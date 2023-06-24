using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Assemblies.Sons.Items.Core;
using Endnight.Utilities.Timer;
using Il2CppDummyDll;
using Shapes;
using Sons.Items.Core;
using Sons.Player;
using Sons.Wearable.Armour;
using TMPro;
using UnityEngine;

namespace Sons
{
	// Token: 0x020004D8 RID: 1240
	[Token(Token = "0x20004D8")]
	public class VitalsGui : MonoBehaviour
	{
		// Token: 0x0600206F RID: 8303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600206F")]
		[Address(RVA = "0x3315C90", Offset = "0x3314290", VA = "0x183315C90")]
		public void HideCookingBuffIcons()
		{
		}

		// Token: 0x06002070 RID: 8304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002070")]
		[Address(RVA = "0x3315DE0", Offset = "0x33143E0", VA = "0x183315DE0")]
		public void SetCookingBuffIcon(int index, bool iconEnabled, [Optional] Texture2D icon, [Optional] Texture2D backgroundIcon, int level = 0)
		{
		}

		// Token: 0x06002071 RID: 8305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002071")]
		[Address(RVA = "0x3315F10", Offset = "0x3314510", VA = "0x183315F10")]
		public void SetCookingBuffAIcon(bool iconEnabled, [Optional] Texture2D icon, [Optional] Texture2D backgroundIcon, int level = 0)
		{
		}

		// Token: 0x06002072 RID: 8306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002072")]
		[Address(RVA = "0x3315F80", Offset = "0x3314580", VA = "0x183315F80")]
		public void SetCookingBuffBIcon(bool iconEnabled, [Optional] Texture2D icon, [Optional] Texture2D backgroundIcon, int level = 0)
		{
		}

		// Token: 0x06002073 RID: 8307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002073")]
		[Address(RVA = "0x3315FF0", Offset = "0x33145F0", VA = "0x183315FF0")]
		public void SetCookingBuffCIcon(bool iconEnabled, [Optional] Texture2D icon, [Optional] Texture2D backgroundIcon, int level = 0)
		{
		}

		// Token: 0x06002074 RID: 8308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002074")]
		[Address(RVA = "0x3316060", Offset = "0x3314660", VA = "0x183316060")]
		private void SetCookingBuffIcon(bool iconEnabled, Texture2D icon, Texture2D backgroundIcon, int level, GameObject cookingBuffGroup, ref Material cookingBuffIconMaterialInstance, ref Material cookingBuffIconBackgroundMaterialInstance, MeshRenderer cookingBuffIcon, MeshRenderer cookingBuffIconBackground, List<GameObject> cookingBuffLevels)
		{
		}

		// Token: 0x06002075 RID: 8309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002075")]
		[Address(RVA = "0x3316380", Offset = "0x3314980", VA = "0x183316380")]
		private void VerifyMaterialInstance(ref Material materialInstance, MeshRenderer cookingBuffIcon)
		{
		}

		// Token: 0x06002076 RID: 8310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002076")]
		[Address(RVA = "0x3316640", Offset = "0x3314C40", VA = "0x183316640")]
		private void DestroyCookingBuffMaterialInstances()
		{
		}

		// Token: 0x06002077 RID: 8311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002077")]
		[Address(RVA = "0x3316880", Offset = "0x3314E80", VA = "0x183316880")]
		private void UpdateCookingBuffIcons(StatRecipe activeCookingBuffRecipe)
		{
		}

		// Token: 0x06002078 RID: 8312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002078")]
		[Address(RVA = "0x3316B30", Offset = "0x3315130", VA = "0x183316B30")]
		private void GetIconsFromStatEffectType(StatEffect.Types statEffectType, out Texture2D icon, out Texture2D iconBackground)
		{
		}

		// Token: 0x06002079 RID: 8313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002079")]
		[Address(RVA = "0x3316B60", Offset = "0x3315160", VA = "0x183316B60")]
		private void Start()
		{
		}

		// Token: 0x0600207A RID: 8314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600207A")]
		[Address(RVA = "0x3316FF0", Offset = "0x33155F0", VA = "0x183316FF0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600207B RID: 8315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600207B")]
		[Address(RVA = "0x33170E0", Offset = "0x33156E0", VA = "0x1833170E0")]
		private void Update()
		{
		}

