using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200027D RID: 637
[Token(Token = "0x200027D")]
public class AfsWindFake : MonoBehaviour
{
	// Token: 0x060010EF RID: 4335 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010EF")]
	[Address(RVA = "0x3740980", Offset = "0x373EF80", VA = "0x183740980")]
	private void Awake()
	{
	}

	// Token: 0x060010F0 RID: 4336 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010F0")]
	[Address(RVA = "0x37409D0", Offset = "0x373EFD0", VA = "0x1837409D0")]
	public void Update()
	{
	}

	// Token: 0x060010F1 RID: 4337 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010F1")]
	[Address(RVA = "0x37409E0", Offset = "0x373EFE0", VA = "0x1837409E0")]
	private void afsSyncFrequencies()
	{
	}

	// Token: 0x060010F2 RID: 4338 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010F2")]
	[Address(RVA = "0x3740A10", Offset = "0x373F010", VA = "0x183740A10")]
	private void afsLightingSettings()
	{
	}

	// Token: 0x060010F3 RID: 4339 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010F3")]
	[Address(RVA = "0x3740FA0", Offset = "0x373F5A0", VA = "0x183740FA0")]
	private void afsUpdateWind()
	{
	}

	// Token: 0x060010F4 RID: 4340 RVA: 0x00006270 File Offset: 0x00004470
	[Token(Token = "0x60010F4")]
	[Address(RVA = "0x37416D0", Offset = "0x373FCD0", VA = "0x1837416D0")]
	private float CubicSmooth(float x)
	{
		return 0f;
	}

	// Token: 0x060010F5 RID: 4341 RVA: 0x00006288 File Offset: 0x00004488
	[Token(Token = "0x60010F5")]
	[Address(RVA = "0x37416F0", Offset = "0x373FCF0", VA = "0x1837416F0")]
	private float TriangleWave(float x)
	{
		return 0f;
	}

	// Token: 0x060010F6 RID: 4342 RVA: 0x000062A0 File Offset: 0x000044A0
	[Token(Token = "0x60010F6")]
	[Address(RVA = "0x3741730", Offset = "0x373FD30", VA = "0x183741730")]
	private float SmoothTriangleWave(float x)
	{
		return 0f;
	}

	// Token: 0x060010F7 RID: 4343 RVA: 0x000062B8 File Offset: 0x000044B8
	[Token(Token = "0x60010F7")]
	[Address(RVA = "0x3741790", Offset = "0x373FD90", VA = "0x183741790")]
	private Vector4 CubicSmooth(Vector4 x)
	{
		return default(Vector4);
	}

	// Token: 0x060010F8 RID: 4344 RVA: 0x000062D0 File Offset: 0x000044D0
	[Token(Token = "0x60010F8")]
	[Address(RVA = "0x3741890", Offset = "0x373FE90", VA = "0x183741890")]
	private Vector4 TriangleWave(Vector4 x)
	{
		return default(Vector4);
	}

	// Token: 0x060010F9 RID: 4345 RVA: 0x000062E8 File Offset: 0x000044E8
	[Token(Token = "0x60010F9")]
	[Address(RVA = "0x3741960", Offset = "0x373FF60", VA = "0x183741960")]
	private Vector4 SmoothTriangleWave(Vector4 x)
	{
		return default(Vector4);
	}

	// Token: 0x060010FA RID: 4346 RVA: 0x00006300 File Offset: 0x00004500
	[Token(Token = "0x60010FA")]
	[Address(RVA = "0x3741AB0", Offset = "0x37400B0", VA = "0x183741AB0")]
	private Vector4 FracVecFour(Vector4 a)
	{
		return default(Vector4);
	}

	// Token: 0x060010FB RID: 4347 RVA: 0x00006318 File Offset: 0x00004518
	[Token(Token = "0x60010FB")]
	[Address(RVA = "0x3741B70", Offset = "0x3740170", VA = "0x183741B70")]
	private Vector4 AbsVecFour(Vector4 a)
	{
		return default(Vector4);
	}

	// Token: 0x060010FC RID: 4348 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010FC")]
	[Address(RVA = "0x3741BC0", Offset = "0x37401C0", VA = "0x183741BC0")]
	public AfsWindFake()
	{
	}

	// Token: 0x0400104A RID: 4170
	[Token(Token = "0x400104A")]
	[FieldOffset(Offset = "0x20")]
	public bool isLinear;

	// Token: 0x0400104B RID: 4171
	[Token(Token = "0x400104B")]
	[FieldOffset(Offset = "0x28")]
	public GameObject DirectionalLightReference;

