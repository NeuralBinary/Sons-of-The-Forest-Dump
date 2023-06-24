using System;
using Il2CppDummyDll;
using TriangleNet.Geometry;

namespace TriangleNet.Tools
{
	// Token: 0x02000038 RID: 56
	[Token(Token = "0x2000038")]
	public static class PolygonValidator
	{
		// Token: 0x060001E2 RID: 482 RVA: 0x000029A0 File Offset: 0x00000BA0
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x24BB530", Offset = "0x24B9B30", VA = "0x1824BB530")]
		public static bool IsConsistent(IPolygon poly)
		{
			return default(bool);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x000029B8 File Offset: 0x00000BB8
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x24BBD70", Offset = "0x24BA370", VA = "0x1824BBD70")]
		public static bool HasDuplicateVertices(IPolygon poly)
		{
			return default(bool);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x000029D0 File Offset: 0x00000BD0
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x24BBF90", Offset = "0x24BA590", VA = "0x1824BBF90")]
		public static bool HasBadAngles(IPolygon poly, double threshold = 2E-12)
		{
			return default(bool);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x000029E8 File Offset: 0x00000BE8
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x24BC540", Offset = "0x24BAB40", VA = "0x1824BC540")]
		private static bool IsBadAngle(Point a, Point b, Point c, double threshold = 0.0)
		{
			return default(bool);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00002A00 File Offset: 0x00000C00
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x24BC640", Offset = "0x24BAC40", VA = "0x1824BC640")]
		private static double DotProduct(Point a, Point b, Point c)
		{
			return 0.0;
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00002A18 File Offset: 0x00000C18
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x24BC6A0", Offset = "0x24BACA0", VA = "0x1824BC6A0")]
		private static double CrossProductLength(Point a, Point b, Point c)
		{
			return 0.0;
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00002A30 File Offset: 0x00000C30
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x24BC700", Offset = "0x24BAD00", VA = "0x1824BC700")]
		private static int CheckVertexIDs(IPolygon poly, int count)
		{
			return 0;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00002A48 File Offset: 0x00000C48
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x24BCB60", Offset = "0x24BB160", VA = "0x1824BCB60")]
		private static int CheckDuplicateIDs(IPolygon poly)
		{
			return 0;
		}
	}
}
