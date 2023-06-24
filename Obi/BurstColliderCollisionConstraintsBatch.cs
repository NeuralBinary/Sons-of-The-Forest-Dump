using System;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x02000076 RID: 118
	[Token(Token = "0x2000076")]
	public class BurstColliderCollisionConstraintsBatch : BurstConstraintsBatchImpl, IColliderCollisionConstraintsBatchImpl, IConstraintsBatchImpl
	{
		// Token: 0x060002F2 RID: 754 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x27792F0", Offset = "0x27778F0", VA = "0x1827792F0")]
		public BurstColliderCollisionConstraintsBatch(BurstColliderCollisionConstraints constraints)
		{
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00002F9C File Offset: 0x0000119C
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x2779360", Offset = "0x2777960", VA = "0x182779360", Slot = "11")]
		public override JobHandle Initialize(JobHandle inputDeps, float substepTime)
		{
			return default(JobHandle);
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00002FB4 File Offset: 0x000011B4
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x2779B60", Offset = "0x2778160", VA = "0x182779B60", Slot = "12")]
		public override JobHandle Evaluate(JobHandle inputDeps, float stepTime, float substepTime, int substeps)
		{
			return default(JobHandle);
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00002FCC File Offset: 0x000011CC
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x277A4B0", Offset = "0x2778AB0", VA = "0x18277A4B0", Slot = "13")]
		public override JobHandle Apply(JobHandle inputDeps, float substepTime)
		{
			return default(JobHandle);
		}

		// Token: 0x02000077 RID: 119
		[Token(Token = "0x2000077")]
		[BurstCompile]
		public struct UpdateContactsJob : IJobParallelFor
		{
			// Token: 0x060002F6 RID: 758 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x277A770", Offset = "0x2778D70", VA = "0x18277A770", Slot = "4")]
			public void Execute(int i)
			{
			}

			// Token: 0x04000263 RID: 611
			[Token(Token = "0x4000263")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<float4> prevPositions;

			// Token: 0x04000264 RID: 612
			[Token(Token = "0x4000264")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public NativeArray<quaternion> prevOrientations;

			// Token: 0x04000265 RID: 613
			[Token(Token = "0x4000265")]
			[FieldOffset(Offset = "0x20")]
			[ReadOnly]
			public NativeArray<float4> velocities;

			// Token: 0x04000266 RID: 614
			[Token(Token = "0x4000266")]
			[FieldOffset(Offset = "0x30")]
			[ReadOnly]
			public NativeArray<float4> radii;

			// Token: 0x04000267 RID: 615
			[Token(Token = "0x4000267")]
			[FieldOffset(Offset = "0x40")]
			[ReadOnly]
			public NativeArray<float> invMasses;

			// Token: 0x04000268 RID: 616
			[Token(Token = "0x4000268")]
			[FieldOffset(Offset = "0x50")]
			[ReadOnly]
			public NativeArray<float4> invInertiaTensors;

			// Token: 0x04000269 RID: 617
			[Token(Token = "0x4000269")]
			[FieldOffset(Offset = "0x60")]
			[ReadOnly]
			public NativeArray<int> particleMaterialIndices;

			// Token: 0x0400026A RID: 618
			[Token(Token = "0x400026A")]
			[FieldOffset(Offset = "0x70")]
			[ReadOnly]
			public NativeArray<BurstCollisionMaterial> collisionMaterials;

			// Token: 0x0400026B RID: 619
			[Token(Token = "0x400026B")]
			[FieldOffset(Offset = "0x80")]
			[ReadOnly]
			public NativeList<int> simplices;

			// Token: 0x0400026C RID: 620
			[Token(Token = "0x400026C")]
			[FieldOffset(Offset = "0x90")]
			[ReadOnly]
			public SimplexCounts simplexCounts;

			// Token: 0x0400026D RID: 621
			[Token(Token = "0x400026D")]
			[FieldOffset(Offset = "0xA0")]
			[ReadOnly]
			public NativeArray<BurstColliderShape> shapes;

			// Token: 0x0400026E RID: 622
			[Token(Token = "0x400026E")]
			[FieldOffset(Offset = "0xB0")]
			[ReadOnly]
			public NativeArray<BurstAffineTransform> transforms;

			// Token: 0x0400026F RID: 623
			[Token(Token = "0x400026F")]
			[FieldOffset(Offset = "0xC0")]
			[ReadOnly]
			public NativeArray<BurstRigidbody> rigidbodies;

			// Token: 0x04000270 RID: 624
			[Token(Token = "0x4000270")]
			[FieldOffset(Offset = "0xD0")]
			[ReadOnly]
			public NativeArray<float4> rigidbodyLinearDeltas;

			// Token: 0x04000271 RID: 625
			[Token(Token = "0x4000271")]
			[FieldOffset(Offset = "0xE0")]
			[ReadOnly]
			public NativeArray<float4> rigidbodyAngularDeltas;

			// Token: 0x04000272 RID: 626
			[Token(Token = "0x4000272")]
			[FieldOffset(Offset = "0xF0")]
			public NativeArray<BurstContact> contacts;

			// Token: 0x04000273 RID: 627
			[Token(Token = "0x4000273")]
			[FieldOffset(Offset = "0x100")]
			[ReadOnly]
			public BurstInertialFrame inertialFrame;
		}

		// Token: 0x02000078 RID: 120
		[Token(Token = "0x2000078")]
		[BurstCompile]
		public struct CollisionConstraintsBatchJob : IJob
		{
			// Token: 0x060002F7 RID: 759 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x277B220", Offset = "0x2779820", VA = "0x18277B220", Slot = "4")]
			public void Execute()
			{
			}

			// Token: 0x060002F8 RID: 760 RVA: 0x00002FE4 File Offset: 0x000011E4
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x277BCF0", Offset = "0x277A2F0", VA = "0x18277BCF0")]
			private BurstCollisionMaterial CombineCollisionMaterials(int entityA, int entityB)
			{
				return default(BurstCollisionMaterial);
			}

			// Token: 0x04000274 RID: 628
			[Token(Token = "0x4000274")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeArray<float4> prevPositions;

			// Token: 0x04000275 RID: 629
			[Token(Token = "0x4000275")]
			[FieldOffset(Offset = "0x10")]
			[ReadOnly]
			public NativeArray<quaternion> orientations;

			// Token: 0x04000276 RID: 630
			[Token(Token = "0x4000276")]
			[FieldOffset(Offset = "0x20")]
			[ReadOnly]
			public NativeArray<quaternion> prevOrientations;

			// Token: 0x04000277 RID: 631
			[Token(Token = "0x4000277")]
			[FieldOffset(Offset = "0x30")]
			[ReadOnly]
			public NativeArray<float> invMasses;

			// Token: 0x04000278 RID: 632
			[Token(Token = "0x4000278")]
			[FieldOffset(Offset = "0x40")]
			[ReadOnly]
			public NativeArray<float4> radii;

			// Token: 0x04000279 RID: 633
			[Token(Token = "0x4000279")]
			[FieldOffset(Offset = "0x50")]
			[ReadOnly]
			public NativeArray<int> particleMaterialIndices;

			// Token: 0x0400027A RID: 634
			[Token(Token = "0x400027A")]
			[FieldOffset(Offset = "0x60")]
			[ReadOnly]
			public NativeList<int> simplices;

			// Token: 0x0400027B RID: 635
			[Token(Token = "0x400027B")]
			[FieldOffset(Offset = "0x70")]
			[ReadOnly]
			public SimplexCounts simplexCounts;

			// Token: 0x0400027C RID: 636
			[Token(Token = "0x400027C")]
			[FieldOffset(Offset = "0x80")]
			[ReadOnly]
			public NativeArray<BurstColliderShape> shapes;

			// Token: 0x0400027D RID: 637
			[Token(Token = "0x400027D")]
			[FieldOffset(Offset = "0x90")]
			[ReadOnly]
			public NativeArray<BurstAffineTransform> transforms;

			// Token: 0x0400027E RID: 638
			[Token(Token = "0x400027E")]
			[FieldOffset(Offset = "0xA0")]
			[ReadOnly]
			public NativeArray<BurstCollisionMaterial> collisionMaterials;

			// Token: 0x0400027F RID: 639
			[Token(Token = "0x400027F")]
			[FieldOffset(Offset = "0xB0")]
			[ReadOnly]
			public NativeArray<BurstRigidbody> rigidbodies;

			// Token: 0x04000280 RID: 640
			[Token(Token = "0x4000280")]
			[FieldOffset(Offset = "0xC0")]
			public NativeArray<float4> rigidbodyLinearDeltas;

			// Token: 0x04000281 RID: 641
			[Token(Token = "0x4000281")]
			[FieldOffset(Offset = "0xD0")]
			public NativeArray<float4> rigidbodyAngularDeltas;

			// Token: 0x04000282 RID: 642
			[Token(Token = "0x4000282")]
			[FieldOffset(Offset = "0xE0")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<float4> positions;

			// Token: 0x04000283 RID: 643
			[Token(Token = "0x4000283")]
			[FieldOffset(Offset = "0xF0")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<float4> deltas;

			// Token: 0x04000284 RID: 644
			[Token(Token = "0x4000284")]
			[FieldOffset(Offset = "0x100")]
			[NativeDisableContainerSafetyRestriction]
			[NativeDisableParallelForRestriction]
			public NativeArray<int> counts;

			// Token: 0x04000285 RID: 645
			[Token(Token = "0x4000285")]
			[FieldOffset(Offset = "0x110")]
			public NativeArray<BurstContact> contacts;

			// Token: 0x04000286 RID: 646
			[Token(Token = "0x4000286")]
			[FieldOffset(Offset = "0x120")]
			[ReadOnly]
			public BurstInertialFrame inertialFrame;

			// Token: 0x04000287 RID: 647
			[Token(Token = "0x4000287")]
			[FieldOffset(Offset = "0x1C0")]
			[ReadOnly]
			public Oni.ConstraintParameters constraintParameters;

			// Token: 0x04000288 RID: 648
			[Token(Token = "0x4000288")]
			[FieldOffset(Offset = "0x1D0")]
			[ReadOnly]
			public Oni.SolverParameters solverParameters;

			// Token: 0x04000289 RID: 649
			[Token(Token = "0x4000289")]
			[FieldOffset(Offset = "0x208")]
			[ReadOnly]
			public float stepTime;

			// Token: 0x0400028A RID: 650
			[Token(Token = "0x400028A")]
			[FieldOffset(Offset = "0x20C")]
			[ReadOnly]
			public float substepTime;

			// Token: 0x0400028B RID: 651
			[Token(Token = "0x400028B")]
			[FieldOffset(Offset = "0x210")]
			[ReadOnly]
			public int substeps;
		}
	}
}
