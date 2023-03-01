using System;
using System.Collections;
using Il2CppDummyDll;
using Steamworks;
using UnityEngine;

// Token: 0x0200021D RID: 541
[Token(Token = "0x200021D")]
public class AutoJoinDedicatedServer : MonoBehaviour
{
	// Token: 0x06000E36 RID: 3638 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000E36")]
	[Address(RVA = "0x2F91500", Offset = "0x2F90500", VA = "0x182F91500")]
	private IEnumerator Start()
	{
		return null;
	}

	// Token: 0x06000E37 RID: 3639 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E37")]
	[Address(RVA = "0x2F91400", Offset = "0x2F90400", VA = "0x182F91400")]
	private void OnGameServerChangeRequested(GameServerChangeRequested_t param)
	{
	}

	// Token: 0x06000E38 RID: 3640 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E38")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public AutoJoinDedicatedServer()
	{
	}

	// Token: 0x04000D4C RID: 3404
	[Token(Token = "0x4000D4C")]
	[FieldOffset(Offset = "0x0")]
	public static bool AutoStartAfterDelay;

	// Token: 0x04000D4D RID: 3405
	[Token(Token = "0x4000D4D")]
	[FieldOffset(Offset = "0x20")]
	private Callback<GameServerChangeRequested_t> GameServerChangeRequested;
}
