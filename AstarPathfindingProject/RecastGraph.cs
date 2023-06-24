using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Pathfinding.Serialization;
using Pathfinding.Util;
using Pathfinding.Voxels;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x020000B1 RID: 177
	[Token(Token = "0x20000B1")]
	[JsonOptIn]
	[Preserve]
	public class RecastGraph : NavmeshBase, IUpdatableGraph
	{
		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060006BB RID: 1723 RVA: 0x0000533C File Offset: 0x0000353C
		[Token(Token = "0x1700011A")]
		protected override bool RecalculateNormals
		{
			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060006BC RID: 1724 RVA: 0x00005354 File Offset: 0x00003554
		[Token(Token = "0x1700011B")]
		public override float TileWorldSizeX
		{
			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x6AA320", Offset = "0x6A8920", VA = "0x1806AA320", Slot = "37")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060006BD RID: 1725 RVA: 0x0000536C File Offset: 0x0000356C
		[Token(Token = "0x1700011C")]
		public override float TileWorldSizeZ
		{
			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x6AA340", Offset = "0x6A8940", VA = "0x1806AA340", Slot = "38")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060006BE RID: 1726 RVA: 0x00005384 File Offset: 0x00003584
		[Token(Token = "0x1700011D")]
		protected override float MaxTileConnectionEdgeDistance
		{
			[Token(Token = "0x60006BE")]
			[Address(RVA = "0x6AA360", Offset = "0x6A8960", VA = "0x1806AA360", Slot = "39")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060006BF RID: 1727 RVA: 0x0000539C File Offset: 0x0000359C
		[Token(Token = "0x1700011E")]
		[Obsolete("Obsolete since this is not accurate when the graph is rotated (rotation was not supported when this property was created)")]
		public Bounds forcedBounds
		{
			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x6AA370", Offset = "0x6A8970", VA = "0x1806AA370")]
			get
			{
				return default(Bounds);
			}
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x000053B4 File Offset: 0x000035B4
		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x6AA3E0", Offset = "0x6A89E0", VA = "0x1806AA3E0")]
		[Obsolete("Use node.ClosestPointOnNode instead")]
		public Vector3 ClosestPointOnNode(TriangleMeshNode node, Vector3 pos)
		{
			return default(Vector3);
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x000053CC File Offset: 0x000035CC
		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x6AA450", Offset = "0x6A8A50", VA = "0x1806AA450")]
		[Obsolete("Use node.ContainsPoint instead")]
		public bool ContainsPoint(TriangleMeshNode node, Vector3 pos)
		{
			return default(bool);
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x6AA530", Offset = "0x6A8B30", VA = "0x1806AA530")]
		public void SnapForceBoundsToScene()
		{
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x000053E4 File Offset: 0x000035E4
		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x6AA860", Offset = "0x6A8E60", VA = "0x1806AA860", Slot = "45")]
		private GraphUpdateThreading CanUpdateAsync(GraphUpdateObject o)
		{
			return GraphUpdateThreading.UnityThread;
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x6AA890", Offset = "0x6A8E90", VA = "0x1806AA890", Slot = "43")]
		private void UpdateAreaInit(GraphUpdateObject o)
		{
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x6AACC0", Offset = "0x6A92C0", VA = "0x1806AACC0", Slot = "42")]
		private void UpdateArea(GraphUpdateObject guo)
		{
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x6AB150", Offset = "0x6A9750", VA = "0x1806AB150", Slot = "44")]
		private void UpdateAreaPost(GraphUpdateObject guo)
		{
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x6AB4F0", Offset = "0x6A9AF0", VA = "0x1806AB4F0", Slot = "20")]
		protected override IEnumerable<Progress> ScanInternal()
		{
			return null;
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x6AB590", Offset = "0x6A9B90", VA = "0x1806AB590", Slot = "41")]
		public override GraphTransform CalculateTransform()
		{
			return null;
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x6AB970", Offset = "0x6A9F70", VA = "0x1806AB970")]
		private void InitializeTileInfo()
		{
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x6ABBC0", Offset = "0x6AA1C0", VA = "0x1806ABBC0")]
		private List<RasterizationMesh>[] PutMeshesIntoTileBuckets(List<RasterizationMesh> meshes)
		{
			return null;
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x6AC030", Offset = "0x6AA630", VA = "0x1806AC030")]
		protected IEnumerable<Progress> ScanAllTiles()
		{
			return null;
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x6AC0D0", Offset = "0x6AA6D0", VA = "0x1806AC0D0")]
		private List<RasterizationMesh> CollectMeshes(Bounds bounds)
		{
			return null;
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060006CD RID: 1741 RVA: 0x000053FC File Offset: 0x000035FC
		[Token(Token = "0x1700011F")]
		private float CellHeight
		{
			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x6AC420", Offset = "0x6AAA20", VA = "0x1806AC420")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060006CE RID: 1742 RVA: 0x00005414 File Offset: 0x00003614
		[Token(Token = "0x17000120")]
		private int CharacterRadiusInVoxels
		{
			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x6AC440", Offset = "0x6AAA40", VA = "0x1806AC440")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060006CF RID: 1743 RVA: 0x0000542C File Offset: 0x0000362C
		[Token(Token = "0x17000121")]
		private int TileBorderSizeInVoxels
		{
			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x6AC460", Offset = "0x6AAA60", VA = "0x1806AC460")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060006D0 RID: 1744 RVA: 0x00005444 File Offset: 0x00003644
		[Token(Token = "0x17000122")]
		private float TileBorderSizeInWorldUnits
		{
			[Token(Token = "0x60006D0")]
			[Address(RVA = "0x6AC490", Offset = "0x6AAA90", VA = "0x1806AC490")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x0000545C File Offset: 0x0000365C
		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x6AC4D0", Offset = "0x6AAAD0", VA = "0x1806AC4D0")]
		private Bounds CalculateTileBoundsWithBorder(int x, int z)
		{
			return default(Bounds);
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x6AC6F0", Offset = "0x6AACF0", VA = "0x1806AC6F0")]
		protected NavmeshTile BuildTileMesh(Voxelize vox, int x, int z, int threadIndex = 0)
		{
			return null;
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x6ACD80", Offset = "0x6AB380", VA = "0x1806ACD80")]
		private NavmeshTile CreateTile(Voxelize vox, VoxelMesh mesh, int x, int z, int threadIndex)
		{
			return null;
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x6AD4A0", Offset = "0x6ABAA0", VA = "0x1806AD4A0", Slot = "24")]
		protected override void DeserializeSettingsCompatibility(GraphSerializationContext ctx)
		{
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x6ADBC0", Offset = "0x6AC1C0", VA = "0x1806ADBC0")]
		public RecastGraph()
		{
		}

		// Token: 0x04000444 RID: 1092
		[Token(Token = "0x4000444")]
		[FieldOffset(Offset = "0x130")]
		[JsonMember]
		public float characterRadius;

		// Token: 0x04000445 RID: 1093
		[Token(Token = "0x4000445")]
		[FieldOffset(Offset = "0x134")]
		[JsonMember]
		public float contourMaxError;

		// Token: 0x04000446 RID: 1094
		[Token(Token = "0x4000446")]
		[FieldOffset(Offset = "0x138")]
		[JsonMember]
		public float cellSize;

		// Token: 0x04000447 RID: 1095
		[Token(Token = "0x4000447")]
		[FieldOffset(Offset = "0x13C")]
		[JsonMember]
		public float walkableHeight;

		// Token: 0x04000448 RID: 1096
		[Token(Token = "0x4000448")]
		[FieldOffset(Offset = "0x140")]
		[JsonMember]
		public float walkableClimb;

		// Token: 0x04000449 RID: 1097
		[Token(Token = "0x4000449")]
		[FieldOffset(Offset = "0x144")]
		[JsonMember]
		public float maxSlope;

		// Token: 0x0400044A RID: 1098
		[Token(Token = "0x400044A")]
		[FieldOffset(Offset = "0x148")]
		[JsonMember]
		public float maxEdgeLength;

		// Token: 0x0400044B RID: 1099
		[Token(Token = "0x400044B")]
		[FieldOffset(Offset = "0x14C")]
		[JsonMember]
		public float minRegionSize;

		// Token: 0x0400044C RID: 1100
		[Token(Token = "0x400044C")]
		[FieldOffset(Offset = "0x150")]
		[JsonMember]
		public int editorTileSize;

		// Token: 0x0400044D RID: 1101
		[Token(Token = "0x400044D")]
		[FieldOffset(Offset = "0x154")]
		[JsonMember]
		public int tileSizeX;

		// Token: 0x0400044E RID: 1102
		[Token(Token = "0x400044E")]
		[FieldOffset(Offset = "0x158")]
		[JsonMember]
		public int tileSizeZ;

		// Token: 0x0400044F RID: 1103
		[Token(Token = "0x400044F")]
		[FieldOffset(Offset = "0x15C")]
		[JsonMember]
		public bool useTiles;

		// Token: 0x04000450 RID: 1104
		[Token(Token = "0x4000450")]
		[FieldOffset(Offset = "0x15D")]
		public bool scanEmptyGraph;

		// Token: 0x04000451 RID: 1105
		[Token(Token = "0x4000451")]
		[FieldOffset(Offset = "0x160")]
		[JsonMember]
		public RecastGraph.RelevantGraphSurfaceMode relevantGraphSurfaceMode;

		// Token: 0x04000452 RID: 1106
		[Token(Token = "0x4000452")]
		[FieldOffset(Offset = "0x164")]
		[JsonMember]
		public bool rasterizeColliders;

		// Token: 0x04000453 RID: 1107
		[Token(Token = "0x4000453")]
		[FieldOffset(Offset = "0x165")]
		[JsonMember]
		public bool rasterizeMeshes;

		// Token: 0x04000454 RID: 1108
		[Token(Token = "0x4000454")]
		[FieldOffset(Offset = "0x166")]
		[JsonMember]
		public bool rasterizeTerrain;

		// Token: 0x04000455 RID: 1109
		[Token(Token = "0x4000455")]
		[FieldOffset(Offset = "0x167")]
		[JsonMember]
		public bool rasterizeTrees;

		// Token: 0x04000456 RID: 1110
		[Token(Token = "0x4000456")]
		[FieldOffset(Offset = "0x168")]
		[JsonMember]
		public float colliderRasterizeDetail;

		// Token: 0x04000457 RID: 1111
		[Token(Token = "0x4000457")]
		[FieldOffset(Offset = "0x16C")]
		[JsonMember]
		public LayerMask mask;

		// Token: 0x04000458 RID: 1112
		[Token(Token = "0x4000458")]
		[FieldOffset(Offset = "0x170")]
		[JsonMember]
		public List<string> tagMask;

		// Token: 0x04000459 RID: 1113
		[Token(Token = "0x4000459")]
		[FieldOffset(Offset = "0x178")]
		[JsonMember]
		public int terrainSampleSize;

		// Token: 0x0400045A RID: 1114
		[Token(Token = "0x400045A")]
		[FieldOffset(Offset = "0x17C")]
		[JsonMember]
		public Vector3 rotation;

		// Token: 0x0400045B RID: 1115
		[Token(Token = "0x400045B")]
		[FieldOffset(Offset = "0x188")]
		[JsonMember]
		public Vector3 forcedBoundsCenter;

		// Token: 0x0400045C RID: 1116
		[Token(Token = "0x400045C")]
		[FieldOffset(Offset = "0x198")]
		private Voxelize globalVox;

		// Token: 0x0400045D RID: 1117
		[Token(Token = "0x400045D")]
		public const int BorderVertexMask = 1;

		// Token: 0x0400045E RID: 1118
		[Token(Token = "0x400045E")]
		public const int BorderVertexOffset = 31;

		// Token: 0x0400045F RID: 1119
		[Token(Token = "0x400045F")]
		[FieldOffset(Offset = "0x1A0")]
		private List<NavmeshTile> stagingTiles;

		// Token: 0x020000B2 RID: 178
		[Token(Token = "0x20000B2")]
		public enum RelevantGraphSurfaceMode
		{
			// Token: 0x04000461 RID: 1121
			[Token(Token = "0x4000461")]
			DoNotRequire,
			// Token: 0x04000462 RID: 1122
			[Token(Token = "0x4000462")]
			OnlyForCompletelyInsideTile,
			// Token: 0x04000463 RID: 1123
			[Token(Token = "0x4000463")]
			RequireForAll
		}
	}
}
