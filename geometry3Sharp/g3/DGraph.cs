using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000EE RID: 238
	[Token(Token = "0x20000EE")]
	public abstract class DGraph
	{
		// Token: 0x060005E5 RID: 1509 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x1FA3C30", Offset = "0x1FA2230", VA = "0x181FA3C30")]
		public DGraph()
		{
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x1FA3E70", Offset = "0x1FA2470", VA = "0x181FA3E70")]
		protected void updateTimeStamp(bool bShapeChange)
		{
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060005E7 RID: 1511 RVA: 0x00004FAC File Offset: 0x000031AC
		[Token(Token = "0x170000E5")]
		public int Timestamp
		{
			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x65D0F0", Offset = "0x65B6F0", VA = "0x18065D0F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060005E8 RID: 1512 RVA: 0x00004FC4 File Offset: 0x000031C4
		[Token(Token = "0x170000E6")]
		public int ShapeTimestamp
		{
			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x716CD0", Offset = "0x7152D0", VA = "0x180716CD0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060005E9 RID: 1513 RVA: 0x00004FDC File Offset: 0x000031DC
		[Token(Token = "0x170000E7")]
		public int VertexCount
		{
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0xF95DB0", Offset = "0xF943B0", VA = "0x180F95DB0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060005EA RID: 1514 RVA: 0x00004FF4 File Offset: 0x000031F4
		[Token(Token = "0x170000E8")]
		public int EdgeCount
		{
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0x1FA3E80", Offset = "0x1FA2480", VA = "0x181FA3E80")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x0000500C File Offset: 0x0000320C
		[Token(Token = "0x170000E9")]
		public int MaxVertexID
		{
			[Token(Token = "0x60005EB")]
			[Address(RVA = "0x1E53140", Offset = "0x1E51740", VA = "0x181E53140")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060005EC RID: 1516 RVA: 0x00005024 File Offset: 0x00003224
		[Token(Token = "0x170000EA")]
		public int MaxEdgeID
		{
			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x1FA3EA0", Offset = "0x1FA24A0", VA = "0x181FA3EA0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x0000503C File Offset: 0x0000323C
		[Token(Token = "0x170000EB")]
		public int MaxGroupID
		{
			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x6E6C40", Offset = "0x6E5240", VA = "0x1806E6C40")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x00005054 File Offset: 0x00003254
		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x1E532A0", Offset = "0x1E518A0", VA = "0x181E532A0")]
		public bool IsVertex(int vID)
		{
			return default(bool);
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x0000506C File Offset: 0x0000326C
		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x1FA3EF0", Offset = "0x1FA24F0", VA = "0x181FA3EF0")]
		public bool IsEdge(int eID)
		{
			return default(bool);
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x1FA3F10", Offset = "0x1FA2510", VA = "0x181FA3F10")]
		public ReadOnlyCollection<int> GetVtxEdges(int vID)
		{
			return null;
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00005084 File Offset: 0x00003284
		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x1FA3FA0", Offset = "0x1FA25A0", VA = "0x181FA3FA0")]
		public int GetVtxEdgeCount(int vID)
		{
			return 0;
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x0000509C File Offset: 0x0000329C
		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x1FA4030", Offset = "0x1FA2630", VA = "0x181FA4030")]
		public int GetMaxVtxEdgeCount()
		{
			return 0;
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x000050B4 File Offset: 0x000032B4
		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x1FA4340", Offset = "0x1FA2940", VA = "0x181FA4340")]
		public int GetEdgeGroup(int eid)
		{
			return 0;
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x1FA43C0", Offset = "0x1FA29C0", VA = "0x181FA43C0")]
		public void SetEdgeGroup(int eid, int group_id)
		{
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x000050CC File Offset: 0x000032CC
		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x1FA44C0", Offset = "0x1FA2AC0", VA = "0x181FA44C0")]
		public int AllocateEdgeGroup()
		{
			return 0;
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x000050E4 File Offset: 0x000032E4
		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x1FA44D0", Offset = "0x1FA2AD0", VA = "0x181FA44D0")]
		public Index2i GetEdgeV(int eID)
		{
			return default(Index2i);
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x000050FC File Offset: 0x000032FC
		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x1FA45A0", Offset = "0x1FA2BA0", VA = "0x181FA45A0")]
		public Index3i GetEdge(int eID)
		{
			return default(Index3i);
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x00005114 File Offset: 0x00003314
		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x1FA46B0", Offset = "0x1FA2CB0", VA = "0x181FA46B0")]
		protected int append_vertex_internal()
		{
			return 0;
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x0000512C File Offset: 0x0000332C
		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x1FA4770", Offset = "0x1FA2D70", VA = "0x181FA4770")]
		public int AppendEdge(int v0, int v1, int gid = -1)
		{
			return 0;
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00005144 File Offset: 0x00003344
		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x1FA48C0", Offset = "0x1FA2EC0", VA = "0x181FA48C0")]
		public int AppendEdge(Index2i ev, int gid = -1)
		{
			return 0;
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x0000515C File Offset: 0x0000335C
		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x1FA4A20", Offset = "0x1FA3020", VA = "0x181FA4A20")]
		protected int add_edge(int a, int b, int gid)
		{
			return 0;
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x1FA4C90", Offset = "0x1FA3290", VA = "0x181FA4C90")]
		public IEnumerable<int> VertexIndices()
		{
			return null;
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x1FA4D30", Offset = "0x1FA3330", VA = "0x181FA4D30")]
		public IEnumerable<int> EdgeIndices()
		{
			return null;
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x1FA4DD0", Offset = "0x1FA33D0", VA = "0x181FA4DD0")]
		public IEnumerable<Index3i> Edges()
		{
			return null;
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x1FA4E70", Offset = "0x1FA3470", VA = "0x181FA4E70")]
		public IEnumerable<int> VtxVerticesItr(int vID)
		{
			return null;
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000600")]
		[Address(RVA = "0x1FA4F30", Offset = "0x1FA3530", VA = "0x181FA4F30")]
		public IEnumerable<int> VtxEdgesItr(int vID)
		{
			return null;
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x00005174 File Offset: 0x00003374
		[Token(Token = "0x6000601")]
		[Address(RVA = "0x1FA4FF0", Offset = "0x1FA35F0", VA = "0x181FA4FF0")]
		public int FindEdge(int vA, int vB)
		{
			return 0;
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x0000518C File Offset: 0x0000338C
		[Token(Token = "0x6000602")]
		[Address(RVA = "0x1FA5150", Offset = "0x1FA3750", VA = "0x181FA5150")]
		public MeshResult RemoveEdge(int eID, bool bRemoveIsolatedVertices)
		{
			return MeshResult.Ok;
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x000051A4 File Offset: 0x000033A4
		[Token(Token = "0x6000603")]
		[Address(RVA = "0x1FA5320", Offset = "0x1FA3920", VA = "0x181FA5320")]
		public MeshResult RemoveVertex(int vid, bool bRemoveIsolatedVertices)
		{
			return MeshResult.Ok;
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x000051BC File Offset: 0x000033BC
		[Token(Token = "0x6000604")]
		[Address(RVA = "0x1FA5550", Offset = "0x1FA3B50", VA = "0x181FA5550")]
		public MeshResult SplitEdge(int vA, int vB, out DGraph.EdgeSplitInfo split)
		{
			return MeshResult.Ok;
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x000051D4 File Offset: 0x000033D4
		[Token(Token = "0x6000605")]
		[Address(RVA = "0x1FA55A0", Offset = "0x1FA3BA0", VA = "0x181FA55A0")]
		public MeshResult SplitEdge(int eab, out DGraph.EdgeSplitInfo split)
		{
			return MeshResult.Ok;
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x000051EC File Offset: 0x000033EC
		[Token(Token = "0x6000606")]
		[Address(RVA = "0x1FA57B0", Offset = "0x1FA3DB0", VA = "0x181FA57B0", Slot = "4")]
		protected virtual int append_new_split_vertex(int a, int b)
		{
			return 0;
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00005204 File Offset: 0x00003404
		[Token(Token = "0x6000607")]
		[Address(RVA = "0x1FA5800", Offset = "0x1FA3E00", VA = "0x181FA5800")]
		public MeshResult CollapseEdge(int vKeep, int vRemove, out DGraph.EdgeCollapseInfo collapse)
		{
			return MeshResult.Ok;
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x0000521C File Offset: 0x0000341C
		[Token(Token = "0x6000608")]
		[Address(RVA = "0x1FA5DF0", Offset = "0x1FA43F0", VA = "0x181FA5DF0")]
		protected bool edge_has_v(int eid, int vid)
		{
			return default(bool);
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00005234 File Offset: 0x00003434
		[Token(Token = "0x6000609")]
		[Address(RVA = "0x1FA5EC0", Offset = "0x1FA44C0", VA = "0x181FA5EC0")]
		protected int edge_other_v(int eID, int vID)
		{
			return 0;
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x0000524C File Offset: 0x0000344C
		[Token(Token = "0x600060A")]
		[Address(RVA = "0x1FA5FE0", Offset = "0x1FA45E0", VA = "0x181FA5FE0")]
		protected int replace_edge_vertex(int eID, int vOld, int vNew)
		{
			return 0;
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600060B RID: 1547 RVA: 0x00005264 File Offset: 0x00003464
		[Token(Token = "0x170000EC")]
		public bool IsCompact
		{
			[Token(Token = "0x600060B")]
			[Address(RVA = "0x1FA6290", Offset = "0x1FA4890", VA = "0x181FA6290")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600060C RID: 1548 RVA: 0x0000527C File Offset: 0x0000347C
		[Token(Token = "0x170000ED")]
		public bool IsCompactV
		{
			[Token(Token = "0x600060C")]
			[Address(RVA = "0x1E62A50", Offset = "0x1E61050", VA = "0x181E62A50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00005294 File Offset: 0x00003494
		[Token(Token = "0x600060D")]
		[Address(RVA = "0x1FA6340", Offset = "0x1FA4940", VA = "0x181FA6340")]
		public bool IsBoundaryVertex(int vID)
		{
			return default(bool);
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x000052AC File Offset: 0x000034AC
		[Token(Token = "0x600060E")]
		[Address(RVA = "0x1FA63D0", Offset = "0x1FA49D0", VA = "0x181FA63D0")]
		public bool IsJunctionVertex(int vID)
		{
			return default(bool);
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x000052C4 File Offset: 0x000034C4
		[Token(Token = "0x600060F")]
		[Address(RVA = "0x1FA6460", Offset = "0x1FA4A60", VA = "0x181FA6460")]
		public bool IsRegularVertex(int vID)
		{
			return default(bool);
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x000052DC File Offset: 0x000034DC
		[Token(Token = "0x6000610")]
		[Address(RVA = "0x1FA64F0", Offset = "0x1FA4AF0", VA = "0x181FA64F0", Slot = "5")]
		public virtual bool CheckValidity(DGraph.FailMode eFailMode = DGraph.FailMode.Throw)
		{
			return default(bool);
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000611")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "6")]
		protected virtual void subclass_validity_checks(Action<bool> CheckOrFailF)
		{
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000612")]
		[Address(RVA = "0x1FA7300", Offset = "0x1FA5900", VA = "0x181FA7300")]
		[Conditional("DEBUG")]
		public void debug_check_is_vertex(int v)
		{
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000613")]
		[Address(RVA = "0x1FA7380", Offset = "0x1FA5980", VA = "0x181FA7380")]
		[Conditional("DEBUG")]
		public void debug_check_is_edge(int e)
		{
		}

		// Token: 0x04000384 RID: 900
		[Token(Token = "0x4000384")]
		public const int InvalidID = -1;

		// Token: 0x04000385 RID: 901
		[Token(Token = "0x4000385")]
		public const int DuplicateEdgeID = -2;

		// Token: 0x04000386 RID: 902
		[Token(Token = "0x4000386")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Index2i InvalidEdgeV;

		// Token: 0x04000387 RID: 903
		[Token(Token = "0x4000387")]
		[FieldOffset(Offset = "0x8")]
		public static readonly Index3i InvalidEdge3;

		// Token: 0x04000388 RID: 904
		[Token(Token = "0x4000388")]
		[FieldOffset(Offset = "0x10")]
		protected RefCountVector vertices_refcount;

		// Token: 0x04000389 RID: 905
		[Token(Token = "0x4000389")]
		[FieldOffset(Offset = "0x18")]
		protected DVector<List<int>> vertex_edges;

		// Token: 0x0400038A RID: 906
		[Token(Token = "0x400038A")]
		[FieldOffset(Offset = "0x20")]
		protected RefCountVector edges_refcount;

		// Token: 0x0400038B RID: 907
		[Token(Token = "0x400038B")]
		[FieldOffset(Offset = "0x28")]
		protected DVector<int> edges;

		// Token: 0x0400038C RID: 908
		[Token(Token = "0x400038C")]
		[FieldOffset(Offset = "0x30")]
		protected int timestamp;

		// Token: 0x0400038D RID: 909
		[Token(Token = "0x400038D")]
		[FieldOffset(Offset = "0x34")]
		protected int shape_timestamp;

		// Token: 0x0400038E RID: 910
		[Token(Token = "0x400038E")]
		[FieldOffset(Offset = "0x38")]
		protected int max_group_id;

		// Token: 0x020000EF RID: 239
		[Token(Token = "0x20000EF")]
		public struct EdgeSplitInfo
		{
			// Token: 0x0400038F RID: 911
			[Token(Token = "0x400038F")]
			[FieldOffset(Offset = "0x0")]
			public int vNew;

			// Token: 0x04000390 RID: 912
			[Token(Token = "0x4000390")]
			[FieldOffset(Offset = "0x4")]
			public int eNewBN;
		}

		// Token: 0x020000F0 RID: 240
		[Token(Token = "0x20000F0")]
		public struct EdgeCollapseInfo
		{
			// Token: 0x04000391 RID: 913
			[Token(Token = "0x4000391")]
			[FieldOffset(Offset = "0x0")]
			public int vKept;

			// Token: 0x04000392 RID: 914
			[Token(Token = "0x4000392")]
			[FieldOffset(Offset = "0x4")]
			public int vRemoved;

			// Token: 0x04000393 RID: 915
			[Token(Token = "0x4000393")]
			[FieldOffset(Offset = "0x8")]
			public int eCollapsed;
		}

		// Token: 0x020000F1 RID: 241
		[Token(Token = "0x20000F1")]
		public enum FailMode
		{
			// Token: 0x04000395 RID: 917
			[Token(Token = "0x4000395")]
			DebugAssert,
			// Token: 0x04000396 RID: 918
			[Token(Token = "0x4000396")]
			gDevAssert,
			// Token: 0x04000397 RID: 919
			[Token(Token = "0x4000397")]
			Throw,
			// Token: 0x04000398 RID: 920
			[Token(Token = "0x4000398")]
			ReturnOnly
		}
	}
}
