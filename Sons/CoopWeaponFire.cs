using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000D8 RID: 216
[Token(Token = "0x20000D8")]
public class CoopWeaponFire : EntityBehaviour<IFireParticle>
{
	// Token: 0x060006AD RID: 1709 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006AD")]
	[Address(RVA = "0x3522380", Offset = "0x3520980", VA = "0x183522380", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x060006AE RID: 1710 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006AE")]
	[Address(RVA = "0x3522540", Offset = "0x3520B40", VA = "0x183522540")]
	private void setFireTimeout()
	{
	}

	// Token: 0x060006AF RID: 1711 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006AF")]
	[Address(RVA = "0x3522640", Offset = "0x3520C40", VA = "0x183522640")]
	public CoopWeaponFire()
	{
	}

	// Token: 0x04000588 RID: 1416
	[Token(Token = "0x4000588")]
	[FieldOffset(Offset = "0x28")]
	public Transform spawnedFireTransform;

	// Token: 0x04000589 RID: 1417
	[Token(Token = "0x4000589")]
	[FieldOffset(Offset = "0x30")]
	private bool doFireTimeout;
}
