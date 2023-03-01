using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200015A RID: 346
[Token(Token = "0x200015A")]
[ExecuteInEditMode]
public class restrictLocalIkPosition : MonoBehaviour
{
	// Token: 0x06000A2E RID: 2606 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A2E")]
	[Address(RVA = "0x2F5C830", Offset = "0x2F5B830", VA = "0x182F5C830")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000A2F RID: 2607 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A2F")]
	[Address(RVA = "0x2F5C890", Offset = "0x2F5B890", VA = "0x182F5C890")]
	public void SolveLimits()
	{
	}

	// Token: 0x06000A30 RID: 2608 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A30")]
	[Address(RVA = "0x2F5CDD0", Offset = "0x2F5BDD0", VA = "0x182F5CDD0")]
	public restrictLocalIkPosition()
	{
	}

	// Token: 0x040008A8 RID: 2216
	[Token(Token = "0x40008A8")]
	[FieldOffset(Offset = "0x20")]
	public Transform[] Blockers;

	// Token: 0x040008A9 RID: 2217
	[Token(Token = "0x40008A9")]
	[FieldOffset(Offset = "0x28")]
	public Transform LimitPosTr1;

	// Token: 0x040008AA RID: 2218
	[Token(Token = "0x40008AA")]
	[FieldOffset(Offset = "0x30")]
	public Transform Shoulder;

	// Token: 0x040008AB RID: 2219
	[Token(Token = "0x40008AB")]
	[FieldOffset(Offset = "0x38")]
	public float MaxArmDistance;

	// Token: 0x040008AC RID: 2220
	[Token(Token = "0x40008AC")]
	[FieldOffset(Offset = "0x3C")]
	private float limitAngle;

	// Token: 0x040008AD RID: 2221
	[Token(Token = "0x40008AD")]
	[FieldOffset(Offset = "0x40")]
	private float armDistance;

	// Token: 0x040008AE RID: 2222
	[Token(Token = "0x40008AE")]
	[FieldOffset(Offset = "0x44")]
	public bool RightHand;
}
