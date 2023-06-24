using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020003A3 RID: 931
	[Token(Token = "0x20003A3")]
	public class GeneralPolygon2dBoxTree
	{
		// Token: 0x06001E00 RID: 7680 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E00")]
		[Address(RVA = "0x1F8B380", Offset = "0x1F89980", VA = "0x181F8B380")]
		public GeneralPolygon2dBoxTree(GeneralPolygon2d poly)
		{
		}

		// Token: 0x06001E01 RID: 7681 RVA: 0x0001505C File Offset: 0x0001325C
		[Token(Token = "0x6001E01")]
		[Address(RVA = "0x1F8B810", Offset = "0x1F89E10", VA = "0x181F8B810")]
		public double DistanceSquared(Vector2d pt, out int iHoleIndex, out int iNearSeg, out double fNearSegT)
		{
			return 0.0;
		}

		// Token: 0x06001E02 RID: 7682 RVA: 0x00015074 File Offset: 0x00013274
		[Token(Token = "0x6001E02")]
		[Address(RVA = "0x1F8BA60", Offset = "0x1F8A060", VA = "0x181F8BA60")]
		public double DistanceSquared(Vector2d pt)
		{
			return 0.0;
		}

		// Token: 0x06001E03 RID: 7683 RVA: 0x0001508C File Offset: 0x0001328C
		[Token(Token = "0x6001E03")]
		[Address(RVA = "0x1F8BAB0", Offset = "0x1F8A0B0", VA = "0x181F8BAB0")]
		public double Distance(Vector2d pt)
		{
			return 0.0;
		}

		// Token: 0x06001E04 RID: 7684 RVA: 0x000150A4 File Offset: 0x000132A4
		[Token(Token = "0x6001E04")]
		[Address(RVA = "0x1F8BB80", Offset = "0x1F8A180", VA = "0x181F8BB80")]
		public Vector2d NearestPoint(Vector2d pt)
		{
			return default(Vector2d);
		}

		// Token: 0x0400105A RID: 4186
		[Token(Token = "0x400105A")]
		[FieldOffset(Offset = "0x10")]
		public GeneralPolygon2d Polygon;

		// Token: 0x0400105B RID: 4187
		[Token(Token = "0x400105B")]
		[FieldOffset(Offset = "0x18")]
		private Polygon2dBoxTree OuterTree;

		// Token: 0x0400105C RID: 4188
		[Token(Token = "0x400105C")]
		[FieldOffset(Offset = "0x20")]
		private Polygon2dBoxTree[] HoleTrees;
	}
}
