using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSiteAdministrationToolStarter.InteropServices;
using System.Runtime.InteropServices;

namespace WebSiteAdministrationToolStarter
{
	/// <summary>
	/// 该类是平台调用的包装类，主要用于降权启动一个应用程序
	/// </summary>
	public class DropRightsProcess
	{
		static string getCommandLine(string programFullName, string commandArgs)
		{

			string commandLine = string.Format("\"{0}\"", programFullName);
			if (!string.IsNullOrEmpty(commandArgs))
			{
				commandLine += " " + commandArgs;
			}
			return commandLine;
		}

		int getRightLevel(string level)
		{
			int saferLevel;
			switch (level.ToLower())
			{
				case "c":
					saferLevel = SafeNativeMethods.SAFER_LEVELID_CONSTRAINED;
					break;
				case "u":
					saferLevel = SafeNativeMethods.SAFER_LEVELID_UNTRUSTED;
					break;
				default://"n"
					saferLevel = SafeNativeMethods.SAFER_LEVELID_NORMALUSER;
					break;
			}
			return saferLevel;
		}

		/// <summary>
		/// 以某一权限开始执行一个进程
		/// </summary>
		/// <param name="programFullName">程序路径（全名）</param>
		/// <param name="level">级别（c/受限的，u/不信任的，n/正常用户）</param>
		/// <param name="commandArgs">命令行参数</param>
		/// <returns></returns>
		public int StartProcess(string programFullName, string level, string commandArgs, bool isHide)
		{
			int saferLevel = getRightLevel(level);
			int status = 0;
			IntPtr authzLevel = IntPtr.Zero;
			if (SafeNativeMethods.SaferCreateLevel(SafeNativeMethods.SAFER_SCOPEID_USER, saferLevel, 0, ref authzLevel, IntPtr.Zero) != 0)
			{
				IntPtr token = IntPtr.Zero;
				if (SafeNativeMethods.SaferComputeTokenFromLevel(authzLevel, IntPtr.Zero, out token, 0, IntPtr.Zero) != 0)
				{
					STARTUPINFO si = new STARTUPINFO();
					si.dwFlags = STARTF.STARTF_USESHOWWINDOW;
					si.wShowWindow = isHide ? WindowShowStyle.Hide : WindowShowStyle.ShowNormal;
					si.cb = Marshal.SizeOf(typeof(STARTUPINFO));

					PROCESS_INFORMATION pi;
					if (SafeNativeMethods.CreateProcessAsUser(token, null, getCommandLine(programFullName, commandArgs), IntPtr.Zero, IntPtr.Zero, 0, SafeNativeMethods.CREATE_NEW_CONSOLE, IntPtr.Zero, IntPtr.Zero, ref si, out pi) != 0)//这里CreateProcessAsUser的lpApplicationName置空，仅使用commandLine参数来启动程序。
					{

						SafeNativeMethods.CloseHandle(pi.hProcess);

						SafeNativeMethods.CloseHandle(pi.hThread);
					}
					else
					{
						status = Marshal.GetLastWin32Error();
					}
				}
				else
				{
					status = Marshal.GetLastWin32Error();
				}

				SafeNativeMethods.SaferCloseLevel(authzLevel);
			}
			else
			{
				status = Marshal.GetLastWin32Error();
			}

			return status;
		}

		/// <summary>
		/// 以正常用户权限开始执行一个进程
		/// </summary>
		/// <param name="programFullName">程序路径（全名）</param>
		/// <param name="commandArgs">命令行参数</param>
		/// <returns></returns>
		public int StartProcess(string programFullName, string commandArgs, bool isHide)
		{
			return StartProcess(programFullName, string.Empty, commandArgs, isHide);
		}
	}
}
