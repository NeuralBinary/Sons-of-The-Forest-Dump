using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000EF RID: 239
	[Token(Token = "0x20000EF")]
	[CallbackIdentity(1109)]
	public struct UserAchievementIconFetched_t
	{
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600086D RID: 2157 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x0600086E RID: 2158 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000017")]
		public string m_rgchAchievementName
		{
			[Token(Token = "0x600086D")]
			[Address(RVA = "0x97DCF0", Offset = "0x97C2F0", VA = "0x18097DCF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600086E")]
			[Address(RVA = "0x97DDF0", Offset = "0x97C3F0", VA = "0x18097DDF0")]
			set
			{
			}
		}

		// Token: 0x040002E5 RID: 741
		[Token(Token = "0x40002E5")]
		public const int k_iCallback = 1109;

		// Token: 0x040002E6 RID: 742
		[Token(Token = "0x40002E6")]
		[FieldOffset(Offset = "0x0")]
		public CGameID m_nGameID;

		// Token: 0x040002E7 RID: 743
		[Token(Token = "0x40002E7")]
		[FieldOffset(Offset = "0x8")]
		private byte[] m_rgchAchievementName_;

		// Token: 0x040002E8 RID: 744
		[Token(Token = "0x40002E8")]
		[FieldOffset(Offset = "0x10")]
		public bool m_bAchieved;

		// Token: 0x040002E9 RID: 745
		[Token(Token = "0x40002E9")]
		[FieldOffset(Offset = "0x14")]
		public int m_nIconHandle;
	}
}
