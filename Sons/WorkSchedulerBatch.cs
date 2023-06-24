using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TheForest.Commons.Delegates;
using TheForest.Utils.WorkSchedulerInterfaces;

// Token: 0x020002C7 RID: 711
[Token(Token = "0x20002C7")]
public class WorkSchedulerBatch
{
	// Token: 0x1700021D RID: 541
	// (get) Token: 0x060012D9 RID: 4825 RVA: 0x00006870 File Offset: 0x00004A70
	// (set) Token: 0x060012DA RID: 4826 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700021D")]
	public int LastThreadRefreshFrame
	{
		[Token(Token = "0x60012D9")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[Token(Token = "0x60012DA")]
		[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x1700021E RID: 542
	// (get) Token: 0x060012DB RID: 4827 RVA: 0x00006888 File Offset: 0x00004A88
	// (set) Token: 0x060012DC RID: 4828 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700021E")]
	public int LastNearRefreshFrame
	{
		[Token(Token = "0x60012DB")]
		[Address(RVA = "0x66F500", Offset = "0x66DB00", VA = "0x18066F500")]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[Token(Token = "0x60012DC")]
		[Address(RVA = "0x66F510", Offset = "0x66DB10", VA = "0x18066F510")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x1700021F RID: 543
	// (get) Token: 0x060012DD RID: 4829 RVA: 0x000068A0 File Offset: 0x00004AA0
	// (set) Token: 0x060012DE RID: 4830 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700021F")]
	public int LastFarRefreshFrame
	{
		[Token(Token = "0x60012DD")]
		[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[Token(Token = "0x60012DE")]
		[Address(RVA = "0x6DDE70", Offset = "0x6DC470", VA = "0x1806DDE70")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000220 RID: 544
	// (get) Token: 0x060012DF RID: 4831 RVA: 0x000068B8 File Offset: 0x00004AB8
	[Token(Token = "0x17000220")]
	public int WorkUnityCount
	{
		[Token(Token = "0x60012DF")]
		[Address(RVA = "0x31E6490", Offset = "0x31E4A90", VA = "0x1831E6490")]
		get
		{
			return 0;
		}
	}

	// Token: 0x060012E0 RID: 4832 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012E0")]
	[Address(RVA = "0x31E64D0", Offset = "0x31E4AD0", VA = "0x1831E64D0")]
	public WorkSchedulerBatch()
	{
	}

	// Token: 0x060012E1 RID: 4833 RVA: 0x000068D0 File Offset: 0x00004AD0
	[Token(Token = "0x60012E1")]
	[Address(RVA = "0x31E6830", Offset = "0x31E4E30", VA = "0x1831E6830")]
	public bool Contains(WsTask task)
	{
		return default(bool);
	}

	// Token: 0x060012E2 RID: 4834 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012E2")]
	[Address(RVA = "0x31E6880", Offset = "0x31E4E80", VA = "0x1831E6880")]
	public void Register(WsTask task, bool skipDuplicateCheck = false)
	{
	}

	// Token: 0x060012E3 RID: 4835 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012E3")]
	[Address(RVA = "0x31E6950", Offset = "0x31E4F50", VA = "0x1831E6950")]
	public void Register(IThreadSafeTask taskObject, bool skipDuplicateCheck = false)
	{
	}

	// Token: 0x060012E4 RID: 4836 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012E4")]
	[Address(RVA = "0x31E6A90", Offset = "0x31E5090", VA = "0x1831E6A90")]
	public void Unregister(WsTask task)
	{
	}

	// Token: 0x060012E5 RID: 4837 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012E5")]
	[Address(RVA = "0x31E6B20", Offset = "0x31E5120", VA = "0x1831E6B20")]
	public void Unregister(IThreadSafeTask tfTask)
	{
	}

	// Token: 0x060012E6 RID: 4838 RVA: 0x000068E8 File Offset: 0x00004AE8
	[Token(Token = "0x60012E6")]
	[Address(RVA = "0x31E6C60", Offset = "0x31E5260", VA = "0x1831E6C60")]
	public int DoWorkTryCatch(long maxTicks, bool autoUnregister = false)
	{
		return 0;
	}

	// Token: 0x060012E7 RID: 4839 RVA: 0x00006900 File Offset: 0x00004B00
	[Token(Token = "0x60012E7")]
	[Address(RVA = "0x31E7110", Offset = "0x31E5710", VA = "0x1831E7110")]
	public int DoWorkNoTry(long maxTicks, bool autoUnregister = false)
	{
		return 0;
	}

	// Token: 0x060012E8 RID: 4840 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012E8")]
	[Address(RVA = "0x31E7540", Offset = "0x31E5B40", VA = "0x1831E7540")]
	public void DoThreadSafeWorkTryCatch(bool autoUnregister = false)
	{
	}

	// Token: 0x060012E9 RID: 4841 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012E9")]
	[Address(RVA = "0x31E75E0", Offset = "0x31E5BE0", VA = "0x1831E75E0")]
	private void CheckTaskChanged(int tasksProcessed)
	{
	}

	// Token: 0x060012EA RID: 4842 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60012EA")]
	[Address(RVA = "0x31E77F0", Offset = "0x31E5DF0", VA = "0x1831E77F0")]
	public void Clear()
	{
	}

	// Token: 0x040012C9 RID: 4809
	[Token(Token = "0x40012C9")]
	[FieldOffset(Offset = "0x0")]
	public static bool MainThreadUpdating;

	// Token: 0x040012CD RID: 4813
	[Token(Token = "0x40012CD")]
	[FieldOffset(Offset = "0x20")]
	private List<WsTask> tasks;

	// Token: 0x040012CE RID: 4814
	[Token(Token = "0x40012CE")]
	[FieldOffset(Offset = "0x28")]
	private List<IThreadSafeTask> tfTasks;

	// Token: 0x040012CF RID: 4815
	[Token(Token = "0x40012CF")]
	[FieldOffset(Offset = "0x30")]
	private List<IThreadSafeTask> tfTasksChanged;

	// Token: 0x040012D0 RID: 4816
	[Token(Token = "0x40012D0")]
	[FieldOffset(Offset = "0x38")]
	private int iterator;

	// Token: 0x040012D1 RID: 4817
	[Token(Token = "0x40012D1")]
	[FieldOffset(Offset = "0x40")]
	private Stopwatch stopwatch;

	// Token: 0x040012D2 RID: 4818
	[Token(Token = "0x40012D2")]
	[FieldOffset(Offset = "0x48")]
	public WorkSchedulerBatch.DoWorkDelegate DoWork;

	// Token: 0x040012D3 RID: 4819
	[Token(Token = "0x40012D3")]
	[FieldOffset(Offset = "0x50")]
	private string _checkTaskChangedName;

	// Token: 0x020002C8 RID: 712
	// (Invoke) Token: 0x060012EC RID: 4844
	[Token(Token = "0x20002C8")]
	public delegate int DoWorkDelegate(long maxTicks, bool autoUnregister = false);
}
