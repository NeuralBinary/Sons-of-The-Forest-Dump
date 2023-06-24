using System;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x02000071 RID: 113
	[Token(Token = "0x2000071")]
	public class BurstChainConstraintsBatch : BurstConstraintsBatchImpl, IChainConstraintsBatchImpl, IConstraintsBatchImpl
	{
		// Token: 0x060002E7 RID: 743 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x2777900", Offset = "0x2775F00", VA = "0x182777900")]
		public BurstChainConstraintsBatch(BurstChainConstraints constraints)
		{
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x2777970", Offset = "0x2775F70", VA = "0x182777970", Slot = "15")]
		public void SetChainConstraints(ObiNativeIntList particleIndices, ObiNativeVector2List restLengths, ObiNativeIntList firstIndex, ObiNativeIntList numIndices, int count)
		{
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00002F54 File Offset: 0x00001154
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x2777B30", Offset = "0x2776130", VA = "0x182777B30", Slot = "12")]
		public override JobHandle Evaluate(JobHandle inputDeps, float stepTime, float substepTime, int substeps)
		{
			return default(JobHandle);
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00002F6C File Offset: 0x0000116C
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x2777E00", Offset = "0x2776400", VA = "0x182777E00", Slot = "13")]
		public override JobHandle Apply(JobHandle inputDeps, float substepTime)
		{
			return default(JobHandle);
		}

		// Token: 0x04000247 RID: 583
		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0x48")]
		private NativeArray<int> firstIndex;

		// Token: 0x04000248 RID: 584
		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0x58")]
		private NativeArray<int> numIndices;

		// Token: 0x04000249 RID: 585
		[Token(Token = "0x4000249")]
		[FieldOffset(Offset = "0x68")]
		private NativeArray<float2> restLengths;

		// Token: 0x02000072 RID: 114
		[Token(Token = "0x2000072")]
		[BurstCompile]
		public struct ChainConstraintsBatchJob : IJobParallelFor
		{
			// Token: 0x060002EB RID: 747 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x60002EB")]
			[Address(RVA = "0x27780C0", Offset = "0x27766C0", VA = "0x1827780C0", Slot = "4")]
			public void Execute(int c)
			{
			}

			// Token: 0x0400024A RID: 586
			[Token(Token = "0x400024A")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<int> particleIndices;

			// Token: 0x0400024B RID: 587
			[Token(Token = "0x400024B")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public NativeArray<int> firstIndex;

			// Token: 0x0400024C RID: 588
			[Token(Token = "0x400024C")]
			[FieldOffset(Offset = "0x20")]
			[ReadOnly]
			public NativeArray<int> numIndices;

			// Token: 0x0400024D RID: 589
			[Token(Token = "0x400024D")]
			[FieldOffset(Offset = "0x30")]
			[ReadOnly]
			public NativeArray<float2> restLengths;

			// Token: 0x0400024E RID: 590
			[Token(Token = "0x400024E")]
			[FieldOffset(Offset = "0x40")]
			[ReadOnly]
			public NativeArray<float4> positions;

			// Token: 0x0400024F RID: 591
			[Token(Token = "0x400024F")]
			[FieldOffset(Offset = "0x50")]
			[ReadOnly]
			public NativeArray<float> invMasses;

			// Token: 0x04000250 RID: 592
			[Token(Token = "0x4000250")]
			[FieldOffset(Offset = "0x60")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<float4> deltas;

			// Token: 0x04000251 RID: 593
			[Token(Token = "0x4000251")]
			[FieldOffset(Offset = "0x70")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<int> counts;
		}

		// Token: 0x02000073 RID: 115
		[Token(Token = "0x2000073")]
		[BurstCompile]
		public struct ApplyChainConstraintsBatchJob : IJobParallelFor
		{
			// Token: 0x060002EC RID: 748 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x60002EC")]
			[Address(RVA = "0x2778D30", Offset = "0x2777330", VA = "0x182778D30", Slot = "4")]
			public void Execute(int i)
			{
			}

			// Token: 0x04000252 RID: 594
			[Token(Token = "0x4000252")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<int> particleIndices;

			// Token: 0x04000253 RID: 595
			[Token(Token = "0x4000253")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public NativeArray<int> firstIndex;

			// Token: 0x04000254 RID: 596
			[Token(Token = "0x4000254")]
			[FieldOffset(Offset = "0x20")]
			[ReadOnly]
			public NativeArray<int> numIndices;

			// Token: 0x04000255 RID: 597
			[Token(Token = "0x4000255")]
			[FieldOffset(Offset = "0x30")]
			[ReadOnly]
			public float sorFactor;

			// Token: 0x04000256 RID: 598
			[Token(Token = "0x4000256")]
			[FieldOffset(Offset = "0x38")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<float4> positions;

			// Token: 0x04000257 RID: 599
			[Token(Token = "0x4000257")]
			[FieldOffset(Offset = "0x48")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<float4> deltas;

			// Token: 0x04000258 RID: 600
			[Token(Token = "0x4000258")]
			[FieldOffset(Offset = "0x58")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<int> counts;
		}
	}
}
