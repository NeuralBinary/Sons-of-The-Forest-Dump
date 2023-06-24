using System;
using Il2CppDummyDll;
using UnityEngine;

namespace g3
{
	// Token: 0x020001F6 RID: 502
	[Token(Token = "0x20001F6")]
	public struct Ray3d
	{
		// Token: 0x0600106F RID: 4207 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600106F")]
		[Address(RVA = "0x1E44220", Offset = "0x1E42820", VA = "0x181E44220")]
		public Ray3d(Vector3d origin, Vector3d direction, bool bIsNormalized = false)
		{
		}

		// Token: 0x06001070 RID: 4208 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001070")]
		[Address(RVA = "0x1E44280", Offset = "0x1E42880", VA = "0x181E44280")]
		public Ray3d(Vector3f origin, Vector3f direction)
		{
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x0000C644 File Offset: 0x0000A844
		[Token(Token = "0x6001071")]
		[Address(RVA = "0x1E44360", Offset = "0x1E42960", VA = "0x181E44360")]
		public Vector3d PointAt(double d)
		{
			return default(Vector3d);
		}

		// Token: 0x06001072 RID: 4210 RVA: 0x0000C65C File Offset: 0x0000A85C
		[Token(Token = "0x6001072")]
		[Address(RVA = "0x1E44430", Offset = "0x1E42A30", VA = "0x181E44430")]
		public double Project(Vector3d p)
		{
			return 0.0;
		}

		// Token: 0x06001073 RID: 4211 RVA: 0x0000C674 File Offset: 0x0000A874
		[Token(Token = "0x6001073")]
		[Address(RVA = "0x1E444E0", Offset = "0x1E42AE0", VA = "0x181E444E0")]
		public double DistanceSquared(Vector3d p)
		{
			return 0.0;
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x0000C68C File Offset: 0x0000A88C
		[Token(Token = "0x6001074")]
		[Address(RVA = "0x1E44690", Offset = "0x1E42C90", VA = "0x181E44690")]
		public Vector3d ClosestPoint(Vector3d p)
		{
			return default(Vector3d);
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x0000C6A4 File Offset: 0x0000A8A4
		[Token(Token = "0x6001075")]
		[Address(RVA = "0x1E447F0", Offset = "0x1E42DF0", VA = "0x181E447F0")]
		public static implicit operator Ray3d(Ray3f v)
		{
			return default(Ray3d);
		}

		// Token: 0x06001076 RID: 4214 RVA: 0x0000C6BC File Offset: 0x0000A8BC
		[Token(Token = "0x6001076")]
		[Address(RVA = "0x1E449F0", Offset = "0x1E42FF0", VA = "0x181E449F0")]
		public static explicit operator Ray3f(Ray3d v)
		{
			return default(Ray3f);
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x0000C6D4 File Offset: 0x0000A8D4
		[Token(Token = "0x6001077")]
		[Address(RVA = "0x1E44C20", Offset = "0x1E43220", VA = "0x181E44C20")]
		public static implicit operator Ray3d(Ray r)
		{
			return default(Ray3d);
		}

		// Token: 0x06001078 RID: 4216 RVA: 0x0000C6EC File Offset: 0x0000A8EC
		[Token(Token = "0x6001078")]
		[Address(RVA = "0x1E44E30", Offset = "0x1E43430", VA = "0x181E44E30")]
		public static explicit operator Ray(Ray3d r)
		{
			return default(Ray);
		}

		// Token: 0x04000818 RID: 2072
		[Token(Token = "0x4000818")]
		[FieldOffset(Offset = "0x0")]
		public Vector3d Origin;

		// Token: 0x04000819 RID: 2073
		[Token(Token = "0x4000819")]
		[FieldOffset(Offset = "0x18")]
		public Vector3d Direction;
	}
}
