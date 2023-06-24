using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000D1 RID: 209
[Token(Token = "0x20000D1")]
public class CoopSharedRigidbody : EntityBehaviour<IRigidbodyState>
{
	// Token: 0x06000695 RID: 1685 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000695")]
	[Address(RVA = "0x2612770", Offset = "0x2610D70", VA = "0x182612770")]
	private void Awake()
	{
	}

	// Token: 0x06000696 RID: 1686 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000696")]
	[Address(RVA = "0x351FAA0", Offset = "0x351E0A0", VA = "0x18351FAA0", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x06000697 RID: 1687 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000697")]
	[Address(RVA = "0x351FED0", Offset = "0x351E4D0", VA = "0x18351FED0", Slot = "17")]
	public override void Detached()
	{
	}

	// Token: 0x06000698 RID: 1688 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000698")]
	[Address(RVA = "0x3520000", Offset = "0x351E600", VA = "0x183520000")]
	private void Update()
	{
	}

	// Token: 0x06000699 RID: 1689 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000699")]
	[Address(RVA = "0x3520610", Offset = "0x351EC10", VA = "0x183520610")]
	public CoopSharedRigidbody()
	{
	}

	// Token: 0x0400057B RID: 1403
	[Token(Token = "0x400057B")]
	[FieldOffset(Offset = "0x28")]
	public float ClientMass;

	// Token: 0x0400057C RID: 1404
	[Token(Token = "0x400057C")]
	[FieldOffset(Offset = "0x2C")]
	public float ClientDrag;

	// Token: 0x0400057D RID: 1405
	[Token(Token = "0x400057D")]
	[FieldOffset(Offset = "0x30")]
	public Rigidbody Body;

	// Token: 0x0400057E RID: 1406
	[Token(Token = "0x400057E")]
	[FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public Transform ClientTransform;
}
