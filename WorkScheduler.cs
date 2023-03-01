using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Il2CppDummyDll;
using TheForest.Commons.Delegates;
using TheForest.Modding.Bridge.Interfaces;
using TheForest.Utils.WorkSchedulerInterfaces;
using UnityEngine;

// Token: 0x020002D1 RID: 721
[Token(Token = "0x20002D1")]
public class WorkScheduler : MonoBehaviour, IWorkScheduler
{
	// Token: 0x17000212 RID: 530
	// (get) Token: 0x06001273 RID: 4723 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000212")]
	public static WorkScheduler Instance
	{
		[Token(Token = "0x6001273")]
		[Address(RVA = "0x2B983C0", Offset = "0x2B973C0", VA = "0x182B983C0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000213 RID: 531
	// (get) Token: 0x06001274 RID: 4724 RVA: 0x000064C8 File Offset: 0x000046C8
	[Token(Token = "0x17000213")]
	public static DateTime Now
	{
		[Token(Token = "0x6001274")]
		[Address(RVA = "0x2B98400", Offset = "0x2B97400", VA = "0x182B98400")]
		get
		{
			return default(DateTime);
		}
	}

	// Token: 0x06001275 RID: 4725 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001275")]
	[Address(RVA = "0x2B950F0", Offset = "0x2B940F0", VA = "0x182B950F0")]
	private void Awake()
	{
	}

	// Token: 0x06001276 RID: 4726 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001276")]
	[Address(RVA = "0x2B95D30", Offset = "0x2B94D30", VA = "0x182B95D30")]
	private void OnEnable()
	{
	}

	// Token: 0x06001277 RID: 4727 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001277")]
	[Address(RVA = "0x2B95CA0", Offset = "0x2B94CA0", VA = "0x182B95CA0")]
	private void OnDisable()
	{
	}

	// Token: 0x06001278 RID: 4728 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001278")]
	[Address(RVA = "0x2B974C0", Offset = "0x2B964C0", VA = "0x182B974C0")]
	private void Update()
	{
	}

	// Token: 0x06001279 RID: 4729 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001279")]
	[Address(RVA = "0x2B96430", Offset = "0x2B95430", VA = "0x182B96430")]
	private void QueueCleanupPosition(Vector3 newPosition)
	{
	}

	// Token: 0x0600127A RID: 4730 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600127A")]
	[Address(RVA = "0x2B95C40", Offset = "0x2B94C40", VA = "0x182B95C40")]
	private void LateUpdate()
	{
	}

	// Token: 0x0600127B RID: 4731 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600127B")]
	[Address(RVA = "0x2B95C70", Offset = "0x2B94C70", VA = "0x182B95C70")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600127C RID: 4732 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600127C")]
	[Address(RVA = "0x2B968E0", Offset = "0x2B958E0", VA = "0x182B968E0")]
	private void SetSecondaryThreadState(WorkScheduler.ThreadStates value)
	{
	}

	// Token: 0x0600127D RID: 4733 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600127D")]
	[Address(RVA = "0x2B95970", Offset = "0x2B94970", VA = "0x182B95970")]
	private void GetViewerPositions(out int localIdx)
	{
	}

	// Token: 0x0600127E RID: 4734 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600127E")]
	[Address(RVA = "0x2B95330", Offset = "0x2B94330", VA = "0x182B95330")]
	private static void CheckConfig()
	{
	}

	// Token: 0x0600127F RID: 4735 RVA: 0x000064E0 File Offset: 0x000046E0
	[Token(Token = "0x600127F")]
	[Address(RVA = "0x2B982B0", Offset = "0x2B972B0", VA = "0x182B982B0")]
	public int getTokenForPosition(Vector3 position)
	{
		return default(int);
	}

	// Token: 0x06001280 RID: 4736 RVA: 0x000064F8 File Offset: 0x000046F8
	[Token(Token = "0x6001280")]
	[Address(RVA = "0x2B95500", Offset = "0x2B94500", VA = "0x182B95500")]
	public static bool CheckTokenForPosition(Vector3 position, int token)
	{
		return default(bool);
	}

	// Token: 0x06001281 RID: 4737 RVA: 0x00006510 File Offset: 0x00004710
	[Token(Token = "0x6001281")]
	[Address(RVA = "0x2B98490", Offset = "0x2B97490", VA = "0x182B98490", Slot = "5")]
	public int register(WsTask task, Vector3 position, bool skipDuplicateCheck)
	{
		return default(int);
	}

	// Token: 0x06001282 RID: 4738 RVA: 0x00006528 File Offset: 0x00004728
	[Token(Token = "0x6001282")]
	[Address(RVA = "0x2B96680", Offset = "0x2B95680", VA = "0x182B96680")]
	public static int Register(WsTask task, Vector3 position, bool skipDuplicateCheck = false)
	{
		return default(int);
	}

	// Token: 0x06001283 RID: 4739 RVA: 0x00006540 File Offset: 0x00004740
	[Token(Token = "0x6001283")]
	[Address(RVA = "0x2B98600", Offset = "0x2B97600", VA = "0x182B98600")]
	public int register(IThreadSafeTask taskObject, Vector3 position, bool skipDuplicateCheck)
	{
		return default(int);
	}

	// Token: 0x06001284 RID: 4740 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001284")]
	[Address(RVA = "0x2B95770", Offset = "0x2B94770", VA = "0x182B95770")]
	private void DrawProcessIndicator(Vector3 worldPos, Color processIndicatorColor)
	{
	}

	// Token: 0x06001285 RID: 4741 RVA: 0x00006558 File Offset: 0x00004758
	[Token(Token = "0x6001285")]
	[Address(RVA = "0x2B96840", Offset = "0x2B95840", VA = "0x182B96840")]
	public static int Register(IThreadSafeTask taskObject, Vector3 position, bool skipDuplicateCheck = false)
	{
		return default(int);
	}

	// Token: 0x06001286 RID: 4742 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001286")]
	[Address(RVA = "0x2B98870", Offset = "0x2B97870", VA = "0x182B98870", Slot = "9")]
	public void unregister(WsTask task, int token)
	{
	}

	// Token: 0x06001287 RID: 4743 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001287")]
	[Address(RVA = "0x2B973A0", Offset = "0x2B963A0", VA = "0x182B973A0")]
	public static void Unregister(WsTask task, int token)
	{
	}

	// Token: 0x06001288 RID: 4744 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001288")]
	[Address(RVA = "0x2B98910", Offset = "0x2B97910", VA = "0x182B98910")]
	public void unregister(IThreadSafeTask tfTask, int token)
	{
	}

	// Token: 0x06001289 RID: 4745 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001289")]
	[Address(RVA = "0x2B97280", Offset = "0x2B96280", VA = "0x182B97280")]
	public static void Unregister(IThreadSafeTask tfTask, int token)
	{
	}

	// Token: 0x0600128A RID: 4746 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600128A")]
	[Address(RVA = "0x2B98440", Offset = "0x2B97440", VA = "0x182B98440", Slot = "6")]
	public void registerGlobal(WsTask task, bool force)
	{
	}

	// Token: 0x0600128B RID: 4747 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600128B")]
	[Address(RVA = "0x2B96550", Offset = "0x2B95550", VA = "0x182B96550")]
	public static void RegisterGlobal(WsTask task, bool force = false)
	{
	}

	// Token: 0x0600128C RID: 4748 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600128C")]
	[Address(RVA = "0x2B98850", Offset = "0x2B97850", VA = "0x182B98850", Slot = "10")]
	public void unregisterGlobal(WsTask task)
	{
	}

	// Token: 0x0600128D RID: 4749 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600128D")]
	[Address(RVA = "0x2B971D0", Offset = "0x2B961D0", VA = "0x182B971D0")]
	public static void UnregisterGlobal(WsTask task)
	{
	}

	// Token: 0x0600128E RID: 4750 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600128E")]
	[Address(RVA = "0x2B96F00", Offset = "0x2B95F00", VA = "0x182B96F00")]
	public static void ToggleTryCatchWork(bool onoff)
	{
	}

	// Token: 0x0600128F RID: 4751 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600128F")]
	[Address(RVA = "0x2B98460", Offset = "0x2B97460", VA = "0x182B98460", Slot = "7")]
	public void registerOneShot(WsTask task)
	{
	}

	// Token: 0x06001290 RID: 4752 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001290")]
	[Address(RVA = "0x2B965D0", Offset = "0x2B955D0", VA = "0x182B965D0")]
	public static void RegisterOneShot(WsTask task)
	{
	}

	// Token: 0x06001291 RID: 4753 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001291")]
	[Address(RVA = "0x2B97170", Offset = "0x2B96170", VA = "0x182B97170", Slot = "8")]
	public void Toggle(bool onOff)
	{
	}

	// Token: 0x06001292 RID: 4754 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001292")]
	[Address(RVA = "0x2B95660", Offset = "0x2B94660", VA = "0x182B95660")]
	public static void ClearInstance()
	{
	}

	// Token: 0x06001293 RID: 4755 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001293")]
	[Address(RVA = "0x2B956B0", Offset = "0x2B946B0", VA = "0x182B956B0", Slot = "4")]
	public void Clear()
	{
	}

	// Token: 0x06001294 RID: 4756 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001294")]
	[Address(RVA = "0x2B96990", Offset = "0x2B95990", VA = "0x182B96990")]
	private void ThreadedUpdate()
	{
	}

	// Token: 0x06001295 RID: 4757 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001295")]
	[Address(RVA = "0x2B95EA0", Offset = "0x2B94EA0", VA = "0x182B95EA0")]
	private void ProcessArea(Vector3 position, long remainingTicks, bool cleanup, bool mainThread = false)
	{
	}

	// Token: 0x06001296 RID: 4758 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001296")]
	[Address(RVA = "0x2B96200", Offset = "0x2B95200", VA = "0x182B96200")]
	private void ProcessSchedulerBatchFar(bool threadSafeOnly, WorkSchedulerBatch wsb, long farTicks, ref int batchedTasksFar)
	{
	}

	// Token: 0x06001297 RID: 4759 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001297")]
	[Address(RVA = "0x2B96110", Offset = "0x2B95110", VA = "0x182B96110")]
	private void ProcessSchedulerBatchFarMainThread(WorkSchedulerBatch wsb)
	{
	}

	// Token: 0x06001298 RID: 4760 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001298")]
	[Address(RVA = "0x2B96350", Offset = "0x2B95350", VA = "0x182B96350")]
	private void ProcessSchedulerBatchNear(bool threadSafeOnly, WorkSchedulerBatch wsb, long nearTicks, ref int batchedTasksNear)
	{
	}

	// Token: 0x06001299 RID: 4761 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001299")]
	[Address(RVA = "0x2B961A0", Offset = "0x2B951A0", VA = "0x182B961A0")]
	private void ProcessSchedulerBatchFarThreaded(WorkSchedulerBatch wsb, long farTicks, ref int batchedTasksFar)
	{
	}

	// Token: 0x0600129A RID: 4762 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600129A")]
	[Address(RVA = "0x2B96110", Offset = "0x2B95110", VA = "0x182B96110")]
	private void ProcessSchedulerBatchNearMainThread(WorkSchedulerBatch wsb)
	{
	}

	// Token: 0x0600129B RID: 4763 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600129B")]
	[Address(RVA = "0x2B962F0", Offset = "0x2B952F0", VA = "0x182B962F0")]
	private void ProcessSchedulerBatchNearThreaded(WorkSchedulerBatch wsb, long nearTicks, ref int batchedTasksNear)
	{
	}

	// Token: 0x0600129C RID: 4764 RVA: 0x00006570 File Offset: 0x00004770
	[Token(Token = "0x600129C")]
	[Address(RVA = "0x2B98000", Offset = "0x2B97000", VA = "0x182B98000")]
	private int WorldToGridX(float xPosition)
	{
		return default(int);
	}

	// Token: 0x0600129D RID: 4765 RVA: 0x00006588 File Offset: 0x00004788
	[Token(Token = "0x600129D")]
	[Address(RVA = "0x2B95C00", Offset = "0x2B94C00", VA = "0x182B95C00")]
	private float GridToWorldX(int xGrid)
	{
		return default(float);
	}

	// Token: 0x0600129E RID: 4766 RVA: 0x000065A0 File Offset: 0x000047A0
	[Token(Token = "0x600129E")]
	[Address(RVA = "0x2B98090", Offset = "0x2B97090", VA = "0x182B98090")]
	private int WorldToGridY(float zPosition)
	{
		return default(int);
	}

	// Token: 0x0600129F RID: 4767 RVA: 0x000065B8 File Offset: 0x000047B8
	[Token(Token = "0x600129F")]
	[Address(RVA = "0x2B95C20", Offset = "0x2B94C20", VA = "0x182B95C20")]
	private float GridToWorldY(int yGrid)
	{
		return default(float);
	}

	// Token: 0x060012A0 RID: 4768 RVA: 0x000065D0 File Offset: 0x000047D0
	[Token(Token = "0x60012A0")]
	[Address(RVA = "0x2B97FE0", Offset = "0x2B96FE0", VA = "0x182B97FE0")]
	private int WorldToGridXRounded(float xPosition)
	{
		return default(int);
	}

	// Token: 0x060012A1 RID: 4769 RVA: 0x000065E8 File Offset: 0x000047E8
	[Token(Token = "0x60012A1")]
	[Address(RVA = "0x2B98070", Offset = "0x2B97070", VA = "0x182B98070")]
	private int WorldToGridYRounded(float zPosition)
	{
		return default(int);
	}

	// Token: 0x060012A2 RID: 4770 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012A2")]
	[Address(RVA = "0x2B94FF0", Offset = "0x2B93FF0", VA = "0x182B94FF0")]
	private static void AddWorkScheduler()
	{
	}

	// Token: 0x060012A3 RID: 4771 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012A3")]
	[Address(RVA = "0x2B98100", Offset = "0x2B97100", VA = "0x182B98100")]
	public WorkScheduler()
	{
	}

	// Token: 0x0400126C RID: 4716
	[Token(Token = "0x400126C")]
	[FieldOffset(Offset = "0x20")]
	[Range(0.01f, 2f)]
	public float MaxMilliseconds;

	// Token: 0x0400126D RID: 4717
	[Token(Token = "0x400126D")]
	[FieldOffset(Offset = "0x24")]
	public bool ScaleWithFPS;

	// Token: 0x0400126E RID: 4718
	[Token(Token = "0x400126E")]
	[FieldOffset(Offset = "0x28")]
	[Range(30f, 120f)]
	public float TargetFPS;

	// Token: 0x0400126F RID: 4719
	[Token(Token = "0x400126F")]
	[FieldOffset(Offset = "0x2C")]
	public int GridSize;

	// Token: 0x04001270 RID: 4720
	[Token(Token = "0x4001270")]
	[FieldOffset(Offset = "0x30")]
	public float GridWorldSize;

	// Token: 0x04001271 RID: 4721
	[Token(Token = "0x4001271")]
	[FieldOffset(Offset = "0x34")]
	[Header("Stats")]
	public float DelayWithPreviousUpdate;

	// Token: 0x04001272 RID: 4722
	[Token(Token = "0x4001272")]
	[FieldOffset(Offset = "0x38")]
	public float ThreadedUpdateDuration;

	// Token: 0x04001273 RID: 4723
	[Token(Token = "0x4001273")]
	[FieldOffset(Offset = "0x3C")]
	public float ThreadedCleanupDuration;

	// Token: 0x04001274 RID: 4724
	[Token(Token = "0x4001274")]
	[FieldOffset(Offset = "0x40")]
	[Header("Gizmos")]
	public bool ShowGrid;

	// Token: 0x04001275 RID: 4725
	[Token(Token = "0x4001275")]
	[FieldOffset(Offset = "0x44")]
	public float MaxDistance;

	// Token: 0x04001276 RID: 4726
	[Token(Token = "0x4001276")]
	[FieldOffset(Offset = "0x48")]
	public float Size;

	// Token: 0x04001277 RID: 4727
	[Token(Token = "0x4001277")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private int _processAreaSize;

	// Token: 0x04001278 RID: 4728
	[Token(Token = "0x4001278")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private int _nearRange;

	// Token: 0x04001279 RID: 4729
	[Token(Token = "0x4001279")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	private float _fullCycleTriggerDistanceMultiplier;

	// Token: 0x0400127A RID: 4730
	[Token(Token = "0x400127A")]
	[FieldOffset(Offset = "0x58")]
	private bool _debugForceServer;

	// Token: 0x0400127B RID: 4731
	[Token(Token = "0x400127B")]
	[FieldOffset(Offset = "0x60")]
	private WorkSchedulerBatch[,] schedulers;

	// Token: 0x0400127C RID: 4732
	[Token(Token = "0x400127C")]
	[FieldOffset(Offset = "0x68")]
	private WorkSchedulerBatch globalScheduler;

	// Token: 0x0400127D RID: 4733
	[Token(Token = "0x400127D")]
	[FieldOffset(Offset = "0x70")]
	private WorkSchedulerBatch oneShotScheduler;

	// Token: 0x0400127E RID: 4734
	[Token(Token = "0x400127E")]
	[FieldOffset(Offset = "0x78")]
	private Stopwatch stopwatch;

	// Token: 0x0400127F RID: 4735
	[Token(Token = "0x400127F")]
	[FieldOffset(Offset = "0x80")]
	private float fps;

	// Token: 0x04001280 RID: 4736
	[Token(Token = "0x4001280")]
	[FieldOffset(Offset = "0x84")]
	private float currentQuality;

	// Token: 0x04001281 RID: 4737
	[Token(Token = "0x4001281")]
	[FieldOffset(Offset = "0x88")]
	private float xOffset;

	// Token: 0x04001282 RID: 4738
	[Token(Token = "0x4001282")]
	[FieldOffset(Offset = "0x8C")]
	private float yOffset;

	// Token: 0x04001283 RID: 4739
	[Token(Token = "0x4001283")]
	[FieldOffset(Offset = "0x90")]
	private int currentFrame;

	// Token: 0x04001284 RID: 4740
	[Token(Token = "0x4001284")]
	[FieldOffset(Offset = "0x94")]
	private int currentThreadFrame;

	// Token: 0x04001285 RID: 4741
	[Token(Token = "0x4001285")]
	[FieldOffset(Offset = "0x98")]
	private Vector3 _previousPosition;

	// Token: 0x04001286 RID: 4742
	[Token(Token = "0x4001286")]
	[FieldOffset(Offset = "0xA4")]
	private WorkScheduler.ThreadStates secondaryThreadState;

	// Token: 0x04001287 RID: 4743
	[Token(Token = "0x4001287")]
	[FieldOffset(Offset = "0xA8")]
	private Thread thread;

	// Token: 0x04001288 RID: 4744
	[Token(Token = "0x4001288")]
	[FieldOffset(Offset = "0xB0")]
	private bool mainThreadUpdating;

	// Token: 0x04001289 RID: 4745
	[Token(Token = "0x4001289")]
	[FieldOffset(Offset = "0xB1")]
	private bool secondaryThreadUpdating;

	// Token: 0x0400128A RID: 4746
	[Token(Token = "0x400128A")]
	[FieldOffset(Offset = "0xB4")]
	private Vector3 _activeWorldPosition;

	// Token: 0x0400128B RID: 4747
	[Token(Token = "0x400128B")]
	[FieldOffset(Offset = "0xC0")]
	private ManualResetEvent mutex;

	// Token: 0x0400128C RID: 4748
	[Token(Token = "0x400128C")]
	[FieldOffset(Offset = "0x0")]
	private static WorkScheduler _instance;

	// Token: 0x0400128D RID: 4749
	[Token(Token = "0x400128D")]
	[FieldOffset(Offset = "0x8")]
	private static bool configWarningIssued;

	// Token: 0x0400128E RID: 4750
	[Token(Token = "0x400128E")]
	[FieldOffset(Offset = "0x9")]
	public static bool Paused;

	// Token: 0x0400128F RID: 4751
	[Token(Token = "0x400128F")]
	[FieldOffset(Offset = "0xA")]
	public static bool ShouldStartCleanup;

	// Token: 0x04001290 RID: 4752
	[Token(Token = "0x4001290")]
	[FieldOffset(Offset = "0xB")]
	public static bool CleanUp;

	// Token: 0x04001291 RID: 4753
	[Token(Token = "0x4001291")]
	[FieldOffset(Offset = "0xC")]
	public static float CurrentTime;

	// Token: 0x04001292 RID: 4754
	[Token(Token = "0x4001292")]
	[FieldOffset(Offset = "0xC8")]
	private List<WorkSchedulerBatch> _previousSchedulers;

	// Token: 0x04001293 RID: 4755
	[Token(Token = "0x4001293")]
	[FieldOffset(Offset = "0xD0")]
	private List<WorkSchedulerBatch> _currentSchedulers;

	// Token: 0x04001294 RID: 4756
	[Token(Token = "0x4001294")]
	[FieldOffset(Offset = "0x10")]
	private static DateTime _nowCachedValue;

	// Token: 0x04001295 RID: 4757
	[Token(Token = "0x4001295")]
	[FieldOffset(Offset = "0xD8")]
	private readonly List<Vector3> _viewerPositions;

	// Token: 0x04001296 RID: 4758
	[Token(Token = "0x4001296")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private bool _createProcessIndicators;

	// Token: 0x04001297 RID: 4759
	[Token(Token = "0x4001297")]
	[FieldOffset(Offset = "0xE4")]
	[SerializeField]
	private Color _processIndicatorNearColor;

	// Token: 0x04001298 RID: 4760
	[Token(Token = "0x4001298")]
	[FieldOffset(Offset = "0xF4")]
	[SerializeField]
	private Color _processIndicatorFarColor;

	// Token: 0x04001299 RID: 4761
	[Token(Token = "0x4001299")]
	[FieldOffset(Offset = "0x104")]
	[SerializeField]
	private float _processIndicatorDuration;

	// Token: 0x0400129A RID: 4762
	[Token(Token = "0x400129A")]
	[FieldOffset(Offset = "0x108")]
	private List<Vector3> _cleanupPositionQueue;

	// Token: 0x0400129B RID: 4763
	[Token(Token = "0x400129B")]
	[FieldOffset(Offset = "0x110")]
	private Vector3 _cleanupPosition;

	// Token: 0x0400129C RID: 4764
	[Token(Token = "0x400129C")]
	[FieldOffset(Offset = "0x120")]
	private readonly object lockObj;

	// Token: 0x020002D2 RID: 722
	[Token(Token = "0x20002D2")]
	public enum ThreadStates
	{
		// Token: 0x0400129E RID: 4766
		[Token(Token = "0x400129E")]
		Idle,
		// Token: 0x0400129F RID: 4767
		[Token(Token = "0x400129F")]
		Running,
		// Token: 0x040012A0 RID: 4768
		[Token(Token = "0x40012A0")]
		Paused,
		// Token: 0x040012A1 RID: 4769
		[Token(Token = "0x40012A1")]
		Closing
	}
}
