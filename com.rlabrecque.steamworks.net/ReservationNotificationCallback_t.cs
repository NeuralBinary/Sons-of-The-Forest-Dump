using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200008C RID: 140
	[Token(Token = "0x200008C")]
	[CallbackIdentity(5303)]
	public struct ReservationNotificationCallback_t
	{
		// Token: 0x0400018C RID: 396
		[Token(Token = "0x400018C")]
		public const int k_iCallback = 5303;

		// Token: 0x0400018D RID: 397
		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x0")]
		public PartyBeaconID_t m_ulBeaconID;

		// Token: 0x0400018E RID: 398
		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x8")]
		public CSteamID m_steamIDJoiner;
	}
}
