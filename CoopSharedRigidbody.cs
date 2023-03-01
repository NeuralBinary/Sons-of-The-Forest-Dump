using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000D3 RID: 211
[Token(Token = "0x20000D3")]
public class CoopSharedRigidbody : EntityBehaviour<IRigidbodyState>
{
	// Token: 0x0600064A RID: 1610 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600064A")]
	[Address(RVA = "0x21F6BA0", Offset = "0x21F5BA0", VA = "0x1821F6BA0")]
	private void Awake()
	{
	}

	// Token: 0x0600064B RID: 1611 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600064B")]
	[Address(RVA = "0x2E7E870", Offset = "0x2E7D870", VA = "0x182E7E870", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x0600064C RID: 1612 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600064C")]
	[Address(RVA = "0x2E7EAA0", Offset = "0x2E7DAA0", VA = "0x182E7EAA0", Slot = "17")]
	public override void Detached()
	{
	}

	// Token: 0x0600064D RID: 1613 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600064D")]
	[Address(RVA = "0x2E7EB40", Offset = "0x2E7DB40", VA = "0x182E7EB40")]
	private void Update()
	{
	}

	// Token: 0x0600064E RID: 1614 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600064E")]
	[Address(RVA = "0x2E7ED70", Offset = "0x2E7DD70", VA = "0x182E7ED70")]
	public CoopSharedRigidbody()
	{
	}

	// Token: 0x0400055E RID: 1374
	[Token(Token = "0x400055E")]
	[FieldOffset(Offset = "0x28")]
	public float ClientMass;

	// Token: 0x0400055F RID: 1375
	[Token(Token = "0x400055F")]
	[FieldOffset(Offset = "0x2C")]
	public float ClientDrag;

	// Token: 0x04000560 RID: 1376
	[Token(Token = "0x4000560")]
	[FieldOffset(Offset = "0x30")]
	public Rigidbody Body;

	// Token: 0x04000561 RID: 1377
	[Token(Token = "0x4000561")]
	[FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public Transform ClientTransform;
}
