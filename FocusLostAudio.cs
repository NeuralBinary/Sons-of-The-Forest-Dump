using System;
using System.Collections.Generic;
using System.Threading;
using FMOD.Studio;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x020001F9 RID: 505
[Token(Token = "0x20001F9")]
public class FocusLostAudio : MonoBehaviour
{
	// Token: 0x06000DC5 RID: 3525 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DC5")]
	[Address(RVA = "0x2F88E50", Offset = "0x2F87E50", VA = "0x182F88E50")]
	private void OnEnable()
	{
	}

	// Token: 0x06000DC6 RID: 3526 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DC6")]
	[Address(RVA = "0x2F88D80", Offset = "0x2F87D80", VA = "0x182F88D80")]
	private void OnApplicationFocus(bool focused)
	{
	}

	// Token: 0x06000DC7 RID: 3527 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DC7")]
	[Address(RVA = "0x2F88AF0", Offset = "0x2F87AF0", VA = "0x182F88AF0")]
	private void Initialize()
	{
	}

	// Token: 0x06000DC8 RID: 3528 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DC8")]
	[Address(RVA = "0x2F88DB0", Offset = "0x2F87DB0", VA = "0x182F88DB0")]
	private void OnDisable()
	{
	}

	// Token: 0x06000DC9 RID: 3529 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DC9")]
	[Address(RVA = "0x2F88C60", Offset = "0x2F87C60", VA = "0x182F88C60")]
	private void IssueCommand(FocusLostAudio.Command command)
	{
	}

	// Token: 0x06000DCA RID: 3530 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DCA")]
	[Address(RVA = "0x2F88EF0", Offset = "0x2F87EF0", VA = "0x182F88EF0")]
	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	// Token: 0x06000DCB RID: 3531 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DCB")]
	[Address(RVA = "0x2F88F90", Offset = "0x2F87F90", VA = "0x182F88F90")]
	private void WorkerThreadRun()
	{
	}

	// Token: 0x06000DCC RID: 3532 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DCC")]
	[Address(RVA = "0x2F88A30", Offset = "0x2F87A30", VA = "0x182F88A30")]
	private void EnableSnapshot()
	{
	}

	// Token: 0x06000DCD RID: 3533 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DCD")]
	[Address(RVA = "0x2F889E0", Offset = "0x2F879E0", VA = "0x182F889E0")]
	private void DisableSnapshot()
	{
	}

	// Token: 0x06000DCE RID: 3534 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DCE")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public FocusLostAudio()
	{
	}

	// Token: 0x04000CDF RID: 3295
	[Token(Token = "0x4000CDF")]
	[FieldOffset(Offset = "0x20")]
	private bool _initialized;

	// Token: 0x04000CE0 RID: 3296
	[Token(Token = "0x4000CE0")]
	[FieldOffset(Offset = "0x28")]
	private List<FocusLostAudio.Command> commandQueue;

	// Token: 0x04000CE1 RID: 3297
	[Token(Token = "0x4000CE1")]
	[FieldOffset(Offset = "0x30")]
	private Thread workerThread;

	// Token: 0x04000CE2 RID: 3298
	[Token(Token = "0x4000CE2")]
	[FieldOffset(Offset = "0x38")]
	private EventInstance snapshotInstance;

	// Token: 0x04000CE3 RID: 3299
	[Token(Token = "0x4000CE3")]
	[FieldOffset(Offset = "0x40")]
	private bool destroyOnTitleSceneLoad;

	// Token: 0x020001FA RID: 506
	[Token(Token = "0x20001FA")]
	private enum Command
	{
		// Token: 0x04000CE5 RID: 3301
		[Token(Token = "0x4000CE5")]
		EnableSnapshot,
		// Token: 0x04000CE6 RID: 3302
		[Token(Token = "0x4000CE6")]
		DisableSnapshot,
		// Token: 0x04000CE7 RID: 3303
		[Token(Token = "0x4000CE7")]
		Shutdown
	}
}
