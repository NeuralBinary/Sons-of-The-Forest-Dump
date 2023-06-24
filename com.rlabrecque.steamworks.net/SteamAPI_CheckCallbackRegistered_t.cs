using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001AE RID: 430
	// (Invoke) Token: 0x060009A9 RID: 2473
	[Token(Token = "0x20001AE")]
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void SteamAPI_CheckCallbackRegistered_t(int iCallbackNum);
}
