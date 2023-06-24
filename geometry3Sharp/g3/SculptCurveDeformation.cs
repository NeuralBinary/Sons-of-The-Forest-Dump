using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000139 RID: 313
	[Token(Token = "0x2000139")]
	public abstract class SculptCurveDeformation
	{
		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060008BC RID: 2236 RVA: 0x0000207E File Offset: 0x0000027E
		// (set) Token: 0x060008BD RID: 2237 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000182")]
		public DCurve3 Curve
		{
			[Token(Token = "0x60008BC")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008BD")]
			[Address(RVA = "0x1FE0A60", Offset = "0x1FDF060", VA = "0x181FE0A60")]
			set
			{
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060008BE RID: 2238 RVA: 0x0000207E File Offset: 0x0000027E
		// (set) Token: 0x060008BF RID: 2239 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000183")]
		public Func<double, double, double> WeightFunc
		{
			[Token(Token = "0x60008BE")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008BF")]
			[Address(RVA = "0x1FE0AC0", Offset = "0x1FDF0C0", VA = "0x181FE0AC0")]
			set
			{
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060008C0 RID: 2240 RVA: 0x00006944 File Offset: 0x00004B44
		// (set) Token: 0x060008C1 RID: 2241 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000184")]
		public double Radius
		{
			[Token(Token = "0x60008C0")]
			[Address(RVA = "0xA44E10", Offset = "0xA43410", VA = "0x180A44E10")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x60008C1")]
			[Address(RVA = "0xA44E20", Offset = "0xA43420", VA = "0x180A44E20")]
			set
			{
			}
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x1FE0B50", Offset = "0x1FDF150", VA = "0x181FE0B50")]
		public SculptCurveDeformation()
		{
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x1FE0D20", Offset = "0x1FDF320", VA = "0x181FE0D20", Slot = "4")]
		public virtual void BeginDeformation(Frame3f vStartPos)
		{
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x0000695C File Offset: 0x00004B5C
		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x1FE0D40", Offset = "0x1FDF340", VA = "0x181FE0D40", Slot = "5")]
		public virtual SculptCurveDeformation.DeformInfo UpdateDeformation(Frame3f vNextPos)
		{
			return default(SculptCurveDeformation.DeformInfo);
		}

		// Token: 0x060008C5 RID: 2245
		[Token(Token = "0x60008C5")]
		public abstract SculptCurveDeformation.DeformInfo Apply(Frame3f vNextPos);

		// Token: 0x040004B4 RID: 1204
		[Token(Token = "0x40004B4")]
		[FieldOffset(Offset = "0x10")]
		protected DCurve3 _curve;

		// Token: 0x040004B5 RID: 1205
		[Token(Token = "0x40004B5")]
		[FieldOffset(Offset = "0x18")]
		protected Func<double, double, double> _weightfunc;

		// Token: 0x040004B6 RID: 1206
		[Token(Token = "0x40004B6")]
		[FieldOffset(Offset = "0x20")]
		protected double radius;

		// Token: 0x040004B7 RID: 1207
		[Token(Token = "0x40004B7")]
		[FieldOffset(Offset = "0x28")]
		protected Frame3f vPreviousPos;

		// Token: 0x0200013A RID: 314
		[Token(Token = "0x200013A")]
		public struct DeformInfo
		{
			// Token: 0x040004B8 RID: 1208
			[Token(Token = "0x40004B8")]
			[FieldOffset(Offset = "0x0")]
			public bool bNoChange;

			// Token: 0x040004B9 RID: 1209
			[Token(Token = "0x40004B9")]
			[FieldOffset(Offset = "0x8")]
			public double maxEdgeLenSqr;

			// Token: 0x040004BA RID: 1210
			[Token(Token = "0x40004BA")]
			[FieldOffset(Offset = "0x10")]
			public double minEdgeLenSqr;
		}
	}
}
