using System;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x02000093 RID: 147
	[Token(Token = "0x2000093")]
	public class BurstParticleCollisionConstraintsBatch : BurstConstraintsBatchImpl, IParticleCollisionConstraintsBatchImpl, IConstraintsBatchImpl
	{
		// Token: 0x06000338 RID: 824 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000338")]
		[Address(RVA = "0x2786280", Offset = "0x2784880", VA = "0x182786280")]
		public BurstParticleCollisionConstraintsBatch(BurstParticleCollisionConstraints constraints)
		{
		}

		// Token: 0x06000339 RID: 825 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000339")]
		[Address(RVA = "0x27862F0", Offset = "0x27848F0", VA = "0x1827862F0")]
		public BurstParticleCollisionConstraintsBatch(BatchData batchData)
		{
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00003284 File Offset: 0x00001484
		[Token(Token = "0x600033A")]
		[Address(RVA = "0x2786310", Offset = "0x2784910", VA = "0x182786310", Slot = "11")]
		public override JobHandle Initialize(JobHandle inputDeps, float substepTime)
		{
			return default(JobHandle);
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0000329C File Offset: 0x0000149C
		[Token(Token = "0x600033B")]
		[Address(RVA = "0x27867A0", Offset = "0x2784DA0", VA = "0x1827867A0", Slot = "12")]
		public override JobHandle Evaluate(JobHandle inputDeps, float stepTime, float substepTime, int substeps)
		{
			return default(JobHandle);
		}

		// Token: 0x0600033C RID: 828 RVA: 0x000032B4 File Offset: 0x000014B4
		[Token(Token = "0x600033C")]
		[Address(RVA = "0x2786D30", Offset = "0x2785330", VA = "0x182786D30", Slot = "13")]
		public override JobHandle Apply(JobHandle inputDeps, float substepTime)
		{
			return default(JobHandle);
		}

		// Token: 0x04000323 RID: 803
		[Token(Token = "0x4000323")]
		[FieldOffset(Offset = "0x48")]
		public BatchData batchData;

		// Token: 0x02000094 RID: 148
		[Token(Token = "0x2000094")]
		[BurstCompile]
		public struct UpdateParticleContactsJob : IJobParallelFor
		{
			// Token: 0x0600033D RID: 829 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x600033D")]
			[Address(RVA = "0x2787060", Offset = "0x2785660", VA = "0x182787060", Slot = "4")]
			public void Execute(int workItemIndex)
			{
			}

			// Token: 0x04000324 RID: 804
			[Token(Token = "0x4000324")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<float4> prevPositions;

			// Token: 0x04000325 RID: 805
			[Token(Token = "0x4000325")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public NativeArray<quaternion> prevOrientations;

			// Token: 0x04000326 RID: 806
			[Token(Token = "0x4000326")]
			[FieldOffset(Offset = "0x20")]
			[ReadOnly]
			public NativeArray<float4> velocities;

			// Token: 0x04000327 RID: 807
			[Token(Token = "0x4000327")]
			[FieldOffset(Offset = "0x30")]
			[ReadOnly]
			public NativeArray<float4> radii;

			// Token: 0x04000328 RID: 808
			[Token(Token = "0x4000328")]
			[FieldOffset(Offset = "0x40")]
			[ReadOnly]
			public NativeArray<float> invMasses;

			// Token: 0x04000329 RID: 809
			[Token(Token = "0x4000329")]
			[FieldOffset(Offset = "0x50")]
			[ReadOnly]
			public NativeArray<float4> invInertiaTensors;

			// Token: 0x0400032A RID: 810
			[Token(Token = "0x400032A")]
			[FieldOffset(Offset = "0x60")]
			[ReadOnly]
			public NativeArray<int> particleMaterialIndices;

			// Token: 0x0400032B RID: 811
			[Token(Token = "0x400032B")]
			[FieldOffset(Offset = "0x70")]
			[ReadOnly]
			public NativeArray<BurstCollisionMaterial> collisionMaterials;

			// Token: 0x0400032C RID: 812
			[Token(Token = "0x400032C")]
			[FieldOffset(Offset = "0x80")]
			[ReadOnly]
			public NativeList<int> simplices;

			// Token: 0x0400032D RID: 813
			[Token(Token = "0x400032D")]
			[FieldOffset(Offset = "0x90")]
			[ReadOnly]
			public SimplexCounts simplexCounts;

			// Token: 0x0400032E RID: 814
			[Token(Token = "0x400032E")]
			[FieldOffset(Offset = "0xA0")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<BurstContact> contacts;

			// Token: 0x0400032F RID: 815
			[Token(Token = "0x400032F")]
			[FieldOffset(Offset = "0xB0")]
			[ReadOnly]
			public BatchData batchData;
		}

		// Token: 0x02000095 RID: 149
		[Token(Token = "0x2000095")]
		[BurstCompile]
		public struct ParticleCollisionConstraintsBatchJob : IJobParallelFor
		{
			// Token: 0x0600033E RID: 830 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x600033E")]
			[Address(RVA = "0x2788B30", Offset = "0x2787130", VA = "0x182788B30", Slot = "4")]
			public void Execute(int workItemIndex)
			{
			}

			// Token: 0x0600033F RID: 831 RVA: 0x000032CC File Offset: 0x000014CC
			[Token(Token = "0x600033F")]
			[Address(RVA = "0x2789810", Offset = "0x2787E10", VA = "0x182789810")]
			private BurstCollisionMaterial CombineCollisionMaterials(int entityA, int entityB)
			{
				return default(BurstCollisionMaterial);
			}

			// Token: 0x04000330 RID: 816
			[Token(Token = "0x4000330")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<quaternion> orientations;

			// Token: 0x04000331 RID: 817
			[Token(Token = "0x4000331")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public NativeArray<float> invMasses;

			// Token: 0x04000332 RID: 818
			[Token(Token = "0x4000332")]
			[FieldOffset(Offset = "0x20")]
			[ReadOnly]
			public NativeArray<float4> radii;

			// Token: 0x04000333 RID: 819
			[Token(Token = "0x4000333")]
			[FieldOffset(Offset = "0x30")]
			[ReadOnly]
			public NativeArray<int> particleMaterialIndices;

			// Token: 0x04000334 RID: 820
			[Token(Token = "0x4000334")]
			[FieldOffset(Offset = "0x40")]
			[ReadOnly]
			public NativeArray<BurstCollisionMaterial> collisionMaterials;

			// Token: 0x04000335 RID: 821
			[Token(Token = "0x4000335")]
			[FieldOffset(Offset = "0x50")]
			[ReadOnly]
			public NativeList<int> simplices;

			// Token: 0x04000336 RID: 822
			[Token(Token = "0x4000336")]
			[FieldOffset(Offset = "0x60")]
			[ReadOnly]
			public SimplexCounts simplexCounts;

			// Token: 0x04000337 RID: 823
			[Token(Token = "0x4000337")]
			[FieldOffset(Offset = "0x70")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<float4> positions;

			// Token: 0x04000338 RID: 824
			[Token(Token = "0x4000338")]
			[FieldOffset(Offset = "0x80")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<float4> deltas;

			// Token: 0x04000339 RID: 825
			[Token(Token = "0x4000339")]
			[FieldOffset(Offset = "0x90")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<int> counts;

			// Token: 0x0400033A RID: 826
			[Token(Token = "0x400033A")]
			[FieldOffset(Offset = "0xA0")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<BurstContact> contacts;

			// Token: 0x0400033B RID: 827
			[Token(Token = "0x400033B")]
			[FieldOffset(Offset = "0xB0")]
			[ReadOnly]
			public Oni.ConstraintParameters constraintParameters;

			// Token: 0x0400033C RID: 828
			[Token(Token = "0x400033C")]
			[FieldOffset(Offset = "0xC0")]
			[ReadOnly]
			public Oni.SolverParameters solverParameters;

			// Token: 0x0400033D RID: 829
			[Token(Token = "0x400033D")]
			[FieldOffset(Offset = "0xF8")]
			[ReadOnly]
			public float4 gravity;

			// Token: 0x0400033E RID: 830
			[Token(Token = "0x400033E")]
			[FieldOffset(Offset = "0x108")]
			[ReadOnly]
			public float substepTime;

			// Token: 0x0400033F RID: 831
			[Token(Token = "0x400033F")]
			[FieldOffset(Offset = "0x10C")]
			[ReadOnly]
			public BatchData batchData;
		}
	}
}
