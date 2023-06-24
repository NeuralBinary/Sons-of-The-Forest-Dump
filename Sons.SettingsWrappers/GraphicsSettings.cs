using System;
using System.Collections.Generic;
using AdvancedTerrainGrass;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Sons.Settings
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	[AddComponentMenu("Sons/Settings/GraphicsSettings")]
	public class GraphicsSettings : MonoBehaviour
	{
		// Token: 0x06000075 RID: 117 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x313D2B0", Offset = "0x313B8B0", VA = "0x18313D2B0")]
		private void AnisotropicQualitySettingChanged(string newValue)
		{
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000215C File Offset: 0x0000035C
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x313D500", Offset = "0x313BB00", VA = "0x18313D500")]
		public static int GetWeatherOcclusionQualityValue(string quality)
		{
			return 0;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x313D620", Offset = "0x313BC20", VA = "0x18313D620")]
		private static string GetDefaultQuality()
		{
			return null;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x313D690", Offset = "0x313BC90", VA = "0x18313D690")]
		private void OnEnable()
		{
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x313DC40", Offset = "0x313C240", VA = "0x18313DC40")]
		private void BillboardQualitySettingChanged(string newValue)
		{
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x313DD50", Offset = "0x313C350", VA = "0x18313DD50")]
		private void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
		{
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x313DDF0", Offset = "0x313C3F0", VA = "0x18313DDF0")]
		private void OnDisable()
		{
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x313DEF0", Offset = "0x313C4F0", VA = "0x18313DEF0")]
		private static void DrawDistanceSettingChanged(string newValue)
		{
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x313DF30", Offset = "0x313C530", VA = "0x18313DF30")]
		private void DlssSettingChanged(string newValue)
		{
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x313DF80", Offset = "0x313C580", VA = "0x18313DF80")]
		private void AntiAliasSettingChanged(string newValue)
		{
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x313DFD0", Offset = "0x313C5D0", VA = "0x18313DFD0")]
		private void DynamicResolutionSettingChanged(string newValue)
		{
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x313E1E0", Offset = "0x313C7E0", VA = "0x18313E1E0")]
		private void DynamicResolutionTargetSettingChanged(string newValue)
		{
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x313E320", Offset = "0x313C920", VA = "0x18313E320")]
		private void TextureResolutionChanged(string newValue)
		{
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002174 File Offset: 0x00000374
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x313E4D0", Offset = "0x313CAD0", VA = "0x18313E4D0")]
		private bool ValidateGrassManager()
		{
			return default(bool);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x313E750", Offset = "0x313CD50", VA = "0x18313E750")]
		private void CheckGrassManagerUpdate()
		{
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x313E7E0", Offset = "0x313CDE0", VA = "0x18313E7E0")]
		private void GrassQualitySettingChanged(string newValue)
		{
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000085 RID: 133 RVA: 0x0000218C File Offset: 0x0000038C
		[Token(Token = "0x1700000C")]
		public static bool IsRunningOnSteamDeck
		{
			[Token(Token = "0x6000085")]
			[Address(RVA = "0x313E9E0", Offset = "0x313CFE0", VA = "0x18313E9E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000021A4 File Offset: 0x000003A4
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x313EB40", Offset = "0x313D140", VA = "0x18313EB40")]
		private bool ValidateMsColorMapFeature()
		{
			return default(bool);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x313ED00", Offset = "0x313D300", VA = "0x18313ED00")]
		private void CheckTerrainFeatureUpdate()
		{
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x313EF10", Offset = "0x313D510", VA = "0x18313EF10")]
		private void TerrainParallaxDistanceSettingChanged(string newValue)
		{
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x313F0B0", Offset = "0x313D6B0", VA = "0x18313F0B0")]
		private void TerrainTessellationQualitySettingChanged(string newValue)
		{
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x313F270", Offset = "0x313D870", VA = "0x18313F270")]
		private void WaterQualitySettingChanged(string newValue)
		{
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x313F430", Offset = "0x313DA30", VA = "0x18313F430")]
		public GraphicsSettings()
		{
		}

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		public const string AnisotropicQualitySettingKey = "Graphics.AnisotropicQuality";

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		public const string AnisotropicQualitySettingDefault = "ON";

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x20")]
		private string _appliedAnisotropicQuality;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		public const string WeatherOcclusionQualitySettingKey = "Graphics.WeatherOcclusionQuality";

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		public const string WeatherOcclusionQualitySettingDefault = "MEDIUM";

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		private const int WeatherOcclusionQualityLowValue = 8;

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		private const int WeatherOcclusionQualityMediumValue = 16;

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		private const int WeatherOcclusionQualityHighValue = 64;

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x0")]
		public static readonly List<string> OnOffOption;

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x8")]
		public static readonly List<string> HighLowOption;

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x10")]
		public static readonly List<string> HighLowOffOption;

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x18")]
		public static readonly List<string> HighMediumLowOption;

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x20")]
		public static readonly List<string> QualityWithOffOption;

		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		protected const string AntiAliasTaa = "TAA";

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		protected const string AntiAliasFxaa = "FXAA";

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		protected const string AntiAliasSmaa = "SMAA";

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		public const string AntiAliasOff = "OFF";

		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		protected const string ResolutionOption20 = "20";

		// Token: 0x04000083 RID: 131
		[Token(Token = "0x4000083")]
		protected const string ResolutionOption30 = "30";

		// Token: 0x04000084 RID: 132
		[Token(Token = "0x4000084")]
		protected const string ResolutionOption40 = "40";

		// Token: 0x04000085 RID: 133
		[Token(Token = "0x4000085")]
		protected const string ResolutionOption50 = "50";

		// Token: 0x04000086 RID: 134
		[Token(Token = "0x4000086")]
		protected const string ResolutionOption60 = "60";

		// Token: 0x04000087 RID: 135
		[Token(Token = "0x4000087")]
		protected const string ResolutionOption70 = "70";

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000088")]
		protected const string ResolutionOption80 = "80";

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		protected const string ResolutionOption90 = "90";

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		protected const string ResolutionOption100 = "100";

		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		protected const string ResolutionOption110 = "110";

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		protected const string ResolutionOption120 = "120";

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x28")]
		public static readonly List<string> DynamicResolutionTargetOptions;

		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		protected const string ResolutionOption0 = "FULL";

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		protected const string ResolutionOption1 = "HALF";

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		protected const string ResolutionOption2 = "QUARTER";

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		protected const string ResolutionOption3 = "EIGHTH";

		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x30")]
		public static readonly List<string> TextureResolutionOptions;

		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		public const string DrawDistanceSettingKey = "Graphics.DrawDistance";

		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		public const string TextureResolutionSettingKey = "Graphics.TextureResolution";

		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		public const string BillboardQualitySettingKey = "Graphics.BillboardQuality";

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		public const string DlssSettingKey = "Graphics.Dlss";

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		public const string DynamicResolutionTargetSettingKey = "Graphics.DynamicResolutionTarget";

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		public const string TextureResolutionSettingDefault = "FULL";

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		public const string DlssSettingDefault = "Balanced";

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		public const string BillboardQualitySettingDefault = "HIGH";

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		public const string AntiAliasSettingKey = "Graphics.AntiAlias";

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x38")]
		public static string AntiAliasSettingDefault;

		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x40")]
		public static readonly List<string> AntiAliasOptions;

		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x28")]
		private readonly List<object> _registeredActionPairs;

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x48")]
		public static string DynamicResolutionTargetSettingDefault;

		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x30")]
		private bool _dynamicResUpscaleActive;

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		public const string GrassQualitySettingKey = "Graphics.GrassQuality";

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		public const string GrassQualitySettingDefault = "HIGH";

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GrassManager _grassManagerCache;

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GrassManagerProfile _highQualityGrassProfile;

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GrassManagerProfile _mediumQualityGrassProfile;

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GrassManagerProfile _lowQualityGrassProfile;

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x58")]
		private string _appliedGrassQuality;

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x50")]
		private static bool? _isRunningOnSteamDeckCached;

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		public const string TerrainParallaxDistanceSettingKey = "Graphics.TerrainParallaxDistance";

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		public const string TerrainTessellationQualitySettingKey = "Graphics.TerrainTessellationQuality";

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x40000AB")]
		public const string TerrainParallaxDistanceSettingDefault = "HIGH";

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		public const string TerrainTessellationQualitySettingDefault = "HIGH";

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private MSColorMapFeature _msColorMapFeature;

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _highParallaxDistance;

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float _mediumParallaxDistance;

		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _lowParallaxDistance;

		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TerrainTessellationProfile _highTessellationProfile;

		// Token: 0x040000B2 RID: 178
		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private TerrainTessellationProfile _mediumTessellationProfile;

		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private TerrainTessellationProfile _lowTessellationProfile;

		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x54")]
		private static readonly int SonsEnableRefractionOnWater;

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x58")]
		private static readonly int SonsEnableCausticsOnWater;

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		public const string WaterQualitySettingKey = "Graphics.WaterQuality";

		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x40000B7")]
		public const string WaterQualitySettingDefault = "HIGH";

		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x90")]
		private string _appliedWaterQuality;
	}
}
