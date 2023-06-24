using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000CC RID: 204
[Token(Token = "0x20000CC")]
public class CoopRigidbody : EntityBehaviour<IRigidbodyState>
{
	// Token: 0x0600065E RID: 1630 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600065E")]
	[Address(RVA = "0x3518710", Offset = "0x3516D10", VA = "0x183518710", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x0600065F RID: 1631 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600065F")]
	[Address(RVA = "0x3518A60", Offset = "0x3517060", VA = "0x183518A60")]
	public CoopRigidbody()
	{
	}

	// Token: 0x04000571 RID: 1393
	[Token(Token = "0x4000571")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Rigidbody targetRigidbody;
}
