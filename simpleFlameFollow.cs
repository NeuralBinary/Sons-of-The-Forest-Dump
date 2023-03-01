using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000172 RID: 370
[Token(Token = "0x2000172")]
public class simpleFlameFollow : MonoBehaviour
{
	// Token: 0x06000AFE RID: 2814 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AFE")]
	[Address(RVA = "0x2F5F610", Offset = "0x2F5E610", VA = "0x182F5F610")]
	private void Awake()
	{
	}

	// Token: 0x06000AFF RID: 2815 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AFF")]
	[Address(RVA = "0x639170", Offset = "0x638170", VA = "0x180639170")]
	private void Start()
	{
	}

	// Token: 0x06000B00 RID: 2816 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B00")]
	[Address(RVA = "0x2F5F680", Offset = "0x2F5E680", VA = "0x182F5F680")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000B01 RID: 2817 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B01")]
	[Address(RVA = "0x2F5FC10", Offset = "0x2F5EC10", VA = "0x182F5FC10")]
	public simpleFlameFollow()
	{
	}

	// Token: 0x0400099F RID: 2463
	[Token(Token = "0x400099F")]
	[FieldOffset(Offset = "0x20")]
	public Transform followTarget;

	// Token: 0x040009A0 RID: 2464
	[Token(Token = "0x40009A0")]
	[FieldOffset(Offset = "0x28")]
	public Transform dummyTarget;

	// Token: 0x040009A1 RID: 2465
	[Token(Token = "0x40009A1")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 origPos;

	// Token: 0x040009A2 RID: 2466
	[Token(Token = "0x40009A2")]
	[FieldOffset(Offset = "0x3C")]
	private float startPos;

	// Token: 0x040009A3 RID: 2467
	[Token(Token = "0x40009A3")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 pos;

	// Token: 0x040009A4 RID: 2468
	[Token(Token = "0x40009A4")]
	[FieldOffset(Offset = "0x4C")]
	private Vector3 velRef;

	// Token: 0x040009A5 RID: 2469
	[Token(Token = "0x40009A5")]
	[FieldOffset(Offset = "0x58")]
	public float finalSmoothTime;

	// Token: 0x040009A6 RID: 2470
	[Token(Token = "0x40009A6")]
	[FieldOffset(Offset = "0x5C")]
	public float followDistance;

	// Token: 0x040009A7 RID: 2471
	[Token(Token = "0x40009A7")]
	[FieldOffset(Offset = "0x60")]
	public bool lockXTranslate;

	// Token: 0x040009A8 RID: 2472
	[Token(Token = "0x40009A8")]
	[FieldOffset(Offset = "0x61")]
	public bool lockYTranslate;

	// Token: 0x040009A9 RID: 2473
	[Token(Token = "0x40009A9")]
	[FieldOffset(Offset = "0x62")]
	public bool lockZTranslate;
}
