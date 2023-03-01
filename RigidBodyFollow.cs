using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000051 RID: 81
[Token(Token = "0x2000051")]
public class RigidBodyFollow : MonoBehaviour
{
	// Token: 0x06000258 RID: 600 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000258")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void Awake()
	{
	}

	// Token: 0x06000259 RID: 601 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000259")]
	[Address(RVA = "0x2B7F0A0", Offset = "0x2B7E0A0", VA = "0x182B7F0A0")]
	private void Next()
	{
	}

	// Token: 0x0600025A RID: 602 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600025A")]
	[Address(RVA = "0x2B7EFB0", Offset = "0x2B7DFB0", VA = "0x182B7EFB0")]
	private void FixedUpdate()
	{
	}

	// Token: 0x0600025B RID: 603 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600025B")]
	[Address(RVA = "0x2B7F0F0", Offset = "0x2B7E0F0", VA = "0x182B7F0F0")]
	public RigidBodyFollow()
	{
	}

	// Token: 0x0400022A RID: 554
	[Token(Token = "0x400022A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Rigidbody _rigidbody;

	// Token: 0x0400022B RID: 555
	[Token(Token = "0x400022B")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<Rigidbody> _rigidbodies;

	// Token: 0x0400022C RID: 556
	[Token(Token = "0x400022C")]
	[FieldOffset(Offset = "0x30")]
	private int _index;
}
