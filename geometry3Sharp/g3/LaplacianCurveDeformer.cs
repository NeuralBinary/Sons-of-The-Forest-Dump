using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000110 RID: 272
	[Token(Token = "0x2000110")]
	public class LaplacianCurveDeformer
	{
		// Token: 0x06000734 RID: 1844 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000734")]
		[Address(RVA = "0x1FBDE80", Offset = "0x1FBC480", VA = "0x181FBDE80")]
		public LaplacianCurveDeformer(DCurve3 curve)
		{
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000735")]
		[Address(RVA = "0x1FBE010", Offset = "0x1FBC610", VA = "0x181FBE010")]
		public void SetConstraint(int vID, Vector3d targetPos, double weight, bool bForceToFixedPos = false)
		{
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00005C3C File Offset: 0x00003E3C
		[Token(Token = "0x6000736")]
		[Address(RVA = "0x1FBE110", Offset = "0x1FBC710", VA = "0x181FBE110")]
		public bool IsConstrained(int vID)
		{
			return default(bool);
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000737")]
		[Address(RVA = "0x1FBE180", Offset = "0x1FBC780", VA = "0x181FBE180")]
		public void ClearConstraints()
		{
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000738")]
		[Address(RVA = "0x1FBE220", Offset = "0x1FBC820", VA = "0x181FBE220")]
		public void Initialize()
		{
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000739")]
		[Address(RVA = "0x1FBF420", Offset = "0x1FBDA20", VA = "0x181FBF420")]
		private void UpdateForSolve()
		{
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x00005C54 File Offset: 0x00003E54
		[Token(Token = "0x600073A")]
		[Address(RVA = "0x1FBF9B0", Offset = "0x1FBDFB0", VA = "0x181FBF9B0")]
		public bool SolveMultipleCG(Vector3d[] Result)
		{
			return default(bool);
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x00005C6C File Offset: 0x00003E6C
		[Token(Token = "0x600073B")]
		[Address(RVA = "0x1FC09E0", Offset = "0x1FBEFE0", VA = "0x181FC09E0")]
		public bool SolveMultipleRHS(Vector3d[] Result)
		{
			return default(bool);
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x00005C84 File Offset: 0x00003E84
		[Token(Token = "0x600073C")]
		[Address(RVA = "0x1FC1110", Offset = "0x1FBF710", VA = "0x181FC1110")]
		public bool Solve(Vector3d[] Result)
		{
			return default(bool);
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00005C9C File Offset: 0x00003E9C
		[Token(Token = "0x600073D")]
		[Address(RVA = "0x1FC11A0", Offset = "0x1FBF7A0", VA = "0x181FC11A0")]
		public bool SolveAndUpdateCurve()
		{
			return default(bool);
		}

		// Token: 0x04000403 RID: 1027
		[Token(Token = "0x4000403")]
		[FieldOffset(Offset = "0x10")]
		public DCurve3 Curve;

		// Token: 0x04000404 RID: 1028
		[Token(Token = "0x4000404")]
		[FieldOffset(Offset = "0x18")]
		public bool SolveX;

		// Token: 0x04000405 RID: 1029
		[Token(Token = "0x4000405")]
		[FieldOffset(Offset = "0x19")]
		public bool SolveY;

		// Token: 0x04000406 RID: 1030
		[Token(Token = "0x4000406")]
		[FieldOffset(Offset = "0x1A")]
		public bool SolveZ;

		// Token: 0x04000407 RID: 1031
		[Token(Token = "0x4000407")]
		[FieldOffset(Offset = "0x1B")]
		public bool ConvergeFailed;

		// Token: 0x04000408 RID: 1032
		[Token(Token = "0x4000408")]
		[FieldOffset(Offset = "0x20")]
		private PackedSparseMatrix PackedM;

		// Token: 0x04000409 RID: 1033
		[Token(Token = "0x4000409")]
		[FieldOffset(Offset = "0x28")]
		private int N;

		// Token: 0x0400040A RID: 1034
		[Token(Token = "0x400040A")]
		[FieldOffset(Offset = "0x30")]
		private int[] ToCurveV;

		// Token: 0x0400040B RID: 1035
		[Token(Token = "0x400040B")]
		[FieldOffset(Offset = "0x38")]
		private int[] ToIndex;

		// Token: 0x0400040C RID: 1036
		[Token(Token = "0x400040C")]
		[FieldOffset(Offset = "0x40")]
		private double[] Px;

		// Token: 0x0400040D RID: 1037
		[Token(Token = "0x400040D")]
		[FieldOffset(Offset = "0x48")]
		private double[] Py;

		// Token: 0x0400040E RID: 1038
		[Token(Token = "0x400040E")]
		[FieldOffset(Offset = "0x50")]
		private double[] Pz;

		// Token: 0x0400040F RID: 1039
		[Token(Token = "0x400040F")]
		[FieldOffset(Offset = "0x58")]
		private int[] nbr_counts;

		// Token: 0x04000410 RID: 1040
		[Token(Token = "0x4000410")]
		[FieldOffset(Offset = "0x60")]
		private double[] MLx;

		// Token: 0x04000411 RID: 1041
		[Token(Token = "0x4000411")]
		[FieldOffset(Offset = "0x68")]
		private double[] MLy;

		// Token: 0x04000412 RID: 1042
		[Token(Token = "0x4000412")]
		[FieldOffset(Offset = "0x70")]
		private double[] MLz;

		// Token: 0x04000413 RID: 1043
		[Token(Token = "0x4000413")]
		[FieldOffset(Offset = "0x78")]
		private Dictionary<int, LaplacianCurveDeformer.SoftConstraintV> SoftConstraints;

		// Token: 0x04000414 RID: 1044
		[Token(Token = "0x4000414")]
		[FieldOffset(Offset = "0x80")]
		private bool HavePostFixedConstraints;

		// Token: 0x04000415 RID: 1045
		[Token(Token = "0x4000415")]
		[FieldOffset(Offset = "0x81")]
		private bool need_solve_update;

		// Token: 0x04000416 RID: 1046
		[Token(Token = "0x4000416")]
		[FieldOffset(Offset = "0x88")]
		private DiagonalMatrix WeightsM;

		// Token: 0x04000417 RID: 1047
		[Token(Token = "0x4000417")]
		[FieldOffset(Offset = "0x90")]
		private double[] Cx;

		// Token: 0x04000418 RID: 1048
		[Token(Token = "0x4000418")]
		[FieldOffset(Offset = "0x98")]
		private double[] Cy;

		// Token: 0x04000419 RID: 1049
		[Token(Token = "0x4000419")]
		[FieldOffset(Offset = "0xA0")]
		private double[] Cz;

		// Token: 0x0400041A RID: 1050
		[Token(Token = "0x400041A")]
		[FieldOffset(Offset = "0xA8")]
		private double[] Bx;

		// Token: 0x0400041B RID: 1051
		[Token(Token = "0x400041B")]
		[FieldOffset(Offset = "0xB0")]
		private double[] By;

		// Token: 0x0400041C RID: 1052
		[Token(Token = "0x400041C")]
		[FieldOffset(Offset = "0xB8")]
		private double[] Bz;

		// Token: 0x0400041D RID: 1053
		[Token(Token = "0x400041D")]
		[FieldOffset(Offset = "0xC0")]
		private DiagonalMatrix Preconditioner;

		// Token: 0x0400041E RID: 1054
		[Token(Token = "0x400041E")]
		[FieldOffset(Offset = "0xC8")]
		public bool UseSoftConstraintNormalEquations;

		// Token: 0x0400041F RID: 1055
		[Token(Token = "0x400041F")]
		[FieldOffset(Offset = "0xD0")]
		private double[] Sx;

		// Token: 0x04000420 RID: 1056
		[Token(Token = "0x4000420")]
		[FieldOffset(Offset = "0xD8")]
		private double[] Sy;

		// Token: 0x04000421 RID: 1057
		[Token(Token = "0x4000421")]
		[FieldOffset(Offset = "0xE0")]
		private double[] Sz;

		// Token: 0x02000111 RID: 273
		[Token(Token = "0x2000111")]
		public struct SoftConstraintV
		{
			// Token: 0x04000422 RID: 1058
			[Token(Token = "0x4000422")]
			[FieldOffset(Offset = "0x0")]
			public Vector3d Position;

			// Token: 0x04000423 RID: 1059
			[Token(Token = "0x4000423")]
			[FieldOffset(Offset = "0x18")]
			public double Weight;

			// Token: 0x04000424 RID: 1060
			[Token(Token = "0x4000424")]
			[FieldOffset(Offset = "0x20")]
			public bool PostFix;
		}
	}
}
