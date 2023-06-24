using System;
using Endnight.Types;
using Expanse;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;
using UnityEngine.Serialization;

namespace Sons.Atmosphere
{
	// Token: 0x02000023 RID: 35
	[Token(Token = "0x2000023")]
	[AddComponentMenu("Sons/Atmosphere/BakedAmbient")]
	[Obsolete("Use AmbientManager instead", true)]
	public class BakedAmbient : SingletonBehaviour<BakedAmbient>
	{
		// Token: 0x060000FB RID: 251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x2D3B150", Offset = "0x2D39750", VA = "0x182D3B150")]
		public void ForceMin(bool value)
		{
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x2D3B160", Offset = "0x2D39760", VA = "0x182D3B160")]
		private void LateUpdate()
		{
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x2D3B390", Offset = "0x2D39990", VA = "0x182D3B390")]
		private void DoVolumeDirectApply()
		{
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x2D3B4B0", Offset = "0x2D39AB0", VA = "0x182D3B4B0")]
		private void DoVolumeBlend()
		{
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002958 File Offset: 0x00000B58
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x2D3B5A0", Offset = "0x2D39BA0", VA = "0x182D3B5A0")]
		private bool FetchAndValidateProfile()
		{
			return default(bool);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x2D3B680", Offset = "0x2D39C80", VA = "0x182D3B680")]
		private void DoAmbientApply()
		{
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00002970 File Offset: 0x00000B70
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x2D3B7F0", Offset = "0x2D39DF0", VA = "0x182D3B7F0")]
		private float GetAmbientReflectionMinOffset()
		{
			return 0f;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002988 File Offset: 0x00000B88
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x2D3B810", Offset = "0x2D39E10", VA = "0x182D3B810")]
		private float GetAmbientMinOffset()
		{
			return 0f;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000029A0 File Offset: 0x00000BA0
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x2D3B830", Offset = "0x2D39E30", VA = "0x182D3B830")]
		private float GetLightRotationFactor()
		{
			return 0f;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000029B8 File Offset: 0x00000BB8
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x2D3B960", Offset = "0x2D39F60", VA = "0x182D3B960")]
		private float GetSunLightFactor(CelestialBodyBlock celestialBodyBlock, AnimationCurve sunCurveLum, float lightRotation)
		{
			return 0f;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000029D0 File Offset: 0x00000BD0
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x2D3BA60", Offset = "0x2D3A060", VA = "0x182D3BA60")]
		private float CalculateOffsetAndScale(float offset, float scale, float startValue)
		{
			return 0f;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000029E8 File Offset: 0x00000BE8
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x2D3BA80", Offset = "0x2D3A080", VA = "0x182D3BA80")]
		public static float GetAmbientIntensity()
		{
			return 0f;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00002A00 File Offset: 0x00000C00
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x23C2610", Offset = "0x23C0C10", VA = "0x1823C2610")]
		private float GetAmbientIntensityInternal()
		{
			return 0f;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00002A18 File Offset: 0x00000C18
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x179D730", Offset = "0x179BD30", VA = "0x18179D730")]
		private float GetAmbientReflectionIntensityInternal()
		{
			return 0f;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x2D3BAC0", Offset = "0x2D3A0C0", VA = "0x182D3BAC0")]
		public void ClearCurve()
		{
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x2D3BBA0", Offset = "0x2D3A1A0", VA = "0x182D3BBA0")]
		public void AddKey(float keyTime, float value)
		{
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
		public AnimationCurve GetCurve()
		{
			return null;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
		public void SetCurve(AnimationCurve bakedTargetCurve)
		{
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00002A30 File Offset: 0x00000C30
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x2D3BBB0", Offset = "0x2D3A1B0", VA = "0x182D3BBB0")]
		public static float GetAmbientReflectionIntensity()
		{
			return 0f;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x2D3BC20", Offset = "0x2D3A220", VA = "0x182D3BC20")]
		public static void InsertKey(AnimationCurve curveTarget, float keyTime, float value)
		{
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x2D3C120", Offset = "0x2D3A720", VA = "0x182D3C120")]
		public BakedAmbient()
		{
		}

		// Token: 0x040000D7 RID: 215
		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[FormerlySerializedAs("_curveLum")]
		private AnimationCurve _sunCurveLum;

		// Token: 0x040000D8 RID: 216
		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _sunCurveLumScale;

		// Token: 0x040000D9 RID: 217
		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AnimationCurve _moonCurveLum;

		// Token: 0x040000DA RID: 218
		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _moonCurveLumScale;

		// Token: 0x040000DB RID: 219
		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CelestialBodyBlock _sunLight;

		// Token: 0x040000DC RID: 220
		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CelestialBodyBlock _moonLight;

		// Token: 0x040000DD RID: 221
		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x58")]
		private VolumeProfile _profile;

		// Token: 0x040000DE RID: 222
		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x60")]
		private IndirectLightingController _indirectLightingController;

		// Token: 0x040000DF RID: 223
		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x68")]
		[FormerlySerializedAs("_lightRotation")]
		[SerializeField]
		private float _sunLightRotation;

		// Token: 0x040000E0 RID: 224
		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float _moonLightRotation;

		// Token: 0x040000E1 RID: 225
		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x70")]
		[Header("Indirect")]
		private float _ambientIntensity;

		// Token: 0x040000E2 RID: 226
		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		[FormerlySerializedAs("_ambientBias")]
		private float _ambientMinOffset;

		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _ambientScale;

		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Volume _nightVolume;

		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x88")]
		[Header("Reflection")]
		private float _ambientReflectionIntensity;

		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private float _ambientReflectionMinOffset;

		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float _ambientReflectionScale;

		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x94")]
		private bool _forceMin;
	}
}
