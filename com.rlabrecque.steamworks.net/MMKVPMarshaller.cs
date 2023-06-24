using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000184 RID: 388
	[Token(Token = "0x2000184")]
	public class MMKVPMarshaller
	{
		// Token: 0x060008C7 RID: 2247 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x9827F0", Offset = "0x980DF0", VA = "0x1809827F0")]
		public MMKVPMarshaller(MatchMakingKeyValuePair_t[] filters)
		{
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x982BA0", Offset = "0x9811A0", VA = "0x180982BA0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x00007BEC File Offset: 0x00005DEC
		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x982C50", Offset = "0x981250", VA = "0x180982C50")]
		public static implicit operator IntPtr(MMKVPMarshaller that)
		{
			return 0;
		}

		// Token: 0x040009F9 RID: 2553
		[Token(Token = "0x40009F9")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_pNativeArray;

		// Token: 0x040009FA RID: 2554
		[Token(Token = "0x40009FA")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_pArrayEntries;
	}
}
