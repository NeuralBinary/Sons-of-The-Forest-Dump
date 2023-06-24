using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000172 RID: 370
	[Token(Token = "0x2000172")]
	public struct MatchMakingKeyValuePair_t
	{
		// Token: 0x0600087B RID: 2171 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600087B")]
		[Address(RVA = "0x5F84C0", Offset = "0x5F6AC0", VA = "0x1805F84C0")]
		private MatchMakingKeyValuePair_t(string strKey, string strValue)
		{
		}

		// Token: 0x040009C0 RID: 2496
		[Token(Token = "0x40009C0")]
		[FieldOffset(Offset = "0x0")]
		public string m_szKey;

		// Token: 0x040009C1 RID: 2497
		[Token(Token = "0x40009C1")]
		[FieldOffset(Offset = "0x8")]
		public string m_szValue;
	}
}
