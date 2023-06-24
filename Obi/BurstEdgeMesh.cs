using System;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x02000059 RID: 89
	[Token(Token = "0x2000059")]
	public struct BurstEdgeMesh : BurstLocalOptimization.IDistanceFunction, IBurstCollider
	{
		// Token: 0x06000294 RID: 660 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x2770D40", Offset = "0x276F340", VA = "0x182770D40", Slot = "4")]
		public void Evaluate(float4 point, ref BurstLocalOptimization.SurfacePoint projectedPoint)
		{
		}

		// Token: 0x06000295 RID: 661 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x27711C0", Offset = "0x276F7C0", VA = "0x1827711C0")]
		public void Contacts(int colliderIndex, NativeArray<float4> positions, NativeArray<float4> velocities, NativeArray<float4> radii, NativeArray<int> simplices, in BurstAabb simplexBounds, int simplexIndex, int simplexStart, int simplexSize, NativeQueue<BurstContact>.ParallelWriter contacts, int optimizationIterations, float optimizationTolerance)
		{
		}

		// Token: 0x06000296 RID: 662 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x27712A0", Offset = "0x276F8A0", VA = "0x1827712A0")]
		private void BIHTraverse(int colliderIndex, int simplexIndex, int simplexStart, int simplexSize, NativeArray<float4> positions, NativeArray<float4> radii, NativeArray<int> simplices, in BurstAabb simplexBounds, int nodeIndex, NativeQueue<BurstContact>.ParallelWriter contacts, int optimizationIterations, float optimizationTolerance)
		{
		}

		// Token: 0x06000297 RID: 663 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x27711C0", Offset = "0x276F7C0", VA = "0x1827711C0", Slot = "5")]
		private void Contacts(int colliderIndex, NativeArray<float4> positions, NativeArray<float4> velocities, NativeArray<float4> radii, NativeArray<int> simplices, in BurstAabb simplexBounds, int simplexIndex, int simplexStart, int simplexSize, NativeQueue<BurstContact>.ParallelWriter contacts, int optimizationIterations, float optimizationTolerance)
		{
		}

		// Token: 0x040001EC RID: 492
		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0x0")]
		public BurstColliderShape shape;

		// Token: 0x040001ED RID: 493
		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0x40")]
		public BurstAffineTransform transform;

		// Token: 0x040001EE RID: 494
		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0x70")]
		public int dataOffset;

		// Token: 0x040001EF RID: 495
		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0x74")]
		public float dt;

		// Token: 0x040001F0 RID: 496
		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0x78")]
		public EdgeMeshHeader header;

		// Token: 0x040001F1 RID: 497
		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0x90")]
		public NativeArray<BIHNode> edgeBihNodes;

		// Token: 0x040001F2 RID: 498
		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0xA0")]
		public NativeArray<Edge> edges;

		// Token: 0x040001F3 RID: 499
		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0xB0")]
		public NativeArray<float2> vertices;
	}
}
