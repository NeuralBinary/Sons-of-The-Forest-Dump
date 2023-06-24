using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000212 RID: 530
[Token(Token = "0x2000212")]
[RequireComponent(typeof(Light))]
public class LightningFlicker : MonoBehaviour
{
	// Token: 0x06000E70 RID: 3696 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E70")]
	[Address(RVA = "0x3718D60", Offset = "0x3717360", VA = "0x183718D60")]
	private void Start()
	{
	}

	// Token: 0x06000E71 RID: 3697 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E71")]
	[Address(RVA = "0x3718E00", Offset = "0x3717400", VA = "0x183718E00")]
	private void Update()
	{
	}

	// Token: 0x06000E72 RID: 3698 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E72")]
	[Address(RVA = "0x3718F40", Offset = "0x3717540", VA = "0x183718F40")]
	public LightningFlicker()
	{
	}

	// Token: 0x04000D5B RID: 3419
	[Token(Token = "0x4000D5B")]
	[FieldOffset(Offset = "0x20")]
	[Range(0.1f, 0.2f)]
	public float PulseAmount;

	// Token: 0x04000D5C RID: 3420
	[Token(Token = "0x4000D5C")]
	[FieldOffset(Offset = "0x24")]
	[Range(1f, 20f)]
	public float PulseSpeed;

	// Token: 0x04000D5D RID: 3421
	[Token(Token = "0x4000D5D")]
	[FieldOffset(Offset = "0x28")]
	private float startingIntensity;
}
