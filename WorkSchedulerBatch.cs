using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TheForest.Commons.Delegates;
using TheForest.Utils.WorkSchedulerInterfaces;

// Token: 0x020002D3 RID: 723
[Token(Token = "0x20002D3")]
public class WorkSchedulerBatch
{
	// Token: 0x17000214 RID: 532
	// (get) Token: 0x060012A4 RID: 4772 RVA: 0x00006600 File Offset: 0x00004800
	// (set) Token: 0x060012A5 RID: 4773 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000214")]
	public int LastThreadRefreshFrame
	{
		[Token(Token = "0x60012A4")]
		[Address(RVA = "0x55E9A0", Offset = "0x55D9A0", VA = "0x18055E9A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60012A5")]
		[Address(RVA = "0x6A2410", Offset = "0x6A1410", VA = "0x1806A2410")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000215 RID: 533
	// (get) Token: 0x060012A6 RID: 4774 RVA: 0x00006618 File Offset: 0x00004818
	// (set) Token: 0x060012A7 RID: 4775 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000215")]
	public int LastNearRefreshFrame
	{
		[Token(Token = "0x60012A6")]
		[Address(RVA = "0x5D9490", Offset = "0x5D8490", VA = "0x1805D9490")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60012A7")]
		[Address(RVA = "0x5D9550", Offset = "0x5D8550", VA = "0x1805D9550")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000216 RID: 534
	// (get) Token: 0x060012A8 RID: 4776 RVA: 0x00006630 File Offset: 0x00004830
	// (set) Token: 0x060012A9 RID: 4777 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000216")]
	public int LastFarRefreshFrame
	{
		[Token(Token = "0x60012A8")]
		[Address(RVA = "0x5D9500", Offset = "0x5D8500", VA = "0x1805D9500")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60012A9")]
		[Address(RVA = "0x64A100", Offset = "0x649100", VA = "0x18064A100")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000217 RID: 535
	// (get) Token: 0x060012AA RID: 4778 RVA: 0x00006648 File Offset: 0x00004848
	[Token(Token = "0x17000217")]
	public int WorkUnityCount
	{
		[Token(Token = "0x60012AA")]
		[Address(RVA = "0x2B94D50", Offset = "0x2B93D50", VA = "0x182B94D50")]
		get
		{
			return default(int);
		}
	}

	// Token: 0x060012AB RID: 4779 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012AB")]
	[Address(RVA = "0x2B94B60", Offset = "0x2B93B60", VA = "0x182B94B60")]
	public WorkSchedulerBatch()
	{
	}

	// Token: 0x060012AC RID: 4780 RVA: 0x00006660 File Offset: 0x00004860
	[Token(Token = "0x60012AC")]
	[Address(RVA = "0x2B94080", Offset = "0x2B93080", VA = "0x182B94080")]
	public bool Contains(WsTask task)
	{
		return default(bool);
	}

	// Token: 0x060012AD RID: 4781 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012AD")]
	[Address(RVA = "0x2B948A0", Offset = "0x2B938A0", VA = "0x182B948A0")]
	public void Register(WsTask task, bool skipDuplicateCheck = false)
	{
	}

	// Token: 0x060012AE RID: 4782 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012AE")]
	[Address(RVA = "0x2B94790", Offset = "0x2B93790", VA = "0x182B94790")]
	public void Register(IThreadSafeTask taskObject, bool skipDuplicateCheck = false)
	{
	}

	// Token: 0x060012AF RID: 4783 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012AF")]
	[Address(RVA = "0x2B94990", Offset = "0x2B93990", VA = "0x182B94990")]
	public void Unregister(WsTask task)
	{
	}

	// Token: 0x060012B0 RID: 4784 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012B0")]
	[Address(RVA = "0x2B94A20", Offset = "0x2B93A20", VA = "0x182B94A20")]
	public void Unregister(IThreadSafeTask tfTask)
	{
	}

	// Token: 0x060012B1 RID: 4785 RVA: 0x00006678 File Offset: 0x00004878
	[Token(Token = "0x60012B1")]
	[Address(RVA = "0x2B94470", Offset = "0x2B93470", VA = "0x182B94470")]
	public int DoWorkTryCatch(long maxTicks, bool autoUnregister = false)
	{
		return default(int);
	}

	// Token: 0x060012B2 RID: 4786 RVA: 0x00006690 File Offset: 0x00004890
	[Token(Token = "0x60012B2")]
	[Address(RVA = "0x2B94180", Offset = "0x2B93180", VA = "0x182B94180")]
	public int DoWorkNoTry(long maxTicks, bool autoUnregister = false)
	{
		return default(int);
	}

	// Token: 0x060012B3 RID: 4787 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012B3")]
	[Address(RVA = "0x2B940E0", Offset = "0x2B930E0", VA = "0x182B940E0")]
	public void DoThreadSafeWorkTryCatch(bool autoUnregister = false)
	{
	}

	// Token: 0x060012B4 RID: 4788 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012B4")]
	[Address(RVA = "0x2B93E20", Offset = "0x2B92E20", VA = "0x182B93E20")]
	private void CheckTaskChanged(int tasksProcessed)
	{
	}

	// Token: 0x060012B5 RID: 4789 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012B5")]
	[Address(RVA = "0x2B93FB0", Offset = "0x2B92FB0", VA = "0x182B93FB0")]
	public void Clear()
	{
	}

	// Token: 0x040012A2 RID: 4770
	[Token(Token = "0x40012A2")]
	[FieldOffset(Offset = "0x0")]
	public static bool MainThreadUpdating;

	// Token: 0x040012A6 RID: 4774
	[Token(Token = "0x40012A6")]
	[FieldOffset(Offset = "0x20")]
	private List<WsTask> tasks;

	// Token: 0x040012A7 RID: 4775
	[Token(Token = "0x40012A7")]
	[FieldOffset(Offset = "0x28")]
	private List<IThreadSafeTask> tfTasks;

	// Token: 0x040012A8 RID: 4776
	[Token(Token = "0x40012A8")]
	[FieldOffset(Offset = "0x30")]
	private List<IThreadSafeTask> tfTasksChanged;

	// Token: 0x040012A9 RID: 4777
	[Token(Token = "0x40012A9")]
	[FieldOffset(Offset = "0x38")]
	private int iterator;

	// Token: 0x040012AA RID: 4778
	[Token(Token = "0x40012AA")]
	[FieldOffset(Offset = "0x40")]
	private Stopwatch stopwatch;

	// Token: 0x040012AB RID: 4779
	[Token(Token = "0x40012AB")]
	[FieldOffset(Offset = "0x48")]
	public WorkSchedulerBatch.DoWorkDelegate DoWork;

	// Token: 0x040012AC RID: 4780
	[Token(Token = "0x40012AC")]
	[FieldOffset(Offset = "0x50")]
	private string _checkTaskChangedName;

	// Token: 0x020002D4 RID: 724
	// (Invoke) Token: 0x060012B7 RID: 4791
	[Token(Token = "0x20002D4")]
	public delegate int DoWorkDelegate(long maxTicks, bool autoUnregister = false);
}
