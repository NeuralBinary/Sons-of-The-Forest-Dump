using System;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x0200006A RID: 106
	[Token(Token = "0x200006A")]
	public class BurstBendTwistConstraintsBatch : BurstConstraintsBatchImpl, IBendTwistConstraintsBatchImpl, IConstraintsBatchImpl
	{
		// Token: 0x060002BF RID: 703 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x2776060", Offset = "0x2774660", VA = "0x182776060")]
		public BurstBendTwistConstraintsBatch(BurstBendTwistConstraints constraints)
		{
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x27760D0", Offset = "0x27746D0", VA = "0x1827760D0", Slot = "15")]
		public void SetBendTwistConstraints(ObiNativeIntList orientationIndices, ObiNativeQuaternionList restDarboux, ObiNativeVector3List stiffnesses, ObiNativeVector2List plasticity, ObiNativeFloatList lambdas, int count)
		{
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00002E34 File Offset: 0x00001034
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x2776310", Offset = "0x2774910", VA = "0x182776310", Slot = "12")]
		public override JobHandle Evaluate(JobHandle inputDeps, float stepTime, float substepTime, int substeps)
		{
			return default(JobHandle);
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00002E4C File Offset: 0x0000104C
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x2776670", Offset = "0x2774C70", VA = "0x182776670", Slot = "13")]
		public override JobHandle Apply(JobHandle inputDeps, float substepTime)
		{
			return default(JobHandle);
		}

		// Token: 0x0400022B RID: 555
		[Token(Token = "0x400022B")]
		[FieldOffset(Offset = "0x48")]
		private NativeArray<int> orientationIndices;

		// Token: 0x0400022C RID: 556
		[Token(Token = "0x400022C")]
		[FieldOffset(Offset = "0x58")]
		private NativeArray<quaternion> restDarboux;

		// Token: 0x0400022D RID: 557
		[Token(Token = "0x400022D")]
		[FieldOffset(Offset = "0x68")]
		private NativeArray<float3> stiffnesses;

		// Token: 0x0400022E RID: 558
		[Token(Token = "0x400022E")]
		[FieldOffset(Offset = "0x78")]
		private NativeArray<float2> plasticity;

		// Token: 0x0200006B RID: 107
		[Token(Token = "0x200006B")]
		[BurstCompile]
		public struct BendTwistConstraintsBatchJob : IJobParallelFor
		{
			// Token: 0x060002C3 RID: 707 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x27768F0", Offset = "0x2774EF0", VA = "0x1827768F0", Slot = "4")]
			public void Execute(int i)
			{
			}

			// Token: 0x0400022F RID: 559
			[Token(Token = "0x400022F")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<int> orientationIndices;

			// Token: 0x04000230 RID: 560
			[Token(Token = "0x4000230")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public NativeArray<float3> stiffnesses;

			// Token: 0x04000231 RID: 561
			[Token(Token = "0x4000231")]
			[FieldOffset(Offset = "0x20")]
			[ReadOnly]
			public NativeArray<float2> plasticity;

			// Token: 0x04000232 RID: 562
			[Token(Token = "0x4000232")]
			[FieldOffset(Offset = "0x30")]
			public NativeArray<quaternion> restDarboux;

			// Token: 0x04000233 RID: 563
			[Token(Token = "0x4000233")]
			[FieldOffset(Offset = "0x40")]
			public NativeArray<float3> lambdas;

			// Token: 0x04000234 RID: 564
			[Token(Token = "0x4000234")]
			[FieldOffset(Offset = "0x50")]
			[ReadOnly]
			public NativeArray<quaternion> orientations;

			// Token: 0x04000235 RID: 565
			[Token(Token = "0x4000235")]
			[FieldOffset(Offset = "0x60")]
			[ReadOnly]
			public NativeArray<float> invRotationalMasses;

			// Token: 0x04000236 RID: 566
			[Token(Token = "0x4000236")]
			[FieldOffset(Offset = "0x70")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<quaternion> orientationDeltas;

			// Token: 0x04000237 RID: 567
			[Token(Token = "0x4000237")]
			[FieldOffset(Offset = "0x80")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<int> orientationCounts;

			// Token: 0x04000238 RID: 568
			[Token(Token = "0x4000238")]
			[FieldOffset(Offset = "0x90")]
			[ReadOnly]
			public float deltaTime;
		}

		// Token: 0x0200006C RID: 108
		[Token(Token = "0x200006C")]
		[BurstCompile]
		public struct ApplyBendTwistConstraintsBatchJob : IJobParallelFor
		{
			// Token: 0x060002C4 RID: 708 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x2776F30", Offset = "0x2775530", VA = "0x182776F30", Slot = "4")]
			public void Execute(int i)
			{
			}

			// Token: 0x04000239 RID: 569
			[Token(Token = "0x4000239")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<int> orientationIndices;

			// Token: 0x0400023A RID: 570
			[Token(Token = "0x400023A")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public float sorFactor;

			// Token: 0x0400023B RID: 571
			[Token(Token = "0x400023B")]
			[FieldOffset(Offset = "0x18")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<quaternion> orientations;

			// Token: 0x0400023C RID: 572
			[Token(Token = "0x400023C")]
			[FieldOffset(Offset = "0x28")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<quaternion> orientationDeltas;

			// Token: 0x0400023D RID: 573
			[Token(Token = "0x400023D")]
			[FieldOffset(Offset = "0x38")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<int> orientationCounts;
		}
	}
}
