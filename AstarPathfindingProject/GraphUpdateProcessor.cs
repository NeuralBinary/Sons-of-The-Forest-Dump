using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Il2CppDummyDll;
using UnityEngine.Profiling;

namespace Pathfinding
{
	// Token: 0x02000058 RID: 88
	[Token(Token = "0x2000058")]
	internal class GraphUpdateProcessor
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600031C RID: 796 RVA: 0x00002082 File Offset: 0x00000282
		// (remove) Token: 0x0600031D RID: 797 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x14000001")]
		public event Action OnGraphsUpdated
		{
			[Token(Token = "0x600031C")]
			[Address(RVA = "0x659790", Offset = "0x657D90", VA = "0x180659790")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600031D")]
			[Address(RVA = "0x659880", Offset = "0x657E80", VA = "0x180659880")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600031E RID: 798 RVA: 0x00003A1C File Offset: 0x00001C1C
		[Token(Token = "0x170000A1")]
		public bool IsAnyGraphUpdateQueued
		{
			[Token(Token = "0x600031E")]
			[Address(RVA = "0x659970", Offset = "0x657F70", VA = "0x180659970")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600031F RID: 799 RVA: 0x00003A34 File Offset: 0x00001C34
		[Token(Token = "0x170000A2")]
		public bool IsAnyGraphUpdateInProgress
		{
			[Token(Token = "0x600031F")]
			[Address(RVA = "0x6599C0", Offset = "0x657FC0", VA = "0x1806599C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x6599D0", Offset = "0x657FD0", VA = "0x1806599D0")]
		public GraphUpdateProcessor(AstarPath astar)
		{
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00003A4C File Offset: 0x00001C4C
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x659DC0", Offset = "0x6583C0", VA = "0x180659DC0")]
		public AstarWorkItem GetWorkItem()
		{
			return default(AstarWorkItem);
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000322")]
		[Address(RVA = "0x659EA0", Offset = "0x6584A0", VA = "0x180659EA0")]
		public void EnableMultithreading()
		{
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000323")]
		[Address(RVA = "0x65A180", Offset = "0x658780", VA = "0x18065A180")]
		public void DisableMultithreading()
		{
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000324")]
		[Address(RVA = "0x65A2D0", Offset = "0x6588D0", VA = "0x18065A2D0")]
		public void AddToQueue(GraphUpdateObject ob)
		{
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000325")]
		[Address(RVA = "0x65A330", Offset = "0x658930", VA = "0x18065A330")]
		private void QueueGraphUpdatesInternal()
		{
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00003A64 File Offset: 0x00001C64
		[Token(Token = "0x6000326")]
		[Address(RVA = "0x65A7B0", Offset = "0x658DB0", VA = "0x18065A7B0")]
		private bool ProcessGraphUpdates(bool force)
		{
			return default(bool);
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00003A7C File Offset: 0x00001C7C
		[Token(Token = "0x6000327")]
		[Address(RVA = "0x65A890", Offset = "0x658E90", VA = "0x18065A890")]
		private bool ProcessRegularUpdates(bool force)
		{
			return default(bool);
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00003A94 File Offset: 0x00001C94
		[Token(Token = "0x6000328")]
		[Address(RVA = "0x65AC70", Offset = "0x659270", VA = "0x18065AC70")]
		private bool StartAsyncUpdatesIfQueued()
		{
			return default(bool);
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000329")]
		[Address(RVA = "0x65ACE0", Offset = "0x6592E0", VA = "0x18065ACE0")]
		private void ProcessPostUpdates()
		{
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600032A")]
		[Address(RVA = "0x65AE90", Offset = "0x659490", VA = "0x18065AE90")]
		private void ProcessGraphUpdatesAsync()
		{
		}

		// Token: 0x0400023D RID: 573
		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x18")]
		private readonly AstarPath astar;

		// Token: 0x0400023E RID: 574
		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0x20")]
		private Thread graphUpdateThread;

		// Token: 0x0400023F RID: 575
		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0x28")]
		private bool anyGraphUpdateInProgress;

		// Token: 0x04000240 RID: 576
		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x30")]
		private CustomSampler asyncUpdateProfilingSampler;

		// Token: 0x04000241 RID: 577
		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x38")]
		private readonly Queue<GraphUpdateObject> graphUpdateQueue;

		// Token: 0x04000242 RID: 578
		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0x40")]
		private readonly Queue<GraphUpdateProcessor.GUOSingle> graphUpdateQueueAsync;

		// Token: 0x04000243 RID: 579
		[Token(Token = "0x4000243")]
		[FieldOffset(Offset = "0x48")]
		private readonly Queue<GraphUpdateProcessor.GUOSingle> graphUpdateQueuePost;

		// Token: 0x04000244 RID: 580
		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0x50")]
		private readonly Queue<GraphUpdateProcessor.GUOSingle> graphUpdateQueueRegular;

		// Token: 0x04000245 RID: 581
		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0x58")]
		private readonly ManualResetEvent asyncGraphUpdatesComplete;

		// Token: 0x04000246 RID: 582
		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0x60")]
		private readonly AutoResetEvent graphUpdateAsyncEvent;

		// Token: 0x04000247 RID: 583
		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0x68")]
		private readonly AutoResetEvent exitAsyncThread;

		// Token: 0x02000059 RID: 89
		[Token(Token = "0x2000059")]
		private enum GraphUpdateOrder
		{
			// Token: 0x04000249 RID: 585
			[Token(Token = "0x4000249")]
			GraphUpdate
		}

		// Token: 0x0200005A RID: 90
		[Token(Token = "0x200005A")]
		private struct GUOSingle
		{
			// Token: 0x0400024A RID: 586
			[Token(Token = "0x400024A")]
			[FieldOffset(Offset = "0x0")]
			public GraphUpdateProcessor.GraphUpdateOrder order;

			// Token: 0x0400024B RID: 587
			[Token(Token = "0x400024B")]
			[FieldOffset(Offset = "0x8")]
			public IUpdatableGraph graph;

			// Token: 0x0400024C RID: 588
			[Token(Token = "0x400024C")]
			[FieldOffset(Offset = "0x10")]
			public GraphUpdateObject obj;
		}
	}
}
