using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000105 RID: 261
	[Token(Token = "0x2000105")]
	public class Ellipse2d : IParametricCurve2d
	{
		// Token: 0x060006B0 RID: 1712 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x1FB7510", Offset = "0x1FB5B10", VA = "0x181FB7510")]
		public Ellipse2d(Vector2d center, Vector2d axis0, Vector2d axis1, Vector2d extent)
		{
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x1FB7540", Offset = "0x1FB5B40", VA = "0x181FB7540")]
		public Ellipse2d(Vector2d center, Vector2d axis0, Vector2d axis1, double extent0, double extent1)
		{
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x1FB7580", Offset = "0x1FB5B80", VA = "0x181FB7580")]
		public Ellipse2d(Vector2d center, double rotationAngleDeg, double extent0, double extent1)
		{
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x1FB7700", Offset = "0x1FB5D00", VA = "0x181FB7700")]
		public Matrix2d GetM()
		{
			return null;
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x1FB7840", Offset = "0x1FB5E40", VA = "0x181FB7840")]
		public Matrix2d GetMInverse()
		{
			return null;
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x1FB7980", Offset = "0x1FB5F80", VA = "0x181FB7980")]
		public double[] ToCoefficients()
		{
			return null;
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x1FB7BE0", Offset = "0x1FB61E0", VA = "0x181FB7BE0")]
		public void ToCoefficients(ref Matrix2d A, ref Vector2d B, ref double C)
		{
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x0000578C File Offset: 0x0000398C
		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x1FB7E70", Offset = "0x1FB6470", VA = "0x181FB7E70")]
		public bool FromCoefficients(double[] coeff)
		{
			return default(bool);
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x000057A4 File Offset: 0x000039A4
		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x1FB7F40", Offset = "0x1FB6540", VA = "0x181FB7F40")]
		public bool FromCoefficients(Matrix2d A, Vector2d B, double C)
		{
			return default(bool);
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x000057BC File Offset: 0x000039BC
		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x1FB7F90", Offset = "0x1FB6590", VA = "0x181FB7F90")]
		public double Evaluate(Vector2d point)
		{
			return 0.0;
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x000057D4 File Offset: 0x000039D4
		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x1FB8060", Offset = "0x1FB6660", VA = "0x181FB8060")]
		public bool Contains(Vector2d point)
		{
			return default(bool);
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x1FB8130", Offset = "0x1FB6730", VA = "0x181FB8130")]
		private static void Convert(double[] coeff, ref Matrix2d A, ref Vector2d B, ref double C)
		{
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x1FB81C0", Offset = "0x1FB67C0", VA = "0x181FB81C0")]
		private static double[] Convert(Matrix2d A, Vector2d B, double C)
		{
			return null;
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060006BD RID: 1725 RVA: 0x000057EC File Offset: 0x000039EC
		[Token(Token = "0x17000102")]
		public bool IsClosed
		{
			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x1FB8290", Offset = "0x1FB6890", VA = "0x181FB8290", Slot = "11")]
		public void Reverse()
		{
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x1FB82A0", Offset = "0x1FB68A0", VA = "0x181FB82A0", Slot = "14")]
		public IParametricCurve2d Clone()
		{
			return null;
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060006C0 RID: 1728 RVA: 0x00005804 File Offset: 0x00003A04
		[Token(Token = "0x17000103")]
		public bool IsTransformable
		{
			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x1FB8370", Offset = "0x1FB6970", VA = "0x181FB8370", Slot = "13")]
		public void Transform(ITransform2 xform)
		{
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x0000581C File Offset: 0x00003A1C
		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x1FB8610", Offset = "0x1FB6C10", VA = "0x181FB8610")]
		public Vector2d SampleDeg(double degrees)
		{
			return default(Vector2d);
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x00005834 File Offset: 0x00003A34
		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x1FB8760", Offset = "0x1FB6D60", VA = "0x181FB8760")]
		public Vector2d SampleRad(double radians)
		{
			return default(Vector2d);
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060006C4 RID: 1732 RVA: 0x0000584C File Offset: 0x00003A4C
		[Token(Token = "0x17000104")]
		public double ParamLength
		{
			[Token(Token = "0x60006C4")]
			[Address(RVA = "0x1E46840", Offset = "0x1E44E40", VA = "0x181E46840", Slot = "5")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x00005864 File Offset: 0x00003A64
		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x1FB88A0", Offset = "0x1FB6EA0", VA = "0x181FB88A0", Slot = "6")]
		public Vector2d SampleT(double t)
		{
			return default(Vector2d);
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x0000587C File Offset: 0x00003A7C
		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x1FB89F0", Offset = "0x1FB6FF0", VA = "0x181FB89F0", Slot = "7")]
		public Vector2d TangentT(double t)
		{
			return default(Vector2d);
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060006C7 RID: 1735 RVA: 0x00005894 File Offset: 0x00003A94
		[Token(Token = "0x17000105")]
		public bool HasArcLength
		{
			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060006C8 RID: 1736 RVA: 0x000058AC File Offset: 0x00003AAC
		[Token(Token = "0x17000106")]
		public double ArcLength
		{
			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x1FB8BA0", Offset = "0x1FB71A0", VA = "0x181FB8BA0", Slot = "9")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x000058C4 File Offset: 0x00003AC4
		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x1FB8BF0", Offset = "0x1FB71F0", VA = "0x181FB8BF0", Slot = "10")]
		public Vector2d SampleArcLength(double a)
		{
			return default(Vector2d);
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060006CA RID: 1738 RVA: 0x000058DC File Offset: 0x00003ADC
		[Token(Token = "0x17000107")]
		public double Area
		{
			[Token(Token = "0x60006CA")]
			[Address(RVA = "0x1FB8C40", Offset = "0x1FB7240", VA = "0x181FB8C40")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060006CB RID: 1739 RVA: 0x000058F4 File Offset: 0x00003AF4
		[Token(Token = "0x17000108")]
		public double ApproxArcLen
		{
			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x1FB8C60", Offset = "0x1FB7260", VA = "0x181FB8C60")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x040003E2 RID: 994
		[Token(Token = "0x40003E2")]
		[FieldOffset(Offset = "0x10")]
		public Vector2d Center;

		// Token: 0x040003E3 RID: 995
		[Token(Token = "0x40003E3")]
		[FieldOffset(Offset = "0x20")]
		public Vector2d Axis0;

		// Token: 0x040003E4 RID: 996
		[Token(Token = "0x40003E4")]
		[FieldOffset(Offset = "0x30")]
		public Vector2d Axis1;

		// Token: 0x040003E5 RID: 997
		[Token(Token = "0x40003E5")]
		[FieldOffset(Offset = "0x40")]
		public Vector2d Extent;

		// Token: 0x040003E6 RID: 998
		[Token(Token = "0x40003E6")]
		[FieldOffset(Offset = "0x50")]
		public bool IsReversed;
	}
}
