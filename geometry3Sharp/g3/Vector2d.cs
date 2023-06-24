using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace g3
{
	// Token: 0x0200020A RID: 522
	[Token(Token = "0x200020A")]
	public struct Vector2d : IComparable<Vector2d>, IEquatable<Vector2d>
	{
		// Token: 0x06001123 RID: 4387 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001123")]
		[Address(RVA = "0x1E2F330", Offset = "0x1E2D930", VA = "0x181E2F330")]
		public Vector2d(double f)
		{
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001124")]
		[Address(RVA = "0xF9AB50", Offset = "0xF99150", VA = "0x180F9AB50")]
		public Vector2d(double x, double y)
		{
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001125")]
		[Address(RVA = "0x1E2F340", Offset = "0x1E2D940", VA = "0x181E2F340")]
		public Vector2d(double[] v2)
		{
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001126")]
		[Address(RVA = "0x1E2F380", Offset = "0x1E2D980", VA = "0x181E2F380")]
		public Vector2d(float f)
		{
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001127")]
		[Address(RVA = "0x1E2F390", Offset = "0x1E2D990", VA = "0x181E2F390")]
		public Vector2d(float x, float y)
		{
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001128")]
		[Address(RVA = "0x1E2F3B0", Offset = "0x1E2D9B0", VA = "0x181E2F3B0")]
		public Vector2d(float[] v2)
		{
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001129")]
		[Address(RVA = "0x1E2F3F0", Offset = "0x1E2D9F0", VA = "0x181E2F3F0")]
		public Vector2d(Vector2d copy)
		{
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600112A")]
		[Address(RVA = "0x1E4EE60", Offset = "0x1E4D460", VA = "0x181E4EE60")]
		public Vector2d(Vector2f copy)
		{
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x0000D07C File Offset: 0x0000B27C
		[Token(Token = "0x600112B")]
		[Address(RVA = "0x1E4EE90", Offset = "0x1E4D490", VA = "0x181E4EE90")]
		public static Vector2d FromAngleRad(double angle)
		{
			return default(Vector2d);
		}

		// Token: 0x0600112C RID: 4396 RVA: 0x0000D094 File Offset: 0x0000B294
		[Token(Token = "0x600112C")]
		[Address(RVA = "0x1E4EF00", Offset = "0x1E4D500", VA = "0x181E4EF00")]
		public static Vector2d FromAngleDeg(double angle)
		{
			return default(Vector2d);
		}

		// Token: 0x170002C4 RID: 708
		[Token(Token = "0x170002C4")]
		public double this[int key]
		{
			[Token(Token = "0x600112D")]
			[Address(RVA = "0x1E2F420", Offset = "0x1E2DA20", VA = "0x181E2F420")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x600112E")]
			[Address(RVA = "0x1E2F430", Offset = "0x1E2DA30", VA = "0x181E2F430")]
			set
			{
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x0600112F RID: 4399 RVA: 0x0000D0C4 File Offset: 0x0000B2C4
		[Token(Token = "0x170002C5")]
		public double LengthSquared
		{
			[Token(Token = "0x600112F")]
			[Address(RVA = "0x1E4EF80", Offset = "0x1E4D580", VA = "0x181E4EF80")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06001130 RID: 4400 RVA: 0x0000D0DC File Offset: 0x0000B2DC
		[Token(Token = "0x170002C6")]
		public double Length
		{
			[Token(Token = "0x6001130")]
			[Address(RVA = "0x1E4EFA0", Offset = "0x1E4D5A0", VA = "0x181E4EFA0")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06001131 RID: 4401 RVA: 0x0000D0F4 File Offset: 0x0000B2F4
		[Token(Token = "0x6001131")]
		[Address(RVA = "0x1E4F020", Offset = "0x1E4D620", VA = "0x181E4F020")]
		public double Normalize(double epsilon = 2.220446049250313E-16)
		{
			return 0.0;
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06001132 RID: 4402 RVA: 0x0000D10C File Offset: 0x0000B30C
		[Token(Token = "0x170002C7")]
		public Vector2d Normalized
		{
			[Token(Token = "0x6001132")]
			[Address(RVA = "0x1E4F080", Offset = "0x1E4D680", VA = "0x181E4F080")]
			get
			{
				return default(Vector2d);
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06001133 RID: 4403 RVA: 0x0000D124 File Offset: 0x0000B324
		[Token(Token = "0x170002C8")]
		public bool IsNormalized
		{
			[Token(Token = "0x6001133")]
			[Address(RVA = "0x1E4F130", Offset = "0x1E4D730", VA = "0x181E4F130")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06001134 RID: 4404 RVA: 0x0000D13C File Offset: 0x0000B33C
		[Token(Token = "0x170002C9")]
		public bool IsFinite
		{
			[Token(Token = "0x6001134")]
			[Address(RVA = "0x1E4F1C0", Offset = "0x1E4D7C0", VA = "0x181E4F1C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001135")]
		[Address(RVA = "0x1E4F210", Offset = "0x1E4D810", VA = "0x181E4F210")]
		public void Round(int nDecimals)
		{
		}

		// Token: 0x06001136 RID: 4406 RVA: 0x0000D154 File Offset: 0x0000B354
		[Token(Token = "0x6001136")]
		[Address(RVA = "0x1E4F300", Offset = "0x1E4D900", VA = "0x181E4F300")]
		public double Dot(Vector2d v2)
		{
			return 0.0;
		}

		// Token: 0x06001137 RID: 4407 RVA: 0x0000D16C File Offset: 0x0000B36C
		[Token(Token = "0x6001137")]
		[Address(RVA = "0x1E4F320", Offset = "0x1E4D920", VA = "0x181E4F320")]
		public double Cross(Vector2d v2)
		{
			return 0.0;
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06001138 RID: 4408 RVA: 0x0000D184 File Offset: 0x0000B384
		[Token(Token = "0x170002CA")]
		public Vector2d Perp
		{
			[Token(Token = "0x6001138")]
			[Address(RVA = "0x1E4F340", Offset = "0x1E4D940", VA = "0x181E4F340")]
			get
			{
				return default(Vector2d);
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06001139 RID: 4409 RVA: 0x0000D19C File Offset: 0x0000B39C
		[Token(Token = "0x170002CB")]
		public Vector2d UnitPerp
		{
			[Token(Token = "0x6001139")]
			[Address(RVA = "0x1E4F360", Offset = "0x1E4D960", VA = "0x181E4F360")]
			get
			{
				return default(Vector2d);
			}
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x0000D1B4 File Offset: 0x0000B3B4
		[Token(Token = "0x600113A")]
		[Address(RVA = "0x1E4F320", Offset = "0x1E4D920", VA = "0x181E4F320")]
		public double DotPerp(Vector2d v2)
		{
			return 0.0;
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x0000D1CC File Offset: 0x0000B3CC
		[Token(Token = "0x600113B")]
		[Address(RVA = "0x1E4F480", Offset = "0x1E4DA80", VA = "0x181E4F480")]
		public double AngleD(Vector2d v2)
		{
			return 0.0;
		}

		// Token: 0x0600113C RID: 4412 RVA: 0x0000D1E4 File Offset: 0x0000B3E4
		[Token(Token = "0x600113C")]
		[Address(RVA = "0x1E4F550", Offset = "0x1E4DB50", VA = "0x181E4F550")]
		public static double AngleD(Vector2d v1, Vector2d v2)
		{
			return 0.0;
		}

		// Token: 0x0600113D RID: 4413 RVA: 0x0000D1FC File Offset: 0x0000B3FC
		[Token(Token = "0x600113D")]
		[Address(RVA = "0x1E4F570", Offset = "0x1E4DB70", VA = "0x181E4F570")]
		public double AngleR(Vector2d v2)
		{
			return 0.0;
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x0000D214 File Offset: 0x0000B414
		[Token(Token = "0x600113E")]
		[Address(RVA = "0x1E4F630", Offset = "0x1E4DC30", VA = "0x181E4F630")]
		public static double AngleR(Vector2d v1, Vector2d v2)
		{
			return 0.0;
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x0000D22C File Offset: 0x0000B42C
		[Token(Token = "0x600113F")]
		[Address(RVA = "0x1E4F650", Offset = "0x1E4DC50", VA = "0x181E4F650")]
		public double DistanceSquared(Vector2d v2)
		{
			return 0.0;
		}

		// Token: 0x06001140 RID: 4416 RVA: 0x0000D244 File Offset: 0x0000B444
		[Token(Token = "0x6001140")]
		[Address(RVA = "0x1E4F670", Offset = "0x1E4DC70", VA = "0x181E4F670")]
		public double Distance(Vector2d v2)
		{
			return 0.0;
		}

		// Token: 0x06001141 RID: 4417 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001141")]
		[Address(RVA = "0x1E2F3F0", Offset = "0x1E2D9F0", VA = "0x181E2F3F0")]
		public void Set(Vector2d o)
		{
		}

		// Token: 0x06001142 RID: 4418 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001142")]
		[Address(RVA = "0xF9AB50", Offset = "0xF99150", VA = "0x180F9AB50")]
		public void Set(double fX, double fY)
		{
		}

		// Token: 0x06001143 RID: 4419 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001143")]
		[Address(RVA = "0x1E4F710", Offset = "0x1E4DD10", VA = "0x181E4F710")]
		public void Add(Vector2d o)
		{
		}

		// Token: 0x06001144 RID: 4420 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001144")]
		[Address(RVA = "0x1E4F730", Offset = "0x1E4DD30", VA = "0x181E4F730")]
		public void Subtract(Vector2d o)
		{
		}

		// Token: 0x06001145 RID: 4421 RVA: 0x0000D25C File Offset: 0x0000B45C
		[Token(Token = "0x6001145")]
		[Address(RVA = "0x1E2F720", Offset = "0x1E2DD20", VA = "0x181E2F720")]
		public static Vector2d operator -(Vector2d v)
		{
			return default(Vector2d);
		}

		// Token: 0x06001146 RID: 4422 RVA: 0x0000D274 File Offset: 0x0000B474
		[Token(Token = "0x6001146")]
		[Address(RVA = "0x1E4F750", Offset = "0x1E4DD50", VA = "0x181E4F750")]
		public static Vector2d operator +(Vector2d a, Vector2d o)
		{
			return default(Vector2d);
		}

		// Token: 0x06001147 RID: 4423 RVA: 0x0000D28C File Offset: 0x0000B48C
		[Token(Token = "0x6001147")]
		[Address(RVA = "0x1E2F740", Offset = "0x1E2DD40", VA = "0x181E2F740")]
		public static Vector2d operator +(Vector2d a, double f)
		{
			return default(Vector2d);
		}

		// Token: 0x06001148 RID: 4424 RVA: 0x0000D2A4 File Offset: 0x0000B4A4
		[Token(Token = "0x6001148")]
		[Address(RVA = "0x1E4F780", Offset = "0x1E4DD80", VA = "0x181E4F780")]
		public static Vector2d operator -(Vector2d a, Vector2d o)
		{
			return default(Vector2d);
		}

		// Token: 0x06001149 RID: 4425 RVA: 0x0000D2BC File Offset: 0x0000B4BC
		[Token(Token = "0x6001149")]
		[Address(RVA = "0x1E2F760", Offset = "0x1E2DD60", VA = "0x181E2F760")]
		public static Vector2d operator -(Vector2d a, double f)
		{
			return default(Vector2d);
		}

		// Token: 0x0600114A RID: 4426 RVA: 0x0000D2D4 File Offset: 0x0000B4D4
		[Token(Token = "0x600114A")]
		[Address(RVA = "0x1E2F780", Offset = "0x1E2DD80", VA = "0x181E2F780")]
		public static Vector2d operator *(Vector2d a, double f)
		{
			return default(Vector2d);
		}

		// Token: 0x0600114B RID: 4427 RVA: 0x0000D2EC File Offset: 0x0000B4EC
		[Token(Token = "0x600114B")]
		[Address(RVA = "0x1E4F7B0", Offset = "0x1E4DDB0", VA = "0x181E4F7B0")]
		public static Vector2d operator *(double f, Vector2d a)
		{
			return default(Vector2d);
		}

		// Token: 0x0600114C RID: 4428 RVA: 0x0000D304 File Offset: 0x0000B504
		[Token(Token = "0x600114C")]
		[Address(RVA = "0x1E4F7D0", Offset = "0x1E4DDD0", VA = "0x181E4F7D0")]
		public static Vector2d operator /(Vector2d v, double f)
		{
			return default(Vector2d);
		}

		// Token: 0x0600114D RID: 4429 RVA: 0x0000D31C File Offset: 0x0000B51C
		[Token(Token = "0x600114D")]
		[Address(RVA = "0x1E4F7F0", Offset = "0x1E4DDF0", VA = "0x181E4F7F0")]
		public static Vector2d operator /(double f, Vector2d v)
		{
			return default(Vector2d);
		}

		// Token: 0x0600114E RID: 4430 RVA: 0x0000D334 File Offset: 0x0000B534
		[Token(Token = "0x600114E")]
		[Address(RVA = "0x1E4F810", Offset = "0x1E4DE10", VA = "0x181E4F810")]
		public static Vector2d operator *(Vector2d a, Vector2d b)
		{
			return default(Vector2d);
		}

		// Token: 0x0600114F RID: 4431 RVA: 0x0000D34C File Offset: 0x0000B54C
		[Token(Token = "0x600114F")]
		[Address(RVA = "0x1E4F840", Offset = "0x1E4DE40", VA = "0x181E4F840")]
		public static Vector2d operator /(Vector2d a, Vector2d b)
		{
			return default(Vector2d);
		}

		// Token: 0x06001150 RID: 4432 RVA: 0x0000D364 File Offset: 0x0000B564
		[Token(Token = "0x6001150")]
		[Address(RVA = "0x1E4F870", Offset = "0x1E4DE70", VA = "0x181E4F870")]
		public static bool operator ==(Vector2d a, Vector2d b)
		{
			return default(bool);
		}

		// Token: 0x06001151 RID: 4433 RVA: 0x0000D37C File Offset: 0x0000B57C
		[Token(Token = "0x6001151")]
		[Address(RVA = "0x1E4F890", Offset = "0x1E4DE90", VA = "0x181E4F890")]
		public static bool operator !=(Vector2d a, Vector2d b)
		{
			return default(bool);
		}

		// Token: 0x06001152 RID: 4434 RVA: 0x0000D394 File Offset: 0x0000B594
		[Token(Token = "0x6001152")]
		[Address(RVA = "0x1E4F8B0", Offset = "0x1E4DEB0", VA = "0x181E4F8B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x0000D3AC File Offset: 0x0000B5AC
		[Token(Token = "0x6001153")]
		[Address(RVA = "0x1E4F960", Offset = "0x1E4DF60", VA = "0x181E4F960", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x0000D3C4 File Offset: 0x0000B5C4
		[Token(Token = "0x6001154")]
		[Address(RVA = "0x1E4F9E0", Offset = "0x1E4DFE0", VA = "0x181E4F9E0", Slot = "4")]
		public int CompareTo(Vector2d other)
		{
			return 0;
		}

		// Token: 0x06001155 RID: 4437 RVA: 0x0000D3DC File Offset: 0x0000B5DC
		[Token(Token = "0x6001155")]
		[Address(RVA = "0x1E4F870", Offset = "0x1E4DE70", VA = "0x181E4F870", Slot = "5")]
		public bool Equals(Vector2d other)
		{
			return default(bool);
		}

		// Token: 0x06001156 RID: 4438 RVA: 0x0000D3F4 File Offset: 0x0000B5F4
		[Token(Token = "0x6001156")]
		[Address(RVA = "0x1E4FA30", Offset = "0x1E4E030", VA = "0x181E4FA30")]
		public bool EpsilonEqual(Vector2d v2, double epsilon)
		{
			return default(bool);
		}

		// Token: 0x06001157 RID: 4439 RVA: 0x0000D40C File Offset: 0x0000B60C
		[Token(Token = "0x6001157")]
		[Address(RVA = "0x1E4FAE0", Offset = "0x1E4E0E0", VA = "0x181E4FAE0")]
		public static Vector2d Lerp(Vector2d a, Vector2d b, double t)
		{
			return default(Vector2d);
		}

		// Token: 0x06001158 RID: 4440 RVA: 0x0000D424 File Offset: 0x0000B624
		[Token(Token = "0x6001158")]
		[Address(RVA = "0x1E4FAE0", Offset = "0x1E4E0E0", VA = "0x181E4FAE0")]
		public static Vector2d Lerp(ref Vector2d a, ref Vector2d b, double t)
		{
			return default(Vector2d);
		}

		// Token: 0x06001159 RID: 4441 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001159")]
		[Address(RVA = "0x1E4FB20", Offset = "0x1E4E120", VA = "0x181E4FB20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x0000D43C File Offset: 0x0000B63C
		[Token(Token = "0x600115A")]
		[Address(RVA = "0x1E4FBB0", Offset = "0x1E4E1B0", VA = "0x181E4FBB0")]
		public static implicit operator Vector2d(Vector2f v)
		{
			return default(Vector2d);
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x0000D454 File Offset: 0x0000B654
		[Token(Token = "0x600115B")]
		[Address(RVA = "0x1E4FBE0", Offset = "0x1E4E1E0", VA = "0x181E4FBE0")]
		public static explicit operator Vector2f(Vector2d v)
		{
			return default(Vector2f);
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x0000D46C File Offset: 0x0000B66C
		[Token(Token = "0x600115C")]
		[Address(RVA = "0x1E4FBB0", Offset = "0x1E4E1B0", VA = "0x181E4FBB0")]
		public static implicit operator Vector2d(Vector2 v)
		{
			return default(Vector2d);
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x0000D484 File Offset: 0x0000B684
		[Token(Token = "0x600115D")]
		[Address(RVA = "0x1E4FBE0", Offset = "0x1E4E1E0", VA = "0x181E4FBE0")]
		public static explicit operator Vector2(Vector2d v)
		{
			return default(Vector2);
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600115E")]
		[Address(RVA = "0x1E4FC00", Offset = "0x1E4E200", VA = "0x181E4FC00")]
		public static void GetInformation(IList<Vector2d> points, double epsilon, out Vector2d.Information info)
		{
		}

		// Token: 0x0400084F RID: 2127
		[Token(Token = "0x400084F")]
		[FieldOffset(Offset = "0x0")]
		public double x;

		// Token: 0x04000850 RID: 2128
		[Token(Token = "0x4000850")]
		[FieldOffset(Offset = "0x8")]
		public double y;

		// Token: 0x04000851 RID: 2129
		[Token(Token = "0x4000851")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Vector2d Zero;

		// Token: 0x04000852 RID: 2130
		[Token(Token = "0x4000852")]
		[FieldOffset(Offset = "0x10")]
		public static readonly Vector2d One;

		// Token: 0x04000853 RID: 2131
		[Token(Token = "0x4000853")]
		[FieldOffset(Offset = "0x20")]
		public static readonly Vector2d AxisX;

		// Token: 0x04000854 RID: 2132
		[Token(Token = "0x4000854")]
		[FieldOffset(Offset = "0x30")]
		public static readonly Vector2d AxisY;

		// Token: 0x04000855 RID: 2133
		[Token(Token = "0x4000855")]
		[FieldOffset(Offset = "0x40")]
		public static readonly Vector2d MaxValue;

		// Token: 0x04000856 RID: 2134
		[Token(Token = "0x4000856")]
		[FieldOffset(Offset = "0x50")]
		public static readonly Vector2d MinValue;

		// Token: 0x0200020B RID: 523
		[Token(Token = "0x200020B")]
		public struct Information
		{
			// Token: 0x04000857 RID: 2135
			[Token(Token = "0x4000857")]
			[FieldOffset(Offset = "0x0")]
			public int mDimension;

			// Token: 0x04000858 RID: 2136
			[Token(Token = "0x4000858")]
			[FieldOffset(Offset = "0x8")]
			public Vector2d mMin;

			// Token: 0x04000859 RID: 2137
			[Token(Token = "0x4000859")]
			[FieldOffset(Offset = "0x18")]
			public Vector2d mMax;

			// Token: 0x0400085A RID: 2138
			[Token(Token = "0x400085A")]
			[FieldOffset(Offset = "0x28")]
			public double mMaxRange;

			// Token: 0x0400085B RID: 2139
			[Token(Token = "0x400085B")]
			[FieldOffset(Offset = "0x30")]
			public Vector2d mOrigin;

			// Token: 0x0400085C RID: 2140
			[Token(Token = "0x400085C")]
			[FieldOffset(Offset = "0x40")]
			public Vector2d mDirection0;

			// Token: 0x0400085D RID: 2141
			[Token(Token = "0x400085D")]
			[FieldOffset(Offset = "0x50")]
			public Vector2d mDirection1;

			// Token: 0x0400085E RID: 2142
			[Token(Token = "0x400085E")]
			[FieldOffset(Offset = "0x60")]
			public Vector3i mExtreme;

			// Token: 0x0400085F RID: 2143
			[Token(Token = "0x400085F")]
			[FieldOffset(Offset = "0x6C")]
			public bool mExtremeCCW;
		}
	}
}
