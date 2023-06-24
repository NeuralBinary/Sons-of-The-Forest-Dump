using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Pathfinding;
using Pathfinding.Util;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x02000002 RID: 2
[Token(Token = "0x2000002")]
[HelpURL("http://arongranberg.com/astar/documentation/stable/class_astar_path.php")]
[AddComponentMenu("Pathfinding/Pathfinder")]
[ExecuteInEditMode]
public class AstarPath : VersionedMonoBehaviour
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000001")]
	[Obsolete]
	public Type[] graphTypes
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x612390", Offset = "0x610990", VA = "0x180612390")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000002")]
	[Obsolete("The 'astarData' field has been renamed to 'data'")]
	public AstarData astarData
	{
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000003")]
	public NavGraph[] graphs
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x6123B0", Offset = "0x6109B0", VA = "0x1806123B0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000004 RID: 4 RVA: 0x00002054 File Offset: 0x00000254
	[Token(Token = "0x17000004")]
	public float maxNearestNodeDistanceSqr
	{
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x612470", Offset = "0x610A70", VA = "0x180612470")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x06000005 RID: 5 RVA: 0x0000206C File Offset: 0x0000026C
	// (set) Token: 0x06000006 RID: 6 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x17000005")]
	[Obsolete("This field has been renamed to 'batchGraphUpdates'")]
	public bool limitGraphUpdates
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x612480", Offset = "0x610A80", VA = "0x180612480")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x612490", Offset = "0x610A90", VA = "0x180612490")]
		set
		{
		}
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000007 RID: 7 RVA: 0x00002084 File Offset: 0x00000284
	// (set) Token: 0x06000008 RID: 8 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x17000006")]
	[Obsolete("This field has been renamed to 'graphUpdateBatchingInterval'")]
	public float maxGraphUpdateFreq
	{
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x6124A0", Offset = "0x610AA0", VA = "0x1806124A0")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x6124B0", Offset = "0x610AB0", VA = "0x1806124B0")]
		set
		{
		}
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x06000009 RID: 9 RVA: 0x0000209C File Offset: 0x0000029C
	// (set) Token: 0x0600000A RID: 10 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x17000007")]
	public float lastScanTime
	{
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x6124C0", Offset = "0x610AC0", VA = "0x1806124C0")]
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x6124D0", Offset = "0x610AD0", VA = "0x1806124D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x0600000B RID: 11 RVA: 0x000020B4 File Offset: 0x000002B4
	// (set) Token: 0x0600000C RID: 12 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x17000008")]
	public bool isScanning
	{
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x6124E0", Offset = "0x610AE0", VA = "0x1806124E0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x6124F0", Offset = "0x610AF0", VA = "0x1806124F0")]
		private set
		{
		}
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x0600000D RID: 13 RVA: 0x000020CC File Offset: 0x000002CC
	[Token(Token = "0x17000009")]
	public int NumParallelThreads
	{
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x612500", Offset = "0x610B00", VA = "0x180612500")]
		get
		{
			return 0;
		}
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x0600000E RID: 14 RVA: 0x000020E4 File Offset: 0x000002E4
	[Token(Token = "0x1700000A")]
	public bool IsUsingMultithreading
	{
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x612530", Offset = "0x610B30", VA = "0x180612530")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x0600000F RID: 15 RVA: 0x000020FC File Offset: 0x000002FC
	[Token(Token = "0x1700000B")]
	[Obsolete("Fixed grammar, use IsAnyGraphUpdateQueued instead")]
	public bool IsAnyGraphUpdatesQueued
	{
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x612560", Offset = "0x610B60", VA = "0x180612560")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x06000010 RID: 16 RVA: 0x00002114 File Offset: 0x00000314
	[Token(Token = "0x1700000C")]
	public bool IsAnyGraphUpdateQueued
	{
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x612560", Offset = "0x610B60", VA = "0x180612560")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x06000011 RID: 17 RVA: 0x0000212C File Offset: 0x0000032C
	[Token(Token = "0x1700000D")]
	public bool IsAnyGraphUpdateInProgress
	{
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x6125B0", Offset = "0x610BB0", VA = "0x1806125B0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x06000012 RID: 18 RVA: 0x00002144 File Offset: 0x00000344
	[Token(Token = "0x1700000E")]
	public bool IsAnyWorkItemInProgress
	{
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x6125D0", Offset = "0x610BD0", VA = "0x1806125D0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x06000013 RID: 19 RVA: 0x0000215C File Offset: 0x0000035C
	[Token(Token = "0x1700000F")]
	internal bool IsInsideWorkItem
	{
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x6125F0", Offset = "0x610BF0", VA = "0x1806125F0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000014")]
	[Address(RVA = "0x612610", Offset = "0x610C10", VA = "0x180612610")]
	private AstarPath()
	{
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000015")]
	[Address(RVA = "0x612EF0", Offset = "0x6114F0", VA = "0x180612EF0")]
	public string[] GetTagNames()
	{
		return null;
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000016")]
	[Address(RVA = "0x6130B0", Offset = "0x6116B0", VA = "0x1806130B0")]
	public static void FindAstarPath()
	{
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000017")]
	[Address(RVA = "0x613440", Offset = "0x611A40", VA = "0x180613440")]
	public static string[] FindTagNames()
	{
		return null;
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00002174 File Offset: 0x00000374
	[Token(Token = "0x6000018")]
	[Address(RVA = "0x6135B0", Offset = "0x611BB0", VA = "0x1806135B0")]
	internal ushort GetNextPathID()
	{
		return 0;
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000019")]
	[Address(RVA = "0x6136D0", Offset = "0x611CD0", VA = "0x1806136D0")]
	private void RecalculateDebugLimits()
	{
	}

	// Token: 0x0600001A RID: 26 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x600001A")]
	[Address(RVA = "0x613930", Offset = "0x611F30", VA = "0x180613930")]
	private void OnDrawGizmos()
	{
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x600001B")]
	[Address(RVA = "0x613EA0", Offset = "0x6124A0", VA = "0x180613EA0")]
	private void OnGUI()
	{
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x600001C")]
	[Address(RVA = "0x613F60", Offset = "0x612560", VA = "0x180613F60")]
	private void LogPathResults(Path path)
	{
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x600001D")]
	[Address(RVA = "0x6140A0", Offset = "0x6126A0", VA = "0x1806140A0")]
	private void Update()
	{
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x600001E")]
	[Address(RVA = "0x614180", Offset = "0x612780", VA = "0x180614180")]
	private void PerformBlockingActions(bool force = false)
	{
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x600001F")]
	[Address(RVA = "0x614260", Offset = "0x612860", VA = "0x180614260")]
	[Obsolete("This method has been moved. Use the method on the context object that can be sent with work item delegates instead")]
	public void QueueWorkItemFloodFill()
	{
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000020")]
	[Address(RVA = "0x6142B0", Offset = "0x6128B0", VA = "0x1806142B0")]
	[Obsolete("This method has been moved. Use the method on the context object that can be sent with work item delegates instead")]
	public void EnsureValidFloodFill()
	{
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000021")]
	[Address(RVA = "0x614300", Offset = "0x612900", VA = "0x180614300")]
	public void AddWorkItem(Action callback)
	{
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000022")]
	[Address(RVA = "0x614350", Offset = "0x612950", VA = "0x180614350")]
	public void AddWorkItem(Action<IWorkItemContext> callback)
	{
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000023")]
	[Address(RVA = "0x6143A0", Offset = "0x6129A0", VA = "0x1806143A0")]
	public void AddWorkItem(AstarWorkItem item)
	{
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000024")]
	[Address(RVA = "0x6144E0", Offset = "0x612AE0", VA = "0x1806144E0")]
	public void QueueGraphUpdates()
	{
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000025")]
	[Address(RVA = "0x614780", Offset = "0x612D80", VA = "0x180614780")]
	private IEnumerator DelayedGraphUpdate()
	{
		return null;
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000026")]
	[Address(RVA = "0x614810", Offset = "0x612E10", VA = "0x180614810")]
	public void UpdateGraphs(Bounds bounds, float delay)
	{
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000027")]
	[Address(RVA = "0x614990", Offset = "0x612F90", VA = "0x180614990")]
	public void UpdateGraphs(GraphUpdateObject ob, float delay)
	{
	}

	// Token: 0x06000028 RID: 40 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000028")]
	[Address(RVA = "0x614AB0", Offset = "0x6130B0", VA = "0x180614AB0")]
	private IEnumerator UpdateGraphsInternal(GraphUpdateObject ob, float delay)
	{
		return null;
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000029")]
	[Address(RVA = "0x614BD0", Offset = "0x6131D0", VA = "0x180614BD0")]
	public void UpdateGraphs(Bounds bounds)
	{
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x600002A")]
	[Address(RVA = "0x614C50", Offset = "0x613250", VA = "0x180614C50")]
	public void UpdateGraphs(GraphUpdateObject ob)
	{
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x600002B")]
	[Address(RVA = "0x614E40", Offset = "0x613440", VA = "0x180614E40")]
	public void FlushGraphUpdates()
	{
	}

	// Token: 0x0600002C RID: 44 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x600002C")]
	[Address(RVA = "0x614EB0", Offset = "0x6134B0", VA = "0x180614EB0")]
	public void FlushWorkItems()
	{
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x600002D")]
	[Address(RVA = "0x614F50", Offset = "0x613550", VA = "0x180614F50")]
	[Obsolete("Use FlushWorkItems() instead")]
	public void FlushWorkItems(bool unblockOnComplete, bool block)
	{
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x600002E")]
	[Address(RVA = "0x614FC0", Offset = "0x6135C0", VA = "0x180614FC0")]
	[Obsolete("Use FlushWorkItems instead")]
	public void FlushThreadSafeCallbacks()
	{
	}

	// Token: 0x0600002F RID: 47 RVA: 0x0000218C File Offset: 0x0000038C
	[Token(Token = "0x600002F")]
	[Address(RVA = "0x614FD0", Offset = "0x6135D0", VA = "0x180614FD0")]
	public static int CalculateThreadCount(ThreadCount count)
	{
		return 0;
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000030")]
	[Address(RVA = "0x6151B0", Offset = "0x6137B0", VA = "0x1806151B0", Slot = "7")]
	protected override void Awake()
	{
	}

	// Token: 0x06000031 RID: 49 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000031")]
	[Address(RVA = "0x615A30", Offset = "0x614030", VA = "0x180615A30")]
	private void InitializePathProcessor()
	{
	}

	// Token: 0x06000032 RID: 50 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000032")]
	[Address(RVA = "0x6160D0", Offset = "0x6146D0", VA = "0x1806160D0")]
	internal void VerifyIntegrity()
	{
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000033")]
	[Address(RVA = "0x6162F0", Offset = "0x6148F0", VA = "0x1806162F0")]
	public void ConfigureReferencesInternal()
	{
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000034")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void InitializeProfiler()
	{
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000035")]
	[Address(RVA = "0x616530", Offset = "0x614B30", VA = "0x180616530")]
	private void InitializeAstarData()
	{
	}

	// Token: 0x06000036 RID: 54 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000036")]
	[Address(RVA = "0x6166B0", Offset = "0x614CB0", VA = "0x1806166B0")]
	private void OnDisable()
	{
	}

	// Token: 0x06000037 RID: 55 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000037")]
	[Address(RVA = "0x6166E0", Offset = "0x614CE0", VA = "0x1806166E0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000038 RID: 56 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000038")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	[Obsolete("Not meaningful anymore. The HierarchicalGraph takes care of things automatically behind the scenes")]
	public void FloodFill(GraphNode seed)
	{
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000039")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	[Obsolete("Not meaningful anymore. The HierarchicalGraph takes care of things automatically behind the scenes")]
	public void FloodFill(GraphNode seed, uint area)
	{
	}

	// Token: 0x0600003A RID: 58 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x600003A")]
	[Address(RVA = "0x617230", Offset = "0x615830", VA = "0x180617230")]
	[Obsolete("Avoid using. This will force a full recalculation of the connected components. In most cases the HierarchicalGraph class takes care of things automatically behind the scenes now.")]
	[ContextMenu("Flood Fill Graphs")]
	public void FloodFill()
	{
	}

	// Token: 0x0600003B RID: 59 RVA: 0x000021A4 File Offset: 0x000003A4
	[Token(Token = "0x600003B")]
	[Address(RVA = "0x617270", Offset = "0x615870", VA = "0x180617270")]
	internal int GetNewNodeIndex()
	{
		return 0;
	}

	// Token: 0x0600003C RID: 60 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x600003C")]
	[Address(RVA = "0x6172E0", Offset = "0x6158E0", VA = "0x1806172E0")]
	internal void InitializeNode(GraphNode node)
	{
	}

	// Token: 0x0600003D RID: 61 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x600003D")]
	[Address(RVA = "0x617310", Offset = "0x615910", VA = "0x180617310")]
	internal void DestroyNode(GraphNode node)
	{
	}

	// Token: 0x0600003E RID: 62 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x600003E")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	[Obsolete("Use PausePathfinding instead. Make sure to call Release on the returned lock.", true)]
	public void BlockUntilPathQueueBlocked()
	{
	}

	// Token: 0x0600003F RID: 63 RVA: 0x000021BC File Offset: 0x000003BC
	[Token(Token = "0x600003F")]
	[Address(RVA = "0x617340", Offset = "0x615940", VA = "0x180617340")]
	public PathProcessor.GraphUpdateLock PausePathfinding()
	{
		return default(PathProcessor.GraphUpdateLock);
	}

	// Token: 0x06000040 RID: 64 RVA: 0x000021D4 File Offset: 0x000003D4
	[Token(Token = "0x6000040")]
	[Address(RVA = "0x617390", Offset = "0x615990", VA = "0x180617390")]
	private PathProcessor.GraphUpdateLock PausePathfindingSoon()
	{
		return default(PathProcessor.GraphUpdateLock);
	}

	// Token: 0x06000041 RID: 65 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000041")]
	[Address(RVA = "0x6173E0", Offset = "0x6159E0", VA = "0x1806173E0")]
	public void Scan(NavGraph graphToScan)
	{
	}

	// Token: 0x06000042 RID: 66 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000042")]
	[Address(RVA = "0x6174C0", Offset = "0x615AC0", VA = "0x1806174C0")]
	public void Scan([Optional] NavGraph[] graphsToScan)
	{
	}

	// Token: 0x06000043 RID: 67 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000043")]
	[Address(RVA = "0x617670", Offset = "0x615C70", VA = "0x180617670")]
	public IEnumerable<Progress> ScanAsync(NavGraph graphToScan)
	{
		return null;
	}

	// Token: 0x06000044 RID: 68 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000044")]
	[Address(RVA = "0x617750", Offset = "0x615D50", VA = "0x180617750")]
	public IEnumerable<Progress> ScanAsync([Optional] NavGraph[] graphsToScan)
	{
		return null;
	}

	// Token: 0x06000045 RID: 69 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000045")]
	[Address(RVA = "0x617860", Offset = "0x615E60", VA = "0x180617860")]
	private IEnumerable<Progress> ScanGraph(NavGraph graph)
	{
		return null;
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000046")]
	[Address(RVA = "0x617900", Offset = "0x615F00", VA = "0x180617900")]
	[Obsolete("This method has been renamed to BlockUntilCalculated")]
	public static void WaitForPath(Path path)
	{
	}

	// Token: 0x06000047 RID: 71 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000047")]
	[Address(RVA = "0x617950", Offset = "0x615F50", VA = "0x180617950")]
	public static void BlockUntilCalculated(Path path)
	{
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000048")]
	[Address(RVA = "0x617FE0", Offset = "0x6165E0", VA = "0x180617FE0")]
	[Obsolete("Use AddWorkItem(System.Action) instead. Note the slight change in behavior (mentioned in the documentation).")]
	public static void RegisterSafeUpdate(Action callback)
	{
	}

	// Token: 0x06000049 RID: 73 RVA: 0x00002082 File Offset: 0x00000282
	[Token(Token = "0x6000049")]
	[Address(RVA = "0x618090", Offset = "0x616690", VA = "0x180618090")]
	public static void StartPath(Path path, bool pushToFront = false)
	{
	}

	// Token: 0x0600004A RID: 74 RVA: 0x000021EC File Offset: 0x000003EC
	[Token(Token = "0x600004A")]
	[Address(RVA = "0x618480", Offset = "0x616A80", VA = "0x180618480")]
	public NNInfo GetNearest(Vector3 position)
	{
		return default(NNInfo);
	}

	// Token: 0x0600004B RID: 75 RVA: 0x00002204 File Offset: 0x00000404
	[Token(Token = "0x600004B")]
	[Address(RVA = "0x618530", Offset = "0x616B30", VA = "0x180618530")]
	public NNInfo GetNearest(Vector3 position, NNConstraint constraint)
	{
		return default(NNInfo);
	}

	// Token: 0x0600004C RID: 76 RVA: 0x0000221C File Offset: 0x0000041C
	[Token(Token = "0x600004C")]
	[Address(RVA = "0x618580", Offset = "0x616B80", VA = "0x180618580")]
	public NNInfo GetNearest(Vector3 position, NNConstraint constraint, GraphNode hint)
	{
		return default(NNInfo);
	}

	// Token: 0x0600004D RID: 77 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004D")]
	[Address(RVA = "0x618A80", Offset = "0x617080", VA = "0x180618A80")]
	public GraphNode GetNearest(Ray ray)
	{
		return null;
	}

	// Token: 0x04000001 RID: 1
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly Version Version;

	// Token: 0x04000002 RID: 2
	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static readonly AstarPath.AstarDistribution Distribution;

	// Token: 0x04000003 RID: 3
	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static readonly string Branch;

	// Token: 0x04000004 RID: 4
	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("astarData")]
	public AstarData data;

	// Token: 0x04000005 RID: 5
	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static AstarPath active;

	// Token: 0x04000006 RID: 6
	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool showNavGraphs;

	// Token: 0x04000007 RID: 7
	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool showUnwalkableNodes;

	// Token: 0x04000008 RID: 8
	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public GraphDebugMode debugMode;

	// Token: 0x04000009 RID: 9
	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float debugFloor;

	// Token: 0x0400000A RID: 10
	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float debugRoof;

	// Token: 0x0400000B RID: 11
	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool manualDebugFloorRoof;

	// Token: 0x0400000C RID: 12
	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	public bool showSearchTree;

	// Token: 0x0400000D RID: 13
	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float unwalkableNodeDebugSize;

	// Token: 0x0400000E RID: 14
	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public PathLog logPathResults;

	// Token: 0x0400000F RID: 15
	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float maxNearestNodeDistance;

	// Token: 0x04000010 RID: 16
	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool scanOnStartup;

	// Token: 0x04000011 RID: 17
	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	public bool fullGetNearestSearch;

	// Token: 0x04000012 RID: 18
	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
	[Obsolete("This setting is discouraged, and it will be removed in a future update")]
	public bool prioritizeGraphs;

	// Token: 0x04000013 RID: 19
	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[Obsolete("This setting is discouraged, and it will be removed in a future update")]
	public float prioritizeGraphsLimit;

	// Token: 0x04000014 RID: 20
	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public AstarColor colorSettings;

	// Token: 0x04000015 RID: 21
	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	protected string[] tagNames;

	// Token: 0x04000016 RID: 22
	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Heuristic heuristic;

	// Token: 0x04000017 RID: 23
	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float heuristicScale;

	// Token: 0x04000018 RID: 24
	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ThreadCount threadCount;

	// Token: 0x04000019 RID: 25
	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float maxFrameTime;

	// Token: 0x0400001A RID: 26
	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public bool batchGraphUpdates;

	// Token: 0x0400001B RID: 27
	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public float graphUpdateBatchingInterval;

	// Token: 0x0400001D RID: 29
	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[NonSerialized]
	public PathHandler debugPathData;

	// Token: 0x0400001E RID: 30
	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[NonSerialized]
	public ushort debugPathID;

	// Token: 0x0400001F RID: 31
	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private string inGameDebugPath;

	// Token: 0x04000020 RID: 32
	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[NonSerialized]
	private bool isScanningBacking;

	// Token: 0x04000021 RID: 33
	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static Action OnAwakeSettings;

	// Token: 0x04000022 RID: 34
	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static OnGraphDelegate OnGraphPreScan;

	// Token: 0x04000023 RID: 35
	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static OnGraphDelegate OnGraphPostScan;

	// Token: 0x04000024 RID: 36
	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static OnPathDelegate OnPathPreSearch;

	// Token: 0x04000025 RID: 37
	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static OnPathDelegate OnPathPostSearch;

	// Token: 0x04000026 RID: 38
	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public static OnScanDelegate OnPreScan;

	// Token: 0x04000027 RID: 39
	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static OnScanDelegate OnPostScan;

	// Token: 0x04000028 RID: 40
	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public static OnScanDelegate OnLatePostScan;

	// Token: 0x04000029 RID: 41
	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public static OnScanDelegate OnGraphsUpdated;

	// Token: 0x0400002A RID: 42
	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public static Action On65KOverflow;

	// Token: 0x0400002B RID: 43
	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[Obsolete]
	public Action OnGraphsWillBeUpdated;

	// Token: 0x0400002C RID: 44
	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[Obsolete]
	public Action OnGraphsWillBeUpdated2;

	// Token: 0x0400002D RID: 45
	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private readonly GraphUpdateProcessor graphUpdates;

	// Token: 0x0400002E RID: 46
	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	internal readonly HierarchicalGraph hierarchicalGraph;

	// Token: 0x0400002F RID: 47
	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public readonly NavmeshUpdates navmeshUpdates;

	// Token: 0x04000030 RID: 48
	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly WorkItemProcessor workItems;

	// Token: 0x04000031 RID: 49
	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private PathProcessor pathProcessor;

	// Token: 0x04000032 RID: 50
	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private bool graphUpdateRoutineRunning;

	// Token: 0x04000033 RID: 51
	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
	private bool graphUpdatesWorkItemAdded;

	// Token: 0x04000034 RID: 52
	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private float lastGraphUpdate;

	// Token: 0x04000035 RID: 53
	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private PathProcessor.GraphUpdateLock workItemLock;

	// Token: 0x04000036 RID: 54
	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	internal readonly PathReturnQueue pathReturnQueue;

	// Token: 0x04000037 RID: 55
	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public EuclideanEmbedding euclideanEmbedding;

	// Token: 0x04000038 RID: 56
	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public bool showGraphs;

	// Token: 0x04000039 RID: 57
	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10A")]
	private ushort nextFreePathID;

	// Token: 0x0400003A RID: 58
	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private RetainedGizmos gizmos;

	// Token: 0x0400003B RID: 59
	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static int waitForPathDepth;

	// Token: 0x0400003C RID: 60
	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private static readonly NNConstraint NNConstraintNone;

	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	public enum AstarDistribution
	{
		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		WebsiteDownload,
		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		AssetStore,
		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		PackageManager
	}
}