	// Token: 0x0400104C RID: 4172
	[Token(Token = "0x400104C")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 DirectlightDir;

	// Token: 0x0400104D RID: 4173
	[Token(Token = "0x400104D")]
	[FieldOffset(Offset = "0x40")]
	private Light Sunlight;

	// Token: 0x0400104E RID: 4174
	[Token(Token = "0x400104E")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 SunLightCol;

	// Token: 0x0400104F RID: 4175
	[Token(Token = "0x400104F")]
	[FieldOffset(Offset = "0x54")]
	private float SunLuminance;

	// Token: 0x04001050 RID: 4176
	[Token(Token = "0x4001050")]
	[FieldOffset(Offset = "0x58")]
	public bool GrassApproxTrans;

	// Token: 0x04001051 RID: 4177
	[Token(Token = "0x4001051")]
	[FieldOffset(Offset = "0x5C")]
	[Range(0f, 2f)]
	public float GrassTransStrength;

	// Token: 0x04001052 RID: 4178
	[Token(Token = "0x4001052")]
	[FieldOffset(Offset = "0x60")]
	public Vector4 Wind;

	// Token: 0x04001053 RID: 4179
	[Token(Token = "0x4001053")]
	[FieldOffset(Offset = "0x70")]
	[Range(0.01f, 2f)]
	public float WindFrequency;

	// Token: 0x04001054 RID: 4180
	[Token(Token = "0x4001054")]
	[FieldOffset(Offset = "0x74")]
	[Range(0.1f, 25f)]
	public float WaveSizeFoliageShader;

	// Token: 0x04001055 RID: 4181
	[Token(Token = "0x4001055")]
	[FieldOffset(Offset = "0x78")]
	[Range(0f, 10f)]
	public float LeafTurbulenceFoliageShader;

	// Token: 0x04001056 RID: 4182
	[Token(Token = "0x4001056")]
	[FieldOffset(Offset = "0x7C")]
	[Range(0.01f, 1f)]
	public float WindMultiplierForGrassshader;

	// Token: 0x04001057 RID: 4183
	[Token(Token = "0x4001057")]
	[FieldOffset(Offset = "0x80")]
	[Range(0f, 10f)]
	public float WaveSizeForGrassshader;

	// Token: 0x04001058 RID: 4184
	[Token(Token = "0x4001058")]
	[FieldOffset(Offset = "0x84")]
	[Range(0f, 1f)]
	public float WindJitterFrequencyForGrassshader;

	// Token: 0x04001059 RID: 4185
	[Token(Token = "0x4001059")]
	[FieldOffset(Offset = "0x88")]
	[Range(0f, 1f)]
	public float WindJitterScaleForGrassshader;

	// Token: 0x0400105A RID: 4186
	[Token(Token = "0x400105A")]
	[FieldOffset(Offset = "0x8C")]
	[Range(0f, 100f)]
	public Vector2 AfsSpecFade;

	// Token: 0x0400105B RID: 4187
	[Token(Token = "0x400105B")]
	[FieldOffset(Offset = "0x98")]
	public AnimationCurve WindJitterScaleForGrassshaderCurve;

	// Token: 0x0400105C RID: 4188
	[Token(Token = "0x400105C")]
	[FieldOffset(Offset = "0xA0")]
	public bool SyncWindDir;

	// Token: 0x0400105D RID: 4189
	[Token(Token = "0x400105D")]
	[FieldOffset(Offset = "0xA4")]
	[Range(0f, 10f)]
	public float WindMuliplierForTreeShaderPrimary;

	// Token: 0x0400105E RID: 4190
	[Token(Token = "0x400105E")]
	[FieldOffset(Offset = "0xA8")]
	[Range(0f, 10f)]
	public float WindMuliplierForTreeShaderSecondary;

	// Token: 0x0400105F RID: 4191
	[Token(Token = "0x400105F")]
	[FieldOffset(Offset = "0xAC")]
	public Vector4 WindMuliplierForTreeShader;

	// Token: 0x04001060 RID: 4192
	[Token(Token = "0x4001060")]
	[FieldOffset(Offset = "0xBC")]
	private float temp_WindFrequency;

	// Token: 0x04001061 RID: 4193
	[Token(Token = "0x4001061")]
	[FieldOffset(Offset = "0xC0")]
	private float temp_WindJitterFrequency;

	// Token: 0x04001062 RID: 4194
	[Token(Token = "0x4001062")]
	private const float TwoPI = 6.2831855f;

	// Token: 0x04001063 RID: 4195
	[Token(Token = "0x4001063")]
	[FieldOffset(Offset = "0xC4")]
	private float freqSpeed;

	// Token: 0x04001064 RID: 4196
	[Token(Token = "0x4001064")]
	[FieldOffset(Offset = "0xC8")]
	private float domainTime_Wind;

	// Token: 0x04001065 RID: 4197
	[Token(Token = "0x4001065")]
	[FieldOffset(Offset = "0xCC")]
	private float domainTime_2ndBending;

	// Token: 0x04001066 RID: 4198
	[Token(Token = "0x4001066")]
	[FieldOffset(Offset = "0xD0")]
	private float domainTime_Grass;

	// Token: 0x04001067 RID: 4199
	[Token(Token = "0x4001067")]
	[FieldOffset(Offset = "0xD4")]
	public float DetailDistanceForGrassShader;

	// Token: 0x04001068 RID: 4200
	[Token(Token = "0x4001068")]
	[FieldOffset(Offset = "0xD8")]
	private Vector4 TempWind;

	// Token: 0x04001069 RID: 4201
	[Token(Token = "0x4001069")]
	[FieldOffset(Offset = "0xE8")]
	private float GrassWindSpeed;

	// Token: 0x0400106A RID: 4202
	[Token(Token = "0x400106A")]
	[FieldOffset(Offset = "0xEC")]
	private float SinusWave;

	// Token: 0x0400106B RID: 4203
	[Token(Token = "0x400106B")]
	[FieldOffset(Offset = "0xF0")]
	private Vector4 TriangleWaves;

	// Token: 0x0400106C RID: 4204
	[Token(Token = "0x400106C")]
	[FieldOffset(Offset = "0x100")]
	private float Oscillation;
}
