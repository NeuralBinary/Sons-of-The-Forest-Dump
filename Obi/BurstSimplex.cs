using System;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x0200005E RID: 94
	[Token(Token = "0x200005E")]
	public struct BurstSimplex : BurstLocalOptimization.IDistanceFunction
	{
		// Token: 0x060002A0 RID: 672 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x2772840", Offset = "0x2770E40", VA = "0x182772840")]
		public void CacheData()
		{
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x27728B0", Offset = "0x2770EB0", VA = "0x1827728B0", Slot = "4")]
		public void Evaluate(float4 point, ref BurstLocalOptimization.SurfacePoint projectedPoint)
		{
		}

		// Token: 0x040001FE RID: 510
		[Token(Token = "0x40001FE")]
		[FieldOffset(Offset = "0x0")]
		public NativeArray<float4> positions;

		// Token: 0x040001FF RID: 511
		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0x10")]
		public NativeArray<float4> radii;

		// Token: 0x04000200 RID: 512
		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0x20")]
		public NativeArray<int> simplices;

		// Token: 0x04000201 RID: 513
		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0x30")]
		public int simplexStart;

		// Token: 0x04000202 RID: 514
		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0x34")]
		public int simplexSize;

		// Token: 0x04000203 RID: 515
		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0x38")]
		private BurstMath.CachedTri tri;
	}
}
