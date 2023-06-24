using System;
using Il2CppDummyDll;

namespace Sons.Utils
{
	// Token: 0x02000017 RID: 23
	[Token(Token = "0x2000017")]
	[Serializable]
	public class RandomRangeF
	{
		// Token: 0x0600002B RID: 43 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2A89A90", Offset = "0x2A88090", VA = "0x182A89A90")]
		public RandomRangeF(float min = 0f, float max = 0f)
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000021C0 File Offset: 0x000003C0
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x30AE640", Offset = "0x30ACC40", VA = "0x1830AE640")]
		public static implicit operator float(RandomRangeF rr)
		{
			return 0f;
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600002D RID: 45 RVA: 0x000021D8 File Offset: 0x000003D8
		[Token(Token = "0x1700000F")]
		public float Average
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x30AE670", Offset = "0x30ACC70", VA = "0x1830AE670")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x30AE690", Offset = "0x30ACC90", VA = "0x1830AE690", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x10")]
		public float _min;

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x14")]
		public float _max;
	}
}
