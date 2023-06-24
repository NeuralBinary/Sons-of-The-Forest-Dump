using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000141 RID: 321
	[Token(Token = "0x2000141")]
	public class ArcLengthSoftTranslation
	{
		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060008DD RID: 2269 RVA: 0x0000207E File Offset: 0x0000027E
		// (set) Token: 0x060008DE RID: 2270 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000189")]
		public DCurve3 Curve
		{
			[Token(Token = "0x60008DD")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008DE")]
			[Address(RVA = "0x1FE2CE0", Offset = "0x1FE12E0", VA = "0x181FE2CE0")]
			set
			{
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060008DF RID: 2271 RVA: 0x00006A1C File Offset: 0x00004C1C
		// (set) Token: 0x060008E0 RID: 2272 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700018A")]
		public Vector3d Handle
		{
			[Token(Token = "0x60008DF")]
			[Address(RVA = "0xF46E30", Offset = "0xF45430", VA = "0x180F46E30")]
			get
			{
				return default(Vector3d);
			}
			[Token(Token = "0x60008E0")]
			[Address(RVA = "0x1FE2D40", Offset = "0x1FE1340", VA = "0x181FE2D40")]
			set
			{
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060008E1 RID: 2273 RVA: 0x00006A34 File Offset: 0x00004C34
		// (set) Token: 0x060008E2 RID: 2274 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700018B")]
		public double ArcRadius
		{
			[Token(Token = "0x60008E1")]
			[Address(RVA = "0x1FE2E00", Offset = "0x1FE1400", VA = "0x181FE2E00")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x60008E2")]
			[Address(RVA = "0x1FE2E10", Offset = "0x1FE1410", VA = "0x181FE2E10")]
			set
			{
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060008E3 RID: 2275 RVA: 0x0000207E File Offset: 0x0000027E
		// (set) Token: 0x060008E4 RID: 2276 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700018C")]
		public Func<double, double, double> WeightFunc
		{
			[Token(Token = "0x60008E3")]
			[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008E4")]
			[Address(RVA = "0x1FE2E30", Offset = "0x1FE1430", VA = "0x181FE2E30")]
			set
			{
			}
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x1FE2ED0", Offset = "0x1FE14D0", VA = "0x181FE2ED0")]
		public ArcLengthSoftTranslation()
		{
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x1FE31A0", Offset = "0x1FE17A0", VA = "0x181FE31A0")]
		public void BeginDeformation()
		{
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x1FE3380", Offset = "0x1FE1980", VA = "0x181FE3380")]
		public void UpdateDeformation(Vector3d newHandlePos)
		{
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void EndDeformation()
		{
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x1FE35F0", Offset = "0x1FE1BF0", VA = "0x181FE35F0")]
		private void invalidate_roi()
		{
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x00006A4C File Offset: 0x00004C4C
		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x1FE3600", Offset = "0x1FE1C00", VA = "0x181FE3600")]
		private bool check_roi_valid()
		{
			return default(bool);
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x1FE3630", Offset = "0x1FE1C30", VA = "0x181FE3630")]
		public void UpdateROI(int nNearVertexHint = -1)
		{
		}

		// Token: 0x040004C8 RID: 1224
		[Token(Token = "0x40004C8")]
		[FieldOffset(Offset = "0x10")]
		private DCurve3 _curve;

		// Token: 0x040004C9 RID: 1225
		[Token(Token = "0x40004C9")]
		[FieldOffset(Offset = "0x18")]
		private Vector3d _handle;

		// Token: 0x040004CA RID: 1226
		[Token(Token = "0x40004CA")]
		[FieldOffset(Offset = "0x30")]
		private double _arcradius;

		// Token: 0x040004CB RID: 1227
		[Token(Token = "0x40004CB")]
		[FieldOffset(Offset = "0x38")]
		private Func<double, double, double> _weightfunc;

		// Token: 0x040004CC RID: 1228
		[Token(Token = "0x40004CC")]
		[FieldOffset(Offset = "0x40")]
		public int[] roi_index;

		// Token: 0x040004CD RID: 1229
		[Token(Token = "0x40004CD")]
		[FieldOffset(Offset = "0x48")]
		public double[] roi_weights;

		// Token: 0x040004CE RID: 1230
		[Token(Token = "0x40004CE")]
		[FieldOffset(Offset = "0x50")]
		public Vector3d[] start_positions;

		// Token: 0x040004CF RID: 1231
		[Token(Token = "0x40004CF")]
		[FieldOffset(Offset = "0x58")]
		private bool roi_valid;

		// Token: 0x040004D0 RID: 1232
		[Token(Token = "0x40004D0")]
		[FieldOffset(Offset = "0x5C")]
		private int curve_timestamp;

		// Token: 0x040004D1 RID: 1233
		[Token(Token = "0x40004D1")]
		[FieldOffset(Offset = "0x60")]
		private Vector3d start_handle;
	}
}
