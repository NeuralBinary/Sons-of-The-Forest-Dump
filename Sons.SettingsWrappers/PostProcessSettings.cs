using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

namespace Sons.Settings
{
	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	[AddComponentMenu("Sons/Settings/PostProcessSettings")]
	public class PostProcessSettings : MonoBehaviour
	{
		// Token: 0x060000AE RID: 174 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x3140B00", Offset = "0x313F100", VA = "0x183140B00")]
		private static string GetDefaultQuality()
		{
			return null;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x3140B70", Offset = "0x313F170", VA = "0x183140B70")]
		private void OnEnable()
		{
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x3140BA0", Offset = "0x313F1A0", VA = "0x183140BA0")]
		private void CreateDelayRetry()
		{
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x3140C40", Offset = "0x313F240", VA = "0x183140C40")]
		private IEnumerator RetryInitialize()
		{
			return null;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000022F4 File Offset: 0x000004F4
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x3140CD0", Offset = "0x313F2D0", VA = "0x183140CD0")]
		private bool TryInitialize()
		{
			return default(bool);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x31411F0", Offset = "0x313F7F0", VA = "0x1831411F0")]
		private void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
		{
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x3141820", Offset = "0x313FE20", VA = "0x183141820")]
		private void OnDisable()
		{
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x3141920", Offset = "0x313FF20", VA = "0x183141920")]
		private static void AmbientOcclusionQualitySettingChanged(string newValue)
		{
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x3141A70", Offset = "0x3140070", VA = "0x183141A70")]
		private void ShadowQualitySettingChanged(string newValue)
		{
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x3141AB0", Offset = "0x31400B0", VA = "0x183141AB0")]
		private void FogQualitySettingChanged(string newValue)
		{
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x3141B70", Offset = "0x3140170", VA = "0x183141B70")]
		private static void BloomSettingChanged(bool newValue)
		{
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x3141BD0", Offset = "0x31401D0", VA = "0x183141BD0")]
		private static void AmbientOcclusionSettingChanged(bool newValue)
		{
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x3141C30", Offset = "0x3140230", VA = "0x183141C30")]
		private static void FilmGrainSettingChanged(bool newValue)
		{
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x3141C90", Offset = "0x3140290", VA = "0x183141C90")]
		private static void ColorGradeSettingChanged(string menuValue)
		{
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x3141ED0", Offset = "0x31404D0", VA = "0x183141ED0")]
		private static void CloudTypeSettingChanged(string newValue)
		{
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x3141F80", Offset = "0x3140580", VA = "0x183141F80")]
		private static void MicroShadowingSettingChanged(bool newValue)
		{
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x3141FE0", Offset = "0x31405E0", VA = "0x183141FE0")]
		private static void ChromaticAberrationSettingChanged(bool newValue)
		{
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x3142040", Offset = "0x3140640", VA = "0x183142040")]
		private static void MotionBlurSettingChanged(bool newValue)
		{
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x31420A0", Offset = "0x31406A0", VA = "0x1831420A0")]
		private static void ContactShadowsSettingChanged(bool newValue)
		{
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x3142100", Offset = "0x3140700", VA = "0x183142100")]
		private static void ScreenSpaceReflectionSettingChanged(bool newValue)
		{
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C2")]
		private static void SetPostProcessingComponentActive<T>(bool newValue) where T : VolumeComponent
		{
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x31421A0", Offset = "0x31407A0", VA = "0x1831421A0")]
		public PostProcessSettings()
		{
		}

		// Token: 0x040000DA RID: 218
		[Token(Token = "0x40000DA")]
		protected const string HighOption = "HIGH";

		// Token: 0x040000DB RID: 219
		[Token(Token = "0x40000DB")]
		protected const string LowOption = "LOW";

		// Token: 0x040000DC RID: 220
		[Token(Token = "0x40000DC")]
		public const string OffOption = "OFF";

		// Token: 0x040000DD RID: 221
		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x0")]
		public static readonly List<string> HighLowOption;

		// Token: 0x040000DE RID: 222
		[Token(Token = "0x40000DE")]
		public const string BloomSettingKey = "Graphics.Bloom";

		// Token: 0x040000DF RID: 223
		[Token(Token = "0x40000DF")]
		public const string AmbientOcclusionQualitySettingKey = "Graphics.AmbientOcclusionQuality";

		// Token: 0x040000E0 RID: 224
		[Token(Token = "0x40000E0")]
		public const string QualityPresetSettingKey = "Graphics.QualityPreset";

		// Token: 0x040000E1 RID: 225
		[Token(Token = "0x40000E1")]
		public const string ShadowQualitySettingKey = "Graphics.ShadowQuality";

		// Token: 0x040000E2 RID: 226
		[Token(Token = "0x40000E2")]
		public const string FogQualitySettingKey = "Graphics.FogQuality";

		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x40000E3")]
		public const string FogQualitySettingDefault = "HIGH";

		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x40000E4")]
		public const string CloudTypeSettingKey = "Graphics.CloudType";

		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000E5")]
		public const string MicroShadowingSettingKey = "Graphics.MicroShadowing";

		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x40000E6")]
		public const string ChromaticAberrationSettingKey = "Graphics.ChromaticAberration";

		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x40000E7")]
		public const string MotionBlurSettingKey = "Graphics.MotionBlur";

		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x40000E8")]
		public const string ScreenSpaceReflectionSettingKey = "Graphics.ScreenSpaceReflection";

		// Token: 0x040000E9 RID: 233
		[Token(Token = "0x40000E9")]
		public const string ContactShadowsSettingKey = "Graphics.ContactShadows";

		// Token: 0x040000EA RID: 234
		[Token(Token = "0x40000EA")]
		public const string ColorGradeSettingKey = "Graphics.ColorGrade";

		// Token: 0x040000EB RID: 235
		[Token(Token = "0x40000EB")]
		public const string FilmGrainSettingKey = "Graphics.FilmGrain";

		// Token: 0x040000EC RID: 236
		[Token(Token = "0x40000EC")]
		public const bool BloomSettingDefault = true;

		// Token: 0x040000ED RID: 237
		[Token(Token = "0x40000ED")]
		public const string CloudTypeSettingHigh = "HIGH";

		// Token: 0x040000EE RID: 238
		[Token(Token = "0x40000EE")]
		public const string CloudTypeSettingDefault = "HIGH";

		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000EF")]
		public const bool MicroShadowingSettingDefault = true;

		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		public const bool ChromaticAberrationSettingDefault = true;

		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		public const bool MotionBlurSettingDefault = true;

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		public const bool ScreenSpaceReflectionSettingDefault = true;

		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000F3")]
		public const bool ContactShadowsSettingDefault = true;

		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		public const string ColorGradeSettingDefault = "Default";

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		public const bool FilmGrainSettingDefault = true;

		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<object> _registeredActionPairs;

		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x28")]
		private bool _initialized;
	}
}
