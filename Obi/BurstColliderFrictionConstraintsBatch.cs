using System;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x0200007A RID: 122
	[Token(Token = "0x200007A")]
	public class BurstColliderFrictionConstraintsBatch : BurstConstraintsBatchImpl, IColliderFrictionConstraintsBatchImpl, IConstraintsBatchImpl
	{
		// Token: 0x060002FD RID: 765 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x277C0B0", Offset = "0x277A6B0", VA = "0x18277C0B0")]
		public BurstColliderFrictionConstraintsBatch(BurstColliderFrictionConstraints constraints)
		{
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00003014 File Offset: 0x00001214
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x18BE6A0", Offset = "0x18BCCA0", VA = "0x1818BE6A0", Slot = "11")]
		public override JobHandle Initialize(JobHandle inputDeps, float substepTime)
		{
			return default(JobHandle);
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0000302C File Offset: 0x0000122C
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x277C120", Offset = "0x277A720", VA = "0x18277C120", Slot = "12")]
		public override JobHandle Evaluate(JobHandle inputDeps, float stepTime, float substepTime, int substeps)
		{
			return default(JobHandle);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00003044 File Offset: 0x00001244
		[Token(Token = "0x6000300")]
		[Address(RVA = "0x277CA00", Offset = "0x277B000", VA = "0x18277CA00", Slot = "13")]
		public override JobHandle Apply(JobHandle inputDeps, float substepTime)
		{
			return default(JobHandle);
		}

		// Token: 0x0200007B RID: 123
		[Token(Token = "0x200007B")]
		[BurstCompile]
		public struct FrictionConstraintsBatchJob : IJob
		{
			// Token: 0x06000301 RID: 769 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x6000301")]
			[Address(RVA = "0x277CD60", Offset = "0x277B360", VA = "0x18277CD60", Slot = "4")]
			public void Execute()
			{
			}

			// Token: 0x06000302 RID: 770 RVA: 0x0000305C File Offset: 0x0000125C
			[Token(Token = "0x6000302")]
			[Address(RVA = "0x277E560", Offset = "0x277CB60", VA = "0x18277E560")]
			private BurstCollisionMaterial CombineCollisionMaterials(int entityA, int entityB)
			{
				return default(BurstCollisionMaterial);
			}

			// Token: 0x0400028C RID: 652
			[Token(Token = "0x400028C")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<float4> positions;

			// Token: 0x0400028D RID: 653
			[Token(Token = "0x400028D")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public NativeArray<float4> prevPositions;

			// Token: 0x0400028E RID: 654
			[Token(Token = "0x400028E")]
			[FieldOffset(Offset = "0x20")]
			[ReadOnly]
			public NativeArray<quaternion> orientations;

			// Token: 0x0400028F RID: 655
			[Token(Token = "0x400028F")]
			[FieldOffset(Offset = "0x30")]
			[ReadOnly]
			public NativeArray<quaternion> prevOrientations;

			// Token: 0x04000290 RID: 656
			[Token(Token = "0x4000290")]
			[FieldOffset(Offset = "0x40")]
			[ReadOnly]
			public NativeArray<float> invMasses;

			// Token: 0x04000291 RID: 657
			[Token(Token = "0x4000291")]
			[FieldOffset(Offset = "0x50")]
			[ReadOnly]
			public NativeArray<float4> invInertiaTensors;

			// Token: 0x04000292 RID: 658
			[Token(Token = "0x4000292")]
			[FieldOffset(Offset = "0x60")]
			[ReadOnly]
			public NativeArray<float4> radii;

			// Token: 0x04000293 RID: 659
			[Token(Token = "0x4000293")]
			[FieldOffset(Offset = "0x70")]
			[ReadOnly]
			public NativeArray<int> particleMaterialIndices;

			// Token: 0x04000294 RID: 660
			[Token(Token = "0x4000294")]
			[FieldOffset(Offset = "0x80")]
			[ReadOnly]
			public NativeList<int> simplices;

			// Token: 0x04000295 RID: 661
			[Token(Token = "0x4000295")]
			[FieldOffset(Offset = "0x90")]
			[ReadOnly]
			public SimplexCounts simplexCounts;

			// Token: 0x04000296 RID: 662
			[Token(Token = "0x4000296")]
			[FieldOffset(Offset = "0xA0")]
			[ReadOnly]
			public NativeArray<BurstColliderShape> shapes;

			// Token: 0x04000297 RID: 663
			[Token(Token = "0x4000297")]
			[FieldOffset(Offset = "0xB0")]
			[ReadOnly]
			public NativeArray<BurstAffineTransform> transforms;

			// Token: 0x04000298 RID: 664
			[Token(Token = "0x4000298")]
			[FieldOffset(Offset = "0xC0")]
			[ReadOnly]
			public NativeArray<BurstCollisionMaterial> collisionMaterials;

			// Token: 0x04000299 RID: 665
			[Token(Token = "0x4000299")]
			[FieldOffset(Offset = "0xD0")]
			[ReadOnly]
			public NativeArray<BurstRigidbody> rigidbodies;

			// Token: 0x0400029A RID: 666
			[Token(Token = "0x400029A")]
			[FieldOffset(Offset = "0xE0")]
			public NativeArray<float4> rigidbodyLinearDeltas;

			// Token: 0x0400029B RID: 667
			[Token(Token = "0x400029B")]
			[FieldOffset(Offset = "0xF0")]
			public NativeArray<float4> rigidbodyAngularDeltas;

			// Token: 0x0400029C RID: 668
			[Token(Token = "0x400029C")]
			[FieldOffset(Offset = "0x100")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<float4> deltas;

			// Token: 0x0400029D RID: 669
			[Token(Token = "0x400029D")]
			[FieldOffset(Offset = "0x110")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<int> counts;

			// Token: 0x0400029E RID: 670
			[Token(Token = "0x400029E")]
			[FieldOffset(Offset = "0x120")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<quaternion> orientationDeltas;

			// Token: 0x0400029F RID: 671
			[Token(Token = "0x400029F")]
			[FieldOffset(Offset = "0x130")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public NativeArray<int> orientationCounts;

			// Token: 0x040002A0 RID: 672
			[Token(Token = "0x40002A0")]
			[FieldOffset(Offset = "0x140")]
			public NativeArray<BurstContact> contacts;

			// Token: 0x040002A1 RID: 673
			[Token(Token = "0x40002A1")]
			[FieldOffset(Offset = "0x150")]
			[ReadOnly]
			public BurstInertialFrame inertialFrame;

			// Token: 0x040002A2 RID: 674
			[Token(Token = "0x40002A2")]
			[FieldOffset(Offset = "0x1F0")]
			[ReadOnly]
			public float stepTime;

			// Token: 0x040002A3 RID: 675
			[Token(Token = "0x40002A3")]
			[FieldOffset(Offset = "0x1F4")]
			[ReadOnly]
			public float substepTime;

			// Token: 0x040002A4 RID: 676
			[Token(Token = "0x40002A4")]
			[FieldOffset(Offset = "0x1F8")]
			[ReadOnly]
			public int substeps;
		}
	}
}
