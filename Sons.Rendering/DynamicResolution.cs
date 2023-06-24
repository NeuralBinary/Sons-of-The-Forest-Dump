using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000004 RID: 4
[Token(Token = "0x2000004")]
public class DynamicResolution : MonoBehaviour
{
	// Token: 0x06000009 RID: 9 RVA: 0x00002080 File Offset: 0x00000280
	[Token(Token = "0x6000009")]
	[Address(RVA = "0x5EA820", Offset = "0x5E8E20", VA = "0x1805EA820")]
	public float SetDynamicResolutionScale()
	{
		return 0f;
	}

	// Token: 0x0600000A RID: 10 RVA: 0x0000207E File Offset: 0x0000027E
	[Token(Token = "0x600000A")]
	[Address(RVA = "0x3124D80", Offset = "0x3123380", VA = "0x183124D80")]
	private void Start()
	{
	}

	// Token: 0x0600000B RID: 11 RVA: 0x0000207E File Offset: 0x0000027E
	[Token(Token = "0x600000B")]
	[Address(RVA = "0x2655D00", Offset = "0x2654300", VA = "0x182655D00")]
	public DynamicResolution()
	{
	}

	// Token: 0x0400003D RID: 61
	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0x20")]
	[Range(0f, 1f)]
	public float desiredScaleRatio;
}
