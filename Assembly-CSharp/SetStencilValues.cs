using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200001E RID: 30
[Token(Token = "0x200001E")]
public class SetStencilValues : MonoBehaviour
{
	// Token: 0x06000074 RID: 116 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000074")]
	[Address(RVA = "0x5D6250", Offset = "0x5D4850", VA = "0x1805D6250")]
	private void Start()
	{
	}

	// Token: 0x06000075 RID: 117 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000075")]
	[Address(RVA = "0x5D6260", Offset = "0x5D4860", VA = "0x1805D6260")]
	private void OnValidate()
	{
	}

	// Token: 0x06000076 RID: 118 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000076")]
	[Address(RVA = "0x5D6280", Offset = "0x5D4880", VA = "0x1805D6280")]
	private void SetStencils()
	{
	}

	// Token: 0x06000077 RID: 119 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000077")]
	[Address(RVA = "0x5D6430", Offset = "0x5D4A30", VA = "0x1805D6430")]
	public SetStencilValues()
	{
	}

	// Token: 0x040000EF RID: 239
	[Token(Token = "0x40000EF")]
	[FieldOffset(Offset = "0x20")]
	public Material[] terrainLikeMaterials;

	// Token: 0x040000F0 RID: 240
	[Token(Token = "0x40000F0")]
	[FieldOffset(Offset = "0x28")]
	public float TerrainStencilWriteMaskDepth;

	// Token: 0x040000F1 RID: 241
	[Token(Token = "0x40000F1")]
	[FieldOffset(Offset = "0x2C")]
	public float TerrainStencilRef;

	// Token: 0x040000F2 RID: 242
	[Token(Token = "0x40000F2")]
	[FieldOffset(Offset = "0x30")]
	public bool UpdateStencils;

	// Token: 0x040000F3 RID: 243
	[Token(Token = "0x40000F3")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int _StencilWriteMaskDepth;

	// Token: 0x040000F4 RID: 244
	[Token(Token = "0x40000F4")]
	[FieldOffset(Offset = "0x4")]
	private static readonly int _StencilRefDepth;
}
