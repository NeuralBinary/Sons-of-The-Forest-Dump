using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000173 RID: 371
[Token(Token = "0x2000173")]
public class simpleFollow : MonoBehaviour
{
	// Token: 0x06000B02 RID: 2818 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B02")]
	[Address(RVA = "0x2F5FF00", Offset = "0x2F5EF00", VA = "0x182F5FF00")]
	private void Start()
	{
	}

	// Token: 0x06000B03 RID: 2819 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B03")]
	[Address(RVA = "0x2F5FC30", Offset = "0x2F5EC30", VA = "0x182F5FC30")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06000B04 RID: 2820 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B04")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public simpleFollow()
	{
	}

	// Token: 0x040009AA RID: 2474
	[Token(Token = "0x40009AA")]
	[FieldOffset(Offset = "0x20")]
	public Transform targetTr;

	// Token: 0x040009AB RID: 2475
	[Token(Token = "0x40009AB")]
	[FieldOffset(Offset = "0x28")]
	private Transform tr;

	// Token: 0x040009AC RID: 2476
	[Token(Token = "0x40009AC")]
	[FieldOffset(Offset = "0x30")]
	public GameObject velocityGo;

	// Token: 0x040009AD RID: 2477
	[Token(Token = "0x40009AD")]
	[FieldOffset(Offset = "0x38")]
	private Rigidbody rb;

	// Token: 0x040009AE RID: 2478
	[Token(Token = "0x40009AE")]
	[FieldOffset(Offset = "0x40")]
	public float mag;

	// Token: 0x040009AF RID: 2479
	[Token(Token = "0x40009AF")]
	[FieldOffset(Offset = "0x44")]
	public float minMag;

	// Token: 0x040009B0 RID: 2480
	[Token(Token = "0x40009B0")]
	[FieldOffset(Offset = "0x48")]
	public float smoothTime;

	// Token: 0x040009B1 RID: 2481
	[Token(Token = "0x40009B1")]
	[FieldOffset(Offset = "0x4C")]
	public float magLerpSpeed;
}
