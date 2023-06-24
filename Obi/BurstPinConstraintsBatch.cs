using System;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x0200009A RID: 154
	[Token(Token = "0x200009A")]
	public class BurstPinConstraintsBatch : BurstConstraintsBatchImpl, IPinConstraintsBatchImpl, IConstraintsBatchImpl
	{
		// Token: 0x0600034E RID: 846 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600034E")]
		[Address(RVA = "0x278C2F0", Offset = "0x278A8F0", VA = "0x18278C2F0")]
		public BurstPinConstraintsBatch(BurstPinConstraints constraints)
		{
		}

		// Token: 0x0600034F RID: 847 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600034F")]
		[Address(RVA = "0x278C360", Offset = "0x278A960", VA = "0x18278C360", Slot = "15")]
		public void SetPinConstraints(ObiNativeIntList particleIndices, ObiNativeIntList colliderIndices, ObiNativeVector4List offsets, ObiNativeQuaternionList restDarbouxVectors, ObiNativeFloatList stiffnesses, ObiNativeFloatList lambdas, int count)
		{
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0000335C File Offset: 0x0000155C
		[Token(Token = "0x6000350")]
		[Address(RVA = "0x278C5F0", Offset = "0x278ABF0", VA = "0x18278C5F0", Slot = "12")]
		public override JobHandle Evaluate(JobHandle inputDeps, float stepTime, float substepTime, int substeps)
		{
			return default(JobHandle);
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00003374 File Offset: 0x00001574
		[Token(Token = "0x6000351")]
		[Address(RVA = "0x278CD80", Offset = "0x278B380", VA = "0x18278CD80", Slot = "13")]
		public override JobHandle Apply(JobHandle inputDeps, float substepTime)
		{
			return default(JobHandle);
		}

		// Token: 0x04000353 RID: 851
		[Token(Token = "0x4000353")]
		[FieldOffset(Offset = "0x48")]
		private NativeArray<int> colliderIndices;

		// Token: 0x04000354 RID: 852
		[Token(Token = "0x4000354")]
		[FieldOffset(Offset = "0x58")]
		private NativeArray<float4> offsets;

		// Token: 0x04000355 RID: 853
		[Token(Token = "0x4000355")]
		[FieldOffset(Offset = "0x68")]
		private NativeArray<quaternion> restDarbouxVectors;

		// Token: 0x04000356 RID: 854
		[Token(Token = "0x4000356")]
		[FieldOffset(Offset = "0x78")]
		private NativeArray<float2> stiffnesses;

		// Token: 0x0200009B RID: 155
		[Token(Token = "0x200009B")]
		[BurstCompile]
		public struct PinConstraintsBatchJob : IJob
		{
			// Token: 0x06000352 RID: 850 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x6000352")]
			[Address(RVA = "0x278D080", Offset = "0x278B680", VA = "0x18278D080", Slot = "4")]
			public void Execute()
			{
			}

			// Token: 0x04000357 RID: 855
			[Token(Token = "0x4000357")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<int> particleIndices;

			// Token: 0x04000358 RID: 856
			[Token(Token = "0x4000358")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public NativeArray<int> colliderIndices;

			// Token: 0x04000359 RID: 857
			[Token(Token = "0x4000359")]
			[FieldOffset(Offset = "0x20")]
			[ReadOnly]
			public NativeArray<float4> offsets;

			// Token: 0x0400035A RID: 858
			[Token(Token = "0x400035A")]
			[FieldOffset(Offset = "0x30")]
			[ReadOnly]
			public NativeArray<float2> stiffnesses;

			// Token: 0x0400035B RID: 859
			[Token(Token = "0x400035B")]
			[FieldOffset(Offset = "0x40")]
			[ReadOnly]
			public NativeArray<quaternion> restDarboux;

			// Token: 0x0400035C RID: 860
			[Token(Token = "0x400035C")]
			[FieldOffset(Offset = "0x50")]
			public NativeArray<float4> lambdas;

			// Token: 0x0400035D RID: 861
			[Token(Token = "0x400035D")]
			[FieldOffset(Offset = "0x60")]
			[ReadOnly]
			public NativeArray<float4> positions;

			// Token: 0x0400035E RID: 862
			[Token(Token = "0x400035E")]
			[FieldOffset(Offset = "0x70")]
			[ReadOnly]
			public NativeArray<float4> prevPositions;

			// Token: 0x0400035F RID: 863
			[Token(Token = "0x400035F")]
			[FieldOffset(Offset = "0x80")]
			[ReadOnly]
			public NativeArray<float> invMasses;

			// Token: 0x04000360 RID: 864
			[Token(Token = "0x4000360")]
			[FieldOffset(Offset = "0x90")]
			[ReadOnly]
			public NativeArray<quaternion> orientations;

			// Token: 0x04000361 RID: 865
			[Token(Token = "0x4000361")]
			[FieldOffset(Offset = "0xA0")]
			[ReadOnly]
			public NativeArray<float> invRotationalMasses;

			// Token: 0x04000362 RID: 866
			[Token(Token = "0x4000362")]
			[FieldOffset(Offset = "0xB0")]
			[ReadOnly]
			public NativeArray<BurstColliderShape> shapes;

			// Token: 0x04000363 RID: 867
			[Token(Token = "0x4000363")]
			[FieldOffset(Offset = "0xC0")]
			[ReadOnly]
			public NativeArray<BurstAffineTransform> transforms;

			// Token: 0x04000364 RID: 868
			[Token(Token = "0x4000364")]
			[FieldOffset(Offset = "0xD0")]
			[ReadOnly]
			public NativeArray<BurstRigidbody> rigidbodies;

			// Token: 0x04000365 RID: 869
			[Token(Token = "0x4000365")]
			[FieldOffset(Offset = "0xE0")]
			public NativeArray<float4> rigidbodyLinearDeltas;

			// Token: 0x04000366 RID: 870
			[Token(Token = "0x4000366")]
			[FieldOffset(Offset = "0xF0")]
			public NativeArray<float4> rigidbodyAngularDeltas;

			// Token: 0x04000367 RID: 871
			[Token(Token = "0x4000367")]
			[FieldOffset(Offset = "0x100")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<float4> deltas;

			// Token: 0x04000368 RID: 872
			[Token(Token = "0x4000368")]
			[FieldOffset(Offset = "0x110")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<int> counts;

			// Token: 0x04000369 RID: 873
			[Token(Token = "0x4000369")]
			[FieldOffset(Offset = "0x120")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<quaternion> orientationDeltas;

			// Token: 0x0400036A RID: 874
			[Token(Token = "0x400036A")]
			[FieldOffset(Offset = "0x130")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<int> orientationCounts;

			// Token: 0x0400036B RID: 875
			[Token(Token = "0x400036B")]
			[FieldOffset(Offset = "0x140")]
			[ReadOnly]
			public BurstInertialFrame inertialFrame;

			// Token: 0x0400036C RID: 876
			[Token(Token = "0x400036C")]
			[FieldOffset(Offset = "0x1E0")]
			[ReadOnly]
			public float stepTime;

			// Token: 0x0400036D RID: 877
			[Token(Token = "0x400036D")]
			[FieldOffset(Offset = "0x1E4")]
			[ReadOnly]
			public float substepTime;

			// Token: 0x0400036E RID: 878
			[Token(Token = "0x400036E")]
			[FieldOffset(Offset = "0x1E8")]
			[ReadOnly]
			public int substeps;

			// Token: 0x0400036F RID: 879
			[Token(Token = "0x400036F")]
			[FieldOffset(Offset = "0x1EC")]
			[ReadOnly]
			public int activeConstraintCount;
		}

		// Token: 0x0200009C RID: 156
		[Token(Token = "0x200009C")]
		[BurstCompile]
		public struct ApplyPinConstraintsBatchJob : IJob
		{
			// Token: 0x06000353 RID: 851 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x6000353")]
			[Address(RVA = "0x278E0B0", Offset = "0x278C6B0", VA = "0x18278E0B0", Slot = "4")]
			public void Execute()
			{
			}

			// Token: 0x04000370 RID: 880
			[Token(Token = "0x4000370")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<int> particleIndices;

			// Token: 0x04000371 RID: 881
			[Token(Token = "0x4000371")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public float sorFactor;

			// Token: 0x04000372 RID: 882
			[Token(Token = "0x4000372")]
			[FieldOffset(Offset = "0x18")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<float4> positions;

			// Token: 0x04000373 RID: 883
			[Token(Token = "0x4000373")]
			[FieldOffset(Offset = "0x28")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<float4> deltas;

			// Token: 0x04000374 RID: 884
			[Token(Token = "0x4000374")]
			[FieldOffset(Offset = "0x38")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<int> counts;

			// Token: 0x04000375 RID: 885
			[Token(Token = "0x4000375")]
			[FieldOffset(Offset = "0x48")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<quaternion> orientations;

			// Token: 0x04000376 RID: 886
			[Token(Token = "0x4000376")]
			[FieldOffset(Offset = "0x58")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<quaternion> orientationDeltas;

			// Token: 0x04000377 RID: 887
			[Token(Token = "0x4000377")]
			[FieldOffset(Offset = "0x68")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<int> orientationCounts;

			// Token: 0x04000378 RID: 888
			[Token(Token = "0x4000378")]
			[FieldOffset(Offset = "0x78")]
			[ReadOnly]
			public int activeConstraintCount;
		}
	}
}
