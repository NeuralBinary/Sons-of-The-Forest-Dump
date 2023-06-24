using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001E6 RID: 486
	[Token(Token = "0x20001E6")]
	public class Matrix2f
	{
		// Token: 0x06000F64 RID: 3940 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F64")]
		[Address(RVA = "0x1E36A00", Offset = "0x1E35000", VA = "0x181E36A00")]
		public Matrix2f(bool bIdentity)
		{
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F65")]
		[Address(RVA = "0x1E20800", Offset = "0x1E1EE00", VA = "0x181E20800")]
		public Matrix2f(float m00, float m01, float m10, float m11)
		{
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F66")]
		[Address(RVA = "0x1E36A40", Offset = "0x1E35040", VA = "0x181E36A40")]
		public Matrix2f(float m00, float m11)
		{
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F67")]
		[Address(RVA = "0x1E36A60", Offset = "0x1E35060", VA = "0x181E36A60")]
		public Matrix2f(float radians)
		{
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F68")]
		[Address(RVA = "0x1E36A70", Offset = "0x1E35070", VA = "0x181E36A70")]
		public Matrix2f(Vector2f u, Vector2f v, bool columns)
		{
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F69")]
		[Address(RVA = "0x1E36AC0", Offset = "0x1E350C0", VA = "0x181E36AC0")]
		public Matrix2f(Vector2f u, Vector2f v)
		{
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F6A")]
		[Address(RVA = "0x1E36A40", Offset = "0x1E35040", VA = "0x181E36A40")]
		public void SetToDiagonal(float m00, float m11)
		{
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F6B")]
		[Address(RVA = "0x1E36B20", Offset = "0x1E35120", VA = "0x181E36B20")]
		public void SetToRotationRad(float angleRad)
		{
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F6C")]
		[Address(RVA = "0x1E36BB0", Offset = "0x1E351B0", VA = "0x181E36BB0")]
		public void SetToRotationDeg(float angleDeg)
		{
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x0000B84C File Offset: 0x00009A4C
		[Token(Token = "0x6000F6D")]
		[Address(RVA = "0x1E36BC0", Offset = "0x1E351C0", VA = "0x181E36BC0")]
		public float QForm(Vector2f u, Vector2f v)
		{
			return 0f;
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000F6E")]
		[Address(RVA = "0x1E36C60", Offset = "0x1E35260", VA = "0x181E36C60")]
		public Matrix2f Transpose()
		{
			return null;
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000F6F")]
		[Address(RVA = "0x1E36CF0", Offset = "0x1E352F0", VA = "0x181E36CF0")]
		public Matrix2f Inverse(float epsilon = 0f)
		{
			return null;
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000F70")]
		[Address(RVA = "0x1E36E50", Offset = "0x1E35450", VA = "0x181E36E50")]
		public Matrix2f Adjoint()
		{
			return null;
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000F71 RID: 3953 RVA: 0x0000B864 File Offset: 0x00009A64
		[Token(Token = "0x17000288")]
		public float Determinant
		{
			[Token(Token = "0x6000F71")]
			[Address(RVA = "0x1E36EF0", Offset = "0x1E354F0", VA = "0x181E36EF0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x0000B87C File Offset: 0x00009A7C
		[Token(Token = "0x6000F72")]
		[Address(RVA = "0x1E36F10", Offset = "0x1E35510", VA = "0x181E36F10")]
		public float ExtractAngle()
		{
			return 0f;
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F73")]
		[Address(RVA = "0x1E36F80", Offset = "0x1E35580", VA = "0x181E36F80")]
		public void Orthonormalize()
		{
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F74")]
		[Address(RVA = "0x1E370B0", Offset = "0x1E356B0", VA = "0x181E370B0")]
		public void EigenDecomposition(ref Matrix2f rot, ref Matrix2f diag)
		{
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000F75")]
		[Address(RVA = "0x1E372E0", Offset = "0x1E358E0", VA = "0x181E372E0")]
		public static Matrix2f operator -(Matrix2f v)
		{
			return null;
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000F76")]
		[Address(RVA = "0x1E37360", Offset = "0x1E35960", VA = "0x181E37360")]
		public static Matrix2f operator +(Matrix2f a, Matrix2f o)
		{
			return null;
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000F77")]
		[Address(RVA = "0x1E37490", Offset = "0x1E35A90", VA = "0x181E37490")]
		public static Matrix2f operator +(Matrix2f a, float f)
		{
			return null;
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000F78")]
		[Address(RVA = "0x1E37520", Offset = "0x1E35B20", VA = "0x181E37520")]
		public static Matrix2f operator -(Matrix2f a, Matrix2f o)
		{
			return null;
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000F79")]
		[Address(RVA = "0x1E37650", Offset = "0x1E35C50", VA = "0x181E37650")]
		public static Matrix2f operator -(Matrix2f a, float f)
		{
			return null;
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000F7A")]
		[Address(RVA = "0x1E376E0", Offset = "0x1E35CE0", VA = "0x181E376E0")]
		public static Matrix2f operator *(Matrix2f a, float f)
		{
			return null;
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000F7B")]
		[Address(RVA = "0x1E37770", Offset = "0x1E35D70", VA = "0x181E37770")]
		public static Matrix2f operator *(float f, Matrix2f a)
		{
			return null;
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000F7C")]
		[Address(RVA = "0x1E37800", Offset = "0x1E35E00", VA = "0x181E37800")]
		public static Matrix2f operator /(Matrix2f a, float f)
		{
			return null;
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x0000B894 File Offset: 0x00009A94
		[Token(Token = "0x6000F7D")]
		[Address(RVA = "0x1E37890", Offset = "0x1E35E90", VA = "0x181E37890")]
		public static Vector2f operator *(Matrix2f m, Vector2f v)
		{
			return default(Vector2f);
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x0000B8AC File Offset: 0x00009AAC
		[Token(Token = "0x6000F7E")]
		[Address(RVA = "0x1E378F0", Offset = "0x1E35EF0", VA = "0x181E378F0")]
		public static Vector2f operator *(Vector2f v, Matrix2f m)
		{
			return default(Vector2f);
		}

		// Token: 0x040007E5 RID: 2021
		[Token(Token = "0x40007E5")]
		[FieldOffset(Offset = "0x10")]
		public float m00;

		// Token: 0x040007E6 RID: 2022
		[Token(Token = "0x40007E6")]
		[FieldOffset(Offset = "0x14")]
		public float m01;

		// Token: 0x040007E7 RID: 2023
		[Token(Token = "0x40007E7")]
		[FieldOffset(Offset = "0x18")]
		public float m10;

		// Token: 0x040007E8 RID: 2024
		[Token(Token = "0x40007E8")]
		[FieldOffset(Offset = "0x1C")]
		public float m11;

		// Token: 0x040007E9 RID: 2025
		[Token(Token = "0x40007E9")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Matrix2f Identity;

		// Token: 0x040007EA RID: 2026
		[Token(Token = "0x40007EA")]
		[FieldOffset(Offset = "0x8")]
		public static readonly Matrix2f Zero;

		// Token: 0x040007EB RID: 2027
		[Token(Token = "0x40007EB")]
		[FieldOffset(Offset = "0x10")]
		public static readonly Matrix2f One;
	}
}
