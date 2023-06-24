using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000070 RID: 112
	[Token(Token = "0x2000070")]
	[CallbackIdentity(2802)]
	public struct SteamInputDeviceDisconnected_t
	{
		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000112")]
		public const int k_iCallback = 2802;

		// Token: 0x04000113 RID: 275
		[Token(Token = "0x4000113")]
		[FieldOffset(Offset = "0x0")]
		public InputHandle_t m_ulDisconnectedDeviceHandle;
	}
}
