using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000E3 RID: 227
	[Token(Token = "0x20000E3")]
	public class Circle2d : IParametricCurve2d
	{
		// Token: 0x0600055F RID: 1375 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600055F")]
		[Address(RVA = "0x1F98190", Offset = "0x1F96790", VA = "0x181F98190")]
		public Circle2d(double radius)
		{
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000560")]
		[Address(RVA = "0x1F98200", Offset = "0x1F96800", VA = "0x181F98200")]
		public Circle2d(Vector2d center, double radius)
		{
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000561 RID: 1377 RVA: 0x00004A3C File Offset: 0x00002C3C
		[Token(Token = "0x170000CA")]
		public double Curvature
		{
			[Token(Token = "0x6000561")]
			[Address(RVA = "0x1F91350", Offset = "0x1F8F950", VA = "0x181F91350")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x00004A54 File Offset: 0x00002C54
		[Token(Token = "0x170000CB")]
		public double SignedCurvature
		{
			[Token(Token = "0x6000562")]
			[Address(RVA = "0x1F98220", Offset = "0x1F96820", VA = "0x181F98220")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000563 RID: 1379 RVA: 0x00004A6C File Offset: 0x00002C6C
		[Token(Token = "0x170000CC")]
		public bool IsClosed
		{
			[Token(Token = "0x6000563")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000564")]
		[Address(RVA = "0x1F98250", Offset = "0x1F96850", VA = "0x181F98250", Slot = "11")]
		public void Reverse()
		{
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000565")]
		[Address(RVA = "0x1F98260", Offset = "0x1F96860", VA = "0x181F98260", Slot = "14")]
		public IParametricCurve2d Clone()
		{
			return null;
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000566 RID: 1382 RVA: 0x00004A84 File Offset: 0x00002C84
		[Token(Token = "0x170000CD")]
		public bool IsTransformable
		{
			[Token(Token = "0x6000566")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000567")]
		[Address(RVA = "0x1F982E0", Offset = "0x1F968E0", VA = "0x181F982E0", Slot = "13")]
		public void Transform(ITransform2 xform)
		{
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00004A9C File Offset: 0x00002C9C
		[Token(Token = "0x6000568")]
		[Address(RVA = "0x1F983E0", Offset = "0x1F969E0", VA = "0x181F983E0")]
		public Vector2d SampleDeg(double degrees)
		{
			return default(Vector2d);
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00004AB4 File Offset: 0x00002CB4
		[Token(Token = "0x6000569")]
		[Address(RVA = "0x1F98480", Offset = "0x1F96A80", VA = "0x181F98480")]
		public Vector2d SampleRad(double radians)
		{
			return default(Vector2d);
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x00004ACC File Offset: 0x00002CCC
		[Token(Token = "0x170000CE")]
		public double ParamLength
		{
			[Token(Token = "0x600056A")]
			[Address(RVA = "0x1E46840", Offset = "0x1E44E40", VA = "0x181E46840", Slot = "5")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00004AE4 File Offset: 0x00002CE4
		[Token(Token = "0x600056B")]
		[Address(RVA = "0x1F98510", Offset = "0x1F96B10", VA = "0x181F98510", Slot = "6")]
		public Vector2d SampleT(double t)
		{
			return default(Vector2d);
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00004AFC File Offset: 0x00002CFC
		[Token(Token = "0x600056C")]
		[Address(RVA = "0x1F985B0", Offset = "0x1F96BB0", VA = "0x181F985B0", Slot = "7")]
		public Vector2d TangentT(double t)
		{
			return default(Vector2d);
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x00004B14 File Offset: 0x00002D14
		[Token(Token = "0x170000CF")]
		public bool HasArcLength
		{
			[Token(Token = "0x600056D")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600056E RID: 1390 RVA: 0x00004B2C File Offset: 0x00002D2C
		[Token(Token = "0x170000D0")]
		public double ArcLength
		{
			[Token(Token = "0x600056E")]
			[Address(RVA = "0x1F986E0", Offset = "0x1F96CE0", VA = "0x181F986E0", Slot = "9")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00004B44 File Offset: 0x00002D44
		[Token(Token = "0x600056F")]
		[Address(RVA = "0x1F986F0", Offset = "0x1F96CF0", VA = "0x181F986F0", Slot = "10")]
		public Vector2d SampleArcLength(double a)
		{
			return default(Vector2d);
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00004B5C File Offset: 0x00002D5C
		[Token(Token = "0x6000570")]
		[Address(RVA = "0x1F987A0", Offset = "0x1F96DA0", VA = "0x181F987A0")]
		public bool Contains(Vector2d p)
		{
			return default(bool);
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000571 RID: 1393 RVA: 0x00004B74 File Offset: 0x00002D74
		// (set) Token: 0x06000572 RID: 1394 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000D1")]
		public double Circumference
		{
			[Token(Token = "0x6000571")]
			[Address(RVA = "0x1F986E0", Offset = "0x1F96CE0", VA = "0x181F986E0")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6000572")]
			[Address(RVA = "0x1F987E0", Offset = "0x1F96DE0", VA = "0x181F987E0")]
			set
			{
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x00004B8C File Offset: 0x00002D8C
		// (set) Token: 0x06000574 RID: 1396 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000D2")]
		public double Diameter
		{
			[Token(Token = "0x6000573")]
			[Address(RVA = "0x1E45E90", Offset = "0x1E44490", VA = "0x181E45E90")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6000574")]
			[Address(RVA = "0x1F987F0", Offset = "0x1F96DF0", VA = "0x181F987F0")]
			set
			{
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x00004BA4 File Offset: 0x00002DA4
		// (set) Token: 0x06000576 RID: 1398 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000D3")]
		public double Area
		{
			[Token(Token = "0x6000575")]
			[Address(RVA = "0x1F98800", Offset = "0x1F96E00", VA = "0x181F98800")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6000576")]
			[Address(RVA = "0x1F98820", Offset = "0x1F96E20", VA = "0x181F98820")]
			set
			{
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x00004BBC File Offset: 0x00002DBC
		[Token(Token = "0x170000D4")]
		public AxisAlignedBox2d Bounds
		{
			[Token(Token = "0x6000577")]
			[Address(RVA = "0x1F988B0", Offset = "0x1F96EB0", VA = "0x181F988B0")]
			get
			{
				return default(AxisAlignedBox2d);
			}
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00004BD4 File Offset: 0x00002DD4
		[Token(Token = "0x6000578")]
		[Address(RVA = "0x1F98900", Offset = "0x1F96F00", VA = "0x181F98900")]
		public double SignedDistance(Vector2d pt)
		{
			return 0.0;
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00004BEC File Offset: 0x00002DEC
		[Token(Token = "0x6000579")]
		[Address(RVA = "0x1F989A0", Offset = "0x1F96FA0", VA = "0x181F989A0")]
		public double Distance(Vector2d pt)
		{
			return 0.0;
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00004C04 File Offset: 0x00002E04
		[Token(Token = "0x600057A")]
		[Address(RVA = "0x1F98A90", Offset = "0x1F97090", VA = "0x181F98A90")]
		public static double RadiusArea(double r)
		{
			return 0.0;
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00004C1C File Offset: 0x00002E1C
		[Token(Token = "0x600057B")]
		[Address(RVA = "0x1F98AA0", Offset = "0x1F970A0", VA = "0x181F98AA0")]
		public static double RadiusCircumference(double r)
		{
			return 0.0;
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00004C34 File Offset: 0x00002E34
		[Token(Token = "0x600057C")]
		[Address(RVA = "0x1F98AB0", Offset = "0x1F970B0", VA = "0x181F98AB0")]
		public static double BoundingPolygonRadius(double r, int n)
		{
			return 0.0;
		}

		// Token: 0x04000368 RID: 872
		[Token(Token = "0x4000368")]
		[FieldOffset(Offset = "0x10")]
		public Vector2d Center;

		// Token: 0x04000369 RID: 873
		[Token(Token = "0x4000369")]
		[FieldOffset(Offset = "0x20")]
		public double Radius;

		// Token: 0x0400036A RID: 874
		[Token(Token = "0x400036A")]
		[FieldOffset(Offset = "0x28")]
		public bool IsReversed;
	}
}
