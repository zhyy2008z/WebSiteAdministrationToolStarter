using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace WebSiteAdministrationToolStarter.InteropServices
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct STARTUPINFO
	{
		public int cb;
		public string lpReserved;
		public string lpDesktop;
		public string lpTitle;
		public int dwX;
		public int dwY;
		public int dwXSize;
		public int dwYSize;
		public int dwXCountChars;
		public int dwYCountChars;
		public int dwFillAttribute;
		public STARTF dwFlags;
		public WindowShowStyle wShowWindow;
		public int cbReserved2;
		public int pReserved2;
		public int hStdInput;
		public int hStdOutput;
		public int hStdError;
	}
}
