using System;
using System.Collections.Generic;
using Endnight.Types;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;
using UnityEngine.Serialization;

namespace Sons.PostProcessing
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public class PostProcessingManager : MonoBehaviour
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x31116D0", Offset = "0x310FCD0", VA = "0x1831116D0")]
		private void Awake()
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x3111970", Offset = "0x310FF70", VA = "0x183111970")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x3111B00", Offset = "0x3110100", VA = "0x183111B00")]
		private void OnDisable()
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x3111B10", Offset = "0x3110110", VA = "0x183111B10")]
		public static bool HasInstance()
		{
			return default(bool);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x3111BF0", Offset = "0x31101F0", VA = "0x183111BF0")]
		public static Volume GetVolume()
		{
			return null;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002084 File Offset: 0x00000284
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x3111CE0", Offset = "0x31102E0", VA = "0x183111CE0")]
		public static bool TryGetVolumeProfile(out VolumeProfile profile)
		{
			return default(bool);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000209C File Offset: 0x0000029C
		[Token(Token = "0x6000009")]
		public static bool TryGetVolumeComponent<T>(out T result) where T : VolumeComponent
		{
			return default(bool);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000020B4 File Offset: 0x000002B4
		[Token(Token = "0x600000A")]
		public static bool TryGetVolumeComponent<T>(VolumeProfile profile, out T result) where T : VolumeComponent
		{
			return default(bool);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x3111E40", Offset = "0x3110440", VA = "0x183111E40")]
		public static VolumeProfile GetVolumeProfile()
		{
			return null;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000020CC File Offset: 0x000002CC
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x3111E70", Offset = "0x3110470", VA = "0x183111E70")]
		private static bool TryGetVolumeProfile(Volume volume, out VolumeProfile profile)
		{
			return default(bool);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000020E4 File Offset: 0x000002E4
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x3112080", Offset = "0x3110680", VA = "0x183112080")]
		private static bool TryGetSharedOrInstanceVolumeProfile(Volume volume, out VolumeProfile profile)
		{
			return default(bool);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000020FC File Offset: 0x000002FC
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x3112300", Offset = "0x3110900", VA = "0x183112300")]
		public static bool SetCloudLowQuality(bool useLowQuality)
		{
			return default(bool);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x3112530", Offset = "0x3110B30", VA = "0x183112530")]
		public static void DeactivateColorGrade()
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x31126E0", Offset = "0x3110CE0", VA = "0x1831126E0")]
		public static void ActivateColorGrade(string value)
		{
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x3112B10", Offset = "0x3111110", VA = "0x183112B10")]
		private void RefreshBrightness()
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002114 File Offset: 0x00000314
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x3112CB0", Offset = "0x31112B0", VA = "0x183112CB0")]
		public static bool SetBrightnessFactor(float value)
		{
			return default(bool);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x3112DE0", Offset = "0x31113E0", VA = "0x183112DE0")]
		private void RefreshGamma()
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x3112FA0", Offset = "0x31115A0", VA = "0x183112FA0")]
		private void RefreshGammaOnTarget(Volume target, float result)
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000212C File Offset: 0x0000032C
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x3113180", Offset = "0x3111780", VA = "0x183113180")]
		public static bool SetGammaFactor(float value)
		{
			return default(bool);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x31132B0", Offset = "0x31118B0", VA = "0x1831132B0")]
		public static void SetShadowProfiles(HDShadowSettings shadowDaySettings, ShadowsAdditionalSettings addDaySettings, HDShadowSettings shadowTwilightSettings, ShadowsAdditionalSettings addTwilightSettings, HDShadowSettings shadowNightSettings, ShadowsAdditionalSettings addNightSettings)
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x3113430", Offset = "0x3111A30", VA = "0x183113430")]
		private void SetShadowProfilesInternal(HDShadowSettings shadowDaySettings, ShadowsAdditionalSettings addDaySettings, HDShadowSettings shadowTwilightSettings, ShadowsAdditionalSettings addTwilightSettings, HDShadowSettings shadowNightSettings, ShadowsAdditionalSettings addNightSettings)
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000018")]
		public static void ApplyComponent<T>(T target, T source) where T : VolumeComponent
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x3113BE0", Offset = "0x31121E0", VA = "0x183113BE0")]
		public PostProcessingManager()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Volume _volumeTarget;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[FormerlySerializedAs("_cloudTypeOverrideVolumeTarget")]
		private Volume _lowQualityCloudOverrideVolumeTarget;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x30")]
		[FormerlySerializedAs("_brightnessAndGammaOverrideVolumeTarget")]
		[SerializeField]
		private Volume _brightnessOverrideVolumeTarget;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<Volume> _gammaOverrideVolumeTargets;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Volume _shadowTwilightVolume;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Volume _shadowNightVolume;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<NamedGameObject> _colorGrades;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UpdateShadowCascades _sunUpdateShadowCascades;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UpdateShadowCascades _moonUpdateShadowCascades;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x0")]
		private static PostProcessingManager _instance;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x8")]
		private static GameObject _activeColorGradeObject;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x68")]
		private float _currentBrightnessFactor;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x6C")]
		private float _currentGammaFactor;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x70")]
		private float _brightnessValueMinMax;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x74")]
		private float _gammaValueMinMax;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x78")]
		private HDShadowSettings _shadowDaySettings;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x80")]
		private HDShadowSettings _shadowTwilightSettings;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x88")]
		private HDShadowSettings _shadowNightSettings;
	}
}
