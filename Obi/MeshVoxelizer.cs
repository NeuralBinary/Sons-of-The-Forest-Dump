using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x0200019B RID: 411
	[Token(Token = "0x200019B")]
	public class MeshVoxelizer
	{
		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060007B2 RID: 1970 RVA: 0x000047E4 File Offset: 0x000029E4
		[Token(Token = "0x17000107")]
		public Vector3Int Origin
		{
			[Token(Token = "0x60007B2")]
			[Address(RVA = "0x781510", Offset = "0x77FB10", VA = "0x180781510")]
			get
			{
				return default(Vector3Int);
			}
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x24033C0", Offset = "0x24019C0", VA = "0x1824033C0")]
		public MeshVoxelizer(Mesh input, float voxelSize)
		{
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x000047FC File Offset: 0x000029FC
		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x27DDEC0", Offset = "0x27DC4C0", VA = "0x1827DDEC0")]
		private Bounds GetTriangleBounds(Vector3 v1, Vector3 v2, Vector3 v3)
		{
			return default(Bounds);
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00004814 File Offset: 0x00002A14
		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x27DDFC0", Offset = "0x27DC5C0", VA = "0x1827DDFC0")]
		private Vector3Int GetPointVoxel(Vector3 point)
		{
			return default(Vector3Int);
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x0000482C File Offset: 0x00002A2C
		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x27DE040", Offset = "0x27DC640", VA = "0x1827DE040")]
		private bool VoxelExists(Vector3Int coords)
		{
			return default(bool);
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x27DE180", Offset = "0x27DC780", VA = "0x1827DE180")]
		private void AppendOverlappingVoxels(Bounds bounds, Vector3 v1, Vector3 v2, Vector3 v3)
		{
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x27DE4D0", Offset = "0x27DCAD0", VA = "0x1827DE4D0")]
		public void Voxelize(Vector3 scale)
		{
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x27DEC40", Offset = "0x27DD240", VA = "0x1827DEC40")]
		private void FloodFill()
		{
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x00004844 File Offset: 0x00002A44
		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x27DF170", Offset = "0x27DD770", VA = "0x1827DF170")]
		public static bool IsIntersecting(Bounds box, Vector3 v1, Vector3 v2, Vector3 v3)
		{
			return default(bool);
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x27DFDD0", Offset = "0x27DE3D0", VA = "0x1827DFDD0")]
		private static void Project(IEnumerable<Vector3> points, Vector3 axis, out double min, out double max)
		{
		}

		// Token: 0x04000673 RID: 1651
		[Token(Token = "0x4000673")]
		[FieldOffset(Offset = "0x10")]
		public Mesh input;

		// Token: 0x04000674 RID: 1652
		[Token(Token = "0x4000674")]
		[FieldOffset(Offset = "0x18")]
		public float voxelSize;

		// Token: 0x04000675 RID: 1653
		[Token(Token = "0x4000675")]
		[FieldOffset(Offset = "0x20")]
		public MeshVoxelizer.Voxel[,,] voxels;

		// Token: 0x04000676 RID: 1654
		[Token(Token = "0x4000676")]
		[FieldOffset(Offset = "0x28")]
		private Vector3Int origin;

		// Token: 0x0200019C RID: 412
		[Token(Token = "0x200019C")]
		public enum Voxel
		{
			// Token: 0x04000678 RID: 1656
			[Token(Token = "0x4000678")]
			Inside,
			// Token: 0x04000679 RID: 1657
			[Token(Token = "0x4000679")]
			Boundary,
			// Token: 0x0400067A RID: 1658
			[Token(Token = "0x400067A")]
			Outside
		}
	}
}
