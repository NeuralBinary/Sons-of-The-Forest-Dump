using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000C6 RID: 198
	[Token(Token = "0x20000C6")]
	[CallbackIdentity(3401)]
	public struct SteamUGCQueryCompleted_t
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000865 RID: 2149 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x06000866 RID: 2150 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000013")]
		public string m_rgchNextCursor
		{
			[Token(Token = "0x6000865")]
			[Address(RVA = "0x97DE30", Offset = "0x97C430", VA = "0x18097DE30")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000866")]
			[Address(RVA = "0x97DEB0", Offset = "0x97C4B0", VA = "0x18097DEB0")]
			set
			{
			}
		}

		// Token: 0x04000249 RID: 585
		[Token(Token = "0x4000249")]
		public const int k_iCallback = 3401;

		// Token: 0x0400024A RID: 586
		[Token(Token = "0x400024A")]
		[FieldOffset(Offset = "0x0")]
		public UGCQueryHandle_t m_handle;

		// Token: 0x0400024B RID: 587
		[Token(Token = "0x400024B")]
		[FieldOffset(Offset = "0x8")]
		public EResult m_eResult;

		// Token: 0x0400024C RID: 588
		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0xC")]
		public uint m_unNumResultsReturned;

		// Token: 0x0400024D RID: 589
		[Token(Token = "0x400024D")]
		[FieldOffset(Offset = "0x10")]
		public uint m_unTotalMatchingResults;

		// Token: 0x0400024E RID: 590
		[Token(Token = "0x400024E")]
		[FieldOffset(Offset = "0x14")]
		public bool m_bCachedData;

		// Token: 0x0400024F RID: 591
		[Token(Token = "0x400024F")]
		[FieldOffset(Offset = "0x18")]
		private byte[] m_rgchNextCursor_;
	}
}
