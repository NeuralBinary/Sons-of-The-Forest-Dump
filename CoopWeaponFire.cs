using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000DA RID: 218
[Token(Token = "0x20000DA")]
public class CoopWeaponFire : EntityBehaviour<IFireParticle>
{
	// Token: 0x06000663 RID: 1635 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000663")]
	[Address(RVA = "0x2E835D0", Offset = "0x2E825D0", VA = "0x182E835D0", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x06000664 RID: 1636 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000664")]
	[Address(RVA = "0x2E83710", Offset = "0x2E82710", VA = "0x182E83710")]
	private void setFireTimeout()
	{
	}

	// Token: 0x06000665 RID: 1637 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000665")]
	[Address(RVA = "0x2E836D0", Offset = "0x2E826D0", VA = "0x182E836D0")]
	public CoopWeaponFire()
	{
	}

	// Token: 0x0400056B RID: 1387
	[Token(Token = "0x400056B")]
	[FieldOffset(Offset = "0x28")]
	public Transform spawnedFireTransform;

	// Token: 0x0400056C RID: 1388
	[Token(Token = "0x400056C")]
	[FieldOffset(Offset = "0x30")]
	private bool doFireTimeout;
}
