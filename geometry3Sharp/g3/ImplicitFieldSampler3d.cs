using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000175 RID: 373
	[Token(Token = "0x2000175")]
	public class ImplicitFieldSampler3d
	{
		// Token: 0x06000A00 RID: 2560 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A00")]
		[Address(RVA = "0x1FF31F0", Offset = "0x1FF17F0", VA = "0x181FF31F0")]
		public ImplicitFieldSampler3d(AxisAlignedBox3d fieldBounds, double cellSize)
		{
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000A01")]
		[Address(RVA = "0x1FF3440", Offset = "0x1FF1A40", VA = "0x181FF3440")]
		public DenseGridTrilinearImplicit ToImplicit()
		{
			return null;
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A02")]
		[Address(RVA = "0x1FF3580", Offset = "0x1FF1B80", VA = "0x181FF3580")]
		public void Clear(float f)
		{
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A03")]
		[Address(RVA = "0x1FF35D0", Offset = "0x1FF1BD0", VA = "0x181FF35D0")]
		public void Sample(BoundedImplicitFunction3d f, double expandRadius = 0.0)
		{
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A04")]
		[Address(RVA = "0x1FF3B50", Offset = "0x1FF2150", VA = "0x181FF3B50")]
		private void sample_min(BoundedImplicitFunction3d f, IEnumerable<Vector3i> indices)
		{
		}

		// Token: 0x0400059C RID: 1436
		[Token(Token = "0x400059C")]
		[FieldOffset(Offset = "0x10")]
		public DenseGrid3f Grid;

		// Token: 0x0400059D RID: 1437
		[Token(Token = "0x400059D")]
		[FieldOffset(Offset = "0x18")]
		public double CellSize;

		// Token: 0x0400059E RID: 1438
		[Token(Token = "0x400059E")]
		[FieldOffset(Offset = "0x20")]
		public Vector3d GridOrigin;

		// Token: 0x0400059F RID: 1439
		[Token(Token = "0x400059F")]
		[FieldOffset(Offset = "0x38")]
		public ShiftGridIndexer3 Indexer;

		// Token: 0x040005A0 RID: 1440
		[Token(Token = "0x40005A0")]
		[FieldOffset(Offset = "0x58")]
		public AxisAlignedBox3i GridBounds;

		// Token: 0x040005A1 RID: 1441
		[Token(Token = "0x40005A1")]
		[FieldOffset(Offset = "0x70")]
		public float BackgroundValue;

		// Token: 0x040005A2 RID: 1442
		[Token(Token = "0x40005A2")]
		[FieldOffset(Offset = "0x74")]
		public ImplicitFieldSampler3d.CombineModes CombineMode;

		// Token: 0x02000176 RID: 374
		[Token(Token = "0x2000176")]
		public enum CombineModes
		{
			// Token: 0x040005A4 RID: 1444
			[Token(Token = "0x40005A4")]
			DistanceMinUnion
		}
	}
}
