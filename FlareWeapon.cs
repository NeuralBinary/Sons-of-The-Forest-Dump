using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001F7 RID: 503
[Token(Token = "0x20001F7")]
public class FlareWeapon : EntityBehaviour
{
	// Token: 0x06000DBD RID: 3517 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DBD")]
	[Address(RVA = "0x2F885E0", Offset = "0x2F875E0", VA = "0x182F885E0")]
	private void Awake()
	{
	}

	// Token: 0x06000DBE RID: 3518 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DBE")]
	[Address(RVA = "0x2F886D0", Offset = "0x2F876D0", VA = "0x182F886D0")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	// Token: 0x06000DBF RID: 3519 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DBF")]
	[Address(RVA = "0x2F88860", Offset = "0x2F87860", VA = "0x182F88860")]
	private void TurnOn()
	{
	}

	// Token: 0x06000DC0 RID: 3520 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DC0")]
	[Address(RVA = "0x2F88750", Offset = "0x2F87750", VA = "0x182F88750")]
	private void TurnOff()
	{
	}

	// Token: 0x06000DC1 RID: 3521 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DC1")]
	[Address(RVA = "0x2F888E0", Offset = "0x2F878E0", VA = "0x182F888E0")]
	public FlareWeapon()
	{
	}

	// Token: 0x04000CDA RID: 3290
	[Token(Token = "0x4000CDA")]
	[FieldOffset(Offset = "0x28")]
	public int Amount;

	// Token: 0x04000CDB RID: 3291
	[Token(Token = "0x4000CDB")]
	[FieldOffset(Offset = "0x30")]
	public GameObject MyFire;
}
