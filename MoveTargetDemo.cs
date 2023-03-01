using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002F0 RID: 752
[Token(Token = "0x20002F0")]
public class MoveTargetDemo : MonoBehaviour
{
	// Token: 0x06001331 RID: 4913 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001331")]
	[Address(RVA = "0x2C67700", Offset = "0x2C66700", VA = "0x182C67700")]
	private void Start()
	{
	}

	// Token: 0x06001332 RID: 4914 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001332")]
	[Address(RVA = "0x2C67690", Offset = "0x2C66690", VA = "0x182C67690")]
	private IEnumerator MoveTarget()
	{
		return null;
	}

	// Token: 0x06001333 RID: 4915 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001333")]
	[Address(RVA = "0x2C67790", Offset = "0x2C66790", VA = "0x182C67790")]
	public MoveTargetDemo()
	{
	}

	// Token: 0x04001318 RID: 4888
	[Token(Token = "0x4001318")]
	[FieldOffset(Offset = "0x20")]
	private Transform xform;

	// Token: 0x04001319 RID: 4889
	[Token(Token = "0x4001319")]
	[FieldOffset(Offset = "0x28")]
	private bool moveForward;

	// Token: 0x0400131A RID: 4890
	[Token(Token = "0x400131A")]
	[FieldOffset(Offset = "0x2C")]
	private float speed;

	// Token: 0x0400131B RID: 4891
	[Token(Token = "0x400131B")]
	[FieldOffset(Offset = "0x30")]
	private float duration;

	// Token: 0x0400131C RID: 4892
	[Token(Token = "0x400131C")]
	[FieldOffset(Offset = "0x34")]
	private float delay;
}
