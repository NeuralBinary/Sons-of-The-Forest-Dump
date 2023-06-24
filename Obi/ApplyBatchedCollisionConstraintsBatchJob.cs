using System;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x02000091 RID: 145
	[Token(Token = "0x2000091")]
	[BurstCompile]
	public struct ApplyBatchedCollisionConstraintsBatchJob : IJobParallelFor
	{
		// Token: 0x06000333 RID: 819 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x2785CB0", Offset = "0x27842B0", VA = "0x182785CB0", Slot = "4")]
		public void Execute(int workItemIndex)
		{
		}

		// Token: 0x04000318 RID: 792
		[Token(Token = "0x4000318")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public NativeArray<BurstContact> contacts;

		// Token: 0x04000319 RID: 793
		[Token(Token = "0x4000319")]
		[FieldOffset(Offset = "0x10")]
		[ReadOnly]
		public NativeList<int> simplices;

		// Token: 0x0400031A RID: 794
		[Token(Token = "0x400031A")]
		[FieldOffset(Offset = "0x20")]
		[ReadOnly]
		public SimplexCounts simplexCounts;

		// Token: 0x0400031B RID: 795
		[Token(Token = "0x400031B")]
		[FieldOffset(Offset = "0x30")]
		[NativeDisableParallelForRestriction]
		public NativeArray<float4> positions;

		// Token: 0x0400031C RID: 796
		[Token(Token = "0x400031C")]
		[FieldOffset(Offset = "0x40")]
		[NativeDisableParallelForRestriction]
		public NativeArray<float4> deltas;

		// Token: 0x0400031D RID: 797
		[Token(Token = "0x400031D")]
		[FieldOffset(Offset = "0x50")]
		[NativeDisableParallelForRestriction]
		public NativeArray<int> counts;

		// Token: 0x0400031E RID: 798
		[Token(Token = "0x400031E")]
		[FieldOffset(Offset = "0x60")]
		[NativeDisableParallelForRestriction]
		public NativeArray<quaternion> orientations;

		// Token: 0x0400031F RID: 799
		[Token(Token = "0x400031F")]
		[FieldOffset(Offset = "0x70")]
		[NativeDisableParallelForRestriction]
		public NativeArray<quaternion> orientationDeltas;

		// Token: 0x04000320 RID: 800
		[Token(Token = "0x4000320")]
		[FieldOffset(Offset = "0x80")]
		[NativeDisableParallelForRestriction]
		public NativeArray<int> orientationCounts;

		// Token: 0x04000321 RID: 801
		[Token(Token = "0x4000321")]
		[FieldOffset(Offset = "0x90")]
		[ReadOnly]
		public Oni.ConstraintParameters constraintParameters;

		// Token: 0x04000322 RID: 802
		[Token(Token = "0x4000322")]
		[FieldOffset(Offset = "0xA0")]
		[ReadOnly]
		public BatchData batchData;
	}
}
