using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.VFX;

// Token: 0x02000033 RID: 51
[Token(Token = "0x2000033")]
public class BindGlobalTextureStreamVFX : MonoBehaviour
{
	// Token: 0x060000BE RID: 190 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x5E0250", Offset = "0x5DE850", VA = "0x1805E0250")]
	private void LateUpdate()
	{
	}

	// Token: 0x060000BF RID: 191 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x5E0250", Offset = "0x5DE850", VA = "0x1805E0250")]
	private void UpdateTex()
	{
	}

	// Token: 0x060000C0 RID: 192 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public BindGlobalTextureStreamVFX()
	{
	}

	// Token: 0x0400018D RID: 397
	[Token(Token = "0x400018D")]
	private const string TerrainHeightMap = "TerrainHeightMap";

	// Token: 0x0400018E RID: 398
	[Token(Token = "0x400018E")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int GlobalHeightMap;

	// Token: 0x0400018F RID: 399
	[Token(Token = "0x400018F")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private VisualEffect _effect;
}
