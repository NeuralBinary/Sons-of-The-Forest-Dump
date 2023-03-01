using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002F5 RID: 757
[Token(Token = "0x20002F5")]
public class Transform_Demo : MonoBehaviour
{
	// Token: 0x0600134A RID: 4938 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600134A")]
	[Address(RVA = "0x2685720", Offset = "0x2684720", VA = "0x182685720")]
	private void Awake()
	{
	}

	// Token: 0x0600134B RID: 4939 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600134B")]
	[Address(RVA = "0x2C77BE0", Offset = "0x2C76BE0", VA = "0x182C77BE0")]
	private void Start()
	{
	}

	// Token: 0x0600134C RID: 4940 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600134C")]
	[Address(RVA = "0x2C77B70", Offset = "0x2C76B70", VA = "0x182C77B70")]
	private IEnumerator RotateTarget()
	{
		return null;
	}

	// Token: 0x0600134D RID: 4941 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600134D")]
	[Address(RVA = "0x2C77B00", Offset = "0x2C76B00", VA = "0x182C77B00")]
	private IEnumerator MoveTarget()
	{
		return null;
	}

	// Token: 0x0600134E RID: 4942 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600134E")]
	[Address(RVA = "0x2C77CB0", Offset = "0x2C76CB0", VA = "0x182C77CB0")]
	public Transform_Demo()
	{
	}

	// Token: 0x0400132D RID: 4909
	[Token(Token = "0x400132D")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 rotate;

	// Token: 0x0400132E RID: 4910
	[Token(Token = "0x400132E")]
	[FieldOffset(Offset = "0x30")]
	private Transform xform;

	// Token: 0x0400132F RID: 4911
	[Token(Token = "0x400132F")]
	[FieldOffset(Offset = "0x38")]
	private bool moveForward;

	// Token: 0x04001330 RID: 4912
	[Token(Token = "0x4001330")]
	[FieldOffset(Offset = "0x3C")]
	private float speed;

	// Token: 0x04001331 RID: 4913
	[Token(Token = "0x4001331")]
	[FieldOffset(Offset = "0x40")]
	private float duration;

	// Token: 0x04001332 RID: 4914
	[Token(Token = "0x4001332")]
	[FieldOffset(Offset = "0x44")]
	private float delay;

	// Token: 0x04001333 RID: 4915
	[Token(Token = "0x4001333")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 bigScale;

	// Token: 0x04001334 RID: 4916
	[Token(Token = "0x4001334")]
	[FieldOffset(Offset = "0x54")]
	private Vector3 smallScale;
}
