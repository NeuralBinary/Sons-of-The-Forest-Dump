using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Voxels
{
	// Token: 0x0200010F RID: 271
	[Token(Token = "0x200010F")]
	public class RasterizationMesh
	{
		// Token: 0x060008D8 RID: 2264 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public RasterizationMesh()
		{
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x6EC9A0", Offset = "0x6EAFA0", VA = "0x1806EC9A0")]
		public RasterizationMesh(Vector3[] vertices, int[] triangles, Bounds bounds)
		{
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x6ECB60", Offset = "0x6EB160", VA = "0x1806ECB60")]
		public RasterizationMesh(Vector3[] vertices, int[] triangles, Bounds bounds, Matrix4x4 matrix)
		{
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x6ECCF0", Offset = "0x6EB2F0", VA = "0x1806ECCF0")]
		public void RecalculateBounds()
		{
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x6ED060", Offset = "0x6EB660", VA = "0x1806ED060")]
		public void Pool()
		{
		}

		// Token: 0x04000615 RID: 1557
		[Token(Token = "0x4000615")]
		[FieldOffset(Offset = "0x10")]
		public MeshFilter original;

		// Token: 0x04000616 RID: 1558
		[Token(Token = "0x4000616")]
		[FieldOffset(Offset = "0x18")]
		public int area;

		// Token: 0x04000617 RID: 1559
		[Token(Token = "0x4000617")]
		[FieldOffset(Offset = "0x20")]
		public Vector3[] vertices;

		// Token: 0x04000618 RID: 1560
		[Token(Token = "0x4000618")]
		[FieldOffset(Offset = "0x28")]
		public int[] triangles;

		// Token: 0x04000619 RID: 1561
		[Token(Token = "0x4000619")]
		[FieldOffset(Offset = "0x30")]
		public int numVertices;

		// Token: 0x0400061A RID: 1562
		[Token(Token = "0x400061A")]
		[FieldOffset(Offset = "0x34")]
		public int numTriangles;

		// Token: 0x0400061B RID: 1563
		[Token(Token = "0x400061B")]
		[FieldOffset(Offset = "0x38")]
		public Bounds bounds;

		// Token: 0x0400061C RID: 1564
		[Token(Token = "0x400061C")]
		[FieldOffset(Offset = "0x50")]
		public Matrix4x4 matrix;

		// Token: 0x0400061D RID: 1565
		[Token(Token = "0x400061D")]
		[FieldOffset(Offset = "0x90")]
		public bool pool;
	}
}
