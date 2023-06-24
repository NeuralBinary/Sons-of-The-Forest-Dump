using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000146 RID: 326
	[Token(Token = "0x2000146")]
	public class DistLine3Ray3
	{
		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000902 RID: 2306 RVA: 0x00006B84 File Offset: 0x00004D84
		// (set) Token: 0x06000903 RID: 2307 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000191")]
		public Line3d Line
		{
			[Token(Token = "0x6000902")]
			[Address(RVA = "0x1B19AA0", Offset = "0x1B180A0", VA = "0x181B19AA0")]
			get
			{
				return default(Line3d);
			}
			[Token(Token = "0x6000903")]
			[Address(RVA = "0x1FE4CF0", Offset = "0x1FE32F0", VA = "0x181FE4CF0")]
			set
			{
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000904 RID: 2308 RVA: 0x00006B9C File Offset: 0x00004D9C
		// (set) Token: 0x06000905 RID: 2309 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000192")]
		public Ray3d Ray
		{
			[Token(Token = "0x6000904")]
			[Address(RVA = "0x1FE4D20", Offset = "0x1FE3320", VA = "0x181FE4D20")]
			get
			{
				return default(Ray3d);
			}
			[Token(Token = "0x6000905")]
			[Address(RVA = "0x1FE4D40", Offset = "0x1FE3340", VA = "0x181FE4D40")]
			set
			{
			}
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000906")]
		[Address(RVA = "0x1FE4D70", Offset = "0x1FE3370", VA = "0x181FE4D70")]
		public DistLine3Ray3(Ray3d rayIn, Line3d LineIn)
		{
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x00006BB4 File Offset: 0x00004DB4
		[Token(Token = "0x6000907")]
		[Address(RVA = "0x1FE4DB0", Offset = "0x1FE33B0", VA = "0x181FE4DB0")]
		public static double MinDistance(Ray3d r, Line3d s)
		{
			return 0.0;
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x00006BCC File Offset: 0x00004DCC
		[Token(Token = "0x6000908")]
		[Address(RVA = "0x1FE4EA0", Offset = "0x1FE34A0", VA = "0x181FE4EA0")]
		public static double MinDistanceLineParam(Ray3d r, Line3d s)
		{
			return 0.0;
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000909")]
		[Address(RVA = "0x1FE4F40", Offset = "0x1FE3540", VA = "0x181FE4F40")]
		public DistLine3Ray3 Compute()
		{
			return null;
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x00006BE4 File Offset: 0x00004DE4
		[Token(Token = "0x600090A")]
		[Address(RVA = "0x1FE4F60", Offset = "0x1FE3560", VA = "0x181FE4F60")]
		public double Get()
		{
			return 0.0;
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x00006BFC File Offset: 0x00004DFC
		[Token(Token = "0x600090B")]
		[Address(RVA = "0x1FE4FE0", Offset = "0x1FE35E0", VA = "0x181FE4FE0")]
		public double GetSquared()
		{
			return 0.0;
		}

		// Token: 0x040004E2 RID: 1250
		[Token(Token = "0x40004E2")]
		[FieldOffset(Offset = "0x10")]
		private Line3d line;

		// Token: 0x040004E3 RID: 1251
		[Token(Token = "0x40004E3")]
		[FieldOffset(Offset = "0x40")]
		private Ray3d ray;

		// Token: 0x040004E4 RID: 1252
		[Token(Token = "0x40004E4")]
		[FieldOffset(Offset = "0x70")]
		public double DistanceSquared;

		// Token: 0x040004E5 RID: 1253
		[Token(Token = "0x40004E5")]
		[FieldOffset(Offset = "0x78")]
		public Vector3d LineClosest;

		// Token: 0x040004E6 RID: 1254
		[Token(Token = "0x40004E6")]
		[FieldOffset(Offset = "0x90")]
		public double LineParameter;

		// Token: 0x040004E7 RID: 1255
		[Token(Token = "0x40004E7")]
		[FieldOffset(Offset = "0x98")]
		public Vector3d RayClosest;

		// Token: 0x040004E8 RID: 1256
		[Token(Token = "0x40004E8")]
		[FieldOffset(Offset = "0xB0")]
		public double RayParameter;
	}
}
