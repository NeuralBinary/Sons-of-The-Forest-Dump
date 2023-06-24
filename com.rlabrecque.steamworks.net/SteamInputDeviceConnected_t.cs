using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200006F RID: 111
	[Token(Token = "0x200006F")]
	[CallbackIdentity(2801)]
	public struct SteamInputDeviceConnected_t
	{
		// Token: 0x04000110 RID: 272
		[Token(Token = "0x4000110")]
		public const int k_iCallback = 2801;

		// Token: 0x04000111 RID: 273
		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x0")]
		public InputHandle_t m_ulConnectedDeviceHandle;
	}
}
