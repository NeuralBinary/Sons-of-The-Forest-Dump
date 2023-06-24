using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001E8 RID: 488
	[Token(Token = "0x20001E8")]
	public struct Matrix3f
	{
		// Token: 0x06000FA6 RID: 4006 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FA6")]
		[Address(RVA = "0x1E39A40", Offset = "0x1E38040", VA = "0x181E39A40")]
		public Matrix3f(bool bIdentity)
		{
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FA7")]
		[Address(RVA = "0x1E39B40", Offset = "0x1E38140", VA = "0x181E39B40")]
		public Matrix3f(float[,] mat)
		{
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FA8")]
		[Address(RVA = "0x1E39C40", Offset = "0x1E38240", VA = "0x181E39C40")]
		public Matrix3f(float[] mat)
		{
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FA9")]
		[Address(RVA = "0x1E39D10", Offset = "0x1E38310", VA = "0x181E39D10")]
		public Matrix3f(double[,] mat)
		{
		}

		// Token: 0x06000FAA RID: 4010 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FAA")]
		[Address(RVA = "0x1E39E50", Offset = "0x1E38450", VA = "0x181E39E50")]
		public Matrix3f(double[] mat)
		{
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FAB")]
		[Address(RVA = "0x1E39F50", Offset = "0x1E38550", VA = "0x181E39F50")]
		public Matrix3f(Func<int, float> matBufferF)
		{
		}

		// Token: 0x06000FAC RID: 4012 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FAC")]
		[Address(RVA = "0x1E3A090", Offset = "0x1E38690", VA = "0x181E3A090")]
		public Matrix3f(Func<int, int, float> matF)
		{
		}

		// Token: 0x06000FAD RID: 4013 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FAD")]
		[Address(RVA = "0x1E3A1F0", Offset = "0x1E387F0", VA = "0x181E3A1F0")]
		public Matrix3f(float m00, float m11, float m22)
		{
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FAE")]
		[Address(RVA = "0x1E3A250", Offset = "0x1E38850", VA = "0x181E3A250")]
		public Matrix3f(Vector3f v1, Vector3f v2, Vector3f v3, bool bRows)
		{
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FAF")]
		[Address(RVA = "0x1E3A310", Offset = "0x1E38910", VA = "0x181E3A310")]
		public Matrix3f(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22)
		{
		}

		// Token: 0x1700028C RID: 652
		[Token(Token = "0x1700028C")]
		public float this[int r, int c]
		{
			[Token(Token = "0x6000FB0")]
			[Address(RVA = "0x1E3A380", Offset = "0x1E38980", VA = "0x181E3A380")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000FB1")]
			[Address(RVA = "0x1E3A3E0", Offset = "0x1E389E0", VA = "0x181E3A3E0")]
			set
			{
			}
		}

		// Token: 0x1700028D RID: 653
		[Token(Token = "0x1700028D")]
		public float this[int i]
		{
			[Token(Token = "0x6000FB2")]
			[Address(RVA = "0x1E3A440", Offset = "0x1E38A40", VA = "0x181E3A440")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000FB3")]
			[Address(RVA = "0x1E3A4C0", Offset = "0x1E38AC0", VA = "0x181E3A4C0")]
			set
			{
			}
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x0000BAA4 File Offset: 0x00009CA4
		[Token(Token = "0x6000FB4")]
		[Address(RVA = "0x1E3A540", Offset = "0x1E38B40", VA = "0x181E3A540")]
		public Vector3f Row(int i)
		{
			return default(Vector3f);
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x0000BABC File Offset: 0x00009CBC
		[Token(Token = "0x6000FB5")]
		[Address(RVA = "0x1E3A590", Offset = "0x1E38B90", VA = "0x181E3A590")]
		public Vector3f Column(int i)
		{
			return default(Vector3f);
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000FB6")]
		[Address(RVA = "0x1E3A5E0", Offset = "0x1E38BE0", VA = "0x181E3A5E0")]
		public float[] ToBuffer()
		{
			return null;
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FB7")]
		[Address(RVA = "0x1E3A6D0", Offset = "0x1E38CD0", VA = "0x181E3A6D0")]
		public void ToBuffer(float[] buf)
		{
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x0000BAD4 File Offset: 0x00009CD4
		[Token(Token = "0x6000FB8")]
		[Address(RVA = "0x1E3A790", Offset = "0x1E38D90", VA = "0x181E3A790")]
		public static Matrix3f operator *(Matrix3f mat, float f)
		{
			return default(Matrix3f);
		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x0000BAEC File Offset: 0x00009CEC
		[Token(Token = "0x6000FB9")]
		[Address(RVA = "0x1E3A820", Offset = "0x1E38E20", VA = "0x181E3A820")]
		public static Matrix3f operator *(float f, Matrix3f mat)
		{
			return default(Matrix3f);
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x0000BB04 File Offset: 0x00009D04
		[Token(Token = "0x6000FBA")]
		[Address(RVA = "0x1E3A8C0", Offset = "0x1E38EC0", VA = "0x181E3A8C0")]
		public static Vector3f operator *(Matrix3f mat, Vector3f v)
		{
			return default(Vector3f);
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x0000BB1C File Offset: 0x00009D1C
		[Token(Token = "0x6000FBB")]
		[Address(RVA = "0x1E3A8C0", Offset = "0x1E38EC0", VA = "0x181E3A8C0")]
		public Vector3f Multiply(ref Vector3f v)
		{
			return default(Vector3f);
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FBC")]
		[Address(RVA = "0x1E3A950", Offset = "0x1E38F50", VA = "0x181E3A950")]
		public void Multiply(ref Vector3f v, ref Vector3f vOut)
		{
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x0000BB34 File Offset: 0x00009D34
		[Token(Token = "0x6000FBD")]
		[Address(RVA = "0x1E3A9D0", Offset = "0x1E38FD0", VA = "0x181E3A9D0")]
		public static Matrix3f operator *(Matrix3f mat1, Matrix3f mat2)
		{
			return default(Matrix3f);
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x0000BB4C File Offset: 0x00009D4C
		[Token(Token = "0x6000FBE")]
		[Address(RVA = "0x1E3AE10", Offset = "0x1E39410", VA = "0x181E3AE10")]
		public static Matrix3f operator +(Matrix3f mat1, Matrix3f mat2)
		{
			return default(Matrix3f);
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x0000BB64 File Offset: 0x00009D64
		[Token(Token = "0x6000FBF")]
		[Address(RVA = "0x1E3AF80", Offset = "0x1E39580", VA = "0x181E3AF80")]
		public static Matrix3f operator -(Matrix3f mat1, Matrix3f mat2)
		{
			return default(Matrix3f);
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000FC0 RID: 4032 RVA: 0x0000BB7C File Offset: 0x00009D7C
		[Token(Token = "0x1700028E")]
		public float Determinant
		{
			[Token(Token = "0x6000FC0")]
			[Address(RVA = "0x1E3B0F0", Offset = "0x1E396F0", VA = "0x181E3B0F0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x0000BB94 File Offset: 0x00009D94
		[Token(Token = "0x6000FC1")]
		[Address(RVA = "0x1E3B170", Offset = "0x1E39770", VA = "0x181E3B170")]
		public Matrix3f Inverse()
		{
			return default(Matrix3f);
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x0000BBAC File Offset: 0x00009DAC
		[Token(Token = "0x6000FC2")]
		[Address(RVA = "0x1E3B450", Offset = "0x1E39A50", VA = "0x181E3B450")]
		public Matrix3f Transpose()
		{
			return default(Matrix3f);
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x0000BBC4 File Offset: 0x00009DC4
		[Token(Token = "0x6000FC3")]
		[Address(RVA = "0x1E3B4D0", Offset = "0x1E39AD0", VA = "0x181E3B4D0")]
		public Quaternionf ToQuaternion()
		{
			return default(Quaternionf);
		}

		// Token: 0x06000FC4 RID: 4036 RVA: 0x0000BBDC File Offset: 0x00009DDC
		[Token(Token = "0x6000FC4")]
		[Address(RVA = "0x1E3B520", Offset = "0x1E39B20", VA = "0x181E3B520")]
		public bool EpsilonEqual(Matrix3f m2, float epsilon)
		{
			return default(bool);
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x0000BBF4 File Offset: 0x00009DF4
		[Token(Token = "0x6000FC5")]
		[Address(RVA = "0x1E3B5F0", Offset = "0x1E39BF0", VA = "0x181E3B5F0")]
		public static Matrix3f AxisAngleD(Vector3f axis, float angleDeg)
		{
			return default(Matrix3f);
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000FC6")]
		[Address(RVA = "0x1E3B7C0", Offset = "0x1E39DC0", VA = "0x181E3B7C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000FC7")]
		[Address(RVA = "0x1E3B8A0", Offset = "0x1E39EA0", VA = "0x181E3B8A0")]
		public string ToString(string fmt)
		{
			return null;
		}

		// Token: 0x040007F1 RID: 2033
		[Token(Token = "0x40007F1")]
		[FieldOffset(Offset = "0x0")]
		public Vector3f Row0;

		// Token: 0x040007F2 RID: 2034
		[Token(Token = "0x40007F2")]
		[FieldOffset(Offset = "0xC")]
		public Vector3f Row1;

		// Token: 0x040007F3 RID: 2035
		[Token(Token = "0x40007F3")]
		[FieldOffset(Offset = "0x18")]
		public Vector3f Row2;

		// Token: 0x040007F4 RID: 2036
		[Token(Token = "0x40007F4")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Matrix3f Identity;

		// Token: 0x040007F5 RID: 2037
		[Token(Token = "0x40007F5")]
		[FieldOffset(Offset = "0x24")]
		public static readonly Matrix3f Zero;
	}
}
