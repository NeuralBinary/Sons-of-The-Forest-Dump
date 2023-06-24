using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000E9 RID: 233
	[Token(Token = "0x20000E9")]
	[CallbackIdentity(1103)]
	public struct UserAchievementStored_t
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600086B RID: 2155 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x0600086C RID: 2156 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000016")]
		public string m_rgchAchievementName
		{
			[Token(Token = "0x600086B")]
			[Address(RVA = "0x97DBB0", Offset = "0x97C1B0", VA = "0x18097DBB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600086C")]
			[Address(RVA = "0x97DDD0", Offset = "0x97C3D0", VA = "0x18097DDD0")]
			set
			{
			}
		}

		// Token: 0x040002CC RID: 716
		[Token(Token = "0x40002CC")]
		public const int k_iCallback = 1103;

		// Token: 0x040002CD RID: 717
		[Token(Token = "0x40002CD")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_nGameID;

		// Token: 0x040002CE RID: 718
		[Token(Token = "0x40002CE")]
		[FieldOffset(Offset = "0x8")]
		public bool m_bGroupAchievement;

		// Token: 0x040002CF RID: 719
		[Token(Token = "0x40002CF")]
		[FieldOffset(Offset = "0x10")]
		private byte[] m_rgchAchievementName_;

		// Token: 0x040002D0 RID: 720
		[Token(Token = "0x40002D0")]
		[FieldOffset(Offset = "0x18")]
		public uint m_nCurProgress;

		// Token: 0x040002D1 RID: 721
		[Token(Token = "0x40002D1")]
		[FieldOffset(Offset = "0x1C")]
		public uint m_nMaxProgress;
	}
}
