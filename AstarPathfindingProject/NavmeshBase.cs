using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Pathfinding.Serialization;
using Pathfinding.Util;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x020000A0 RID: 160
	[Token(Token = "0x20000A0")]
	public abstract class NavmeshBase : NavGraph, INavmesh, INavmeshHolder, ITransformedGraph, IRaycastableGraph
	{
		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060005CD RID: 1485
		[Token(Token = "0x17000101")]
		public abstract float TileWorldSizeX { [Token(Token = "0x60005CD")] get; }

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060005CE RID: 1486
		[Token(Token = "0x17000102")]
		public abstract float TileWorldSizeZ { [Token(Token = "0x60005CE")] get; }

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060005CF RID: 1487
		[Token(Token = "0x17000103")]
		protected abstract float MaxTileConnectionEdgeDistance { [Token(Token = "0x60005CF")] get; }

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060005D0 RID: 1488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000104")]
		private GraphTransform transform
		{
			[Token(Token = "0x60005D0")]
			[Address(RVA = "0x6913C0", Offset = "0x68F9C0", VA = "0x1806913C0", Slot = "31")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060005D1 RID: 1489
		[Token(Token = "0x17000105")]
		protected abstract bool RecalculateNormals { [Token(Token = "0x60005D1")] get; }

		// Token: 0x060005D2 RID: 1490
		[Token(Token = "0x60005D2")]
		public abstract GraphTransform CalculateTransform();

		// Token: 0x060005D3 RID: 1491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x6913D0", Offset = "0x68F9D0", VA = "0x1806913D0")]
		public NavmeshTile GetTile(int x, int z)
		{
			return null;
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00004BD4 File Offset: 0x00002DD4
		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x691410", Offset = "0x68FA10", VA = "0x180691410", Slot = "27")]
		public Int3 GetVertex(int index)
		{
			return default(Int3);
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00004BEC File Offset: 0x00002DEC
		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x691480", Offset = "0x68FA80", VA = "0x180691480", Slot = "28")]
		public Int3 GetVertexInGraphSpace(int index)
		{
			return default(Int3);
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00004C04 File Offset: 0x00002E04
		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x6914F0", Offset = "0x68FAF0", VA = "0x1806914F0")]
		public static int GetTileIndex(int index)
		{
			return 0;
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00004C1C File Offset: 0x00002E1C
		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x691500", Offset = "0x68FB00", VA = "0x180691500", Slot = "29")]
		public int GetVertexArrayIndex(int index)
		{
			return 0;
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x691510", Offset = "0x68FB10", VA = "0x180691510", Slot = "30")]
		public void GetTileCoordinates(int tileIndex, out int x, out int z)
		{
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x691530", Offset = "0x68FB30", VA = "0x180691530")]
		public NavmeshTile[] GetTiles()
		{
			return null;
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00004C34 File Offset: 0x00002E34
		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x691540", Offset = "0x68FB40", VA = "0x180691540")]
		public Bounds GetTileBounds(IntRect rect)
		{
			return default(Bounds);
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00004C4C File Offset: 0x00002E4C
		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x6915F0", Offset = "0x68FBF0", VA = "0x1806915F0")]
		public Bounds GetTileBounds(int x, int z, int width = 1, int depth = 1)
		{
			return default(Bounds);
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00004C64 File Offset: 0x00002E64
		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x691690", Offset = "0x68FC90", VA = "0x180691690")]
		public Bounds GetTileBoundsInGraphSpace(IntRect rect)
		{
			return default(Bounds);
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00004C7C File Offset: 0x00002E7C
		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x6916F0", Offset = "0x68FCF0", VA = "0x1806916F0")]
		public Bounds GetTileBoundsInGraphSpace(int x, int z, int width = 1, int depth = 1)
		{
			return default(Bounds);
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00004C94 File Offset: 0x00002E94
		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x691870", Offset = "0x68FE70", VA = "0x180691870")]
		public Int2 GetTileCoordinates(Vector3 position)
		{
			return default(Int2);
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x691930", Offset = "0x68FF30", VA = "0x180691930", Slot = "18")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x691A30", Offset = "0x690030", VA = "0x180691A30", Slot = "15")]
		public override void RelocateNodes(Matrix4x4 deltaMatrix)
		{
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x691CF0", Offset = "0x6902F0", VA = "0x180691CF0")]
		public void RelocateNodes(GraphTransform newTransform)
		{
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x691E60", Offset = "0x690460", VA = "0x180691E60")]
		protected NavmeshTile NewEmptyTile(int x, int z)
		{
			return null;
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x692150", Offset = "0x690750", VA = "0x180692150", Slot = "14")]
		public override void GetNodes(Action<GraphNode> action)
		{
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00004CAC File Offset: 0x00002EAC
		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x692240", Offset = "0x690840", VA = "0x180692240")]
		public IntRect GetTouchingTiles(Bounds bounds, float margin = 0f)
		{
			return default(IntRect);
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00004CC4 File Offset: 0x00002EC4
		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x692500", Offset = "0x690B00", VA = "0x180692500")]
		public IntRect GetTouchingTilesInGraphSpace(Rect rect)
		{
			return default(IntRect);
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00004CDC File Offset: 0x00002EDC
		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x6926C0", Offset = "0x690CC0", VA = "0x1806926C0")]
		public IntRect GetTouchingTilesRound(Bounds bounds)
		{
			return default(IntRect);
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x692950", Offset = "0x690F50", VA = "0x180692950")]
		protected void ConnectTileWithNeighbours(NavmeshTile tile, bool onlyUnflagged = false)
		{
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x692AA0", Offset = "0x6910A0", VA = "0x180692AA0")]
		protected void RemoveConnectionsFromTile(NavmeshTile tile)
		{
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x692C50", Offset = "0x691250", VA = "0x180692C50")]
		protected void RemoveConnectionsFromTo(NavmeshTile a, NavmeshTile b)
		{
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00004CF4 File Offset: 0x00002EF4
		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x692DB0", Offset = "0x6913B0", VA = "0x180692DB0", Slot = "16")]
		public override NNInfoInternal GetNearest(Vector3 position, NNConstraint constraint, GraphNode hint)
		{
			return default(NNInfoInternal);
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00004D0C File Offset: 0x00002F0C
		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x692EA0", Offset = "0x6914A0", VA = "0x180692EA0", Slot = "17")]
		public override NNInfoInternal GetNearestForce(Vector3 position, NNConstraint constraint)
		{
			return default(NNInfoInternal);
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x693490", Offset = "0x691A90", VA = "0x180693490")]
		public GraphNode PointOnNavmesh(Vector3 position, NNConstraint constraint)
		{
			return null;
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x6935E0", Offset = "0x691BE0", VA = "0x1806935E0")]
		protected void FillWithEmptyTiles()
		{
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x6936C0", Offset = "0x691CC0", VA = "0x1806936C0")]
		protected static void CreateNodeConnections(TriangleMeshNode[] nodes)
		{
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x693CB0", Offset = "0x6922B0", VA = "0x180693CB0")]
		protected void ConnectTiles(NavmeshTile tile1, NavmeshTile tile2)
		{
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x6949A0", Offset = "0x692FA0", VA = "0x1806949A0")]
		public void StartBatchTileUpdate()
		{
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x694A10", Offset = "0x693010", VA = "0x180694A10")]
		private void DestroyNodes(List<MeshNode> nodes)
		{
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x694C10", Offset = "0x693210", VA = "0x180694C10")]
		private void TryConnect(int tileIdx1, int tileIdx2)
		{
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x694CA0", Offset = "0x6932A0", VA = "0x180694CA0")]
		public void EndBatchTileUpdate()
		{
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x6950F0", Offset = "0x6936F0", VA = "0x1806950F0")]
		protected void ClearTile(int x, int z)
		{
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x6952B0", Offset = "0x6938B0", VA = "0x1806952B0")]
		private void PrepareNodeRecycling(int x, int z, Int3[] verts, int[] tris, TriangleMeshNode[] recycledNodeBuffer)
		{
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x695A70", Offset = "0x694070", VA = "0x180695A70")]
		public void ReplaceTile(int x, int z, Int3[] verts, int[] tris)
		{
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x696610", Offset = "0x694C10", VA = "0x180696610")]
		protected void CreateNodes(TriangleMeshNode[] buffer, int[] tris, int tileIndex, uint graphIndex)
		{
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x696AA0", Offset = "0x6950A0", VA = "0x180696AA0")]
		public NavmeshBase()
		{
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00004D24 File Offset: 0x00002F24
		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x696F20", Offset = "0x695520", VA = "0x180696F20", Slot = "32")]
		public bool Linecast(Vector3 origin, Vector3 end)
		{
			return default(bool);
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00004D3C File Offset: 0x00002F3C
		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x697000", Offset = "0x695600", VA = "0x180697000", Slot = "34")]
		public bool Linecast(Vector3 origin, Vector3 end, GraphNode hint, out GraphHitInfo hit)
		{
			return default(bool);
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00004D54 File Offset: 0x00002F54
		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x6970C0", Offset = "0x6956C0", VA = "0x1806970C0", Slot = "33")]
		public bool Linecast(Vector3 origin, Vector3 end, GraphNode hint)
		{
			return default(bool);
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x00004D6C File Offset: 0x00002F6C
		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x6971A0", Offset = "0x6957A0", VA = "0x1806971A0", Slot = "35")]
		public bool Linecast(Vector3 origin, Vector3 end, GraphNode hint, out GraphHitInfo hit, List<GraphNode> trace)
		{
			return default(bool);
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00004D84 File Offset: 0x00002F84
		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x697270", Offset = "0x695870", VA = "0x180697270", Slot = "36")]
		public bool Linecast(Vector3 origin, Vector3 end, out GraphHitInfo hit, List<GraphNode> trace, Func<GraphNode, bool> filter)
		{
			return default(bool);
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00004D9C File Offset: 0x00002F9C
		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x697340", Offset = "0x695940", VA = "0x180697340")]
		public static bool Linecast(NavmeshBase graph, Vector3 origin, Vector3 end, GraphNode hint, out GraphHitInfo hit)
		{
			return default(bool);
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00004DB4 File Offset: 0x00002FB4
		[Token(Token = "0x6000600")]
		[Address(RVA = "0x6977E0", Offset = "0x695DE0", VA = "0x1806977E0")]
		public static bool Linecast(NavmeshBase graph, Vector3 origin, Vector3 end, GraphNode hint, out GraphHitInfo hit, List<GraphNode> trace, [Optional] Func<GraphNode, bool> filter)
		{
			return default(bool);
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000601")]
		[Address(RVA = "0x6986D0", Offset = "0x696CD0", VA = "0x1806986D0", Slot = "25")]
		public override void OnDrawGizmos(RetainedGizmos gizmos, bool drawNodes)
		{
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000602")]
		[Address(RVA = "0x698DA0", Offset = "0x6973A0", VA = "0x180698DA0")]
		private void CreateNavmeshSurfaceVisualization(NavmeshTile[] tiles, int startTile, int endTile, GraphGizmoHelper helper)
		{
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000603")]
		[Address(RVA = "0x6993F0", Offset = "0x6979F0", VA = "0x1806993F0")]
		private static void CreateNavmeshOutlineVisualization(NavmeshTile[] tiles, int startTile, int endTile, GraphGizmoHelper helper)
		{
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000604")]
		[Address(RVA = "0x699890", Offset = "0x697E90", VA = "0x180699890", Slot = "21")]
		protected override void SerializeExtraInfo(GraphSerializationContext ctx)
		{
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000605")]
		[Address(RVA = "0x699CF0", Offset = "0x6982F0", VA = "0x180699CF0", Slot = "22")]
		protected override void DeserializeExtraInfo(GraphSerializationContext ctx)
		{
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000606")]
		[Address(RVA = "0x69A660", Offset = "0x698C60", VA = "0x18069A660", Slot = "23")]
		protected override void PostDeserialization(GraphSerializationContext ctx)
		{
		}

		// Token: 0x040003DB RID: 987
		[Token(Token = "0x40003DB")]
		public const int VertexIndexMask = 4095;

		// Token: 0x040003DC RID: 988
		[Token(Token = "0x40003DC")]
		public const int TileIndexMask = 524287;

		// Token: 0x040003DD RID: 989
		[Token(Token = "0x40003DD")]
		public const int TileIndexOffset = 12;

		// Token: 0x040003DE RID: 990
		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[JsonMember]
		public Vector3 forcedBoundsSize;

		// Token: 0x040003DF RID: 991
		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[JsonMember]
		public bool showMeshOutline;

		// Token: 0x040003E0 RID: 992
		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDD")]
		[JsonMember]
		public bool showNodeConnections;

		// Token: 0x040003E1 RID: 993
		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDE")]
		[JsonMember]
		public bool showMeshSurface;

		// Token: 0x040003E2 RID: 994
		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public int tileXCount;

		// Token: 0x040003E3 RID: 995
		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public int tileZCount;

		// Token: 0x040003E4 RID: 996
		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		protected NavmeshTile[] tiles;

		// Token: 0x040003E5 RID: 997
		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[JsonMember]
		public bool nearestSearchOnlyXZ;

		// Token: 0x040003E6 RID: 998
		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF1")]
		[JsonMember]
		public bool enableNavmeshCutting;

		// Token: 0x040003E7 RID: 999
		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		internal readonly NavmeshUpdates.NavmeshUpdateSettings navmeshUpdateData;

		// Token: 0x040003E8 RID: 1000
		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private bool batchTileUpdate;

		// Token: 0x040003E9 RID: 1001
		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private List<int> batchUpdatedTiles;

		// Token: 0x040003EA RID: 1002
		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private List<MeshNode> batchNodesToDestroy;

		// Token: 0x040003EB RID: 1003
		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public GraphTransform transform;

		// Token: 0x040003EC RID: 1004
		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public Action<NavmeshTile[]> OnRecalculatedTiles;

		// Token: 0x040003ED RID: 1005
		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly NNConstraint NNConstraintDistanceXZ;

		// Token: 0x040003EE RID: 1006
		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Dictionary<int, int> nodeRecyclingHashBuffer;

		// Token: 0x040003EF RID: 1007
		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly NNConstraint NNConstraintNoneXZ;

		// Token: 0x040003F0 RID: 1008
		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly byte[] LinecastShapeEdgeLookup;
	}
}
