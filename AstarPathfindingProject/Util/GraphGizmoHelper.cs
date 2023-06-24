using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.Util
{
	// Token: 0x02000149 RID: 329
	[Token(Token = "0x2000149")]
	public class GraphGizmoHelper : IAstarPooledObject, IDisposable
	{
		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000A37 RID: 2615 RVA: 0x00006764 File Offset: 0x00004964
		// (set) Token: 0x06000A38 RID: 2616 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000156")]
		public RetainedGizmos.Hasher hasher
		{
			[Token(Token = "0x6000A37")]
			[Address(RVA = "0x718F50", Offset = "0x717550", VA = "0x180718F50")]
			[CompilerGenerated]
			get
			{
				return default(RetainedGizmos.Hasher);
			}
			[Token(Token = "0x6000A38")]
			[Address(RVA = "0x718F70", Offset = "0x717570", VA = "0x180718F70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000A39 RID: 2617 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000A3A RID: 2618 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000157")]
		public RetainedGizmos.Builder builder
		{
			[Token(Token = "0x6000A39")]
			[Address(RVA = "0x661070", Offset = "0x65F670", VA = "0x180661070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A3A")]
			[Address(RVA = "0x661080", Offset = "0x65F680", VA = "0x180661080")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0x718FE0", Offset = "0x7175E0", VA = "0x180718FE0")]
		public GraphGizmoHelper()
		{
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x719090", Offset = "0x717690", VA = "0x180719090")]
		public void Init(AstarPath active, RetainedGizmos.Hasher hasher, RetainedGizmos gizmos)
		{
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x719330", Offset = "0x717930", VA = "0x180719330", Slot = "4")]
		public void OnEnterPool()
		{
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x719430", Offset = "0x717A30", VA = "0x180719430")]
		public void DrawConnections(GraphNode node)
		{
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0x7196E0", Offset = "0x717CE0", VA = "0x1807196E0")]
		private void DrawConnection(GraphNode other)
		{
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x0000677C File Offset: 0x0000497C
		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x719810", Offset = "0x717E10", VA = "0x180719810")]
		public Color NodeColor(GraphNode node)
		{
			return default(Color);
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x00006794 File Offset: 0x00004994
		[Token(Token = "0x6000A41")]
		[Address(RVA = "0x719D50", Offset = "0x718350", VA = "0x180719D50")]
		public static bool InSearchTree(GraphNode node, PathHandler handler, ushort pathID)
		{
			return default(bool);
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A42")]
		[Address(RVA = "0x719DA0", Offset = "0x7183A0", VA = "0x180719DA0")]
		public void DrawWireTriangle(Vector3 a, Vector3 b, Vector3 c, Color color)
		{
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A43")]
		[Address(RVA = "0x719EE0", Offset = "0x7184E0", VA = "0x180719EE0")]
		public void DrawTriangles(Vector3[] vertices, Color[] colors, int numTriangles)
		{
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A44")]
		[Address(RVA = "0x71A050", Offset = "0x718650", VA = "0x18071A050")]
		public void DrawWireTriangles(Vector3[] vertices, Color[] colors, int numTriangles)
		{
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A45")]
		[Address(RVA = "0x71A250", Offset = "0x718850", VA = "0x18071A250")]
		public void Submit()
		{
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A46")]
		[Address(RVA = "0x71A2B0", Offset = "0x7188B0", VA = "0x18071A2B0", Slot = "5")]
		private void Dispose()
		{
		}

		// Token: 0x04000701 RID: 1793
		[Token(Token = "0x4000701")]
		[FieldOffset(Offset = "0x28")]
		private RetainedGizmos gizmos;

		// Token: 0x04000702 RID: 1794
		[Token(Token = "0x4000702")]
		[FieldOffset(Offset = "0x30")]
		private PathHandler debugData;

		// Token: 0x04000703 RID: 1795
		[Token(Token = "0x4000703")]
		[FieldOffset(Offset = "0x38")]
		private ushort debugPathID;

		// Token: 0x04000704 RID: 1796
		[Token(Token = "0x4000704")]
		[FieldOffset(Offset = "0x3C")]
		private GraphDebugMode debugMode;

		// Token: 0x04000705 RID: 1797
		[Token(Token = "0x4000705")]
		[FieldOffset(Offset = "0x40")]
		private bool showSearchTree;

		// Token: 0x04000706 RID: 1798
		[Token(Token = "0x4000706")]
		[FieldOffset(Offset = "0x44")]
		private float debugFloor;

		// Token: 0x04000707 RID: 1799
		[Token(Token = "0x4000707")]
		[FieldOffset(Offset = "0x48")]
		private float debugRoof;

		// Token: 0x04000709 RID: 1801
		[Token(Token = "0x4000709")]
		[FieldOffset(Offset = "0x58")]
		private Vector3 drawConnectionStart;

		// Token: 0x0400070A RID: 1802
		[Token(Token = "0x400070A")]
		[FieldOffset(Offset = "0x64")]
		private Color drawConnectionColor;

		// Token: 0x0400070B RID: 1803
		[Token(Token = "0x400070B")]
		[FieldOffset(Offset = "0x78")]
		private readonly Action<GraphNode> drawConnection;
	}
}
