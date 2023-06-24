using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000A3 RID: 163
	[Token(Token = "0x20000A3")]
	public class ConstantIndexMap : IIndexMap
	{
		// Token: 0x0600037A RID: 890 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600037A")]
		[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
		public ConstantIndexMap(int c)
		{
		}

		// Token: 0x17000071 RID: 113
		[Token(Token = "0x17000071")]
		public int this[int index]
		{
			[Token(Token = "0x600037B")]
			[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0400029E RID: 670
		[Token(Token = "0x400029E")]
		[FieldOffset(Offset = "0x10")]
		public int Constant;
	}
}
