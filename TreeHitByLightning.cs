using System;
using Il2CppDummyDll;
using Sons.Atmosphere;
using UnityEngine;

// Token: 0x02000057 RID: 87
[Token(Token = "0x2000057")]
public class TreeHitByLightning : LightningTarget
{
	// Token: 0x06000272 RID: 626 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000272")]
	[Address(RVA = "0x2B81390", Offset = "0x2B80390", VA = "0x182B81390", Slot = "8")]
	public override void LightningHit()
	{
	}

	// Token: 0x06000273 RID: 627 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000273")]
	[Address(RVA = "0x59FF50", Offset = "0x59EF50", VA = "0x18059FF50")]
	public TreeHitByLightning()
	{
	}

	// Token: 0x0400024E RID: 590
	[Token(Token = "0x400024E")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject _explosionPrefab;
}
