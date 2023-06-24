using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x0200004D RID: 77
	[Token(Token = "0x200004D")]
	public static class BurstMath
	{
		// Token: 0x06000252 RID: 594 RVA: 0x00002A74 File Offset: 0x00000C74
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x2765B80", Offset = "0x2764180", VA = "0x182765B80")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3x3 multrnsp(float4 column, float4 row)
		{
			return default(float3x3);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00002A8C File Offset: 0x00000C8C
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x2765C30", Offset = "0x2764230", VA = "0x182765C30")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x4 multrnsp4(float4 column, float4 row)
		{
			return default(float4x4);
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00002AA4 File Offset: 0x00000CA4
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x2765D20", Offset = "0x2764320", VA = "0x182765D20")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 project(this float4 vector, float4 onto)
		{
			return default(float4);
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00002ABC File Offset: 0x00000CBC
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x2765E90", Offset = "0x2764490", VA = "0x182765E90")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x4 TransformInertiaTensor(float4 tensor, quaternion rotation)
		{
			return default(float4x4);
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00002AD4 File Offset: 0x00000CD4
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x2766070", Offset = "0x2764670", VA = "0x182766070")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float RotationalInvMass(float4x4 inverseInertiaTensor, float4 point, float4 direction)
		{
			return 0f;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00002AEC File Offset: 0x00000CEC
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x27661D0", Offset = "0x27647D0", VA = "0x1827661D0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 GetParticleVelocityAtPoint(float4 position, float4 prevPosition, float4 point, float dt)
		{
			return default(float4);
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00002B04 File Offset: 0x00000D04
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x2766250", Offset = "0x2764850", VA = "0x182766250")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 GetParticleVelocityAtPoint(float4 position, float4 prevPosition, quaternion orientation, quaternion prevOrientation, float4 point, float dt)
		{
			return default(float4);
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00002B1C File Offset: 0x00000D1C
		[Token(Token = "0x6000259")]
		[Address(RVA = "0x27664D0", Offset = "0x2764AD0", VA = "0x1827664D0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 GetRigidbodyVelocityAtPoint(int rigidbodyIndex, float4 point, NativeArray<BurstRigidbody> rigidbodies, NativeArray<float4> linearDeltas, NativeArray<float4> angularDeltas, BurstAffineTransform transform)
		{
			return default(float4);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600025A")]
		[Address(RVA = "0x2766730", Offset = "0x2764D30", VA = "0x182766730")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ApplyImpulse(int rigidbodyIndex, float4 impulse, float4 point, NativeArray<BurstRigidbody> rigidbodies, NativeArray<float4> linearDeltas, NativeArray<float4> angularDeltas, BurstAffineTransform transform)
		{
		}

		// Token: 0x0600025B RID: 603 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600025B")]
		[Address(RVA = "0x2766B20", Offset = "0x2765120", VA = "0x182766B20")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ApplyDeltaQuaternion(int rigidbodyIndex, quaternion rotation, quaternion delta, NativeArray<float4> angularDeltas, BurstAffineTransform transform, float dt)
		{
		}

		// Token: 0x0600025C RID: 604 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600025C")]
		[Address(RVA = "0x2766E10", Offset = "0x2765410", VA = "0x182766E10")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void OneSidedNormal(float4 forward, ref float4 normal)
		{
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00002B34 File Offset: 0x00000D34
		[Token(Token = "0x600025D")]
		[Address(RVA = "0x2766EC0", Offset = "0x27654C0", VA = "0x182766EC0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float EllipsoidRadius(float4 normSolverDirection, quaternion orientation, float3 radii)
		{
			return 0f;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00002B4C File Offset: 0x00000D4C
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x2766FE0", Offset = "0x27655E0", VA = "0x182766FE0")]
		public static quaternion ExtractRotation(float4x4 matrix, quaternion rotation, int iterations)
		{
			return default(quaternion);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600025F")]
		[Address(RVA = "0x2767420", Offset = "0x2765A20", VA = "0x182767420")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SwingTwist(quaternion q, float3 vt, out quaternion swing, out quaternion twist)
		{
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00002B64 File Offset: 0x00000D64
		[Token(Token = "0x6000260")]
		[Address(RVA = "0x27675C0", Offset = "0x2765BC0", VA = "0x1827675C0")]
		public static float4x4 toMatrix(this quaternion q)
		{
			return default(float4x4);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00002B7C File Offset: 0x00000D7C
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x27677A0", Offset = "0x2765DA0", VA = "0x1827677A0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4x4 asDiagonal(this float4 v)
		{
			return default(float4x4);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00002B94 File Offset: 0x00000D94
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x2767860", Offset = "0x2765E60", VA = "0x182767860")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 diagonal(this float4x4 value)
		{
			return default(float4);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00002BAC File Offset: 0x00000DAC
		[Token(Token = "0x6000263")]
		[Address(RVA = "0x2767880", Offset = "0x2765E80", VA = "0x182767880")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float frobeniusNorm(this float4x4 m)
		{
			return 0f;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x2767A20", Offset = "0x2766020", VA = "0x182767A20")]
		public static void EigenSolve(float3x3 D, out float3 S, out float3x3 V)
		{
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00002BC4 File Offset: 0x00000DC4
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x2767F20", Offset = "0x2766520", VA = "0x182767F20")]
		private static float3 unitOrthogonal(this float3 input)
		{
			return default(float3);
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00002BDC File Offset: 0x00000DDC
		[Token(Token = "0x6000266")]
		[Address(RVA = "0x2768010", Offset = "0x2766610", VA = "0x182768010")]
		private static float3 EigenVector(float3x3 D, float S)
		{
			return default(float3);
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00002BF4 File Offset: 0x00000DF4
		[Token(Token = "0x6000267")]
		[Address(RVA = "0x27682F0", Offset = "0x27668F0", VA = "0x1827682F0")]
		private static float3 EigenValues(float3x3 D)
		{
			return default(float3);
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00002C0C File Offset: 0x00000E0C
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x2768550", Offset = "0x2766B50", VA = "0x182768550")]
		public static float4 NearestPointOnTri(in BurstMath.CachedTri tri, float4 p, out float4 bary)
		{
			return default(float4);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00002C24 File Offset: 0x00000E24
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x2768970", Offset = "0x2766F70", VA = "0x182768970")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 NearestPointOnEdge(float4 a, float4 b, float4 p, out float mu, bool clampToSegment = true)
		{
			return default(float4);
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00002C3C File Offset: 0x00000E3C
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x2768B70", Offset = "0x2767170", VA = "0x182768B70")]
		public static float4 NearestPointsTwoEdges(float4 a, float4 b, float4 c, float4 d, out float mu1, out float mu2)
		{
			return default(float4);
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00002C54 File Offset: 0x00000E54
		[Token(Token = "0x600026B")]
		[Address(RVA = "0x2768FD0", Offset = "0x27675D0", VA = "0x182768FD0")]
		public static float4 BaryCoords(in float4 A, in float4 B, in float4 C, in float4 P)
		{
			return default(float4);
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00002C6C File Offset: 0x00000E6C
		[Token(Token = "0x600026C")]
		[Address(RVA = "0x2769300", Offset = "0x2767900", VA = "0x182769300")]
		public static float4 BaryCoords2(in float4 A, in float4 B, in float4 P)
		{
			return default(float4);
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00002C84 File Offset: 0x00000E84
		[Token(Token = "0x600026D")]
		[Address(RVA = "0x2769430", Offset = "0x2767A30", VA = "0x182769430")]
		public static float4 BaryIntrpl(in float4 p1, in float4 p2, in float4 p3, in float4 coords)
		{
			return default(float4);
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00002C9C File Offset: 0x00000E9C
		[Token(Token = "0x600026E")]
		[Address(RVA = "0x2769560", Offset = "0x2767B60", VA = "0x182769560")]
		public static float4 BaryIntrpl(in float4 p1, in float4 p2, in float4 coords)
		{
			return default(float4);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00002CB4 File Offset: 0x00000EB4
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x2769640", Offset = "0x2767C40", VA = "0x182769640")]
		public static float BaryIntrpl(float p1, float p2, float p3, float4 coords)
		{
			return 0f;
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00002CCC File Offset: 0x00000ECC
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x2769660", Offset = "0x2767C60", VA = "0x182769660")]
		public static float BaryIntrpl(float p1, float p2, float4 coords)
		{
			return 0f;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00002CE4 File Offset: 0x00000EE4
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x2769680", Offset = "0x2767C80", VA = "0x182769680")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float BaryScale(float4 coords)
		{
			return 0f;
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00002CFC File Offset: 0x00000EFC
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x27696E0", Offset = "0x2767CE0", VA = "0x1827696E0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 BarycenterForSimplexOfSize(int simplexSize)
		{
			return default(float4);
		}

		// Token: 0x04000193 RID: 403
		[Token(Token = "0x4000193")]
		public const float epsilon = 1E-07f;

		// Token: 0x04000194 RID: 404
		[Token(Token = "0x4000194")]
		public const float zero = 0f;

		// Token: 0x04000195 RID: 405
		[Token(Token = "0x4000195")]
		public const float one = 1f;

		// Token: 0x0200004E RID: 78
		[Token(Token = "0x200004E")]
		public struct CachedTri
		{
			// Token: 0x06000273 RID: 627 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x2769760", Offset = "0x2767D60", VA = "0x182769760")]
			public void Cache(float4 v1, float4 v2, float4 v3)
			{
			}

			// Token: 0x04000196 RID: 406
			[Token(Token = "0x4000196")]
			[FieldOffset(Offset = "0x0")]
			public float4 vertex;

			// Token: 0x04000197 RID: 407
			[Token(Token = "0x4000197")]
			[FieldOffset(Offset = "0x10")]
			public float4 edge0;

			// Token: 0x04000198 RID: 408
			[Token(Token = "0x4000198")]
			[FieldOffset(Offset = "0x20")]
			public float4 edge1;

			// Token: 0x04000199 RID: 409
			[Token(Token = "0x4000199")]
			[FieldOffset(Offset = "0x30")]
			public float4 data;
		}
	}
}
