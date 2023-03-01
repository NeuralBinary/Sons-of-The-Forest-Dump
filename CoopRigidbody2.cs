using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x020000CF RID: 207
[Token(Token = "0x20000CF")]
public class CoopRigidbody2 : EntityBehaviour<IRigidbodyState>
{
	// Token: 0x06000628 RID: 1576 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000628")]
	[Address(RVA = "0x2E7B2D0", Offset = "0x2E7A2D0", VA = "0x182E7B2D0", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x06000629 RID: 1577 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000629")]
	[Address(RVA = "0x2E7B4C0", Offset = "0x2E7A4C0", VA = "0x182E7B4C0")]
	public CoopRigidbody2()
	{
	}

	// Token: 0x04000558 RID: 1368
	[Token(Token = "0x4000558")]
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("targetRigidbody")]
	[SerializeField]
	private Rigidbody _targetRigidbody;
}
