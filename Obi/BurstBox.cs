using System;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x0200004F RID: 79
	[Token(Token = "0x200004F")]
	public struct BurstBox : BurstLocalOptimization.IDistanceFunction, IBurstCollider
	{
		// Token: 0x06000274 RID: 628 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x2769990", Offset = "0x2767F90", VA = "0x182769990", Slot = "4")]
		public void Evaluate(float4 point, ref BurstLocalOptimization.SurfacePoint projectedPoint)
		{
		}

		// Token: 0x06000275 RID: 629 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000275")]
		[Address(RVA = "0x2769F50", Offset = "0x2768550", VA = "0x182769F50")]
		public void Contacts(int colliderIndex, NativeArray<float4> positions, NativeArray<float4> velocities, NativeArray<float4> radii, NativeArray<int> simplices, in BurstAabb simplexBounds, int simplexIndex, int simplexStart, int simplexSize, NativeQueue<BurstContact>.ParallelWriter contacts, int optimizationIterations, float optimizationTolerance)
		{
		}

		// Token: 0x06000276 RID: 630 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000276")]
		[Address(RVA = "0x276A130", Offset = "0x2768730", VA = "0x18276A130", Slot = "5")]
		private void Contacts(int colliderIndex, NativeArray<float4> positions, NativeArray<float4> velocities, NativeArray<float4> radii, NativeArray<int> simplices, in BurstAabb simplexBounds, int simplexIndex, int simplexStart, int simplexSize, NativeQueue<BurstContact>.ParallelWriter contacts, int optimizationIterations, float optimizationTolerance)
		{
		}

		// Token: 0x0400019A RID: 410
		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x0")]
		public BurstColliderShape shape;

		// Token: 0x0400019B RID: 411
		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0x40")]
		public BurstAffineTransform transform;

		// Token: 0x0400019C RID: 412
		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0x70")]
		public float dt;
	}
}
