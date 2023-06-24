using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000106 RID: 262
	[Token(Token = "0x2000106")]
	public class EllipseArc2d : IParametricCurve2d
	{
		// Token: 0x060006CC RID: 1740 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x1FB8D90", Offset = "0x1FB7390", VA = "0x181FB8D90")]
		public EllipseArc2d(Vector2d center, double rotationAngleDeg, double extent0, double extent1, double startDeg, double endDeg)
		{
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x1FB8F40", Offset = "0x1FB7540", VA = "0x181FB8F40")]
		public EllipseArc2d(Vector2d center, Vector2d axis0, Vector2d axis1, Vector2d extent, double startDeg, double endDeg)
		{
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060006CE RID: 1742 RVA: 0x0000590C File Offset: 0x00003B0C
		[Token(Token = "0x17000109")]
		public bool IsClosed
		{
			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060006CF RID: 1743 RVA: 0x00005924 File Offset: 0x00003B24
		[Token(Token = "0x1700010A")]
		public double ParamLength
		{
			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x1E46840", Offset = "0x1E44E40", VA = "0x181E46840", Slot = "5")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x0000593C File Offset: 0x00003B3C
		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x1FB8FA0", Offset = "0x1FB75A0", VA = "0x181FB8FA0", Slot = "6")]
		public Vector2d SampleT(double t)
		{
			return default(Vector2d);
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x00005954 File Offset: 0x00003B54
		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x1FB9150", Offset = "0x1FB7750", VA = "0x181FB9150", Slot = "7")]
		public Vector2d TangentT(double t)
		{
			return default(Vector2d);
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060006D2 RID: 1746 RVA: 0x0000596C File Offset: 0x00003B6C
		[Token(Token = "0x1700010B")]
		public bool HasArcLength
		{
			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060006D3 RID: 1747 RVA: 0x00005984 File Offset: 0x00003B84
		[Token(Token = "0x1700010C")]
		public double ArcLength
		{
			[Token(Token = "0x60006D3")]
			[Address(RVA = "0x1FB9440", Offset = "0x1FB7A40", VA = "0x181FB9440", Slot = "9")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x0000599C File Offset: 0x00003B9C
		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x1FB9490", Offset = "0x1FB7A90", VA = "0x181FB9490", Slot = "10")]
		public Vector2d SampleArcLength(double a)
		{
			return default(Vector2d);
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x1FB94E0", Offset = "0x1FB7AE0", VA = "0x181FB94E0", Slot = "11")]
		public void Reverse()
		{
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x1FB94F0", Offset = "0x1FB7AF0", VA = "0x181FB94F0", Slot = "14")]
		public IParametricCurve2d Clone()
		{
			return null;
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060006D7 RID: 1751 RVA: 0x000059B4 File Offset: 0x00003BB4
		[Token(Token = "0x1700010D")]
		public bool IsTransformable
		{
			[Token(Token = "0x60006D7")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x1FB9600", Offset = "0x1FB7C00", VA = "0x181FB9600", Slot = "13")]
		public void Transform(ITransform2 xform)
		{
		}

		// Token: 0x040003E7 RID: 999
		[Token(Token = "0x40003E7")]
		[FieldOffset(Offset = "0x10")]
		public Vector2d Center;

		// Token: 0x040003E8 RID: 1000
		[Token(Token = "0x40003E8")]
		[FieldOffset(Offset = "0x20")]
		public Vector2d Axis0;

		// Token: 0x040003E9 RID: 1001
		[Token(Token = "0x40003E9")]
		[FieldOffset(Offset = "0x30")]
		public Vector2d Axis1;

		// Token: 0x040003EA RID: 1002
		[Token(Token = "0x40003EA")]
		[FieldOffset(Offset = "0x40")]
		public Vector2d Extent;

		// Token: 0x040003EB RID: 1003
		[Token(Token = "0x40003EB")]
		[FieldOffset(Offset = "0x50")]
		public double AngleStartDeg;

		// Token: 0x040003EC RID: 1004
		[Token(Token = "0x40003EC")]
		[FieldOffset(Offset = "0x58")]
		public double AngleEndDeg;

		// Token: 0x040003ED RID: 1005
		[Token(Token = "0x40003ED")]
		[FieldOffset(Offset = "0x60")]
		public bool IsReversed;
	}
}
