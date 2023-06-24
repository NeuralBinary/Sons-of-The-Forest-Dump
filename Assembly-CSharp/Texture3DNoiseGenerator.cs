using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000026 RID: 38
[Token(Token = "0x2000026")]
public class Texture3DNoiseGenerator : MonoBehaviour
{
	// Token: 0x06000096 RID: 150 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x6000096")]
	[Address(RVA = "0x5DB950", Offset = "0x5D9F50", VA = "0x1805DB950")]
	public Texture3D GenerateNoise()
	{
		return null;
	}

	// Token: 0x06000097 RID: 151 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000097")]
	[Address(RVA = "0x5DBB80", Offset = "0x5DA180", VA = "0x1805DBB80")]
	public Texture3DNoiseGenerator()
	{
	}

	// Token: 0x04000144 RID: 324
	[Token(Token = "0x4000144")]
	[FieldOffset(Offset = "0x20")]
	[Header("Texture Settings")]
	[SerializeField]
	private int _textureSize;

	// Token: 0x04000145 RID: 325
	[Token(Token = "0x4000145")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private TextureFormat _format;

	// Token: 0x04000146 RID: 326
	[Token(Token = "0x4000146")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Range(1f, 20f)]
	[Header("Noise Settings")]
	private int _octaves;

	// Token: 0x04000147 RID: 327
	[Token(Token = "0x4000147")]
	[FieldOffset(Offset = "0x2C")]
	[Range(1f, 10f)]
	[SerializeField]
	private int _multiplier;

	// Token: 0x04000148 RID: 328
	[Token(Token = "0x4000148")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Range(0f, 15f)]
	private float _amplitude;

	// Token: 0x04000149 RID: 329
	[Token(Token = "0x4000149")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Range(0f, 500f)]
	private float _lacunarity;

	// Token: 0x0400014A RID: 330
	[Token(Token = "0x400014A")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Range(0f, 500f)]
	private float _persistence;
}