		// Token: 0x0600207C RID: 8316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600207C")]
		[Address(RVA = "0x33170F0", Offset = "0x33156F0", VA = "0x1833170F0")]
		private void RefreshGui()
		{
		}

		// Token: 0x0600207D RID: 8317 RVA: 0x00009840 File Offset: 0x00007A40
		[Token(Token = "0x600207D")]
		[Address(RVA = "0x3317E80", Offset = "0x3316480", VA = "0x183317E80")]
		private bool VerifyObjects()
		{
			return default(bool);
		}

		// Token: 0x0600207E RID: 8318 RVA: 0x00009858 File Offset: 0x00007A58
		[Token(Token = "0x600207E")]
		[Address(RVA = "0x3317ED0", Offset = "0x33164D0", VA = "0x183317ED0")]
		private bool VerifyArmourObject()
		{
			return default(bool);
		}

		// Token: 0x0600207F RID: 8319 RVA: 0x00009870 File Offset: 0x00007A70
		[Token(Token = "0x600207F")]
		[Address(RVA = "0x33180C0", Offset = "0x33166C0", VA = "0x1833180C0")]
		private bool VerifyVisibilityObject()
		{
			return default(bool);
		}

		// Token: 0x06002080 RID: 8320 RVA: 0x00009888 File Offset: 0x00007A88
		[Token(Token = "0x6002080")]
		[Address(RVA = "0x3318390", Offset = "0x3316990", VA = "0x183318390")]
		private bool VerifyStatsObject()
		{
			return default(bool);
		}

		// Token: 0x06002081 RID: 8321 RVA: 0x000098A0 File Offset: 0x00007AA0
		[Token(Token = "0x6002081")]
		[Address(RVA = "0x3318580", Offset = "0x3316B80", VA = "0x183318580")]
		private bool VerifyVitalsObject()
		{
			return default(bool);
		}

		// Token: 0x06002082 RID: 8322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002082")]
		[Address(RVA = "0x3318770", Offset = "0x3316D70", VA = "0x183318770")]
		private void UpdateCooking()
		{
		}

		// Token: 0x06002083 RID: 8323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002083")]
		[Address(RVA = "0x3318AE0", Offset = "0x33170E0", VA = "0x183318AE0")]
		private void SetCookingGui(bool value)
		{
		}

		// Token: 0x06002084 RID: 8324 RVA: 0x000098B8 File Offset: 0x00007AB8
		[Token(Token = "0x6002084")]
		[Address(RVA = "0x3318C00", Offset = "0x3317200", VA = "0x183318C00")]
		private bool ShouldShowCooking()
		{
			return default(bool);
		}

		// Token: 0x06002085 RID: 8325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002085")]
		[Address(RVA = "0x3318CF0", Offset = "0x33172F0", VA = "0x183318CF0")]
		private void UpdateStealth()
		{
		}

		// Token: 0x06002086 RID: 8326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002086")]
		[Address(RVA = "0x3318F70", Offset = "0x3317570", VA = "0x183318F70")]
		private void SetStealthGui(bool value)
		{
		}

		// Token: 0x06002087 RID: 8327 RVA: 0x000098D0 File Offset: 0x00007AD0
		[Token(Token = "0x6002087")]
		[Address(RVA = "0x3319090", Offset = "0x3317690", VA = "0x183319090")]
		private bool ShouldShowStealth()
		{
			return default(bool);
		}

		// Token: 0x06002088 RID: 8328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002088")]
		[Address(RVA = "0x33190B0", Offset = "0x33176B0", VA = "0x1833190B0")]
		private void ApplyStealth(VitalsGui.VitalElementDef stealthElementDef, float currentStealthFactor, Material iconMaterial, Color eyeFullColor, Color eyeEmptyColor, Color fullColor, Color emptyColor)
		{
		}

		// Token: 0x06002089 RID: 8329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002089")]
		[Address(RVA = "0x3319220", Offset = "0x3317820", VA = "0x183319220")]
		private void ApplySecondaryFactors(VitalsGui.VitalElementDef mainElementDef, VitalsGui.VitalElementDef buffElementDef, float mainFactor, float buffFactor, Disc alertDisc, ref float alertTime)
		{
		}

