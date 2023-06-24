using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000002 RID: 2
[Token(Token = "0x2000002")]
public class FluidDrop : MonoBehaviour
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x5EA830", Offset = "0x5E8E30", VA = "0x1805EA830")]
	public void SetAmount(float amount)
	{
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002054 File Offset: 0x00000254
	[Token(Token = "0x6000002")]
	[Address(RVA = "0x5EA820", Offset = "0x5E8E20", VA = "0x1805EA820")]
	public float GetAmount()
	{
		return 0f;
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public FluidDrop()
	{
	}

	// Token: 0x04000001 RID: 1
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x20")]
	private float amount;
}
