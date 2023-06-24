using System;
using System.Collections;
using Il2CppDummyDll;
using Steamworks;
using UnityEngine;

// Token: 0x0200021C RID: 540
[Token(Token = "0x200021C")]
public class AutoJoinDedicatedServer : MonoBehaviour
{
	// Token: 0x06000E91 RID: 3729 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E91")]
	[Address(RVA = "0x371A160", Offset = "0x3718760", VA = "0x18371A160")]
	private IEnumerator Start()
	{
		return null;
	}

	// Token: 0x06000E92 RID: 3730 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E92")]
	[Address(RVA = "0x371A1A0", Offset = "0x37187A0", VA = "0x18371A1A0")]
	private void OnGameServerChangeRequested(GameServerChangeRequested_t param)
	{
	}

	// Token: 0x06000E93 RID: 3731 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E93")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public AutoJoinDedicatedServer()
	{
	}

	// Token: 0x04000D7B RID: 3451
	[Token(Token = "0x4000D7B")]
	[FieldOffset(Offset = "0x0")]
	public static bool AutoStartAfterDelay;

	// Token: 0x04000D7C RID: 3452
	[Token(Token = "0x4000D7C")]
	[FieldOffset(Offset = "0x20")]
	private Callback<GameServerChangeRequested_t> GameServerChangeRequested;
}
