using System;
using System.Collections.Generic;
using System.Threading;
using FMOD.Studio;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x020001F8 RID: 504
[Token(Token = "0x20001F8")]
public class FocusLostAudio : MonoBehaviour
{
	// Token: 0x06000E20 RID: 3616 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E20")]
	[Address(RVA = "0x37123E0", Offset = "0x37109E0", VA = "0x1837123E0")]
	private void OnEnable()
	{
	}

	// Token: 0x06000E21 RID: 3617 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E21")]
	[Address(RVA = "0x3712480", Offset = "0x3710A80", VA = "0x183712480")]
	private void OnApplicationFocus(bool focused)
	{
	}

	// Token: 0x06000E22 RID: 3618 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E22")]
	[Address(RVA = "0x37124B0", Offset = "0x3710AB0", VA = "0x1837124B0")]
	private void Initialize()
	{
	}

	// Token: 0x06000E23 RID: 3619 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E23")]
	[Address(RVA = "0x37127C0", Offset = "0x3710DC0", VA = "0x1837127C0")]
	private void OnDisable()
	{
	}

	// Token: 0x06000E24 RID: 3620 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E24")]
	[Address(RVA = "0x3712860", Offset = "0x3710E60", VA = "0x183712860")]
	private void IssueCommand(FocusLostAudio.Command command)
	{
	}

	// Token: 0x06000E25 RID: 3621 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E25")]
	[Address(RVA = "0x3712B10", Offset = "0x3711110", VA = "0x183712B10")]
	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	// Token: 0x06000E26 RID: 3622 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E26")]
	[Address(RVA = "0x3712C50", Offset = "0x3711250", VA = "0x183712C50")]
	private void WorkerThreadRun()
	{
	}

	// Token: 0x06000E27 RID: 3623 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E27")]
	[Address(RVA = "0x3712F10", Offset = "0x3711510", VA = "0x183712F10")]
	private void EnableSnapshot()
	{
	}

	// Token: 0x06000E28 RID: 3624 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E28")]
	[Address(RVA = "0x3712FD0", Offset = "0x37115D0", VA = "0x183712FD0")]
	private void DisableSnapshot()
	{
	}

	// Token: 0x06000E29 RID: 3625 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E29")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public FocusLostAudio()
	{
	}

	// Token: 0x04000D0E RID: 3342
	[Token(Token = "0x4000D0E")]
	[FieldOffset(Offset = "0x20")]
	private bool _initialized;

	// Token: 0x04000D0F RID: 3343
	[Token(Token = "0x4000D0F")]
	[FieldOffset(Offset = "0x28")]
	private List<FocusLostAudio.Command> commandQueue;

	// Token: 0x04000D10 RID: 3344
	[Token(Token = "0x4000D10")]
	[FieldOffset(Offset = "0x30")]
	private Thread workerThread;

	// Token: 0x04000D11 RID: 3345
	[Token(Token = "0x4000D11")]
	[FieldOffset(Offset = "0x38")]
	private EventInstance snapshotInstance;

	// Token: 0x04000D12 RID: 3346
	[Token(Token = "0x4000D12")]
	[FieldOffset(Offset = "0x40")]
	private bool destroyOnTitleSceneLoad;

	// Token: 0x020001F9 RID: 505
	[Token(Token = "0x20001F9")]
	private enum Command
	{
		// Token: 0x04000D14 RID: 3348
		[Token(Token = "0x4000D14")]
		EnableSnapshot,
		// Token: 0x04000D15 RID: 3349
		[Token(Token = "0x4000D15")]
		DisableSnapshot,
		// Token: 0x04000D16 RID: 3350
		[Token(Token = "0x4000D16")]
		Shutdown
	}
}
