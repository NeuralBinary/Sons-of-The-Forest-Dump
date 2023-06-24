using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x02000078 RID: 120
	[Token(Token = "0x2000078")]
	public abstract class Path : IPathInternals
	{
		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000444 RID: 1092 RVA: 0x000042D4 File Offset: 0x000024D4
		// (set) Token: 0x06000445 RID: 1093 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000D2")]
		public PathState PipelineState
		{
			[Token(Token = "0x6000444")]
			[Address(RVA = "0x632000", Offset = "0x630600", VA = "0x180632000")]
			[CompilerGenerated]
			get
			{
				return PathState.Created;
			}
			[Token(Token = "0x6000445")]
			[Address(RVA = "0x670F30", Offset = "0x66F530", VA = "0x180670F30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x000042EC File Offset: 0x000024EC
		// (set) Token: 0x06000447 RID: 1095 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000D3")]
		public PathCompleteState CompleteState
		{
			[Token(Token = "0x6000446")]
			[Address(RVA = "0x670F40", Offset = "0x66F540", VA = "0x180670F40")]
			get
			{
				return PathCompleteState.NotCalculated;
			}
			[Token(Token = "0x6000447")]
			[Address(RVA = "0x670F50", Offset = "0x66F550", VA = "0x180670F50")]
			protected set
			{
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000448 RID: 1096 RVA: 0x00004304 File Offset: 0x00002504
		[Token(Token = "0x170000D4")]
		public bool error
		{
			[Token(Token = "0x6000448")]
			[Address(RVA = "0x6710B0", Offset = "0x66F6B0", VA = "0x1806710B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600044A RID: 1098 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000D5")]
		public string errorLog
		{
			[Token(Token = "0x6000449")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600044A")]
			[Address(RVA = "0x6710D0", Offset = "0x66F6D0", VA = "0x1806710D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x0000431C File Offset: 0x0000251C
		// (set) Token: 0x0600044C RID: 1100 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000D6")]
		public int searchedNodes
		{
			[Token(Token = "0x600044B")]
			[Address(RVA = "0x671130", Offset = "0x66F730", VA = "0x180671130")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600044C")]
			[Address(RVA = "0x671140", Offset = "0x66F740", VA = "0x180671140")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x00004334 File Offset: 0x00002534
		// (set) Token: 0x0600044E RID: 1102 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000D7")]
		private bool Pooled
		{
			[Token(Token = "0x600044D")]
			[Address(RVA = "0x671150", Offset = "0x66F750", VA = "0x180671150", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600044E")]
			[Address(RVA = "0x671160", Offset = "0x66F760", VA = "0x180671160", Slot = "6")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x0000434C File Offset: 0x0000254C
		[Token(Token = "0x170000D8")]
		[Obsolete("Has been renamed to 'Pooled' to use more widely underestood terminology", true)]
		internal bool recycled
		{
			[Token(Token = "0x600044F")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000450 RID: 1104 RVA: 0x00004364 File Offset: 0x00002564
		// (set) Token: 0x06000451 RID: 1105 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000D9")]
		public ushort pathID
		{
			[Token(Token = "0x6000450")]
			[Address(RVA = "0x671170", Offset = "0x66F770", VA = "0x180671170")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000451")]
			[Address(RVA = "0x671180", Offset = "0x66F780", VA = "0x180671180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000452 RID: 1106 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000453 RID: 1107 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000DA")]
		public int[] tagPenalties
		{
			[Token(Token = "0x6000452")]
			[Address(RVA = "0x671190", Offset = "0x66F790", VA = "0x180671190")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000453")]
			[Address(RVA = "0x6711A0", Offset = "0x66F7A0", VA = "0x1806711A0")]
			set
			{
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x0000437C File Offset: 0x0000257C
		[Token(Token = "0x170000DB")]
		public virtual bool FloodingPath
		{
			[Token(Token = "0x6000454")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00004394 File Offset: 0x00002594
		[Token(Token = "0x6000455")]
		[Address(RVA = "0x671390", Offset = "0x66F990", VA = "0x180671390")]
		public float GetTotalLength()
		{
			return 0f;
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000456")]
		[Address(RVA = "0x671580", Offset = "0x66FB80", VA = "0x180671580")]
		public IEnumerator WaitForPath()
		{
			return null;
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000457")]
		[Address(RVA = "0x671610", Offset = "0x66FC10", VA = "0x180671610")]
		public void BlockUntilCalculated()
		{
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x000043AC File Offset: 0x000025AC
		[Token(Token = "0x6000458")]
		[Address(RVA = "0x671660", Offset = "0x66FC60", VA = "0x180671660")]
		internal uint CalculateHScore(GraphNode node)
		{
			return 0U;
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x000043C4 File Offset: 0x000025C4
		[Token(Token = "0x6000459")]
		[Address(RVA = "0x6719A0", Offset = "0x66FFA0", VA = "0x1806719A0")]
		public uint GetTagPenalty(int tag)
		{
			return 0U;
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x000043DC File Offset: 0x000025DC
		[Token(Token = "0x600045A")]
		[Address(RVA = "0x6719D0", Offset = "0x66FFD0", VA = "0x1806719D0")]
		protected Int3 GetHTarget()
		{
			return default(Int3);
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x000043F4 File Offset: 0x000025F4
		[Token(Token = "0x600045B")]
		[Address(RVA = "0x6719F0", Offset = "0x66FFF0", VA = "0x1806719F0")]
		public bool CanTraverse(GraphNode node)
		{
			return default(bool);
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0000440C File Offset: 0x0000260C
		[Token(Token = "0x600045C")]
		[Address(RVA = "0x671B00", Offset = "0x670100", VA = "0x180671B00")]
		public uint GetTraversalCost(GraphNode node)
		{
			return 0U;
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00004424 File Offset: 0x00002624
		[Token(Token = "0x600045D")]
		[Address(RVA = "0x671C20", Offset = "0x670220", VA = "0x180671C20", Slot = "18")]
		public virtual uint GetConnectionSpecialCost(GraphNode a, GraphNode b, uint currentCost)
		{
			return 0U;
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0000443C File Offset: 0x0000263C
		[Token(Token = "0x600045E")]
		[Address(RVA = "0x671C30", Offset = "0x670230", VA = "0x180671C30")]
		public bool IsDone()
		{
			return default(bool);
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600045F")]
		[Address(RVA = "0x671C40", Offset = "0x670240", VA = "0x180671C40", Slot = "7")]
		private void AdvanceState(PathState s)
		{
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00004454 File Offset: 0x00002654
		[Token(Token = "0x6000460")]
		[Address(RVA = "0x632000", Offset = "0x630600", VA = "0x180632000")]
		[Obsolete("Use the 'PipelineState' property instead")]
		public PathState GetState()
		{
			return PathState.Created;
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000461")]
		[Address(RVA = "0x671DE0", Offset = "0x6703E0", VA = "0x180671DE0")]
		public void FailWithError(string msg)
		{
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000462")]
		[Address(RVA = "0x671F50", Offset = "0x670550", VA = "0x180671F50")]
		[Obsolete("Use FailWithError instead")]
		protected void LogError(string msg)
		{
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000463")]
		[Address(RVA = "0x671F50", Offset = "0x670550", VA = "0x180671F50")]
		[Obsolete("Use FailWithError instead")]
		protected void Log(string msg)
		{
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000464")]
		[Address(RVA = "0x671FB0", Offset = "0x6705B0", VA = "0x180671FB0")]
		public void Error()
		{
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000465")]
		[Address(RVA = "0x671FC0", Offset = "0x6705C0", VA = "0x180671FC0")]
		private void ErrorCheck()
		{
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000466")]
		[Address(RVA = "0x6720A0", Offset = "0x6706A0", VA = "0x1806720A0", Slot = "19")]
		protected virtual void OnEnterPool()
		{
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000467")]
		[Address(RVA = "0x6722A0", Offset = "0x6708A0", VA = "0x1806722A0", Slot = "20")]
		protected virtual void Reset()
		{
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000468")]
		[Address(RVA = "0x672940", Offset = "0x670F40", VA = "0x180672940")]
		public void Claim(object o)
		{
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000469")]
		[Address(RVA = "0x672AE0", Offset = "0x6710E0", VA = "0x180672AE0")]
		[Obsolete("Use Release(o, true) instead")]
		internal void ReleaseSilent(object o)
		{
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600046A")]
		[Address(RVA = "0x672AF0", Offset = "0x6710F0", VA = "0x180672AF0")]
		public void Release(object o, bool silent = false)
		{
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600046B")]
		[Address(RVA = "0x672DA0", Offset = "0x6713A0", VA = "0x180672DA0", Slot = "21")]
		protected virtual void Trace(PathNode from)
		{
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600046C")]
		[Address(RVA = "0x6731A0", Offset = "0x6717A0", VA = "0x1806731A0")]
		protected void DebugStringPrefix(PathLog logMode, StringBuilder text)
		{
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600046D")]
		[Address(RVA = "0x6733A0", Offset = "0x6719A0", VA = "0x1806733A0")]
		protected void DebugStringSuffix(PathLog logMode, StringBuilder text)
		{
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600046E")]
		[Address(RVA = "0x6736D0", Offset = "0x671CD0", VA = "0x1806736D0", Slot = "22")]
		protected virtual string DebugString(PathLog logMode)
		{
			return null;
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600046F")]
		[Address(RVA = "0x673790", Offset = "0x671D90", VA = "0x180673790", Slot = "23")]
		protected virtual void ReturnPath()
		{
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000470")]
		[Address(RVA = "0x6737B0", Offset = "0x671DB0", VA = "0x1806737B0")]
		protected void PrepareBase(PathHandler pathHandler)
		{
		}

		// Token: 0x06000471 RID: 1137
		[Token(Token = "0x6000471")]
		protected abstract void Prepare();

		// Token: 0x06000472 RID: 1138 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000472")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "25")]
		protected virtual void Cleanup()
		{
		}

		// Token: 0x06000473 RID: 1139
		[Token(Token = "0x6000473")]
		protected abstract void Initialize();

		// Token: 0x06000474 RID: 1140
		[Token(Token = "0x6000474")]
		protected abstract void CalculateStep(long targetTick);

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000DC")]
		private PathHandler PathHandler
		{
			[Token(Token = "0x6000475")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000476")]
		[Address(RVA = "0x660460", Offset = "0x65EA60", VA = "0x180660460", Slot = "8")]
		private void OnEnterPool()
		{
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000477")]
		[Address(RVA = "0x673AB0", Offset = "0x6720B0", VA = "0x180673AB0", Slot = "9")]
		private void Reset()
		{
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000478")]
		[Address(RVA = "0x673AD0", Offset = "0x6720D0", VA = "0x180673AD0", Slot = "10")]
		private void ReturnPath()
		{
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000479")]
		[Address(RVA = "0x673AF0", Offset = "0x6720F0", VA = "0x180673AF0", Slot = "11")]
		private void PrepareBase(PathHandler handler)
		{
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600047A")]
		[Address(RVA = "0x673B00", Offset = "0x672100", VA = "0x180673B00", Slot = "12")]
		private void Prepare()
		{
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600047B")]
		[Address(RVA = "0x673B20", Offset = "0x672120", VA = "0x180673B20", Slot = "14")]
		private void Cleanup()
		{
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600047C")]
		[Address(RVA = "0x673B40", Offset = "0x672140", VA = "0x180673B40", Slot = "13")]
		private void Initialize()
		{
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600047D")]
		[Address(RVA = "0x673B60", Offset = "0x672160", VA = "0x180673B60", Slot = "15")]
		private void CalculateStep(long targetTick)
		{
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600047E")]
		[Address(RVA = "0x673B80", Offset = "0x672180", VA = "0x180673B80", Slot = "16")]
		private string DebugString(PathLog logMode)
		{
			return null;
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600047F")]
		[Address(RVA = "0x673BA0", Offset = "0x6721A0", VA = "0x180673BA0")]
		protected Path()
		{
		}

		// Token: 0x040002E4 RID: 740
		[Token(Token = "0x40002E4")]
		[FieldOffset(Offset = "0x10")]
		protected PathHandler pathHandler;

		// Token: 0x040002E5 RID: 741
		[Token(Token = "0x40002E5")]
		[FieldOffset(Offset = "0x18")]
		public OnPathDelegate callback;

		// Token: 0x040002E6 RID: 742
		[Token(Token = "0x40002E6")]
		[FieldOffset(Offset = "0x20")]
		public OnPathDelegate immediateCallback;

		// Token: 0x040002E8 RID: 744
		[Token(Token = "0x40002E8")]
		[FieldOffset(Offset = "0x30")]
		private object stateLock;

		// Token: 0x040002E9 RID: 745
		[Token(Token = "0x40002E9")]
		[FieldOffset(Offset = "0x38")]
		public ITraversalProvider traversalProvider;

		// Token: 0x040002EA RID: 746
		[Token(Token = "0x40002EA")]
		[FieldOffset(Offset = "0x40")]
		protected PathCompleteState completeState;

		// Token: 0x040002EC RID: 748
		[Token(Token = "0x40002EC")]
		[FieldOffset(Offset = "0x50")]
		public List<GraphNode> path;

		// Token: 0x040002ED RID: 749
		[Token(Token = "0x40002ED")]
		[FieldOffset(Offset = "0x58")]
		public List<Vector3> vectorPath;

		// Token: 0x040002EE RID: 750
		[Token(Token = "0x40002EE")]
		[FieldOffset(Offset = "0x60")]
		protected PathNode currentR;

		// Token: 0x040002EF RID: 751
		[Token(Token = "0x40002EF")]
		[FieldOffset(Offset = "0x68")]
		public float duration;

		// Token: 0x040002F2 RID: 754
		[Token(Token = "0x40002F2")]
		[FieldOffset(Offset = "0x71")]
		protected bool hasBeenReset;

		// Token: 0x040002F3 RID: 755
		[Token(Token = "0x40002F3")]
		[FieldOffset(Offset = "0x78")]
		public NNConstraint nnConstraint;

		// Token: 0x040002F4 RID: 756
		[Token(Token = "0x40002F4")]
		[FieldOffset(Offset = "0x80")]
		internal Path next;

		// Token: 0x040002F5 RID: 757
		[Token(Token = "0x40002F5")]
		[FieldOffset(Offset = "0x88")]
		public Heuristic heuristic;

		// Token: 0x040002F6 RID: 758
		[Token(Token = "0x40002F6")]
		[FieldOffset(Offset = "0x8C")]
		public float heuristicScale;

		// Token: 0x040002F8 RID: 760
		[Token(Token = "0x40002F8")]
		[FieldOffset(Offset = "0x98")]
		protected GraphNode hTargetNode;

		// Token: 0x040002F9 RID: 761
		[Token(Token = "0x40002F9")]
		[FieldOffset(Offset = "0xA0")]
		protected Int3 hTarget;

		// Token: 0x040002FA RID: 762
		[Token(Token = "0x40002FA")]
		[FieldOffset(Offset = "0xAC")]
		public int enabledTags;

		// Token: 0x040002FB RID: 763
		[Token(Token = "0x40002FB")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[] ZeroTagPenalties;

		// Token: 0x040002FC RID: 764
		[Token(Token = "0x40002FC")]
		[FieldOffset(Offset = "0xB0")]
		protected int[] internalTagPenalties;

		// Token: 0x040002FD RID: 765
		[Token(Token = "0x40002FD")]
		[FieldOffset(Offset = "0xB8")]
		protected int[] manualTagPenalties;

		// Token: 0x040002FE RID: 766
		[Token(Token = "0x40002FE")]
		[FieldOffset(Offset = "0xC0")]
		private List<object> claimed;

		// Token: 0x040002FF RID: 767
		[Token(Token = "0x40002FF")]
		[FieldOffset(Offset = "0xC8")]
		private bool releasedNotSilent;
	}
}
