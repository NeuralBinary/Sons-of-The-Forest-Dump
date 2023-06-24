using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000D9 RID: 217
	[Token(Token = "0x20000D9")]
	public class Arc2d : IParametricCurve2d
	{
		// Token: 0x060004FF RID: 1279 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x1F910B0", Offset = "0x1F8F6B0", VA = "0x181F910B0")]
		public Arc2d(Vector2d center, double radius, double startDeg, double endDeg)
		{
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000500")]
		[Address(RVA = "0x1F910F0", Offset = "0x1F8F6F0", VA = "0x181F910F0")]
		public Arc2d(Vector2d vCenter, Vector2d vStart, Vector2d vEnd)
		{
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000501")]
		[Address(RVA = "0x1F91130", Offset = "0x1F8F730", VA = "0x181F91130")]
		public void SetFromCenterAndPoints(Vector2d vCenter, Vector2d vStart, Vector2d vEnd)
		{
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000502 RID: 1282 RVA: 0x000044CC File Offset: 0x000026CC
		[Token(Token = "0x170000B3")]
		public Vector2d P0
		{
			[Token(Token = "0x6000502")]
			[Address(RVA = "0x1F912F0", Offset = "0x1F8F8F0", VA = "0x181F912F0")]
			get
			{
				return default(Vector2d);
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000503 RID: 1283 RVA: 0x000044E4 File Offset: 0x000026E4
		[Token(Token = "0x170000B4")]
		public Vector2d P1
		{
			[Token(Token = "0x6000503")]
			[Address(RVA = "0x1F91320", Offset = "0x1F8F920", VA = "0x181F91320")]
			get
			{
				return default(Vector2d);
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000504 RID: 1284 RVA: 0x000044FC File Offset: 0x000026FC
		[Token(Token = "0x170000B5")]
		public double Curvature
		{
			[Token(Token = "0x6000504")]
			[Address(RVA = "0x1F91350", Offset = "0x1F8F950", VA = "0x181F91350")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000505 RID: 1285 RVA: 0x00004514 File Offset: 0x00002714
		[Token(Token = "0x170000B6")]
		public double SignedCurvature
		{
			[Token(Token = "0x6000505")]
			[Address(RVA = "0x1F91360", Offset = "0x1F8F960", VA = "0x181F91360")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x0000452C File Offset: 0x0000272C
		[Token(Token = "0x170000B7")]
		public bool IsClosed
		{
			[Token(Token = "0x6000506")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x00004544 File Offset: 0x00002744
		[Token(Token = "0x170000B8")]
		public double ParamLength
		{
			[Token(Token = "0x6000507")]
			[Address(RVA = "0x1E46840", Offset = "0x1E44E40", VA = "0x181E46840", Slot = "5")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x0000455C File Offset: 0x0000275C
		[Token(Token = "0x6000508")]
		[Address(RVA = "0x1F91390", Offset = "0x1F8F990", VA = "0x181F91390", Slot = "6")]
		public Vector2d SampleT(double t)
		{
			return default(Vector2d);
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x00004574 File Offset: 0x00002774
		[Token(Token = "0x6000509")]
		[Address(RVA = "0x1F91460", Offset = "0x1F8FA60", VA = "0x181F91460", Slot = "7")]
		public Vector2d TangentT(double t)
		{
			return default(Vector2d);
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x0000458C File Offset: 0x0000278C
		[Token(Token = "0x170000B9")]
		public bool HasArcLength
		{
			[Token(Token = "0x600050A")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600050B RID: 1291 RVA: 0x000045A4 File Offset: 0x000027A4
		[Token(Token = "0x170000BA")]
		public double ArcLength
		{
			[Token(Token = "0x600050B")]
			[Address(RVA = "0x1F915B0", Offset = "0x1F8FBB0", VA = "0x181F915B0", Slot = "9")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x000045BC File Offset: 0x000027BC
		[Token(Token = "0x600050C")]
		[Address(RVA = "0x1F915D0", Offset = "0x1F8FBD0", VA = "0x181F915D0", Slot = "10")]
		public Vector2d SampleArcLength(double a)
		{
			return default(Vector2d);
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600050D")]
		[Address(RVA = "0x1F917A0", Offset = "0x1F8FDA0", VA = "0x181F917A0", Slot = "11")]
		public void Reverse()
		{
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600050E")]
		[Address(RVA = "0x1F917B0", Offset = "0x1F8FDB0", VA = "0x181F917B0", Slot = "14")]
		public IParametricCurve2d Clone()
		{
			return null;
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600050F RID: 1295 RVA: 0x000045D4 File Offset: 0x000027D4
		[Token(Token = "0x170000BB")]
		public bool IsTransformable
		{
			[Token(Token = "0x600050F")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000510")]
		[Address(RVA = "0x1F91880", Offset = "0x1F8FE80", VA = "0x181F91880", Slot = "13")]
		public void Transform(ITransform2 xform)
		{
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000511 RID: 1297 RVA: 0x000045EC File Offset: 0x000027EC
		[Token(Token = "0x170000BC")]
		public AxisAlignedBox2d Bounds
		{
			[Token(Token = "0x6000511")]
			[Address(RVA = "0x1F91B30", Offset = "0x1F90130", VA = "0x181F91B30")]
			get
			{
				return default(AxisAlignedBox2d);
			}
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00004604 File Offset: 0x00002804
		[Token(Token = "0x6000512")]
		[Address(RVA = "0x1F91F40", Offset = "0x1F90540", VA = "0x181F91F40")]
		public double Distance(Vector2d point)
		{
			return 0.0;
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x0000461C File Offset: 0x0000281C
		[Token(Token = "0x6000513")]
		[Address(RVA = "0x1F921F0", Offset = "0x1F907F0", VA = "0x181F921F0")]
		public Vector2d NearestPoint(Vector2d point)
		{
			return default(Vector2d);
		}

		// Token: 0x04000348 RID: 840
		[Token(Token = "0x4000348")]
		[FieldOffset(Offset = "0x10")]
		public Vector2d Center;

		// Token: 0x04000349 RID: 841
		[Token(Token = "0x4000349")]
		[FieldOffset(Offset = "0x20")]
		public double Radius;

		// Token: 0x0400034A RID: 842
		[Token(Token = "0x400034A")]
		[FieldOffset(Offset = "0x28")]
		public double AngleStartDeg;

		// Token: 0x0400034B RID: 843
		[Token(Token = "0x400034B")]
		[FieldOffset(Offset = "0x30")]
		public double AngleEndDeg;

		// Token: 0x0400034C RID: 844
		[Token(Token = "0x400034C")]
		[FieldOffset(Offset = "0x38")]
		public bool IsReversed;

		// Token: 0x0400034D RID: 845
		[Token(Token = "0x400034D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector2d[] bounds_dirs;
	}
}
