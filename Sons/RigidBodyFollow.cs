using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000053 RID: 83
[Token(Token = "0x2000053")]
public class RigidBodyFollow : MonoBehaviour
{
	// Token: 0x06000277 RID: 631 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000277")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void Awake()
	{
	}

	// Token: 0x06000278 RID: 632 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000278")]
	[Address(RVA = "0x31AFFB0", Offset = "0x31AE5B0", VA = "0x1831AFFB0")]
	private void Next()
	{
	}

	// Token: 0x06000279 RID: 633 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000279")]
	[Address(RVA = "0x31B0000", Offset = "0x31AE600", VA = "0x1831B0000")]
	private void FixedUpdate()
	{
	}

	// Token: 0x0600027A RID: 634 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600027A")]
	[Address(RVA = "0x31B0240", Offset = "0x31AE840", VA = "0x1831B0240")]
	public RigidBodyFollow()
	{
	}

	// Token: 0x0400025D RID: 605
	[Token(Token = "0x400025D")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Rigidbody _rigidbody;

	// Token: 0x0400025E RID: 606
	[Token(Token = "0x400025E")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<Rigidbody> _rigidbodies;

	// Token: 0x0400025F RID: 607
	[Token(Token = "0x400025F")]
	[FieldOffset(Offset = "0x30")]
	private int _index;
}
