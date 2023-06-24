using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace MTAssets.UltimateLODSystem.MeshSimplifier
{
	// Token: 0x02000068 RID: 104
	[Token(Token = "0x2000068")]
	public struct Vector3d : IEquatable<Vector3d>
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600018F RID: 399 RVA: 0x000026D0 File Offset: 0x000008D0
		[Token(Token = "0x17000013")]
		public double Magnitude
		{
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x5F91D0", Offset = "0x5F77D0", VA = "0x1805F91D0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000190 RID: 400 RVA: 0x000026E8 File Offset: 0x000008E8
		[Token(Token = "0x17000014")]
		public double MagnitudeSqr
		{
			[Token(Token = "0x6000190")]
			[Address(RVA = "0x5F9270", Offset = "0x5F7870", VA = "0x1805F9270")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000191 RID: 401 RVA: 0x00002700 File Offset: 0x00000900
		[Token(Token = "0x17000015")]
		public Vector3d Normalized
		{
			[Token(Token = "0x6000191")]
			[Address(RVA = "0x5F92A0", Offset = "0x5F78A0", VA = "0x1805F92A0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return default(Vector3d);
			}
		}

		// Token: 0x17000016 RID: 22
		[Token(Token = "0x17000016")]
		public double this[int index]
		{
			[Token(Token = "0x6000192")]
			[Address(RVA = "0x5F9310", Offset = "0x5F7910", VA = "0x1805F9310")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x5F93B0", Offset = "0x5F79B0", VA = "0x1805F93B0")]
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set
			{
			}
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x5F9450", Offset = "0x5F7A50", VA = "0x1805F9450")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Vector3d(double value)
		{
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x5F9460", Offset = "0x5F7A60", VA = "0x1805F9460")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Vector3d(double x, double y, double z)
		{
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x5F9470", Offset = "0x5F7A70", VA = "0x1805F9470")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Vector3d(Vector3 vector)
		{
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00002730 File Offset: 0x00000930
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x5F94A0", Offset = "0x5F7AA0", VA = "0x1805F94A0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3d operator +(Vector3d a, Vector3d b)
		{
			return default(Vector3d);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00002748 File Offset: 0x00000948
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x5F94E0", Offset = "0x5F7AE0", VA = "0x1805F94E0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3d operator -(Vector3d a, Vector3d b)
		{
			return default(Vector3d);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00002760 File Offset: 0x00000960
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x5F9520", Offset = "0x5F7B20", VA = "0x1805F9520")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3d operator *(Vector3d a, double d)
		{
			return default(Vector3d);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00002778 File Offset: 0x00000978
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x5F9540", Offset = "0x5F7B40", VA = "0x1805F9540")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3d operator *(double d, Vector3d a)
		{
			return default(Vector3d);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00002790 File Offset: 0x00000990
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x5F9560", Offset = "0x5F7B60", VA = "0x1805F9560")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3d operator /(Vector3d a, double d)
		{
			return default(Vector3d);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x000027A8 File Offset: 0x000009A8
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x5F9580", Offset = "0x5F7B80", VA = "0x1805F9580")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3d operator -(Vector3d a)
		{
			return default(Vector3d);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x000027C0 File Offset: 0x000009C0
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x5F95B0", Offset = "0x5F7BB0", VA = "0x1805F95B0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(Vector3d lhs, Vector3d rhs)
		{
			return default(bool);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x000027D8 File Offset: 0x000009D8
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x5F9650", Offset = "0x5F7C50", VA = "0x1805F9650")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator !=(Vector3d lhs, Vector3d rhs)
		{
			return default(bool);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x000027F0 File Offset: 0x000009F0
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x5F96E0", Offset = "0x5F7CE0", VA = "0x1805F96E0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static implicit operator Vector3d(Vector3 v)
		{
			return default(Vector3d);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00002808 File Offset: 0x00000A08
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x5F9710", Offset = "0x5F7D10", VA = "0x1805F9710")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static explicit operator Vector3(Vector3d v)
		{
			return default(Vector3);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x5F9460", Offset = "0x5F7A60", VA = "0x1805F9460")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Set(double x, double y, double z)
		{
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x5F9740", Offset = "0x5F7D40", VA = "0x1805F9740")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Scale(ref Vector3d scale)
		{
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x5F9770", Offset = "0x5F7D70", VA = "0x1805F9770")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Normalize()
		{
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x5F97D0", Offset = "0x5F7DD0", VA = "0x1805F97D0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Clamp(double min, double max)
		{
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00002820 File Offset: 0x00000A20
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x5F9830", Offset = "0x5F7E30", VA = "0x1805F9830", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00002838 File Offset: 0x00000A38
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x5F98D0", Offset = "0x5F7ED0", VA = "0x1805F98D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002850 File Offset: 0x00000A50
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x5F9990", Offset = "0x5F7F90", VA = "0x1805F9990", Slot = "4")]
		public bool Equals(Vector3d other)
		{
			return default(bool);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x5F99D0", Offset = "0x5F7FD0", VA = "0x1805F99D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x5F9AA0", Offset = "0x5F80A0", VA = "0x1805F9AA0")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00002868 File Offset: 0x00000A68
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x5F9B40", Offset = "0x5F8140", VA = "0x1805F9B40")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double Dot(ref Vector3d lhs, ref Vector3d rhs)
		{
			return 0.0;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x5F9B70", Offset = "0x5F8170", VA = "0x1805F9B70")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Cross(ref Vector3d lhs, ref Vector3d rhs, out Vector3d result)
		{
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00002880 File Offset: 0x00000A80
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x5F9BF0", Offset = "0x5F81F0", VA = "0x1805F9BF0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double Angle(ref Vector3d from, ref Vector3d to)
		{
			return 0.0;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x5F9D60", Offset = "0x5F8360", VA = "0x1805F9D60")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Lerp(ref Vector3d a, ref Vector3d b, double t, out Vector3d result)
		{
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x5F9DB0", Offset = "0x5F83B0", VA = "0x1805F9DB0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Scale(ref Vector3d a, ref Vector3d b, out Vector3d result)
		{
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x5F9DF0", Offset = "0x5F83F0", VA = "0x1805F9DF0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Normalize(ref Vector3d value, out Vector3d result)
		{
		}

		// Token: 0x040002DE RID: 734
		[Token(Token = "0x40002DE")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Vector3d zero;

		// Token: 0x040002DF RID: 735
		[Token(Token = "0x40002DF")]
		public const double Epsilon = 5E-324;

		// Token: 0x040002E0 RID: 736
		[Token(Token = "0x40002E0")]
		[FieldOffset(Offset = "0x0")]
		public double x;

		// Token: 0x040002E1 RID: 737
		[Token(Token = "0x40002E1")]
		[FieldOffset(Offset = "0x8")]
		public double y;

		// Token: 0x040002E2 RID: 738
		[Token(Token = "0x40002E2")]
		[FieldOffset(Offset = "0x10")]
		public double z;
	}
}
