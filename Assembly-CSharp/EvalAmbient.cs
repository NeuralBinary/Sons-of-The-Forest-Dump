using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200000F RID: 15
[Token(Token = "0x200000F")]
[ExecuteAlways]
public class EvalAmbient : MonoBehaviour
{
	// Token: 0x06000035 RID: 53 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000035")]
	[Address(RVA = "0x5CD820", Offset = "0x5CBE20", VA = "0x1805CD820")]
	private void Update()
	{
	}

	// Token: 0x06000036 RID: 54 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000036")]
	[Address(RVA = "0x5CD960", Offset = "0x5CBF60", VA = "0x1805CD960")]
	public EvalAmbient()
	{
	}

	// Token: 0x04000076 RID: 118
	[Token(Token = "0x4000076")]
	[FieldOffset(Offset = "0x20")]
	public float ambientLuminance;

	// Token: 0x04000077 RID: 119
	[Token(Token = "0x4000077")]
	[FieldOffset(Offset = "0x24")]
	public Color col;

	// Token: 0x04000078 RID: 120
	[Token(Token = "0x4000078")]
	[FieldOffset(Offset = "0x38")]
	private Vector3[] directions;

	// Token: 0x04000079 RID: 121
	[Token(Token = "0x4000079")]
	[FieldOffset(Offset = "0x40")]
	private Color[] ambientLighting;

	// Token: 0x0400007A RID: 122
	[Token(Token = "0x400007A")]
	[FieldOffset(Offset = "0x48")]
	private SphericalHarmonicsL2 ambientProbe;
}
