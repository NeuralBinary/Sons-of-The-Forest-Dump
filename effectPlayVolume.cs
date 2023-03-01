using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001A5 RID: 421
[Token(Token = "0x20001A5")]
public class effectPlayVolume : MonoBehaviour
{
	// Token: 0x06000C12 RID: 3090 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C12")]
	[Address(RVA = "0x5F6200", Offset = "0x5F5200", VA = "0x1805F6200")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06000C13 RID: 3091 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C13")]
	[Address(RVA = "0x5F61F0", Offset = "0x5F51F0", VA = "0x1805F61F0")]
	private void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x06000C14 RID: 3092 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C14")]
	[Address(RVA = "0x2F748A0", Offset = "0x2F738A0", VA = "0x182F748A0")]
	private void Update()
	{
	}

	// Token: 0x06000C15 RID: 3093 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C15")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public effectPlayVolume()
	{
	}

	// Token: 0x04000AC1 RID: 2753
	[Token(Token = "0x4000AC1")]
	[FieldOffset(Offset = "0x20")]
	public ParticleSystem effectToPlay;

	// Token: 0x04000AC2 RID: 2754
	[Token(Token = "0x4000AC2")]
	[FieldOffset(Offset = "0x28")]
	public bool armed;
}
