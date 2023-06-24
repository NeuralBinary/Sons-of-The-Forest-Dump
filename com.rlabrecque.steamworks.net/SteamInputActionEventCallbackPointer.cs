using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001C0 RID: 448
	// (Invoke) Token: 0x06000A4E RID: 2638
	[Token(Token = "0x20001C0")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void SteamInputActionEventCallbackPointer(IntPtr SteamInputActionEvent);
}
