using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200025F RID: 607
[Token(Token = "0x200025F")]
public class TheForestQualitySettings : ScriptableObject
{
	// Token: 0x170001F7 RID: 503
	// (get) Token: 0x060010D6 RID: 4310 RVA: 0x000061B0 File Offset: 0x000043B0
	[Token(Token = "0x170001F7")]
	public float DrawDistanceRatio
	{
		[Token(Token = "0x60010D6")]
		[Address(RVA = "0x373F540", Offset = "0x373DB40", VA = "0x18373F540")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170001F8 RID: 504
	// (get) Token: 0x060010D7 RID: 4311 RVA: 0x000061C8 File Offset: 0x000043C8
	[Token(Token = "0x170001F8")]
	public float DrawDistanceGreebleRatio
	{
		[Token(Token = "0x60010D7")]
		[Address(RVA = "0x373F5A0", Offset = "0x373DBA0", VA = "0x18373F5A0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170001F9 RID: 505
	// (get) Token: 0x060010D8 RID: 4312 RVA: 0x000061E0 File Offset: 0x000043E0
	[Token(Token = "0x170001F9")]
	public int MaterialQualityShaderLOD
	{
		[Token(Token = "0x60010D8")]
		[Address(RVA = "0x373F5F0", Offset = "0x373DBF0", VA = "0x18373F5F0")]
		get
		{
			return 0;
		}
	}

	// Token: 0x170001FA RID: 506
	// (get) Token: 0x060010D9 RID: 4313 RVA: 0x000061F8 File Offset: 0x000043F8
	[Token(Token = "0x170001FA")]
	public float TerrainQualityPixelErrorPercentage
	{
		[Token(Token = "0x60010D9")]
		[Address(RVA = "0x373F610", Offset = "0x373DC10", VA = "0x18373F610")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170001FB RID: 507
	// (get) Token: 0x060010DA RID: 4314 RVA: 0x00006210 File Offset: 0x00004410
	// (set) Token: 0x060010DB RID: 4315 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001FB")]
	public TheForestQualitySettings.PostEffectsSystems PostEffectsSystem
	{
		[Token(Token = "0x60010DA")]
		[Address(RVA = "0x373F650", Offset = "0x373DC50", VA = "0x18373F650")]
		get
		{
			return TheForestQualitySettings.PostEffectsSystems.Legacy;
		}
		[Token(Token = "0x60010DB")]
		[Address(RVA = "0x287DC40", Offset = "0x287C240", VA = "0x18287DC40")]
		set
		{
		}
	}

	// Token: 0x170001FC RID: 508
	// (get) Token: 0x060010DC RID: 4316 RVA: 0x00006228 File Offset: 0x00004428
	// (set) Token: 0x060010DD RID: 4317 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001FC")]
	public TheForestQualitySettings.ShadowCascadeCount CascadeCount
	{
		[Token(Token = "0x60010DC")]
		[Address(RVA = "0xAFF2A0", Offset = "0xAFD8A0", VA = "0x180AFF2A0")]
		get
		{
			return TheForestQualitySettings.ShadowCascadeCount.FourCascades;
		}
		[Token(Token = "0x60010DD")]
		[Address(RVA = "0x373F810", Offset = "0x373DE10", VA = "0x18373F810")]
		set
		{
		}
	}

	// Token: 0x060010DE RID: 4318 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010DE")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public static void Save()
	{
	}

	// Token: 0x060010DF RID: 4319 RVA: 0x00006240 File Offset: 0x00004440
	[Token(Token = "0x60010DF")]
	[Address(RVA = "0x373F8F0", Offset = "0x373DEF0", VA = "0x18373F8F0")]
	public static bool HasSavedSettings()
	{
		return default(bool);
	}

	// Token: 0x170001FD RID: 509
	// (get) Token: 0x060010E0 RID: 4320 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001FD")]
	public static TheForestQualitySettings CurrentPreset
	{
		[Token(Token = "0x60010E0")]
		[Address(RVA = "0x373F960", Offset = "0x373DF60", VA = "0x18373F960")]
		get
		{
			return null;
		}
	}

	// Token: 0x060010E1 RID: 4321 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010E1")]
	[Address(RVA = "0x373F9B0", Offset = "0x373DFB0", VA = "0x18373F9B0")]
	internal static void SetUnityQualityFromShadowLevel(TheForestQualitySettings.ShadowLevels shadowLevel)
	{
	}

	// Token: 0x060010E2 RID: 4322 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010E2")]
	[Address(RVA = "0x373FB00", Offset = "0x373E100", VA = "0x18373FB00")]
	public static void UpdateUnityQualityShadowResolution(TheForestQualitySettings.ShadowLevels shadowLevel)
	{
	}

	// Token: 0x060010E3 RID: 4323 RVA: 0x00006258 File Offset: 0x00004458
	[Token(Token = "0x60010E3")]
	[Address(RVA = "0x373FBA0", Offset = "0x373E1A0", VA = "0x18373FBA0")]
	internal static int ConvertToQualityIndex(TheForestQualitySettings.ShadowLevels shadowLevel)
	{
		return 0;
	}

	// Token: 0x060010E4 RID: 4324 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60010E4")]
	[Address(RVA = "0x373FBF0", Offset = "0x373E1F0", VA = "0x18373FBF0")]
	public static TheForestQualitySettings GetPreset(int level = -1)
	{
		return null;
	}

	// Token: 0x060010E5 RID: 4325 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010E5")]
	[Address(RVA = "0x37400E0", Offset = "0x373E6E0", VA = "0x1837400E0")]
	public void SetTextureQuality(TheForestQualitySettings.TextureQualities value)
	{
	}

	// Token: 0x060010E6 RID: 4326 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010E6")]
	[Address(RVA = "0x3740150", Offset = "0x373E750", VA = "0x183740150")]
	public void SetMaterialQuality(TheForestQualitySettings.MaterialQualities value)
	{
	}

	// Token: 0x060010E7 RID: 4327 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010E7")]
	[Address(RVA = "0x3740230", Offset = "0x373E830", VA = "0x183740230")]
	public void ApplyQualitySetting(Light light, LightShadows defaultValue)
	{
	}

	// Token: 0x060010E8 RID: 4328 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010E8")]
	[Address(RVA = "0x37402F0", Offset = "0x373E8F0", VA = "0x1837402F0")]
	public TheForestQualitySettings()
	{
	}

	// Token: 0x04000FB6 RID: 4022
	[Token(Token = "0x4000FB6")]
	[FieldOffset(Offset = "0x18")]
	public TheForestQualitySettings.DrawDistances DrawDistance;

	// Token: 0x04000FB7 RID: 4023
	[Token(Token = "0x4000FB7")]
	[FieldOffset(Offset = "0x1C")]
	public TheForestQualitySettings.PresetLevels Preset;

	// Token: 0x04000FB8 RID: 4024
	[Token(Token = "0x4000FB8")]
	[FieldOffset(Offset = "0x20")]
	public TheForestQualitySettings.MotionBlurQuality MotionBlur;

	// Token: 0x04000FB9 RID: 4025
	[Token(Token = "0x4000FB9")]
	[FieldOffset(Offset = "0x24")]
	public float GrassDistance;

	// Token: 0x04000FBA RID: 4026
	[Token(Token = "0x4000FBA")]
	[FieldOffset(Offset = "0x28")]
	public TheForestQualitySettings.GrassModes GrassMode;

	// Token: 0x04000FBB RID: 4027
	[Token(Token = "0x4000FBB")]
	[FieldOffset(Offset = "0x2C")]
	public float GrassDensity;

	// Token: 0x04000FBC RID: 4028
	[Token(Token = "0x4000FBC")]
	[FieldOffset(Offset = "0x30")]
	public TheForestQualitySettings.SSAOTypes SSAOType;

	// Token: 0x04000FBD RID: 4029
	[Token(Token = "0x4000FBD")]
	[FieldOffset(Offset = "0x34")]
	public TheForestQualitySettings.SSAOTechnique SSAO;

	// Token: 0x04000FBE RID: 4030
	[Token(Token = "0x4000FBE")]
	[FieldOffset(Offset = "0x38")]
	public TheForestQualitySettings.SEBloomTechnique SEBloom;

	// Token: 0x04000FBF RID: 4031
	[Token(Token = "0x4000FBF")]
	[FieldOffset(Offset = "0x3C")]
	public TheForestQualitySettings.ChromaticAberration CA;

	// Token: 0x04000FC0 RID: 4032
	[Token(Token = "0x4000FC0")]
	[FieldOffset(Offset = "0x40")]
	public TheForestQualitySettings.FilmGrain Fg;

	// Token: 0x04000FC1 RID: 4033
	[Token(Token = "0x4000FC1")]
	[FieldOffset(Offset = "0x44")]
	public TheForestQualitySettings.Dof DofTech;

	// Token: 0x04000FC2 RID: 4034
	[Token(Token = "0x4000FC2")]
	[FieldOffset(Offset = "0x48")]
	public TheForestQualitySettings.ScreenSpaceReflection screenSpaceReflection;

	// Token: 0x04000FC3 RID: 4035
	[Token(Token = "0x4000FC3")]
	[FieldOffset(Offset = "0x4C")]
	public TheForestQualitySettings.VolumetricClouds volumetricClouds;

	// Token: 0x04000FC4 RID: 4036
	[Token(Token = "0x4000FC4")]
	[FieldOffset(Offset = "0x50")]
	public TheForestQualitySettings.SunshineOcclusionOn SunshineOcclusion;

	// Token: 0x04000FC5 RID: 4037
	[Token(Token = "0x4000FC5")]
	[FieldOffset(Offset = "0x54")]
	public TheForestQualitySettings.VolumetricsTypes VolumetricsType;

	// Token: 0x04000FC6 RID: 4038
	[Token(Token = "0x4000FC6")]
	[FieldOffset(Offset = "0x58")]
	public TheForestQualitySettings.SkyLightingOn SkyLighting;

	// Token: 0x04000FC7 RID: 4039
	[Token(Token = "0x4000FC7")]
	[FieldOffset(Offset = "0x5C")]
	private TheForestQualitySettings.PostEffectsSystems _postEffectSystem;

	// Token: 0x04000FC8 RID: 4040
	[Token(Token = "0x4000FC8")]
	[FieldOffset(Offset = "0x60")]
	public TheForestQualitySettings.CausticsOn Caustics;

	// Token: 0x04000FC9 RID: 4041
	[Token(Token = "0x4000FC9")]
	[FieldOffset(Offset = "0x64")]
	public TheForestQualitySettings.AntiAliasingTechnique AntiAliasing;

	// Token: 0x04000FCA RID: 4042
	[Token(Token = "0x4000FCA")]
	[FieldOffset(Offset = "0x68")]
	public int LightmapResolution;

	// Token: 0x04000FCB RID: 4043
	[Token(Token = "0x4000FCB")]
	[FieldOffset(Offset = "0x6C")]
	public float LightDistance;

	// Token: 0x04000FCC RID: 4044
	[Token(Token = "0x4000FCC")]
	[FieldOffset(Offset = "0x70")]
	public int LightmapUpdateIntervalFrames;

	// Token: 0x04000FCD RID: 4045
	[Token(Token = "0x4000FCD")]
	[FieldOffset(Offset = "0x74")]
	public TheForestQualitySettings.FarShadowModes FarShadowMode;

	// Token: 0x04000FCE RID: 4046
	[Token(Token = "0x4000FCE")]
	[FieldOffset(Offset = "0x78")]
	public TheForestQualitySettings.TextureQualities TextureQuality;

	// Token: 0x04000FCF RID: 4047
	[Token(Token = "0x4000FCF")]
	[FieldOffset(Offset = "0x7C")]
	public TheForestQualitySettings.ShadowLevels ShadowLevel;

	// Token: 0x04000FD0 RID: 4048
	[Token(Token = "0x4000FD0")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private TheForestQualitySettings.ShadowCascadeCount _cascadeCount;

	// Token: 0x04000FD1 RID: 4049
	[Token(Token = "0x4000FD1")]
	[FieldOffset(Offset = "0x84")]
	public TheForestQualitySettings.TerrainQualities TerrainQuality;

	// Token: 0x04000FD2 RID: 4050
	[Token(Token = "0x4000FD2")]
	[FieldOffset(Offset = "0x88")]
	public TheForestQualitySettings.ReflexionModes ReflexionMode;

	// Token: 0x04000FD3 RID: 4051
	[Token(Token = "0x4000FD3")]
	[FieldOffset(Offset = "0x8C")]
	public TheForestQualitySettings.OceanQualities OceanQuality;

	// Token: 0x04000FD4 RID: 4052
	[Token(Token = "0x4000FD4")]
	[FieldOffset(Offset = "0x90")]
	public TheForestQualitySettings.MaterialQualities MaterialQuality;

	// Token: 0x04000FD5 RID: 4053
	[Token(Token = "0x4000FD5")]
	private const string Prefix = "Quality_v016_";

	// Token: 0x04000FD6 RID: 4054
	[Token(Token = "0x4000FD6")]
	[FieldOffset(Offset = "0x0")]
	private static TheForestQualitySettings[] Presets;

	// Token: 0x04000FD7 RID: 4055
	[Token(Token = "0x4000FD7")]
	[FieldOffset(Offset = "0x8")]
	private static TheForestQualitySettings userSettings;

	// Token: 0x02000260 RID: 608
	[Token(Token = "0x2000260")]
	public enum TerrainQualities
	{
		// Token: 0x04000FD9 RID: 4057
		[Token(Token = "0x4000FD9")]
		POM,
		// Token: 0x04000FDA RID: 4058
		[Token(Token = "0x4000FDA")]
		PM,
		// Token: 0x04000FDB RID: 4059
		[Token(Token = "0x4000FDB")]
		SIMPLE
	}

	// Token: 0x02000261 RID: 609
	[Token(Token = "0x2000261")]
	public enum MaterialQualities
	{
		// Token: 0x04000FDD RID: 4061
		[Token(Token = "0x4000FDD")]
		High,
		// Token: 0x04000FDE RID: 4062
		[Token(Token = "0x4000FDE")]
		Medium,
		// Token: 0x04000FDF RID: 4063
		[Token(Token = "0x4000FDF")]
		Low
	}

	// Token: 0x02000262 RID: 610
	[Token(Token = "0x2000262")]
	public enum DrawDistances
	{
		// Token: 0x04000FE1 RID: 4065
		[Token(Token = "0x4000FE1")]
		Ultra,
		// Token: 0x04000FE2 RID: 4066
		[Token(Token = "0x4000FE2")]
		VeryHigh,
		// Token: 0x04000FE3 RID: 4067
		[Token(Token = "0x4000FE3")]
		High,
		// Token: 0x04000FE4 RID: 4068
		[Token(Token = "0x4000FE4")]
		Medium,
		// Token: 0x04000FE5 RID: 4069
		[Token(Token = "0x4000FE5")]
		Low,
		// Token: 0x04000FE6 RID: 4070
		[Token(Token = "0x4000FE6")]
		UltraLow
	}

	// Token: 0x02000263 RID: 611
	[Token(Token = "0x2000263")]
	public enum SSAOTypes
	{
		// Token: 0x04000FE8 RID: 4072
		[Token(Token = "0x4000FE8")]
		AMPLIFY,
		// Token: 0x04000FE9 RID: 4073
		[Token(Token = "0x4000FE9")]
		UNITY
	}

	// Token: 0x02000264 RID: 612
	[Token(Token = "0x2000264")]
	public enum SSAOTechnique
	{
		// Token: 0x04000FEB RID: 4075
		[Token(Token = "0x4000FEB")]
		Ultra,
		// Token: 0x04000FEC RID: 4076
		[Token(Token = "0x4000FEC")]
		High,
		// Token: 0x04000FED RID: 4077
		[Token(Token = "0x4000FED")]
		Low,
		// Token: 0x04000FEE RID: 4078
		[Token(Token = "0x4000FEE")]
		Off
	}

	// Token: 0x02000265 RID: 613
	[Token(Token = "0x2000265")]
	public enum SEBloomTechnique
	{
		// Token: 0x04000FF0 RID: 4080
		[Token(Token = "0x4000FF0")]
		Normal,
		// Token: 0x04000FF1 RID: 4081
		[Token(Token = "0x4000FF1")]
		None
	}

	// Token: 0x02000266 RID: 614
	[Token(Token = "0x2000266")]
	public enum ChromaticAberration
	{
		// Token: 0x04000FF3 RID: 4083
		[Token(Token = "0x4000FF3")]
		Normal,
		// Token: 0x04000FF4 RID: 4084
		[Token(Token = "0x4000FF4")]
		None
	}

	// Token: 0x02000267 RID: 615
	[Token(Token = "0x2000267")]
	public enum FilmGrain
	{
		// Token: 0x04000FF6 RID: 4086
		[Token(Token = "0x4000FF6")]
		Normal,
		// Token: 0x04000FF7 RID: 4087
		[Token(Token = "0x4000FF7")]
		None
	}

	// Token: 0x02000268 RID: 616
	[Token(Token = "0x2000268")]
	public enum ScreenSpaceReflection
	{
		// Token: 0x04000FF9 RID: 4089
		[Token(Token = "0x4000FF9")]
		On,
		// Token: 0x04000FFA RID: 4090
		[Token(Token = "0x4000FFA")]
		Off
	}

	// Token: 0x02000269 RID: 617
	[Token(Token = "0x2000269")]
	public enum VolumetricClouds
	{
		// Token: 0x04000FFC RID: 4092
		[Token(Token = "0x4000FFC")]
		On,
		// Token: 0x04000FFD RID: 4093
		[Token(Token = "0x4000FFD")]
		Off
	}

	// Token: 0x0200026A RID: 618
	[Token(Token = "0x200026A")]
	public enum Dof
	{
		// Token: 0x04000FFF RID: 4095
		[Token(Token = "0x4000FFF")]
		Normal,
		// Token: 0x04001000 RID: 4096
		[Token(Token = "0x4001000")]
		None
	}

	// Token: 0x0200026B RID: 619
	[Token(Token = "0x200026B")]
	public enum GiOn
	{
		// Token: 0x04001002 RID: 4098
		[Token(Token = "0x4001002")]
		On,
		// Token: 0x04001003 RID: 4099
		[Token(Token = "0x4001003")]
		Off
	}

	// Token: 0x0200026C RID: 620
	[Token(Token = "0x200026C")]
	public enum SkyLightingOn
	{
		// Token: 0x04001005 RID: 4101
		[Token(Token = "0x4001005")]
		On,
		// Token: 0x04001006 RID: 4102
		[Token(Token = "0x4001006")]
		Off
	}

	// Token: 0x0200026D RID: 621
	[Token(Token = "0x200026D")]
	public enum CausticsOn
	{
		// Token: 0x04001008 RID: 4104
		[Token(Token = "0x4001008")]
		On,
		// Token: 0x04001009 RID: 4105
		[Token(Token = "0x4001009")]
		Off
	}

	// Token: 0x0200026E RID: 622
	[Token(Token = "0x200026E")]
	public enum AntiAliasingTechnique
	{
		// Token: 0x0400100B RID: 4107
		[Token(Token = "0x400100B")]
		None,
		// Token: 0x0400100C RID: 4108
		[Token(Token = "0x400100C")]
		FXAA,
		// Token: 0x0400100D RID: 4109
		[Token(Token = "0x400100D")]
		TAA
	}

	// Token: 0x0200026F RID: 623
	[Token(Token = "0x200026F")]
	public enum MotionBlurQuality
	{
		// Token: 0x0400100F RID: 4111
		[Token(Token = "0x400100F")]
		None,
		// Token: 0x04001010 RID: 4112
		[Token(Token = "0x4001010")]
		Low,
		// Token: 0x04001011 RID: 4113
		[Token(Token = "0x4001011")]
		Medium,
		// Token: 0x04001012 RID: 4114
		[Token(Token = "0x4001012")]
		High,
		// Token: 0x04001013 RID: 4115
		[Token(Token = "0x4001013")]
		Ultra
	}

	// Token: 0x02000270 RID: 624
	[Token(Token = "0x2000270")]
	public enum FarShadowModes
	{
		// Token: 0x04001015 RID: 4117
		[Token(Token = "0x4001015")]
		On,
		// Token: 0x04001016 RID: 4118
		[Token(Token = "0x4001016")]
		Off
	}

	// Token: 0x02000271 RID: 625
	[Token(Token = "0x2000271")]
	public enum ShadowLevels
	{
		// Token: 0x04001018 RID: 4120
		[Token(Token = "0x4001018")]
		VeryHigh,
		// Token: 0x04001019 RID: 4121
		[Token(Token = "0x4001019")]
		High,
		// Token: 0x0400101A RID: 4122
		[Token(Token = "0x400101A")]
		Medium,
		// Token: 0x0400101B RID: 4123
		[Token(Token = "0x400101B")]
		Low,
		// Token: 0x0400101C RID: 4124
		[Token(Token = "0x400101C")]
		Fastest,
		// Token: 0x0400101D RID: 4125
		[Token(Token = "0x400101D")]
		UltraLow
	}

	// Token: 0x02000272 RID: 626
	[Token(Token = "0x2000272")]
	public enum ShadowCascadeCount
	{
		// Token: 0x0400101F RID: 4127
		[Token(Token = "0x400101F")]
		FourCascades,
		// Token: 0x04001020 RID: 4128
		[Token(Token = "0x4001020")]
		TwoCascades,
		// Token: 0x04001021 RID: 4129
		[Token(Token = "0x4001021")]
		NoCascades_low,
		// Token: 0x04001022 RID: 4130
		[Token(Token = "0x4001022")]
		NoCascades_vlow,
		// Token: 0x04001023 RID: 4131
		[Token(Token = "0x4001023")]
		NoCascades_fastest,
		// Token: 0x04001024 RID: 4132
		[Token(Token = "0x4001024")]
		NoCascades_laptop
	}

	// Token: 0x02000273 RID: 627
	[Token(Token = "0x2000273")]
	public enum ReflexionModes
	{
		// Token: 0x04001026 RID: 4134
		[Token(Token = "0x4001026")]
		Complex,
		// Token: 0x04001027 RID: 4135
		[Token(Token = "0x4001027")]
		Simple,
		// Token: 0x04001028 RID: 4136
		[Token(Token = "0x4001028")]
		Off
	}

	// Token: 0x02000274 RID: 628
	[Token(Token = "0x2000274")]
	public enum SunshineOcclusionOn
	{
		// Token: 0x0400102A RID: 4138
		[Token(Token = "0x400102A")]
		On,
		// Token: 0x0400102B RID: 4139
		[Token(Token = "0x400102B")]
		Off
	}

	// Token: 0x02000275 RID: 629
	[Token(Token = "0x2000275")]
	public enum VolumetricsTypes
	{
		// Token: 0x0400102D RID: 4141
		[Token(Token = "0x400102D")]
		Hx,
		// Token: 0x0400102E RID: 4142
		[Token(Token = "0x400102E")]
		Sunshine
	}

	// Token: 0x02000276 RID: 630
	[Token(Token = "0x2000276")]
	public enum PostEffectsSystems
	{
		// Token: 0x04001030 RID: 4144
		[Token(Token = "0x4001030")]
		Legacy,
		// Token: 0x04001031 RID: 4145
		[Token(Token = "0x4001031")]
		DX11
	}

	// Token: 0x02000277 RID: 631
	[Token(Token = "0x2000277")]
	public enum OceanQualities
	{
		// Token: 0x04001033 RID: 4147
		[Token(Token = "0x4001033")]
		WaveDisplacementHigh,
		// Token: 0x04001034 RID: 4148
		[Token(Token = "0x4001034")]
		WaveDisplacementLow,
		// Token: 0x04001035 RID: 4149
		[Token(Token = "0x4001035")]
		Flat
	}

	// Token: 0x02000278 RID: 632
	[Token(Token = "0x2000278")]
	public enum TextureQualities
	{
		// Token: 0x04001037 RID: 4151
		[Token(Token = "0x4001037")]
		FullRes,
		// Token: 0x04001038 RID: 4152
		[Token(Token = "0x4001038")]
		HalfRes,
		// Token: 0x04001039 RID: 4153
		[Token(Token = "0x4001039")]
		QuaterRes
	}

	// Token: 0x02000279 RID: 633
	[Token(Token = "0x2000279")]
	public enum GrassModes
	{
		// Token: 0x0400103B RID: 4155
		[Token(Token = "0x400103B")]
		CPU,
		// Token: 0x0400103C RID: 4156
		[Token(Token = "0x400103C")]
		GPU
	}

	// Token: 0x0200027A RID: 634
	[Token(Token = "0x200027A")]
	[Serializable]
	public enum PresetLevels
	{
		// Token: 0x0400103E RID: 4158
		[Token(Token = "0x400103E")]
		High,
		// Token: 0x0400103F RID: 4159
		[Token(Token = "0x400103F")]
		Medium,
		// Token: 0x04001040 RID: 4160
		[Token(Token = "0x4001040")]
		Low,
		// Token: 0x04001041 RID: 4161
		[Token(Token = "0x4001041")]
		Fastest,
		// Token: 0x04001042 RID: 4162
		[Token(Token = "0x4001042")]
		UltraLow,
		// Token: 0x04001043 RID: 4163
		[Token(Token = "0x4001043")]
		Custom,
		// Token: 0x04001044 RID: 4164
		[Token(Token = "0x4001044")]
		Ps4 = -1,
		// Token: 0x04001045 RID: 4165
		[Token(Token = "0x4001045")]
		DS = -2
	}
}
