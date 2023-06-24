using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000208 RID: 520
	[Token(Token = "0x2000208")]
	public struct Triangle3d
	{
		// Token: 0x06001112 RID: 4370 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001112")]
		[Address(RVA = "0x1E4E120", Offset = "0x1E4C720", VA = "0x181E4E120")]
		public Triangle3d(Vector3d v0, Vector3d v1, Vector3d v2)
		{
		}

		// Token: 0x170002BF RID: 703
		[Token(Token = "0x170002BF")]
		public Vector3d this[int key]
		{
			[Token(Token = "0x6001113")]
			[Address(RVA = "0x1E38660", Offset = "0x1E36C60", VA = "0x181E38660")]
			get
			{
				return default(Vector3d);
			}
			[Token(Token = "0x6001114")]
			[Address(RVA = "0x1E4E160", Offset = "0x1E4C760", VA = "0x181E4E160")]
			set
			{
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06001115 RID: 4373 RVA: 0x0000CF5C File Offset: 0x0000B15C
		[Token(Token = "0x170002C0")]
		public Vector3d Normal
		{
			[Token(Token = "0x6001115")]
			[Address(RVA = "0x1E4E1A0", Offset = "0x1E4C7A0", VA = "0x181E4E1A0")]
			get
			{
				return default(Vector3d);
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06001116 RID: 4374 RVA: 0x0000CF74 File Offset: 0x0000B174
		[Token(Token = "0x170002C1")]
		public double Area
		{
			[Token(Token = "0x6001116")]
			[Address(RVA = "0x1E4E240", Offset = "0x1E4C840", VA = "0x181E4E240")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06001117 RID: 4375 RVA: 0x0000CF8C File Offset: 0x0000B18C
		[Token(Token = "0x170002C2")]
		public double AspectRatio
		{
			[Token(Token = "0x6001117")]
			[Address(RVA = "0x1E4E2B0", Offset = "0x1E4C8B0", VA = "0x181E4E2B0")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x0000CFA4 File Offset: 0x0000B1A4
		[Token(Token = "0x6001118")]
		[Address(RVA = "0x1E4E320", Offset = "0x1E4C920", VA = "0x181E4E320")]
		public Vector3d PointAt(double bary0, double bary1, double bary2)
		{
			return default(Vector3d);
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x0000CFBC File Offset: 0x0000B1BC
		[Token(Token = "0x6001119")]
		[Address(RVA = "0x1E4E440", Offset = "0x1E4CA40", VA = "0x181E4E440")]
		public Vector3d PointAt(Vector3d bary)
		{
			return default(Vector3d);
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x0000CFD4 File Offset: 0x0000B1D4
		[Token(Token = "0x600111A")]
		[Address(RVA = "0x1E4E550", Offset = "0x1E4CB50", VA = "0x181E4E550")]
		public Vector3d BarycentricCoords(Vector3d point)
		{
			return default(Vector3d);
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x0000CFEC File Offset: 0x0000B1EC
		[Token(Token = "0x600111B")]
		[Address(RVA = "0x1E4E6D0", Offset = "0x1E4CCD0", VA = "0x181E4E6D0")]
		public static implicit operator Triangle3d(Triangle3f v)
		{
			return default(Triangle3d);
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x0000D004 File Offset: 0x0000B204
		[Token(Token = "0x600111C")]
		[Address(RVA = "0x1E4E810", Offset = "0x1E4CE10", VA = "0x181E4E810")]
		public static explicit operator Triangle3f(Triangle3d v)
		{
			return default(Triangle3f);
		}

		// Token: 0x04000849 RID: 2121
		[Token(Token = "0x4000849")]
		[FieldOffset(Offset = "0x0")]
		public Vector3d V0;

		// Token: 0x0400084A RID: 2122
		[Token(Token = "0x400084A")]
		[FieldOffset(Offset = "0x18")]
		public Vector3d V1;

		// Token: 0x0400084B RID: 2123
		[Token(Token = "0x400084B")]
		[FieldOffset(Offset = "0x30")]
		public Vector3d V2;
	}
}
