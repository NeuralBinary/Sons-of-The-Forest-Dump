using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000A2 RID: 162
	[Token(Token = "0x20000A2")]
	public class ShiftIndexMap : IIndexMap
	{
		// Token: 0x06000378 RID: 888 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000378")]
		[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
		public ShiftIndexMap(int n)
		{
		}

		// Token: 0x17000070 RID: 112
		[Token(Token = "0x17000070")]
		public int this[int index]
		{
			[Token(Token = "0x6000379")]
			[Address(RVA = "0x1F44390", Offset = "0x1F42990", VA = "0x181F44390", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0400029D RID: 669
		[Token(Token = "0x400029D")]
		[FieldOffset(Offset = "0x10")]
		public int Shift;
	}
}
