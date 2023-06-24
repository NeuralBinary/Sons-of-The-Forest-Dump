using System;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x02000060 RID: 96
	[Token(Token = "0x2000060")]
	public struct BurstTriangleMesh : BurstLocalOptimization.IDistanceFunction, IBurstCollider
	{
		// Token: 0x060002A5 RID: 677 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x27732C0", Offset = "0x27718C0", VA = "0x1827732C0", Slot = "4")]
		public void Evaluate(float4 point, ref BurstLocalOptimization.SurfacePoint projectedPoint)
		{
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x27735D0", Offset = "0x2771BD0", VA = "0x1827735D0")]
		public void Contacts(int colliderIndex, NativeArray<float4> positions, NativeArray<float4> velocities, NativeArray<float4> radii, NativeArray<int> simplices, in BurstAabb simplexBounds, int simplexIndex, int simplexStart, int simplexSize, NativeQueue<BurstContact>.ParallelWriter contacts, int optimizationIterations, float optimizationTolerance)
		{
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x27736B0", Offset = "0x2771CB0", VA = "0x1827736B0")]
		private void BIHTraverse(int colliderIndex, int simplexIndex, int simplexStart, int simplexSize, NativeArray<float4> positions, NativeArray<float4> velocities, NativeArray<float4> radii, NativeArray<int> simplices, in BurstAabb simplexBounds, int nodeIndex, NativeQueue<BurstContact>.ParallelWriter contacts, int optimizationIterations, float optimizationTolerance)
		{
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x27735D0", Offset = "0x2771BD0", VA = "0x1827735D0", Slot = "5")]
		private void Contacts(int colliderIndex, NativeArray<float4> positions, NativeArray<float4> velocities, NativeArray<float4> radii, NativeArray<int> simplices, in BurstAabb simplexBounds, int simplexIndex, int simplexStart, int simplexSize, NativeQueue<BurstContact>.ParallelWriter contacts, int optimizationIterations, float optimizationTolerance)
		{
		}

		// Token: 0x04000207 RID: 519
		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0x0")]
		public BurstColliderShape shape;

		// Token: 0x04000208 RID: 520
		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x40")]
		public BurstAffineTransform transform;

		// Token: 0x04000209 RID: 521
		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x70")]
		public TriangleMeshHeader header;

		// Token: 0x0400020A RID: 522
		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x88")]
		public NativeArray<BIHNode> bihNodes;

		// Token: 0x0400020B RID: 523
		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x98")]
		public NativeArray<Triangle> triangles;

		// Token: 0x0400020C RID: 524
		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0xA8")]
		public NativeArray<float3> vertices;

		// Token: 0x0400020D RID: 525
		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0xB8")]
		public float dt;

		// Token: 0x0400020E RID: 526
		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0xBC")]
		public float collisionMargin;

		// Token: 0x0400020F RID: 527
		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0xC0")]
		private BurstMath.CachedTri tri;
	}
}
