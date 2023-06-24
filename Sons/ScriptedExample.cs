using System;
using System.Collections;
using Il2CppDummyDll;
using PathologicalGames;
using UnityEngine;

// Token: 0x020002E6 RID: 742
[Token(Token = "0x20002E6")]
public class ScriptedExample : MonoBehaviour
{
	// Token: 0x06001370 RID: 4976 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001370")]
	[Address(RVA = "0x31F5610", Offset = "0x31F3C10", VA = "0x1831F5610")]
	private void Awake()
	{
	}

	// Token: 0x06001371 RID: 4977 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001371")]
	[Address(RVA = "0x31F5A60", Offset = "0x31F4060", VA = "0x1831F5A60")]
	private IEnumerator MoveRandom()
	{
		return null;
	}

	// Token: 0x06001372 RID: 4978 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001372")]
	[Address(RVA = "0x31F5AF0", Offset = "0x31F40F0", VA = "0x1831F5AF0")]
	private IEnumerator LookAtRandom()
	{
		return null;
	}

	// Token: 0x06001373 RID: 4979 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001373")]
	[Address(RVA = "0x31F5B80", Offset = "0x31F4180", VA = "0x1831F5B80")]
	public ScriptedExample()
	{
	}

	// Token: 0x04001349 RID: 4937
	[Token(Token = "0x4001349")]
	[FieldOffset(Offset = "0x20")]
	public float moveSpeed;

	// Token: 0x0400134A RID: 4938
	[Token(Token = "0x400134A")]
	[FieldOffset(Offset = "0x24")]
	public float turnSpeed;

	// Token: 0x0400134B RID: 4939
	[Token(Token = "0x400134B")]
	[FieldOffset(Offset = "0x28")]
	public float newDirectionInterval;

	// Token: 0x0400134C RID: 4940
	[Token(Token = "0x400134C")]
	[FieldOffset(Offset = "0x30")]
	private SmoothLookAtConstraint lookCns;

	// Token: 0x0400134D RID: 4941
	[Token(Token = "0x400134D")]
	[FieldOffset(Offset = "0x38")]
	private TransformConstraint xformCns;

	// Token: 0x0400134E RID: 4942
	[Token(Token = "0x400134E")]
	[FieldOffset(Offset = "0x40")]
	private Transform xform;
}
