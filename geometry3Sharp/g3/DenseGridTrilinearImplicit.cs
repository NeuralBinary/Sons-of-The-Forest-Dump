using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200015A RID: 346
	[Token(Token = "0x200015A")]
	public class DenseGridTrilinearImplicit : BoundedImplicitFunction3d, ImplicitFunction3d
	{
		// Token: 0x0600099C RID: 2460 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600099C")]
		[Address(RVA = "0x1FEF370", Offset = "0x1FED970", VA = "0x181FEF370")]
		public DenseGridTrilinearImplicit(DenseGrid3f grid, Vector3d gridOrigin, double cellSize)
		{
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600099D")]
		[Address(RVA = "0x1FEF470", Offset = "0x1FEDA70", VA = "0x181FEF470")]
		public DenseGridTrilinearImplicit(MeshSignedDistanceGrid sdf_grid)
		{
		}

		// Token: 0x0600099E RID: 2462 RVA: 0x00007334 File Offset: 0x00005534
		[Token(Token = "0x600099E")]
		[Address(RVA = "0x1FEB700", Offset = "0x1FE9D00", VA = "0x181FEB700", Slot = "4")]
		public AxisAlignedBox3d Bounds()
		{
			return default(AxisAlignedBox3d);
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x0000734C File Offset: 0x0000554C
		[Token(Token = "0x600099F")]
		[Address(RVA = "0x1FEF5C0", Offset = "0x1FEDBC0", VA = "0x181FEF5C0", Slot = "5")]
		public double Value(ref Vector3d pt)
		{
			return 0.0;
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x00007364 File Offset: 0x00005564
		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x1FEF8A0", Offset = "0x1FEDEA0", VA = "0x181FEF8A0")]
		public Vector3d Gradient(ref Vector3d pt)
		{
			return default(Vector3d);
		}

		// Token: 0x04000564 RID: 1380
		[Token(Token = "0x4000564")]
		[FieldOffset(Offset = "0x10")]
		public DenseGrid3f Grid;

		// Token: 0x04000565 RID: 1381
		[Token(Token = "0x4000565")]
		[FieldOffset(Offset = "0x18")]
		public double CellSize;

		// Token: 0x04000566 RID: 1382
		[Token(Token = "0x4000566")]
		[FieldOffset(Offset = "0x20")]
		public Vector3d GridOrigin;

		// Token: 0x04000567 RID: 1383
		[Token(Token = "0x4000567")]
		[FieldOffset(Offset = "0x38")]
		public double Outside;
	}
}
