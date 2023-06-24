using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000009 RID: 9
[Token(Token = "0x2000009")]
public class FanSpin : MonoBehaviour
{
	// Token: 0x0600001D RID: 29 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600001D")]
	[Address(RVA = "0x2F63740", Offset = "0x2F61D40", VA = "0x182F63740")]
	private void Awake()
	{
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600001E")]
	[Address(RVA = "0x2F63820", Offset = "0x2F61E20", VA = "0x182F63820")]
	private void Update()
	{
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600001F")]
	[Address(RVA = "0x2F63A10", Offset = "0x2F62010", VA = "0x182F63A10")]
	private void ValidateSpin()
	{
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000020")]
	[Address(RVA = "0x2F63AD0", Offset = "0x2F620D0", VA = "0x182F63AD0")]
	private void ValidateRotationValue(ref float rotationComponent, float maxRotation)
	{
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000021")]
	[Address(RVA = "0x2F63B10", Offset = "0x2F62110", VA = "0x182F63B10")]
	public FanSpin()
	{
	}

	// Token: 0x04000021 RID: 33
	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x20")]
	private Vector3 spin;

	// Token: 0x04000022 RID: 34
	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 spinAmount;

	// Token: 0x04000023 RID: 35
	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x38")]
	private float _spinReset;
}