		// Token: 0x0600208A RID: 8330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600208A")]
		[Address(RVA = "0x33193F0", Offset = "0x33179F0", VA = "0x1833193F0")]
		private void ShowAlert(Disc alertDisc, float alertFactor, ref float alertTime)
		{
		}

		// Token: 0x0600208B RID: 8331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600208B")]
		[Address(RVA = "0x3319800", Offset = "0x3317E00", VA = "0x183319800")]
		private void UpdateHydrationFactors()
		{
		}

		// Token: 0x0600208C RID: 8332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600208C")]
		[Address(RVA = "0x3319890", Offset = "0x3317E90", VA = "0x183319890")]
		private void UpdateRestedFactors()
		{
		}

		// Token: 0x0600208D RID: 8333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600208D")]
		[Address(RVA = "0x3319920", Offset = "0x3317F20", VA = "0x183319920")]
		private void UpdateFullnessFactors()
		{
		}

		// Token: 0x0600208E RID: 8334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600208E")]
		[Address(RVA = "0x33199B0", Offset = "0x3317FB0", VA = "0x1833199B0")]
		private void UpdateDebug()
		{
		}

		// Token: 0x0600208F RID: 8335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600208F")]
		[Address(RVA = "0x3319F90", Offset = "0x3318590", VA = "0x183319F90")]
		private void UpdateStrengthLevel()
		{
		}

		// Token: 0x06002090 RID: 8336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002090")]
		[Address(RVA = "0x331A110", Offset = "0x3318710", VA = "0x18331A110")]
		private void PlayStrengthLevelAnimation()
		{
		}

		// Token: 0x06002091 RID: 8337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002091")]
		[Address(RVA = "0x331A1D0", Offset = "0x33187D0", VA = "0x18331A1D0")]
		private List<Renderer> CollectSourceRenderers()
		{
			return null;
		}

		// Token: 0x06002092 RID: 8338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002092")]
		[Address(RVA = "0x331A2C0", Offset = "0x33188C0", VA = "0x18331A2C0")]
		private void UpdateColdAndFreezing()
		{
		}

		// Token: 0x06002093 RID: 8339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002093")]
		[Address(RVA = "0x331A470", Offset = "0x3318A70", VA = "0x18331A470")]
		private void UpdateArmour()
		{
		}

		// Token: 0x06002094 RID: 8340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002094")]
		[Address(RVA = "0x331A810", Offset = "0x3318E10", VA = "0x18331A810")]
		public VitalsGui()
		{
		}

