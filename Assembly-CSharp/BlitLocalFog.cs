using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

// Token: 0x0200001C RID: 28
[Token(Token = "0x200001C")]
[ExecuteAlways]
public class BlitLocalFog : MonoBehaviour
{
	// Token: 0x0600006E RID: 110 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600006E")]
	[Address(RVA = "0x5D59F0", Offset = "0x5D3FF0", VA = "0x1805D59F0")]
	private void OnEnable()
	{
	}

	// Token: 0x0600006F RID: 111 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600006F")]
	[Address(RVA = "0x5D5A00", Offset = "0x5D4000", VA = "0x1805D5A00")]
	private void OnDisable()
	{
	}

	// Token: 0x06000070 RID: 112 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000070")]
	[Address(RVA = "0x5D5BD0", Offset = "0x5D41D0", VA = "0x1805D5BD0")]
	private void Setup()
	{
	}

	// Token: 0x06000071 RID: 113 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000071")]
	[Address(RVA = "0x5D6040", Offset = "0x5D4640", VA = "0x1805D6040")]
	private void Update()
	{
	}

	// Token: 0x06000072 RID: 114 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000072")]
	[Address(RVA = "0x5D61F0", Offset = "0x5D47F0", VA = "0x1805D61F0")]
	public BlitLocalFog()
	{
	}

	// Token: 0x040000E3 RID: 227
	[Token(Token = "0x40000E3")]
	[FieldOffset(Offset = "0x20")]
	public Texture3D _noiseTexture;

	// Token: 0x040000E4 RID: 228
	[Token(Token = "0x40000E4")]
	[FieldOffset(Offset = "0x28")]
	[Range(0.1f, 3f)]
	public float _shapePower;

	// Token: 0x040000E5 RID: 229
	[Token(Token = "0x40000E5")]
	[FieldOffset(Offset = "0x2C")]
	public float _speed;

	// Token: 0x040000E6 RID: 230
	[Token(Token = "0x40000E6")]
	[FieldOffset(Offset = "0x30")]
	public RTSize _resolution;

	// Token: 0x040000E7 RID: 231
	[Token(Token = "0x40000E7")]
	[FieldOffset(Offset = "0x38")]
	public LocalVolumetricFog[] _localVolumetricFogVolumes;

	// Token: 0x040000E8 RID: 232
	[Token(Token = "0x40000E8")]
	[FieldOffset(Offset = "0x40")]
	private ComputeShader _computeBufferShader;

	// Token: 0x040000E9 RID: 233
	[Token(Token = "0x40000E9")]
	[FieldOffset(Offset = "0x48")]
	private int _computeKernel;

	// Token: 0x040000EA RID: 234
	[Token(Token = "0x40000EA")]
	[FieldOffset(Offset = "0x4C")]
	private bool _goodToGo;

	// Token: 0x040000EB RID: 235
	[Token(Token = "0x40000EB")]
	[FieldOffset(Offset = "0x50")]
	private RenderTexture _fogVolume;
}
