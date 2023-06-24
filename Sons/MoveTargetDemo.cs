using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002E4 RID: 740
[Token(Token = "0x20002E4")]
public class MoveTargetDemo : MonoBehaviour
{
	// Token: 0x06001367 RID: 4967 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001367")]
	[Address(RVA = "0x31F5100", Offset = "0x31F3700", VA = "0x1831F5100")]
	private void Start()
	{
	}

	// Token: 0x06001368 RID: 4968 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001368")]
	[Address(RVA = "0x31F51C0", Offset = "0x31F37C0", VA = "0x1831F51C0")]
	private IEnumerator MoveTarget()
	{
		return null;
	}

	// Token: 0x06001369 RID: 4969 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001369")]
	[Address(RVA = "0x31F5250", Offset = "0x31F3850", VA = "0x1831F5250")]
	public MoveTargetDemo()
	{
	}

	// Token: 0x04001340 RID: 4928
	[Token(Token = "0x4001340")]
	[FieldOffset(Offset = "0x20")]
	private Transform xform;

	// Token: 0x04001341 RID: 4929
	[Token(Token = "0x4001341")]
	[FieldOffset(Offset = "0x28")]
	private bool moveForward;

	// Token: 0x04001342 RID: 4930
	[Token(Token = "0x4001342")]
	[FieldOffset(Offset = "0x2C")]
	private float speed;

	// Token: 0x04001343 RID: 4931
	[Token(Token = "0x4001343")]
	[FieldOffset(Offset = "0x30")]
	private float duration;

	// Token: 0x04001344 RID: 4932
	[Token(Token = "0x4001344")]
	[FieldOffset(Offset = "0x34")]
	private float delay;
}
