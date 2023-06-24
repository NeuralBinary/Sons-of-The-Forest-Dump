using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200010F RID: 271
[Token(Token = "0x200010F")]
public class disableConstantForce : MonoBehaviour
{
	// Token: 0x0600086C RID: 2156 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600086C")]
	[Address(RVA = "0x3687990", Offset = "0x3685F90", VA = "0x183687990")]
	private void Start()
	{
	}

	// Token: 0x0600086D RID: 2157 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600086D")]
	[Address(RVA = "0x3687A50", Offset = "0x3686050", VA = "0x183687A50")]
	private void Update()
	{
	}

	// Token: 0x0600086E RID: 2158 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600086E")]
	[Address(RVA = "0x3687CA0", Offset = "0x36862A0", VA = "0x183687CA0")]
	private void disableForce()
	{
	}

	// Token: 0x0600086F RID: 2159 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600086F")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public disableConstantForce()
	{
	}

	// Token: 0x040006B7 RID: 1719
	[Token(Token = "0x40006B7")]
	[FieldOffset(Offset = "0x20")]
	public float delay;

	// Token: 0x040006B8 RID: 1720
	[Token(Token = "0x40006B8")]
	[FieldOffset(Offset = "0x28")]
	private ConstantForce force;

	// Token: 0x040006B9 RID: 1721
	[Token(Token = "0x40006B9")]
	[FieldOffset(Offset = "0x30")]
	private bool disable;
}
