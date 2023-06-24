using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Pathfinding.Serialization;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x02000072 RID: 114
	[Token(Token = "0x2000072")]
	public abstract class GraphNode
	{
		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C5")]
		public NavGraph Graph
		{
			[Token(Token = "0x6000400")]
			[Address(RVA = "0x66F1C0", Offset = "0x66D7C0", VA = "0x18066F1C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000401")]
		[Address(RVA = "0x66F1E0", Offset = "0x66D7E0", VA = "0x18066F1E0")]
		protected GraphNode(AstarPath astar)
		{
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000402")]
		[Address(RVA = "0x66F2D0", Offset = "0x66D8D0", VA = "0x18066F2D0")]
		public void Destroy()
		{
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x000040C4 File Offset: 0x000022C4
		[Token(Token = "0x170000C6")]
		public bool Destroyed
		{
			[Token(Token = "0x6000403")]
			[Address(RVA = "0x66F440", Offset = "0x66DA40", VA = "0x18066F440")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x000040DC File Offset: 0x000022DC
		// (set) Token: 0x06000405 RID: 1029 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000C7")]
		public int NodeIndex
		{
			[Token(Token = "0x6000404")]
			[Address(RVA = "0x66F460", Offset = "0x66DA60", VA = "0x18066F460")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000405")]
			[Address(RVA = "0x66F470", Offset = "0x66DA70", VA = "0x18066F470")]
			private set
			{
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x000040F4 File Offset: 0x000022F4
		// (set) Token: 0x06000407 RID: 1031 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000C8")]
		internal bool TemporaryFlag1
		{
			[Token(Token = "0x6000406")]
			[Address(RVA = "0x66F480", Offset = "0x66DA80", VA = "0x18066F480")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000407")]
			[Address(RVA = "0x66F490", Offset = "0x66DA90", VA = "0x18066F490")]
			set
			{
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x0000410C File Offset: 0x0000230C
		// (set) Token: 0x06000409 RID: 1033 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000C9")]
		internal bool TemporaryFlag2
		{
			[Token(Token = "0x6000408")]
			[Address(RVA = "0x66F4C0", Offset = "0x66DAC0", VA = "0x18066F4C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000409")]
			[Address(RVA = "0x66F4D0", Offset = "0x66DAD0", VA = "0x18066F4D0")]
			set
			{
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600040A RID: 1034 RVA: 0x00004124 File Offset: 0x00002324
		// (set) Token: 0x0600040B RID: 1035 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000CA")]
		public uint Flags
		{
			[Token(Token = "0x600040A")]
			[Address(RVA = "0x66F500", Offset = "0x66DB00", VA = "0x18066F500")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600040B")]
			[Address(RVA = "0x66F510", Offset = "0x66DB10", VA = "0x18066F510")]
			set
			{
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x0000413C File Offset: 0x0000233C
		// (set) Token: 0x0600040D RID: 1037 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000CB")]
		public uint Penalty
		{
			[Token(Token = "0x600040C")]
			[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600040D")]
			[Address(RVA = "0x66F530", Offset = "0x66DB30", VA = "0x18066F530")]
			set
			{
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x00004154 File Offset: 0x00002354
		// (set) Token: 0x0600040F RID: 1039 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000CC")]
		public bool Walkable
		{
			[Token(Token = "0x600040E")]
			[Address(RVA = "0x66F5D0", Offset = "0x66DBD0", VA = "0x18066F5D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600040F")]
			[Address(RVA = "0x66F5E0", Offset = "0x66DBE0", VA = "0x18066F5E0")]
			set
			{
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x0000416C File Offset: 0x0000236C
		// (set) Token: 0x06000411 RID: 1041 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000CD")]
		internal int HierarchicalNodeIndex
		{
			[Token(Token = "0x6000410")]
			[Address(RVA = "0x66F670", Offset = "0x66DC70", VA = "0x18066F670")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000411")]
			[Address(RVA = "0x66F680", Offset = "0x66DC80", VA = "0x18066F680")]
			set
			{
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x00004184 File Offset: 0x00002384
		// (set) Token: 0x06000413 RID: 1043 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000CE")]
		internal bool IsHierarchicalNodeDirty
		{
			[Token(Token = "0x6000412")]
			[Address(RVA = "0x66F690", Offset = "0x66DC90", VA = "0x18066F690")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000413")]
			[Address(RVA = "0x66F6A0", Offset = "0x66DCA0", VA = "0x18066F6A0")]
			set
			{
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x0000419C File Offset: 0x0000239C
		[Token(Token = "0x170000CF")]
		public uint Area
		{
			[Token(Token = "0x6000414")]
			[Address(RVA = "0x66F6D0", Offset = "0x66DCD0", VA = "0x18066F6D0")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x000041B4 File Offset: 0x000023B4
		// (set) Token: 0x06000416 RID: 1046 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000D0")]
		public uint GraphIndex
		{
			[Token(Token = "0x6000415")]
			[Address(RVA = "0x66F760", Offset = "0x66DD60", VA = "0x18066F760")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6000416")]
			[Address(RVA = "0x66F770", Offset = "0x66DD70", VA = "0x18066F770")]
			set
			{
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000417 RID: 1047 RVA: 0x000041CC File Offset: 0x000023CC
		// (set) Token: 0x06000418 RID: 1048 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000D1")]
		public uint Tag
		{
			[Token(Token = "0x6000417")]
			[Address(RVA = "0x66F780", Offset = "0x66DD80", VA = "0x18066F780")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6000418")]
			[Address(RVA = "0x66F790", Offset = "0x66DD90", VA = "0x18066F790")]
			set
			{
			}
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000419")]
		[Address(RVA = "0x66F7B0", Offset = "0x66DDB0", VA = "0x18066F7B0")]
		public void SetConnectivityDirty()
		{
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600041A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("This method is deprecated because it never did anything, you can safely remove any calls to this method")]
		public void RecalculateConnectionCosts()
		{
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600041B")]
		[Address(RVA = "0x66F830", Offset = "0x66DE30", VA = "0x18066F830", Slot = "4")]
		public virtual void UpdateRecursiveG(Path path, PathNode pathNode, PathHandler handler)
		{
		}

		// Token: 0x0600041C RID: 1052
		[Token(Token = "0x600041C")]
		public abstract void GetConnections(Action<GraphNode> action);

		// Token: 0x0600041D RID: 1053
		[Token(Token = "0x600041D")]
		public abstract void AddConnection(GraphNode node, uint cost);

		// Token: 0x0600041E RID: 1054
		[Token(Token = "0x600041E")]
		public abstract void RemoveConnection(GraphNode node);

		// Token: 0x0600041F RID: 1055
		[Token(Token = "0x600041F")]
		public abstract void ClearConnections(bool alsoReverse);

		// Token: 0x06000420 RID: 1056 RVA: 0x000041E4 File Offset: 0x000023E4
		[Token(Token = "0x6000420")]
		[Address(RVA = "0x66FA60", Offset = "0x66E060", VA = "0x18066FA60", Slot = "9")]
		public virtual bool ContainsConnection(GraphNode node)
		{
			return default(bool);
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x000041FC File Offset: 0x000023FC
		[Token(Token = "0x6000421")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "10")]
		public virtual bool GetPortal(GraphNode other, List<Vector3> left, List<Vector3> right, bool backwards)
		{
			return default(bool);
		}

		// Token: 0x06000422 RID: 1058
		[Token(Token = "0x6000422")]
		public abstract void Open(Path path, PathNode pathNode, PathHandler handler);

		// Token: 0x06000423 RID: 1059 RVA: 0x00004214 File Offset: 0x00002414
		[Token(Token = "0x6000423")]
		[Address(RVA = "0x620A90", Offset = "0x61F090", VA = "0x180620A90", Slot = "12")]
		public virtual float SurfaceArea()
		{
			return 0f;
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x0000422C File Offset: 0x0000242C
		[Token(Token = "0x6000424")]
		[Address(RVA = "0x66FB80", Offset = "0x66E180", VA = "0x18066FB80", Slot = "13")]
		public virtual Vector3 RandomPointOnSurface()
		{
			return default(Vector3);
		}

		// Token: 0x06000425 RID: 1061
		[Token(Token = "0x6000425")]
		public abstract Vector3 ClosestPointOnNode(Vector3 p);

		// Token: 0x06000426 RID: 1062 RVA: 0x00004244 File Offset: 0x00002444
		[Token(Token = "0x6000426")]
		[Address(RVA = "0x66FBF0", Offset = "0x66E1F0", VA = "0x18066FBF0", Slot = "15")]
		public virtual int GetGizmoHashCode()
		{
			return 0;
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000427")]
		[Address(RVA = "0x66FC20", Offset = "0x66E220", VA = "0x18066FC20", Slot = "16")]
		public virtual void SerializeNode(GraphSerializationContext ctx)
		{
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000428")]
		[Address(RVA = "0x66FC90", Offset = "0x66E290", VA = "0x18066FC90", Slot = "17")]
		public virtual void DeserializeNode(GraphSerializationContext ctx)
		{
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000429")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "18")]
		public virtual void SerializeReferences(GraphSerializationContext ctx)
		{
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600042A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "19")]
		public virtual void DeserializeReferences(GraphSerializationContext ctx)
		{
		}

		// Token: 0x040002CA RID: 714
		[Token(Token = "0x40002CA")]
		[FieldOffset(Offset = "0x10")]
		private int nodeIndex;

		// Token: 0x040002CB RID: 715
		[Token(Token = "0x40002CB")]
		[FieldOffset(Offset = "0x14")]
		protected uint flags;

		// Token: 0x040002CC RID: 716
		[Token(Token = "0x40002CC")]
		[FieldOffset(Offset = "0x18")]
		private uint penalty;

		// Token: 0x040002CD RID: 717
		[Token(Token = "0x40002CD")]
		private const int NodeIndexMask = 268435455;

		// Token: 0x040002CE RID: 718
		[Token(Token = "0x40002CE")]
		private const int DestroyedNodeIndex = 268435454;

		// Token: 0x040002CF RID: 719
		[Token(Token = "0x40002CF")]
		private const int TemporaryFlag1Mask = 268435456;

		// Token: 0x040002D0 RID: 720
		[Token(Token = "0x40002D0")]
		private const int TemporaryFlag2Mask = 536870912;

		// Token: 0x040002D1 RID: 721
		[Token(Token = "0x40002D1")]
		[FieldOffset(Offset = "0x1C")]
		public Int3 position;

		// Token: 0x040002D2 RID: 722
		[Token(Token = "0x40002D2")]
		private const int FlagsWalkableOffset = 0;

		// Token: 0x040002D3 RID: 723
		[Token(Token = "0x40002D3")]
		private const uint FlagsWalkableMask = 1U;

		// Token: 0x040002D4 RID: 724
		[Token(Token = "0x40002D4")]
		private const int FlagsHierarchicalIndexOffset = 1;

		// Token: 0x040002D5 RID: 725
		[Token(Token = "0x40002D5")]
		private const uint HierarchicalIndexMask = 262142U;

		// Token: 0x040002D6 RID: 726
		[Token(Token = "0x40002D6")]
		private const int HierarchicalDirtyOffset = 18;

		// Token: 0x040002D7 RID: 727
		[Token(Token = "0x40002D7")]
		private const uint HierarchicalDirtyMask = 262144U;

		// Token: 0x040002D8 RID: 728
		[Token(Token = "0x40002D8")]
		private const int FlagsGraphOffset = 24;

		// Token: 0x040002D9 RID: 729
		[Token(Token = "0x40002D9")]
		private const uint FlagsGraphMask = 4278190080U;

		// Token: 0x040002DA RID: 730
		[Token(Token = "0x40002DA")]
		public const uint MaxHierarchicalNodeIndex = 131071U;

		// Token: 0x040002DB RID: 731
		[Token(Token = "0x40002DB")]
		public const uint MaxGraphIndex = 255U;

		// Token: 0x040002DC RID: 732
		[Token(Token = "0x40002DC")]
		private const int FlagsTagOffset = 19;

		// Token: 0x040002DD RID: 733
		[Token(Token = "0x40002DD")]
		private const uint FlagsTagMask = 16252928U;
	}
}
