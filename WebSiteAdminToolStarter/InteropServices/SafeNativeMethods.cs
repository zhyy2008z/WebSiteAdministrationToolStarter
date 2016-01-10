using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace WebSiteAdministrationToolStarter.InteropServices
{
	[System.Security.SuppressUnmanagedCodeSecurity]
	internal static class SafeNativeMethods
	{
		public const int SAFER_LEVELID_NORMALUSER = 0x20000;

		public const int SAFER_LEVELID_CONSTRAINED = 0x10000;

		public const int SAFER_LEVELID_UNTRUSTED = 0x01000;

		public const int MAX_PATH = 260;

		public const int ERROR_INVALID_PARAMETER = 87;

		public const int SAFER_SCOPEID_USER = 2;

		public const int CREATE_NEW_CONSOLE = 0x00000010;

		[DllImport("advapi32.dll", SetLastError = true)]
		public static extern int SaferCreateLevel(int dwScopeId, int dwLevelId, int OpenFlags, ref IntPtr pLevelHandle, IntPtr lpReserved);

		[DllImport("advapi32.dll", SetLastError = true)]
		public static extern int SaferComputeTokenFromLevel(IntPtr LevelHandle, IntPtr InAccessToken, out IntPtr OutAccessToken, int dwFlags, IntPtr lpReserved);

		[DllImport("advapi32.dll", SetLastError = true)]
		public static extern int SaferCloseLevel(IntPtr hLevelHandle);

		[DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Auto)]
		public static extern int CreateProcessAsUser(IntPtr hToken, string lpApplicationName, string lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, int bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, IntPtr lpCurrentDirectory, ref STARTUPINFO lpStartupInfo, out PROCESS_INFORMATION lpProcessInformation);

		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern int CloseHandle(IntPtr hObject);
	}
}
