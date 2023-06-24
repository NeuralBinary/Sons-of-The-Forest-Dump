using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001E9 RID: 489
	[Token(Token = "0x20001E9")]
	public static class MatrixUtil
	{
		// Token: 0x06000FC9 RID: 4041 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000FC9")]
		[Address(RVA = "0x1E3BA90", Offset = "0x1E3A090", VA = "0x181E3BA90")]
		public static double[] MakeIdentity3x3(double a, double b, double c)
		{
			return null;
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FCA")]
		[Address(RVA = "0x1E3BAF0", Offset = "0x1E3A0F0", VA = "0x181E3BAF0")]
		public static void SetIdentity3x3(double[] M, double a, double b, double c)
		{
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000FCB")]
		[Address(RVA = "0x1E3BB50", Offset = "0x1E3A150", VA = "0x181E3BB50")]
		public static double[] MakeDiagonal3x3(double a, double b, double c)
		{
			return null;
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FCC")]
		[Address(RVA = "0x1E3BBF0", Offset = "0x1E3A1F0", VA = "0x181E3BBF0")]
		public static void SetDiagonal3x3(double[] M, double a, double b, double c)
		{
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x0000BC0C File Offset: 0x00009E0C
		[Token(Token = "0x6000FCD")]
		[Address(RVA = "0x1E3BC70", Offset = "0x1E3A270", VA = "0x181E3BC70")]
		public static double Determinant3x3(double[] M)
		{
			return 0.0;
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FCE")]
		[Address(RVA = "0x1E3BD10", Offset = "0x1E3A310", VA = "0x181E3BD10")]
		public static void Transpose3x3(double[] M)
		{
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FCF")]
		[Address(RVA = "0x1E3BDA0", Offset = "0x1E3A3A0", VA = "0x181E3BDA0")]
		public static void Transpose3x3(double[] M, double[] MTranspose)
		{
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000FD0")]
		[Address(RVA = "0x1E3BE90", Offset = "0x1E3A490", VA = "0x181E3BE90")]
		public static void Multiply3x3(double[] A, double[] B, double[] C)
		{
		}

		// Token: 0x06000FD1 RID: 4049 RVA: 0x0000BC24 File Offset: 0x00009E24
		[Token(Token = "0x6000FD1")]
		[Address(RVA = "0x1E3C2D0", Offset = "0x1E3A8D0", VA = "0x181E3C2D0")]
		public static Vector3d Multiply3x3(double[] M, Vector3d vec)
		{
			return default(Vector3d);
		}
	}
}
