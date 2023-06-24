using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000172 RID: 370
[Token(Token = "0x2000172")]
public class simpleFollow : MonoBehaviour
{
	// Token: 0x06000B5B RID: 2907 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B5B")]
	[Address(RVA = "0x36CCB10", Offset = "0x36CB110", VA = "0x1836CCB10")]
	private void Start()
	{
	}

	// Token: 0x06000B5C RID: 2908 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B5C")]
	[Address(RVA = "0x36CCC50", Offset = "0x36CB250", VA = "0x1836CCC50")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06000B5D RID: 2909 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B5D")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public simpleFollow()
	{
	}

	// Token: 0x040009D3 RID: 2515
	[Token(Token = "0x40009D3")]
	[FieldOffset(Offset = "0x20")]
	public Transform targetTr;

	// Token: 0x040009D4 RID: 2516
	[Token(Token = "0x40009D4")]
	[FieldOffset(Offset = "0x28")]
	private Transform tr;

	// Token: 0x040009D5 RID: 2517
	[Token(Token = "0x40009D5")]
	[FieldOffset(Offset = "0x30")]
	public GameObject velocityGo;

	// Token: 0x040009D6 RID: 2518
	[Token(Token = "0x40009D6")]
	[FieldOffset(Offset = "0x38")]
	private Rigidbody rb;

	// Token: 0x040009D7 RID: 2519
	[Token(Token = "0x40009D7")]
	[FieldOffset(Offset = "0x40")]
	public float mag;

	// Token: 0x040009D8 RID: 2520
	[Token(Token = "0x40009D8")]
	[FieldOffset(Offset = "0x44")]
	public float minMag;

	// Token: 0x040009D9 RID: 2521
	[Token(Token = "0x40009D9")]
	[FieldOffset(Offset = "0x48")]
	public float smoothTime;

	// Token: 0x040009DA RID: 2522
	[Token(Token = "0x40009DA")]
	[FieldOffset(Offset = "0x4C")]
	public float magLerpSpeed;
}
