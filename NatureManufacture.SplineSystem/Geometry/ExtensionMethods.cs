using System;
using Il2CppDummyDll;
using TriangleNet.Meshing;

namespace TriangleNet.Geometry
{
	// Token: 0x02000071 RID: 113
	[Token(Token = "0x2000071")]
	public static class ExtensionMethods
	{
		// Token: 0x0600034F RID: 847 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600034F")]
		[Address(RVA = "0x24E8F30", Offset = "0x24E7530", VA = "0x1824E8F30")]
		public static IMesh Triangulate(this IPolygon polygon)
		{
			return null;
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000350")]
		[Address(RVA = "0x24E8FB0", Offset = "0x24E75B0", VA = "0x1824E8FB0")]
		public static IMesh Triangulate(this IPolygon polygon, ConstraintOptions options)
		{
			return null;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000351")]
		[Address(RVA = "0x24E9030", Offset = "0x24E7630", VA = "0x1824E9030")]
		public static IMesh Triangulate(this IPolygon polygon, QualityOptions quality)
		{
			return null;
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000352")]
		[Address(RVA = "0x24E90B0", Offset = "0x24E76B0", VA = "0x1824E90B0")]
		public static IMesh Triangulate(this IPolygon polygon, ConstraintOptions options, QualityOptions quality)
		{
			return null;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000353")]
		[Address(RVA = "0x24E9140", Offset = "0x24E7740", VA = "0x1824E9140")]
		public static IMesh Triangulate(this IPolygon polygon, ConstraintOptions options, QualityOptions quality, ITriangulator triangulator)
		{
			return null;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00003108 File Offset: 0x00001308
		[Token(Token = "0x6000354")]
		[Address(RVA = "0x24E9220", Offset = "0x24E7820", VA = "0x1824E9220")]
		public static bool Contains(this ITriangle triangle, Point p)
		{
			return default(bool);
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00003120 File Offset: 0x00001320
		[Token(Token = "0x6000355")]
		[Address(RVA = "0x24E9250", Offset = "0x24E7850", VA = "0x1824E9250")]
		public static bool Contains(this ITriangle triangle, double x, double y)
		{
			return default(bool);
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000356")]
		[Address(RVA = "0x24E9530", Offset = "0x24E7B30", VA = "0x1824E9530")]
		public static Rectangle Bounds(this ITriangle triangle)
		{
			return null;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00003138 File Offset: 0x00001338
		[Token(Token = "0x6000357")]
		[Address(RVA = "0x24C05E0", Offset = "0x24BEBE0", VA = "0x1824C05E0")]
		internal static double DotProduct(Point p, Point q)
		{
			return 0.0;
		}
	}
}
