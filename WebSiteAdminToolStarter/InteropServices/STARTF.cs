using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSiteAdministrationToolStarter.InteropServices
{
	internal enum STARTF : uint
	{
		/// <summary>
		/// Indicates that the cursor is in feedback mode for two seconds after CreateProcess is called. The Working in Background cursor is displayed (see the Pointers tab in the Mouse control panel utility). 
		/// <para>If during those two seconds the process makes the first GUI call, the system gives five more seconds to the process. If during those five seconds the process shows a window, the system gives five more seconds to the process to finish drawing the window.
		/// </para>
		///<para>The system turns the feedback cursor off after the first call to GetMessage, regardless of whether the process is drawing.
		///</para>
		/// </summary>
		STARTF_FORCEONFEEDBACK = 0x00000040,
		/// <summary>
		/// Indicates that the feedback cursor is forced off while the process is starting. The Normal Select cursor is displayed.
		/// </summary>
		STARTF_FORCEOFFFEEDBACK = 0x00000080,
		/// <summary>
		/// Indicates that any windows created by the process cannot be pinned on the taskbar.
		/// <para>This flag must be combined with STARTF_TITLEISAPPID.</para>
		/// </summary>
		STARTF_PREVENTPINNING = 0x00002000,
		/// <summary>
		/// Indicates that the process should be run in full-screen mode, rather than in windowed mode. 
		/// <para>This flag is only valid for console applications running on an x86 computer.</para>
		/// </summary>
		STARTF_RUNFULLSCREEN = 0x00000020,
		/// <summary>
		/// The lpTitle member contains an AppUserModelID. This identifier controls how the taskbar and Start menu present the application, and enables it to be associated with the correct shortcuts and Jump Lists. Generally, applications will use the SetCurrentProcessExplicitAppUserModelID and GetCurrentProcessExplicitAppUserModelID functions instead of setting this flag. For more information, see Application User Model IDs.
		/// <para>If STARTF_PREVENTPINNING is used, application windows cannot be pinned on the taskbar. The use of any AppUserModelID-related window properties by the application overrides this setting for that window only.</para>
		/// <para>This flag cannot be used with STARTF_TITLEISLINKNAME.</para>
		/// </summary>
		STARTF_TITLEISAPPID = 0x00001000,
		/// <summary>
		/// The lpTitle member contains the path of the shortcut file (.lnk) that the user invoked to start this process. This is typically set by the shell when a .lnk file pointing to the launched application is invoked. Most applications will not need to set this value.
		/// <para>This flag cannot be used with STARTF_TITLEISAPPID.</para>
		/// </summary>
		STARTF_TITLEISLINKNAME = 0x00000800,
		/// <summary>
		/// The dwXCountChars and dwYCountChars members contain additional information.
		/// </summary>
		STARTF_USECOUNTCHARS = 0x00000008,
		/// <summary>
		/// The dwFillAttribute member contains additional information.
		/// </summary>
		STARTF_USEFILLATTRIBUTE = 0x00000010,
		/// <summary>
		/// The hStdInput member contains additional information. 
		/// <para>This flag cannot be used with STARTF_USESTDHANDLES.</para>
		/// </summary>
		STARTF_USEHOTKEY = 0x00000200,
		/// <summary>
		/// The dwX and dwY members contain additional information.
		/// </summary>
		STARTF_USEPOSITION = 0x00000004,
		/// <summary>
		/// The wShowWindow member contains additional information.
		/// </summary>
		STARTF_USESHOWWINDOW = 0x00000001,
		/// <summary>
		/// The dwXSize and dwYSize members contain additional information.
		/// </summary>
		STARTF_USESIZE = 0x00000002,
		/// <summary>
		/// The hStdInput, hStdOutput, and hStdError members contain additional information. 
		/// <para>If this flag is specified when calling one of the process creation functions, the handles must be inheritable and the function's bInheritHandles parameter must be set to TRUE. For more information, see Handle Inheritance.</para>
		/// <para>If this flag is specified when calling the GetStartupInfo function, these members are either the handle value specified during process creation or INVALID_HANDLE_VALUE.</para>
		/// <para>Handles must be closed with CloseHandle when they are no longer needed.</para>
		/// <para>This flag cannot be used with STARTF_USEHOTKEY.</para>
		/// </summary>
		STARTF_USESTDHANDLES = 0x00000100
	}
}
