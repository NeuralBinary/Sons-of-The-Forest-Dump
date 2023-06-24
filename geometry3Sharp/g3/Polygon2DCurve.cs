using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200012D RID: 301
	[Token(Token = "0x200012D")]
	public class Polygon2DCurve : IParametricCurve2d
	{
		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000842 RID: 2114 RVA: 0x000064AC File Offset: 0x000046AC
		[Token(Token = "0x17000163")]
		public bool IsClosed
		{
			[Token(Token = "0x6000842")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000843 RID: 2115 RVA: 0x000064C4 File Offset: 0x000046C4
		[Token(Token = "0x17000164")]
		public double ParamLength
		{
			[Token(Token = "0x6000843")]
			[Address(RVA = "0x1FD88A0", Offset = "0x1FD6EA0", VA = "0x181FD88A0", Slot = "5")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x000064DC File Offset: 0x000046DC
		[Token(Token = "0x6000844")]
		[Address(RVA = "0x1FD88F0", Offset = "0x1FD6EF0", VA = "0x181FD88F0", Slot = "6")]
		public Vector2d SampleT(double t)
		{
			return default(Vector2d);
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x000064F4 File Offset: 0x000046F4
		[Token(Token = "0x6000845")]
		[Address(RVA = "0x1FD8B90", Offset = "0x1FD7190", VA = "0x181FD8B90", Slot = "7")]
		public Vector2d TangentT(double t)
		{
			return default(Vector2d);
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000846 RID: 2118 RVA: 0x0000650C File Offset: 0x0000470C
		[Token(Token = "0x17000165")]
		public bool HasArcLength
		{
			[Token(Token = "0x6000846")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000847 RID: 2119 RVA: 0x00006524 File Offset: 0x00004724
		[Token(Token = "0x17000166")]
		public double ArcLength
		{
			[Token(Token = "0x6000847")]
			[Address(RVA = "0x1FD8BE0", Offset = "0x1FD71E0", VA = "0x181FD8BE0", Slot = "9")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x0000653C File Offset: 0x0000473C
		[Token(Token = "0x6000848")]
		[Address(RVA = "0x1FD8C00", Offset = "0x1FD7200", VA = "0x181FD8C00", Slot = "10")]
		public Vector2d SampleArcLength(double a)
		{
			return default(Vector2d);
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000849")]
		[Address(RVA = "0x1FD8C50", Offset = "0x1FD7250", VA = "0x181FD8C50", Slot = "11")]
		public void Reverse()
		{
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600084A")]
		[Address(RVA = "0x1FD8CA0", Offset = "0x1FD72A0", VA = "0x181FD8CA0", Slot = "14")]
		public IParametricCurve2d Clone()
		{
			return null;
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x0600084B RID: 2123 RVA: 0x00006554 File Offset: 0x00004754
		[Token(Token = "0x17000167")]
		public bool IsTransformable
		{
			[Token(Token = "0x600084B")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600084C")]
		[Address(RVA = "0x1FD8D80", Offset = "0x1FD7380", VA = "0x181FD8D80", Slot = "13")]
		public void Transform(ITransform2 xform)
		{
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600084D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public Polygon2DCurve()
		{
		}

		// Token: 0x04000492 RID: 1170
		[Token(Token = "0x4000492")]
		[FieldOffset(Offset = "0x10")]
		public Polygon2d Polygon;
	}
}
