using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000282 RID: 642
[Token(Token = "0x2000282")]
public class AfsWindFake : MonoBehaviour
{
	// Token: 0x060010A1 RID: 4257 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010A1")]
	[Address(RVA = "0x2FA98E0", Offset = "0x2FA88E0", VA = "0x182FA98E0")]
	private void Awake()
	{
	}

	// Token: 0x060010A2 RID: 4258 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010A2")]
	[Address(RVA = "0x2FA9DD0", Offset = "0x2FA8DD0", VA = "0x182FA9DD0")]
	public void Update()
	{
	}

	// Token: 0x060010A3 RID: 4259 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010A3")]
	[Address(RVA = "0x2FAA320", Offset = "0x2FA9320", VA = "0x182FAA320")]
	private void afsSyncFrequencies()
	{
	}

	// Token: 0x060010A4 RID: 4260 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010A4")]
	[Address(RVA = "0x2FA9FE0", Offset = "0x2FA8FE0", VA = "0x182FA9FE0")]
	private void afsLightingSettings()
	{
	}

	// Token: 0x060010A5 RID: 4261 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010A5")]
	[Address(RVA = "0x2FAA350", Offset = "0x2FA9350", VA = "0x182FAA350")]
	private void afsUpdateWind()
	{
	}

	// Token: 0x060010A6 RID: 4262 RVA: 0x00006000 File Offset: 0x00004200
	[Token(Token = "0x60010A6")]
	[Address(RVA = "0x2FA9A30", Offset = "0x2FA8A30", VA = "0x182FA9A30")]
	private float CubicSmooth(float x)
	{
		return default(float);
	}

	// Token: 0x060010A7 RID: 4263 RVA: 0x00006018 File Offset: 0x00004218
	[Token(Token = "0x60010A7")]
	[Address(RVA = "0x2FA9CC0", Offset = "0x2FA8CC0", VA = "0x182FA9CC0")]
	private float TriangleWave(float x)
	{
		return default(float);
	}

	// Token: 0x060010A8 RID: 4264 RVA: 0x00006030 File Offset: 0x00004230
	[Token(Token = "0x60010A8")]
	[Address(RVA = "0x2FA9C60", Offset = "0x2FA8C60", VA = "0x182FA9C60")]
	private float SmoothTriangleWave(float x)
	{
		return default(float);
	}

	// Token: 0x060010A9 RID: 4265 RVA: 0x00006048 File Offset: 0x00004248
	[Token(Token = "0x60010A9")]
	[Address(RVA = "0x2FA9930", Offset = "0x2FA8930", VA = "0x182FA9930")]
	private Vector4 CubicSmooth(Vector4 x)
	{
		return default(Vector4);
	}

	// Token: 0x060010AA RID: 4266 RVA: 0x00006060 File Offset: 0x00004260
	[Token(Token = "0x60010AA")]
	[Address(RVA = "0x2FA9D00", Offset = "0x2FA8D00", VA = "0x182FA9D00")]
	private Vector4 TriangleWave(Vector4 x)
	{
		return default(Vector4);
	}

	// Token: 0x060010AB RID: 4267 RVA: 0x00006078 File Offset: 0x00004278
	[Token(Token = "0x60010AB")]
	[Address(RVA = "0x2FA9B10", Offset = "0x2FA8B10", VA = "0x182FA9B10")]
	private Vector4 SmoothTriangleWave(Vector4 x)
	{
		return default(Vector4);
	}

	// Token: 0x060010AC RID: 4268 RVA: 0x00006090 File Offset: 0x00004290
	[Token(Token = "0x60010AC")]
	[Address(RVA = "0x2FA9A50", Offset = "0x2FA8A50", VA = "0x182FA9A50")]
	private Vector4 FracVecFour(Vector4 a)
	{
		return default(Vector4);
	}

	// Token: 0x060010AD RID: 4269 RVA: 0x000060A8 File Offset: 0x000042A8
	[Token(Token = "0x60010AD")]
	[Address(RVA = "0x2FA9890", Offset = "0x2FA8890", VA = "0x182FA9890")]
	private Vector4 AbsVecFour(Vector4 a)
	{
		return default(Vector4);
	}

	// Token: 0x060010AE RID: 4270 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010AE")]
	[Address(RVA = "0x2FA9DE0", Offset = "0x2FA8DE0", VA = "0x182FA9DE0")]
	public AfsWindFake()
	{
	}

	// Token: 0x04001024 RID: 4132
	[Token(Token = "0x4001024")]
	[FieldOffset(Offset = "0x20")]
	public bool isLinear;

	// Token: 0x04001025 RID: 4133
	[Token(Token = "0x4001025")]
	[FieldOffset(Offset = "0x28")]
	public GameObject DirectionalLightReference;