		// Token: 0x04001DD7 RID: 7639
		[Token(Token = "0x4001DD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material _cookingBuffAIconMaterialInstance;

		// Token: 0x04001DD8 RID: 7640
		[Token(Token = "0x4001DD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Material _cookingBuffAIconBackgroundMaterialInstance;

		// Token: 0x04001DD9 RID: 7641
		[Token(Token = "0x4001DD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material _cookingBuffBIconMaterialInstance;

		// Token: 0x04001DDA RID: 7642
		[Token(Token = "0x4001DDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material _cookingBuffBIconBackgroundMaterialInstance;

		// Token: 0x04001DDB RID: 7643
		[Token(Token = "0x4001DDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material _cookingBuffCIconMaterialInstance;

		// Token: 0x04001DDC RID: 7644
		[Token(Token = "0x4001DDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material _cookingBuffCIconBackgroundMaterialInstance;

		// Token: 0x04001DDD RID: 7645
		[Token(Token = "0x4001DDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<Material> _cookingBuffIconMaterialInstances;

		// Token: 0x04001DDE RID: 7646
		[Token(Token = "0x4001DDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int MainTexPropertyId;

		// Token: 0x04001DDF RID: 7647
		[Token(Token = "0x4001DDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _renderersGroup;

		// Token: 0x04001DE0 RID: 7648
		[Token(Token = "0x4001DE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Camera _referenceCamera;

		// Token: 0x04001DE1 RID: 7649
		[Token(Token = "0x4001DE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private VitalsGui.VitalElementDef _vitalityHealthElementDef;

		// Token: 0x04001DE2 RID: 7650
		[Token(Token = "0x4001DE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private VitalsGui.VitalElementDef _vitalityEnergyElementDef;

		// Token: 0x04001DE3 RID: 7651
		[Token(Token = "0x4001DE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private VitalsGui.VitalElementDef _strengthElementDef;

		// Token: 0x04001DE4 RID: 7652
		[Token(Token = "0x4001DE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private VitalsGui.VitalElementDef _healthElementDef;

		// Token: 0x04001DE5 RID: 7653
		[Token(Token = "0x4001DE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private VitalsGui.VitalElementDef _healthBackgroundElementDef;

		// Token: 0x04001DE6 RID: 7654
		[Token(Token = "0x4001DE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private VitalsGui.VitalElementDef _healthVitalityClampedElementDef;

		// Token: 0x04001DE7 RID: 7655
		[Token(Token = "0x4001DE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private VitalsGui.VitalElementDef _healthPaddingHighlightElementDef;

		// Token: 0x04001DE8 RID: 7656
		[Token(Token = "0x4001DE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private VitalsGui.VitalElementDef _targetHealthElementDef;

		// Token: 0x04001DE9 RID: 7657
		[Token(Token = "0x4001DE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private VitalsGui.VitalElementDef _energyElementDef;

		// Token: 0x04001DEA RID: 7658
		[Token(Token = "0x4001DEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private VitalsGui.VitalElementDef _energyBackgroundElementDef;

		// Token: 0x04001DEB RID: 7659
		[Token(Token = "0x4001DEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private VitalsGui.VitalElementDef _energyVitalityClampedElementDef;

		// Token: 0x04001DEC RID: 7660
		[Token(Token = "0x4001DEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private VitalsGui.VitalElementDef _energyPaddingHighlightElementDef;

		// Token: 0x04001DED RID: 7661
		[Token(Token = "0x4001DED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private AnimationCurve _alertFlashCurve;

		// Token: 0x04001DEE RID: 7662
		[Token(Token = "0x4001DEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private float _alertFlashSpeedMin;

		// Token: 0x04001DEF RID: 7663
		[Token(Token = "0x4001DEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[SerializeField]
		private float _alertFlashSpeedMax;

		// Token: 0x04001DF0 RID: 7664
		[Token(Token = "0x4001DF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private VitalsGui.VitalElementDef _fullnessElementDef;

		// Token: 0x04001DF1 RID: 7665
		[Token(Token = "0x4001DF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private VitalsGui.VitalElementDef _fullnessBuffElementDef;

		// Token: 0x04001DF2 RID: 7666
		[Token(Token = "0x4001DF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Disc _fullnessAlertDisc;

		// Token: 0x04001DF3 RID: 7667
		[Token(Token = "0x4001DF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private VitalsGui.VitalElementDef _restedElementDef;

		// Token: 0x04001DF4 RID: 7668
		[Token(Token = "0x4001DF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private VitalsGui.VitalElementDef _restedBuffElementDef;

		// Token: 0x04001DF5 RID: 7669
		[Token(Token = "0x4001DF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[SerializeField]
		private Disc _restedAlertDisc;

		// Token: 0x04001DF6 RID: 7670
		[Token(Token = "0x4001DF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[SerializeField]
		private VitalsGui.VitalElementDef _hydrationElementDef;

		// Token: 0x04001DF7 RID: 7671
		[Token(Token = "0x4001DF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		private VitalsGui.VitalElementDef _hydrationBuffElementDef;

		// Token: 0x04001DF8 RID: 7672
		[Token(Token = "0x4001DF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		private Disc _hydrationAlertDisc;

		// Token: 0x04001DF9 RID: 7673
		[Token(Token = "0x4001DF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		private GameObject _cookingGroup;

		// Token: 0x04001DFA RID: 7674
		[Token(Token = "0x4001DFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		private List<VitalsGui.VitalElementDef> _cookingElementDefs;

		// Token: 0x04001DFB RID: 7675
		[Token(Token = "0x4001DFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[SerializeField]
		private float _cookingGroupEnableTimer;

		// Token: 0x04001DFC RID: 7676
		[Token(Token = "0x4001DFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		[SerializeField]
		private float _cookingGroupDisableTimer;

		// Token: 0x04001DFD RID: 7677
		[Token(Token = "0x4001DFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[SerializeField]
		private GameObject _stealthGroup;

		// Token: 0x04001DFE RID: 7678
		[Token(Token = "0x4001DFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[SerializeField]
		private float _stealthGroupEnableTimer;

		// Token: 0x04001DFF RID: 7679
		[Token(Token = "0x4001DFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		[SerializeField]
		private float _stealthGroupDisableTimer;

		// Token: 0x04001E00 RID: 7680
		[Token(Token = "0x4001E00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[SerializeField]
		private VitalsGui.VitalElementDef _stealthElementDef;

		// Token: 0x04001E01 RID: 7681
		[Token(Token = "0x4001E01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[SerializeField]
		private Renderer _stealthIconRenderer;

		// Token: 0x04001E02 RID: 7682
		[Token(Token = "0x4001E02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		[SerializeField]
		private Color _stealthEyeFullColor;

		// Token: 0x04001E03 RID: 7683
		[Token(Token = "0x4001E03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[SerializeField]
		private Color _stealthEyeEmptyColor;

		// Token: 0x04001E04 RID: 7684
		[Token(Token = "0x4001E04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		[SerializeField]
		private Color _stealthFullColor;

		// Token: 0x04001E05 RID: 7685
		[Token(Token = "0x4001E05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		[SerializeField]
		private Color _stealthEmptyColor;

		// Token: 0x04001E06 RID: 7686
		[Token(Token = "0x4001E06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		[HideInInspector]
		[SerializeField]
		private float _stealthChangeSpeed;

		// Token: 0x04001E07 RID: 7687
		[Token(Token = "0x4001E07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private List<Disc> _armourNibbles;

		// Token: 0x04001E08 RID: 7688
		[Token(Token = "0x4001E08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		private Disc _armourSingleNibbles;

		// Token: 0x04001E09 RID: 7689
		[Token(Token = "0x4001E09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private GameObject _coldGroup;

		// Token: 0x04001E0A RID: 7690
		[Token(Token = "0x4001E0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		private float _minFreezingDisplay;

		// Token: 0x04001E0B RID: 7691
		[Token(Token = "0x4001E0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		private VitalsGui.VitalElementDef _freezingElementDef;

		// Token: 0x04001E0C RID: 7692
		[Token(Token = "0x4001E0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		private VitalsGui.VitalElementDef _freezingHighlightElementDef;

		// Token: 0x04001E0D RID: 7693
		[Token(Token = "0x4001E0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		private GameObject _freezingGroup;

		// Token: 0x04001E0E RID: 7694
		[Token(Token = "0x4001E0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		[SerializeField]
		private VitalsGui.AmountIndicationDef _healthAmountIndicator;

		// Token: 0x04001E0F RID: 7695
		[Token(Token = "0x4001E0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		[SerializeField]
		private TMP_Text _strengthLevelText;

		// Token: 0x04001E10 RID: 7696
		[Token(Token = "0x4001E10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		[SerializeField]
		private Animation _strengthLevelAnimation;

		// Token: 0x04001E11 RID: 7697
		[Token(Token = "0x4001E11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		[SerializeField]
		private CookingBuffs _cookingBuffsIconTable;

		// Token: 0x04001E12 RID: 7698
		[Token(Token = "0x4001E12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		[SerializeField]
		private GameObject _cookingBuffAGroup;

		// Token: 0x04001E13 RID: 7699
		[Token(Token = "0x4001E13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		[SerializeField]
		private MeshRenderer _cookingBuffAIcon;

		// Token: 0x04001E14 RID: 7700
		[Token(Token = "0x4001E14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		[SerializeField]
		private MeshRenderer _cookingBuffAIconBackground;

		// Token: 0x04001E15 RID: 7701
		[Token(Token = "0x4001E15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		[SerializeField]
		private List<GameObject> _cookingBuffALevels;

		// Token: 0x04001E16 RID: 7702
		[Token(Token = "0x4001E16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		[SerializeField]
		private GameObject _cookingBuffBGroup;

		// Token: 0x04001E17 RID: 7703
		[Token(Token = "0x4001E17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		[SerializeField]
		private MeshRenderer _cookingBuffBIcon;

		// Token: 0x04001E18 RID: 7704
		[Token(Token = "0x4001E18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		[SerializeField]
		private MeshRenderer _cookingBuffBIconBackground;

		// Token: 0x04001E19 RID: 7705
		[Token(Token = "0x4001E19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		[SerializeField]
		private List<GameObject> _cookingBuffBLevels;

		// Token: 0x04001E1A RID: 7706
		[Token(Token = "0x4001E1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		[SerializeField]
		private GameObject _cookingBuffCGroup;

		// Token: 0x04001E1B RID: 7707
		[Token(Token = "0x4001E1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		[SerializeField]
		private MeshRenderer _cookingBuffCIcon;

		// Token: 0x04001E1C RID: 7708
		[Token(Token = "0x4001E1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		[SerializeField]
		private MeshRenderer _cookingBuffCIconBackground;

		// Token: 0x04001E1D RID: 7709
		[Token(Token = "0x4001E1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		[SerializeField]
		private List<GameObject> _cookingBuffCLevels;

		// Token: 0x04001E1E RID: 7710
		[Token(Token = "0x4001E1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		[SerializeField]
		private GameObject _debugGroup;

		// Token: 0x04001E1F RID: 7711
		[Token(Token = "0x4001E1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		[SerializeField]
		private TMP_Text _healthDebug;

		// Token: 0x04001E20 RID: 7712
		[Token(Token = "0x4001E20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		[SerializeField]
		private TMP_Text _healthMaxDebug;

		// Token: 0x04001E21 RID: 7713
		[Token(Token = "0x4001E21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		[SerializeField]
		private TMP_Text _energyDebug;

		// Token: 0x04001E22 RID: 7714
		[Token(Token = "0x4001E22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		[SerializeField]
		private TMP_Text _cookingDebug;

		// Token: 0x04001E23 RID: 7715
		[Token(Token = "0x4001E23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		[SerializeField]
		private TMP_Text _vitalityDebug;

		// Token: 0x04001E24 RID: 7716
		[Token(Token = "0x4001E24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		[SerializeField]
		private TMP_Text _strengthLevelDebug;

		// Token: 0x04001E25 RID: 7717
		[Token(Token = "0x4001E25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		[SerializeField]
		private TMP_Text _strengthLevelProgressDebug;

		// Token: 0x04001E26 RID: 7718
		[Token(Token = "0x4001E26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		[SerializeField]
		private TMP_Text _fullnessDebug;

		// Token: 0x04001E27 RID: 7719
		[Token(Token = "0x4001E27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		[SerializeField]
		private TMP_Text _fullnessBuffDebug;

		// Token: 0x04001E28 RID: 7720
		[Token(Token = "0x4001E28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		[SerializeField]
		private TMP_Text _hydrationDebug;

		// Token: 0x04001E29 RID: 7721
		[Token(Token = "0x4001E29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		[SerializeField]
		private TMP_Text _hydrationBuffDebug;

		// Token: 0x04001E2A RID: 7722
		[Token(Token = "0x4001E2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		[SerializeField]
		private TMP_Text _restedDebug;

		// Token: 0x04001E2B RID: 7723
		[Token(Token = "0x4001E2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		[SerializeField]
		private TMP_Text _restedBuffDebug;

		// Token: 0x04001E2C RID: 7724
		[Token(Token = "0x4001E2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		[SerializeField]
		private TMP_Text _coldnessDebug;

		// Token: 0x04001E2D RID: 7725
		[Token(Token = "0x4001E2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		[SerializeField]
		private TMP_Text _stealthDebug;

		// Token: 0x04001E2E RID: 7726
		[Token(Token = "0x4001E2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private float _currentVitalityFactor;

		// Token: 0x04001E2F RID: 7727
		[Token(Token = "0x4001E2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2DC")]
		private float _currentTargetHealthFactor;

		// Token: 0x04001E30 RID: 7728
		[Token(Token = "0x4001E30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private float _currentHealthFactor;

		// Token: 0x04001E31 RID: 7729
		[Token(Token = "0x4001E31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E4")]
		private float _currentEnergyFactor;

		// Token: 0x04001E32 RID: 7730
		[Token(Token = "0x4001E32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		private float _currentFullnessFactor;

		// Token: 0x04001E33 RID: 7731
		[Token(Token = "0x4001E33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2EC")]
		private float _currentRestedFactor;

		// Token: 0x04001E34 RID: 7732
		[Token(Token = "0x4001E34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		private float _currentHydrationFactor;

		// Token: 0x04001E35 RID: 7733
		[Token(Token = "0x4001E35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F4")]
		private float _strengthFactor;

		// Token: 0x04001E36 RID: 7734
		[Token(Token = "0x4001E36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		private float _currentCookingFactor;

		// Token: 0x04001E37 RID: 7735
		[Token(Token = "0x4001E37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2FC")]
		private float _healthMax;

		// Token: 0x04001E38 RID: 7736
		[Token(Token = "0x4001E38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		private float _currentStealthFactor;

		// Token: 0x04001E39 RID: 7737
		[Token(Token = "0x4001E39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		private Vitals _vitals;

		// Token: 0x04001E3A RID: 7738
		[Token(Token = "0x4001E3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		private PlayerArmourSystem _armourSystem;

		// Token: 0x04001E3B RID: 7739
		[Token(Token = "0x4001E3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		private PlayerStats _playerStats;

		// Token: 0x04001E3C RID: 7740
		[Token(Token = "0x4001E3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		private int _lastKnownStrengthLevel;

		// Token: 0x04001E3D RID: 7741
		[Token(Token = "0x4001E3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x324")]
		private int _currentTextStrengthLevel;

		// Token: 0x04001E3E RID: 7742
		[Token(Token = "0x4001E3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static bool _showDebugGroup;

		// Token: 0x04001E3F RID: 7743
		[Token(Token = "0x4001E3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
		private float _currentColdFactor;

		// Token: 0x04001E40 RID: 7744
		[Token(Token = "0x4001E40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32C")]
		private float _currentRestedBuffFactor;

		// Token: 0x04001E41 RID: 7745
		[Token(Token = "0x4001E41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
		private float _currentFullnessBuffFactor;

		// Token: 0x04001E42 RID: 7746
		[Token(Token = "0x4001E42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x334")]
		private float _currentHydrationBuffFactor;

		// Token: 0x04001E43 RID: 7747
		[Token(Token = "0x4001E43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
		private float _shownStealthFactor;

		// Token: 0x04001E44 RID: 7748
		[Token(Token = "0x4001E44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33C")]
		private float _shownCookingFactor;

		// Token: 0x04001E45 RID: 7749
		[Token(Token = "0x4001E45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
		private Material _stealthIconMaterial;

		// Token: 0x04001E46 RID: 7750
		[Token(Token = "0x4001E46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
		private PlayerVisibility _playerVisibility;

		// Token: 0x04001E47 RID: 7751
		[Token(Token = "0x4001E47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
		private bool _stealthGroupVisibilityGoal;

		// Token: 0x04001E48 RID: 7752
		[Token(Token = "0x4001E48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x351")]
		private bool _cookingGroupVisibilityGoal;

		// Token: 0x04001E49 RID: 7753
		[Token(Token = "0x4001E49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
		private AutoTimer _stealthGroupVisibilitySwitchTimer;

		// Token: 0x04001E4A RID: 7754
		[Token(Token = "0x4001E4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
		private AutoTimer _cookingGroupVisibilitySwitchTimer;

		// Token: 0x04001E4B RID: 7755
		[Token(Token = "0x4001E4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
		private float _fullnessAlertTimeFactor;

		// Token: 0x04001E4C RID: 7756
		[Token(Token = "0x4001E4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36C")]
		private float _restedAlertTimeFactor;

		// Token: 0x04001E4D RID: 7757
		[Token(Token = "0x4001E4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
		private float _hydrationAlertTimeFactor;

		// Token: 0x020004D9 RID: 1241
		[Token(Token = "0x20004D9")]
		[Serializable]
		public class AmountIndicationDef
		{
			// Token: 0x06002096 RID: 8342 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002096")]
			[Address(RVA = "0x331AA00", Offset = "0x3319000", VA = "0x18331AA00")]
			private void Test()
			{
			}

			// Token: 0x06002097 RID: 8343 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002097")]
			[Address(RVA = "0x331AA10", Offset = "0x3319010", VA = "0x18331AA10")]
			public void Apply(float amount)
			{
			}

			// Token: 0x06002098 RID: 8344 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002098")]
			[Address(RVA = "0x331AD90", Offset = "0x3319390", VA = "0x18331AD90")]
			public AmountIndicationDef()
			{
			}

			// Token: 0x04001E4E RID: 7758
			[Token(Token = "0x4001E4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			private float _interval;

			// Token: 0x04001E4F RID: 7759
			[Token(Token = "0x4001E4F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Disc _discElement;

			// Token: 0x04001E50 RID: 7760
			[Token(Token = "0x4001E50")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private float _notchThickness;

			// Token: 0x04001E51 RID: 7761
			[Token(Token = "0x4001E51")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[SerializeField]
			private float _notchThicknessScale;

			// Token: 0x04001E52 RID: 7762
			[Token(Token = "0x4001E52")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[SerializeField]
			private float _notchProgressiveScale;

			// Token: 0x04001E53 RID: 7763
			[Token(Token = "0x4001E53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[SerializeField]
			private float _startFull;

			// Token: 0x04001E54 RID: 7764
			[Token(Token = "0x4001E54")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[SerializeField]
			private float _endFull;

			// Token: 0x04001E55 RID: 7765
			[Token(Token = "0x4001E55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[SerializeField]
			private float _testAmount;

			// Token: 0x04001E56 RID: 7766
			[Token(Token = "0x4001E56")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int _currentNotches;

			// Token: 0x04001E57 RID: 7767
			[Token(Token = "0x4001E57")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float _currentAmount;
		}

		// Token: 0x020004DA RID: 1242
		[Token(Token = "0x20004DA")]
		[Serializable]
		public class VitalElementDef
		{
			// Token: 0x06002099 RID: 8345 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002099")]
			[Address(RVA = "0x331ADB0", Offset = "0x33193B0", VA = "0x18331ADB0")]
			public void ApplyFactor(float factor)
			{
			}

			// Token: 0x0600209A RID: 8346 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600209A")]
			[Address(RVA = "0x331ADC0", Offset = "0x33193C0", VA = "0x18331ADC0")]
			public void ApplyFactor(float factorBase, float factor)
			{
			}

			// Token: 0x0600209B RID: 8347 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600209B")]
			[Address(RVA = "0x29150F0", Offset = "0x29136F0", VA = "0x1829150F0")]
			public void Disable()
			{
			}

			// Token: 0x0600209C RID: 8348 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600209C")]
			[Address(RVA = "0x331AFA0", Offset = "0x33195A0", VA = "0x18331AFA0")]
			public void ApplyColor(Color color)
			{
			}

			// Token: 0x0600209D RID: 8349 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600209D")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public VitalElementDef()
			{
			}

			// Token: 0x04001E58 RID: 7768
			[Token(Token = "0x4001E58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Disc _discElement;

			// Token: 0x04001E59 RID: 7769
			[Token(Token = "0x4001E59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private float _discStartFullValue;

			// Token: 0x04001E5A RID: 7770
			[Token(Token = "0x4001E5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[SerializeField]
			private float _discEndFullValue;

			// Token: 0x04001E5B RID: 7771
			[Token(Token = "0x4001E5B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private float _discStartEmptyValue;

			// Token: 0x04001E5C RID: 7772
			[Token(Token = "0x4001E5C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[SerializeField]
			private float _discEndEmptyValue;

			// Token: 0x04001E5D RID: 7773
			[Token(Token = "0x4001E5D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float _currentBaseFactor;

			// Token: 0x04001E5E RID: 7774
			[Token(Token = "0x4001E5E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float _currentFactor;
		}
	}
}
