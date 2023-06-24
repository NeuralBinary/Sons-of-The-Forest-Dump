using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000171 RID: 369
[Token(Token = "0x2000171")]
public class simpleFlameFollow : MonoBehaviour
{
	// Token: 0x06000B57 RID: 2903 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B57")]
	[Address(RVA = "0x36CBEE0", Offset = "0x36CA4E0", VA = "0x1836CBEE0")]
	private void Awake()
	{
	}

	// Token: 0x06000B58 RID: 2904 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B58")]
	[Address(RVA = "0x6D1610", Offset = "0x6CFC10", VA = "0x1806D1610")]
	private void Start()
	{
	}

	// Token: 0x06000B59 RID: 2905 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B59")]
	[Address(RVA = "0x36CC060", Offset = "0x36CA660", VA = "0x1836CC060")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000B5A RID: 2906 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B5A")]
	[Address(RVA = "0x36CCAC0", Offset = "0x36CB0C0", VA = "0x1836CCAC0")]
	public simpleFlameFollow()
	{
	}

	// Token: 0x040009C8 RID: 2504
	[Token(Token = "0x40009C8")]
	[FieldOffset(Offset = "0x20")]
	public Transform followTarget;

	// Token: 0x040009C9 RID: 2505
	[Token(Token = "0x40009C9")]
	[FieldOffset(Offset = "0x28")]
	public Transform dummyTarget;

	// Token: 0x040009CA RID: 2506
	[Token(Token = "0x40009CA")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 origPos;

	// Token: 0x040009CB RID: 2507
	[Token(Token = "0x40009CB")]
	[FieldOffset(Offset = "0x3C")]
	private float startPos;

	// Token: 0x040009CC RID: 2508
	[Token(Token = "0x40009CC")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 pos;

	// Token: 0x040009CD RID: 2509
	[Token(Token = "0x40009CD")]
	[FieldOffset(Offset = "0x4C")]
	private Vector3 velRef;

	// Token: 0x040009CE RID: 2510
	[Token(Token = "0x40009CE")]
	[FieldOffset(Offset = "0x58")]
	public float finalSmoothTime;

	// Token: 0x040009CF RID: 2511
	[Token(Token = "0x40009CF")]
	[FieldOffset(Offset = "0x5C")]
	public float followDistance;

	// Token: 0x040009D0 RID: 2512
	[Token(Token = "0x40009D0")]
	[FieldOffset(Offset = "0x60")]
	public bool lockXTranslate;

	// Token: 0x040009D1 RID: 2513
	[Token(Token = "0x40009D1")]
	[FieldOffset(Offset = "0x61")]
	public bool lockYTranslate;

	// Token: 0x040009D2 RID: 2514
	[Token(Token = "0x40009D2")]
	[FieldOffset(Offset = "0x62")]
	public bool lockZTranslate;
}
