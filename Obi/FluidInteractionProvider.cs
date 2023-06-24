using System;
using Il2CppDummyDll;
using Unity.Collections;

namespace Obi
{
	// Token: 0x020000C8 RID: 200
	[Token(Token = "0x20000C8")]
	public struct FluidInteractionProvider : IConstraintProvider
	{
		// Token: 0x060003DB RID: 987 RVA: 0x000038CC File Offset: 0x00001ACC
		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xF9ACD0", Offset = "0xF992D0", VA = "0x180F9ACD0", Slot = "4")]
		public int GetConstraintCount()
		{
			return 0;
		}

		// Token: 0x060003DC RID: 988 RVA: 0x000038E4 File Offset: 0x00001AE4
		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xE51970", Offset = "0xE4FF70", VA = "0x180E51970", Slot = "5")]
		public int GetParticleCount(int constraintIndex)
		{
			return 0;
		}

		// Token: 0x060003DD RID: 989 RVA: 0x000038FC File Offset: 0x00001AFC
		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x279C130", Offset = "0x279A730", VA = "0x18279C130", Slot = "6")]
		public int GetParticle(int constraintIndex, int index)
		{
			return 0;
		}

		// Token: 0x060003DE RID: 990 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x279C170", Offset = "0x279A770", VA = "0x18279C170", Slot = "7")]
		public void WriteSortedConstraint(int constraintIndex, int sortedIndex)
		{
		}

		// Token: 0x04000462 RID: 1122
		[Token(Token = "0x4000462")]
		[FieldOffset(Offset = "0x0")]
		public NativeArray<FluidInteraction> interactions;

		// Token: 0x04000463 RID: 1123
		[Token(Token = "0x4000463")]
		[FieldOffset(Offset = "0x10")]
		public NativeArray<FluidInteraction> sortedInteractions;
	}
}
