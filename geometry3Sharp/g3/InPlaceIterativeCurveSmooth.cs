using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000140 RID: 320
	[Token(Token = "0x2000140")]
	public class InPlaceIterativeCurveSmooth
	{
		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060008D0 RID: 2256 RVA: 0x0000207E File Offset: 0x0000027E
		// (set) Token: 0x060008D1 RID: 2257 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000185")]
		public DCurve3 Curve
		{
			[Token(Token = "0x60008D0")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008D1")]
			[Address(RVA = "0x1FE0A60", Offset = "0x1FDF060", VA = "0x181FE0A60")]
			set
			{
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060008D2 RID: 2258 RVA: 0x000069D4 File Offset: 0x00004BD4
		// (set) Token: 0x060008D3 RID: 2259 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000186")]
		public int Start
		{
			[Token(Token = "0x60008D2")]
			[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60008D3")]
			[Address(RVA = "0x6DDE70", Offset = "0x6DC470", VA = "0x1806DDE70")]
			set
			{
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060008D4 RID: 2260 RVA: 0x000069EC File Offset: 0x00004BEC
		// (set) Token: 0x060008D5 RID: 2261 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000187")]
		public int End
		{
			[Token(Token = "0x60008D4")]
			[Address(RVA = "0x9FA1D0", Offset = "0x9F87D0", VA = "0x1809FA1D0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60008D5")]
			[Address(RVA = "0xA7FDD0", Offset = "0xA7E3D0", VA = "0x180A7FDD0")]
			set
			{
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060008D6 RID: 2262 RVA: 0x00006A04 File Offset: 0x00004C04
		// (set) Token: 0x060008D7 RID: 2263 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000188")]
		public float Alpha
		{
			[Token(Token = "0x60008D6")]
			[Address(RVA = "0x5EA820", Offset = "0x5E8E20", VA = "0x1805EA820")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60008D7")]
			[Address(RVA = "0x1FE23F0", Offset = "0x1FE09F0", VA = "0x181FE23F0")]
			set
			{
			}
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x1FE2460", Offset = "0x1FE0A60", VA = "0x181FE2460")]
		public InPlaceIterativeCurveSmooth()
		{
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x1FE24B0", Offset = "0x1FE0AB0", VA = "0x181FE24B0")]
		public InPlaceIterativeCurveSmooth(DCurve3 curve, float alpha = 0.25f)
		{
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x1FE2580", Offset = "0x1FE0B80", VA = "0x181FE2580")]
		public void UpdateDeformation(int nIterations = 1)
		{
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x1FE25B0", Offset = "0x1FE0BB0", VA = "0x181FE25B0")]
		public void UpdateDeformation_Closed(int nIterations = 1)
		{
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x1FE2970", Offset = "0x1FE0F70", VA = "0x181FE2970")]
		public void UpdateDeformation_Open(int nIterations = 1)
		{
		}

		// Token: 0x040004C4 RID: 1220
		[Token(Token = "0x40004C4")]
		[FieldOffset(Offset = "0x10")]
		private DCurve3 _curve;

		// Token: 0x040004C5 RID: 1221
		[Token(Token = "0x40004C5")]
		[FieldOffset(Offset = "0x18")]
		private int _startRange;

		// Token: 0x040004C6 RID: 1222
		[Token(Token = "0x40004C6")]
		[FieldOffset(Offset = "0x1C")]
		private int _endRange;

		// Token: 0x040004C7 RID: 1223
		[Token(Token = "0x40004C7")]
		[FieldOffset(Offset = "0x20")]
		private float _alpha;
	}
}
