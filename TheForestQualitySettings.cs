using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000264 RID: 612
[Token(Token = "0x2000264")]
public class TheForestQualitySettings : ScriptableObject
{
	// Token: 0x170001EE RID: 494
	// (get) Token: 0x06001088 RID: 4232 RVA: 0x00005F40 File Offset: 0x00004140
	[Token(Token = "0x170001EE")]
	public float DrawDistanceRatio
	{
		[Token(Token = "0x6001088")]
		[Address(RVA = "0x2FBB440", Offset = "0x2FBA440", VA = "0x182FBB440")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x170001EF RID: 495
	// (get) Token: 0x06001089 RID: 4233 RVA: 0x00005F58 File Offset: 0x00004158
	[Token(Token = "0x170001EF")]
	public float DrawDistanceGreebleRatio
	{
		[Token(Token = "0x6001089")]
		[Address(RVA = "0x2FBB3F0", Offset = "0x2FBA3F0", VA = "0x182FBB3F0")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x170001F0 RID: 496
	// (get) Token: 0x0600108A RID: 4234 RVA: 0x00005F70 File Offset: 0x00004170
	[Token(Token = "0x170001F0")]
	public int MaterialQualityShaderLOD
	{
		[Token(Token = "0x600108A")]
		[Address(RVA = "0x2FBB4A0", Offset = "0x2FBA4A0", VA = "0x182FBB4A0")]
		get
		{
			return default(int);
		}
	}

	// Token: 0x170001F1 RID: 497
	// (get) Token: 0x0600108B RID: 4235 RVA: 0x00005F88 File Offset: 0x00004188
	[Token(Token = "0x170001F1")]
	public float TerrainQualityPixelErrorPercentage
	{
		[Token(Token = "0x600108B")]
		[Address(RVA = "0x2FBB520", Offset = "0x2FBA520", VA = "0x182FBB520")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x170001F2 RID: 498
	// (get) Token: 0x0600108C RID: 4236 RVA: 0x00005FA0 File Offset: 0x000041A0
	// (set) Token: 0x0600108D RID: 4237 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001F2")]
	public TheForestQualitySettings.PostEffectsSystems PostEffectsSystem
	{
		[Token(Token = "0x600108C")]
		[Address(RVA = "0x2FBB4C0", Offset = "0x2FBA4C0", VA = "0x182FBB4C0")]
		get
		{
			return TheForestQualitySettings.PostEffectsSystems.Legacy;
		}
		[Token(Token = "0x600108D")]
		[Address(RVA = "0x23E67A0", Offset = "0x23E57A0", VA = "0x1823E67A0")]
		set
		{
		}
	}

	// Token: 0x170001F3 RID: 499
	// (get) Token: 0x0600108E RID: 4238 RVA: 0x00005FB8 File Offset: 0x000041B8
	// (set) Token: 0x0600108F RID: 4239 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001F3")]
	public TheForestQualitySettings.ShadowCascadeCount CascadeCount
	{
		[Token(Token = "0x600108E")]
		[Address(RVA = "0x986680", Offset = "0x985680", VA = "0x180986680")]
		get
		{
			return TheForestQualitySettings.ShadowCascadeCount.FourCascades;
		}
		[Token(Token = "0x600108F")]
		[Address(RVA = "0x2FBB560", Offset = "0x2FBA560", VA = "0x182FBB560")]
		set
		{
		}
	}

	// Token: 0x06001090 RID: 4240 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001090")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	public static void Save()
	{
	}

	// Token: 0x06001091 RID: 4241 RVA: 0x00005FD0 File Offset: 0x000041D0
	[Token(Token = "0x6001091")]
	[Address(RVA = "0x2FBB110", Offset = "0x2FBA110", VA = "0x182FBB110")]
	public static bool HasSavedSettings()
	{
		return default(bool);
	}

	// Token: 0x170001F4 RID: 500
	// (get) Token: 0x06001092 RID: 4242 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001F4")]
	public static TheForestQualitySettings CurrentPreset
	{
		[Token(Token = "0x6001092")]
		[Address(RVA = "0x2FBB3D0", Offset = "0x2FBA3D0", VA = "0x182FBB3D0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06001093 RID: 4243 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001093")]
	[Address(RVA = "0x2FBB220", Offset = "0x2FBA220", VA = "0x182FBB220")]
	internal static void SetUnityQualityFromShadowLevel(TheForestQualitySettings.ShadowLevels shadowLevel)
	{
	}

	// Token: 0x06001094 RID: 4244 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001094")]
	[Address(RVA = "0x2FBB300", Offset = "0x2FBA300", VA = "0x182FBB300")]
	public static void UpdateUnityQualityShadowResolution(TheForestQualitySettings.ShadowLevels shadowLevel)
	{
	}

	// Token: 0x06001095 RID: 4245 RVA: 0x00005FE8 File Offset: 0x000041E8
	[Token(Token = "0x6001095")]
	[Address(RVA = "0x2FBACD0", Offset = "0x2FB9CD0", VA = "0x182FBACD0")]
	internal static int ConvertToQualityIndex(TheForestQualitySettings.ShadowLevels shadowLevel)
	{
		return default(int);
	}

	// Token: 0x06001096 RID: 4246 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001096")]
	[Address(RVA = "0x2FBAD20", Offset = "0x2FB9D20", VA = "0x182FBAD20")]
	public static TheForestQualitySettings GetPreset(int level = -1)
	{
		return null;
	}

	// Token: 0x06001097 RID: 4247 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001097")]
	[Address(RVA = "0x2FBB1B0", Offset = "0x2FBA1B0", VA = "0x182FBB1B0")]
	public void SetTextureQuality(TheForestQualitySettings.TextureQualities value)
	{
	}

	// Token: 0x06001098 RID: 4248 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001098")]
	[Address(RVA = "0x2FBB150", Offset = "0x2FBA150", VA = "0x182FBB150")]
	public void SetMaterialQuality(TheForestQualitySettings.MaterialQualities value)
	{
	}

	// Token: 0x06001099 RID: 4249 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001099")]
	[Address(RVA = "0x2FBAC80", Offset = "0x2FB9C80", VA = "0x182FBAC80")]
	public void ApplyQualitySetting(Light light, LightShadows defaultValue)
	{
	}

	// Token: 0x0600109A RID: 4250 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600109A")]
	[Address(RVA = "0x2FBB360", Offset = "0x2FBA360", VA = "0x182FBB360")]
	public TheForestQualitySettings()
	{
	}

	// Token: 0x04000F90 RID: 3984
	[Token(Token = "0x4000F90")]
	[FieldOffset(Offset = "0x18")]
	public TheForestQualitySettings.DrawDistances DrawDistance;

	// Token: 0x04000F91 RID: 3985
	[Token(Token = "0x4000F91")]
	[FieldOffset(Offset = "0x1C")]
	public TheForestQualitySettings.PresetLevels Preset;

	// Token: 0x04000F92 RID: 3986
	[Token(Token = "0x4000F92")]
	[FieldOffset(Offset = "0x20")]
	public TheForestQualitySettings.MotionBlurQuality MotionBlur;

	// Token: 0x04000F93 RID: 3987
	[Token(Token = "0x4000F93")]
	[FieldOffset(Offset = "0x24")]
	public float GrassDistance;

	// Token: 0x04000F94 RID: 3988
	[Token(Token = "0x4000F94")]
	[FieldOffset(Offset = "0x28")]
	public TheForestQualitySettings.GrassModes GrassMode;

	// Token: 0x04000F95 RID: 3989
	[Token(Token = "0x4000F95")]
	[FieldOffset(Offset = "0x2C")]
	public float GrassDensity;

	// Token: 0x04000F96 RID: 3990
	[Token(Token = "0x4000F96")]
	[FieldOffset(Offset = "0x30")]
	public TheForestQualitySettings.SSAOTypes SSAOType;

	// Token: 0x04000F97 RID: 3991
	[Token(Token = "0x4000F97")]
	[FieldOffset(Offset = "0x34")]
	public TheForestQualitySettings.SSAOTechnique SSAO;

	// Token: 0x04000F98 RID: 3992
	[Token(Token = "0x4000F98")]
	[FieldOffset(Offset = "0x38")]
	public TheForestQualitySettings.SEBloomTechnique SEBloom;

	// Token: 0x04000F99 RID: 3993
	[Token(Token = "0x4000F99")]
	[FieldOffset(Offset = "0x3C")]
	public TheForestQualitySettings.ChromaticAberration CA;

	// Token: 0x04000F9A RID: 3994
	[Token(Token = "0x4000F9A")]
	[FieldOffset(Offset = "0x40")]
	public TheForestQualitySettings.FilmGrain Fg;

	// Token: 0x04000F9B RID: 3995
	[Token(Token = "0x4000F9B")]
	[FieldOffset(Offset = "0x44")]
	public TheForestQualitySettings.Dof DofTech;

	// Token: 0x04000F9C RID: 3996
	[Token(Token = "0x4000F9C")]
	[FieldOffset(Offset = "0x48")]
	public TheForestQualitySettings.ScreenSpaceReflection screenSpaceReflection;

	// Token: 0x04000F9D RID: 3997
	[Token(Token = "0x4000F9D")]
	[FieldOffset(Offset = "0x4C")]
	public TheForestQualitySettings.VolumetricClouds volumetricClouds;

	// Token: 0x04000F9E RID: 3998
	[Token(Token = "0x4000F9E")]
	[FieldOffset(Offset = "0x50")]
	public TheForestQualitySettings.SunshineOcclusionOn SunshineOcclusion;

	// Token: 0x04000F9F RID: 3999
	[Token(Token = "0x4000F9F")]
	[FieldOffset(Offset = "0x54")]
	public TheForestQualitySettings.VolumetricsTypes VolumetricsType;

	// Token: 0x04000FA0 RID: 4000
	[Token(Token = "0x4000FA0")]
	[FieldOffset(Offset = "0x58")]
	public TheForestQualitySettings.SkyLightingOn SkyLighting;

	// Token: 0x04000FA1 RID: 4001
	[Token(Token = "0x4000FA1")]
	[FieldOffset(Offset = "0x5C")]
	private TheForestQualitySettings.PostEffectsSystems _postEffectSystem;

	// Token: 0x04000FA2 RID: 4002
	[Token(Token = "0x4000FA2")]
	[FieldOffset(Offset = "0x60")]
	public TheForestQualitySettings.CausticsOn Caustics;

	// Token: 0x04000FA3 RID: 4003
	[Token(Token = "0x4000FA3")]
	[FieldOffset(Offset = "0x64")]
	public TheForestQualitySettings.AntiAliasingTechnique AntiAliasing;

	// Token: 0x04000FA4 RID: 4004
	[Token(Token = "0x4000FA4")]
	[FieldOffset(Offset = "0x68")]
	public int LightmapResolution;

	// Token: 0x04000FA5 RID: 4005
	[Token(Token = "0x4000FA5")]
	[FieldOffset(Offset = "0x6C")]
	public float LightDistance;

	// Token: 0x04000FA6 RID: 4006
	[Token(Token = "0x4000FA6")]
	[FieldOffset(Offset = "0x70")]
	public int LightmapUpdateIntervalFrames;

	// Token: 0x04000FA7 RID: 4007
	[Token(Token = "0x4000FA7")]
	[FieldOffset(Offset = "0x74")]
	public TheForestQualitySettings.FarShadowModes FarShadowMode;

	// Token: 0x04000FA8 RID: 4008
	[Token(Token = "0x4000FA8")]
	[FieldOffset(Offset = "0x78")]
	public TheForestQualitySettings.TextureQualities TextureQuality;

	// Token: 0x04000FA9 RID: 4009
	[Token(Token = "0x4000FA9")]
	[FieldOffset(Offset = "0x7C")]
	public TheForestQualitySettings.ShadowLevels ShadowLevel;

	// Token: 0x04000FAA RID: 4010
	[Token(Token = "0x4000FAA")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private TheForestQualitySettings.ShadowCascadeCount _cascadeCount;

	// Token: 0x04000FAB RID: 4011
	[Token(Token = "0x4000FAB")]
	[FieldOffset(Offset = "0x84")]
	public TheForestQualitySettings.TerrainQualities TerrainQuality;

	// Token: 0x04000FAC RID: 4012
	[Token(Token = "0x4000FAC")]
	[FieldOffset(Offset = "0x88")]
	public TheForestQualitySettings.ReflexionModes ReflexionMode;

	// Token: 0x04000FAD RID: 4013
	[Token(Token = "0x4000FAD")]
	[FieldOffset(Offset = "0x8C")]
	public TheForestQualitySettings.OceanQualities OceanQuality;

	// Token: 0x04000FAE RID: 4014
	[Token(Token = "0x4000FAE")]
	[FieldOffset(Offset = "0x90")]
	public TheForestQualitySettings.MaterialQualities MaterialQuality;

	// Token: 0x04000FAF RID: 4015
	[Token(Token = "0x4000FAF")]
	private const string Prefix = "Quality_v016_";

	// Token: 0x04000FB0 RID: 4016
	[Token(Token = "0x4000FB0")]
	[FieldOffset(Offset = "0x0")]
	private static TheForestQualitySettings[] Presets;

	// Token: 0x04000FB1 RID: 4017
	[Token(Token = "0x4000FB1")]
	[FieldOffset(Offset = "0x8")]
	private static TheForestQualitySettings userSettings;

	// Token: 0x02000265 RID: 613
	[Token(Token = "0x2000265")]
	public enum TerrainQualities
	{
		// Token: 0x04000FB3 RID: 4019
		[Token(Token = "0x4000FB3")]
		POM,
		// Token: 0x04000FB4 RID: 4020
		[Token(Token = "0x4000FB4")]
		PM,
		// Token: 0x04000FB5 RID: 4021
		[Token(Token = "0x4000FB5")]
		SIMPLE
	}

	// Token: 0x02000266 RID: 614
	[Token(Token = "0x2000266")]
	public enum MaterialQualities
	{
		// Token: 0x04000FB7 RID: 4023
		[Token(Token = "0x4000FB7")]
		High,
		// Token: 0x04000FB8 RID: 4024
		[Token(Token = "0x4000FB8")]
		Medium,
		// Token: 0x04000FB9 RID: 4025
		[Token(Token = "0x4000FB9")]
		Low
	}

	// Token: 0x02000267 RID: 615
	[Token(Token = "0x2000267")]
	public enum DrawDistances
	{
		// Token: 0x04000FBB RID: 4027
		[Token(Token = "0x4000FBB")]
		Ultra,
		// Token: 0x04000FBC RID: 4028
		[Token(Token = "0x4000FBC")]
		VeryHigh,
		// Token: 0x04000FBD RID: 4029
		[Token(Token = "0x4000FBD")]
		High,
		// Token: 0x04000FBE RID: 4030
		[Token(Token = "0x4000FBE")]
		Medium,
		// Token: 0x04000FBF RID: 4031
		[Token(Token = "0x4000FBF")]
		Low,
		// Token: 0x04000FC0 RID: 4032
		[Token(Token = "0x4000FC0")]
		UltraLow
	}

	// Token: 0x02000268 RID: 616
	[Token(Token = "0x2000268")]
	public enum SSAOTypes
	{
		// Token: 0x04000FC2 RID: 4034
		[Token(Token = "0x4000FC2")]
		AMPLIFY,
		// Token: 0x04000FC3 RID: 4035
		[Token(Token = "0x4000FC3")]
		UNITY
	}

	// Token: 0x02000269 RID: 617
	[Token(Token = "0x2000269")]
	public enum SSAOTechnique
	{
		// Token: 0x04000FC5 RID: 4037
		[Token(Token = "0x4000FC5")]
		Ultra,
		// Token: 0x04000FC6 RID: 4038
		[Token(Token = "0x4000FC6")]
		High,
		// Token: 0x04000FC7 RID: 4039
		[Token(Token = "0x4000FC7")]
		Low,
		// Token: 0x04000FC8 RID: 4040
		[Token(Token = "0x4000FC8")]
		Off
	}

	// Token: 0x0200026A RID: 618
	[Token(Token = "0x200026A")]
	public enum SEBloomTechnique
	{
		// Token: 0x04000FCA RID: 4042
		[Token(Token = "0x4000FCA")]
		Normal,
		// Token: 0x04000FCB RID: 4043
		[Token(Token = "0x4000FCB")]
		None
	}

	// Token: 0x0200026B RID: 619
	[Token(Token = "0x200026B")]
	public enum ChromaticAberration
	{
		// Token: 0x04000FCD RID: 4045
		[Token(Token = "0x4000FCD")]
		Normal,
		// Token: 0x04000FCE RID: 4046
		[Token(Token = "0x4000FCE")]
		None
	}

	// Token: 0x0200026C RID: 620
	[Token(Token = "0x200026C")]
	public enum FilmGrain
	{
		// Token: 0x04000FD0 RID: 4048
		[Token(Token = "0x4000FD0")]
		Normal,
		// Token: 0x04000FD1 RID: 4049
		[Token(Token = "0x4000FD1")]
		None
	}

	// Token: 0x0200026D RID: 621
	[Token(Token = "0x200026D")]
	public enum ScreenSpaceReflection
	{
		// Token: 0x04000FD3 RID: 4051
		[Token(Token = "0x4000FD3")]
		On,
		// Token: 0x04000FD4 RID: 4052
		[Token(Token = "0x4000FD4")]
		Off
	}

	// Token: 0x0200026E RID: 622
	[Token(Token = "0x200026E")]
	public enum VolumetricClouds
	{
		// Token: 0x04000FD6 RID: 4054
		[Token(Token = "0x4000FD6")]
		On,
		// Token: 0x04000FD7 RID: 4055
		[Token(Token = "0x4000FD7")]
		Off
	}

	// Token: 0x0200026F RID: 623
	[Token(Token = "0x200026F")]
	public enum Dof
	{
		// Token: 0x04000FD9 RID: 4057
		[Token(Token = "0x4000FD9")]
		Normal,
		// Token: 0x04000FDA RID: 4058
		[Token(Token = "0x4000FDA")]
		None
	}

	// Token: 0x02000270 RID: 624
	[Token(Token = "0x2000270")]
	public enum GiOn
	{
		// Token: 0x04000FDC RID: 4060
		[Token(Token = "0x4000FDC")]
		On,
		// Token: 0x04000FDD RID: 4061
		[Token(Token = "0x4000FDD")]
		Off
	}

	// Token: 0x02000271 RID: 625
	[Token(Token = "0x2000271")]
	public enum SkyLightingOn
	{
		// Token: 0x04000FDF RID: 4063
		[Token(Token = "0x4000FDF")]
		On,
		// Token: 0x04000FE0 RID: 4064
		[Token(Token = "0x4000FE0")]
		Off
	}

	// Token: 0x02000272 RID: 626
	[Token(Token = "0x2000272")]
	public enum CausticsOn
	{
		// Token: 0x04000FE2 RID: 4066
		[Token(Token = "0x4000FE2")]
		On,
		// Token: 0x04000FE3 RID: 4067
		[Token(Token = "0x4000FE3")]
		Off
	}

	// Token: 0x02000273 RID: 627
	[Token(Token = "0x2000273")]
	public enum AntiAliasingTechnique
	{
		// Token: 0x04000FE5 RID: 4069
		[Token(Token = "0x4000FE5")]
		None,
		// Token: 0x04000FE6 RID: 4070
		[Token(Token = "0x4000FE6")]
		FXAA,
		// Token: 0x04000FE7 RID: 4071
		[Token(Token = "0x4000FE7")]
		TAA
	}

	// Token: 0x02000274 RID: 628
	[Token(Token = "0x2000274")]
	public enum MotionBlurQuality
	{
		// Token: 0x04000FE9 RID: 4073
		[Token(Token = "0x4000FE9")]
		None,
		// Token: 0x04000FEA RID: 4074
		[Token(Token = "0x4000FEA")]
		Low,
		// Token: 0x04000FEB RID: 4075
		[Token(Token = "0x4000FEB")]
		Medium,
		// Token: 0x04000FEC RID: 4076
		[Token(Token = "0x4000FEC")]
		High,
		// Token: 0x04000FED RID: 4077
		[Token(Token = "0x4000FED")]
		Ultra
	}

	// Token: 0x02000275 RID: 629
	[Token(Token = "0x2000275")]
	public enum FarShadowModes
	{
		// Token: 0x04000FEF RID: 4079
		[Token(Token = "0x4000FEF")]
		On,
		// Token: 0x04000FF0 RID: 4080
		[Token(Token = "0x4000FF0")]
		Off
	}

	// Token: 0x02000276 RID: 630
	[Token(Token = "0x2000276")]
	public enum ShadowLevels
	{
		// Token: 0x04000FF2 RID: 4082
		[Token(Token = "0x4000FF2")]
		VeryHigh,
		// Token: 0x04000FF3 RID: 4083
		[Token(Token = "0x4000FF3")]
		High,
		// Token: 0x04000FF4 RID: 4084
		[Token(Token = "0x4000FF4")]
		Medium,
		// Token: 0x04000FF5 RID: 4085
		[Token(Token = "0x4000FF5")]
		Low,
		// Token: 0x04000FF6 RID: 4086
		[Token(Token = "0x4000FF6")]
		Fastest,
		// Token: 0x04000FF7 RID: 4087
		[Token(Token = "0x4000FF7")]
		UltraLow
	}

	// Token: 0x02000277 RID: 631
	[Token(Token = "0x2000277")]
	public enum ShadowCascadeCount
	{
		// Token: 0x04000FF9 RID: 4089
		[Token(Token = "0x4000FF9")]
		FourCascades,
		// Token: 0x04000FFA RID: 4090
		[Token(Token = "0x4000FFA")]
		TwoCascades,
		// Token: 0x04000FFB RID: 4091
		[Token(Token = "0x4000FFB")]
		NoCascades_low,
		// Token: 0x04000FFC RID: 4092
		[Token(Token = "0x4000FFC")]
		NoCascades_vlow,
		// Token: 0x04000FFD RID: 4093
		[Token(Token = "0x4000FFD")]
		NoCascades_fastest,
		// Token: 0x04000FFE RID: 4094
		[Token(Token = "0x4000FFE")]
		NoCascades_laptop
	}

	// Token: 0x02000278 RID: 632
	[Token(Token = "0x2000278")]
	public enum ReflexionModes
	{
		// Token: 0x04001000 RID: 4096
		[Token(Token = "0x4001000")]
		Complex,
		// Token: 0x04001001 RID: 4097
		[Token(Token = "0x4001001")]
		Simple,
		// Token: 0x04001002 RID: 4098
		[Token(Token = "0x4001002")]
		Off
	}

	// Token: 0x02000279 RID: 633
	[Token(Token = "0x2000279")]
	public enum SunshineOcclusionOn
	{
		// Token: 0x04001004 RID: 4100
		[Token(Token = "0x4001004")]
		On,
		// Token: 0x04001005 RID: 4101
		[Token(Token = "0x4001005")]
		Off
	}

	// Token: 0x0200027A RID: 634
	[Token(Token = "0x200027A")]
	public enum VolumetricsTypes
	{
		// Token: 0x04001007 RID: 4103
		[Token(Token = "0x4001007")]
		Hx,
		// Token: 0x04001008 RID: 4104
		[Token(Token = "0x4001008")]
		Sunshine
	}

	// Token: 0x0200027B RID: 635
	[Token(Token = "0x200027B")]
	public enum PostEffectsSystems
	{
		// Token: 0x0400100A RID: 4106
		[Token(Token = "0x400100A")]
		Legacy,
		// Token: 0x0400100B RID: 4107
		[Token(Token = "0x400100B")]
		DX11
	}

	// Token: 0x0200027C RID: 636
	[Token(Token = "0x200027C")]
	public enum OceanQualities
	{
		// Token: 0x0400100D RID: 4109
		[Token(Token = "0x400100D")]
		WaveDisplacementHigh,
		// Token: 0x0400100E RID: 4110
		[Token(Token = "0x400100E")]
		WaveDisplacementLow,
		// Token: 0x0400100F RID: 4111
		[Token(Token = "0x400100F")]
		Flat
	}

	// Token: 0x0200027D RID: 637
	[Token(Token = "0x200027D")]
	public enum TextureQualities
	{
		// Token: 0x04001011 RID: 4113
		[Token(Token = "0x4001011")]
		FullRes,
		// Token: 0x04001012 RID: 4114
		[Token(Token = "0x4001012")]
		HalfRes,
		// Token: 0x04001013 RID: 4115
		[Token(Token = "0x4001013")]
		QuaterRes
	}

	// Token: 0x0200027E RID: 638
	[Token(Token = "0x200027E")]
	public enum GrassModes
	{
		// Token: 0x04001015 RID: 4117
		[Token(Token = "0x4001015")]
		CPU,
		// Token: 0x04001016 RID: 4118
		[Token(Token = "0x4001016")]
		GPU
	}

	// Token: 0x0200027F RID: 639
	[Token(Token = "0x200027F")]
	[Serializable]
	public enum PresetLevels
	{
		// Token: 0x04001018 RID: 4120
		[Token(Token = "0x4001018")]
		High,
		// Token: 0x04001019 RID: 4121
		[Token(Token = "0x4001019")]
		Medium,
		// Token: 0x0400101A RID: 4122
		[Token(Token = "0x400101A")]
		Low,
		// Token: 0x0400101B RID: 4123
		[Token(Token = "0x400101B")]
		Fastest,
		// Token: 0x0400101C RID: 4124
		[Token(Token = "0x400101C")]
		UltraLow,
		// Token: 0x0400101D RID: 4125
		[Token(Token = "0x400101D")]
		Custom,
		// Token: 0x0400101E RID: 4126
		[Token(Token = "0x400101E")]
		Ps4 = -1,
		// Token: 0x0400101F RID: 4127
		[Token(Token = "0x400101F")]
		DS = -2
	}
}
