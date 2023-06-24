using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001E7 RID: 487
	[Token(Token = "0x20001E7")]
	public struct Matrix3d
	{
		// Token: 0x06000F80 RID: 3968 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F80")]
		[Address(RVA = "0x1E37B30", Offset = "0x1E36130", VA = "0x181E37B30")]
		public Matrix3d(bool bIdentity)
		{
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F81")]
		[Address(RVA = "0x1E37C20", Offset = "0x1E36220", VA = "0x181E37C20")]
		public Matrix3d(float[,] mat)
		{
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F82")]
		[Address(RVA = "0x1E37D20", Offset = "0x1E36320", VA = "0x181E37D20")]
		public Matrix3d(float[] mat)
		{
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F83")]
		[Address(RVA = "0x1E37DF0", Offset = "0x1E363F0", VA = "0x181E37DF0")]
		public Matrix3d(double[,] mat)
		{
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F84")]
		[Address(RVA = "0x1E37EF0", Offset = "0x1E364F0", VA = "0x181E37EF0")]
		public Matrix3d(double[] mat)
		{
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F85")]
		[Address(RVA = "0x1E37FA0", Offset = "0x1E365A0", VA = "0x181E37FA0")]
		public Matrix3d(Func<int, double> matBufferF)
		{
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F86")]
		[Address(RVA = "0x1E380D0", Offset = "0x1E366D0", VA = "0x181E380D0")]
		public Matrix3d(Func<int, int, double> matF)
		{
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F87")]
		[Address(RVA = "0x1E38210", Offset = "0x1E36810", VA = "0x181E38210")]
		public Matrix3d(double m00, double m11, double m22)
		{
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F88")]
		[Address(RVA = "0x1E38260", Offset = "0x1E36860", VA = "0x181E38260")]
		public Matrix3d(Vector3d v1, Vector3d v2, Vector3d v3, bool bRows)
		{
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F89")]
		[Address(RVA = "0x1E38300", Offset = "0x1E36900", VA = "0x181E38300")]
		public Matrix3d(ref Vector3d v1, ref Vector3d v2, ref Vector3d v3, bool bRows)
		{
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F8A")]
		[Address(RVA = "0x1E383B0", Offset = "0x1E369B0", VA = "0x181E383B0")]
		public Matrix3d(double m00, double m01, double m02, double m10, double m11, double m12, double m20, double m21, double m22)
		{
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F8B")]
		[Address(RVA = "0x1E38410", Offset = "0x1E36A10", VA = "0x181E38410")]
		public Matrix3d(ref Vector3d u, ref Vector3d v)
		{
		}

		// Token: 0x17000289 RID: 649
		[Token(Token = "0x17000289")]
		public double this[int r, int c]
		{
			[Token(Token = "0x6000F8C")]
			[Address(RVA = "0x1E384A0", Offset = "0x1E36AA0", VA = "0x181E384A0")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6000F8D")]
			[Address(RVA = "0x1E38500", Offset = "0x1E36B00", VA = "0x181E38500")]
			set
			{
			}
		}

		// Token: 0x1700028A RID: 650
		[Token(Token = "0x1700028A")]
		public double this[int i]
		{
			[Token(Token = "0x6000F8E")]
			[Address(RVA = "0x1E38560", Offset = "0x1E36B60", VA = "0x181E38560")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6000F8F")]
			[Address(RVA = "0x1E385E0", Offset = "0x1E36BE0", VA = "0x181E385E0")]
			set
			{
			}
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x0000B8F4 File Offset: 0x00009AF4
		[Token(Token = "0x6000F90")]
		[Address(RVA = "0x1E38660", Offset = "0x1E36C60", VA = "0x181E38660")]
		public Vector3d Row(int i)
		{
			return default(Vector3d);
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x0000B90C File Offset: 0x00009B0C
		[Token(Token = "0x6000F91")]
		[Address(RVA = "0x1E386B0", Offset = "0x1E36CB0", VA = "0x181E386B0")]
		public Vector3d Column(int i)
		{
			return default(Vector3d);
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000F92")]
		[Address(RVA = "0x1E38710", Offset = "0x1E36D10", VA = "0x181E38710")]
		public double[] ToBuffer()
		{
			return null;
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F93")]
		[Address(RVA = "0x1E38800", Offset = "0x1E36E00", VA = "0x181E38800")]
		public void ToBuffer(double[] buf)
		{
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x0000B924 File Offset: 0x00009B24
		[Token(Token = "0x6000F94")]
		[Address(RVA = "0x1E388C0", Offset = "0x1E36EC0", VA = "0x181E388C0")]
		public static Matrix3d operator *(Matrix3d mat, double f)
		{
			return default(Matrix3d);
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x0000B93C File Offset: 0x00009B3C
		[Token(Token = "0x6000F95")]
		[Address(RVA = "0x1E38940", Offset = "0x1E36F40", VA = "0x181E38940")]
		public static Matrix3d operator *(double f, Matrix3d mat)
		{
			return default(Matrix3d);
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x0000B954 File Offset: 0x00009B54
		[Token(Token = "0x6000F96")]
		[Address(RVA = "0x1E389C0", Offset = "0x1E36FC0", VA = "0x181E389C0")]
		public static Vector3d operator *(Matrix3d mat, Vector3d v)
		{
			return default(Vector3d);
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x0000B96C File Offset: 0x00009B6C
		[Token(Token = "0x6000F97")]
		[Address(RVA = "0x1E389C0", Offset = "0x1E36FC0", VA = "0x181E389C0")]
		public Vector3d Multiply(ref Vector3d v)
		{
			return default(Vector3d);
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F98")]
		[Address(RVA = "0x1E38A50", Offset = "0x1E37050", VA = "0x181E38A50")]
		public void Multiply(ref Vector3d v, ref Vector3d vOut)
		{
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x0000B984 File Offset: 0x00009B84
		[Token(Token = "0x6000F99")]
		[Address(RVA = "0x1E38AD0", Offset = "0x1E370D0", VA = "0x181E38AD0")]
		public static Matrix3d operator *(Matrix3d mat1, Matrix3d mat2)
		{
			return default(Matrix3d);
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x0000B99C File Offset: 0x00009B9C
		[Token(Token = "0x6000F9A")]
		[Address(RVA = "0x1E38D80", Offset = "0x1E37380", VA = "0x181E38D80")]
		public static Matrix3d operator +(Matrix3d mat1, Matrix3d mat2)
		{
			return default(Matrix3d);
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x0000B9B4 File Offset: 0x00009BB4
		[Token(Token = "0x6000F9B")]
		[Address(RVA = "0x1E38EE0", Offset = "0x1E374E0", VA = "0x181E38EE0")]
		public static Matrix3d operator -(Matrix3d mat1, Matrix3d mat2)
		{
			return default(Matrix3d);
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x0000B9CC File Offset: 0x00009BCC
		[Token(Token = "0x6000F9C")]
		[Address(RVA = "0x1E39040", Offset = "0x1E37640", VA = "0x181E39040")]
		public double InnerProduct(ref Matrix3d m2)
		{
			return 0.0;
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000F9D RID: 3997 RVA: 0x0000B9E4 File Offset: 0x00009BE4
		[Token(Token = "0x1700028B")]
		public double Determinant
		{
			[Token(Token = "0x6000F9D")]
			[Address(RVA = "0x1E390C0", Offset = "0x1E376C0", VA = "0x181E390C0")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x0000B9FC File Offset: 0x00009BFC
		[Token(Token = "0x6000F9E")]
		[Address(RVA = "0x1E39140", Offset = "0x1E37740", VA = "0x181E39140")]
		public Matrix3d Inverse()
		{
			return default(Matrix3d);
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x0000BA14 File Offset: 0x00009C14
		[Token(Token = "0x6000F9F")]
		[Address(RVA = "0x1E39410", Offset = "0x1E37A10", VA = "0x181E39410")]
		public Matrix3d Transpose()
		{
			return default(Matrix3d);
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x0000BA2C File Offset: 0x00009C2C
		[Token(Token = "0x6000FA0")]
		[Address(RVA = "0x1E39470", Offset = "0x1E37A70", VA = "0x181E39470")]
		public Quaterniond ToQuaternion()
		{
			return default(Quaterniond);
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x0000BA44 File Offset: 0x00009C44
		[Token(Token = "0x6000FA1")]
		[Address(RVA = "0x1E394E0", Offset = "0x1E37AE0", VA = "0x181E394E0")]
		public bool EpsilonEqual(Matrix3d m2, double epsilon)
		{
			return default(bool);
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x0000BA5C File Offset: 0x00009C5C
		[Token(Token = "0x6000FA2")]
		[Address(RVA = "0x1E395B0", Offset = "0x1E37BB0", VA = "0x181E395B0")]
		public static Matrix3d AxisAngleD(Vector3d axis, double angleDeg)
		{
			return default(Matrix3d);
		}

		// Token: 0x06000FA3 RID: 4003 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000FA3")]
		[Address(RVA = "0x1E39760", Offset = "0x1E37D60", VA = "0x181E39760", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000FA4 RID: 4004 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000FA4")]
		[Address(RVA = "0x1E39840", Offset = "0x1E37E40", VA = "0x181E39840")]
		public string ToString(string fmt)
		{
			return null;
		}

		// Token: 0x040007EC RID: 2028
		[Token(Token = "0x40007EC")]
		[FieldOffset(Offset = "0x0")]
		public Vector3d Row0;

		// Token: 0x040007ED RID: 2029
		[Token(Token = "0x40007ED")]
		[FieldOffset(Offset = "0x18")]
		public Vector3d Row1;

		// Token: 0x040007EE RID: 2030
		[Token(Token = "0x40007EE")]
		[FieldOffset(Offset = "0x30")]
		public Vector3d Row2;

		// Token: 0x040007EF RID: 2031
		[Token(Token = "0x40007EF")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Matrix3d Identity;

		// Token: 0x040007F0 RID: 2032
		[Token(Token = "0x40007F0")]
		[FieldOffset(Offset = "0x48")]
		public static readonly Matrix3d Zero;
	}
}
