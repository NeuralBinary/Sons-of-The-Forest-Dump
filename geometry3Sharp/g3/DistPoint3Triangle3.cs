using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200014D RID: 333
	[Token(Token = "0x200014D")]
	public class DistPoint3Triangle3
	{
		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000941 RID: 2369 RVA: 0x00006E84 File Offset: 0x00005084
		// (set) Token: 0x06000942 RID: 2370 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001A1")]
		public Vector3d Point
		{
			[Token(Token = "0x6000941")]
			[Address(RVA = "0x718F50", Offset = "0x717550", VA = "0x180718F50")]
			get
			{
				return default(Vector3d);
			}
			[Token(Token = "0x6000942")]
			[Address(RVA = "0x1FE7F20", Offset = "0x1FE6520", VA = "0x181FE7F20")]
			set
			{
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000943 RID: 2371 RVA: 0x00006E9C File Offset: 0x0000509C
		// (set) Token: 0x06000944 RID: 2372 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001A2")]
		public Triangle3d Triangle
		{
			[Token(Token = "0x6000943")]
			[Address(RVA = "0x1FE7F40", Offset = "0x1FE6540", VA = "0x181FE7F40")]
			get
			{
				return default(Triangle3d);
			}
			[Token(Token = "0x6000944")]
			[Address(RVA = "0x1FE7F70", Offset = "0x1FE6570", VA = "0x181FE7F70")]
			set
			{
			}
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000945")]
		[Address(RVA = "0x1FE7FB0", Offset = "0x1FE65B0", VA = "0x181FE7FB0")]
		public DistPoint3Triangle3(Vector3d PointIn, Triangle3d TriangleIn)
		{
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000946")]
		[Address(RVA = "0x1FE8000", Offset = "0x1FE6600", VA = "0x181FE8000")]
		public DistPoint3Triangle3 Compute()
		{
			return null;
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x00006EB4 File Offset: 0x000050B4
		[Token(Token = "0x6000947")]
		[Address(RVA = "0x1FE8050", Offset = "0x1FE6650", VA = "0x181FE8050")]
		public double Get()
		{
			return 0.0;
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x00006ECC File Offset: 0x000050CC
		[Token(Token = "0x6000948")]
		[Address(RVA = "0x1FE8100", Offset = "0x1FE6700", VA = "0x181FE8100")]
		public double GetSquared()
		{
			return 0.0;
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x00006EE4 File Offset: 0x000050E4
		[Token(Token = "0x6000949")]
		[Address(RVA = "0x1FE8150", Offset = "0x1FE6750", VA = "0x181FE8150")]
		public static double DistanceSqr(ref Vector3d point, ref Triangle3d triangle, out Vector3d closestPoint, out Vector3d baryCoords)
		{
			return 0.0;
		}

		// Token: 0x0400050A RID: 1290
		[Token(Token = "0x400050A")]
		[FieldOffset(Offset = "0x10")]
		private Vector3d point;

		// Token: 0x0400050B RID: 1291
		[Token(Token = "0x400050B")]
		[FieldOffset(Offset = "0x28")]
		private Triangle3d triangle;

		// Token: 0x0400050C RID: 1292
		[Token(Token = "0x400050C")]
		[FieldOffset(Offset = "0x70")]
		public double DistanceSquared;

		// Token: 0x0400050D RID: 1293
		[Token(Token = "0x400050D")]
		[FieldOffset(Offset = "0x78")]
		public Vector3d TriangleClosest;

		// Token: 0x0400050E RID: 1294
		[Token(Token = "0x400050E")]
		[FieldOffset(Offset = "0x90")]
		public Vector3d TriangleBaryCoords;
	}
}
