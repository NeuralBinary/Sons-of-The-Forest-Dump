using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020002FC RID: 764
	[Token(Token = "0x20002FC")]
	public class PlanarSpansFiller
	{
		// Token: 0x060019CF RID: 6607 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019CF")]
		[Address(RVA = "0x1F13ED0", Offset = "0x1F124D0", VA = "0x181F13ED0")]
		public PlanarSpansFiller(DMesh3 mesh, IList<EdgeSpan> spans)
		{
		}

		// Token: 0x060019D0 RID: 6608 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019D0")]
		[Address(RVA = "0x1F14050", Offset = "0x1F12650", VA = "0x181F14050")]
		public void SetPlane(Vector3d origin, Vector3d normal)
		{
		}

		// Token: 0x060019D1 RID: 6609 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019D1")]
		[Address(RVA = "0x1F14100", Offset = "0x1F12700", VA = "0x181F14100")]
		public void SetPlane(Vector3d origin, Vector3d normal, Vector3d planeX, Vector3d planeY)
		{
		}

		// Token: 0x060019D2 RID: 6610 RVA: 0x00012C74 File Offset: 0x00010E74
		[Token(Token = "0x60019D2")]
		[Address(RVA = "0x1F14160", Offset = "0x1F12760", VA = "0x181F14160")]
		public bool Fill()
		{
			return default(bool);
		}

		// Token: 0x060019D3 RID: 6611 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019D3")]
		[Address(RVA = "0x1F14BC0", Offset = "0x1F131C0", VA = "0x181F14BC0")]
		private void compute_polygon()
		{
		}

		// Token: 0x060019D4 RID: 6612 RVA: 0x00012C8C File Offset: 0x00010E8C
		[Token(Token = "0x60019D4")]
		[Address(RVA = "0x1F14E60", Offset = "0x1F13460", VA = "0x181F14E60")]
		private Vector2d to2D(Vector3d v)
		{
			return default(Vector2d);
		}

		// Token: 0x060019D5 RID: 6613 RVA: 0x00012CA4 File Offset: 0x00010EA4
		[Token(Token = "0x60019D5")]
		[Address(RVA = "0x1F14F90", Offset = "0x1F13590", VA = "0x181F14F90")]
		private Vector3d to3D(Vector2d v)
		{
			return default(Vector3d);
		}

		// Token: 0x04000D97 RID: 3479
		[Token(Token = "0x4000D97")]
		[FieldOffset(Offset = "0x10")]
		public DMesh3 Mesh;

		// Token: 0x04000D98 RID: 3480
		[Token(Token = "0x4000D98")]
		[FieldOffset(Offset = "0x18")]
		public Vector3d PlaneOrigin;

		// Token: 0x04000D99 RID: 3481
		[Token(Token = "0x4000D99")]
		[FieldOffset(Offset = "0x30")]
		public Vector3d PlaneNormal;

		// Token: 0x04000D9A RID: 3482
		[Token(Token = "0x4000D9A")]
		[FieldOffset(Offset = "0x48")]
		public double FillTargetEdgeLen;

		// Token: 0x04000D9B RID: 3483
		[Token(Token = "0x4000D9B")]
		[FieldOffset(Offset = "0x50")]
		public bool MergeFillBoundary;

		// Token: 0x04000D9C RID: 3484
		[Token(Token = "0x4000D9C")]
		[FieldOffset(Offset = "0x58")]
		private Vector3d PlaneX;

		// Token: 0x04000D9D RID: 3485
		[Token(Token = "0x4000D9D")]
		[FieldOffset(Offset = "0x70")]
		private Vector3d PlaneY;

		// Token: 0x04000D9E RID: 3486
		[Token(Token = "0x4000D9E")]
		[FieldOffset(Offset = "0x88")]
		private List<EdgeSpan> FillSpans;

		// Token: 0x04000D9F RID: 3487
		[Token(Token = "0x4000D9F")]
		[FieldOffset(Offset = "0x90")]
		private Polygon2d SpansPoly;

		// Token: 0x04000DA0 RID: 3488
		[Token(Token = "0x4000DA0")]
		[FieldOffset(Offset = "0x98")]
		private AxisAlignedBox2d Bounds;
	}
}
