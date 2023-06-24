using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x0200005B RID: 91
	[Token(Token = "0x200005B")]
	public static class BurstLocalOptimization
	{
		// Token: 0x0600029B RID: 667 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600029B")]
		[Address(RVA = "0x27726E0", Offset = "0x2770CE0", VA = "0x1827726E0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void GetCartesianConvexAttrib(int simplexStart, int simplexSize, NativeArray<int> simplices, NativeArray<float4> positions, NativeArray<float4> radii, float4 convexBary, out float4 convexPoint, out float convexThickness)
		{
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00002DA4 File Offset: 0x00000FA4
		[Token(Token = "0x600029C")]
		public static BurstLocalOptimization.SurfacePoint Optimize<T>(ref T function, NativeArray<float4> positions, NativeArray<float4> radii, NativeArray<int> simplices, int simplexStart, int simplexSize, ref float4 convexBary, out float4 convexPoint, int maxIterations = 16, float tolerance = 0.004f) where T : struct, BurstLocalOptimization.IDistanceFunction
		{
			return default(BurstLocalOptimization.SurfacePoint);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600029D")]
		private static void FrankWolfe<T>(ref T function, int simplexStart, int simplexSize, NativeArray<float4> positions, NativeArray<float4> radii, NativeArray<int> simplices, ref float4 convexPoint, ref float convexThickness, ref float4 convexBary, ref BurstLocalOptimization.SurfacePoint pointInFunction, int maxIterations, float tolerance) where T : struct, BurstLocalOptimization.IDistanceFunction
		{
		}

		// Token: 0x0600029E RID: 670 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600029E")]
		private static void GoldenSearch<T>(ref T function, NativeArray<float4> positions, NativeArray<float4> radii, NativeArray<int> simplices, int simplexStartA, ref float4 convexBary, ref BurstLocalOptimization.SurfacePoint pointInFunction, int maxIterations, float tolerance) where T : struct, BurstLocalOptimization.IDistanceFunction
		{
		}

		// Token: 0x0200005C RID: 92
		[Token(Token = "0x200005C")]
		public struct SurfacePoint
		{
			// Token: 0x040001FB RID: 507
			[Token(Token = "0x40001FB")]
			[FieldOffset(Offset = "0x0")]
			public float4 bary;

			// Token: 0x040001FC RID: 508
			[Token(Token = "0x40001FC")]
			[FieldOffset(Offset = "0x10")]
			public float4 point;

			// Token: 0x040001FD RID: 509
			[Token(Token = "0x40001FD")]
			[FieldOffset(Offset = "0x20")]
			public float4 normal;
		}

		// Token: 0x0200005D RID: 93
		[Token(Token = "0x200005D")]
		public interface IDistanceFunction
		{
			// Token: 0x0600029F RID: 671
			[Token(Token = "0x600029F")]
			void Evaluate(float4 point, ref BurstLocalOptimization.SurfacePoint projectedPoint);
		}
	}
}
