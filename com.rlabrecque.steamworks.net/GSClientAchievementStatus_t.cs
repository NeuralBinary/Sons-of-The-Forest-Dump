using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200004B RID: 75
	[Token(Token = "0x200004B")]
	[CallbackIdentity(206)]
	public struct GSClientAchievementStatus_t
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600084D RID: 2125 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x0600084E RID: 2126 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000007")]
		public string m_pchAchievement
		{
			[Token(Token = "0x600084D")]
			[Address(RVA = "0x97DCF0", Offset = "0x97C2F0", VA = "0x18097DCF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600084E")]
			[Address(RVA = "0x97DDF0", Offset = "0x97C3F0", VA = "0x18097DDF0")]
			set
			{
			}
		}

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		public const int k_iCallback = 206;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_SteamID;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x8")]
		private byte[] m_pchAchievement_;

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x10")]
		public bool m_bUnlocked;
	}
}
