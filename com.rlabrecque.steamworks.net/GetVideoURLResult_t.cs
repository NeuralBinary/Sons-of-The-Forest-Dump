using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000FB RID: 251
	[Token(Token = "0x20000FB")]
	[CallbackIdentity(4611)]
	public struct GetVideoURLResult_t
	{
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600086F RID: 2159 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x06000870 RID: 2160 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000018")]
		public string m_rgchURL
		{
			[Token(Token = "0x600086F")]
			[Address(RVA = "0x97DCF0", Offset = "0x97C2F0", VA = "0x18097DCF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000870")]
			[Address(RVA = "0x97DD90", Offset = "0x97C390", VA = "0x18097DD90")]
			set
			{
			}
		}

		// Token: 0x04000302 RID: 770
		[Token(Token = "0x4000302")]
		public const int k_iCallback = 4611;

		// Token: 0x04000303 RID: 771
		[Token(Token = "0x4000303")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x04000304 RID: 772
		[Token(Token = "0x4000304")]
		[FieldOffset(Offset = "0x4")]
		public AppId_t m_unVideoAppID;

		// Token: 0x04000305 RID: 773
		[Token(Token = "0x4000305")]
		[FieldOffset(Offset = "0x8")]
		private byte[] m_rgchURL_;
	}
}
