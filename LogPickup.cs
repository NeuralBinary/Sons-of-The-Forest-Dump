using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000DF RID: 223
[Token(Token = "0x20000DF")]
public class LogPickup : CoopBase<ILogPickup>
{
	// Token: 0x06000685 RID: 1669 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000685")]
	[Address(RVA = "0x2E86FE0", Offset = "0x2E85FE0", VA = "0x182E86FE0", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x06000686 RID: 1670 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000686")]
	[Address(RVA = "0x2E87380", Offset = "0x2E86380", VA = "0x182E87380")]
	private void ModifyColliders(float scale, float lengthScale)
	{
	}

	// Token: 0x06000687 RID: 1671 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000687")]
	[Address(RVA = "0x2E871F0", Offset = "0x2E861F0", VA = "0x182E871F0")]
	private void ModifyCollider(Collider eachCollider, float scale, float lengthScale)
	{
	}

	// Token: 0x06000688 RID: 1672 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000688")]
	[Address(RVA = "0x2E87160", Offset = "0x2E86160", VA = "0x182E87160")]
	private void ModifyCollider(BoxCollider boxCollider, float scale)
	{
	}

	// Token: 0x06000689 RID: 1673 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000689")]
	[Address(RVA = "0x2E870F0", Offset = "0x2E860F0", VA = "0x182E870F0")]
	private void ModifyCollider(CapsuleCollider capsuleCollider, float scale, float lengthScale)
	{
	}

	// Token: 0x0600068A RID: 1674 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600068A")]
	[Address(RVA = "0x2E87610", Offset = "0x2E86610", VA = "0x182E87610")]
	public LogPickup()
	{
	}

	// Token: 0x0400057F RID: 1407
	[Token(Token = "0x400057F")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float _serverScale;

	// Token: 0x04000580 RID: 1408
	[Token(Token = "0x4000580")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float _serverLengthScale;

	// Token: 0x04000581 RID: 1409
	[Token(Token = "0x4000581")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float _clientScale;

	// Token: 0x04000582 RID: 1410
	[Token(Token = "0x4000582")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float _clientLengthScale;

	// Token: 0x04000583 RID: 1411
	[Token(Token = "0x4000583")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private List<Collider> _colliders;
}
