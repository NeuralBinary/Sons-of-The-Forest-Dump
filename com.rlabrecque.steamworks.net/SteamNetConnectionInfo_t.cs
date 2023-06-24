using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000174 RID: 372
	[Token(Token = "0x2000174")]
	public struct SteamNetConnectionInfo_t
	{
		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600087C RID: 2172 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x0600087D RID: 2173 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700001E")]
		public string m_szEndDebug
		{
			[Token(Token = "0x600087C")]
			[Address(RVA = "0x97E210", Offset = "0x97C810", VA = "0x18097E210")]
			get
			{
				return null;
			}
			[Token(Token = "0x600087D")]
			[Address(RVA = "0x97E2B0", Offset = "0x97C8B0", VA = "0x18097E2B0")]
			set
			{
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600087E RID: 2174 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x0600087F RID: 2175 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700001F")]
		public string m_szConnectionDescription
		{
			[Token(Token = "0x600087E")]
			[Address(RVA = "0x97DFF0", Offset = "0x97C5F0", VA = "0x18097DFF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600087F")]
			[Address(RVA = "0x97E2D0", Offset = "0x97C8D0", VA = "0x18097E2D0")]
			set
			{
			}
		}

		// Token: 0x040009C6 RID: 2502
		[Token(Token = "0x40009C6")]
		[FieldOffset(Offset = "0x0")]
		public SteamNetworkingIdentity m_identityRemote;

		// Token: 0x040009C7 RID: 2503
		[Token(Token = "0x40009C7")]
		[FieldOffset(Offset = "0x10")]
		public long m_nUserData;

		// Token: 0x040009C8 RID: 2504
		[Token(Token = "0x40009C8")]
		[FieldOffset(Offset = "0x18")]
		public HSteamListenSocket m_hListenSocket;

		// Token: 0x040009C9 RID: 2505
		[Token(Token = "0x40009C9")]
		[FieldOffset(Offset = "0x20")]
		public SteamNetworkingIPAddr m_addrRemote;

		// Token: 0x040009CA RID: 2506
		[Token(Token = "0x40009CA")]
		[FieldOffset(Offset = "0x30")]
		public ushort m__pad1;

		// Token: 0x040009CB RID: 2507
		[Token(Token = "0x40009CB")]
		[FieldOffset(Offset = "0x34")]
		public SteamNetworkingPOPID m_idPOPRemote;

		// Token: 0x040009CC RID: 2508
		[Token(Token = "0x40009CC")]
		[FieldOffset(Offset = "0x38")]
		public SteamNetworkingPOPID m_idPOPRelay;

		// Token: 0x040009CD RID: 2509
		[Token(Token = "0x40009CD")]
		[FieldOffset(Offset = "0x3C")]
		public ESteamNetworkingConnectionState m_eState;

		// Token: 0x040009CE RID: 2510
		[Token(Token = "0x40009CE")]
		[FieldOffset(Offset = "0x40")]
		public int m_eEndReason;

		// Token: 0x040009CF RID: 2511
		[Token(Token = "0x40009CF")]
		[FieldOffset(Offset = "0x48")]
		private byte[] m_szEndDebug_;

		// Token: 0x040009D0 RID: 2512
		[Token(Token = "0x40009D0")]
		[FieldOffset(Offset = "0x50")]
		private byte[] m_szConnectionDescription_;

		// Token: 0x040009D1 RID: 2513
		[Token(Token = "0x40009D1")]
		[FieldOffset(Offset = "0x58")]
		public int m_nFlags;

		// Token: 0x040009D2 RID: 2514
		[Token(Token = "0x40009D2")]
		[FieldOffset(Offset = "0x60")]
		public uint[] reserved;
	}
}
