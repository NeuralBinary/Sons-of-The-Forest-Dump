using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000041 RID: 65
	[Token(Token = "0x2000041")]
	public class BiArcFit2
	{
		// Token: 0x0600010E RID: 270 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x1E196B0", Offset = "0x1E17CB0", VA = "0x181E196B0")]
		public BiArcFit2(Vector2d point1, Vector2d tangent1, Vector2d point2, Vector2d tangent2)
		{
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x1E19700", Offset = "0x1E17D00", VA = "0x181E19700")]
		public BiArcFit2(Vector2d point1, Vector2d tangent1, Vector2d point2, Vector2d tangent2, double d1)
		{
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x1E19760", Offset = "0x1E17D60", VA = "0x181E19760")]
		private void set_output()
		{
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002954 File Offset: 0x00000B54
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x1E19AD0", Offset = "0x1E180D0", VA = "0x181E19AD0")]
		public double Distance(Vector2d point)
		{
			return 0.0;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0000296C File Offset: 0x00000B6C
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x1E19C60", Offset = "0x1E18260", VA = "0x181E19C60")]
		public Vector2d NearestPoint(Vector2d point)
		{
			return default(Vector2d);
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000113 RID: 275 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000017")]
		public List<IParametricCurve2d> Curves
		{
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x1E19DD0", Offset = "0x1E183D0", VA = "0x181E19DD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000114 RID: 276 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000018")]
		public IParametricCurve2d Curve1
		{
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x1E19F90", Offset = "0x1E18590", VA = "0x181E19F90")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000115 RID: 277 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000019")]
		public IParametricCurve2d Curve2
		{
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x1E1A000", Offset = "0x1E18600", VA = "0x181E1A000")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x1E1A080", Offset = "0x1E18680", VA = "0x181E1A080")]
		private void set_arc(int i, BiArcFit2.Arc a)
		{
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x1E1A100", Offset = "0x1E18700", VA = "0x181E1A100")]
		private Arc2d get_arc(int i)
		{
			return null;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x1E1A3B0", Offset = "0x1E189B0", VA = "0x181E1A3B0")]
		private void Fit()
		{
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x1E1A9D0", Offset = "0x1E18FD0", VA = "0x181E1A9D0")]
		private void Fit(double d1)
		{
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x1E1AE50", Offset = "0x1E19450", VA = "0x181E1AE50")]
		private void SetArcFromEdge(int i, Vector2d p1, Vector2d t1, Vector2d p2, bool fromP1)
		{
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x1E1B350", Offset = "0x1E19950", VA = "0x181E1B350")]
		public void DebugPrint()
		{
		}

		// Token: 0x0400013D RID: 317
		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x10")]
		public Vector2d Point1;

		// Token: 0x0400013E RID: 318
		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x20")]
		public Vector2d Point2;

		// Token: 0x0400013F RID: 319
		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x30")]
		public Vector2d Tangent1;

		// Token: 0x04000140 RID: 320
		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x40")]
		public Vector2d Tangent2;

		// Token: 0x04000141 RID: 321
		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x50")]
		public double Epsilon;

		// Token: 0x04000142 RID: 322
		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x58")]
		public Arc2d Arc1;

		// Token: 0x04000143 RID: 323
		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x60")]
		public Arc2d Arc2;

		// Token: 0x04000144 RID: 324
		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x68")]
		public bool Arc1IsSegment;

		// Token: 0x04000145 RID: 325
		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x69")]
		public bool Arc2IsSegment;

		// Token: 0x04000146 RID: 326
		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x70")]
		public Segment2d Segment1;

		// Token: 0x04000147 RID: 327
		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x98")]
		public Segment2d Segment2;

		// Token: 0x04000148 RID: 328
		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0xC0")]
		public double FitD1;

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0xC8")]
		public double FitD2;

		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0xD0")]
		private BiArcFit2.Arc arc1;

		// Token: 0x0400014B RID: 331
		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x120")]
		private BiArcFit2.Arc arc2;

		// Token: 0x02000042 RID: 66
		[Token(Token = "0x2000042")]
		private struct Arc
		{
			// Token: 0x0600011C RID: 284 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600011C")]
			[Address(RVA = "0x1E1B7D0", Offset = "0x1E19DD0", VA = "0x181E1B7D0")]
			public Arc(Vector2d c, double r, double startR, double endR, bool posRotation)
			{
			}

			// Token: 0x0600011D RID: 285 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x1E1B890", Offset = "0x1E19E90", VA = "0x181E1B890")]
			public Arc(Vector2d p0, Vector2d p1)
			{
			}

			// Token: 0x0400014C RID: 332
			[Token(Token = "0x400014C")]
			[FieldOffset(Offset = "0x0")]
			public Vector2d Center;

			// Token: 0x0400014D RID: 333
			[Token(Token = "0x400014D")]
			[FieldOffset(Offset = "0x10")]
			public double Radius;

			// Token: 0x0400014E RID: 334
			[Token(Token = "0x400014E")]
			[FieldOffset(Offset = "0x18")]
			public double AngleStartR;

			// Token: 0x0400014F RID: 335
			[Token(Token = "0x400014F")]
			[FieldOffset(Offset = "0x20")]
			public double AngleEndR;

			// Token: 0x04000150 RID: 336
			[Token(Token = "0x4000150")]
			[FieldOffset(Offset = "0x28")]
			public bool PositiveRotation;

			// Token: 0x04000151 RID: 337
			[Token(Token = "0x4000151")]
			[FieldOffset(Offset = "0x29")]
			public bool IsSegment;

			// Token: 0x04000152 RID: 338
			[Token(Token = "0x4000152")]
			[FieldOffset(Offset = "0x30")]
			public Vector2d P0;

			// Token: 0x04000153 RID: 339
			[Token(Token = "0x4000153")]
			[FieldOffset(Offset = "0x40")]
			public Vector2d P1;
		}
	}
}
