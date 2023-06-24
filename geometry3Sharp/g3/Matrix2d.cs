using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001E5 RID: 485
	[Token(Token = "0x20001E5")]
	public class Matrix2d
	{
		// Token: 0x06000F45 RID: 3909 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F45")]
		[Address(RVA = "0x1E35840", Offset = "0x1E33E40", VA = "0x181E35840")]
		public Matrix2d(bool bIdentity)
		{
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F46")]
		[Address(RVA = "0x1E35870", Offset = "0x1E33E70", VA = "0x181E35870")]
		public Matrix2d(double m00, double m01, double m10, double m11)
		{
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F47")]
		[Address(RVA = "0x1E35890", Offset = "0x1E33E90", VA = "0x181E35890")]
		public Matrix2d(double m00, double m11)
		{
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F48")]
		[Address(RVA = "0x1E358B0", Offset = "0x1E33EB0", VA = "0x181E358B0")]
		public Matrix2d(double angle, bool bDegrees = false)
		{
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F49")]
		[Address(RVA = "0x1E358D0", Offset = "0x1E33ED0", VA = "0x181E358D0")]
		public Matrix2d(Vector2d u, Vector2d v, bool columns)
		{
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F4A")]
		[Address(RVA = "0x1E35910", Offset = "0x1E33F10", VA = "0x181E35910")]
		public Matrix2d(Vector2d u, Vector2d v)
		{
		}

		// Token: 0x17000286 RID: 646
		[Token(Token = "0x17000286")]
		public double this[int r, int c]
		{
			[Token(Token = "0x6000F4B")]
			[Address(RVA = "0x1E35950", Offset = "0x1E33F50", VA = "0x181E35950")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F4C")]
		[Address(RVA = "0x1E35890", Offset = "0x1E33E90", VA = "0x181E35890")]
		public void SetToDiagonal(double m00, double m11)
		{
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F4D")]
		[Address(RVA = "0x1E35980", Offset = "0x1E33F80", VA = "0x181E35980")]
		public void SetToRotationRad(double angleRad)
		{
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F4E")]
		[Address(RVA = "0x1E35A00", Offset = "0x1E34000", VA = "0x181E35A00")]
		public void SetToRotationDeg(double angleDeg)
		{
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x0000B7A4 File Offset: 0x000099A4
		[Token(Token = "0x6000F4F")]
		[Address(RVA = "0x1E35A10", Offset = "0x1E34010", VA = "0x181E35A10")]
		public double QForm(Vector2d u, Vector2d v)
		{
			return 0.0;
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000F50")]
		[Address(RVA = "0x1E35AC0", Offset = "0x1E340C0", VA = "0x181E35AC0")]
		public Matrix2d Transpose()
		{
			return null;
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000F51")]
		[Address(RVA = "0x1E35B50", Offset = "0x1E34150", VA = "0x181E35B50")]
		public Matrix2d Inverse(double epsilon = 0.0)
		{
			return null;
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000F52")]
		[Address(RVA = "0x1E35C90", Offset = "0x1E34290", VA = "0x181E35C90")]
		public Matrix2d Adjoint()
		{
			return null;
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000F53 RID: 3923 RVA: 0x0000B7BC File Offset: 0x000099BC
		[Token(Token = "0x17000287")]
		public double Determinant
		{
			[Token(Token = "0x6000F53")]
			[Address(RVA = "0x1E35D20", Offset = "0x1E34320", VA = "0x181E35D20")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x0000B7D4 File Offset: 0x000099D4
		[Token(Token = "0x6000F54")]
		[Address(RVA = "0x1E35D40", Offset = "0x1E34340", VA = "0x181E35D40")]
		public double ExtractAngle()
		{
			return 0.0;
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x0000B7EC File Offset: 0x000099EC
		[Token(Token = "0x6000F55")]
		[Address(RVA = "0x1E35DB0", Offset = "0x1E343B0", VA = "0x181E35DB0")]
		public Vector2d Row(int i)
		{
			return default(Vector2d);
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x0000B804 File Offset: 0x00009A04
		[Token(Token = "0x6000F56")]
		[Address(RVA = "0x1E35DE0", Offset = "0x1E343E0", VA = "0x181E35DE0")]
		public Vector2d Column(int i)
		{
			return default(Vector2d);
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F57")]
		[Address(RVA = "0x1E35E10", Offset = "0x1E34410", VA = "0x181E35E10")]
		public void Orthonormalize()
		{
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F58")]
		[Address(RVA = "0x1E35F30", Offset = "0x1E34530", VA = "0x181E35F30")]
		public void EigenDecomposition(ref Matrix2d rot, ref Matrix2d diag)
		{
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000F59")]
		[Address(RVA = "0x1E36170", Offset = "0x1E34770", VA = "0x181E36170")]
		public static Matrix2d operator -(Matrix2d v)
		{
			return null;
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000F5A")]
		[Address(RVA = "0x1E36200", Offset = "0x1E34800", VA = "0x181E36200")]
		public static Matrix2d operator +(Matrix2d a, Matrix2d o)
		{
			return null;
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000F5B")]
		[Address(RVA = "0x1E36330", Offset = "0x1E34930", VA = "0x181E36330")]
		public static Matrix2d operator +(Matrix2d a, double f)
		{
			return null;
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000F5C")]
		[Address(RVA = "0x1E363D0", Offset = "0x1E349D0", VA = "0x181E363D0")]
		public static Matrix2d operator -(Matrix2d a, Matrix2d o)
		{
			return null;
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000F5D")]
		[Address(RVA = "0x1E36500", Offset = "0x1E34B00", VA = "0x181E36500")]
		public static Matrix2d operator -(Matrix2d a, double f)
		{
			return null;
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000F5E")]
		[Address(RVA = "0x1E365A0", Offset = "0x1E34BA0", VA = "0x181E365A0")]
		public static Matrix2d operator *(Matrix2d a, double f)
		{
			return null;
		}

		// Token: 0x06000F5F RID: 3935 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000F5F")]
		[Address(RVA = "0x1E36640", Offset = "0x1E34C40", VA = "0x181E36640")]
		public static Matrix2d operator *(double f, Matrix2d a)
		{
			return null;
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000F60")]
		[Address(RVA = "0x1E366E0", Offset = "0x1E34CE0", VA = "0x181E366E0")]
		public static Matrix2d operator /(Matrix2d a, double f)
		{
			return null;
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x0000B81C File Offset: 0x00009A1C
		[Token(Token = "0x6000F61")]
		[Address(RVA = "0x1E36780", Offset = "0x1E34D80", VA = "0x181E36780")]
		public static Vector2d operator *(Matrix2d m, Vector2d v)
		{
			return default(Vector2d);
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x0000B834 File Offset: 0x00009A34
		[Token(Token = "0x6000F62")]
		[Address(RVA = "0x1E367D0", Offset = "0x1E34DD0", VA = "0x181E367D0")]
		public static Vector2d operator *(Vector2d v, Matrix2d m)
		{
			return default(Vector2d);
		}

		// Token: 0x040007DE RID: 2014
		[Token(Token = "0x40007DE")]
		[FieldOffset(Offset = "0x10")]
		public double m00;

		// Token: 0x040007DF RID: 2015
		[Token(Token = "0x40007DF")]
		[FieldOffset(Offset = "0x18")]
		public double m01;

		// Token: 0x040007E0 RID: 2016
		[Token(Token = "0x40007E0")]
		[FieldOffset(Offset = "0x20")]
		public double m10;

		// Token: 0x040007E1 RID: 2017
		[Token(Token = "0x40007E1")]
		[FieldOffset(Offset = "0x28")]
		public double m11;

		// Token: 0x040007E2 RID: 2018
		[Token(Token = "0x40007E2")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Matrix2d Identity;

		// Token: 0x040007E3 RID: 2019
		[Token(Token = "0x40007E3")]
		[FieldOffset(Offset = "0x8")]
		public static readonly Matrix2d Zero;

		// Token: 0x040007E4 RID: 2020
		[Token(Token = "0x40007E4")]
		[FieldOffset(Offset = "0x10")]
		public static readonly Matrix2d One;
	}
}
