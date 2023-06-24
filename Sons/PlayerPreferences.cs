using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FMOD.Studio;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000239 RID: 569
[Token(Token = "0x2000239")]
public class PlayerPreferences : MonoBehaviour
{
	// Token: 0x170001DD RID: 477
	// (get) Token: 0x06000FFE RID: 4094 RVA: 0x00005EC8 File Offset: 0x000040C8
	[Token(Token = "0x170001DD")]
	public static bool VRUseCameraDirectedForwardMovement
	{
		[Token(Token = "0x6000FFE")]
		[Address(RVA = "0x3732BD0", Offset = "0x37311D0", VA = "0x183732BD0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001DE RID: 478
	// (get) Token: 0x06000FFF RID: 4095 RVA: 0x00005EE0 File Offset: 0x000040E0
	[Token(Token = "0x170001DE")]
	public static bool VRUseControllerDirectedForwardMovement
	{
		[Token(Token = "0x6000FFF")]
		[Address(RVA = "0x3732C30", Offset = "0x3731230", VA = "0x183732C30")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001DF RID: 479
	// (get) Token: 0x06001000 RID: 4096 RVA: 0x00005EF8 File Offset: 0x000040F8
	// (set) Token: 0x06001001 RID: 4097 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001DF")]
	public static bool CanUpdateFov
	{
		[Token(Token = "0x6001000")]
		[Address(RVA = "0x3732C90", Offset = "0x3731290", VA = "0x183732C90")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001001")]
		[Address(RVA = "0x3732CE0", Offset = "0x37312E0", VA = "0x183732CE0")]
		set
		{
		}
	}

	// Token: 0x170001E0 RID: 480
	// (get) Token: 0x06001002 RID: 4098 RVA: 0x00005F10 File Offset: 0x00004110
	// (set) Token: 0x06001003 RID: 4099 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001E0")]
	public static bool TreeRegrowthLocal
	{
		[Token(Token = "0x6001002")]
		[Address(RVA = "0x3732D40", Offset = "0x3731340", VA = "0x183732D40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001003")]
		[Address(RVA = "0x3732D90", Offset = "0x3731390", VA = "0x183732D90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x170001E1 RID: 481
	// (get) Token: 0x06001004 RID: 4100 RVA: 0x00005F28 File Offset: 0x00004128
	[Token(Token = "0x170001E1")]
	public static bool TreeRegrowth
	{
		[Token(Token = "0x6001004")]
		[Address(RVA = "0x3732DF0", Offset = "0x37313F0", VA = "0x183732DF0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001E2 RID: 482
	// (get) Token: 0x06001005 RID: 4101 RVA: 0x00005F40 File Offset: 0x00004140
	// (set) Token: 0x06001006 RID: 4102 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001E2")]
	public static bool NoDestructionLocal
	{
		[Token(Token = "0x6001005")]
		[Address(RVA = "0x3732F00", Offset = "0x3731500", VA = "0x183732F00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001006")]
		[Address(RVA = "0x3732F50", Offset = "0x3731550", VA = "0x183732F50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x170001E3 RID: 483
	// (get) Token: 0x06001007 RID: 4103 RVA: 0x00005F58 File Offset: 0x00004158
	[Token(Token = "0x170001E3")]
	public static bool NoDestruction
	{
		[Token(Token = "0x6001007")]
		[Address(RVA = "0x3732FB0", Offset = "0x37315B0", VA = "0x183732FB0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170001E4 RID: 484
	// (get) Token: 0x06001008 RID: 4104 RVA: 0x00005F70 File Offset: 0x00004170
	// (set) Token: 0x06001009 RID: 4105 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001E4")]
	public static bool AllowEnemiesCreative
	{
		[Token(Token = "0x6001008")]
		[Address(RVA = "0x37330C0", Offset = "0x37316C0", VA = "0x1837330C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001009")]
		[Address(RVA = "0x3733110", Offset = "0x3731710", VA = "0x183733110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x170001E5 RID: 485
	// (get) Token: 0x0600100A RID: 4106 RVA: 0x00005F88 File Offset: 0x00004188
	// (set) Token: 0x0600100B RID: 4107 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170001E5")]
	public static bool RealisticPlayerDamage
	{
		[Token(Token = "0x600100A")]
		[Address(RVA = "0x3733170", Offset = "0x3731770", VA = "0x183733170")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600100B")]
		[Address(RVA = "0x37331C0", Offset = "0x37317C0", VA = "0x1837331C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x170001E6 RID: 486
	// (get) Token: 0x0600100C RID: 4108 RVA: 0x00005FA0 File Offset: 0x000041A0
	[Token(Token = "0x170001E6")]
	public static bool IsBelowDX11
	{
		[Token(Token = "0x600100C")]
		[Address(RVA = "0x3733220", Offset = "0x3731820", VA = "0x183733220")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600100D RID: 4109 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600100D")]
	[Address(RVA = "0x37333A0", Offset = "0x37319A0", VA = "0x1837333A0")]
	private void Awake()
	{
	}

	// Token: 0x0600100E RID: 4110 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600100E")]
	[Address(RVA = "0x3733670", Offset = "0x3731C70", VA = "0x183733670")]
	private void Start()
	{
	}

	// Token: 0x0600100F RID: 4111 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600100F")]
	[Address(RVA = "0x37337F0", Offset = "0x3731DF0", VA = "0x1837337F0")]
	private void GetExtraMusicBuses()
	{
	}

	// Token: 0x06001010 RID: 4112 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001010")]
	[Address(RVA = "0x3733A70", Offset = "0x3732070", VA = "0x183733A70")]
	private void OnDestroy()
	{
	}

	// Token: 0x06001011 RID: 4113 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001011")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public static void Load()
	{
	}

	// Token: 0x06001012 RID: 4114 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001012")]
	[Address(RVA = "0x3733C30", Offset = "0x3732230", VA = "0x183733C30")]
	public static void SetAudioDriver(string audioDriver, int driverNum = -1)
	{
	}

	// Token: 0x06001013 RID: 4115 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001013")]
	[Address(RVA = "0x3734260", Offset = "0x3732860", VA = "0x183734260")]
	public static IEnumerable<string> GetAudioDrivers()
	{
		return null;
	}

	// Token: 0x06001014 RID: 4116 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001014")]
	[Address(RVA = "0x37342B0", Offset = "0x37328B0", VA = "0x1837342B0")]
	public static void SetLocalTreeRegrowth(bool onoff)
	{
	}

	// Token: 0x06001015 RID: 4117 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001015")]
	[Address(RVA = "0x37343F0", Offset = "0x37329F0", VA = "0x1837343F0")]
	public static void SetLocalNoDestructionMode(bool onoff)
	{
	}

	// Token: 0x06001016 RID: 4118 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001016")]
	[Address(RVA = "0x3734530", Offset = "0x3732B30", VA = "0x183734530")]
	public static void SetAllowCheatsMode(bool onoff)
	{
	}

	// Token: 0x06001017 RID: 4119 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001017")]
	[Address(RVA = "0x3734580", Offset = "0x3732B80", VA = "0x183734580")]
	public static void SetLocalAllowEnemiesCreativeMode(bool onoff)
	{
	}

	// Token: 0x06001018 RID: 4120 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001018")]
	[Address(RVA = "0x37346C0", Offset = "0x3732CC0", VA = "0x1837346C0")]
	public static void SetLocalRealisticPlayerDamage(bool onoff)
	{
	}

	// Token: 0x06001019 RID: 4121 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001019")]
	[Address(RVA = "0x3734830", Offset = "0x3732E30", VA = "0x183734830")]
	public PlayerPreferences()
	{
	}

	// Token: 0x04000EBF RID: 3775
	[Token(Token = "0x4000EBF")]
	private const bool RespectUnityDialogSettings = false;

	// Token: 0x04000EC0 RID: 3776
	[Token(Token = "0x4000EC0")]
	private const string CustomQualityPath = "/TheForestQualitySettings.dat";

	// Token: 0x04000EC1 RID: 3777
	[Token(Token = "0x4000EC1")]
	[FieldOffset(Offset = "0x20")]
	public bool TitleScene;

	// Token: 0x04000EC2 RID: 3778
	[Token(Token = "0x4000EC2")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Warning32Bits;

	// Token: 0x04000EC3 RID: 3779
	[Token(Token = "0x4000EC3")]
	[FieldOffset(Offset = "0x0")]
	private static PlayerPreferences Instance;

	// Token: 0x04000EC4 RID: 3780
	[Token(Token = "0x4000EC4")]
	[FieldOffset(Offset = "0x8")]
	public static int Preset;

	// Token: 0x04000EC5 RID: 3781
	[Token(Token = "0x4000EC5")]
	[FieldOffset(Offset = "0xC")]
	public static float GammaCavesAndNight;

	// Token: 0x04000EC6 RID: 3782
	[Token(Token = "0x4000EC6")]
	[FieldOffset(Offset = "0x10")]
	public static float GammaWorldAndDay;

	// Token: 0x04000EC7 RID: 3783
	[Token(Token = "0x4000EC7")]
	public const float GammaMin = 1.5f;

	// Token: 0x04000EC8 RID: 3784
	[Token(Token = "0x4000EC8")]
	public const float GammaMax = 2.3f;

	// Token: 0x04000EC9 RID: 3785
	[Token(Token = "0x4000EC9")]
	public const float GammaDefault = 2f;

	// Token: 0x04000ECA RID: 3786
	[Token(Token = "0x4000ECA")]
	public const float GammaCavesMin = 2f;

	// Token: 0x04000ECB RID: 3787
	[Token(Token = "0x4000ECB")]
	public const float GammaCavesMax = 2.5f;

	// Token: 0x04000ECC RID: 3788
	[Token(Token = "0x4000ECC")]
	public const float GammaCavesDefault = 2f;

	// Token: 0x04000ECD RID: 3789
	[Token(Token = "0x4000ECD")]
	[FieldOffset(Offset = "0x14")]
	public static float Contrast;

	// Token: 0x04000ECE RID: 3790
	[Token(Token = "0x4000ECE")]
	public const float ContrastMin = 0.9f;

	// Token: 0x04000ECF RID: 3791
	[Token(Token = "0x4000ECF")]
	public const float ContrastMax = 1.15f;

	// Token: 0x04000ED0 RID: 3792
	[Token(Token = "0x4000ED0")]
	public const float ContrastDefault = 1f;

	// Token: 0x04000ED1 RID: 3793
	[Token(Token = "0x4000ED1")]
	[FieldOffset(Offset = "0x18")]
	public static string AudioDriver;

	// Token: 0x04000ED2 RID: 3794
	[Token(Token = "0x4000ED2")]
	[FieldOffset(Offset = "0x20")]
	public static int AudioDriverNum;

	// Token: 0x04000ED3 RID: 3795
	[Token(Token = "0x4000ED3")]
	[FieldOffset(Offset = "0x24")]
	public static float MouseSmoothing;

	// Token: 0x04000ED4 RID: 3796
	[Token(Token = "0x4000ED4")]
	[FieldOffset(Offset = "0x28")]
	public static bool AllowAsync;

	// Token: 0x04000ED5 RID: 3797
	[Token(Token = "0x4000ED5")]
	[FieldOffset(Offset = "0x2C")]
	public static int VRTurnSnap;

	// Token: 0x04000ED6 RID: 3798
	[Token(Token = "0x4000ED6")]
	[FieldOffset(Offset = "0x30")]
	public static PlayerPreferences.VRMoveDarkeningTypes VRMoveDarkening;

	// Token: 0x04000ED7 RID: 3799
	[Token(Token = "0x4000ED7")]
	[FieldOffset(Offset = "0x34")]
	public static PlayerPreferences.VRAntiAliasingTypes VRAntiAliasing;

	// Token: 0x04000ED8 RID: 3800
	[Token(Token = "0x4000ED8")]
	[FieldOffset(Offset = "0x38")]
	public static PlayerPreferences.VRForwardDirectionTypes VRForwardMovement;

	// Token: 0x04000ED9 RID: 3801
	[Token(Token = "0x4000ED9")]
	[FieldOffset(Offset = "0x3C")]
	public static bool VRUsePhysicalCrouching;

	// Token: 0x04000EDA RID: 3802
	[Token(Token = "0x4000EDA")]
	[FieldOffset(Offset = "0x3D")]
	public static bool VRAutoRun;

	// Token: 0x04000EDB RID: 3803
	[Token(Token = "0x4000EDB")]
	[FieldOffset(Offset = "0x3E")]
	public static bool VRUseRightHandedBow;

	// Token: 0x04000EDC RID: 3804
	[Token(Token = "0x4000EDC")]
	[FieldOffset(Offset = "0x3F")]
	public static bool VRUseRightHandedWeapon;

	// Token: 0x04000EDD RID: 3805
	[Token(Token = "0x4000EDD")]
	[FieldOffset(Offset = "0x40")]
	public static float Fov;

	// Token: 0x04000EDE RID: 3806
	[Token(Token = "0x4000EDE")]
	[FieldOffset(Offset = "0x44")]
	private static bool _canUpdateFOV;

	// Token: 0x04000EDF RID: 3807
	[Token(Token = "0x4000EDF")]
	[FieldOffset(Offset = "0x48")]
	public static int MaxFrameRate;

	// Token: 0x04000EE0 RID: 3808
	[Token(Token = "0x4000EE0")]
	[FieldOffset(Offset = "0x4C")]
	public static bool LowQualityPhysics;

	// Token: 0x04000EE1 RID: 3809
	[Token(Token = "0x4000EE1")]
	[FieldOffset(Offset = "0x50")]
	public static string Language;

	// Token: 0x04000EE2 RID: 3810
	[Token(Token = "0x4000EE2")]
	[FieldOffset(Offset = "0x58")]
	public static int GhostTintNum;

	// Token: 0x04000EE3 RID: 3811
	[Token(Token = "0x4000EE3")]
	[FieldOffset(Offset = "0x5C")]
	public static float GhostTintOpacity;

	// Token: 0x04000EE4 RID: 3812
	[Token(Token = "0x4000EE4")]
	public const float GhostTintOpacityDef = 0.0784f;

	// Token: 0x04000EE5 RID: 3813
	[Token(Token = "0x4000EE5")]
	public const float GhostTintOpacityMin = 0.0784f;

	// Token: 0x04000EE6 RID: 3814
	[Token(Token = "0x4000EE6")]
	public const float GhostTintOpacityMax = 0.75f;

	// Token: 0x04000EE7 RID: 3815
	[Token(Token = "0x4000EE7")]
	[FieldOffset(Offset = "0x60")]
	public static float BuildingSnapAngle;

	// Token: 0x04000EE8 RID: 3816
	[Token(Token = "0x4000EE8")]
	[FieldOffset(Offset = "0x64")]
	public static float BuildingSnapRange;

	// Token: 0x04000EE9 RID: 3817
	[Token(Token = "0x4000EE9")]
	[FieldOffset(Offset = "0x68")]
	public static int ColorGrading;

	// Token: 0x04000EEA RID: 3818
	[Token(Token = "0x4000EEA")]
	[FieldOffset(Offset = "0x6C")]
	public static bool ShowOverlayIcons;

	// Token: 0x04000EEB RID: 3819
	[Token(Token = "0x4000EEB")]
	[FieldOffset(Offset = "0x6D")]
	public static bool OverlayIconsGrouping;

	// Token: 0x04000EEC RID: 3820
	[Token(Token = "0x4000EEC")]
	[FieldOffset(Offset = "0x6E")]
	public static bool ShowProjectileReticle;

	// Token: 0x04000EED RID: 3821
	[Token(Token = "0x4000EED")]
	[FieldOffset(Offset = "0x6F")]
	public static bool UseXInput;

	// Token: 0x04000EEE RID: 3822
	[Token(Token = "0x4000EEE")]
	[FieldOffset(Offset = "0x70")]
	public static bool LowMemoryMode;

	// Token: 0x04000EEF RID: 3823
	[Token(Token = "0x4000EEF")]
	[FieldOffset(Offset = "0x71")]
	public static bool MemorySafeSaveMode;

	// Token: 0x04000EF0 RID: 3824
	[Token(Token = "0x4000EF0")]
	[FieldOffset(Offset = "0x72")]
	public static bool ShowPlayerNamesMP;

	// Token: 0x04000EF1 RID: 3825
	[Token(Token = "0x4000EF1")]
	[FieldOffset(Offset = "0x73")]
	public static bool ShowStealthMeter;

	// Token: 0x04000EF2 RID: 3826
	[Token(Token = "0x4000EF2")]
	[FieldOffset(Offset = "0x74")]
	public static bool UseGamepadCursorSnapping;

	// Token: 0x04000EF4 RID: 3828
	[Token(Token = "0x4000EF4")]
	[FieldOffset(Offset = "0x76")]
	public static bool TreeRegrowthRemote;

	// Token: 0x04000EF6 RID: 3830
	[Token(Token = "0x4000EF6")]
	[FieldOffset(Offset = "0x78")]
	public static bool NoDestructionRemote;

	// Token: 0x04000EF9 RID: 3833
	[Token(Token = "0x4000EF9")]
	[FieldOffset(Offset = "0x7B")]
	public static bool ExWallAutofill;

	// Token: 0x04000EFA RID: 3834
	[Token(Token = "0x4000EFA")]
	[FieldOffset(Offset = "0x7C")]
	public static bool ExFloorsAutofill;

	// Token: 0x04000EFB RID: 3835
	[Token(Token = "0x4000EFB")]
	[FieldOffset(Offset = "0x7D")]
	public static bool PreventSaving;

	// Token: 0x04000EFC RID: 3836
	[Token(Token = "0x4000EFC")]
	[FieldOffset(Offset = "0x7E")]
	private static bool? _isBelowDX11;

	// Token: 0x04000EFD RID: 3837
	[Token(Token = "0x4000EFD")]
	[FieldOffset(Offset = "0x80")]
	public static bool is32bit;

	// Token: 0x04000EFE RID: 3838
	[Token(Token = "0x4000EFE")]
	[FieldOffset(Offset = "0x30")]
	public Terrain activeTerrain;

	// Token: 0x04000EFF RID: 3839
	[Token(Token = "0x4000EFF")]
	[FieldOffset(Offset = "0x81")]
	private static bool alreadyLoaded;

	// Token: 0x04000F00 RID: 3840
	[Token(Token = "0x4000F00")]
	[FieldOffset(Offset = "0x38")]
	private VCA SFXControl;

	// Token: 0x04000F01 RID: 3841
	[Token(Token = "0x4000F01")]
	[FieldOffset(Offset = "0x40")]
	private Bus MusicBus;

	// Token: 0x04000F02 RID: 3842
	[Token(Token = "0x4000F02")]
	[FieldOffset(Offset = "0x48")]
	private Dictionary<string, Bus> SecondaryMusicBuses;

	// Token: 0x04000F03 RID: 3843
	[Token(Token = "0x4000F03")]
	[FieldOffset(Offset = "0x50")]
	private string[] SecondaryMusicBusPaths;

	// Token: 0x0200023A RID: 570
	[Token(Token = "0x200023A")]
	public enum VRMoveDarkeningTypes
	{
		// Token: 0x04000F05 RID: 3845
		[Token(Token = "0x4000F05")]
		OFF,
		// Token: 0x04000F06 RID: 3846
		[Token(Token = "0x4000F06")]
		LOW,
		// Token: 0x04000F07 RID: 3847
		[Token(Token = "0x4000F07")]
		MEDIUM,
		// Token: 0x04000F08 RID: 3848
		[Token(Token = "0x4000F08")]
		HIGH
	}

	// Token: 0x0200023B RID: 571
	[Token(Token = "0x200023B")]
	public enum VRAntiAliasingTypes
	{
		// Token: 0x04000F0A RID: 3850
		[Token(Token = "0x4000F0A")]
		OFF,
		// Token: 0x04000F0B RID: 3851
		[Token(Token = "0x4000F0B")]
		FXAA,
		// Token: 0x04000F0C RID: 3852
		[Token(Token = "0x4000F0C")]
		SMAA
	}

	// Token: 0x0200023C RID: 572
	[Token(Token = "0x200023C")]
	public enum VRForwardDirectionTypes
	{
		// Token: 0x04000F0E RID: 3854
		[Token(Token = "0x4000F0E")]
		CAMERA,
		// Token: 0x04000F0F RID: 3855
		[Token(Token = "0x4000F0F")]
		CONTROLLER,
		// Token: 0x04000F10 RID: 3856
		[Token(Token = "0x4000F10")]
		PLAYER
	}
}
