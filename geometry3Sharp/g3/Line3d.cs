using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001E1 RID: 481
	[Token(Token = "0x20001E1")]
	public struct Line3d
	{
		// Token: 0x06000EE7 RID: 3815 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000EE7")]
		[Address(RVA = "0x1E306B0", Offset = "0x1E2ECB0", VA = "0x181E306B0")]
		public Line3d(Vector3d origin, Vector3d direction)
		{
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x0000AFDC File Offset: 0x000091DC
		[Token(Token = "0x6000EE8")]
		[Address(RVA = "0x1E306E0", Offset = "0x1E2ECE0", VA = "0x181E306E0")]
		public Vector3d PointAt(double d)
		{
			return default(Vector3d);
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x0000AFF4 File Offset: 0x000091F4
		[Token(Token = "0x6000EE9")]
		[Address(RVA = "0x1E307B0", Offset = "0x1E2EDB0", VA = "0x181E307B0")]
		public double Project(Vector3d p)
		{
			return 0.0;
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x0000B00C File Offset: 0x0000920C
		[Token(Token = "0x6000EEA")]
		[Address(RVA = "0x1E30860", Offset = "0x1E2EE60", VA = "0x181E30860")]
		public double DistanceSquared(Vector3d p)
		{
			return 0.0;
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x0000B024 File Offset: 0x00009224
		[Token(Token = "0x6000EEB")]
		[Address(RVA = "0x1E30970", Offset = "0x1E2EF70", VA = "0x181E30970")]
		public Vector3d ClosestPoint(Vector3d p)
		{
			return default(Vector3d);
		}

		// Token: 0x06000EEC RID: 3820 RVA: 0x0000B03C File Offset: 0x0000923C
		[Token(Token = "0x6000EEC")]
		[Address(RVA = "0x1E30A70", Offset = "0x1E2F070", VA = "0x181E30A70")]
		public static implicit operator Line3d(Line3f v)
		{
			return default(Line3d);
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x0000B054 File Offset: 0x00009254
		[Token(Token = "0x6000EED")]
		[Address(RVA = "0x1E30B40", Offset = "0x1E2F140", VA = "0x181E30B40")]
		public static explicit operator Line3f(Line3d v)
		{
			return default(Line3f);
		}

		// Token: 0x040007BF RID: 1983
		[Token(Token = "0x40007BF")]
		[FieldOffset(Offset = "0x0")]
		public Vector3d Origin;

		// Token: 0x040007C0 RID: 1984
		[Token(Token = "0x40007C0")]
		[FieldOffset(Offset = "0x18")]
		public Vector3d Direction;
	}
}
