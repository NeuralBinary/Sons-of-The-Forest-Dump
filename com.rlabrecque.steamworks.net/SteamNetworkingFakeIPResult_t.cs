using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000FD RID: 253
	[Token(Token = "0x20000FD")]
	[CallbackIdentity(1223)]
	public struct SteamNetworkingFakeIPResult_t
	{
		// Token: 0x04000309 RID: 777
		[Token(Token = "0x4000309")]
		public const int k_iCallback = 1223;

		// Token: 0x0400030A RID: 778
		[Token(Token = "0x400030A")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x0400030B RID: 779
		[Token(Token = "0x400030B")]
		[FieldOffset(Offset = "0x8")]
		public SteamNetworkingIdentity m_identity;

		// Token: 0x0400030C RID: 780
		[Token(Token = "0x400030C")]
		[FieldOffset(Offset = "0x18")]
		public uint m_unIP;

		// Token: 0x0400030D RID: 781
		[Token(Token = "0x400030D")]
		[FieldOffset(Offset = "0x20")]
		public ushort[] m_unPorts;
	}
}
