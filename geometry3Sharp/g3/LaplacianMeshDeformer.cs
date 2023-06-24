using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020002C8 RID: 712
	[Token(Token = "0x20002C8")]
	public class LaplacianMeshDeformer
	{
		// Token: 0x060018E7 RID: 6375 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018E7")]
		[Address(RVA = "0x1EECE70", Offset = "0x1EEB470", VA = "0x181EECE70")]
		public LaplacianMeshDeformer(DMesh3 mesh)
		{
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018E8")]
		[Address(RVA = "0x1EED000", Offset = "0x1EEB600", VA = "0x181EED000")]
		public void SetConstraint(int vID, Vector3d targetPos, double weight, bool bForceToFixedPos = false)
		{
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x000124DC File Offset: 0x000106DC
		[Token(Token = "0x60018E9")]
		[Address(RVA = "0x1EED100", Offset = "0x1EEB700", VA = "0x181EED100")]
		public bool IsConstrained(int vID)
		{
			return default(bool);
		}

		// Token: 0x060018EA RID: 6378 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018EA")]
		[Address(RVA = "0x1EED170", Offset = "0x1EEB770", VA = "0x181EED170")]
		public void ClearConstraints()
		{
		}

		// Token: 0x060018EB RID: 6379 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018EB")]
		[Address(RVA = "0x1EED210", Offset = "0x1EEB810", VA = "0x181EED210")]
		public void Initialize()
		{
		}

		// Token: 0x060018EC RID: 6380 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018EC")]
		[Address(RVA = "0x1EEE6B0", Offset = "0x1EECCB0", VA = "0x181EEE6B0")]
		private void UpdateForSolve()
		{
		}

		// Token: 0x060018ED RID: 6381 RVA: 0x000124F4 File Offset: 0x000106F4
		[Token(Token = "0x60018ED")]
		[Address(RVA = "0x1EEEC40", Offset = "0x1EED240", VA = "0x181EEEC40")]
		public bool SolveMultipleCG(Vector3d[] Result)
		{
			return default(bool);
		}

		// Token: 0x060018EE RID: 6382 RVA: 0x0001250C File Offset: 0x0001070C
		[Token(Token = "0x60018EE")]
		[Address(RVA = "0x1EEFB40", Offset = "0x1EEE140", VA = "0x181EEFB40")]
		public bool SolveMultipleRHS(Vector3d[] Result)
		{
			return default(bool);
		}

		// Token: 0x060018EF RID: 6383 RVA: 0x00012524 File Offset: 0x00010724
		[Token(Token = "0x60018EF")]
		[Address(RVA = "0x1EF0270", Offset = "0x1EEE870", VA = "0x181EF0270")]
		public bool Solve(Vector3d[] Result)
		{
			return default(bool);
		}

		// Token: 0x060018F0 RID: 6384 RVA: 0x0001253C File Offset: 0x0001073C
		[Token(Token = "0x60018F0")]
		[Address(RVA = "0x1EF02B0", Offset = "0x1EEE8B0", VA = "0x181EF02B0")]
		public bool SolveAndUpdateMesh()
		{
			return default(bool);
		}

		// Token: 0x04000C55 RID: 3157
		[Token(Token = "0x4000C55")]
		[FieldOffset(Offset = "0x10")]
		public DMesh3 Mesh;

		// Token: 0x04000C56 RID: 3158
		[Token(Token = "0x4000C56")]
		[FieldOffset(Offset = "0x18")]
		private PackedSparseMatrix PackedM;

		// Token: 0x04000C57 RID: 3159
		[Token(Token = "0x4000C57")]
		[FieldOffset(Offset = "0x20")]
		private int N;

		// Token: 0x04000C58 RID: 3160
		[Token(Token = "0x4000C58")]
		[FieldOffset(Offset = "0x28")]
		private int[] ToMeshV;

		// Token: 0x04000C59 RID: 3161
		[Token(Token = "0x4000C59")]
		[FieldOffset(Offset = "0x30")]
		private int[] ToIndex;

		// Token: 0x04000C5A RID: 3162
		[Token(Token = "0x4000C5A")]
		[FieldOffset(Offset = "0x38")]
		private double[] Px;

		// Token: 0x04000C5B RID: 3163
		[Token(Token = "0x4000C5B")]
		[FieldOffset(Offset = "0x40")]
		private double[] Py;

		// Token: 0x04000C5C RID: 3164
		[Token(Token = "0x4000C5C")]
		[FieldOffset(Offset = "0x48")]
		private double[] Pz;

		// Token: 0x04000C5D RID: 3165
		[Token(Token = "0x4000C5D")]
		[FieldOffset(Offset = "0x50")]
		private int[] nbr_counts;

		// Token: 0x04000C5E RID: 3166
		[Token(Token = "0x4000C5E")]
		[FieldOffset(Offset = "0x58")]
		private double[] MLx;

		// Token: 0x04000C5F RID: 3167
		[Token(Token = "0x4000C5F")]
		[FieldOffset(Offset = "0x60")]
		private double[] MLy;

		// Token: 0x04000C60 RID: 3168
		[Token(Token = "0x4000C60")]
		[FieldOffset(Offset = "0x68")]
		private double[] MLz;

		// Token: 0x04000C61 RID: 3169
		[Token(Token = "0x4000C61")]
		[FieldOffset(Offset = "0x70")]
		private Dictionary<int, LaplacianMeshDeformer.SoftConstraintV> SoftConstraints;

		// Token: 0x04000C62 RID: 3170
		[Token(Token = "0x4000C62")]
		[FieldOffset(Offset = "0x78")]
		private bool HavePostFixedConstraints;

		// Token: 0x04000C63 RID: 3171
		[Token(Token = "0x4000C63")]
		[FieldOffset(Offset = "0x79")]
		private bool need_solve_update;

		// Token: 0x04000C64 RID: 3172
		[Token(Token = "0x4000C64")]
		[FieldOffset(Offset = "0x80")]
		private DiagonalMatrix WeightsM;

		// Token: 0x04000C65 RID: 3173
		[Token(Token = "0x4000C65")]
		[FieldOffset(Offset = "0x88")]
		private double[] Cx;

		// Token: 0x04000C66 RID: 3174
		[Token(Token = "0x4000C66")]
		[FieldOffset(Offset = "0x90")]
		private double[] Cy;

		// Token: 0x04000C67 RID: 3175
		[Token(Token = "0x4000C67")]
		[FieldOffset(Offset = "0x98")]
		private double[] Cz;

		// Token: 0x04000C68 RID: 3176
		[Token(Token = "0x4000C68")]
		[FieldOffset(Offset = "0xA0")]
		private double[] Bx;

		// Token: 0x04000C69 RID: 3177
		[Token(Token = "0x4000C69")]
		[FieldOffset(Offset = "0xA8")]
		private double[] By;

		// Token: 0x04000C6A RID: 3178
		[Token(Token = "0x4000C6A")]
		[FieldOffset(Offset = "0xB0")]
		private double[] Bz;

		// Token: 0x04000C6B RID: 3179
		[Token(Token = "0x4000C6B")]
		[FieldOffset(Offset = "0xB8")]
		private DiagonalMatrix Preconditioner;

		// Token: 0x04000C6C RID: 3180
		[Token(Token = "0x4000C6C")]
		[FieldOffset(Offset = "0xC0")]
		public bool UseSoftConstraintNormalEquations;

		// Token: 0x04000C6D RID: 3181
		[Token(Token = "0x4000C6D")]
		[FieldOffset(Offset = "0xC8")]
		private double[] Sx;

		// Token: 0x04000C6E RID: 3182
		[Token(Token = "0x4000C6E")]
		[FieldOffset(Offset = "0xD0")]
		private double[] Sy;

		// Token: 0x04000C6F RID: 3183
		[Token(Token = "0x4000C6F")]
		[FieldOffset(Offset = "0xD8")]
		private double[] Sz;

		// Token: 0x020002C9 RID: 713
		[Token(Token = "0x20002C9")]
		public struct SoftConstraintV
		{
			// Token: 0x04000C70 RID: 3184
			[Token(Token = "0x4000C70")]
			[FieldOffset(Offset = "0x0")]
			public Vector3d Position;

			// Token: 0x04000C71 RID: 3185
			[Token(Token = "0x4000C71")]
			[FieldOffset(Offset = "0x18")]
			public double Weight;

			// Token: 0x04000C72 RID: 3186
			[Token(Token = "0x4000C72")]
			[FieldOffset(Offset = "0x20")]
			public bool PostFix;
		}
	}
}
