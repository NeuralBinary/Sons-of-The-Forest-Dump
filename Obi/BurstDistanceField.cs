using System;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x02000058 RID: 88
	[Token(Token = "0x2000058")]
	public struct BurstDistanceField : BurstLocalOptimization.IDistanceFunction, IBurstCollider
	{
		// Token: 0x06000290 RID: 656 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x276EE40", Offset = "0x276D440", VA = "0x18276EE40", Slot = "4")]
		public void Evaluate(float4 point, ref BurstLocalOptimization.SurfacePoint projectedPoint)
		{
		}

		// Token: 0x06000291 RID: 657 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x276F160", Offset = "0x276D760", VA = "0x18276F160")]
		public void Contacts(int colliderIndex, NativeArray<float4> positions, NativeArray<float4> velocities, NativeArray<float4> radii, NativeArray<int> simplices, in BurstAabb simplexBounds, int simplexIndex, int simplexStart, int simplexSize, NativeQueue<BurstContact>.ParallelWriter contacts, int optimizationIterations, float optimizationTolerance)
		{
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00002D8C File Offset: 0x00000F8C
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x276F5D0", Offset = "0x276DBD0", VA = "0x18276F5D0")]
		private static float4 DFTraverse(float4 particlePosition, int nodeIndex, in DistanceFieldHeader header, in NativeArray<BurstDFNode> dfNodes)
		{
			return default(float4);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x276F6D0", Offset = "0x276DCD0", VA = "0x18276F6D0", Slot = "5")]
		private void Contacts(int colliderIndex, NativeArray<float4> positions, NativeArray<float4> velocities, NativeArray<float4> radii, NativeArray<int> simplices, in BurstAabb simplexBounds, int simplexIndex, int simplexStart, int simplexSize, NativeQueue<BurstContact>.ParallelWriter contacts, int optimizationIterations, float optimizationTolerance)
		{
		}

		// Token: 0x040001E6 RID: 486
		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x0")]
		public BurstColliderShape shape;

		// Token: 0x040001E7 RID: 487
		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0x40")]
		public BurstAffineTransform transform;

		// Token: 0x040001E8 RID: 488
		[Token(Token = "0x40001E8")]
		[FieldOffset(Offset = "0x70")]
		public float dt;

		// Token: 0x040001E9 RID: 489
		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0x74")]
		public float collisionMargin;

		// Token: 0x040001EA RID: 490
		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0x78")]
		public NativeArray<DistanceFieldHeader> distanceFieldHeaders;

		// Token: 0x040001EB RID: 491
		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0x88")]
		public NativeArray<BurstDFNode> dfNodes;
	}
}
