using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using PathologicalGames;
using UnityEngine;

// Token: 0x020002E2 RID: 738
[Token(Token = "0x20002E2")]
public class DemoTurret : MonoBehaviour
{
	// Token: 0x06001360 RID: 4960 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001360")]
	[Address(RVA = "0x31F4A60", Offset = "0x31F3060", VA = "0x1831F4A60")]
	private void Awake()
	{
	}

	// Token: 0x06001361 RID: 4961 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001361")]
	[Address(RVA = "0x31F4B50", Offset = "0x31F3150", VA = "0x1831F4B50")]
	private void OnTargetUpdateDel(List<Target> targets)
	{
	}

	// Token: 0x06001362 RID: 4962 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001362")]
	[Address(RVA = "0x31F4CC0", Offset = "0x31F32C0", VA = "0x1831F4CC0")]
	private void OnTargetIdleUpdateDel()
	{
	}

	// Token: 0x06001363 RID: 4963 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001363")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public DemoTurret()
	{
	}

	// Token: 0x0400133C RID: 4924
	[Token(Token = "0x400133C")]
	[FieldOffset(Offset = "0x20")]
	public SmoothLookAtConstraint turretY;

	// Token: 0x0400133D RID: 4925
	[Token(Token = "0x400133D")]
	[FieldOffset(Offset = "0x28")]
	public SmoothLookAtConstraint turretX;
}
