using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000213 RID: 531
[Token(Token = "0x2000213")]
[RequireComponent(typeof(Light))]
public class LightningFlicker : MonoBehaviour
{
	// Token: 0x06000E15 RID: 3605 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E15")]
	[Address(RVA = "0x2F9ADC0", Offset = "0x2F99DC0", VA = "0x182F9ADC0")]
	private void Start()
	{
	}

	// Token: 0x06000E16 RID: 3606 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E16")]
	[Address(RVA = "0x2F9AE20", Offset = "0x2F99E20", VA = "0x182F9AE20")]
	private void Update()
	{
	}

	// Token: 0x06000E17 RID: 3607 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E17")]
	[Address(RVA = "0x2F9AEC0", Offset = "0x2F99EC0", VA = "0x182F9AEC0")]
	public LightningFlicker()
	{
	}

	// Token: 0x04000D2C RID: 3372
	[Token(Token = "0x4000D2C")]
	[FieldOffset(Offset = "0x20")]
	[Range(0.1f, 0.2f)]
	public float PulseAmount;

	// Token: 0x04000D2D RID: 3373
	[Token(Token = "0x4000D2D")]
	[FieldOffset(Offset = "0x24")]
	[Range(1f, 20f)]
	public float PulseSpeed;

	// Token: 0x04000D2E RID: 3374
	[Token(Token = "0x4000D2E")]
	[FieldOffset(Offset = "0x28")]
	private float startingIntensity;
}
