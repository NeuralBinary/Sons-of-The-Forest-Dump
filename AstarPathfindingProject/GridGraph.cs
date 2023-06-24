using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Pathfinding.Serialization;
using Pathfinding.Util;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x02000092 RID: 146
	[Token(Token = "0x2000092")]
	[JsonOptIn]
	[Preserve]
	public class GridGraph : NavGraph, IUpdatableGraph, ITransformedGraph, IRaycastableGraph
	{
		// Token: 0x0600051C RID: 1308 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600051C")]
		[Address(RVA = "0x67D490", Offset = "0x67BA90", VA = "0x18067D490", Slot = "18")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600051D")]
		[Address(RVA = "0x67D5D0", Offset = "0x67BBD0", VA = "0x18067D5D0", Slot = "19")]
		protected override void DestroyAllNodes()
		{
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600051E")]
		[Address(RVA = "0x67D720", Offset = "0x67BD20", VA = "0x18067D720")]
		private void RemoveGridGraphFromStatic()
		{
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x000046AC File Offset: 0x000028AC
		[Token(Token = "0x170000F1")]
		public virtual bool uniformWidthDepthGrid
		{
			[Token(Token = "0x600051F")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x000046C4 File Offset: 0x000028C4
		[Token(Token = "0x170000F2")]
		public virtual int LayerCount
		{
			[Token(Token = "0x6000520")]
			[Address(RVA = "0x67D850", Offset = "0x67BE50", VA = "0x18067D850", Slot = "37")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x000046DC File Offset: 0x000028DC
		[Token(Token = "0x6000521")]
		[Address(RVA = "0x67D860", Offset = "0x67BE60", VA = "0x18067D860", Slot = "13")]
		public override int CountNodes()
		{
			return 0;
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000522")]
		[Address(RVA = "0x67D880", Offset = "0x67BE80", VA = "0x18067D880", Slot = "14")]
		public override void GetNodes(Action<GraphNode> action)
		{
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000523 RID: 1315 RVA: 0x000046F4 File Offset: 0x000028F4
		[Token(Token = "0x170000F3")]
		protected bool useRaycastNormal
		{
			[Token(Token = "0x6000523")]
			[Address(RVA = "0x67D910", Offset = "0x67BF10", VA = "0x18067D910")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000524 RID: 1316 RVA: 0x0000470C File Offset: 0x0000290C
		// (set) Token: 0x06000525 RID: 1317 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000F4")]
		public Vector2 size
		{
			[Token(Token = "0x6000524")]
			[Address(RVA = "0x67D980", Offset = "0x67BF80", VA = "0x18067D980")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000525")]
			[Address(RVA = "0x67D9A0", Offset = "0x67BFA0", VA = "0x18067D9A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000527 RID: 1319 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000F5")]
		public GraphTransform transform
		{
			[Token(Token = "0x6000526")]
			[Address(RVA = "0x67D9B0", Offset = "0x67BFB0", VA = "0x18067D9B0", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000527")]
			[Address(RVA = "0x67D9C0", Offset = "0x67BFC0", VA = "0x18067D9C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x00004724 File Offset: 0x00002924
		// (set) Token: 0x06000529 RID: 1321 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000F6")]
		public bool is2D
		{
			[Token(Token = "0x6000528")]
			[Address(RVA = "0x67DA20", Offset = "0x67C020", VA = "0x18067DA20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000529")]
			[Address(RVA = "0x67DBD0", Offset = "0x67C1D0", VA = "0x18067DBD0")]
			set
			{
			}
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600052A")]
		[Address(RVA = "0x67DE00", Offset = "0x67C400", VA = "0x18067DE00")]
		public GridGraph()
		{
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600052B")]
		[Address(RVA = "0x67E340", Offset = "0x67C940", VA = "0x18067E340", Slot = "15")]
		public override void RelocateNodes(Matrix4x4 deltaMatrix)
		{
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600052C")]
		[Address(RVA = "0x67E390", Offset = "0x67C990", VA = "0x18067E390")]
		public void RelocateNodes(Vector3 center, Quaternion rotation, float nodeSize, float aspectRatio = 1f, float isometricAngle = 0f)
		{
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x0000473C File Offset: 0x0000293C
		[Token(Token = "0x600052D")]
		[Address(RVA = "0x67E5B0", Offset = "0x67CBB0", VA = "0x18067E5B0")]
		public Int3 GraphPointToWorld(int x, int z, float height)
		{
			return default(Int3);
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00004754 File Offset: 0x00002954
		[Token(Token = "0x600052E")]
		[Address(RVA = "0x67E6E0", Offset = "0x67CCE0", VA = "0x18067E6E0")]
		public static float ConvertHexagonSizeToNodeSize(InspectorGridHexagonNodeSize mode, float value)
		{
			return 0f;
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x0000476C File Offset: 0x0000296C
		[Token(Token = "0x600052F")]
		[Address(RVA = "0x67E7D0", Offset = "0x67CDD0", VA = "0x18067E7D0")]
		public static float ConvertNodeSizeToHexagonSize(InspectorGridHexagonNodeSize mode, float value)
		{
			return 0f;
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000530 RID: 1328 RVA: 0x00004784 File Offset: 0x00002984
		// (set) Token: 0x06000531 RID: 1329 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000F7")]
		public int Width
		{
			[Token(Token = "0x6000530")]
			[Address(RVA = "0x67E8C0", Offset = "0x67CEC0", VA = "0x18067E8C0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000531")]
			[Address(RVA = "0x67E8D0", Offset = "0x67CED0", VA = "0x18067E8D0")]
			set
			{
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000532 RID: 1330 RVA: 0x0000479C File Offset: 0x0000299C
		// (set) Token: 0x06000533 RID: 1331 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000F8")]
		public int Depth
		{
			[Token(Token = "0x6000532")]
			[Address(RVA = "0x67E8E0", Offset = "0x67CEE0", VA = "0x18067E8E0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000533")]
			[Address(RVA = "0x67E8F0", Offset = "0x67CEF0", VA = "0x18067E8F0")]
			set
			{
			}
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x000047B4 File Offset: 0x000029B4
		[Token(Token = "0x6000534")]
		[Address(RVA = "0x67E900", Offset = "0x67CF00", VA = "0x18067E900")]
		public uint GetConnectionCost(int dir)
		{
			return 0U;
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000535")]
		[Address(RVA = "0x67E930", Offset = "0x67CF30", VA = "0x18067E930")]
		[Obsolete("Use GridNode.HasConnectionInDirection instead")]
		public GridNode GetNodeConnection(GridNode node, int dir)
		{
			return null;
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x000047CC File Offset: 0x000029CC
		[Token(Token = "0x6000536")]
		[Address(RVA = "0x67EB80", Offset = "0x67D180", VA = "0x18067EB80")]
		[Obsolete("Use GridNode.HasConnectionInDirection instead")]
		public bool HasNodeConnection(GridNode node, int dir)
		{
			return default(bool);
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000537")]
		[Address(RVA = "0x67ECB0", Offset = "0x67D2B0", VA = "0x18067ECB0")]
		[Obsolete("Use GridNode.SetConnectionInternal instead")]
		public void SetNodeConnection(GridNode node, int dir, bool value)
		{
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000538")]
		[Address(RVA = "0x67ED80", Offset = "0x67D380", VA = "0x18067ED80")]
		[Obsolete("Use GridNode.HasConnectionInDirection instead")]
		private GridNode GetNodeConnection(int index, int x, int z, int dir)
		{
			return null;
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000539")]
		[Address(RVA = "0x67EF10", Offset = "0x67D510", VA = "0x18067EF10")]
		[Obsolete("Use GridNode.SetConnectionInternal instead")]
		public void SetNodeConnection(int index, int x, int z, int dir, bool value)
		{
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x000047E4 File Offset: 0x000029E4
		[Token(Token = "0x600053A")]
		[Address(RVA = "0x67EFC0", Offset = "0x67D5C0", VA = "0x18067EFC0")]
		[Obsolete("Use GridNode.HasConnectionInDirection instead")]
		public bool HasNodeConnection(int index, int x, int z, int dir)
		{
			return default(bool);
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600053B")]
		[Address(RVA = "0x67F0A0", Offset = "0x67D6A0", VA = "0x18067F0A0")]
		public void SetGridShape(InspectorGridMode shape)
		{
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600053C")]
		[Address(RVA = "0x67F1D0", Offset = "0x67D7D0", VA = "0x18067F1D0")]
		public void SetDimensions(int width, int depth, float nodeSize)
		{
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600053D")]
		[Address(RVA = "0x67F210", Offset = "0x67D810", VA = "0x18067F210")]
		[Obsolete("Use SetDimensions instead")]
		public void UpdateSizeFromWidthDepth()
		{
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600053E")]
		[Address(RVA = "0x67F250", Offset = "0x67D850", VA = "0x18067F250")]
		[Obsolete("This method has been renamed to UpdateTransform")]
		public void GenerateMatrix()
		{
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600053F")]
		[Address(RVA = "0x67F260", Offset = "0x67D860", VA = "0x18067F260")]
		public void UpdateTransform()
		{
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000540")]
		[Address(RVA = "0x67F2F0", Offset = "0x67D8F0", VA = "0x18067F2F0")]
		public GraphTransform CalculateTransform()
		{
			return null;
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000541")]
		[Address(RVA = "0x67FC80", Offset = "0x67E280", VA = "0x18067FC80")]
		private void CalculateDimensions(out int width, out int depth, out float nodeSize)
		{
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x000047FC File Offset: 0x000029FC
		[Token(Token = "0x6000542")]
		[Address(RVA = "0x67FE10", Offset = "0x67E410", VA = "0x18067FE10", Slot = "16")]
		public override NNInfoInternal GetNearest(Vector3 position, NNConstraint constraint, GraphNode hint)
		{
			return default(NNInfoInternal);
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000543")]
		[Address(RVA = "0x680100", Offset = "0x67E700", VA = "0x180680100", Slot = "38")]
		protected virtual GridNodeBase GetNearestFromGraphSpace(Vector3 positionGraphSpace)
		{
			return null;
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00004814 File Offset: 0x00002A14
		[Token(Token = "0x6000544")]
		[Address(RVA = "0x680180", Offset = "0x67E780", VA = "0x180680180", Slot = "17")]
		public override NNInfoInternal GetNearestForce(Vector3 position, NNConstraint constraint)
		{
			return default(NNInfoInternal);
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000545")]
		[Address(RVA = "0x680B70", Offset = "0x67F170", VA = "0x180680B70", Slot = "39")]
		public virtual void SetUpOffsetsAndCosts()
		{
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000546")]
		[Address(RVA = "0x680FD0", Offset = "0x67F5D0", VA = "0x180680FD0", Slot = "20")]
		protected override IEnumerable<Progress> ScanInternal()
		{
			return null;
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000547")]
		[Address(RVA = "0x681070", Offset = "0x67F670", VA = "0x180681070", Slot = "40")]
		[Obsolete("Use RecalculateCell instead which works both for grid graphs and layered grid graphs")]
		public virtual void UpdateNodePositionCollision(GridNode node, int x, int z, bool resetPenalty = true)
		{
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000548")]
		[Address(RVA = "0x6810A0", Offset = "0x67F6A0", VA = "0x1806810A0", Slot = "41")]
		public virtual void RecalculateCell(int x, int z, bool resetPenalties = true, bool resetTags = true)
		{
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x0000482C File Offset: 0x00002A2C
		[Token(Token = "0x6000549")]
		[Address(RVA = "0x681600", Offset = "0x67FC00", VA = "0x180681600", Slot = "42")]
		protected virtual bool ErosionAnyFalseConnections(GraphNode baseNode)
		{
			return default(bool);
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600054A")]
		[Address(RVA = "0x681780", Offset = "0x67FD80", VA = "0x180681780")]
		private void ErodeNode(GraphNode node)
		{
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600054B")]
		[Address(RVA = "0x6817D0", Offset = "0x67FDD0", VA = "0x1806817D0")]
		private void ErodeNodeWithTagsInit(GraphNode node)
		{
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600054C")]
		[Address(RVA = "0x681840", Offset = "0x67FE40", VA = "0x180681840")]
		private void ErodeNodeWithTags(GraphNode node, int iteration)
		{
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600054D")]
		[Address(RVA = "0x681A40", Offset = "0x680040", VA = "0x180681A40", Slot = "43")]
		public virtual void ErodeWalkableArea()
		{
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600054E")]
		[Address(RVA = "0x681A70", Offset = "0x680070", VA = "0x180681A70")]
		public void ErodeWalkableArea(int xmin, int zmin, int xmax, int zmax)
		{
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00004844 File Offset: 0x00002A44
		[Token(Token = "0x600054F")]
		[Address(RVA = "0x681EC0", Offset = "0x6804C0", VA = "0x180681EC0", Slot = "44")]
		public virtual bool IsValidConnection(GridNodeBase node1, GridNodeBase node2)
		{
			return default(bool);
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000550")]
		[Address(RVA = "0x682110", Offset = "0x680710", VA = "0x180682110")]
		public void CalculateConnectionsForCellAndNeighbours(int x, int z)
		{
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000551")]
		[Address(RVA = "0x6821E0", Offset = "0x6807E0", VA = "0x1806821E0")]
		[Obsolete("Use the instance function instead")]
		public static void CalculateConnections(GridNode node)
		{
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000552")]
		[Address(RVA = "0x682270", Offset = "0x680870", VA = "0x180682270", Slot = "45")]
		public virtual void CalculateConnections(GridNodeBase node)
		{
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000553")]
		[Address(RVA = "0x6822B0", Offset = "0x6808B0", VA = "0x1806822B0", Slot = "46")]
		[Obsolete("Use CalculateConnections(x,z) or CalculateConnections(node) instead")]
		public virtual void CalculateConnections(int x, int z, GridNode node)
		{
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000554")]
		[Address(RVA = "0x6822D0", Offset = "0x6808D0", VA = "0x1806822D0", Slot = "47")]
		public virtual void CalculateConnections(int x, int z)
		{
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000555")]
		[Address(RVA = "0x682C70", Offset = "0x681270", VA = "0x180682C70", Slot = "25")]
		public override void OnDrawGizmos(RetainedGizmos gizmos, bool drawNodes)
		{
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000556")]
		[Address(RVA = "0x683740", Offset = "0x681D40", VA = "0x180683740")]
		private void CreateNavmeshSurfaceVisualization(GridNodeBase[] nodes, int nodeCount, GraphGizmoHelper helper)
		{
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x0000485C File Offset: 0x00002A5C
		[Token(Token = "0x6000557")]
		[Address(RVA = "0x6843F0", Offset = "0x6829F0", VA = "0x1806843F0")]
		public IntRect GetRectFromBounds(Bounds bounds)
		{
			return default(IntRect);
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000558")]
		[Address(RVA = "0x684620", Offset = "0x682C20", VA = "0x180684620")]
		[Obsolete("This method has been renamed to GetNodesInRegion", true)]
		public List<GraphNode> GetNodesInArea(Bounds bounds)
		{
			return null;
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000559")]
		[Address(RVA = "0x684660", Offset = "0x682C60", VA = "0x180684660")]
		[Obsolete("This method has been renamed to GetNodesInRegion", true)]
		public List<GraphNode> GetNodesInArea(GraphUpdateShape shape)
		{
			return null;
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600055A")]
		[Address(RVA = "0x6846D0", Offset = "0x682CD0", VA = "0x1806846D0")]
		[Obsolete("This method has been renamed to GetNodesInRegion", true)]
		public List<GraphNode> GetNodesInArea(Bounds bounds, GraphUpdateShape shape)
		{
			return null;
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600055B")]
		[Address(RVA = "0x684620", Offset = "0x682C20", VA = "0x180684620")]
		public List<GraphNode> GetNodesInRegion(Bounds bounds)
		{
			return null;
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600055C")]
		[Address(RVA = "0x684660", Offset = "0x682C60", VA = "0x180684660")]
		public List<GraphNode> GetNodesInRegion(GraphUpdateShape shape)
		{
			return null;
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600055D")]
		[Address(RVA = "0x684710", Offset = "0x682D10", VA = "0x180684710", Slot = "48")]
		protected virtual List<GraphNode> GetNodesInRegion(Bounds bounds, GraphUpdateShape shape)
		{
			return null;
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600055E")]
		[Address(RVA = "0x684A40", Offset = "0x683040", VA = "0x180684A40", Slot = "49")]
		public virtual List<GraphNode> GetNodesInRegion(IntRect rect)
		{
			return null;
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00004874 File Offset: 0x00002A74
		[Token(Token = "0x600055F")]
		[Address(RVA = "0x684C80", Offset = "0x683280", VA = "0x180684C80", Slot = "50")]
		public virtual int GetNodesInRegion(IntRect rect, GridNodeBase[] buffer)
		{
			return 0;
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000560")]
		[Address(RVA = "0x684E90", Offset = "0x683490", VA = "0x180684E90", Slot = "51")]
		public virtual GridNodeBase GetNode(int x, int z)
		{
			return null;
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x0000488C File Offset: 0x00002A8C
		[Token(Token = "0x6000561")]
		[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "29")]
		private GraphUpdateThreading CanUpdateAsync(GraphUpdateObject o)
		{
			return GraphUpdateThreading.UnityThread;
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000562")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "27")]
		private void UpdateAreaInit(GraphUpdateObject o)
		{
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000563")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "28")]
		private void UpdateAreaPost(GraphUpdateObject o)
		{
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000564")]
		[Address(RVA = "0x684EF0", Offset = "0x6834F0", VA = "0x180684EF0")]
		protected void CalculateAffectedRegions(GraphUpdateObject o, out IntRect originalRect, out IntRect affectRect, out IntRect physicsRect, out bool willChangeWalkability, out int erosion)
		{
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000565")]
		[Address(RVA = "0x6851F0", Offset = "0x6837F0", VA = "0x1806851F0", Slot = "26")]
		private void UpdateArea(GraphUpdateObject o)
		{
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x000048A4 File Offset: 0x00002AA4
		[Token(Token = "0x6000566")]
		[Address(RVA = "0x685BC0", Offset = "0x6841C0", VA = "0x180685BC0", Slot = "31")]
		public bool Linecast(Vector3 from, Vector3 to)
		{
			return default(bool);
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x000048BC File Offset: 0x00002ABC
		[Token(Token = "0x6000567")]
		[Address(RVA = "0x685BC0", Offset = "0x6841C0", VA = "0x180685BC0", Slot = "32")]
		[Obsolete("The hint parameter is deprecated")]
		public bool Linecast(Vector3 from, Vector3 to, GraphNode hint)
		{
			return default(bool);
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x000048D4 File Offset: 0x00002AD4
		[Token(Token = "0x6000568")]
		[Address(RVA = "0x685C30", Offset = "0x684230", VA = "0x180685C30", Slot = "33")]
		[Obsolete("The hint parameter is deprecated")]
		public bool Linecast(Vector3 from, Vector3 to, GraphNode hint, out GraphHitInfo hit)
		{
			return default(bool);
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x000048EC File Offset: 0x00002AEC
		[Token(Token = "0x6000569")]
		[Address(RVA = "0x685C90", Offset = "0x684290", VA = "0x180685C90")]
		protected static long CrossMagnitude(Int2 a, Int2 b)
		{
			return 0L;
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00004904 File Offset: 0x00002B04
		[Token(Token = "0x600056A")]
		[Address(RVA = "0x685CC0", Offset = "0x6842C0", VA = "0x180685CC0")]
		protected bool ClipLineSegmentToBounds(Vector3 a, Vector3 b, out Vector3 outA, out Vector3 outB)
		{
			return default(bool);
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x0000491C File Offset: 0x00002B1C
		[Token(Token = "0x600056B")]
		[Address(RVA = "0x686400", Offset = "0x684A00", VA = "0x180686400", Slot = "34")]
		[Obsolete("The hint parameter is deprecated")]
		public bool Linecast(Vector3 from, Vector3 to, GraphNode hint, out GraphHitInfo hit, List<GraphNode> trace)
		{
			return default(bool);
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00004934 File Offset: 0x00002B34
		[Token(Token = "0x600056C")]
		[Address(RVA = "0x686460", Offset = "0x684A60", VA = "0x180686460", Slot = "35")]
		public bool Linecast(Vector3 from, Vector3 to, out GraphHitInfo hit, [Optional] List<GraphNode> trace, [Optional] Func<GraphNode, bool> filter)
		{
			return default(bool);
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x0000494C File Offset: 0x00002B4C
		[Token(Token = "0x600056D")]
		[Address(RVA = "0x686B60", Offset = "0x685160", VA = "0x180686B60")]
		[Obsolete("Use Linecast instead")]
		public bool SnappedLinecast(Vector3 from, Vector3 to, GraphNode hint, out GraphHitInfo hit)
		{
			return default(bool);
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00004964 File Offset: 0x00002B64
		[Token(Token = "0x600056E")]
		[Address(RVA = "0x686D30", Offset = "0x685330", VA = "0x180686D30")]
		public bool Linecast(GridNodeBase fromNode, GridNodeBase toNode, [Optional] Func<GraphNode, bool> filter)
		{
			return default(bool);
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x0000497C File Offset: 0x00002B7C
		[Token(Token = "0x600056F")]
		[Address(RVA = "0x686D90", Offset = "0x685390", VA = "0x180686D90")]
		public bool Linecast(Vector3 from, Vector3 to, out GridHitInfo hit, [Optional] List<GraphNode> trace, [Optional] Func<GraphNode, bool> filter)
		{
			return default(bool);
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00004994 File Offset: 0x00002B94
		[Token(Token = "0x6000570")]
		[Address(RVA = "0x687350", Offset = "0x685950", VA = "0x180687350")]
		public bool Linecast(GridNodeBase fromNode, Vector2 normalizedFromPoint, GridNodeBase toNode, Vector2 normalizedToPoint, out GridHitInfo hit, [Optional] List<GraphNode> trace, [Optional] Func<GraphNode, bool> filter, bool continuePastEnd = false)
		{
			return default(bool);
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x000049AC File Offset: 0x00002BAC
		[Token(Token = "0x6000571")]
		[Address(RVA = "0x687440", Offset = "0x685A40", VA = "0x180687440")]
		public bool Linecast(GridNodeBase fromNode, Int2 fixedNormalizedFromPoint, GridNodeBase toNode, Int2 fixedNormalizedToPoint, out GridHitInfo hit, [Optional] List<GraphNode> trace, [Optional] Func<GraphNode, bool> filter, bool continuePastEnd = false)
		{
			return default(bool);
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x000049C4 File Offset: 0x00002BC4
		[Token(Token = "0x6000572")]
		[Address(RVA = "0x688270", Offset = "0x686870", VA = "0x180688270")]
		public bool CheckConnection(GridNode node, int dir)
		{
			return default(bool);
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000573")]
		[Address(RVA = "0x688410", Offset = "0x686A10", VA = "0x180688410", Slot = "21")]
		protected override void SerializeExtraInfo(GraphSerializationContext ctx)
		{
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000574")]
		[Address(RVA = "0x6884F0", Offset = "0x686AF0", VA = "0x1806884F0", Slot = "22")]
		protected override void DeserializeExtraInfo(GraphSerializationContext ctx)
		{
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000575")]
		[Address(RVA = "0x6888C0", Offset = "0x686EC0", VA = "0x1806888C0", Slot = "24")]
		protected override void DeserializeSettingsCompatibility(GraphSerializationContext ctx)
		{
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000576")]
		[Address(RVA = "0x688D70", Offset = "0x687370", VA = "0x180688D70", Slot = "23")]
		protected override void PostDeserialization(GraphSerializationContext ctx)
		{
		}

		// Token: 0x0400037D RID: 893
		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[JsonMember]
		public InspectorGridMode inspectorGridMode;

		// Token: 0x0400037E RID: 894
		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[JsonMember]
		public InspectorGridHexagonNodeSize inspectorHexagonSizeMode;

		// Token: 0x0400037F RID: 895
		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public int width;

		// Token: 0x04000380 RID: 896
		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public int depth;

		// Token: 0x04000381 RID: 897
		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[JsonMember]
		public float aspectRatio;

		// Token: 0x04000382 RID: 898
		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[JsonMember]
		public float isometricAngle;

		// Token: 0x04000383 RID: 899
		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly float StandardIsometricAngle;

		// Token: 0x04000384 RID: 900
		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly float StandardDimetricAngle;

		// Token: 0x04000385 RID: 901
		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[JsonMember]
		public bool uniformEdgeCosts;

		// Token: 0x04000386 RID: 902
		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[JsonMember]
		public Vector3 rotation;

		// Token: 0x04000387 RID: 903
		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[JsonMember]
		public Vector3 center;

		// Token: 0x04000388 RID: 904
		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[JsonMember]
		public Vector2 unclampedSize;

		// Token: 0x04000389 RID: 905
		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[JsonMember]
		public float nodeSize;

		// Token: 0x0400038A RID: 906
		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[JsonMember]
		public GraphCollision collision;

		// Token: 0x0400038B RID: 907
		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[JsonMember]
		public float maxClimb;

		// Token: 0x0400038C RID: 908
		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[JsonMember]
		public float maxSlope;

		// Token: 0x0400038D RID: 909
		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[JsonMember]
		public int erodeIterations;

		// Token: 0x0400038E RID: 910
		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[JsonMember]
		public bool erosionUseTags;

		// Token: 0x0400038F RID: 911
		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[JsonMember]
		public int erosionFirstTag;

		// Token: 0x04000390 RID: 912
		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		[JsonMember]
		public NumNeighbours neighbours;

		// Token: 0x04000391 RID: 913
		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[JsonMember]
		public bool cutCorners;

		// Token: 0x04000392 RID: 914
		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		[JsonMember]
		public float penaltyPositionOffset;

		// Token: 0x04000393 RID: 915
		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[JsonMember]
		public bool penaltyPosition;

		// Token: 0x04000394 RID: 916
		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		[JsonMember]
		public float penaltyPositionFactor;

		// Token: 0x04000395 RID: 917
		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[JsonMember]
		public bool penaltyAngle;

		// Token: 0x04000396 RID: 918
		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		[JsonMember]
		public float penaltyAngleFactor;

		// Token: 0x04000397 RID: 919
		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[JsonMember]
		public float penaltyAnglePower;

		// Token: 0x04000398 RID: 920
		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		[JsonMember]
		public bool useJumpPointSearch;

		// Token: 0x04000399 RID: 921
		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14D")]
		[JsonMember]
		public bool showMeshOutline;

		// Token: 0x0400039A RID: 922
		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14E")]
		[JsonMember]
		public bool showNodeConnections;

		// Token: 0x0400039B RID: 923
		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14F")]
		[JsonMember]
		public bool showMeshSurface;

		// Token: 0x0400039C RID: 924
		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[JsonMember]
		public GridGraph.TextureData textureData;

		// Token: 0x0400039E RID: 926
		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		[NonSerialized]
		public readonly int[] neighbourOffsets;

		// Token: 0x0400039F RID: 927
		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[NonSerialized]
		public readonly uint[] neighbourCosts;

		// Token: 0x040003A0 RID: 928
		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[NonSerialized]
		public readonly int[] neighbourXOffsets;

		// Token: 0x040003A1 RID: 929
		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		[NonSerialized]
		public readonly int[] neighbourZOffsets;

		// Token: 0x040003A2 RID: 930
		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal static readonly int[] hexagonNeighbourIndices;

		// Token: 0x040003A3 RID: 931
		[Token(Token = "0x40003A3")]
		public const int getNearestForceOverlap = 2;

		// Token: 0x040003A4 RID: 932
		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public GridNodeBase[] nodes;

		// Token: 0x040003A6 RID: 934
		[Token(Token = "0x40003A6")]
		private const int FixedPrecisionScale = 1024;

		// Token: 0x02000093 RID: 147
		[Token(Token = "0x2000093")]
		public class TextureData
		{
			// Token: 0x06000578 RID: 1400 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000578")]
			[Address(RVA = "0x6890A0", Offset = "0x6876A0", VA = "0x1806890A0")]
			public void Initialize()
			{
			}

			// Token: 0x06000579 RID: 1401 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000579")]
			[Address(RVA = "0x689250", Offset = "0x687850", VA = "0x180689250")]
			public void Apply(GridNodeBase node, int x, int z)
			{
			}

			// Token: 0x0600057A RID: 1402 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x600057A")]
			[Address(RVA = "0x6894B0", Offset = "0x687AB0", VA = "0x1806894B0")]
			private void ApplyChannel(GridNodeBase node, int x, int z, int value, GridGraph.TextureData.ChannelUse channelUse, float factor)
			{
			}

			// Token: 0x0600057B RID: 1403 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x600057B")]
			[Address(RVA = "0x6895F0", Offset = "0x687BF0", VA = "0x1806895F0")]
			public TextureData()
			{
			}

			// Token: 0x040003A7 RID: 935
			[Token(Token = "0x40003A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			// Token: 0x040003A8 RID: 936
			[Token(Token = "0x40003A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Texture2D source;

			// Token: 0x040003A9 RID: 937
			[Token(Token = "0x40003A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float[] factors;

			// Token: 0x040003AA RID: 938
			[Token(Token = "0x40003AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GridGraph.TextureData.ChannelUse[] channels;

			// Token: 0x040003AB RID: 939
			[Token(Token = "0x40003AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Color32[] data;

			// Token: 0x02000094 RID: 148
			[Token(Token = "0x2000094")]
			public enum ChannelUse
			{
				// Token: 0x040003AD RID: 941
				[Token(Token = "0x40003AD")]
				None,
				// Token: 0x040003AE RID: 942
				[Token(Token = "0x40003AE")]
				Penalty,
				// Token: 0x040003AF RID: 943
				[Token(Token = "0x40003AF")]
				Position,
				// Token: 0x040003B0 RID: 944
				[Token(Token = "0x40003B0")]
				WalkablePenalty
			}
		}
	}
}
