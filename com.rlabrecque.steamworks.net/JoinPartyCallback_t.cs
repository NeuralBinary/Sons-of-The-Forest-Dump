using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200008A RID: 138
	[Token(Token = "0x200008A")]
	[CallbackIdentity(5301)]
	public struct JoinPartyCallback_t
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000851 RID: 2129 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x06000852 RID: 2130 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000009")]
		public string m_rgchConnectString
		{
			[Token(Token = "0x6000851")]
			[Address(RVA = "0x97DE30", Offset = "0x97C430", VA = "0x18097DE30")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000852")]
			[Address(RVA = "0x97DEB0", Offset = "0x97C4B0", VA = "0x18097DEB0")]
			set
			{
			}
		}

		// Token: 0x04000184 RID: 388
		[Token(Token = "0x4000184")]
		public const int k_iCallback = 5301;

		// Token: 0x04000185 RID: 389
		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x04000186 RID: 390
		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x8")]
		public PartyBeaconID_t m_ulBeaconID;

		// Token: 0x04000187 RID: 391
		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x10")]
		public CSteamID m_SteamIDBeaconOwner;

		// Token: 0x04000188 RID: 392
		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x18")]
		private byte[] m_rgchConnectString_;
	}
}
