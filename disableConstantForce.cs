using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000112 RID: 274
[Token(Token = "0x2000112")]
public class disableConstantForce : MonoBehaviour
{
	// Token: 0x06000825 RID: 2085 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000825")]
	[Address(RVA = "0x2F46F90", Offset = "0x2F45F90", VA = "0x182F46F90")]
	private void Start()
	{
	}

	// Token: 0x06000826 RID: 2086 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000826")]
	[Address(RVA = "0x2F47000", Offset = "0x2F46000", VA = "0x182F47000")]
	private void Update()
	{
	}

	// Token: 0x06000827 RID: 2087 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000827")]
	[Address(RVA = "0x2F470D0", Offset = "0x2F460D0", VA = "0x182F470D0")]
	private void disableForce()
	{
	}

	// Token: 0x06000828 RID: 2088 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000828")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public disableConstantForce()
	{
	}

	// Token: 0x0400069B RID: 1691
	[Token(Token = "0x400069B")]
	[FieldOffset(Offset = "0x20")]
	public float delay;

	// Token: 0x0400069C RID: 1692
	[Token(Token = "0x400069C")]
	[FieldOffset(Offset = "0x28")]
	private ConstantForce force;

	// Token: 0x0400069D RID: 1693
	[Token(Token = "0x400069D")]
	[FieldOffset(Offset = "0x30")]
	private bool disable;
}
