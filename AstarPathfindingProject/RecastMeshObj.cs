using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x020000CA RID: 202
	[Token(Token = "0x20000CA")]
	[AddComponentMenu("Pathfinding/Navmesh/RecastMeshObj")]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_recast_mesh_obj.php")]
	public class RecastMeshObj : VersionedMonoBehaviour
	{
		// Token: 0x06000752 RID: 1874 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000752")]
		[Address(RVA = "0x6BB4F0", Offset = "0x6B9AF0", VA = "0x1806BB4F0")]
		public static void GetAllInBounds(List<RecastMeshObj> buffer, Bounds bounds)
		{
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000753")]
		[Address(RVA = "0x6BBBA0", Offset = "0x6BA1A0", VA = "0x1806BBBA0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000754")]
		[Address(RVA = "0x6BBBB0", Offset = "0x6BA1B0", VA = "0x1806BBBB0")]
		private void Register()
		{
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000755")]
		[Address(RVA = "0x6BC120", Offset = "0x6BA720", VA = "0x1806BC120")]
		private void RecalculateBounds()
		{
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x000057BC File Offset: 0x000039BC
		[Token(Token = "0x6000756")]
		[Address(RVA = "0x6BC5F0", Offset = "0x6BABF0", VA = "0x1806BC5F0")]
		public Bounds GetBounds()
		{
			return default(Bounds);
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000757")]
		[Address(RVA = "0x6BC630", Offset = "0x6BAC30", VA = "0x1806BC630")]
		public MeshFilter GetMeshFilter()
		{
			return null;
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000758")]
		[Address(RVA = "0x6BC670", Offset = "0x6BAC70", VA = "0x1806BC670")]
		public Collider GetCollider()
		{
			return null;
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000759")]
		[Address(RVA = "0x6BC6B0", Offset = "0x6BACB0", VA = "0x1806BC6B0")]
		private void OnDisable()
		{
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600075A")]
		[Address(RVA = "0x6BC7C0", Offset = "0x6BADC0", VA = "0x1806BC7C0")]
		public RecastMeshObj()
		{
		}

		// Token: 0x040004C9 RID: 1225
		[Token(Token = "0x40004C9")]
		[FieldOffset(Offset = "0x0")]
		protected static RecastBBTree tree;

		// Token: 0x040004CA RID: 1226
		[Token(Token = "0x40004CA")]
		[FieldOffset(Offset = "0x8")]
		protected static List<RecastMeshObj> dynamicMeshObjs;

		// Token: 0x040004CB RID: 1227
		[Token(Token = "0x40004CB")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public Bounds bounds;

		// Token: 0x040004CC RID: 1228
		[Token(Token = "0x40004CC")]
		[FieldOffset(Offset = "0x40")]
		public bool dynamic;

		// Token: 0x040004CD RID: 1229
		[Token(Token = "0x40004CD")]
		[FieldOffset(Offset = "0x44")]
		public int area;

		// Token: 0x040004CE RID: 1230
		[Token(Token = "0x40004CE")]
		[FieldOffset(Offset = "0x48")]
		private bool _dynamic;

		// Token: 0x040004CF RID: 1231
		[Token(Token = "0x40004CF")]
		[FieldOffset(Offset = "0x49")]
		private bool registered;
	}
}
