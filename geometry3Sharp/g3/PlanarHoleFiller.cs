using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020002F9 RID: 761
	[Token(Token = "0x20002F9")]
	public class PlanarHoleFiller
	{
		// Token: 0x060019BF RID: 6591 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019BF")]
		[Address(RVA = "0x1F11680", Offset = "0x1F0FC80", VA = "0x181F11680")]
		public PlanarHoleFiller(DMesh3 mesh)
		{
		}

		// Token: 0x060019C0 RID: 6592 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019C0")]
		[Address(RVA = "0x1F11800", Offset = "0x1F0FE00", VA = "0x181F11800")]
		public PlanarHoleFiller(MeshPlaneCut cut)
		{
		}

		// Token: 0x060019C1 RID: 6593 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019C1")]
		[Address(RVA = "0x1F11A20", Offset = "0x1F10020", VA = "0x181F11A20")]
		public void SetPlane(Vector3d origin, Vector3d normal)
		{
		}

		// Token: 0x060019C2 RID: 6594 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019C2")]
		[Address(RVA = "0x1F11AD0", Offset = "0x1F100D0", VA = "0x181F11AD0")]
		public void SetPlane(Vector3d origin, Vector3d normal, Vector3d planeX, Vector3d planeY)
		{
		}

		// Token: 0x060019C3 RID: 6595 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019C3")]
		[Address(RVA = "0x1F11B30", Offset = "0x1F10130", VA = "0x181F11B30")]
		public void AddFillLoop(EdgeLoop loop)
		{
		}

		// Token: 0x060019C4 RID: 6596 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019C4")]
		[Address(RVA = "0x1F11C40", Offset = "0x1F10240", VA = "0x181F11C40")]
		public void AddFillLoops(IEnumerable<EdgeLoop> loops)
		{
		}

		// Token: 0x060019C5 RID: 6597 RVA: 0x00012BE4 File Offset: 0x00010DE4
		[Token(Token = "0x60019C5")]
		[Address(RVA = "0x1F11E00", Offset = "0x1F10400", VA = "0x181F11E00")]
		public bool Fill()
		{
			return default(bool);
		}

		// Token: 0x060019C6 RID: 6598 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60019C6")]
		[Address(RVA = "0x1F12F40", Offset = "0x1F11540", VA = "0x181F12F40")]
		private List<int> build_merge_map(DMesh3 fillMesh, int[] fillLoopV, DMesh3 targetMesh, int[] targetLoopV, double tol, IndexMap mergeMapV)
		{
			return null;
		}

		// Token: 0x060019C7 RID: 6599 RVA: 0x00012BFC File Offset: 0x00010DFC
		[Token(Token = "0x60019C7")]
		[Address(RVA = "0x1F134A0", Offset = "0x1F11AA0", VA = "0x181F134A0")]
		private bool build_merge_map_simple(DMesh3 fillMesh, int[] fillLoopV, DMesh3 targetMesh, int[] targetLoopV, double tol, IndexMap mergeMapV)
		{
			return default(bool);
		}

		// Token: 0x060019C8 RID: 6600 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019C8")]
		[Address(RVA = "0x1F13650", Offset = "0x1F11C50", VA = "0x181F13650")]
		private void compute_polygons()
		{
		}

		// Token: 0x060019C9 RID: 6601 RVA: 0x00012C14 File Offset: 0x00010E14
		[Token(Token = "0x60019C9")]
		[Address(RVA = "0x1F13930", Offset = "0x1F11F30", VA = "0x181F13930")]
		private bool inPolygon(Vector2d v2, List<GeneralPolygon2d> polys, bool all = false)
		{
			return default(bool);
		}

		// Token: 0x060019CA RID: 6602 RVA: 0x00012C2C File Offset: 0x00010E2C
		[Token(Token = "0x60019CA")]
		[Address(RVA = "0x1F13AE0", Offset = "0x1F120E0", VA = "0x181F13AE0")]
		private Vector2d to2D(Vector3d v)
		{
			return default(Vector2d);
		}

		// Token: 0x060019CB RID: 6603 RVA: 0x00012C44 File Offset: 0x00010E44
		[Token(Token = "0x60019CB")]
		[Address(RVA = "0x1F13C10", Offset = "0x1F12210", VA = "0x181F13C10")]
		private Vector3d to3D(Vector2d v)
		{
			return default(Vector3d);
		}

		// Token: 0x04000D85 RID: 3461
		[Token(Token = "0x4000D85")]
		[FieldOffset(Offset = "0x10")]
		public DMesh3 Mesh;

		// Token: 0x04000D86 RID: 3462
		[Token(Token = "0x4000D86")]
		[FieldOffset(Offset = "0x18")]
		public Vector3d PlaneOrigin;

		// Token: 0x04000D87 RID: 3463
		[Token(Token = "0x4000D87")]
		[FieldOffset(Offset = "0x30")]
		public Vector3d PlaneNormal;

		// Token: 0x04000D88 RID: 3464
		[Token(Token = "0x4000D88")]
		[FieldOffset(Offset = "0x48")]
		public double FillTargetEdgeLen;

		// Token: 0x04000D89 RID: 3465
		[Token(Token = "0x4000D89")]
		[FieldOffset(Offset = "0x50")]
		public bool MergeFillBoundary;

		// Token: 0x04000D8A RID: 3466
		[Token(Token = "0x4000D8A")]
		[FieldOffset(Offset = "0x51")]
		public bool OutputHasCracks;

		// Token: 0x04000D8B RID: 3467
		[Token(Token = "0x4000D8B")]
		[FieldOffset(Offset = "0x54")]
		public int FailedInsertions;

		// Token: 0x04000D8C RID: 3468
		[Token(Token = "0x4000D8C")]
		[FieldOffset(Offset = "0x58")]
		public int FailedMerges;

		// Token: 0x04000D8D RID: 3469
		[Token(Token = "0x4000D8D")]
		[FieldOffset(Offset = "0x60")]
		private Vector3d PlaneX;

		// Token: 0x04000D8E RID: 3470
		[Token(Token = "0x4000D8E")]
		[FieldOffset(Offset = "0x78")]
		private Vector3d PlaneY;

		// Token: 0x04000D8F RID: 3471
		[Token(Token = "0x4000D8F")]
		[FieldOffset(Offset = "0x90")]
		private List<PlanarHoleFiller.FillLoop> Loops;

		// Token: 0x04000D90 RID: 3472
		[Token(Token = "0x4000D90")]
		[FieldOffset(Offset = "0x98")]
		private AxisAlignedBox2d Bounds;

		// Token: 0x020002FA RID: 762
		[Token(Token = "0x20002FA")]
		private class FillLoop
		{
			// Token: 0x060019CC RID: 6604 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60019CC")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public FillLoop()
			{
			}

			// Token: 0x04000D91 RID: 3473
			[Token(Token = "0x4000D91")]
			[FieldOffset(Offset = "0x10")]
			public EdgeLoop edgeLoop;

			// Token: 0x04000D92 RID: 3474
			[Token(Token = "0x4000D92")]
			[FieldOffset(Offset = "0x18")]
			public Polygon2d poly;
		}
	}
}
