using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001F6 RID: 502
[Token(Token = "0x20001F6")]
public class FlareWeapon : EntityBehaviour
{
	// Token: 0x06000E18 RID: 3608 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E18")]
	[Address(RVA = "0x3711D60", Offset = "0x3710360", VA = "0x183711D60")]
	private void Awake()
	{
	}

	// Token: 0x06000E19 RID: 3609 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E19")]
	[Address(RVA = "0x3711E60", Offset = "0x3710460", VA = "0x183711E60")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	// Token: 0x06000E1A RID: 3610 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E1A")]
	[Address(RVA = "0x3711F70", Offset = "0x3710570", VA = "0x183711F70")]
	private void TurnOn()
	{
	}

	// Token: 0x06000E1B RID: 3611 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E1B")]
	[Address(RVA = "0x3712080", Offset = "0x3710680", VA = "0x183712080")]
	private void TurnOff()
	{
	}

	// Token: 0x06000E1C RID: 3612 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E1C")]
	[Address(RVA = "0x3712230", Offset = "0x3710830", VA = "0x183712230")]
	public FlareWeapon()
	{
	}

	// Token: 0x04000D09 RID: 3337
	[Token(Token = "0x4000D09")]
	[FieldOffset(Offset = "0x28")]
	public int Amount;

	// Token: 0x04000D0A RID: 3338
	[Token(Token = "0x4000D0A")]
	[FieldOffset(Offset = "0x30")]
	public GameObject MyFire;
}
