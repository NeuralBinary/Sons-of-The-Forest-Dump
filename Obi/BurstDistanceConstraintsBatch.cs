using System;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x0200008E RID: 142
	[Token(Token = "0x200008E")]
	public class BurstDistanceConstraintsBatch : BurstConstraintsBatchImpl, IDistanceConstraintsBatchImpl, IConstraintsBatchImpl
	{
		// Token: 0x0600032D RID: 813 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600032D")]
		[Address(RVA = "0x2785000", Offset = "0x2783600", VA = "0x182785000")]
		public BurstDistanceConstraintsBatch(BurstDistanceConstraints constraints)
		{
		}

		// Token: 0x0600032E RID: 814 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x2785070", Offset = "0x2783670", VA = "0x182785070", Slot = "15")]
		public void SetDistanceConstraints(ObiNativeIntList particleIndices, ObiNativeFloatList restLengths, ObiNativeVector2List stiffnesses, ObiNativeFloatList lambdas, int count)
		{
		}

		// Token: 0x0600032F RID: 815 RVA: 0x0000323C File Offset: 0x0000143C
		[Token(Token = "0x600032F")]
		[Address(RVA = "0x2785240", Offset = "0x2783840", VA = "0x182785240", Slot = "12")]
		public override JobHandle Evaluate(JobHandle inputDeps, float stepTime, float substepTime, int substeps)
		{
			return default(JobHandle);
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00003254 File Offset: 0x00001454
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x2785540", Offset = "0x2783B40", VA = "0x182785540", Slot = "13")]
		public override JobHandle Apply(JobHandle inputDeps, float substepTime)
		{
			return default(JobHandle);
		}

		// Token: 0x04000308 RID: 776
		[Token(Token = "0x4000308")]
		[FieldOffset(Offset = "0x48")]
		private NativeArray<float> restLengths;

		// Token: 0x04000309 RID: 777
		[Token(Token = "0x4000309")]
		[FieldOffset(Offset = "0x58")]
		private NativeArray<float2> stiffnesses;

		// Token: 0x0200008F RID: 143
		[Token(Token = "0x200008F")]
		[BurstCompile]
		public struct DistanceConstraintsBatchJob : IJobParallelFor
		{
			// Token: 0x06000331 RID: 817 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x6000331")]
			[Address(RVA = "0x27857C0", Offset = "0x2783DC0", VA = "0x1827857C0", Slot = "4")]
			public void Execute(int i)
			{
			}

			// Token: 0x0400030A RID: 778
			[Token(Token = "0x400030A")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<int> particleIndices;

			// Token: 0x0400030B RID: 779
			[Token(Token = "0x400030B")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public NativeArray<float> restLengths;

			// Token: 0x0400030C RID: 780
			[Token(Token = "0x400030C")]
			[FieldOffset(Offset = "0x20")]
			[ReadOnly]
			public NativeArray<float2> stiffnesses;

			// Token: 0x0400030D RID: 781
			[Token(Token = "0x400030D")]
			[FieldOffset(Offset = "0x30")]
			public NativeArray<float> lambdas;

			// Token: 0x0400030E RID: 782
			[Token(Token = "0x400030E")]
			[FieldOffset(Offset = "0x40")]
			[ReadOnly]
			public NativeArray<float4> positions;

			// Token: 0x0400030F RID: 783
			[Token(Token = "0x400030F")]
			[FieldOffset(Offset = "0x50")]
			[ReadOnly]
			public NativeArray<float> invMasses;

			// Token: 0x04000310 RID: 784
			[Token(Token = "0x4000310")]
			[FieldOffset(Offset = "0x60")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<float4> deltas;

			// Token: 0x04000311 RID: 785
			[Token(Token = "0x4000311")]
			[FieldOffset(Offset = "0x70")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<int> counts;

			// Token: 0x04000312 RID: 786
			[Token(Token = "0x4000312")]
			[FieldOffset(Offset = "0x80")]
			[ReadOnly]
			public float deltaTimeSqr;
		}

		// Token: 0x02000090 RID: 144
		[Token(Token = "0x2000090")]
		[BurstCompile]
		public struct ApplyDistanceConstraintsBatchJob : IJobParallelFor
		{
			// Token: 0x06000332 RID: 818 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x6000332")]
			[Address(RVA = "0x2785AC0", Offset = "0x27840C0", VA = "0x182785AC0", Slot = "4")]
			public void Execute(int i)
			{
			}

			// Token: 0x04000313 RID: 787
			[Token(Token = "0x4000313")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<int> particleIndices;

			// Token: 0x04000314 RID: 788
			[Token(Token = "0x4000314")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public float sorFactor;

			// Token: 0x04000315 RID: 789
			[Token(Token = "0x4000315")]
			[FieldOffset(Offset = "0x18")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<float4> positions;

			// Token: 0x04000316 RID: 790
			[Token(Token = "0x4000316")]
			[FieldOffset(Offset = "0x28")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<float4> deltas;

			// Token: 0x04000317 RID: 791
			[Token(Token = "0x4000317")]
			[FieldOffset(Offset = "0x38")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<int> counts;
		}
	}
}
