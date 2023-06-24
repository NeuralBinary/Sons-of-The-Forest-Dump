using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000132 RID: 306
	[Token(Token = "0x2000132")]
	public class PolyLine2DCurve : IParametricCurve2d
	{
		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000884 RID: 2180 RVA: 0x00006734 File Offset: 0x00004934
		[Token(Token = "0x17000172")]
		public bool IsClosed
		{
			[Token(Token = "0x6000884")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000885 RID: 2181 RVA: 0x0000674C File Offset: 0x0000494C
		[Token(Token = "0x17000173")]
		public double ParamLength
		{
			[Token(Token = "0x6000885")]
			[Address(RVA = "0x1FDCD60", Offset = "0x1FDB360", VA = "0x181FDCD60", Slot = "5")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00006764 File Offset: 0x00004964
		[Token(Token = "0x6000886")]
		[Address(RVA = "0x1FDCDB0", Offset = "0x1FDB3B0", VA = "0x181FDCDB0", Slot = "6")]
		public Vector2d SampleT(double t)
		{
			return default(Vector2d);
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x0000677C File Offset: 0x0000497C
		[Token(Token = "0x6000887")]
		[Address(RVA = "0x1FDD050", Offset = "0x1FDB650", VA = "0x181FDD050", Slot = "7")]
		public Vector2d TangentT(double t)
		{
			return default(Vector2d);
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000888 RID: 2184 RVA: 0x00006794 File Offset: 0x00004994
		[Token(Token = "0x17000174")]
		public bool HasArcLength
		{
			[Token(Token = "0x6000888")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000889 RID: 2185 RVA: 0x000067AC File Offset: 0x000049AC
		[Token(Token = "0x17000175")]
		public double ArcLength
		{
			[Token(Token = "0x6000889")]
			[Address(RVA = "0x1FDD0A0", Offset = "0x1FDB6A0", VA = "0x181FDD0A0", Slot = "9")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x000067C4 File Offset: 0x000049C4
		[Token(Token = "0x600088A")]
		[Address(RVA = "0x1FDD0C0", Offset = "0x1FDB6C0", VA = "0x181FDD0C0", Slot = "10")]
		public Vector2d SampleArcLength(double a)
		{
			return default(Vector2d);
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600088B")]
		[Address(RVA = "0x1FDD110", Offset = "0x1FDB710", VA = "0x181FDD110", Slot = "11")]
		public void Reverse()
		{
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600088C")]
		[Address(RVA = "0x1FDD140", Offset = "0x1FDB740", VA = "0x181FDD140", Slot = "14")]
		public IParametricCurve2d Clone()
		{
			return null;
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x0600088D RID: 2189 RVA: 0x000067DC File Offset: 0x000049DC
		[Token(Token = "0x17000176")]
		public bool IsTransformable
		{
			[Token(Token = "0x600088D")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600088E")]
		[Address(RVA = "0x1FDD220", Offset = "0x1FDB820", VA = "0x181FDD220", Slot = "13")]
		public void Transform(ITransform2 xform)
		{
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600088F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public PolyLine2DCurve()
		{
		}

		// Token: 0x0400049F RID: 1183
		[Token(Token = "0x400049F")]
		[FieldOffset(Offset = "0x10")]
		public PolyLine2d Polyline;
	}
}
