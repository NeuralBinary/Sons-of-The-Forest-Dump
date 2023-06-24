using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002E9 RID: 745
[Token(Token = "0x20002E9")]
public class Transform_Demo : MonoBehaviour
{
	// Token: 0x06001380 RID: 4992 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001380")]
	[Address(RVA = "0x31F66E0", Offset = "0x31F4CE0", VA = "0x1831F66E0")]
	private void Awake()
	{
	}

	// Token: 0x06001381 RID: 4993 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001381")]
	[Address(RVA = "0x31F6790", Offset = "0x31F4D90", VA = "0x1831F6790")]
	private void Start()
	{
	}

	// Token: 0x06001382 RID: 4994 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001382")]
	[Address(RVA = "0x31F68E0", Offset = "0x31F4EE0", VA = "0x1831F68E0")]
	private IEnumerator RotateTarget()
	{
		return null;
	}

	// Token: 0x06001383 RID: 4995 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001383")]
	[Address(RVA = "0x31F6970", Offset = "0x31F4F70", VA = "0x1831F6970")]
	private IEnumerator MoveTarget()
	{
		return null;
	}

	// Token: 0x06001384 RID: 4996 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001384")]
	[Address(RVA = "0x31F6A00", Offset = "0x31F5000", VA = "0x1831F6A00")]
	public Transform_Demo()
	{
	}

	// Token: 0x04001355 RID: 4949
	[Token(Token = "0x4001355")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 rotate;

	// Token: 0x04001356 RID: 4950
	[Token(Token = "0x4001356")]
	[FieldOffset(Offset = "0x30")]
	private Transform xform;

	// Token: 0x04001357 RID: 4951
	[Token(Token = "0x4001357")]
	[FieldOffset(Offset = "0x38")]
	private bool moveForward;

	// Token: 0x04001358 RID: 4952
	[Token(Token = "0x4001358")]
	[FieldOffset(Offset = "0x3C")]
	private float speed;

	// Token: 0x04001359 RID: 4953
	[Token(Token = "0x4001359")]
	[FieldOffset(Offset = "0x40")]
	private float duration;

	// Token: 0x0400135A RID: 4954
	[Token(Token = "0x400135A")]
	[FieldOffset(Offset = "0x44")]
	private float delay;

	// Token: 0x0400135B RID: 4955
	[Token(Token = "0x400135B")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 bigScale;

	// Token: 0x0400135C RID: 4956
	[Token(Token = "0x400135C")]
	[FieldOffset(Offset = "0x54")]
	private Vector3 smallScale;
}
