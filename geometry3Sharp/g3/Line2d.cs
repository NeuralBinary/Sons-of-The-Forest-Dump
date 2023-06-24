using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001DF RID: 479
	[Token(Token = "0x20001DF")]
	public struct Line2d
	{
		// Token: 0x06000ED7 RID: 3799 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ED7")]
		[Address(RVA = "0x15C8940", Offset = "0x15C6F40", VA = "0x1815C8940")]
		public Line2d(Vector2d origin, Vector2d direction)
		{
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ED8")]
		[Address(RVA = "0x1E2FC20", Offset = "0x1E2E220", VA = "0x181E2FC20")]
		public Line2d(ref Vector2d origin, ref Vector2d direction)
		{
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x0000AEA4 File Offset: 0x000090A4
		[Token(Token = "0x6000ED9")]
		[Address(RVA = "0x1E2FC40", Offset = "0x1E2E240", VA = "0x181E2FC40")]
		public static Line2d FromPoints(Vector2d p0, Vector2d p1)
		{
			return default(Line2d);
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x0000AEBC File Offset: 0x000090BC
		[Token(Token = "0x6000EDA")]
		[Address(RVA = "0x1E2FDF0", Offset = "0x1E2E3F0", VA = "0x181E2FDF0")]
		public static Line2d FromPoints(ref Vector2d p0, ref Vector2d p1)
		{
			return default(Line2d);
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x0000AED4 File Offset: 0x000090D4
		[Token(Token = "0x6000EDB")]
		[Address(RVA = "0x1E2FFA0", Offset = "0x1E2E5A0", VA = "0x181E2FFA0")]
		public Vector2d PointAt(double d)
		{
			return default(Vector2d);
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x0000AEEC File Offset: 0x000090EC
		[Token(Token = "0x6000EDC")]
		[Address(RVA = "0x1E30050", Offset = "0x1E2E650", VA = "0x181E30050")]
		public double Project(Vector2d p)
		{
			return 0.0;
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x0000AF04 File Offset: 0x00009104
		[Token(Token = "0x6000EDD")]
		[Address(RVA = "0x1E300E0", Offset = "0x1E2E6E0", VA = "0x181E300E0")]
		public double DistanceSquared(Vector2d p)
		{
			return 0.0;
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x0000AF1C File Offset: 0x0000911C
		[Token(Token = "0x6000EDE")]
		[Address(RVA = "0x1E301B0", Offset = "0x1E2E7B0", VA = "0x181E301B0")]
		public int WhichSide(Vector2d test, double tol = 0.0)
		{
			return 0;
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x0000AF34 File Offset: 0x00009134
		[Token(Token = "0x6000EDF")]
		[Address(RVA = "0x1E301B0", Offset = "0x1E2E7B0", VA = "0x181E301B0")]
		public int WhichSide(ref Vector2d test, double tol = 0.0)
		{
			return 0;
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x0000AF4C File Offset: 0x0000914C
		[Token(Token = "0x6000EE0")]
		[Address(RVA = "0x1E301F0", Offset = "0x1E2E7F0", VA = "0x181E301F0")]
		public Vector2d IntersectionPoint(ref Line2d other, double dotThresh = 1E-08)
		{
			return default(Vector2d);
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x0000AF64 File Offset: 0x00009164
		[Token(Token = "0x6000EE1")]
		[Address(RVA = "0x1E303A0", Offset = "0x1E2E9A0", VA = "0x181E303A0")]
		public static implicit operator Line2d(Line2f v)
		{
			return default(Line2d);
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x0000AF7C File Offset: 0x0000917C
		[Token(Token = "0x6000EE2")]
		[Address(RVA = "0x1E30440", Offset = "0x1E2EA40", VA = "0x181E30440")]
		public static explicit operator Line2f(Line2d v)
		{
			return default(Line2f);
		}

		// Token: 0x040007BB RID: 1979
		[Token(Token = "0x40007BB")]
		[FieldOffset(Offset = "0x0")]
		public Vector2d Origin;

		// Token: 0x040007BC RID: 1980
		[Token(Token = "0x40007BC")]
		[FieldOffset(Offset = "0x10")]
		public Vector2d Direction;
	}
}
