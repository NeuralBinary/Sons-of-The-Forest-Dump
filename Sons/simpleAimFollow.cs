using System;
using Il2CppDummyDll;
using UnityEngine;
using Valve.VR.InteractionSystem;

// Token: 0x02000170 RID: 368
[Token(Token = "0x2000170")]
[ExecuteInEditMode]
public class simpleAimFollow : MonoBehaviour
{
	// Token: 0x06000B55 RID: 2901 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B55")]
	[Address(RVA = "0x36CB9D0", Offset = "0x36C9FD0", VA = "0x1836CB9D0")]
	private void Update()
	{
	}

	// Token: 0x06000B56 RID: 2902 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B56")]
	[Address(RVA = "0x36CBE90", Offset = "0x36CA490", VA = "0x1836CBE90")]
	public simpleAimFollow()
	{
	}

	// Token: 0x040009BE RID: 2494
	[Token(Token = "0x40009BE")]
	[FieldOffset(Offset = "0x20")]
	public Transform HandTransform;

	// Token: 0x040009BF RID: 2495
	[Token(Token = "0x40009BF")]
	[FieldOffset(Offset = "0x28")]
	public Transform AimRoot;

	// Token: 0x040009C0 RID: 2496
	[Token(Token = "0x40009C0")]
	[FieldOffset(Offset = "0x30")]
	public Transform BowFollow;

	// Token: 0x040009C1 RID: 2497
	[Token(Token = "0x40009C1")]
	[FieldOffset(Offset = "0x38")]
	public Transform nockRestTransform;

	// Token: 0x040009C2 RID: 2498
	[Token(Token = "0x40009C2")]
	[FieldOffset(Offset = "0x40")]
	public LinearMapping bowDrawLinearMapping;

	// Token: 0x040009C3 RID: 2499
	[Token(Token = "0x40009C3")]
	[FieldOffset(Offset = "0x48")]
	public Transform AimTarget;

	// Token: 0x040009C4 RID: 2500
	[Token(Token = "0x40009C4")]
	[FieldOffset(Offset = "0x50")]
	public float minPull;

	// Token: 0x040009C5 RID: 2501
	[Token(Token = "0x40009C5")]
	[FieldOffset(Offset = "0x54")]
	public float maxPull;

	// Token: 0x040009C6 RID: 2502
	[Token(Token = "0x40009C6")]
	[FieldOffset(Offset = "0x58")]
	public bool execute;

	// Token: 0x040009C7 RID: 2503
	[Token(Token = "0x40009C7")]
	[FieldOffset(Offset = "0x5C")]
	public Vector3 localNockPos;
}
