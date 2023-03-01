using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000009 RID: 9
[Token(Token = "0x2000009")]
public class FanSpin : MonoBehaviour
{
	// Token: 0x0600001D RID: 29 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600001D")]
	[Address(RVA = "0x29A55C0", Offset = "0x29A45C0", VA = "0x1829A55C0")]
	private void Awake()
	{
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600001E")]
	[Address(RVA = "0x29A5600", Offset = "0x29A4600", VA = "0x1829A5600")]
	private void Update()
	{
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600001F")]
	[Address(RVA = "0x29A57D0", Offset = "0x29A47D0", VA = "0x1829A57D0")]
	private void ValidateSpin()
	{
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000020")]
	[Address(RVA = "0x29A5790", Offset = "0x29A4790", VA = "0x1829A5790")]
	private void ValidateRotationValue(ref float rotationComponent, float maxRotation)
	{
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000021")]
	[Address(RVA = "0x29A5890", Offset = "0x29A4890", VA = "0x1829A5890")]
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
