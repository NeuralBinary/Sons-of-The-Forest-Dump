using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000147 RID: 327
	[Token(Token = "0x2000147")]
	public class DistLine3Segment3
	{
		// Token: 0x17000193 RID: 403
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x00006C14 File Offset: 0x00004E14
		// (set) Token: 0x0600090D RID: 2317 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000193")]
		public Line3d Line
		{
			[Token(Token = "0x600090C")]
			[Address(RVA = "0x1B19AA0", Offset = "0x1B180A0", VA = "0x181B19AA0")]
			get
			{
				return default(Line3d);
			}
			[Token(Token = "0x600090D")]
			[Address(RVA = "0x1FE5390", Offset = "0x1FE3990", VA = "0x181FE5390")]
			set
			{
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x0600090E RID: 2318 RVA: 0x00006C2C File Offset: 0x00004E2C
		// (set) Token: 0x0600090F RID: 2319 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000194")]
		public Segment3d Segment
		{
			[Token(Token = "0x600090E")]
			[Address(RVA = "0x1FE53C0", Offset = "0x1FE39C0", VA = "0x181FE53C0")]
			get
			{
				return default(Segment3d);
			}
			[Token(Token = "0x600090F")]
			[Address(RVA = "0x1FE53F0", Offset = "0x1FE39F0", VA = "0x181FE53F0")]
			set
			{
			}
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000910")]
		[Address(RVA = "0x1FE5420", Offset = "0x1FE3A20", VA = "0x181FE5420")]
		public DistLine3Segment3(Line3d LineIn, Segment3d SegmentIn)
		{
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x00006C44 File Offset: 0x00004E44
		[Token(Token = "0x6000911")]
		[Address(RVA = "0x1FE5470", Offset = "0x1FE3A70", VA = "0x181FE5470")]
		public static double MinDistance(Line3d line, Segment3d segment)
		{
			return 0.0;
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x00006C5C File Offset: 0x00004E5C
		[Token(Token = "0x6000912")]
		[Address(RVA = "0x1FE5570", Offset = "0x1FE3B70", VA = "0x181FE5570")]
		public static double MinDistanceLineParam(Line3d line, Segment3d segment)
		{
			return 0.0;
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000913")]
		[Address(RVA = "0x1FE5620", Offset = "0x1FE3C20", VA = "0x181FE5620")]
		public DistLine3Segment3 Compute()
		{
			return null;
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x00006C74 File Offset: 0x00004E74
		[Token(Token = "0x6000914")]
		[Address(RVA = "0x1FE5640", Offset = "0x1FE3C40", VA = "0x181FE5640")]
		public double Get()
		{
			return 0.0;
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x00006C8C File Offset: 0x00004E8C
		[Token(Token = "0x6000915")]
		[Address(RVA = "0x1FE56C0", Offset = "0x1FE3CC0", VA = "0x181FE56C0")]
		public double GetSquared()
		{
			return 0.0;
		}

		// Token: 0x040004E9 RID: 1257
		[Token(Token = "0x40004E9")]
		[FieldOffset(Offset = "0x10")]
		private Line3d line;

		// Token: 0x040004EA RID: 1258
		[Token(Token = "0x40004EA")]
		[FieldOffset(Offset = "0x40")]
		private Segment3d segment;

		// Token: 0x040004EB RID: 1259
		[Token(Token = "0x40004EB")]
		[FieldOffset(Offset = "0x78")]
		public double DistanceSquared;

		// Token: 0x040004EC RID: 1260
		[Token(Token = "0x40004EC")]
		[FieldOffset(Offset = "0x80")]
		public Vector3d LineClosest;

		// Token: 0x040004ED RID: 1261
		[Token(Token = "0x40004ED")]
		[FieldOffset(Offset = "0x98")]
		public double LineParameter;

		// Token: 0x040004EE RID: 1262
		[Token(Token = "0x40004EE")]
		[FieldOffset(Offset = "0xA0")]
		public Vector3d SegmentClosest;

		// Token: 0x040004EF RID: 1263
		[Token(Token = "0x40004EF")]
		[FieldOffset(Offset = "0xB8")]
		public double SegmentParameter;
	}
}
