using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000CE RID: 206
[Token(Token = "0x20000CE")]
public class CoopRigidbody : EntityBehaviour<IRigidbodyState>
{
	// Token: 0x06000626 RID: 1574 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000626")]
	[Address(RVA = "0x2E7B500", Offset = "0x2E7A500", VA = "0x182E7B500", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x06000627 RID: 1575 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000627")]
	[Address(RVA = "0x2E7B6C0", Offset = "0x2E7A6C0", VA = "0x182E7B6C0")]
	public CoopRigidbody()
	{
	}

	// Token: 0x04000557 RID: 1367
	[Token(Token = "0x4000557")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Rigidbody targetRigidbody;
}
