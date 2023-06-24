using System;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x0200005F RID: 95
	[Token(Token = "0x200005F")]
	public struct BurstSphere : BurstLocalOptimization.IDistanceFunction, IBurstCollider
	{
		// Token: 0x060002A2 RID: 674 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x2772BA0", Offset = "0x27711A0", VA = "0x182772BA0", Slot = "4")]
		public void Evaluate(float4 point, ref BurstLocalOptimization.SurfacePoint projectedPoint)
		{
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x2772EE0", Offset = "0x27714E0", VA = "0x182772EE0")]
		public void Contacts(int colliderIndex, NativeArray<float4> positions, NativeArray<float4> velocities, NativeArray<float4> radii, NativeArray<int> simplices, in BurstAabb simplexBounds, int simplexIndex, int simplexStart, int simplexSize, NativeQueue<BurstContact>.ParallelWriter contacts, int optimizationIterations, float optimizationTolerance)
		{
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x27730C0", Offset = "0x27716C0", VA = "0x1827730C0", Slot = "5")]
		private void Contacts(int colliderIndex, NativeArray<float4> positions, NativeArray<float4> velocities, NativeArray<float4> radii, NativeArray<int> simplices, in BurstAabb simplexBounds, int simplexIndex, int simplexStart, int simplexSize, NativeQueue<BurstContact>.ParallelWriter contacts, int optimizationIterations, float optimizationTolerance)
		{
		}

		// Token: 0x04000204 RID: 516
		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0x0")]
		public BurstColliderShape shape;

		// Token: 0x04000205 RID: 517
		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0x40")]
		public BurstAffineTransform transform;

		// Token: 0x04000206 RID: 518
		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x70")]
		public float dt;
	}
}
