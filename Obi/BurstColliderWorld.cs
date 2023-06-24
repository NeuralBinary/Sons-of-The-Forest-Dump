using System;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

namespace Obi
{
	// Token: 0x02000052 RID: 82
	[Token(Token = "0x2000052")]
	public class BurstColliderWorld : MonoBehaviour, IColliderWorldImpl
	{
		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600027A RID: 634 RVA: 0x00002D14 File Offset: 0x00000F14
		[Token(Token = "0x1700006B")]
		public int referenceCount
		{
			[Token(Token = "0x600027A")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600027B RID: 635 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600027B")]
		[Address(RVA = "0x276ABE0", Offset = "0x27691E0", VA = "0x18276ABE0")]
		public void Awake()
		{
		}

		// Token: 0x0600027C RID: 636 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x276ADA0", Offset = "0x27693A0", VA = "0x18276ADA0")]
		public void OnDestroy()
		{
		}

		// Token: 0x0600027D RID: 637 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x276AEB0", Offset = "0x27694B0", VA = "0x18276AEB0")]
		public void IncreaseReferenceCount()
		{
		}

		// Token: 0x0600027E RID: 638 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x276AEC0", Offset = "0x27694C0", VA = "0x18276AEC0")]
		public void DecreaseReferenceCount()
		{
		}

		// Token: 0x0600027F RID: 639 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600027F")]
		[Address(RVA = "0x276B040", Offset = "0x2769640", VA = "0x18276B040", Slot = "6")]
		public void SetColliders(ObiNativeColliderShapeList shapes, ObiNativeAabbList bounds, ObiNativeAffineTransformList transforms, int count)
		{
		}

		// Token: 0x06000280 RID: 640 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "7")]
		public void SetRigidbodies(ObiNativeRigidbodyList rigidbody)
		{
		}

		// Token: 0x06000281 RID: 641 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "8")]
		public void SetCollisionMaterials(ObiNativeCollisionMaterialList materials)
		{
		}

		// Token: 0x06000282 RID: 642 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000282")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "9")]
		public void SetTriangleMeshData(ObiNativeTriangleMeshHeaderList headers, ObiNativeBIHNodeList nodes, ObiNativeTriangleList triangles, ObiNativeVector3List vertices)
		{
		}

		// Token: 0x06000283 RID: 643 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "10")]
		public void SetEdgeMeshData(ObiNativeEdgeMeshHeaderList headers, ObiNativeBIHNodeList nodes, ObiNativeEdgeList edges, ObiNativeVector2List vertices)
		{
		}

		// Token: 0x06000284 RID: 644 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "11")]
		public void SetDistanceFieldData(ObiNativeDistanceFieldHeaderList headers, ObiNativeDFNodeList nodes)
		{
		}

		// Token: 0x06000285 RID: 645 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "12")]
		public void SetHeightFieldData(ObiNativeHeightFieldHeaderList headers, ObiNativeFloatList samples)
		{
		}

		// Token: 0x06000286 RID: 646 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000286")]
		[Address(RVA = "0x276B150", Offset = "0x2769750", VA = "0x18276B150", Slot = "5")]
		public void UpdateWorld(float deltaTime)
		{
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00002D2C File Offset: 0x00000F2C
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x276B7E0", Offset = "0x2769DE0", VA = "0x18276B7E0")]
		public JobHandle GenerateContacts(BurstSolverImpl solver, float deltaTime, JobHandle inputDeps)
		{
			return default(JobHandle);
		}

		// Token: 0x06000288 RID: 648 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000288")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public BurstColliderWorld()
		{
		}

		// Token: 0x040001AA RID: 426
		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0x20")]
		private int refCount;

		// Token: 0x040001AB RID: 427
		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0x24")]
		private int colliderCount;

		// Token: 0x040001AC RID: 428
		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0x28")]
		private NativeMultilevelGrid<int> grid;

		// Token: 0x040001AD RID: 429
		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0x58")]
		private NativeQueue<BurstColliderWorld.MovingCollider> movingColliders;

		// Token: 0x040001AE RID: 430
		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0x70")]
		public NativeQueue<BurstContact> colliderContactQueue;

		// Token: 0x040001AF RID: 431
		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x88")]
		public ObiNativeCellSpanList cellSpans;

		// Token: 0x02000053 RID: 83
		[Token(Token = "0x2000053")]
		private struct MovingCollider
		{
			// Token: 0x040001B0 RID: 432
			[Token(Token = "0x40001B0")]
			[FieldOffset(Offset = "0x0")]
			public BurstCellSpan oldSpan;

			// Token: 0x040001B1 RID: 433
			[Token(Token = "0x40001B1")]
			[FieldOffset(Offset = "0x20")]
			public BurstCellSpan newSpan;

			// Token: 0x040001B2 RID: 434
			[Token(Token = "0x40001B2")]
			[FieldOffset(Offset = "0x40")]
			public int entity;
		}

		// Token: 0x02000054 RID: 84
		[Token(Token = "0x2000054")]
		[BurstCompile]
		private struct IdentifyMovingColliders : IJobParallelFor
		{
			// Token: 0x06000289 RID: 649 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x6000289")]
			[Address(RVA = "0x276C3B0", Offset = "0x276A9B0", VA = "0x18276C3B0", Slot = "4")]
			public void Execute(int i)
			{
			}

			// Token: 0x040001B3 RID: 435
			[Token(Token = "0x40001B3")]
			[FieldOffset(Offset = "0x0")]
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeQueue<BurstColliderWorld.MovingCollider>.ParallelWriter movingColliders;

			// Token: 0x040001B4 RID: 436
			[Token(Token = "0x40001B4")]
			[FieldOffset(Offset = "0x18")]
			[ReadOnly]
			public NativeArray<BurstColliderShape> shapes;

			// Token: 0x040001B5 RID: 437
			[Token(Token = "0x40001B5")]
			[FieldOffset(Offset = "0x28")]
			[ReadOnly]
			public NativeArray<BurstRigidbody> rigidbodies;

			// Token: 0x040001B6 RID: 438
			[Token(Token = "0x40001B6")]
			[FieldOffset(Offset = "0x38")]
			[ReadOnly]
			public NativeArray<BurstCollisionMaterial> collisionMaterials;

			// Token: 0x040001B7 RID: 439
			[Token(Token = "0x40001B7")]
			[FieldOffset(Offset = "0x48")]
			public NativeArray<BurstAabb> bounds;

			// Token: 0x040001B8 RID: 440
			[Token(Token = "0x40001B8")]
			[FieldOffset(Offset = "0x58")]
			public NativeArray<BurstCellSpan> cellIndices;

			// Token: 0x040001B9 RID: 441
			[Token(Token = "0x40001B9")]
			[FieldOffset(Offset = "0x68")]
			[ReadOnly]
			public int colliderCount;

			// Token: 0x040001BA RID: 442
			[Token(Token = "0x40001BA")]
			[FieldOffset(Offset = "0x6C")]
			[ReadOnly]
			public float dt;
		}

		// Token: 0x02000055 RID: 85
		[Token(Token = "0x2000055")]
		[BurstCompile]
		private struct UpdateMovingColliders : IJob
		{
			// Token: 0x0600028A RID: 650 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x600028A")]
			[Address(RVA = "0x276C8E0", Offset = "0x276AEE0", VA = "0x18276C8E0", Slot = "4")]
			public void Execute()
			{
			}

			// Token: 0x040001BB RID: 443
			[Token(Token = "0x40001BB")]
			[FieldOffset(Offset = "0x0")]
			public NativeQueue<BurstColliderWorld.MovingCollider> movingColliders;

			// Token: 0x040001BC RID: 444
			[Token(Token = "0x40001BC")]
			[FieldOffset(Offset = "0x18")]
			public NativeMultilevelGrid<int> grid;

			// Token: 0x040001BD RID: 445
			[Token(Token = "0x40001BD")]
			[FieldOffset(Offset = "0x48")]
			[ReadOnly]
			public int colliderCount;
		}

		// Token: 0x02000056 RID: 86
		[Token(Token = "0x2000056")]
		[BurstCompile]
		private struct GenerateContactsJob : IJobParallelFor
		{
			// Token: 0x0600028B RID: 651 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x600028B")]
			[Address(RVA = "0x276CA90", Offset = "0x276B090", VA = "0x18276CA90", Slot = "4")]
			public void Execute(int i)
			{
			}

			// Token: 0x0600028C RID: 652 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x600028C")]
			[Address(RVA = "0x276D680", Offset = "0x276BC80", VA = "0x18276D680")]
			private void GenerateContacts(in BurstColliderShape shape, in BurstAffineTransform colliderToSolver, int colliderIndex, int simplexIndex, int simplexStart, int simplexSize, in BurstAabb simplexBoundsSS)
			{
			}

			// Token: 0x040001BE RID: 446
			[Token(Token = "0x40001BE")]
			[FieldOffset(Offset = "0x0")]
			[ReadOnly]
			public NativeMultilevelGrid<int> colliderGrid;

			// Token: 0x040001BF RID: 447
			[Token(Token = "0x40001BF")]
			[FieldOffset(Offset = "0x30")]
			[DeallocateOnJobCompletion]
			[ReadOnly]
			public NativeArray<int> gridLevels;

			// Token: 0x040001C0 RID: 448
			[Token(Token = "0x40001C0")]
			[FieldOffset(Offset = "0x40")]
			[ReadOnly]
			public NativeArray<float4> velocities;

			// Token: 0x040001C1 RID: 449
			[Token(Token = "0x40001C1")]
			[FieldOffset(Offset = "0x50")]
			[ReadOnly]
			public NativeArray<float4> positions;

			// Token: 0x040001C2 RID: 450
			[Token(Token = "0x40001C2")]
			[FieldOffset(Offset = "0x60")]
			[ReadOnly]
			public NativeArray<quaternion> orientations;

			// Token: 0x040001C3 RID: 451
			[Token(Token = "0x40001C3")]
			[FieldOffset(Offset = "0x70")]
			[ReadOnly]
			public NativeArray<float> invMasses;

			// Token: 0x040001C4 RID: 452
			[Token(Token = "0x40001C4")]
			[FieldOffset(Offset = "0x80")]
			[ReadOnly]
			public NativeArray<float4> radii;

			// Token: 0x040001C5 RID: 453
			[Token(Token = "0x40001C5")]
			[FieldOffset(Offset = "0x90")]
			[ReadOnly]
			public NativeArray<int> phases;

			// Token: 0x040001C6 RID: 454
			[Token(Token = "0x40001C6")]
			[FieldOffset(Offset = "0xA0")]
			[ReadOnly]
			public NativeList<int> simplices;

			// Token: 0x040001C7 RID: 455
			[Token(Token = "0x40001C7")]
			[FieldOffset(Offset = "0xB0")]
			[ReadOnly]
			public SimplexCounts simplexCounts;

			// Token: 0x040001C8 RID: 456
			[Token(Token = "0x40001C8")]
			[FieldOffset(Offset = "0xC0")]
			[ReadOnly]
			public NativeArray<BurstAabb> simplexBounds;

			// Token: 0x040001C9 RID: 457
			[Token(Token = "0x40001C9")]
			[FieldOffset(Offset = "0xD0")]
			[ReadOnly]
			public NativeArray<BurstAffineTransform> transforms;

			// Token: 0x040001CA RID: 458
			[Token(Token = "0x40001CA")]
			[FieldOffset(Offset = "0xE0")]
			[ReadOnly]
			public NativeArray<BurstColliderShape> shapes;

			// Token: 0x040001CB RID: 459
			[Token(Token = "0x40001CB")]
			[FieldOffset(Offset = "0xF0")]
			[ReadOnly]
			public NativeArray<BurstCollisionMaterial> collisionMaterials;

			// Token: 0x040001CC RID: 460
			[Token(Token = "0x40001CC")]
			[FieldOffset(Offset = "0x100")]
			[ReadOnly]
			public NativeArray<BurstRigidbody> rigidbodies;

			// Token: 0x040001CD RID: 461
			[Token(Token = "0x40001CD")]
			[FieldOffset(Offset = "0x110")]
			[ReadOnly]
			public NativeArray<BurstAabb> bounds;

			// Token: 0x040001CE RID: 462
			[Token(Token = "0x40001CE")]
			[FieldOffset(Offset = "0x120")]
			[ReadOnly]
			public NativeArray<DistanceFieldHeader> distanceFieldHeaders;

			// Token: 0x040001CF RID: 463
			[Token(Token = "0x40001CF")]
			[FieldOffset(Offset = "0x130")]
			[ReadOnly]
			public NativeArray<BurstDFNode> distanceFieldNodes;

			// Token: 0x040001D0 RID: 464
			[Token(Token = "0x40001D0")]
			[FieldOffset(Offset = "0x140")]
			[ReadOnly]
			public NativeArray<TriangleMeshHeader> triangleMeshHeaders;

			// Token: 0x040001D1 RID: 465
			[Token(Token = "0x40001D1")]
			[FieldOffset(Offset = "0x150")]
			[ReadOnly]
			public NativeArray<BIHNode> bihNodes;

			// Token: 0x040001D2 RID: 466
			[Token(Token = "0x40001D2")]
			[FieldOffset(Offset = "0x160")]
			[ReadOnly]
			public NativeArray<Triangle> triangles;

			// Token: 0x040001D3 RID: 467
			[Token(Token = "0x40001D3")]
			[FieldOffset(Offset = "0x170")]
			[ReadOnly]
			public NativeArray<float3> vertices;

			// Token: 0x040001D4 RID: 468
			[Token(Token = "0x40001D4")]
			[FieldOffset(Offset = "0x180")]
			[ReadOnly]
			public NativeArray<EdgeMeshHeader> edgeMeshHeaders;

			// Token: 0x040001D5 RID: 469
			[Token(Token = "0x40001D5")]
			[FieldOffset(Offset = "0x190")]
			[ReadOnly]
			public NativeArray<BIHNode> edgeBihNodes;

			// Token: 0x040001D6 RID: 470
			[Token(Token = "0x40001D6")]
			[FieldOffset(Offset = "0x1A0")]
			[ReadOnly]
			public NativeArray<Edge> edges;

			// Token: 0x040001D7 RID: 471
			[Token(Token = "0x40001D7")]
			[FieldOffset(Offset = "0x1B0")]
			[ReadOnly]
			public NativeArray<float2> edgeVertices;

			// Token: 0x040001D8 RID: 472
			[Token(Token = "0x40001D8")]
			[FieldOffset(Offset = "0x1C0")]
			[ReadOnly]
			public NativeArray<HeightFieldHeader> heightFieldHeaders;

			// Token: 0x040001D9 RID: 473
			[Token(Token = "0x40001D9")]
			[FieldOffset(Offset = "0x1D0")]
			[ReadOnly]
			public NativeArray<float> heightFieldSamples;

			// Token: 0x040001DA RID: 474
			[Token(Token = "0x40001DA")]
			[FieldOffset(Offset = "0x1E0")]
			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeQueue<BurstContact>.ParallelWriter contactsQueue;

			// Token: 0x040001DB RID: 475
			[Token(Token = "0x40001DB")]
			[FieldOffset(Offset = "0x1F8")]
			[ReadOnly]
			public BurstAffineTransform solverToWorld;

			// Token: 0x040001DC RID: 476
			[Token(Token = "0x40001DC")]
			[FieldOffset(Offset = "0x228")]
			[ReadOnly]
			public BurstAffineTransform worldToSolver;

			// Token: 0x040001DD RID: 477
			[Token(Token = "0x40001DD")]
			[FieldOffset(Offset = "0x258")]
			[ReadOnly]
			public float deltaTime;

			// Token: 0x040001DE RID: 478
			[Token(Token = "0x40001DE")]
			[FieldOffset(Offset = "0x25C")]
			[ReadOnly]
			public Oni.SolverParameters parameters;
		}
	}
}
