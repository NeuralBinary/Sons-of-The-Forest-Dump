using System;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x02000050 RID: 80
	[Token(Token = "0x2000050")]
	public struct BurstCapsule : BurstLocalOptimization.IDistanceFunction, IBurstCollider
	{
		// Token: 0x06000277 RID: 631 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000277")]
		[Address(RVA = "0x276A330", Offset = "0x2768930", VA = "0x18276A330", Slot = "4")]
		public void Evaluate(float4 point, ref BurstLocalOptimization.SurfacePoint projectedPoint)
		{
		}

		// Token: 0x06000278 RID: 632 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x276A800", Offset = "0x2768E00", VA = "0x18276A800")]
		public void Contacts(int colliderIndex, NativeArray<float4> positions, NativeArray<float4> velocities, NativeArray<float4> radii, NativeArray<int> simplices, in BurstAabb simplexBounds, int simplexIndex, int simplexStart, int simplexSize, NativeQueue<BurstContact>.ParallelWriter contacts, int optimizationIterations, float optimizationTolerance)
		{
		}

		// Token: 0x06000279 RID: 633 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x276A9E0", Offset = "0x2768FE0", VA = "0x18276A9E0", Slot = "5")]
		private void Contacts(int colliderIndex, NativeArray<float4> positions, NativeArray<float4> velocities, NativeArray<float4> radii, NativeArray<int> simplices, in BurstAabb simplexBounds, int simplexIndex, int simplexStart, int simplexSize, NativeQueue<BurstContact>.ParallelWriter contacts, int optimizationIterations, float optimizationTolerance)
		{
		}

		// Token: 0x0400019D RID: 413
		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0x0")]
		public BurstColliderShape shape;

		// Token: 0x0400019E RID: 414
		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0x40")]
		public BurstAffineTransform transform;

		// Token: 0x0400019F RID: 415
		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0x70")]
		public float dt;
	}
}
