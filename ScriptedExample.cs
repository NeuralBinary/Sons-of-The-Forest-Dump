using System;
using System.Collections;
using Il2CppDummyDll;
using PathologicalGames;
using UnityEngine;

// Token: 0x020002F2 RID: 754
[Token(Token = "0x20002F2")]
public class ScriptedExample : MonoBehaviour
{
	// Token: 0x0600133A RID: 4922 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600133A")]
	[Address(RVA = "0x2C6A800", Offset = "0x2C69800", VA = "0x182C6A800")]
	private void Awake()
	{
	}

	// Token: 0x0600133B RID: 4923 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600133B")]
	[Address(RVA = "0x2C6AAD0", Offset = "0x2C69AD0", VA = "0x182C6AAD0")]
	private IEnumerator MoveRandom()
	{
		return null;
	}

	// Token: 0x0600133C RID: 4924 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600133C")]
	[Address(RVA = "0x2C6AA60", Offset = "0x2C69A60", VA = "0x182C6AA60")]
	private IEnumerator LookAtRandom()
	{
		return null;
	}

	// Token: 0x0600133D RID: 4925 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600133D")]
	[Address(RVA = "0x2C6AB40", Offset = "0x2C69B40", VA = "0x182C6AB40")]
	public ScriptedExample()
	{
	}

	// Token: 0x04001321 RID: 4897
	[Token(Token = "0x4001321")]
	[FieldOffset(Offset = "0x20")]
	public float moveSpeed;

	// Token: 0x04001322 RID: 4898
	[Token(Token = "0x4001322")]
	[FieldOffset(Offset = "0x24")]
	public float turnSpeed;

	// Token: 0x04001323 RID: 4899
	[Token(Token = "0x4001323")]
	[FieldOffset(Offset = "0x28")]
	public float newDirectionInterval;

	// Token: 0x04001324 RID: 4900
	[Token(Token = "0x4001324")]
	[FieldOffset(Offset = "0x30")]
	private SmoothLookAtConstraint lookCns;

	// Token: 0x04001325 RID: 4901
	[Token(Token = "0x4001325")]
	[FieldOffset(Offset = "0x38")]
	private TransformConstraint xformCns;

	// Token: 0x04001326 RID: 4902
	[Token(Token = "0x4001326")]
	[FieldOffset(Offset = "0x40")]
	private Transform xform;
}