	// Token: 0x04001026 RID: 4134
	[Token(Token = "0x4001026")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 DirectlightDir;

	// Token: 0x04001027 RID: 4135
	[Token(Token = "0x4001027")]
	[FieldOffset(Offset = "0x40")]
	private Light Sunlight;

	// Token: 0x04001028 RID: 4136
	[Token(Token = "0x4001028")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 SunLightCol;

	// Token: 0x04001029 RID: 4137
	[Token(Token = "0x4001029")]
	[FieldOffset(Offset = "0x54")]
	private float SunLuminance;

	// Token: 0x0400102A RID: 4138
	[Token(Token = "0x400102A")]
	[FieldOffset(Offset = "0x58")]
	public bool GrassApproxTrans;

	// Token: 0x0400102B RID: 4139
	[Token(Token = "0x400102B")]
	[FieldOffset(Offset = "0x5C")]
	[Range(0f, 2f)]
	public float GrassTransStrength;

	// Token: 0x0400102C RID: 4140
	[Token(Token = "0x400102C")]
	[FieldOffset(Offset = "0x60")]
	public Vector4 Wind;

	// Token: 0x0400102D RID: 4141
	[Token(Token = "0x400102D")]
	[FieldOffset(Offset = "0x70")]
	[Range(0.01f, 2f)]
	public float WindFrequency;

	// Token: 0x0400102E RID: 4142
	[Token(Token = "0x400102E")]
	[FieldOffset(Offset = "0x74")]
	[Range(0.1f, 25f)]
	public float WaveSizeFoliageShader;

	// Token: 0x0400102F RID: 4143
	[Token(Token = "0x400102F")]
	[FieldOffset(Offset = "0x78")]
	[Range(0f, 10f)]
	public float LeafTurbulenceFoliageShader;

	// Token: 0x04001030 RID: 4144
	[Token(Token = "0x4001030")]
	[FieldOffset(Offset = "0x7C")]
	[Range(0.01f, 1f)]
	public float WindMultiplierForGrassshader;

	// Token: 0x04001031 RID: 4145
	[Token(Token = "0x4001031")]
	[FieldOffset(Offset = "0x80")]
	[Range(0f, 10f)]
	public float WaveSizeForGrassshader;

	// Token: 0x04001032 RID: 4146
	[Token(Token = "0x4001032")]
	[FieldOffset(Offset = "0x84")]
	[Range(0f, 1f)]
	public float WindJitterFrequencyForGrassshader;

	// Token: 0x04001033 RID: 4147
	[Token(Token = "0x4001033")]
	[FieldOffset(Offset = "0x88")]
	[Range(0f, 1f)]
	public float WindJitterScaleForGrassshader;

	// Token: 0x04001034 RID: 4148
	[Token(Token = "0x4001034")]
	[FieldOffset(Offset = "0x8C")]
	[Range(0f, 100f)]
	public Vector2 AfsSpecFade;

	// Token: 0x04001035 RID: 4149
	[Token(Token = "0x4001035")]
	[FieldOffset(Offset = "0x98")]
	public AnimationCurve WindJitterScaleForGrassshaderCurve;

	// Token: 0x04001036 RID: 4150
	[Token(Token = "0x4001036")]
	[FieldOffset(Offset = "0xA0")]
	public bool SyncWindDir;

	// Token: 0x04001037 RID: 4151
	[Token(Token = "0x4001037")]
	[FieldOffset(Offset = "0xA4")]
	[Range(0f, 10f)]
	public float WindMuliplierForTreeShaderPrimary;

	// Token: 0x04001038 RID: 4152
	[Token(Token = "0x4001038")]
	[FieldOffset(Offset = "0xA8")]
	[Range(0f, 10f)]
	public float WindMuliplierForTreeShaderSecondary;

	// Token: 0x04001039 RID: 4153
	[Token(Token = "0x4001039")]
	[FieldOffset(Offset = "0xAC")]
	public Vector4 WindMuliplierForTreeShader;

	// Token: 0x0400103A RID: 4154
	[Token(Token = "0x400103A")]
	[FieldOffset(Offset = "0xBC")]
	private float temp_WindFrequency;

	// Token: 0x0400103B RID: 4155
	[Token(Token = "0x400103B")]
	[FieldOffset(Offset = "0xC0")]
	private float temp_WindJitterFrequency;

	// Token: 0x0400103C RID: 4156
	[Token(Token = "0x400103C")]
	private const float TwoPI = 6.2831855f;

	// Token: 0x0400103D RID: 4157
	[Token(Token = "0x400103D")]
	[FieldOffset(Offset = "0xC4")]
	private float freqSpeed;

	// Token: 0x0400103E RID: 4158
	[Token(Token = "0x400103E")]
	[FieldOffset(Offset = "0xC8")]
	private float domainTime_Wind;

	// Token: 0x0400103F RID: 4159
	[Token(Token = "0x400103F")]
	[FieldOffset(Offset = "0xCC")]
	private float domainTime_2ndBending;

	// Token: 0x04001040 RID: 4160
	[Token(Token = "0x4001040")]
	[FieldOffset(Offset = "0xD0")]
	private float domainTime_Grass;

	// Token: 0x04001041 RID: 4161
	[Token(Token = "0x4001041")]
	[FieldOffset(Offset = "0xD4")]
	public float DetailDistanceForGrassShader;

	// Token: 0x04001042 RID: 4162
	[Token(Token = "0x4001042")]
	[FieldOffset(Offset = "0xD8")]
	private Vector4 TempWind;

	// Token: 0x04001043 RID: 4163
	[Token(Token = "0x4001043")]
	[FieldOffset(Offset = "0xE8")]
	private float GrassWindSpeed;

	// Token: 0x04001044 RID: 4164
	[Token(Token = "0x4001044")]
	[FieldOffset(Offset = "0xEC")]
	private float SinusWave;

	// Token: 0x04001045 RID: 4165
	[Token(Token = "0x4001045")]
	[FieldOffset(Offset = "0xF0")]
	private Vector4 TriangleWaves;

	// Token: 0x04001046 RID: 4166
	[Token(Token = "0x4001046")]
	[FieldOffset(Offset = "0x100")]
	private float Oscillation;
}
