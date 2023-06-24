using System;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x02000066 RID: 102
	[Token(Token = "0x2000066")]
	public class BurstBendConstraintsBatch : BurstConstraintsBatchImpl, IBendConstraintsBatchImpl, IConstraintsBatchImpl
	{
		// Token: 0x060002B6 RID: 694 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x2774E70", Offset = "0x2773470", VA = "0x182774E70")]
		public BurstBendConstraintsBatch(BurstBendConstraints constraints)
		{
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x2774EE0", Offset = "0x27734E0", VA = "0x182774EE0", Slot = "15")]
		public void SetBendConstraints(ObiNativeIntList particleIndices, ObiNativeFloatList restBends, ObiNativeVector2List bendingStiffnesses, ObiNativeVector2List plasticity, ObiNativeFloatList lambdas, int count)
		{
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00002E04 File Offset: 0x00001004
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x2775110", Offset = "0x2773710", VA = "0x182775110", Slot = "12")]
		public override JobHandle Evaluate(JobHandle inputDeps, float stepTime, float substepTime, int substeps)
		{
			return default(JobHandle);
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00002E1C File Offset: 0x0000101C
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x2775420", Offset = "0x2773A20", VA = "0x182775420", Slot = "13")]
		public override JobHandle Apply(JobHandle inputDeps, float substepTime)
		{
			return default(JobHandle);
		}

		// Token: 0x04000219 RID: 537
		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0x48")]
		private NativeArray<float> restBends;

		// Token: 0x0400021A RID: 538
		[Token(Token = "0x400021A")]
		[FieldOffset(Offset = "0x58")]
		private NativeArray<float2> stiffnesses;

		// Token: 0x0400021B RID: 539
		[Token(Token = "0x400021B")]
		[FieldOffset(Offset = "0x68")]
		private NativeArray<float2> plasticity;

		// Token: 0x02000067 RID: 103
		[Token(Token = "0x2000067")]
		[BurstCompile]
		public struct BendConstraintsBatchJob : IJobParallelFor
		{
			// Token: 0x060002BA RID: 698 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x27756A0", Offset = "0x2773CA0", VA = "0x1827756A0", Slot = "4")]
			public void Execute(int i)
			{
			}

			// Token: 0x0400021C RID: 540
			[Token(Token = "0x400021C")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<int> particleIndices;

			// Token: 0x0400021D RID: 541
			[Token(Token = "0x400021D")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public NativeArray<float2> stiffnesses;

			// Token: 0x0400021E RID: 542
			[Token(Token = "0x400021E")]
			[FieldOffset(Offset = "0x20")]
			[ReadOnly]
			public NativeArray<float2> plasticity;

			// Token: 0x0400021F RID: 543
			[Token(Token = "0x400021F")]
			[FieldOffset(Offset = "0x30")]
			public NativeArray<float> restBends;

			// Token: 0x04000220 RID: 544
			[Token(Token = "0x4000220")]
			[FieldOffset(Offset = "0x40")]
			public NativeArray<float> lambdas;

			// Token: 0x04000221 RID: 545
			[Token(Token = "0x4000221")]
			[FieldOffset(Offset = "0x50")]
			[ReadOnly]
			public NativeArray<float4> positions;

			// Token: 0x04000222 RID: 546
			[Token(Token = "0x4000222")]
			[FieldOffset(Offset = "0x60")]
			[ReadOnly]
			public NativeArray<float> invMasses;

			// Token: 0x04000223 RID: 547
			[Token(Token = "0x4000223")]
			[FieldOffset(Offset = "0x70")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<float4> deltas;

			// Token: 0x04000224 RID: 548
			[Token(Token = "0x4000224")]
			[FieldOffset(Offset = "0x80")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<int> counts;

			// Token: 0x04000225 RID: 549
			[Token(Token = "0x4000225")]
			[FieldOffset(Offset = "0x90")]
			[ReadOnly]
			public float deltaTime;
		}

		// Token: 0x02000068 RID: 104
		[Token(Token = "0x2000068")]
		[BurstCompile]
		public struct ApplyBendConstraintsBatchJob : IJobParallelFor
		{
			// Token: 0x060002BB RID: 699 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x2775B70", Offset = "0x2774170", VA = "0x182775B70", Slot = "4")]
			public void Execute(int i)
			{
			}

			// Token: 0x04000226 RID: 550
			[Token(Token = "0x4000226")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<int> particleIndices;

			// Token: 0x04000227 RID: 551
			[Token(Token = "0x4000227")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public float sorFactor;

			// Token: 0x04000228 RID: 552
			[Token(Token = "0x4000228")]
			[FieldOffset(Offset = "0x18")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<float4> positions;

			// Token: 0x04000229 RID: 553
			[Token(Token = "0x4000229")]
			[FieldOffset(Offset = "0x28")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<float4> deltas;

			// Token: 0x0400022A RID: 554
			[Token(Token = "0x400022A")]
			[FieldOffset(Offset = "0x38")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<int> counts;
		}
	}
}
