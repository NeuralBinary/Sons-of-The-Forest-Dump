using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000003 RID: 3
[Token(Token = "0x2000003")]
public class ReflectionProbeTreeOcclusion : MonoBehaviour
{
	// Token: 0x06000004 RID: 4 RVA: 0x00002054 File Offset: 0x00000254
	[Token(Token = "0x6000004")]
	[Address(RVA = "0x5EA820", Offset = "0x5E8E20", VA = "0x1805EA820")]
	public float GetMinWeight()
	{
		return 0f;
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000005")]
	[Address(RVA = "0x2655D00", Offset = "0x2654300", VA = "0x182655D00")]
	public ReflectionProbeTreeOcclusion()
	{
	}

	// Token: 0x04000009 RID: 9
	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Range(0f, 1f)]
	private float _minWeight;
}
