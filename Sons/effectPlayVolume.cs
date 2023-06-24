using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001A4 RID: 420
[Token(Token = "0x20001A4")]
public class effectPlayVolume : MonoBehaviour
{
	// Token: 0x06000C6C RID: 3180 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C6C")]
	[Address(RVA = "0x66E8E0", Offset = "0x66CEE0", VA = "0x18066E8E0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06000C6D RID: 3181 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C6D")]
	[Address(RVA = "0x66EAE0", Offset = "0x66D0E0", VA = "0x18066EAE0")]
	private void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x06000C6E RID: 3182 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C6E")]
	[Address(RVA = "0x36E64B0", Offset = "0x36E4AB0", VA = "0x1836E64B0")]
	private void Update()
	{
	}

	// Token: 0x06000C6F RID: 3183 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C6F")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public effectPlayVolume()
	{
	}

	// Token: 0x04000AEC RID: 2796
	[Token(Token = "0x4000AEC")]
	[FieldOffset(Offset = "0x20")]
	public ParticleSystem effectToPlay;

	// Token: 0x04000AED RID: 2797
	[Token(Token = "0x4000AED")]
	[FieldOffset(Offset = "0x28")]
	public bool armed;
}
