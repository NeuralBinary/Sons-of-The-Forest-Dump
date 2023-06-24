using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x020000CD RID: 205
[Token(Token = "0x20000CD")]
public class CoopRigidbody2 : EntityBehaviour<IRigidbodyState>
{
	// Token: 0x06000660 RID: 1632 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000660")]
	[Address(RVA = "0x3518AC0", Offset = "0x35170C0", VA = "0x183518AC0", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x06000661 RID: 1633 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000661")]
	[Address(RVA = "0x3518E70", Offset = "0x3517470", VA = "0x183518E70")]
	public CoopRigidbody2()
	{
	}

	// Token: 0x04000572 RID: 1394
	[Token(Token = "0x4000572")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[FormerlySerializedAs("targetRigidbody")]
	private Rigidbody _targetRigidbody;
}
