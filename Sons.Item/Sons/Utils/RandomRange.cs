using System;
using Il2CppDummyDll;

namespace Sons.Utils
{
	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	[Serializable]
	public class RandomRange
	{
		// Token: 0x06000027 RID: 39 RVA: 0x00002190 File Offset: 0x00000390
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x30AE500", Offset = "0x30ACB00", VA = "0x1830AE500")]
		public static implicit operator int(RandomRange rr)
		{
			return 0;
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000028 RID: 40 RVA: 0x000021A8 File Offset: 0x000003A8
		[Token(Token = "0x1700000E")]
		public int Average
		{
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x30AE590", Offset = "0x30ACB90", VA = "0x1830AE590")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x30AE5C0", Offset = "0x30ACBC0", VA = "0x1830AE5C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public RandomRange()
		{
		}

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x10")]
		public int _min;

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x14")]
		public int _max;
	}
}
