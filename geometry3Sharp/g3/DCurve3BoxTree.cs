using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000356 RID: 854
	[Token(Token = "0x2000356")]
	public class DCurve3BoxTree
	{
		// Token: 0x06001C2E RID: 7214 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C2E")]
		[Address(RVA = "0x1F67530", Offset = "0x1F65B30", VA = "0x181F67530")]
		public DCurve3BoxTree(DCurve3 curve)
		{
		}

		// Token: 0x06001C2F RID: 7215 RVA: 0x00013F64 File Offset: 0x00012164
		[Token(Token = "0x6001C2F")]
		[Address(RVA = "0x1F67590", Offset = "0x1F65B90", VA = "0x181F67590")]
		public double DistanceSquared(Vector3d pt)
		{
			return 0.0;
		}

		// Token: 0x06001C30 RID: 7216 RVA: 0x00013F7C File Offset: 0x0001217C
		[Token(Token = "0x6001C30")]
		[Address(RVA = "0x1F67640", Offset = "0x1F65C40", VA = "0x181F67640")]
		public double Distance(Vector3d pt)
		{
			return 0.0;
		}

		// Token: 0x06001C31 RID: 7217 RVA: 0x00013F94 File Offset: 0x00012194
		[Token(Token = "0x6001C31")]
		[Address(RVA = "0x1F67770", Offset = "0x1F65D70", VA = "0x181F67770")]
		public Vector3d NearestPoint(Vector3d pt)
		{
			return default(Vector3d);
		}

		// Token: 0x06001C32 RID: 7218 RVA: 0x00013FAC File Offset: 0x000121AC
		[Token(Token = "0x6001C32")]
		[Address(RVA = "0x1F67870", Offset = "0x1F65E70", VA = "0x181F67870")]
		public double SquaredDistance(Vector3d pt, out int iNearSeg, out double fNearSegT, double max_dist = 1.7976931348623157E+308)
		{
			return 0.0;
		}

		// Token: 0x06001C33 RID: 7219 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C33")]
		[Address(RVA = "0x1F67900", Offset = "0x1F65F00", VA = "0x181F67900")]
		private void find_min_distance(ref Vector3d pt, ref double min_dist, ref int min_dist_seg, ref double min_dist_segt, int bi, int iLayerStart, int iLayer)
		{
		}

		// Token: 0x06001C34 RID: 7220 RVA: 0x00013FC4 File Offset: 0x000121C4
		[Token(Token = "0x6001C34")]
		[Address(RVA = "0x1F67C60", Offset = "0x1F66260", VA = "0x181F67C60")]
		public double SquaredDistance(Ray3d ray, out int iNearSeg, out double fNearSegT, out double fRayT, double max_dist = 1.7976931348623157E+308)
		{
			return 0.0;
		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C35")]
		[Address(RVA = "0x1F67D10", Offset = "0x1F66310", VA = "0x181F67D10")]
		private void find_min_distance(ref Ray3d ray, ref double min_dist, ref int min_dist_seg, ref double min_dist_segt, ref double min_dist_rayt, int bi, int iLayerStart, int iLayer)
		{
		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x00013FDC File Offset: 0x000121DC
		[Token(Token = "0x6001C36")]
		[Address(RVA = "0x1F68150", Offset = "0x1F66750", VA = "0x181F68150")]
		public bool FindClosestRayIntersction(Ray3d ray, double radius, out int hitSegment, out double fRayT)
		{
			return default(bool);
		}

		// Token: 0x06001C37 RID: 7223 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C37")]
		[Address(RVA = "0x1F681C0", Offset = "0x1F667C0", VA = "0x181F681C0")]
		private void find_closest_ray_intersction(ref Ray3d ray, double radius, ref int nearestSegment, ref double nearest_ray_t, int bi, int iLayerStart, int iLayer)
		{
		}

		// Token: 0x06001C38 RID: 7224 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001C38")]
		[Address(RVA = "0x1F68560", Offset = "0x1F66B60", VA = "0x181F68560")]
		private void build_sequential(DCurve3 curve)
		{
		}

		// Token: 0x04000F07 RID: 3847
		[Token(Token = "0x4000F07")]
		[FieldOffset(Offset = "0x10")]
		public DCurve3 Curve;

		// Token: 0x04000F08 RID: 3848
		[Token(Token = "0x4000F08")]
		[FieldOffset(Offset = "0x18")]
		private Box3d[] boxes;

		// Token: 0x04000F09 RID: 3849
		[Token(Token = "0x4000F09")]
		[FieldOffset(Offset = "0x20")]
		private int layers;

		// Token: 0x04000F0A RID: 3850
		[Token(Token = "0x4000F0A")]
		[FieldOffset(Offset = "0x28")]
		private List<int> layer_counts;
	}
}
