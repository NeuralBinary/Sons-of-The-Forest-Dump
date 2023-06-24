using System;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x02000074 RID: 116
	[Token(Token = "0x2000074")]
	[BurstCompile]
	public struct ApplyCollisionConstraintsBatchJob : IJob
	{
		// Token: 0x060002ED RID: 749 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x2778E80", Offset = "0x2777480", VA = "0x182778E80", Slot = "4")]
		public void Execute()
		{
		}

		// Token: 0x04000259 RID: 601
		[Token(Token = "0x4000259")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NativeArray<BurstContact> contacts;

		// Token: 0x0400025A RID: 602
		[Token(Token = "0x400025A")]
		[FieldOffset(Offset = "0x10")]
		[ReadOnly]
		public NativeList<int> simplices;

		// Token: 0x0400025B RID: 603
		[Token(Token = "0x400025B")]
		[FieldOffset(Offset = "0x20")]
		[ReadOnly]
		public SimplexCounts simplexCounts;

		// Token: 0x0400025C RID: 604
		[Token(Token = "0x400025C")]
		[FieldOffset(Offset = "0x30")]
		[NativeDisableParallelForRestriction]
		public NativeArray<float4> positions;

		// Token: 0x0400025D RID: 605
		[Token(Token = "0x400025D")]
		[FieldOffset(Offset = "0x40")]
		[NativeDisableParallelForRestriction]
		public NativeArray<float4> deltas;

		// Token: 0x0400025E RID: 606
		[Token(Token = "0x400025E")]
		[FieldOffset(Offset = "0x50")]
		[NativeDisableParallelForRestriction]
		public NativeArray<int> counts;

		// Token: 0x0400025F RID: 607
		[Token(Token = "0x400025F")]
		[FieldOffset(Offset = "0x60")]
		[NativeDisableParallelForRestriction]
		public NativeArray<quaternion> orientations;

		// Token: 0x04000260 RID: 608
		[Token(Token = "0x4000260")]
		[FieldOffset(Offset = "0x70")]
		[NativeDisableParallelForRestriction]
		public NativeArray<quaternion> orientationDeltas;

		// Token: 0x04000261 RID: 609
		[Token(Token = "0x4000261")]
		[FieldOffset(Offset = "0x80")]
		[NativeDisableParallelForRestriction]
		public NativeArray<int> orientationCounts;

		// Token: 0x04000262 RID: 610
		[Token(Token = "0x4000262")]
		[FieldOffset(Offset = "0x90")]
		[ReadOnly]
		public Oni.ConstraintParameters constraintParameters;
	}
}
