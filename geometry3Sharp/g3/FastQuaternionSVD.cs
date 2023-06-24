using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000323 RID: 803
	[Token(Token = "0x2000323")]
	public class FastQuaternionSVD
	{
		// Token: 0x06001B0C RID: 6924 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B0C")]
		[Address(RVA = "0x1F51A50", Offset = "0x1F50050", VA = "0x181F51A50")]
		public FastQuaternionSVD()
		{
		}

		// Token: 0x06001B0D RID: 6925 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B0D")]
		[Address(RVA = "0x1F51A60", Offset = "0x1F50060", VA = "0x181F51A60")]
		public FastQuaternionSVD(Matrix3d matrix, double epsilon = 2.220446049250313E-16, int jacobiIters = 4)
		{
		}

		// Token: 0x06001B0E RID: 6926 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B0E")]
		[Address(RVA = "0x1F51AC0", Offset = "0x1F500C0", VA = "0x181F51AC0")]
		public void Solve(Matrix3d matrix, double epsilon = 2.220446049250313E-16, int jacobiIters = -1)
		{
		}

		// Token: 0x06001B0F RID: 6927 RVA: 0x000137FC File Offset: 0x000119FC
		[Token(Token = "0x6001B0F")]
		[Address(RVA = "0x1F52000", Offset = "0x1F50600", VA = "0x181F52000")]
		public Matrix3d ReconstructMatrix()
		{
			return default(Matrix3d);
		}

		// Token: 0x06001B10 RID: 6928 RVA: 0x00013814 File Offset: 0x00011A14
		[Token(Token = "0x6001B10")]
		[Address(RVA = "0x1F52260", Offset = "0x1F50860", VA = "0x181F52260")]
		private Vector4d jacobiDiagonalize(SymmetricMatrix3d ATA)
		{
			return default(Vector4d);
		}

		// Token: 0x06001B11 RID: 6929 RVA: 0x0001382C File Offset: 0x00011A2C
		[Token(Token = "0x6001B11")]
		[Address(RVA = "0x1F52520", Offset = "0x1F50B20", VA = "0x181F52520")]
		private Vector2d givensAngles(SymmetricMatrix3d B, int p, int q)
		{
			return default(Vector2d);
		}

		// Token: 0x06001B12 RID: 6930 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B12")]
		[Address(RVA = "0x1F52710", Offset = "0x1F50D10", VA = "0x181F52710")]
		private void computeAV(ref Matrix3d matrix, ref Vector4d V, double[] buf)
		{
		}

		// Token: 0x06001B13 RID: 6931 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B13")]
		[Address(RVA = "0x1F529A0", Offset = "0x1F50FA0", VA = "0x181F529A0")]
		private void QRFactorize(double[] AV, ref Vector4d V, double eps, ref Vector3d S, ref Vector4d U)
		{
		}

		// Token: 0x06001B14 RID: 6932 RVA: 0x00013844 File Offset: 0x00011A44
		[Token(Token = "0x6001B14")]
		[Address(RVA = "0x1F52E40", Offset = "0x1F51440", VA = "0x181F52E40")]
		private Vector2d computeGivensQR(double[] B, double eps, int r, int c)
		{
			return default(Vector2d);
		}

		// Token: 0x06001B15 RID: 6933 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B15")]
		[Address(RVA = "0x1F53050", Offset = "0x1F51650", VA = "0x181F53050")]
		private void givensQTB2(double[] B, double ch, double sh)
		{
		}

		// Token: 0x06001B16 RID: 6934 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B16")]
		[Address(RVA = "0x1F531A0", Offset = "0x1F517A0", VA = "0x181F531A0")]
		private void givensQTB1(double[] B, double ch, double sh)
		{
		}

		// Token: 0x06001B17 RID: 6935 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B17")]
		[Address(RVA = "0x1F532D0", Offset = "0x1F518D0", VA = "0x181F532D0")]
		private void givensQTB0(double[] B, double ch, double sh)
		{
		}

		// Token: 0x06001B18 RID: 6936 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B18")]
		[Address(RVA = "0x1F53350", Offset = "0x1F51950", VA = "0x181F53350")]
		private void quatTimesEqualCoordinateAxis(ref Vector4d lhs, double c, double s, int i)
		{
		}

		// Token: 0x06001B19 RID: 6937 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B19")]
		[Address(RVA = "0x1F534F0", Offset = "0x1F51AF0", VA = "0x181F534F0")]
		private void permuteColumns(double[] B, ref Vector4d V)
		{
		}

		// Token: 0x06001B1A RID: 6938 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001B1A")]
		[Address(RVA = "0x1F536E0", Offset = "0x1F51CE0", VA = "0x181F536E0")]
		private void swapColsNeg(double[] B, int i, int j)
		{
		}

		// Token: 0x04000E27 RID: 3623
		[Token(Token = "0x4000E27")]
		[FieldOffset(Offset = "0x10")]
		private int NumJacobiIterations;

		// Token: 0x04000E28 RID: 3624
		[Token(Token = "0x4000E28")]
		[FieldOffset(Offset = "0x18")]
		public Quaterniond U;

		// Token: 0x04000E29 RID: 3625
		[Token(Token = "0x4000E29")]
		[FieldOffset(Offset = "0x38")]
		public Quaterniond V;

		// Token: 0x04000E2A RID: 3626
		[Token(Token = "0x4000E2A")]
		[FieldOffset(Offset = "0x58")]
		public Vector3d S;

		// Token: 0x04000E2B RID: 3627
		[Token(Token = "0x4000E2B")]
		[FieldOffset(Offset = "0x70")]
		private SymmetricMatrix3d ATA;

		// Token: 0x04000E2C RID: 3628
		[Token(Token = "0x4000E2C")]
		[FieldOffset(Offset = "0x78")]
		private double[] AV;

		// Token: 0x04000E2D RID: 3629
		[Token(Token = "0x4000E2D")]
		private const double gamma = 5.82842712474619;

		// Token: 0x04000E2E RID: 3630
		[Token(Token = "0x4000E2E")]
		private const double sinBackup = 0.3826834323650897;

		// Token: 0x04000E2F RID: 3631
		[Token(Token = "0x4000E2F")]
		private const double cosBackup = 0.9238795325112867;
	}
}
