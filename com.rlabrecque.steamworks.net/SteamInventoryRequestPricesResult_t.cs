using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000077 RID: 119
	[Token(Token = "0x2000077")]
	[CallbackIdentity(4705)]
	public struct SteamInventoryRequestPricesResult_t
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600084F RID: 2127 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x06000850 RID: 2128 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000008")]
		public string m_rgchCurrency
		{
			[Token(Token = "0x600084F")]
			[Address(RVA = "0x97DCF0", Offset = "0x97C2F0", VA = "0x18097DCF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000850")]
			[Address(RVA = "0x97DE10", Offset = "0x97C410", VA = "0x18097DE10")]
			set
			{
			}
		}

		// Token: 0x0400012B RID: 299
		[Token(Token = "0x400012B")]
		public const int k_iCallback = 4705;

		// Token: 0x0400012C RID: 300
		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_result;

		// Token: 0x0400012D RID: 301
		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x8")]
		private byte[] m_rgchCurrency_;
	}
}
