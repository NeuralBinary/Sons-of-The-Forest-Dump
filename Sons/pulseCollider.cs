using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000154 RID: 340
[Token(Token = "0x2000154")]
public class pulseCollider : MonoBehaviour
{
	// Token: 0x06000A6A RID: 2666 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A6A")]
	[Address(RVA = "0x36B50C0", Offset = "0x36B36C0", VA = "0x1836B50C0")]
	private void Start()
	{
	}

	// Token: 0x06000A6B RID: 2667 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A6B")]
	[Address(RVA = "0x36B5170", Offset = "0x36B3770", VA = "0x1836B5170")]
	private void OnEnable()
	{
	}

	// Token: 0x06000A6C RID: 2668 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A6C")]
	[Address(RVA = "0x36B5220", Offset = "0x36B3820", VA = "0x1836B5220")]
	private void OnDisable()
	{
	}

	// Token: 0x06000A6D RID: 2669 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A6D")]
	[Address(RVA = "0x36B52A0", Offset = "0x36B38A0", VA = "0x1836B52A0")]
	private void Update()
	{
	}

	// Token: 0x06000A6E RID: 2670 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A6E")]
	[Address(RVA = "0x36B5350", Offset = "0x36B3950", VA = "0x1836B5350")]
	private void initPulse()
	{
	}

	// Token: 0x06000A6F RID: 2671 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A6F")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public pulseCollider()
	{
	}

	// Token: 0x040008C2 RID: 2242
	[Token(Token = "0x40008C2")]
	[FieldOffset(Offset = "0x20")]
	public Collider _collider;

	// Token: 0x040008C3 RID: 2243
	[Token(Token = "0x40008C3")]
	[FieldOffset(Offset = "0x28")]
	public float interval;

	// Token: 0x040008C4 RID: 2244
	[Token(Token = "0x40008C4")]
	[FieldOffset(Offset = "0x2C")]
	private bool canPulse;
}
