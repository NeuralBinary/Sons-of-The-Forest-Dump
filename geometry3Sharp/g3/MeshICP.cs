using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020002D8 RID: 728
	[Token(Token = "0x20002D8")]
	public class MeshICP
	{
		// Token: 0x06001925 RID: 6437 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001925")]
		[Address(RVA = "0x1EF9F80", Offset = "0x1EF8580", VA = "0x181EF9F80")]
		public MeshICP(IPointSet source, DMeshAABBTree3 target)
		{
		}

		// Token: 0x06001926 RID: 6438 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001926")]
		[Address(RVA = "0x1EFA110", Offset = "0x1EF8710", VA = "0x181EFA110")]
		public void Solve(bool bUpdate = false)
		{
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06001927 RID: 6439 RVA: 0x00012704 File Offset: 0x00010904
		[Token(Token = "0x170003DD")]
		public double Error
		{
			[Token(Token = "0x6001927")]
			[Address(RVA = "0x1EFA2F0", Offset = "0x1EF88F0", VA = "0x181EFA2F0")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06001928 RID: 6440 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001928")]
		[Address(RVA = "0x1EFA300", Offset = "0x1EF8900", VA = "0x181EFA300")]
		public void UpdateVertices(IDeformableMesh target)
		{
		}

		// Token: 0x06001929 RID: 6441 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001929")]
		[Address(RVA = "0x1EFA770", Offset = "0x1EF8D70", VA = "0x181EFA770")]
		private void initialize()
		{
		}

		// Token: 0x0600192A RID: 6442 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600192A")]
		[Address(RVA = "0x1EFACE0", Offset = "0x1EF92E0", VA = "0x181EFACE0")]
		private void update_from()
		{
		}

		// Token: 0x0600192B RID: 6443 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600192B")]
		[Address(RVA = "0x1EFB110", Offset = "0x1EF9710", VA = "0x181EFB110")]
		private void update_to()
		{
		}

		// Token: 0x0600192C RID: 6444 RVA: 0x0001271C File Offset: 0x0001091C
		[Token(Token = "0x600192C")]
		[Address(RVA = "0x1EFB2B0", Offset = "0x1EF98B0", VA = "0x181EFB2B0")]
		private double measure_error()
		{
			return 0.0;
		}

		// Token: 0x0600192D RID: 6445 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600192D")]
		[Address(RVA = "0x1EFB490", Offset = "0x1EF9A90", VA = "0x181EFB490")]
		private void update_transformation()
		{
		}

		// Token: 0x04000CCB RID: 3275
		[Token(Token = "0x4000CCB")]
		[FieldOffset(Offset = "0x10")]
		public IPointSet Source;

		// Token: 0x04000CCC RID: 3276
		[Token(Token = "0x4000CCC")]
		[FieldOffset(Offset = "0x18")]
		public DMeshAABBTree3 TargetSurface;

		// Token: 0x04000CCD RID: 3277
		[Token(Token = "0x4000CCD")]
		[FieldOffset(Offset = "0x20")]
		public Vector3d Translation;

		// Token: 0x04000CCE RID: 3278
		[Token(Token = "0x4000CCE")]
		[FieldOffset(Offset = "0x38")]
		public Quaterniond Rotation;

		// Token: 0x04000CCF RID: 3279
		[Token(Token = "0x4000CCF")]
		[FieldOffset(Offset = "0x58")]
		public Action<string> VerboseF;

		// Token: 0x04000CD0 RID: 3280
		[Token(Token = "0x4000CD0")]
		[FieldOffset(Offset = "0x60")]
		public int MaxIterations;

		// Token: 0x04000CD1 RID: 3281
		[Token(Token = "0x4000CD1")]
		[FieldOffset(Offset = "0x64")]
		public bool UseNormals;

		// Token: 0x04000CD2 RID: 3282
		[Token(Token = "0x4000CD2")]
		[FieldOffset(Offset = "0x68")]
		public double MaxAllowableDistance;

		// Token: 0x04000CD3 RID: 3283
		[Token(Token = "0x4000CD3")]
		[FieldOffset(Offset = "0x70")]
		public double ConvergeTolerance;

		// Token: 0x04000CD4 RID: 3284
		[Token(Token = "0x4000CD4")]
		[FieldOffset(Offset = "0x78")]
		public bool Converged;

		// Token: 0x04000CD5 RID: 3285
		[Token(Token = "0x4000CD5")]
		[FieldOffset(Offset = "0x79")]
		private bool is_initialized;

		// Token: 0x04000CD6 RID: 3286
		[Token(Token = "0x4000CD6")]
		[FieldOffset(Offset = "0x80")]
		private int[] MapV;

		// Token: 0x04000CD7 RID: 3287
		[Token(Token = "0x4000CD7")]
		[FieldOffset(Offset = "0x88")]
		private Vector3d[] From;

		// Token: 0x04000CD8 RID: 3288
		[Token(Token = "0x4000CD8")]
		[FieldOffset(Offset = "0x90")]
		private Vector3d[] To;

		// Token: 0x04000CD9 RID: 3289
		[Token(Token = "0x4000CD9")]
		[FieldOffset(Offset = "0x98")]
		private double[] Weights;

		// Token: 0x04000CDA RID: 3290
		[Token(Token = "0x4000CDA")]
		[FieldOffset(Offset = "0xA0")]
		private double LastError;
	}
}
