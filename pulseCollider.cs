using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000155 RID: 341
[Token(Token = "0x2000155")]
public class pulseCollider : MonoBehaviour
{
	// Token: 0x06000A1A RID: 2586 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A1A")]
	[Address(RVA = "0x2F5C640", Offset = "0x2F5B640", VA = "0x182F5C640")]
	private void Start()
	{
	}

	// Token: 0x06000A1B RID: 2587 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A1B")]
	[Address(RVA = "0x2F5C5D0", Offset = "0x2F5B5D0", VA = "0x182F5C5D0")]
	private void OnEnable()
	{
	}

	// Token: 0x06000A1C RID: 2588 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A1C")]
	[Address(RVA = "0x2F5C590", Offset = "0x2F5B590", VA = "0x182F5C590")]
	private void OnDisable()
	{
	}

	// Token: 0x06000A1D RID: 2589 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A1D")]
	[Address(RVA = "0x2F5C6B0", Offset = "0x2F5B6B0", VA = "0x182F5C6B0")]
	private void Update()
	{
	}

	// Token: 0x06000A1E RID: 2590 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A1E")]
	[Address(RVA = "0x2F5C6F0", Offset = "0x2F5B6F0", VA = "0x182F5C6F0")]
	private void initPulse()
	{
	}

	// Token: 0x06000A1F RID: 2591 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A1F")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public pulseCollider()
	{
	}

	// Token: 0x040008A1 RID: 2209
	[Token(Token = "0x40008A1")]
	[FieldOffset(Offset = "0x20")]
	public Collider _collider;

	// Token: 0x040008A2 RID: 2210
	[Token(Token = "0x40008A2")]
	[FieldOffset(Offset = "0x28")]
	public float interval;

	// Token: 0x040008A3 RID: 2211
	[Token(Token = "0x40008A3")]
	[FieldOffset(Offset = "0x2C")]
	private bool canPulse;
}
