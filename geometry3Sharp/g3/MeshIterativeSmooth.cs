using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020002E4 RID: 740
	[Token(Token = "0x20002E4")]
	public class MeshIterativeSmooth
	{
		// Token: 0x0600195D RID: 6493 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600195D")]
		[Address(RVA = "0x1F046C0", Offset = "0x1F02CC0", VA = "0x181F046C0")]
		public MeshIterativeSmooth(DMesh3 mesh, int[] vertices, bool bOwnVertices = false)
		{
		}

		// Token: 0x0600195E RID: 6494 RVA: 0x0001286C File Offset: 0x00010A6C
		[Token(Token = "0x600195E")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "4")]
		public virtual ValidationStatus Validate()
		{
			return ValidationStatus.Ok;
		}

		// Token: 0x0600195F RID: 6495 RVA: 0x00012884 File Offset: 0x00010A84
		[Token(Token = "0x600195F")]
		[Address(RVA = "0x1F04900", Offset = "0x1F02F00", VA = "0x181F04900", Slot = "5")]
		public virtual bool Smooth()
		{
			return default(bool);
		}

		// Token: 0x04000D13 RID: 3347
		[Token(Token = "0x4000D13")]
		[FieldOffset(Offset = "0x10")]
		public DMesh3 Mesh;

		// Token: 0x04000D14 RID: 3348
		[Token(Token = "0x4000D14")]
		[FieldOffset(Offset = "0x18")]
		public int[] Vertices;

		// Token: 0x04000D15 RID: 3349
		[Token(Token = "0x4000D15")]
		[FieldOffset(Offset = "0x20")]
		public double Alpha;

		// Token: 0x04000D16 RID: 3350
		[Token(Token = "0x4000D16")]
		[FieldOffset(Offset = "0x28")]
		public int Rounds;

		// Token: 0x04000D17 RID: 3351
		[Token(Token = "0x4000D17")]
		[FieldOffset(Offset = "0x2C")]
		public MeshIterativeSmooth.SmoothTypes SmoothType;

		// Token: 0x04000D18 RID: 3352
		[Token(Token = "0x4000D18")]
		[FieldOffset(Offset = "0x30")]
		public Func<Vector3d, Vector3f, int, Vector3d> ProjectF;

		// Token: 0x04000D19 RID: 3353
		[Token(Token = "0x4000D19")]
		[FieldOffset(Offset = "0x38")]
		private Vector3d[] SmoothedPostions;

		// Token: 0x020002E5 RID: 741
		[Token(Token = "0x20002E5")]
		public enum SmoothTypes
		{
			// Token: 0x04000D1B RID: 3355
			[Token(Token = "0x4000D1B")]
			Uniform,
			// Token: 0x04000D1C RID: 3356
			[Token(Token = "0x4000D1C")]
			Cotan,
			// Token: 0x04000D1D RID: 3357
			[Token(Token = "0x4000D1D")]
			MeanValue
		}
	}
}
