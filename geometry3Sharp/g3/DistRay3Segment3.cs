using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200014F RID: 335
	[Token(Token = "0x200014F")]
	public class DistRay3Segment3
	{
		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000954 RID: 2388 RVA: 0x00006F8C File Offset: 0x0000518C
		// (set) Token: 0x06000955 RID: 2389 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001A5")]
		public Ray3d Ray
		{
			[Token(Token = "0x6000954")]
			[Address(RVA = "0x1B19AA0", Offset = "0x1B180A0", VA = "0x181B19AA0")]
			get
			{
				return default(Ray3d);
			}
			[Token(Token = "0x6000955")]
			[Address(RVA = "0x1FE5390", Offset = "0x1FE3990", VA = "0x181FE5390")]
			set
			{
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000956 RID: 2390 RVA: 0x00006FA4 File Offset: 0x000051A4
		// (set) Token: 0x06000957 RID: 2391 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001A6")]
		public Segment3d Segment
		{
			[Token(Token = "0x6000956")]
			[Address(RVA = "0x1FE53C0", Offset = "0x1FE39C0", VA = "0x181FE53C0")]
			get
			{
				return default(Segment3d);
			}
			[Token(Token = "0x6000957")]
			[Address(RVA = "0x1FE53F0", Offset = "0x1FE39F0", VA = "0x181FE53F0")]
			set
			{
			}
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000958")]
		[Address(RVA = "0x1FE8F40", Offset = "0x1FE7540", VA = "0x181FE8F40")]
		public DistRay3Segment3(Ray3d rayIn, Segment3d segmentIn)
		{
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x00006FBC File Offset: 0x000051BC
		[Token(Token = "0x6000959")]
		[Address(RVA = "0x1FE8F90", Offset = "0x1FE7590", VA = "0x181FE8F90")]
		public static double MinDistance(Ray3d r, Segment3d s)
		{
			return 0.0;
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x00006FD4 File Offset: 0x000051D4
		[Token(Token = "0x600095A")]
		[Address(RVA = "0x1FE9040", Offset = "0x1FE7640", VA = "0x181FE9040")]
		public static double MinDistanceSegmentParam(Ray3d r, Segment3d s)
		{
			return 0.0;
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600095B")]
		[Address(RVA = "0x1FE9080", Offset = "0x1FE7680", VA = "0x181FE9080")]
		public DistRay3Segment3 Compute()
		{
			return null;
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x00006FEC File Offset: 0x000051EC
		[Token(Token = "0x600095C")]
		[Address(RVA = "0x1FE90A0", Offset = "0x1FE76A0", VA = "0x181FE90A0")]
		public double Get()
		{
			return 0.0;
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x00007004 File Offset: 0x00005204
		[Token(Token = "0x600095D")]
		[Address(RVA = "0x1FE9120", Offset = "0x1FE7720", VA = "0x181FE9120")]
		public double GetSquared()
		{
			return 0.0;
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x0000701C File Offset: 0x0000521C
		[Token(Token = "0x600095E")]
		[Address(RVA = "0x1FE9650", Offset = "0x1FE7C50", VA = "0x181FE9650")]
		public static double SquaredDistance(ref Ray3d ray, ref Segment3d segment, out double rayT, out double segT)
		{
			return 0.0;
		}

		// Token: 0x04000516 RID: 1302
		[Token(Token = "0x4000516")]
		[FieldOffset(Offset = "0x10")]
		private Ray3d ray;

		// Token: 0x04000517 RID: 1303
		[Token(Token = "0x4000517")]
		[FieldOffset(Offset = "0x40")]
		private Segment3d segment;

		// Token: 0x04000518 RID: 1304
		[Token(Token = "0x4000518")]
		[FieldOffset(Offset = "0x78")]
		public double DistanceSquared;

		// Token: 0x04000519 RID: 1305
		[Token(Token = "0x4000519")]
		[FieldOffset(Offset = "0x80")]
		public Vector3d RayClosest;

		// Token: 0x0400051A RID: 1306
		[Token(Token = "0x400051A")]
		[FieldOffset(Offset = "0x98")]
		public double RayParameter;

		// Token: 0x0400051B RID: 1307
		[Token(Token = "0x400051B")]
		[FieldOffset(Offset = "0xA0")]
		public Vector3d SegmentClosest;

		// Token: 0x0400051C RID: 1308
		[Token(Token = "0x400051C")]
		[FieldOffset(Offset = "0xB8")]
		public double SegmentParameter;
	}
}
