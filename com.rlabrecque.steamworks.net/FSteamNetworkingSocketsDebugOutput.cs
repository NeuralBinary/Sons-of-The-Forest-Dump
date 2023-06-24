using System;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001CF RID: 463
	// (Invoke) Token: 0x06000AAA RID: 2730
	[Token(Token = "0x20001CF")]
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public delegate void FSteamNetworkingSocketsDebugOutput(ESteamNetworkingSocketsDebugOutputType nType, StringBuilder pszMsg);
}
