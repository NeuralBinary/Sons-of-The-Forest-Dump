using System;
using Il2CppDummyDll;
using Sons.Atmosphere;
using UnityEngine;

// Token: 0x02000058 RID: 88
[Token(Token = "0x2000058")]
public class TreeHitByLightning : LightningTarget
{
	// Token: 0x0600028F RID: 655 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600028F")]
	[Address(RVA = "0x31B2E30", Offset = "0x31B1430", VA = "0x1831B2E30", Slot = "8")]
	public override void LightningHit()
	{
	}

	// Token: 0x06000290 RID: 656 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000290")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public TreeHitByLightning()
	{
	}

	// Token: 0x0400027A RID: 634
	[Token(Token = "0x400027A")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject _explosionPrefab;
}
