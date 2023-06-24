using System;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001AD RID: 429
	// (Invoke) Token: 0x060009A5 RID: 2469
	[Token(Token = "0x20001AD")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void SteamAPIWarningMessageHook_t(int nSeverity, StringBuilder pchDebugText);
}
