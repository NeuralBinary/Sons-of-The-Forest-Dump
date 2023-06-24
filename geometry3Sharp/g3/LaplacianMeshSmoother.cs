using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020002CC RID: 716
	[Token(Token = "0x20002CC")]
	public class LaplacianMeshSmoother
	{
		// Token: 0x060018F7 RID: 6391 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018F7")]
		[Address(RVA = "0x1EF08D0", Offset = "0x1EEEED0", VA = "0x181EF08D0")]
		public LaplacianMeshSmoother(DMesh3 mesh)
		{
		}

		// Token: 0x060018F8 RID: 6392 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018F8")]
		[Address(RVA = "0x1EF0A60", Offset = "0x1EEF060", VA = "0x181EF0A60")]
		public void SetConstraint(int vID, Vector3d targetPos, double weight, bool bForceToFixedPos = false)
		{
		}

		// Token: 0x060018F9 RID: 6393 RVA: 0x00012554 File Offset: 0x00010754
		[Token(Token = "0x60018F9")]
		[Address(RVA = "0x1EF0B60", Offset = "0x1EEF160", VA = "0x181EF0B60")]
		public bool IsConstrained(int vID)
		{
			return default(bool);
		}

		// Token: 0x060018FA RID: 6394 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018FA")]
		[Address(RVA = "0x1EF0BD0", Offset = "0x1EEF1D0", VA = "0x181EF0BD0")]
		public void ClearConstraints()
		{
		}

		// Token: 0x060018FB RID: 6395 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018FB")]
		[Address(RVA = "0x1EF0C70", Offset = "0x1EEF270", VA = "0x181EF0C70")]
		public void Initialize()
		{
		}

		// Token: 0x060018FC RID: 6396 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018FC")]
		[Address(RVA = "0x1EF2270", Offset = "0x1EF0870", VA = "0x181EF2270")]
		private void UpdateForSolve()
		{
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x0001256C File Offset: 0x0001076C
		[Token(Token = "0x60018FD")]
		[Address(RVA = "0x1EF2800", Offset = "0x1EF0E00", VA = "0x181EF2800")]
		public bool SolveMultipleCG(Vector3d[] Result)
		{
			return default(bool);
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x00012584 File Offset: 0x00010784
		[Token(Token = "0x60018FE")]
		[Address(RVA = "0x1EF3700", Offset = "0x1EF1D00", VA = "0x181EF3700")]
		public bool SolveMultipleRHS(Vector3d[] Result)
		{
			return default(bool);
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x0001259C File Offset: 0x0001079C
		[Token(Token = "0x60018FF")]
		[Address(RVA = "0x1EF3E60", Offset = "0x1EF2460", VA = "0x181EF3E60")]
		public bool Solve(Vector3d[] Result)
		{
			return default(bool);
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x000125B4 File Offset: 0x000107B4
		[Token(Token = "0x6001900")]
		[Address(RVA = "0x1EF3EA0", Offset = "0x1EF24A0", VA = "0x181EF3EA0")]
		public bool SolveAndUpdateMesh()
		{
			return default(bool);
		}

		// Token: 0x06001901 RID: 6401 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001901")]
		[Address(RVA = "0x1EF40C0", Offset = "0x1EF26C0", VA = "0x181EF40C0")]
		public static void RegionSmooth(DMesh3 mesh, IEnumerable<int> triangles, int nConstrainLoops, int nIncludeExteriorRings, bool bPreserveExteriorRings, double borderWeight = 10.0, double interiorWeight = 0.0)
		{
		}

		// Token: 0x04000C79 RID: 3193
		[Token(Token = "0x4000C79")]
		[FieldOffset(Offset = "0x10")]
		public DMesh3 Mesh;

		// Token: 0x04000C7A RID: 3194
		[Token(Token = "0x4000C7A")]
		[FieldOffset(Offset = "0x18")]
		private PackedSparseMatrix PackedM;

		// Token: 0x04000C7B RID: 3195
		[Token(Token = "0x4000C7B")]
		[FieldOffset(Offset = "0x20")]
		private int N;

		// Token: 0x04000C7C RID: 3196
		[Token(Token = "0x4000C7C")]
		[FieldOffset(Offset = "0x28")]
		private int[] ToMeshV;

		// Token: 0x04000C7D RID: 3197
		[Token(Token = "0x4000C7D")]
		[FieldOffset(Offset = "0x30")]
		private int[] ToIndex;

		// Token: 0x04000C7E RID: 3198
		[Token(Token = "0x4000C7E")]
		[FieldOffset(Offset = "0x38")]
		private double[] Px;

		// Token: 0x04000C7F RID: 3199
		[Token(Token = "0x4000C7F")]
		[FieldOffset(Offset = "0x40")]
		private double[] Py;

		// Token: 0x04000C80 RID: 3200
		[Token(Token = "0x4000C80")]
		[FieldOffset(Offset = "0x48")]
		private double[] Pz;

		// Token: 0x04000C81 RID: 3201
		[Token(Token = "0x4000C81")]
		[FieldOffset(Offset = "0x50")]
		private int[] nbr_counts;

		// Token: 0x04000C82 RID: 3202
		[Token(Token = "0x4000C82")]
		[FieldOffset(Offset = "0x58")]
		private double[] MLx;

		// Token: 0x04000C83 RID: 3203
		[Token(Token = "0x4000C83")]
		[FieldOffset(Offset = "0x60")]
		private double[] MLy;

		// Token: 0x04000C84 RID: 3204
		[Token(Token = "0x4000C84")]
		[FieldOffset(Offset = "0x68")]
		private double[] MLz;

		// Token: 0x04000C85 RID: 3205
		[Token(Token = "0x4000C85")]
		[FieldOffset(Offset = "0x70")]
		private Dictionary<int, LaplacianMeshSmoother.SoftConstraintV> SoftConstraints;

		// Token: 0x04000C86 RID: 3206
		[Token(Token = "0x4000C86")]
		[FieldOffset(Offset = "0x78")]
		private bool HavePostFixedConstraints;

		// Token: 0x04000C87 RID: 3207
		[Token(Token = "0x4000C87")]
		[FieldOffset(Offset = "0x79")]
		private bool need_solve_update;

		// Token: 0x04000C88 RID: 3208
		[Token(Token = "0x4000C88")]
		[FieldOffset(Offset = "0x80")]
		private DiagonalMatrix WeightsM;

		// Token: 0x04000C89 RID: 3209
		[Token(Token = "0x4000C89")]
		[FieldOffset(Offset = "0x88")]
		private double[] Cx;

		// Token: 0x04000C8A RID: 3210
		[Token(Token = "0x4000C8A")]
		[FieldOffset(Offset = "0x90")]
		private double[] Cy;

		// Token: 0x04000C8B RID: 3211
		[Token(Token = "0x4000C8B")]
		[FieldOffset(Offset = "0x98")]
		private double[] Cz;

		// Token: 0x04000C8C RID: 3212
		[Token(Token = "0x4000C8C")]
		[FieldOffset(Offset = "0xA0")]
		private double[] Bx;

		// Token: 0x04000C8D RID: 3213
		[Token(Token = "0x4000C8D")]
		[FieldOffset(Offset = "0xA8")]
		private double[] By;

		// Token: 0x04000C8E RID: 3214
		[Token(Token = "0x4000C8E")]
		[FieldOffset(Offset = "0xB0")]
		private double[] Bz;

		// Token: 0x04000C8F RID: 3215
		[Token(Token = "0x4000C8F")]
		[FieldOffset(Offset = "0xB8")]
		private DiagonalMatrix Preconditioner;

		// Token: 0x04000C90 RID: 3216
		[Token(Token = "0x4000C90")]
		[FieldOffset(Offset = "0xC0")]
		public bool UseSoftConstraintNormalEquations;

		// Token: 0x04000C91 RID: 3217
		[Token(Token = "0x4000C91")]
		[FieldOffset(Offset = "0xC8")]
		private double[] Sx;

		// Token: 0x04000C92 RID: 3218
		[Token(Token = "0x4000C92")]
		[FieldOffset(Offset = "0xD0")]
		private double[] Sy;

		// Token: 0x04000C93 RID: 3219
		[Token(Token = "0x4000C93")]
		[FieldOffset(Offset = "0xD8")]
		private double[] Sz;

		// Token: 0x020002CD RID: 717
		[Token(Token = "0x20002CD")]
		public struct SoftConstraintV
		{
			// Token: 0x04000C94 RID: 3220
			[Token(Token = "0x4000C94")]
			[FieldOffset(Offset = "0x0")]
			public Vector3d Position;

			// Token: 0x04000C95 RID: 3221
			[Token(Token = "0x4000C95")]
			[FieldOffset(Offset = "0x18")]
			public double Weight;

			// Token: 0x04000C96 RID: 3222
			[Token(Token = "0x4000C96")]
			[FieldOffset(Offset = "0x20")]
			public bool PostFix;
		}
	}
}
