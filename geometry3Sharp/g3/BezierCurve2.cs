using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000E1 RID: 225
	[Token(Token = "0x20000E1")]
	public class BezierCurve2 : BaseCurve2, IParametricCurve2d
	{
		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x000047B4 File Offset: 0x000029B4
		[Token(Token = "0x170000C1")]
		public int Degree
		{
			[Token(Token = "0x6000536")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000C2")]
		public Vector2d[] ControlPoints
		{
			[Token(Token = "0x6000537")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000538")]
		[Address(RVA = "0x1F94B30", Offset = "0x1F93130", VA = "0x181F94B30")]
		public BezierCurve2(int degree, Vector2d[] ctrlPoint, bool bTakeOwnership = false)
		{
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000539")]
		[Address(RVA = "0x1F953C0", Offset = "0x1F939C0", VA = "0x181F953C0")]
		protected BezierCurve2()
		{
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x000047CC File Offset: 0x000029CC
		[Token(Token = "0x600053A")]
		[Address(RVA = "0x1F953E0", Offset = "0x1F939E0", VA = "0x181F953E0", Slot = "4")]
		public override Vector2d GetPosition(double t)
		{
			return default(Vector2d);
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x000047E4 File Offset: 0x000029E4
		[Token(Token = "0x600053B")]
		[Address(RVA = "0x1F95660", Offset = "0x1F93C60", VA = "0x181F95660", Slot = "5")]
		public override Vector2d GetFirstDerivative(double t)
		{
			return default(Vector2d);
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x000047FC File Offset: 0x000029FC
		[Token(Token = "0x600053C")]
		[Address(RVA = "0x1F95910", Offset = "0x1F93F10", VA = "0x181F95910", Slot = "6")]
		public override Vector2d GetSecondDerivative(double t)
		{
			return default(Vector2d);
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00004814 File Offset: 0x00002A14
		[Token(Token = "0x600053D")]
		[Address(RVA = "0x1F95BC0", Offset = "0x1F941C0", VA = "0x181F95BC0", Slot = "7")]
		public override Vector2d GetThirdDerivative(double t)
		{
			return default(Vector2d);
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600053E RID: 1342 RVA: 0x0000482C File Offset: 0x00002A2C
		[Token(Token = "0x170000C3")]
		public bool IsClosed
		{
			[Token(Token = "0x600053E")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x00004844 File Offset: 0x00002A44
		[Token(Token = "0x170000C4")]
		public double ParamLength
		{
			[Token(Token = "0x600053F")]
			[Address(RVA = "0x1F95E90", Offset = "0x1F94490", VA = "0x181F95E90", Slot = "11")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x0000485C File Offset: 0x00002A5C
		[Token(Token = "0x6000540")]
		[Address(RVA = "0x1F95EA0", Offset = "0x1F944A0", VA = "0x181F95EA0", Slot = "12")]
		public Vector2d SampleT(double t)
		{
			return default(Vector2d);
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x00004874 File Offset: 0x00002A74
		[Token(Token = "0x6000541")]
		[Address(RVA = "0x1F940B0", Offset = "0x1F926B0", VA = "0x181F940B0", Slot = "13")]
		public Vector2d TangentT(double t)
		{
			return default(Vector2d);
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000542 RID: 1346 RVA: 0x0000488C File Offset: 0x00002A8C
		[Token(Token = "0x170000C5")]
		public bool HasArcLength
		{
			[Token(Token = "0x6000542")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x000048A4 File Offset: 0x00002AA4
		[Token(Token = "0x170000C6")]
		public double ArcLength
		{
			[Token(Token = "0x6000543")]
			[Address(RVA = "0x1F94090", Offset = "0x1F92690", VA = "0x181F94090", Slot = "15")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x000048BC File Offset: 0x00002ABC
		[Token(Token = "0x6000544")]
		[Address(RVA = "0x1F95ED0", Offset = "0x1F944D0", VA = "0x181F95ED0", Slot = "16")]
		public Vector2d SampleArcLength(double a)
		{
			return default(Vector2d);
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000545")]
		[Address(RVA = "0x1F95F40", Offset = "0x1F94540", VA = "0x181F95F40", Slot = "17")]
		public void Reverse()
		{
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000546")]
		[Address(RVA = "0x1F95F90", Offset = "0x1F94590", VA = "0x181F95F90", Slot = "20")]
		public IParametricCurve2d Clone()
		{
			return null;
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x000048D4 File Offset: 0x00002AD4
		[Token(Token = "0x170000C7")]
		public bool IsTransformable
		{
			[Token(Token = "0x6000547")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000548")]
		[Address(RVA = "0x1F963B0", Offset = "0x1F949B0", VA = "0x181F963B0", Slot = "19")]
		public void Transform(ITransform2 xform)
		{
		}

		// Token: 0x04000358 RID: 856
		[Token(Token = "0x4000358")]
		[FieldOffset(Offset = "0x20")]
		private int mDegree;

		// Token: 0x04000359 RID: 857
		[Token(Token = "0x4000359")]
		[FieldOffset(Offset = "0x24")]
		private int mNumCtrlPoints;

		// Token: 0x0400035A RID: 858
		[Token(Token = "0x400035A")]
		[FieldOffset(Offset = "0x28")]
		private Vector2d[] mCtrlPoint;

		// Token: 0x0400035B RID: 859
		[Token(Token = "0x400035B")]
		[FieldOffset(Offset = "0x30")]
		private Vector2d[] mDer1CtrlPoint;

		// Token: 0x0400035C RID: 860
		[Token(Token = "0x400035C")]
		[FieldOffset(Offset = "0x38")]
		private Vector2d[] mDer2CtrlPoint;

		// Token: 0x0400035D RID: 861
		[Token(Token = "0x400035D")]
		[FieldOffset(Offset = "0x40")]
		private Vector2d[] mDer3CtrlPoint;

		// Token: 0x0400035E RID: 862
		[Token(Token = "0x400035E")]
		[FieldOffset(Offset = "0x48")]
		private DenseMatrix mChoose;
	}
}
