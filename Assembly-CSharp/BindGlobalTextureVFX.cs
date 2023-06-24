using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.VFX;

// Token: 0x02000034 RID: 52
[Token(Token = "0x2000034")]
public class BindGlobalTextureVFX : MonoBehaviour
{
	// Token: 0x060000C2 RID: 194 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void OnEnable()
	{
	}

	// Token: 0x060000C3 RID: 195 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x5E0440", Offset = "0x5DEA40", VA = "0x1805E0440")]
	private void LateUpdate()
	{
	}

	// Token: 0x060000C4 RID: 196 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x5E0450", Offset = "0x5DEA50", VA = "0x1805E0450")]
	private void UpdateTex()
	{
	}

	// Token: 0x060000C5 RID: 197 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public BindGlobalTextureVFX()
	{
	}

	// Token: 0x04000190 RID: 400
	[Token(Token = "0x4000190")]
	private const string OceanDisplacementName = "OceanDisplacement";

	// Token: 0x04000191 RID: 401
	[Token(Token = "0x4000191")]
	private const string GlobalTextureFactorName = "GlobalTextureFactor";

	// Token: 0x04000192 RID: 402
	[Token(Token = "0x4000192")]
	private const string TerrainHeightMap = "TerrainHeightMap";

	// Token: 0x04000193 RID: 403
	[Token(Token = "0x4000193")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int LdTexArrayAnimatedWaves;

	// Token: 0x04000194 RID: 404
	[Token(Token = "0x4000194")]
	[FieldOffset(Offset = "0x4")]
	private static readonly int OceanWavesOneOverTexResTexelWidth;

	// Token: 0x04000195 RID: 405
	[Token(Token = "0x4000195")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int GlobalHeightMap;

	// Token: 0x04000196 RID: 406
	[Token(Token = "0x4000196")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private VisualEffect _effect;
}
