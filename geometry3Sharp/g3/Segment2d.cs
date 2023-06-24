using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001FA RID: 506
	[Token(Token = "0x20001FA")]
	public struct Segment2d : IParametricCurve2d
	{
		// Token: 0x06001082 RID: 4226 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001082")]
		[Address(RVA = "0x1E45B60", Offset = "0x1E44160", VA = "0x181E45B60")]
		public Segment2d(Vector2d p0, Vector2d p1)
		{
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001083")]
		[Address(RVA = "0x1E45C70", Offset = "0x1E44270", VA = "0x181E45C70")]
		public Segment2d(Vector2d center, Vector2d direction, double extent)
		{
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06001084 RID: 4228 RVA: 0x0000C794 File Offset: 0x0000A994
		// (set) Token: 0x06001085 RID: 4229 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700029D")]
		public Vector2d P0
		{
			[Token(Token = "0x6001084")]
			[Address(RVA = "0x1E45C90", Offset = "0x1E44290", VA = "0x181E45C90")]
			get
			{
				return default(Vector2d);
			}
			[Token(Token = "0x6001085")]
			[Address(RVA = "0x1E45D40", Offset = "0x1E44340", VA = "0x181E45D40")]
			set
			{
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06001086 RID: 4230 RVA: 0x0000C7AC File Offset: 0x0000A9AC
		// (set) Token: 0x06001087 RID: 4231 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700029E")]
		public Vector2d P1
		{
			[Token(Token = "0x6001086")]
			[Address(RVA = "0x1E45D90", Offset = "0x1E44390", VA = "0x181E45D90")]
			get
			{
				return default(Vector2d);
			}
			[Token(Token = "0x6001087")]
			[Address(RVA = "0x1E45E40", Offset = "0x1E44440", VA = "0x181E45E40")]
			set
			{
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06001088 RID: 4232 RVA: 0x0000C7C4 File Offset: 0x0000A9C4
		[Token(Token = "0x1700029F")]
		public double Length
		{
			[Token(Token = "0x6001088")]
			[Address(RVA = "0x1E45E90", Offset = "0x1E44490", VA = "0x181E45E90")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x0000C7DC File Offset: 0x0000A9DC
		[Token(Token = "0x6001089")]
		[Address(RVA = "0x1E45EA0", Offset = "0x1E444A0", VA = "0x181E45EA0")]
		public Vector2d Endpoint(int i)
		{
			return default(Vector2d);
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x0000C7F4 File Offset: 0x0000A9F4
		[Token(Token = "0x600108A")]
		[Address(RVA = "0x1E45FA0", Offset = "0x1E445A0", VA = "0x181E45FA0")]
		public Vector2d PointAt(double d)
		{
			return default(Vector2d);
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x0000C80C File Offset: 0x0000AA0C
		[Token(Token = "0x600108B")]
		[Address(RVA = "0x1E46050", Offset = "0x1E44650", VA = "0x181E46050")]
		public Vector2d PointBetween(double t)
		{
			return default(Vector2d);
		}

		// Token: 0x0600108C RID: 4236 RVA: 0x0000C824 File Offset: 0x0000AA24
		[Token(Token = "0x600108C")]
		[Address(RVA = "0x1E46120", Offset = "0x1E44720", VA = "0x181E46120")]
		public double DistanceSquared(Vector2d p)
		{
			return 0.0;
		}

		// Token: 0x0600108D RID: 4237 RVA: 0x0000C83C File Offset: 0x0000AA3C
		[Token(Token = "0x600108D")]
		[Address(RVA = "0x1E462A0", Offset = "0x1E448A0", VA = "0x181E462A0")]
		public double DistanceSquared(Vector2d p, out double t)
		{
			return 0.0;
		}

		// Token: 0x0600108E RID: 4238 RVA: 0x0000C854 File Offset: 0x0000AA54
		[Token(Token = "0x600108E")]
		[Address(RVA = "0x1E46430", Offset = "0x1E44A30", VA = "0x181E46430")]
		public Vector2d NearestPoint(Vector2d p)
		{
			return default(Vector2d);
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x0000C86C File Offset: 0x0000AA6C
		[Token(Token = "0x600108F")]
		[Address(RVA = "0x1E46580", Offset = "0x1E44B80", VA = "0x181E46580")]
		public double Project(Vector2d p)
		{
			return 0.0;
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001090")]
		[Address(RVA = "0x1E46610", Offset = "0x1E44C10", VA = "0x181E46610")]
		private void update_from_endpoints(Vector2d p0, Vector2d p1)
		{
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x0000C884 File Offset: 0x0000AA84
		[Token(Token = "0x6001091")]
		[Address(RVA = "0x1E46720", Offset = "0x1E44D20", VA = "0x181E46720")]
		public int WhichSide(Vector2d test, double tol = 0.0)
		{
			return 0;
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06001092 RID: 4242 RVA: 0x0000C89C File Offset: 0x0000AA9C
		[Token(Token = "0x170002A0")]
		public bool IsClosed
		{
			[Token(Token = "0x6001092")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06001093 RID: 4243 RVA: 0x0000C8B4 File Offset: 0x0000AAB4
		[Token(Token = "0x170002A1")]
		public double ParamLength
		{
			[Token(Token = "0x6001093")]
			[Address(RVA = "0x1E46840", Offset = "0x1E44E40", VA = "0x181E46840", Slot = "5")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06001094 RID: 4244 RVA: 0x0000C8CC File Offset: 0x0000AACC
		[Token(Token = "0x6001094")]
		[Address(RVA = "0x1E46850", Offset = "0x1E44E50", VA = "0x181E46850", Slot = "6")]
		public Vector2d SampleT(double t)
		{
			return default(Vector2d);
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x0000C8E4 File Offset: 0x0000AAE4
		[Token(Token = "0x6001095")]
		[Address(RVA = "0x74B700", Offset = "0x749D00", VA = "0x18074B700", Slot = "7")]
		public Vector2d TangentT(double t)
		{
			return default(Vector2d);
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06001096 RID: 4246 RVA: 0x0000C8FC File Offset: 0x0000AAFC
		[Token(Token = "0x170002A2")]
		public bool HasArcLength
		{
			[Token(Token = "0x6001096")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06001097 RID: 4247 RVA: 0x0000C914 File Offset: 0x0000AB14
		[Token(Token = "0x170002A3")]
		public double ArcLength
		{
			[Token(Token = "0x6001097")]
			[Address(RVA = "0x1E45E90", Offset = "0x1E44490", VA = "0x181E45E90", Slot = "9")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06001098 RID: 4248 RVA: 0x0000C92C File Offset: 0x0000AB2C
		[Token(Token = "0x6001098")]
		[Address(RVA = "0x1E46920", Offset = "0x1E44F20", VA = "0x181E46920", Slot = "10")]
		public Vector2d SampleArcLength(double a)
		{
			return default(Vector2d);
		}

		// Token: 0x06001099 RID: 4249 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001099")]
		[Address(RVA = "0x1E469E0", Offset = "0x1E44FE0", VA = "0x181E469E0", Slot = "11")]
		public void Reverse()
		{
		}

		// Token: 0x0600109A RID: 4250 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600109A")]
		[Address(RVA = "0x1E46A40", Offset = "0x1E45040", VA = "0x181E46A40", Slot = "14")]
		public IParametricCurve2d Clone()
		{
			return null;
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x0600109B RID: 4251 RVA: 0x0000C944 File Offset: 0x0000AB44
		[Token(Token = "0x170002A4")]
		public bool IsTransformable
		{
			[Token(Token = "0x600109B")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600109C")]
		[Address(RVA = "0x1E46AA0", Offset = "0x1E450A0", VA = "0x181E46AA0", Slot = "13")]
		public void Transform(ITransform2 xform)
		{
		}

		// Token: 0x0600109D RID: 4253 RVA: 0x0000C95C File Offset: 0x0000AB5C
		[Token(Token = "0x600109D")]
		[Address(RVA = "0x1E46C60", Offset = "0x1E45260", VA = "0x181E46C60")]
		public static double FastDistanceSquared(ref Vector2d a, ref Vector2d b, ref Vector2d pt)
		{
			return 0.0;
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x0000C974 File Offset: 0x0000AB74
		[Token(Token = "0x600109E")]
		[Address(RVA = "0x1E46D60", Offset = "0x1E45360", VA = "0x181E46D60")]
		public static int WhichSide(ref Vector2d a, ref Vector2d b, ref Vector2d test, double tol = 0.0)
		{
			return 0;
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x0000C98C File Offset: 0x0000AB8C
		[Token(Token = "0x600109F")]
		[Address(RVA = "0x1E46DC0", Offset = "0x1E453C0", VA = "0x181E46DC0")]
		public bool Intersects(ref Segment2d seg2, double dotThresh = 5E-324, double intervalThresh = 0.0)
		{
			return default(bool);
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x0000C9A4 File Offset: 0x0000ABA4
		[Token(Token = "0x60010A0")]
		[Address(RVA = "0x1E470F0", Offset = "0x1E456F0", VA = "0x181E470F0")]
		public bool Intersects(Segment2d seg2, double dotThresh = 5E-324, double intervalThresh = 0.0)
		{
			return default(bool);
		}

		// Token: 0x04000820 RID: 2080
		[Token(Token = "0x4000820")]
		[FieldOffset(Offset = "0x0")]
		public Vector2d Center;

		// Token: 0x04000821 RID: 2081
		[Token(Token = "0x4000821")]
		[FieldOffset(Offset = "0x10")]
		public Vector2d Direction;

		// Token: 0x04000822 RID: 2082
		[Token(Token = "0x4000822")]
		[FieldOffset(Offset = "0x20")]
		public double Extent;
	}
}
