using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000E3 RID: 227
	[Token(Token = "0x20000E3")]
	[CallbackIdentity(164)]
	public struct GameWebCallback_t
	{
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000867 RID: 2151 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x06000868 RID: 2152 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000014")]
		public string m_szURL
		{
			[Token(Token = "0x6000867")]
			[Address(RVA = "0x97DC50", Offset = "0x97C250", VA = "0x18097DC50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000868")]
			[Address(RVA = "0x97E1D0", Offset = "0x97C7D0", VA = "0x18097E1D0")]
			set
			{
			}
		}

		// Token: 0x040002B2 RID: 690
		[Token(Token = "0x40002B2")]
		public const int k_iCallback = 164;

		// Token: 0x040002B3 RID: 691
		[Token(Token = "0x40002B3")]
		[FieldOffset(Offset = "0x0")]
		private byte[] m_szURL_;
	}
}
