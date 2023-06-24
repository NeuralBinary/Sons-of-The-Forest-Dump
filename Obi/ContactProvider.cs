using System;
using Il2CppDummyDll;
using Unity.Collections;

namespace Obi
{
	// Token: 0x020000C7 RID: 199
	[Token(Token = "0x20000C7")]
	public struct ContactProvider : IConstraintProvider
	{
		// Token: 0x060003D7 RID: 983 RVA: 0x00003884 File Offset: 0x00001A84
		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xF9ACD0", Offset = "0xF992D0", VA = "0x180F9ACD0", Slot = "4")]
		public int GetConstraintCount()
		{
			return 0;
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0000389C File Offset: 0x00001A9C
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x279BEB0", Offset = "0x279A4B0", VA = "0x18279BEB0", Slot = "5")]
		public int GetParticleCount(int constraintIndex)
		{
			return 0;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x000038B4 File Offset: 0x00001AB4
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x279BF70", Offset = "0x279A570", VA = "0x18279BF70", Slot = "6")]
		public int GetParticle(int constraintIndex, int index)
		{
			return 0;
		}

		// Token: 0x060003DA RID: 986 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x279C080", Offset = "0x279A680", VA = "0x18279C080", Slot = "7")]
		public void WriteSortedConstraint(int constraintIndex, int sortedIndex)
		{
		}

		// Token: 0x0400045E RID: 1118
		[Token(Token = "0x400045E")]
		[FieldOffset(Offset = "0x0")]
		public NativeArray<BurstContact> contacts;

		// Token: 0x0400045F RID: 1119
		[Token(Token = "0x400045F")]
		[FieldOffset(Offset = "0x10")]
		public NativeArray<BurstContact> sortedContacts;

		// Token: 0x04000460 RID: 1120
		[Token(Token = "0x4000460")]
		[FieldOffset(Offset = "0x20")]
		public NativeArray<int> simplices;

		// Token: 0x04000461 RID: 1121
		[Token(Token = "0x4000461")]
		[FieldOffset(Offset = "0x30")]
		public SimplexCounts simplexCounts;
	}
}
