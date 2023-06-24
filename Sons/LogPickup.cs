using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000DD RID: 221
[Token(Token = "0x20000DD")]
public class LogPickup : CoopBase<ILogPickup>
{
	// Token: 0x060006D0 RID: 1744 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006D0")]
	[Address(RVA = "0x3526530", Offset = "0x3524B30", VA = "0x183526530", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x060006D1 RID: 1745 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006D1")]
	[Address(RVA = "0x3526730", Offset = "0x3524D30", VA = "0x183526730")]
	private void ModifyColliders(float scale, float lengthScale)
	{
	}

	// Token: 0x060006D2 RID: 1746 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006D2")]
	[Address(RVA = "0x35268A0", Offset = "0x3524EA0", VA = "0x1835268A0")]
	private void ModifyCollider(Collider eachCollider, float scale, float lengthScale)
	{
	}

	// Token: 0x060006D3 RID: 1747 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006D3")]
	[Address(RVA = "0x3526BF0", Offset = "0x35251F0", VA = "0x183526BF0")]
	private void ModifyCollider(BoxCollider boxCollider, float scale)
	{
	}

	// Token: 0x060006D4 RID: 1748 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006D4")]
	[Address(RVA = "0x3526CF0", Offset = "0x35252F0", VA = "0x183526CF0")]
	private void ModifyCollider(CapsuleCollider capsuleCollider, float scale, float lengthScale)
	{
	}

	// Token: 0x060006D5 RID: 1749 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006D5")]
	[Address(RVA = "0x3526E60", Offset = "0x3525460", VA = "0x183526E60")]
	public LogPickup()
	{
	}

	// Token: 0x0400059C RID: 1436
	[Token(Token = "0x400059C")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float _serverScale;

	// Token: 0x0400059D RID: 1437
	[Token(Token = "0x400059D")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float _serverLengthScale;

	// Token: 0x0400059E RID: 1438
	[Token(Token = "0x400059E")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float _clientScale;

	// Token: 0x0400059F RID: 1439
	[Token(Token = "0x400059F")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float _clientLengthScale;

	// Token: 0x040005A0 RID: 1440
	[Token(Token = "0x40005A0")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private List<Collider> _colliders;
}
