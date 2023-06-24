using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020003A4 RID: 932
	[Token(Token = "0x20003A4")]
	public class Polygon2dBoxTree
	{
		// Token: 0x06001E05 RID: 7685 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E05")]
		[Address(RVA = "0x1F8BCA0", Offset = "0x1F8A2A0", VA = "0x181F8BCA0")]
		public Polygon2dBoxTree(Polygon2d poly)
		{
		}

		// Token: 0x06001E06 RID: 7686 RVA: 0x000150BC File Offset: 0x000132BC
		[Token(Token = "0x6001E06")]
		[Address(RVA = "0x1F8BD00", Offset = "0x1F8A300", VA = "0x181F8BD00")]
		public double DistanceSquared(Vector2d pt)
		{
			return 0.0;
		}

		// Token: 0x06001E07 RID: 7687 RVA: 0x000150D4 File Offset: 0x000132D4
		[Token(Token = "0x6001E07")]
		[Address(RVA = "0x1F8BDA0", Offset = "0x1F8A3A0", VA = "0x181F8BDA0")]
		public double Distance(Vector2d pt)
		{
			return 0.0;
		}

		// Token: 0x06001E08 RID: 7688 RVA: 0x000150EC File Offset: 0x000132EC
		[Token(Token = "0x6001E08")]
		[Address(RVA = "0x1F8BEC0", Offset = "0x1F8A4C0", VA = "0x181F8BEC0")]
		public Vector2d NearestPoint(Vector2d pt)
		{
			return default(Vector2d);
		}

		// Token: 0x06001E09 RID: 7689 RVA: 0x00015104 File Offset: 0x00013304
		[Token(Token = "0x6001E09")]
		[Address(RVA = "0x1F8BFA0", Offset = "0x1F8A5A0", VA = "0x181F8BFA0")]
		public double SquaredDistance(Vector2d pt, out int iNearSeg, out double fNearSegT, double max_dist = 1.7976931348623157E+308)
		{
			return 0.0;
		}

		// Token: 0x06001E0A RID: 7690 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E0A")]
		[Address(RVA = "0x1F8C030", Offset = "0x1F8A630", VA = "0x181F8C030")]
		private void find_min_distance(ref Vector2d pt, ref double min_dist, ref int min_dist_seg, ref double min_dist_segt, int bi, int iLayerStart, int iLayer)
		{
		}

		// Token: 0x06001E0B RID: 7691 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E0B")]
		[Address(RVA = "0x1F8C380", Offset = "0x1F8A980", VA = "0x181F8C380")]
		private void build_sequential(Polygon2d poly)
		{
		}

		// Token: 0x0400105D RID: 4189
		[Token(Token = "0x400105D")]
		[FieldOffset(Offset = "0x10")]
		public Polygon2d Polygon;

		// Token: 0x0400105E RID: 4190
		[Token(Token = "0x400105E")]
		[FieldOffset(Offset = "0x18")]
		private Box2d[] boxes;

		// Token: 0x0400105F RID: 4191
		[Token(Token = "0x400105F")]
		[FieldOffset(Offset = "0x20")]
		private int layers;

		// Token: 0x04001060 RID: 4192
		[Token(Token = "0x4001060")]
		[FieldOffset(Offset = "0x28")]
		private List<int> layer_counts;
	}
}
