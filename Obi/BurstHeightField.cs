using System;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x0200005A RID: 90
	[Token(Token = "0x200005A")]
	public struct BurstHeightField : BurstLocalOptimization.IDistanceFunction, IBurstCollider
	{
		// Token: 0x06000298 RID: 664 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000298")]
		[Address(RVA = "0x2771940", Offset = "0x276FF40", VA = "0x182771940", Slot = "4")]
		public void Evaluate(float4 point, ref BurstLocalOptimization.SurfacePoint projectedPoint)
		{
		}

		// Token: 0x06000299 RID: 665 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x2771D10", Offset = "0x2770310", VA = "0x182771D10")]
		public void Contacts(int colliderIndex, NativeArray<float4> positions, NativeArray<float4> velocities, NativeArray<float4> radii, NativeArray<int> simplices, in BurstAabb simplexBounds, int simplexIndex, int simplexStart, int simplexSize, NativeQueue<BurstContact>.ParallelWriter contacts, int optimizationIterations, float optimizationTolerance)
		{
		}

		// Token: 0x0600029A RID: 666 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600029A")]
		[Address(RVA = "0x2772600", Offset = "0x2770C00", VA = "0x182772600", Slot = "5")]
		private void Contacts(int colliderIndex, NativeArray<float4> positions, NativeArray<float4> velocities, NativeArray<float4> radii, NativeArray<int> simplices, in BurstAabb simplexBounds, int simplexIndex, int simplexStart, int simplexSize, NativeQueue<BurstContact>.ParallelWriter contacts, int optimizationIterations, float optimizationTolerance)
		{
		}

		// Token: 0x040001F4 RID: 500
		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x0")]
		public BurstColliderShape shape;

		// Token: 0x040001F5 RID: 501
		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x40")]
		public BurstAffineTransform transform;

		// Token: 0x040001F6 RID: 502
		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0x70")]
		public float dt;

		// Token: 0x040001F7 RID: 503
		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x74")]
		public BurstMath.CachedTri tri;

		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0xB4")]
		public float4 triNormal;

		// Token: 0x040001F9 RID: 505
		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0xC4")]
		public HeightFieldHeader header;

		// Token: 0x040001FA RID: 506
		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0xD0")]
		public NativeArray<float> heightFieldSamples;
	}
}
