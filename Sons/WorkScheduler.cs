using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Il2CppDummyDll;
using TheForest.Commons.Delegates;
using TheForest.Modding.Bridge.Interfaces;
using TheForest.Utils.WorkSchedulerInterfaces;
using UnityEngine;

// Token: 0x020002C5 RID: 709
[Token(Token = "0x20002C5")]
public class WorkScheduler : MonoBehaviour, IWorkScheduler
{
	// Token: 0x1700021B RID: 539
	// (get) Token: 0x060012A8 RID: 4776 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700021B")]
	public static WorkScheduler Instance
	{
		[Token(Token = "0x60012A8")]
		[Address(RVA = "0x31E1C40", Offset = "0x31E0240", VA = "0x1831E1C40")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700021C RID: 540
	// (get) Token: 0x060012A9 RID: 4777 RVA: 0x00006750 File Offset: 0x00004950
	[Token(Token = "0x1700021C")]
	public static DateTime Now
	{
		[Token(Token = "0x60012A9")]
		[Address(RVA = "0x31E1C80", Offset = "0x31E0280", VA = "0x1831E1C80")]
		get
		{
			return default(DateTime);
		}
	}

	// Token: 0x060012AA RID: 4778 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012AA")]
	[Address(RVA = "0x31E1CC0", Offset = "0x31E02C0", VA = "0x1831E1CC0")]
	private void Awake()
	{
	}

	// Token: 0x060012AB RID: 4779 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012AB")]
	[Address(RVA = "0x31E22A0", Offset = "0x31E08A0", VA = "0x1831E22A0")]
	private void OnEnable()
	{
	}

	// Token: 0x060012AC RID: 4780 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012AC")]
	[Address(RVA = "0x31E2540", Offset = "0x31E0B40", VA = "0x1831E2540")]
	private void OnDisable()
	{
	}

	// Token: 0x060012AD RID: 4781 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012AD")]
	[Address(RVA = "0x31E2690", Offset = "0x31E0C90", VA = "0x1831E2690")]
	private void Update()
	{
	}

	// Token: 0x060012AE RID: 4782 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012AE")]
	[Address(RVA = "0x31E33F0", Offset = "0x31E19F0", VA = "0x1831E33F0")]
	private void QueueCleanupPosition(Vector3 newPosition)
	{
	}

	// Token: 0x060012AF RID: 4783 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012AF")]
	[Address(RVA = "0x31E3560", Offset = "0x31E1B60", VA = "0x1831E3560")]
	private void LateUpdate()
	{
	}

	// Token: 0x060012B0 RID: 4784 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012B0")]
	[Address(RVA = "0x31E35E0", Offset = "0x31E1BE0", VA = "0x1831E35E0")]
	private void OnDestroy()
	{
	}

	// Token: 0x060012B1 RID: 4785 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012B1")]
	[Address(RVA = "0x31E3610", Offset = "0x31E1C10", VA = "0x1831E3610")]
	private void SetSecondaryThreadState(WorkScheduler.ThreadStates value)
	{
	}

	// Token: 0x060012B2 RID: 4786 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012B2")]
	[Address(RVA = "0x31E37E0", Offset = "0x31E1DE0", VA = "0x1831E37E0")]
	private void GetViewerPositions(out int localIdx)
	{
	}

	// Token: 0x060012B3 RID: 4787 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012B3")]
	[Address(RVA = "0x31E3AB0", Offset = "0x31E20B0", VA = "0x1831E3AB0")]
	private static void CheckConfig()
	{
	}

	// Token: 0x060012B4 RID: 4788 RVA: 0x00006768 File Offset: 0x00004968
	[Token(Token = "0x60012B4")]
	[Address(RVA = "0x31E3D80", Offset = "0x31E2380", VA = "0x1831E3D80")]
	public static bool CheckTokenForPosition(Vector3 position, int token)
	{
		return default(bool);
	}

	// Token: 0x060012B5 RID: 4789 RVA: 0x00006780 File Offset: 0x00004980
	[Token(Token = "0x60012B5")]
	[Address(RVA = "0x31E3E50", Offset = "0x31E2450", VA = "0x1831E3E50", Slot = "5")]
	public int register(WsTask task, Vector3 position, bool skipDuplicateCheck)
	{
		return 0;
	}

	// Token: 0x060012B6 RID: 4790 RVA: 0x00006798 File Offset: 0x00004998
	[Token(Token = "0x60012B6")]
	[Address(RVA = "0x31E3F50", Offset = "0x31E2550", VA = "0x1831E3F50")]
	public static int Register(WsTask task, Vector3 position, bool skipDuplicateCheck = false)
	{
		return 0;
	}

	// Token: 0x060012B7 RID: 4791 RVA: 0x000067B0 File Offset: 0x000049B0
	[Token(Token = "0x60012B7")]
	[Address(RVA = "0x31E4080", Offset = "0x31E2680", VA = "0x1831E4080")]
	public int register(IThreadSafeTask taskObject, Vector3 position, bool skipDuplicateCheck)
	{
		return 0;
	}

	// Token: 0x060012B8 RID: 4792 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012B8")]
	[Address(RVA = "0x31E4280", Offset = "0x31E2880", VA = "0x1831E4280")]
	public void GetRegistrationBucket(Vector3 position, out int x, out int y, out int registrationBucketId)
	{
	}

	// Token: 0x060012B9 RID: 4793 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012B9")]
	[Address(RVA = "0x31E4320", Offset = "0x31E2920", VA = "0x1831E4320")]
	private void DrawProcessIndicator(Vector3 worldPos, Color processIndicatorColor)
	{
	}

	// Token: 0x060012BA RID: 4794 RVA: 0x000067C8 File Offset: 0x000049C8
	[Token(Token = "0x60012BA")]
	[Address(RVA = "0x31E4550", Offset = "0x31E2B50", VA = "0x1831E4550")]
	public static int Register(IThreadSafeTask taskObject, Vector3 position, bool skipDuplicateCheck = false)
	{
		return 0;
	}

	// Token: 0x060012BB RID: 4795 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012BB")]
	[Address(RVA = "0x31E45F0", Offset = "0x31E2BF0", VA = "0x1831E45F0", Slot = "9")]
	public void unregister(WsTask task, int token)
	{
	}

	// Token: 0x060012BC RID: 4796 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012BC")]
	[Address(RVA = "0x31E4690", Offset = "0x31E2C90", VA = "0x1831E4690")]
	public static void Unregister(WsTask task, int token)
	{
	}

	// Token: 0x060012BD RID: 4797 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012BD")]
	[Address(RVA = "0x31E4820", Offset = "0x31E2E20", VA = "0x1831E4820")]
	public void unregister(IThreadSafeTask tfTask, int token)
	{
	}

	// Token: 0x060012BE RID: 4798 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012BE")]
	[Address(RVA = "0x31E48C0", Offset = "0x31E2EC0", VA = "0x1831E48C0")]
	public static void Unregister(IThreadSafeTask tfTask, int token)
	{
	}

	// Token: 0x060012BF RID: 4799 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012BF")]
	[Address(RVA = "0x31E4A50", Offset = "0x31E3050", VA = "0x1831E4A50", Slot = "6")]
	public void registerGlobal(WsTask task, bool force)
	{
	}

	// Token: 0x060012C0 RID: 4800 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012C0")]
	[Address(RVA = "0x31E4A70", Offset = "0x31E3070", VA = "0x1831E4A70")]
	public static void RegisterGlobal(WsTask task, bool force = false)
	{
	}

	// Token: 0x060012C1 RID: 4801 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012C1")]
	[Address(RVA = "0x31E4AF0", Offset = "0x31E30F0", VA = "0x1831E4AF0", Slot = "10")]
	public void unregisterGlobal(WsTask task)
	{
	}

	// Token: 0x060012C2 RID: 4802 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012C2")]
	[Address(RVA = "0x31E4B10", Offset = "0x31E3110", VA = "0x1831E4B10")]
	public static void UnregisterGlobal(WsTask task)
	{
	}

	// Token: 0x060012C3 RID: 4803 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012C3")]
	[Address(RVA = "0x31E4C20", Offset = "0x31E3220", VA = "0x1831E4C20")]
	public static void ToggleTryCatchWork(bool onoff)
	{
	}

	// Token: 0x060012C4 RID: 4804 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012C4")]
	[Address(RVA = "0x31E4F90", Offset = "0x31E3590", VA = "0x1831E4F90", Slot = "7")]
	public void registerOneShot(WsTask task)
	{
	}

	// Token: 0x060012C5 RID: 4805 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012C5")]
	[Address(RVA = "0x31E4FC0", Offset = "0x31E35C0", VA = "0x1831E4FC0")]
	public static void RegisterOneShot(WsTask task)
	{
	}

	// Token: 0x060012C6 RID: 4806 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012C6")]
	[Address(RVA = "0x31E50D0", Offset = "0x31E36D0", VA = "0x1831E50D0", Slot = "8")]
	public void Toggle(bool onOff)
	{
	}

	// Token: 0x060012C7 RID: 4807 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012C7")]
	[Address(RVA = "0x31E5230", Offset = "0x31E3830", VA = "0x1831E5230")]
	public static void ClearInstance()
	{
	}

	// Token: 0x060012C8 RID: 4808 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012C8")]
	[Address(RVA = "0x31E5280", Offset = "0x31E3880", VA = "0x1831E5280", Slot = "4")]
	public void Clear()
	{
	}

	// Token: 0x060012C9 RID: 4809 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012C9")]
	[Address(RVA = "0x31E5340", Offset = "0x31E3940", VA = "0x1831E5340")]
	private void ThreadedUpdate()
	{
	}

	// Token: 0x060012CA RID: 4810 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012CA")]
	[Address(RVA = "0x31E5950", Offset = "0x31E3F50", VA = "0x1831E5950")]
	private void ProcessArea(Vector3 position, long remainingTicks, bool cleanup, bool mainThread = false)
	{
	}

	// Token: 0x060012CB RID: 4811 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012CB")]
	[Address(RVA = "0x31E5C00", Offset = "0x31E4200", VA = "0x1831E5C00")]
	private void ProcessSchedulerBatchFar(bool threadSafeOnly, WorkSchedulerBatch wsb, long farTicks, ref int batchedTasksFar)
	{
	}

	// Token: 0x060012CC RID: 4812 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012CC")]
	[Address(RVA = "0x31E5CF0", Offset = "0x31E42F0", VA = "0x1831E5CF0")]
	private void ProcessSchedulerBatchFarMainThread(WorkSchedulerBatch wsb)
	{
	}

	// Token: 0x060012CD RID: 4813 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012CD")]
	[Address(RVA = "0x31E5D80", Offset = "0x31E4380", VA = "0x1831E5D80")]
	private void ProcessSchedulerBatchNear(bool threadSafeOnly, WorkSchedulerBatch wsb, long nearTicks, ref int batchedTasksNear)
	{
	}

	// Token: 0x060012CE RID: 4814 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012CE")]
	[Address(RVA = "0x31E5E60", Offset = "0x31E4460", VA = "0x1831E5E60")]
	private void ProcessSchedulerBatchFarThreaded(WorkSchedulerBatch wsb, long farTicks, ref int batchedTasksFar)
	{
	}

	// Token: 0x060012CF RID: 4815 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012CF")]
	[Address(RVA = "0x31E5CF0", Offset = "0x31E42F0", VA = "0x1831E5CF0")]
	private void ProcessSchedulerBatchNearMainThread(WorkSchedulerBatch wsb)
	{
	}

	// Token: 0x060012D0 RID: 4816 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012D0")]
	[Address(RVA = "0x31E5EC0", Offset = "0x31E44C0", VA = "0x1831E5EC0")]
	private void ProcessSchedulerBatchNearThreaded(WorkSchedulerBatch wsb, long nearTicks, ref int batchedTasksNear)
	{
	}

	// Token: 0x060012D1 RID: 4817 RVA: 0x000067E0 File Offset: 0x000049E0
	[Token(Token = "0x60012D1")]
	[Address(RVA = "0x31E5F20", Offset = "0x31E4520", VA = "0x1831E5F20")]
	private int WorldToGridX(float xPosition)
	{
		return 0;
	}

	// Token: 0x060012D2 RID: 4818 RVA: 0x000067F8 File Offset: 0x000049F8
	[Token(Token = "0x60012D2")]
	[Address(RVA = "0x31E5F40", Offset = "0x31E4540", VA = "0x1831E5F40")]
	private float GridToWorldX(int xGrid)
	{
		return 0f;
	}

	// Token: 0x060012D3 RID: 4819 RVA: 0x00006810 File Offset: 0x00004A10
	[Token(Token = "0x60012D3")]
	[Address(RVA = "0x31E5F60", Offset = "0x31E4560", VA = "0x1831E5F60")]
	private int WorldToGridY(float zPosition)
	{
		return 0;
	}

	// Token: 0x060012D4 RID: 4820 RVA: 0x00006828 File Offset: 0x00004A28
	[Token(Token = "0x60012D4")]
	[Address(RVA = "0x31E5F80", Offset = "0x31E4580", VA = "0x1831E5F80")]
	private float GridToWorldY(int yGrid)
	{
		return 0f;
	}

	// Token: 0x060012D5 RID: 4821 RVA: 0x00006840 File Offset: 0x00004A40
	[Token(Token = "0x60012D5")]
	[Address(RVA = "0x31E5FA0", Offset = "0x31E45A0", VA = "0x1831E5FA0")]
	private int WorldToGridXRounded(float xPosition)
	{
		return 0;
	}

	// Token: 0x060012D6 RID: 4822 RVA: 0x00006858 File Offset: 0x00004A58
	[Token(Token = "0x60012D6")]
	[Address(RVA = "0x31E5FC0", Offset = "0x31E45C0", VA = "0x1831E5FC0")]
	private int WorldToGridYRounded(float zPosition)
	{
		return 0;
	}

	// Token: 0x060012D7 RID: 4823 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012D7")]
	[Address(RVA = "0x31E5FE0", Offset = "0x31E45E0", VA = "0x1831E5FE0")]
	private static void AddWorkScheduler()
	{
	}

	// Token: 0x060012D8 RID: 4824 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012D8")]
	[Address(RVA = "0x31E6180", Offset = "0x31E4780", VA = "0x1831E6180")]
	public WorkScheduler()
	{
	}

	// Token: 0x04001293 RID: 4755
	[Token(Token = "0x4001293")]
	[FieldOffset(Offset = "0x20")]
	[Range(0.01f, 2f)]
	public float MaxMilliseconds;

	// Token: 0x04001294 RID: 4756
	[Token(Token = "0x4001294")]
	[FieldOffset(Offset = "0x24")]
	public bool ScaleWithFPS;

	// Token: 0x04001295 RID: 4757
	[Token(Token = "0x4001295")]
	[FieldOffset(Offset = "0x28")]
	[Range(30f, 120f)]
	public float TargetFPS;

	// Token: 0x04001296 RID: 4758
	[Token(Token = "0x4001296")]
	[FieldOffset(Offset = "0x2C")]
	public int GridSize;

	// Token: 0x04001297 RID: 4759
	[Token(Token = "0x4001297")]
	[FieldOffset(Offset = "0x30")]
	public float GridWorldSize;

	// Token: 0x04001298 RID: 4760
	[Token(Token = "0x4001298")]
	[FieldOffset(Offset = "0x34")]
	[Header("Stats")]
	public float DelayWithPreviousUpdate;

	// Token: 0x04001299 RID: 4761
	[Token(Token = "0x4001299")]
	[FieldOffset(Offset = "0x38")]
	public float ThreadedUpdateDuration;

	// Token: 0x0400129A RID: 4762
	[Token(Token = "0x400129A")]
	[FieldOffset(Offset = "0x3C")]
	public float ThreadedCleanupDuration;

	// Token: 0x0400129B RID: 4763
	[Token(Token = "0x400129B")]
	[FieldOffset(Offset = "0x40")]
	[Header("Gizmos")]
	public bool ShowGrid;

	// Token: 0x0400129C RID: 4764
	[Token(Token = "0x400129C")]
	[FieldOffset(Offset = "0x44")]
	public float MaxDistance;

	// Token: 0x0400129D RID: 4765
	[Token(Token = "0x400129D")]
	[FieldOffset(Offset = "0x48")]
	public float Size;

	// Token: 0x0400129E RID: 4766
	[Token(Token = "0x400129E")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private int _processAreaSize;

	// Token: 0x0400129F RID: 4767
	[Token(Token = "0x400129F")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private int _nearRange;

	// Token: 0x040012A0 RID: 4768
	[Token(Token = "0x40012A0")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	private float _fullCycleTriggerDistanceMultiplier;

	// Token: 0x040012A1 RID: 4769
	[Token(Token = "0x40012A1")]
	[FieldOffset(Offset = "0x58")]
	private bool _debugForceServer;

	// Token: 0x040012A2 RID: 4770
	[Token(Token = "0x40012A2")]
	[FieldOffset(Offset = "0x60")]
	private WorkSchedulerBatch[,] schedulers;

	// Token: 0x040012A3 RID: 4771
	[Token(Token = "0x40012A3")]
	[FieldOffset(Offset = "0x68")]
	private WorkSchedulerBatch globalScheduler;

	// Token: 0x040012A4 RID: 4772
	[Token(Token = "0x40012A4")]
	[FieldOffset(Offset = "0x70")]
	private WorkSchedulerBatch oneShotScheduler;

	// Token: 0x040012A5 RID: 4773
	[Token(Token = "0x40012A5")]
	[FieldOffset(Offset = "0x78")]
	private Stopwatch stopwatch;

	// Token: 0x040012A6 RID: 4774
	[Token(Token = "0x40012A6")]
	[FieldOffset(Offset = "0x80")]
	private float fps;

	// Token: 0x040012A7 RID: 4775
	[Token(Token = "0x40012A7")]
	[FieldOffset(Offset = "0x84")]
	private float currentQuality;

	// Token: 0x040012A8 RID: 4776
	[Token(Token = "0x40012A8")]
	[FieldOffset(Offset = "0x88")]
	private float xOffset;

	// Token: 0x040012A9 RID: 4777
	[Token(Token = "0x40012A9")]
	[FieldOffset(Offset = "0x8C")]
	private float yOffset;

	// Token: 0x040012AA RID: 4778
	[Token(Token = "0x40012AA")]
	[FieldOffset(Offset = "0x90")]
	private int currentFrame;

	// Token: 0x040012AB RID: 4779
	[Token(Token = "0x40012AB")]
	[FieldOffset(Offset = "0x94")]
	private int currentThreadFrame;

	// Token: 0x040012AC RID: 4780
	[Token(Token = "0x40012AC")]
	[FieldOffset(Offset = "0x98")]
	private Vector3 _previousPosition;

	// Token: 0x040012AD RID: 4781
	[Token(Token = "0x40012AD")]
	[FieldOffset(Offset = "0xA4")]
	private WorkScheduler.ThreadStates secondaryThreadState;

	// Token: 0x040012AE RID: 4782
	[Token(Token = "0x40012AE")]
	[FieldOffset(Offset = "0xA8")]
	private Thread thread;

	// Token: 0x040012AF RID: 4783
	[Token(Token = "0x40012AF")]
	[FieldOffset(Offset = "0xB0")]
	private bool mainThreadUpdating;

	// Token: 0x040012B0 RID: 4784
	[Token(Token = "0x40012B0")]
	[FieldOffset(Offset = "0xB1")]
	private bool secondaryThreadUpdating;

	// Token: 0x040012B1 RID: 4785
	[Token(Token = "0x40012B1")]
	[FieldOffset(Offset = "0xB4")]
	private Vector3 _activeWorldPosition;

	// Token: 0x040012B2 RID: 4786
	[Token(Token = "0x40012B2")]
	[FieldOffset(Offset = "0xC0")]
	private ManualResetEvent mutex;

	// Token: 0x040012B3 RID: 4787
	[Token(Token = "0x40012B3")]
	[FieldOffset(Offset = "0x0")]
	private static WorkScheduler _instance;

	// Token: 0x040012B4 RID: 4788
	[Token(Token = "0x40012B4")]
	[FieldOffset(Offset = "0x8")]
	private static bool configWarningIssued;

	// Token: 0x040012B5 RID: 4789
	[Token(Token = "0x40012B5")]
	[FieldOffset(Offset = "0x9")]
	public static bool Paused;

	// Token: 0x040012B6 RID: 4790
	[Token(Token = "0x40012B6")]
	[FieldOffset(Offset = "0xA")]
	public static bool ShouldStartCleanup;

	// Token: 0x040012B7 RID: 4791
	[Token(Token = "0x40012B7")]
	[FieldOffset(Offset = "0xB")]
	public static bool CleanUp;

	// Token: 0x040012B8 RID: 4792
	[Token(Token = "0x40012B8")]
	[FieldOffset(Offset = "0xC")]
	public static float CurrentTime;

	// Token: 0x040012B9 RID: 4793
	[Token(Token = "0x40012B9")]
	[FieldOffset(Offset = "0xC8")]
	private List<WorkSchedulerBatch> _previousSchedulers;

	// Token: 0x040012BA RID: 4794
	[Token(Token = "0x40012BA")]
	[FieldOffset(Offset = "0xD0")]
	private List<WorkSchedulerBatch> _currentSchedulers;

	// Token: 0x040012BB RID: 4795
	[Token(Token = "0x40012BB")]
	[FieldOffset(Offset = "0x10")]
	private static DateTime _nowCachedValue;

	// Token: 0x040012BC RID: 4796
	[Token(Token = "0x40012BC")]
	[FieldOffset(Offset = "0xD8")]
	private readonly List<Vector3> _viewerPositions;

	// Token: 0x040012BD RID: 4797
	[Token(Token = "0x40012BD")]
	[FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private bool _createProcessIndicators;

	// Token: 0x040012BE RID: 4798
	[Token(Token = "0x40012BE")]
	[FieldOffset(Offset = "0xE4")]
	[SerializeField]
	private Color _processIndicatorNearColor;

	// Token: 0x040012BF RID: 4799
	[Token(Token = "0x40012BF")]
	[FieldOffset(Offset = "0xF4")]
	[SerializeField]
	private Color _processIndicatorFarColor;

	// Token: 0x040012C0 RID: 4800
	[Token(Token = "0x40012C0")]
	[FieldOffset(Offset = "0x104")]
	[SerializeField]
	private float _processIndicatorDuration;

	// Token: 0x040012C1 RID: 4801
	[Token(Token = "0x40012C1")]
	[FieldOffset(Offset = "0x108")]
	private List<Vector3> _cleanupPositionQueue;

	// Token: 0x040012C2 RID: 4802
	[Token(Token = "0x40012C2")]
	[FieldOffset(Offset = "0x110")]
	private Vector3 _cleanupPosition;

	// Token: 0x040012C3 RID: 4803
	[Token(Token = "0x40012C3")]
	[FieldOffset(Offset = "0x120")]
	private readonly object lockObj;

	// Token: 0x020002C6 RID: 710
	[Token(Token = "0x20002C6")]
	public enum ThreadStates
	{
		// Token: 0x040012C5 RID: 4805
		[Token(Token = "0x40012C5")]
		Idle,
		// Token: 0x040012C6 RID: 4806
		[Token(Token = "0x40012C6")]
		Running,
		// Token: 0x040012C7 RID: 4807
		[Token(Token = "0x40012C7")]
		Paused,
		// Token: 0x040012C8 RID: 4808
		[Token(Token = "0x40012C8")]
		Closing
	}
}
