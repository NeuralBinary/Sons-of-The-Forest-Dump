using System;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x02000097 RID: 151
	[Token(Token = "0x2000097")]
	public class BurstParticleFrictionConstraintsBatch : BurstConstraintsBatchImpl, IParticleFrictionConstraintsBatchImpl, IConstraintsBatchImpl
	{
		// Token: 0x06000344 RID: 836 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000344")]
		[Address(RVA = "0x2789BC0", Offset = "0x27881C0", VA = "0x182789BC0")]
		public BurstParticleFrictionConstraintsBatch(BurstParticleFrictionConstraints constraints)
		{
		}

		// Token: 0x06000345 RID: 837 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000345")]
		[Address(RVA = "0x27862F0", Offset = "0x27848F0", VA = "0x1827862F0")]
		public BurstParticleFrictionConstraintsBatch(BatchData batchData)
		{
		}

		// Token: 0x06000346 RID: 838 RVA: 0x000032FC File Offset: 0x000014FC
		[Token(Token = "0x6000346")]
		[Address(RVA = "0x18BE6A0", Offset = "0x18BCCA0", VA = "0x1818BE6A0", Slot = "11")]
		public override JobHandle Initialize(JobHandle inputDeps, float substepTime)
		{
			return default(JobHandle);
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00003314 File Offset: 0x00001514
		[Token(Token = "0x6000347")]
		[Address(RVA = "0x2789C30", Offset = "0x2788230", VA = "0x182789C30", Slot = "12")]
		public override JobHandle Evaluate(JobHandle inputDeps, float stepTime, float substepTime, int substeps)
		{
			return default(JobHandle);
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0000332C File Offset: 0x0000152C
		[Token(Token = "0x6000348")]
		[Address(RVA = "0x278A1E0", Offset = "0x27887E0", VA = "0x18278A1E0", Slot = "13")]
		public override JobHandle Apply(JobHandle inputDeps, float substepTime)
		{
			return default(JobHandle);
		}

		// Token: 0x04000340 RID: 832
		[Token(Token = "0x4000340")]
		[FieldOffset(Offset = "0x48")]
		public BatchData batchData;

		// Token: 0x02000098 RID: 152
		[Token(Token = "0x2000098")]
		[BurstCompile]
		public struct ParticleFrictionConstraintsBatchJob : IJobParallelFor
		{
			// Token: 0x06000349 RID: 841 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x6000349")]
			[Address(RVA = "0x278A5A0", Offset = "0x2788BA0", VA = "0x18278A5A0", Slot = "4")]
			public void Execute(int workItemIndex)
			{
			}

			// Token: 0x0600034A RID: 842 RVA: 0x00003344 File Offset: 0x00001544
			[Token(Token = "0x600034A")]
			[Address(RVA = "0x278BFB0", Offset = "0x278A5B0", VA = "0x18278BFB0")]
			private BurstCollisionMaterial CombineCollisionMaterials(int entityA, int entityB)
			{
				return default(BurstCollisionMaterial);
			}

			// Token: 0x04000341 RID: 833
			[Token(Token = "0x4000341")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<float4> positions;

			// Token: 0x04000342 RID: 834
			[Token(Token = "0x4000342")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public NativeArray<float4> prevPositions;

			// Token: 0x04000343 RID: 835
			[Token(Token = "0x4000343")]
			[FieldOffset(Offset = "0x20")]
			[ReadOnly]
			public NativeArray<quaternion> orientations;

			// Token: 0x04000344 RID: 836
			[Token(Token = "0x4000344")]
			[FieldOffset(Offset = "0x30")]
			[ReadOnly]
			public NativeArray<quaternion> prevOrientations;

			// Token: 0x04000345 RID: 837
			[Token(Token = "0x4000345")]
			[FieldOffset(Offset = "0x40")]
			[ReadOnly]
			public NativeArray<float> invMasses;

			// Token: 0x04000346 RID: 838
			[Token(Token = "0x4000346")]
			[FieldOffset(Offset = "0x50")]
			[ReadOnly]
			public NativeArray<float4> invInertiaTensors;

			// Token: 0x04000347 RID: 839
			[Token(Token = "0x4000347")]
			[FieldOffset(Offset = "0x60")]
			[ReadOnly]
			public NativeArray<float4> radii;

			// Token: 0x04000348 RID: 840
			[Token(Token = "0x4000348")]
			[FieldOffset(Offset = "0x70")]
			[ReadOnly]
			public NativeArray<int> particleMaterialIndices;

			// Token: 0x04000349 RID: 841
			[Token(Token = "0x4000349")]
			[FieldOffset(Offset = "0x80")]
			[ReadOnly]
			public NativeArray<BurstCollisionMaterial> collisionMaterials;

			// Token: 0x0400034A RID: 842
			[Token(Token = "0x400034A")]
			[FieldOffset(Offset = "0x90")]
			[ReadOnly]
			public NativeList<int> simplices;

			// Token: 0x0400034B RID: 843
			[Token(Token = "0x400034B")]
			[FieldOffset(Offset = "0xA0")]
			[ReadOnly]
			public SimplexCounts simplexCounts;

			// Token: 0x0400034C RID: 844
			[Token(Token = "0x400034C")]
			[FieldOffset(Offset = "0xB0")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<float4> deltas;

			// Token: 0x0400034D RID: 845
			[Token(Token = "0x400034D")]
			[FieldOffset(Offset = "0xC0")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<int> counts;

			// Token: 0x0400034E RID: 846
			[Token(Token = "0x400034E")]
			[FieldOffset(Offset = "0xD0")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<quaternion> orientationDeltas;

			// Token: 0x0400034F RID: 847
			[Token(Token = "0x400034F")]
			[FieldOffset(Offset = "0xE0")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<int> orientationCounts;

			// Token: 0x04000350 RID: 848
			[Token(Token = "0x4000350")]
			[FieldOffset(Offset = "0xF0")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<BurstContact> contacts;

			// Token: 0x04000351 RID: 849
			[Token(Token = "0x4000351")]
			[FieldOffset(Offset = "0x100")]
			[ReadOnly]
			public BatchData batchData;

			// Token: 0x04000352 RID: 850
			[Token(Token = "0x4000352")]
			[FieldOffset(Offset = "0x11C")]
			[ReadOnly]
			public float substepTime;
		}
	}
}
