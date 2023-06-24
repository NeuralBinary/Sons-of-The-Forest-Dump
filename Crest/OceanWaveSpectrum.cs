using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x02000066 RID: 102
	[Token(Token = "0x2000066")]
	[CreateAssetMenu(fileName = "OceanWaves", menuName = "Crest/Ocean Wave Spectrum", order = 10000)]
	public class OceanWaveSpectrum : ScriptableObject
	{
		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000273 RID: 627 RVA: 0x00003000 File Offset: 0x00001200
		[Token(Token = "0x1700009F")]
		public float Multiplier
		{
			[Token(Token = "0x6000273")]
			[Address(RVA = "0x623BA0", Offset = "0x6221A0", VA = "0x180623BA0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x623BB0", Offset = "0x6221B0", VA = "0x180623BB0")]
		public void SetMultiplier(float value)
		{
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00003018 File Offset: 0x00001218
		[Token(Token = "0x6000275")]
		[Address(RVA = "0xA0A770", Offset = "0xA08D70", VA = "0x180A0A770")]
		public static float SmallWavelength(float octaveIndex)
		{
			return 0f;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00003030 File Offset: 0x00001230
		[Token(Token = "0x6000276")]
		[Address(RVA = "0xA0A7E0", Offset = "0xA08DE0", VA = "0x180A0A7E0")]
		public static int GetOctaveIndex(float wavelength)
		{
			return 0;
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00003048 File Offset: 0x00001248
		[Token(Token = "0x6000277")]
		[Address(RVA = "0xA0A870", Offset = "0xA08E70", VA = "0x180A0A870")]
		public float GetAmplitude(float wavelength, float componentsPerOctave)
		{
			return 0f;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000278")]
		[Address(RVA = "0xA0ACD0", Offset = "0xA092D0", VA = "0x180A0ACD0")]
		private static void DeepDispersion(float k, float gravity, out float w)
		{
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00003060 File Offset: 0x00001260
		[Token(Token = "0x6000279")]
		[Address(RVA = "0xA0AD10", Offset = "0xA09310", VA = "0x180A0AD10")]
		public float GetAmplitude(float wavelength, float componentsPerOctave, float windSpeed, out float power)
		{
			return 0f;
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00003078 File Offset: 0x00001278
		[Token(Token = "0x600027A")]
		[Address(RVA = "0xA0B250", Offset = "0xA09850", VA = "0x180A0B250")]
		public static float ComputeWaveSpeed(float wavelength, float gravityMultiplier = 1f)
		{
			return 0f;
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027B")]
		[Address(RVA = "0xA0B370", Offset = "0xA09970", VA = "0x180A0B370")]
		public void GenerateWaveData(int componentsPerOctave, ref float[] wavelengths, ref float[] anglesDeg)
		{
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027C")]
		[Address(RVA = "0xA0B670", Offset = "0xA09C70", VA = "0x180A0B670")]
		public void ApplyPhillipsSpectrum(float windSpeed, float smallWavelengthMultiplier)
		{
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027D")]
		[Address(RVA = "0xA0B9C0", Offset = "0xA09FC0", VA = "0x180A0B9C0")]
		public void ApplyPiersonMoskowitzSpectrum(float windSpeed, float smallWavelengthMultiplier)
		{
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027E")]
		[Address(RVA = "0xA0BD40", Offset = "0xA0A340", VA = "0x180A0BD40")]
		public void ApplyJONSWAPSpectrum(float windSpeed, float fetch, float smallWavelengthMultiplier)
		{
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00003090 File Offset: 0x00001290
		[Token(Token = "0x600027F")]
		[Address(RVA = "0xA0BFB0", Offset = "0xA0A5B0", VA = "0x180A0BFB0")]
		private static float PhillipsSpectrum(float windSpeed, Vector2 windDir, float gravity, float wavelength, float angle)
		{
			return 0f;
		}

		// Token: 0x06000280 RID: 640 RVA: 0x000030A8 File Offset: 0x000012A8
		[Token(Token = "0x6000280")]
		[Address(RVA = "0xA0C0C0", Offset = "0xA0A6C0", VA = "0x180A0C0C0")]
		private static float PhilSpectrum(float gravity, float wavelength)
		{
			return 0f;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x000030C0 File Offset: 0x000012C0
		[Token(Token = "0x6000281")]
		[Address(RVA = "0xA0C170", Offset = "0xA0A770", VA = "0x180A0C170")]
		private static float PhilSpectrum(float gravity, float alpha, float wavelength)
		{
			return 0f;
		}

		// Token: 0x06000282 RID: 642 RVA: 0x000030D8 File Offset: 0x000012D8
		[Token(Token = "0x6000282")]
		[Address(RVA = "0xA0C1D0", Offset = "0xA0A7D0", VA = "0x180A0C1D0")]
		private static float PiersonMoskowitzSpectrum(float gravity, float windspeed, float wavelength)
		{
			return 0f;
		}

		// Token: 0x06000283 RID: 643 RVA: 0x000030F0 File Offset: 0x000012F0
		[Token(Token = "0x6000283")]
		[Address(RVA = "0xA0C320", Offset = "0xA0A920", VA = "0x180A0C320")]
		private static float PiersonMoskowitzSpectrum(float gravity, float windspeed, float frequency_peak, float alpha, float wavelength)
		{
			return 0f;
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00003108 File Offset: 0x00001308
		[Token(Token = "0x6000284")]
		[Address(RVA = "0xA0C440", Offset = "0xA0AA40", VA = "0x180A0C440")]
		private static float JONSWAPSpectrum(float gravity, float windspeed, float wavelength, float fetch)
		{
			return 0f;
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000285")]
		[Address(RVA = "0xA0C650", Offset = "0xA0AC50", VA = "0x180A0C650")]
		public OceanWaveSpectrum()
		{
		}

		// Token: 0x04000221 RID: 545
		[Token(Token = "0x4000221")]
		public const int NUM_OCTAVES = 14;

		// Token: 0x04000222 RID: 546
		[Token(Token = "0x4000222")]
		[FieldOffset(Offset = "0x0")]
		public static readonly float SMALLEST_WL_POW_2;

		// Token: 0x04000223 RID: 547
		[Token(Token = "0x4000223")]
		[FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public float _windSpeed;

		// Token: 0x04000224 RID: 548
		[Token(Token = "0x4000224")]
		[FieldOffset(Offset = "0x1C")]
		[HideInInspector]
		public float _fetch;

		// Token: 0x04000225 RID: 549
		[Token(Token = "0x4000225")]
		[FieldOffset(Offset = "0x4")]
		public static readonly float MIN_POWER_LOG;

		// Token: 0x04000226 RID: 550
		[Token(Token = "0x4000226")]
		[FieldOffset(Offset = "0x8")]
		public static readonly float MAX_POWER_LOG;

		// Token: 0x04000227 RID: 551
		[Token(Token = "0x4000227")]
		[FieldOffset(Offset = "0x20")]
		[Range(0f, 180f)]
		[Tooltip("Variance of wave directions, in degrees")]
		public float _waveDirectionVariance;

		// Token: 0x04000228 RID: 552
		[Token(Token = "0x4000228")]
		[FieldOffset(Offset = "0x24")]
		[Range(0f, 25f)]
		[Tooltip("More gravity means faster waves.")]
		public float _gravityScale;

		// Token: 0x04000229 RID: 553
		[Token(Token = "0x4000229")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public float _smallWavelengthMultiplier;

		// Token: 0x0400022A RID: 554
		[Token(Token = "0x400022A")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("Multiplier")]
		[SerializeField]
		[Range(0f, 10f)]
		private float _multiplier;

		// Token: 0x0400022B RID: 555
		[Token(Token = "0x400022B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[HideInInspector]
		private float[] _powerLog;

		// Token: 0x0400022C RID: 556
		[Token(Token = "0x400022C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HideInInspector]
		private bool[] _powerDisabled;

		// Token: 0x0400022D RID: 557
		[Token(Token = "0x400022D")]
		[FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public float[] _chopScales;

		// Token: 0x0400022E RID: 558
		[Token(Token = "0x400022E")]
		[FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public float[] _gravityScales;

		// Token: 0x0400022F RID: 559
		[Token(Token = "0x400022F")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("Scales horizontal displacement")]
		[Range(0f, 2f)]
		public float _chop;
	}
}
