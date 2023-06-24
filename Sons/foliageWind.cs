using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001FA RID: 506
[Token(Token = "0x20001FA")]
public class foliageWind : MonoBehaviour
{
	// Token: 0x06000E2A RID: 3626 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E2A")]
	[Address(RVA = "0x3713020", Offset = "0x3711620", VA = "0x183713020")]
	private void Awake()
	{
	}

	// Token: 0x06000E2B RID: 3627 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E2B")]
	[Address(RVA = "0x37130C0", Offset = "0x37116C0", VA = "0x1837130C0")]
	private void Update()
	{
	}

	// Token: 0x06000E2C RID: 3628 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E2C")]
	[Address(RVA = "0x3713180", Offset = "0x3711780", VA = "0x183713180")]
	private void ChangeWindAmount()
	{
	}

	// Token: 0x06000E2D RID: 3629 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E2D")]
	[Address(RVA = "0x3713220", Offset = "0x3711820", VA = "0x183713220")]
	public foliageWind()
	{
	}

	// Token: 0x04000D17 RID: 3351
	[Token(Token = "0x4000D17")]
	[FieldOffset(Offset = "0x20")]
	public Vector4 Wind;

	// Token: 0x04000D18 RID: 3352
	[Token(Token = "0x4000D18")]
	[FieldOffset(Offset = "0x30")]
	private float WaveSizeFoliageShader;

	// Token: 0x04000D19 RID: 3353
	[Token(Token = "0x4000D19")]
	[FieldOffset(Offset = "0x34")]
	private float WindRandomAmt;

	// Token: 0x04000D1A RID: 3354
	[Token(Token = "0x4000D1A")]
	[FieldOffset(Offset = "0x38")]
	private float WindForce;
}
