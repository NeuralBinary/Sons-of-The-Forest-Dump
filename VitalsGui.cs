using System;
using System.Collections.Generic;
using Endnight.Utilities.Timer;
using Il2CppDummyDll;
using Shapes;
using Sons.Player;
using Sons.Wearable.Armour;
using TMPro;
using UnityEngine;

namespace Sons
{
	// Token: 0x020004E2 RID: 1250
	[Token(Token = "0x20004E2")]
	public class VitalsGui : MonoBehaviour
	{
		// Token: 0x0600200A RID: 8202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600200A")]
		[Address(RVA = "0x2D38EB0", Offset = "0x2D37EB0", VA = "0x182D38EB0")]
		private void Start()
		{
		}

		// Token: 0x0600200B RID: 8203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600200B")]
		[Address(RVA = "0x2D38040", Offset = "0x2D37040", VA = "0x182D38040")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600200C RID: 8204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600200C")]
		[Address(RVA = "0x2D39DA0", Offset = "0x2D38DA0", VA = "0x182D39DA0")]
		private void Update()
		{
		}

		// Token: 0x0600200D RID: 8205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600200D")]
		[Address(RVA = "0x2D38110", Offset = "0x2D37110", VA = "0x182D38110")]
		private void RefreshGui()
		{
		}

		// Token: 0x0600200E RID: 8206 RVA: 0x000094E0 File Offset: 0x000076E0
		[Token(Token = "0x600200E")]
		[Address(RVA = "0x2D39E90", Offset = "0x2D38E90", VA = "0x182D39E90")]
		private bool VerifyObjects()
		{
			return default(bool);
		}

		// Token: 0x0600200F RID: 8207 RVA: 0x000094F8 File Offset: 0x000076F8
		[Token(Token = "0x600200F")]
		[Address(RVA = "0x2D39DB0", Offset = "0x2D38DB0", VA = "0x182D39DB0")]
		private bool VerifyArmourObject()
		{
			return default(bool);
		}

		// Token: 0x06002010 RID: 8208 RVA: 0x00009510 File Offset: 0x00007710
		[Token(Token = "0x6002010")]
		[Address(RVA = "0x2D3A2F0", Offset = "0x2D392F0", VA = "0x182D3A2F0")]
		private bool VerifyVisibilityObject()
		{
			return default(bool);
		}

		// Token: 0x06002011 RID: 8209 RVA: 0x00009528 File Offset: 0x00007728
		[Token(Token = "0x6002011")]
		[Address(RVA = "0x2D3A210", Offset = "0x2D39210", VA = "0x182D3A210")]
		private bool VerifyStatsObject()
		{
			return default(bool);
		}

		// Token: 0x06002012 RID: 8210 RVA: 0x00009540 File Offset: 0x00007740
		[Token(Token = "0x6002012")]
		[Address(RVA = "0x2D3A460", Offset = "0x2D39460", VA = "0x182D3A460")]
		private bool VerifyVitalsObject()
		{
			return default(bool);
		}

		// Token: 0x06002013 RID: 8211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002013")]
		[Address(RVA = "0x2D39B20", Offset = "0x2D38B20", VA = "0x182D39B20")]
		private void UpdateStealth()
		{
		}

		// Token: 0x06002014 RID: 8212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002014")]
		[Address(RVA = "0x2D38B70", Offset = "0x2D37B70", VA = "0x182D38B70")]
		private void SetStealthGui(bool value)
		{
		}

		// Token: 0x06002015 RID: 8213 RVA: 0x00009558 File Offset: 0x00007758
		[Token(Token = "0x6002015")]
		[Address(RVA = "0x2D38C10", Offset = "0x2D37C10", VA = "0x182D38C10")]
		private bool ShouldShowStealth()
		{
			return default(bool);
		}

		// Token: 0x06002016 RID: 8214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002016")]
		[Address(RVA = "0x2D37E60", Offset = "0x2D36E60", VA = "0x182D37E60")]
		private void ApplyStealth(VitalsGui.VitalElementDef stealthElementDef, float currentStealthFactor, Material iconMaterial, Color eyeFullColor, Color eyeEmptyColor, Color fullColor, Color emptyColor)
		{
		}

		// Token: 0x06002017 RID: 8215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002017")]
		[Address(RVA = "0x2D37D30", Offset = "0x2D36D30", VA = "0x182D37D30")]
		private void ApplySecondaryFactors(VitalsGui.VitalElementDef mainElementDef, VitalsGui.VitalElementDef buffElementDef, float mainFactor, float buffFactor, Disc alertDisc, ref float alertTime)
		{
		}

		// Token: 0x06002018 RID: 8216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002018")]
		[Address(RVA = "0x2D38C30", Offset = "0x2D37C30", VA = "0x182D38C30")]
		private void ShowAlert(Disc alertDisc, float alertFactor, ref float alertTime)
		{
		}

		// Token: 0x06002019 RID: 8217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002019")]
		[Address(RVA = "0x2D39A20", Offset = "0x2D38A20", VA = "0x182D39A20")]
		private void UpdateHydrationFactors()
		{
		}

		// Token: 0x0600201A RID: 8218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600201A")]
		[Address(RVA = "0x2D39AA0", Offset = "0x2D38AA0", VA = "0x182D39AA0")]
		private void UpdateRestedFactors()
		{
		}

		// Token: 0x0600201B RID: 8219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600201B")]
		[Address(RVA = "0x2D399A0", Offset = "0x2D389A0", VA = "0x182D399A0")]
		private void UpdateFullnessFactors()
		{
		}

		// Token: 0x0600201C RID: 8220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600201C")]
		[Address(RVA = "0x2D39410", Offset = "0x2D38410", VA = "0x182D39410")]
		private void UpdateDebug()
		{
		}

		// Token: 0x0600201D RID: 8221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600201D")]
		[Address(RVA = "0x2D39C90", Offset = "0x2D38C90", VA = "0x182D39C90")]
		private void UpdateStrengthLevel()
		{
		}

		// Token: 0x0600201E RID: 8222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600201E")]
		[Address(RVA = "0x2D380D0", Offset = "0x2D370D0", VA = "0x182D380D0")]
		private void PlayStrengthLevelAnimation()
		{
		}

		// Token: 0x0600201F RID: 8223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600201F")]
		[Address(RVA = "0x2D37FD0", Offset = "0x2D36FD0", VA = "0x182D37FD0")]
		private List<Renderer> CollectSourceRenderers()
		{
			return null;
		}

		// Token: 0x06002020 RID: 8224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002020")]
		[Address(RVA = "0x2D39300", Offset = "0x2D38300", VA = "0x182D39300")]
		private void UpdateColdAndFreezing()
		{
		}

		// Token: 0x06002021 RID: 8225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002021")]
		[Address(RVA = "0x2D390F0", Offset = "0x2D380F0", VA = "0x182D390F0")]
		private void UpdateArmour()
		{
		}

		// Token: 0x06002022 RID: 8226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002022")]
		[Address(RVA = "0x2D3A540", Offset = "0x2D39540", VA = "0x182D3A540")]
		public VitalsGui()
		{
		}

		// Token: 0x04001D9A RID: 7578
		[Token(Token = "0x4001D9A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _renderersGroup;

		// Token: 0x04001D9B RID: 7579
		[Token(Token = "0x4001D9B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Camera _referenceCamera;

		// Token: 0x04001D9C RID: 7580
		[Token(Token = "0x4001D9C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private VitalsGui.VitalElementDef _vitalityHealthElementDef;

		// Token: 0x04001D9D RID: 7581
		[Token(Token = "0x4001D9D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private VitalsGui.VitalElementDef _vitalityEnergyElementDef;

		// Token: 0x04001D9E RID: 7582
		[Token(Token = "0x4001D9E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private VitalsGui.VitalElementDef _strengthElementDef;

		// Token: 0x04001D9F RID: 7583
		[Token(Token = "0x4001D9F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private VitalsGui.VitalElementDef _healthElementDef;

		// Token: 0x04001DA0 RID: 7584
		[Token(Token = "0x4001DA0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private VitalsGui.VitalElementDef _healthBackgroundElementDef;

		// Token: 0x04001DA1 RID: 7585
		[Token(Token = "0x4001DA1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private VitalsGui.VitalElementDef _healthVitalityClampedElementDef;

		// Token: 0x04001DA2 RID: 7586
		[Token(Token = "0x4001DA2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private VitalsGui.VitalElementDef _healthPaddingHighlightElementDef;

		// Token: 0x04001DA3 RID: 7587
		[Token(Token = "0x4001DA3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private VitalsGui.VitalElementDef _targetHealthElementDef;

		// Token: 0x04001DA4 RID: 7588
		[Token(Token = "0x4001DA4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private VitalsGui.VitalElementDef _energyElementDef;

		// Token: 0x04001DA5 RID: 7589
		[Token(Token = "0x4001DA5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private VitalsGui.VitalElementDef _energyBackgroundElementDef;

		// Token: 0x04001DA6 RID: 7590
		[Token(Token = "0x4001DA6")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private VitalsGui.VitalElementDef _energyVitalityClampedElementDef;

		// Token: 0x04001DA7 RID: 7591
		[Token(Token = "0x4001DA7")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private VitalsGui.VitalElementDef _energyPaddingHighlightElementDef;

		// Token: 0x04001DA8 RID: 7592
		[Token(Token = "0x4001DA8")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private AnimationCurve _alertFlashCurve;

		// Token: 0x04001DA9 RID: 7593
		[Token(Token = "0x4001DA9")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private float _alertFlashSpeedMin;

		// Token: 0x04001DAA RID: 7594
		[Token(Token = "0x4001DAA")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private float _alertFlashSpeedMax;

		// Token: 0x04001DAB RID: 7595
		[Token(Token = "0x4001DAB")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private VitalsGui.VitalElementDef _fullnessElementDef;

		// Token: 0x04001DAC RID: 7596
		[Token(Token = "0x4001DAC")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private VitalsGui.VitalElementDef _fullnessBuffElementDef;

		// Token: 0x04001DAD RID: 7597
		[Token(Token = "0x4001DAD")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Disc _fullnessAlertDisc;

		// Token: 0x04001DAE RID: 7598
		[Token(Token = "0x4001DAE")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private VitalsGui.VitalElementDef _restedElementDef;

		// Token: 0x04001DAF RID: 7599
		[Token(Token = "0x4001DAF")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private VitalsGui.VitalElementDef _restedBuffElementDef;

		// Token: 0x04001DB0 RID: 7600
		[Token(Token = "0x4001DB0")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Disc _restedAlertDisc;

		// Token: 0x04001DB1 RID: 7601
		[Token(Token = "0x4001DB1")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private VitalsGui.VitalElementDef _hydrationElementDef;

		// Token: 0x04001DB2 RID: 7602
		[Token(Token = "0x4001DB2")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private VitalsGui.VitalElementDef _hydrationBuffElementDef;

		// Token: 0x04001DB3 RID: 7603
		[Token(Token = "0x4001DB3")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Disc _hydrationAlertDisc;

		// Token: 0x04001DB4 RID: 7604
		[Token(Token = "0x4001DB4")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private GameObject _stealthGroup;

		// Token: 0x04001DB5 RID: 7605
		[Token(Token = "0x4001DB5")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private float _stealthGroupEnableTimer;

		// Token: 0x04001DB6 RID: 7606
		[Token(Token = "0x4001DB6")]
		[FieldOffset(Offset = "0xF4")]
		[SerializeField]
		private float _stealthGroupDisableTimer;

		// Token: 0x04001DB7 RID: 7607
		[Token(Token = "0x4001DB7")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private VitalsGui.VitalElementDef _stealthElementDef;

		// Token: 0x04001DB8 RID: 7608
		[Token(Token = "0x4001DB8")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private Renderer _stealthIconRenderer;

		// Token: 0x04001DB9 RID: 7609
		[Token(Token = "0x4001DB9")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private Color _stealthEyeFullColor;

		// Token: 0x04001DBA RID: 7610
		[Token(Token = "0x4001DBA")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private Color _stealthEyeEmptyColor;

		// Token: 0x04001DBB RID: 7611
		[Token(Token = "0x4001DBB")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private Color _stealthFullColor;

		// Token: 0x04001DBC RID: 7612
		[Token(Token = "0x4001DBC")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private Color _stealthEmptyColor;

		// Token: 0x04001DBD RID: 7613
		[Token(Token = "0x4001DBD")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		[HideInInspector]
		private float _stealthChangeSpeed;

		// Token: 0x04001DBE RID: 7614
		[Token(Token = "0x4001DBE")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private List<Disc> _armourNibbles;

		// Token: 0x04001DBF RID: 7615
		[Token(Token = "0x4001DBF")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private Disc _armourSingleNibbles;

		// Token: 0x04001DC0 RID: 7616
		[Token(Token = "0x4001DC0")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private GameObject _coldGroup;

		// Token: 0x04001DC1 RID: 7617
		[Token(Token = "0x4001DC1")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private float _minFreezingDisplay;

		// Token: 0x04001DC2 RID: 7618
		[Token(Token = "0x4001DC2")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private VitalsGui.VitalElementDef _freezingElementDef;

		// Token: 0x04001DC3 RID: 7619
		[Token(Token = "0x4001DC3")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private VitalsGui.VitalElementDef _freezingHighlightElementDef;

		// Token: 0x04001DC4 RID: 7620
		[Token(Token = "0x4001DC4")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private GameObject _freezingGroup;

		// Token: 0x04001DC5 RID: 7621
		[Token(Token = "0x4001DC5")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private VitalsGui.AmountIndicationDef _healthAmountIndicator;

		// Token: 0x04001DC6 RID: 7622
		[Token(Token = "0x4001DC6")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private TMP_Text _strengthLevelText;

		// Token: 0x04001DC7 RID: 7623
		[Token(Token = "0x4001DC7")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private Animation _strengthLevelAnimation;

		// Token: 0x04001DC8 RID: 7624
		[Token(Token = "0x4001DC8")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private GameObject _debugGroup;

		// Token: 0x04001DC9 RID: 7625
		[Token(Token = "0x4001DC9")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		private TMP_Text _healthDebug;

		// Token: 0x04001DCA RID: 7626
		[Token(Token = "0x4001DCA")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private TMP_Text _healthMaxDebug;

		// Token: 0x04001DCB RID: 7627
		[Token(Token = "0x4001DCB")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		private TMP_Text _energyDebug;

		// Token: 0x04001DCC RID: 7628
		[Token(Token = "0x4001DCC")]
		[FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		private TMP_Text _vitalityDebug;

		// Token: 0x04001DCD RID: 7629
		[Token(Token = "0x4001DCD")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		private TMP_Text _strengthLevelDebug;

		// Token: 0x04001DCE RID: 7630
		[Token(Token = "0x4001DCE")]
		[FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		private TMP_Text _strengthLevelProgressDebug;

		// Token: 0x04001DCF RID: 7631
		[Token(Token = "0x4001DCF")]
		[FieldOffset(Offset = "0x1D8")]
		[SerializeField]
		private TMP_Text _fullnessDebug;

		// Token: 0x04001DD0 RID: 7632
		[Token(Token = "0x4001DD0")]
		[FieldOffset(Offset = "0x1E0")]
		[SerializeField]
		private TMP_Text _fullnessBuffDebug;

		// Token: 0x04001DD1 RID: 7633
		[Token(Token = "0x4001DD1")]
		[FieldOffset(Offset = "0x1E8")]
		[SerializeField]
		private TMP_Text _hydrationDebug;

		// Token: 0x04001DD2 RID: 7634
		[Token(Token = "0x4001DD2")]
		[FieldOffset(Offset = "0x1F0")]
		[SerializeField]
		private TMP_Text _hydrationBuffDebug;

		// Token: 0x04001DD3 RID: 7635
		[Token(Token = "0x4001DD3")]
		[FieldOffset(Offset = "0x1F8")]
		[SerializeField]
		private TMP_Text _restedDebug;

		// Token: 0x04001DD4 RID: 7636
		[Token(Token = "0x4001DD4")]
		[FieldOffset(Offset = "0x200")]
		[SerializeField]
		private TMP_Text _restedBuffDebug;

		// Token: 0x04001DD5 RID: 7637
		[Token(Token = "0x4001DD5")]
		[FieldOffset(Offset = "0x208")]
		[SerializeField]
		private TMP_Text _coldnessDebug;

		// Token: 0x04001DD6 RID: 7638
		[Token(Token = "0x4001DD6")]
		[FieldOffset(Offset = "0x210")]
		[SerializeField]
		private TMP_Text _stealthDebug;

		// Token: 0x04001DD7 RID: 7639
		[Token(Token = "0x4001DD7")]
		[FieldOffset(Offset = "0x218")]
		private float _currentVitalityFactor;

		// Token: 0x04001DD8 RID: 7640
		[Token(Token = "0x4001DD8")]
		[FieldOffset(Offset = "0x21C")]
		private float _currentTargetHealthFactor;

		// Token: 0x04001DD9 RID: 7641
		[Token(Token = "0x4001DD9")]
		[FieldOffset(Offset = "0x220")]
		private float _currentHealthFactor;

		// Token: 0x04001DDA RID: 7642
		[Token(Token = "0x4001DDA")]
		[FieldOffset(Offset = "0x224")]
		private float _currentEnergyFactor;

		// Token: 0x04001DDB RID: 7643
		[Token(Token = "0x4001DDB")]
		[FieldOffset(Offset = "0x228")]
		private float _currentFullnessFactor;

		// Token: 0x04001DDC RID: 7644
		[Token(Token = "0x4001DDC")]
		[FieldOffset(Offset = "0x22C")]
		private float _currentRestedFactor;

		// Token: 0x04001DDD RID: 7645
		[Token(Token = "0x4001DDD")]
		[FieldOffset(Offset = "0x230")]
		private float _currentHydrationFactor;

		// Token: 0x04001DDE RID: 7646
		[Token(Token = "0x4001DDE")]
		[FieldOffset(Offset = "0x234")]
		private float _strengthFactor;

		// Token: 0x04001DDF RID: 7647
		[Token(Token = "0x4001DDF")]
		[FieldOffset(Offset = "0x238")]
		private float _healthMax;

		// Token: 0x04001DE0 RID: 7648
		[Token(Token = "0x4001DE0")]
		[FieldOffset(Offset = "0x23C")]
		private float _currentStealthFactor;

		// Token: 0x04001DE1 RID: 7649
		[Token(Token = "0x4001DE1")]
		[FieldOffset(Offset = "0x240")]
		private Vitals _vitals;

		// Token: 0x04001DE2 RID: 7650
		[Token(Token = "0x4001DE2")]
		[FieldOffset(Offset = "0x248")]
		private PlayerArmourSystem _armourSystem;

		// Token: 0x04001DE3 RID: 7651
		[Token(Token = "0x4001DE3")]
		[FieldOffset(Offset = "0x250")]
		private PlayerStats _playerStats;

		// Token: 0x04001DE4 RID: 7652
		[Token(Token = "0x4001DE4")]
		[FieldOffset(Offset = "0x258")]
		private int _lastKnownStrengthLevel;

		// Token: 0x04001DE5 RID: 7653
		[Token(Token = "0x4001DE5")]
		[FieldOffset(Offset = "0x25C")]
		private int _currentTextStrengthLevel;

		// Token: 0x04001DE6 RID: 7654
		[Token(Token = "0x4001DE6")]
		[FieldOffset(Offset = "0x0")]
		private static bool _showDebugGroup;

		// Token: 0x04001DE7 RID: 7655
		[Token(Token = "0x4001DE7")]
		[FieldOffset(Offset = "0x260")]
		private float _currentColdFactor;

		// Token: 0x04001DE8 RID: 7656
		[Token(Token = "0x4001DE8")]
		[FieldOffset(Offset = "0x264")]
		private float _currentRestedBuffFactor;

		// Token: 0x04001DE9 RID: 7657
		[Token(Token = "0x4001DE9")]
		[FieldOffset(Offset = "0x268")]
		private float _currentFullnessBuffFactor;

		// Token: 0x04001DEA RID: 7658
		[Token(Token = "0x4001DEA")]
		[FieldOffset(Offset = "0x26C")]
		private float _currentHydrationBuffFactor;

		// Token: 0x04001DEB RID: 7659
		[Token(Token = "0x4001DEB")]
		[FieldOffset(Offset = "0x270")]
		private float _shownStealthFactor;

		// Token: 0x04001DEC RID: 7660
		[Token(Token = "0x4001DEC")]
		[FieldOffset(Offset = "0x278")]
		private Material _stealthIconMaterial;

		// Token: 0x04001DED RID: 7661
		[Token(Token = "0x4001DED")]
		[FieldOffset(Offset = "0x280")]
		private PlayerVisibility _playerVisibility;

		// Token: 0x04001DEE RID: 7662
		[Token(Token = "0x4001DEE")]
		[FieldOffset(Offset = "0x288")]
		private bool _stealthGroupVisibilityGoal;

		// Token: 0x04001DEF RID: 7663
		[Token(Token = "0x4001DEF")]
		[FieldOffset(Offset = "0x290")]
		private AutoTimer _stealthGroupVisibilitySwitchTimer;

		// Token: 0x04001DF0 RID: 7664
		[Token(Token = "0x4001DF0")]
		[FieldOffset(Offset = "0x298")]
		private float _fullnessAlertTimeFactor;

		// Token: 0x04001DF1 RID: 7665
		[Token(Token = "0x4001DF1")]
		[FieldOffset(Offset = "0x29C")]
		private float _restedAlertTimeFactor;

		// Token: 0x04001DF2 RID: 7666
		[Token(Token = "0x4001DF2")]
		[FieldOffset(Offset = "0x2A0")]
		private float _hydrationAlertTimeFactor;

		// Token: 0x020004E3 RID: 1251
		[Token(Token = "0x20004E3")]
		[Serializable]
		public class AmountIndicationDef
		{
			// Token: 0x06002023 RID: 8227 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002023")]
			[Address(RVA = "0x2D262A0", Offset = "0x2D252A0", VA = "0x182D262A0")]
			private void Test()
			{
			}

			// Token: 0x06002024 RID: 8228 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002024")]
			[Address(RVA = "0x2D26100", Offset = "0x2D25100", VA = "0x182D26100")]
			public void Apply(float amount)
			{
			}

			// Token: 0x06002025 RID: 8229 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002025")]
			[Address(RVA = "0x2D262B0", Offset = "0x2D252B0", VA = "0x182D262B0")]
			public AmountIndicationDef()
			{
			}

			// Token: 0x04001DF3 RID: 7667
			[Token(Token = "0x4001DF3")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private float _interval;

			// Token: 0x04001DF4 RID: 7668
			[Token(Token = "0x4001DF4")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Disc _discElement;

			// Token: 0x04001DF5 RID: 7669
			[Token(Token = "0x4001DF5")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private float _notchThickness;

			// Token: 0x04001DF6 RID: 7670
			[Token(Token = "0x4001DF6")]
			[FieldOffset(Offset = "0x24")]
			[SerializeField]
			private float _notchThicknessScale;

			// Token: 0x04001DF7 RID: 7671
			[Token(Token = "0x4001DF7")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private float _notchProgressiveScale;

			// Token: 0x04001DF8 RID: 7672
			[Token(Token = "0x4001DF8")]
			[FieldOffset(Offset = "0x2C")]
			[SerializeField]
			private float _startFull;

			// Token: 0x04001DF9 RID: 7673
			[Token(Token = "0x4001DF9")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private float _endFull;

			// Token: 0x04001DFA RID: 7674
			[Token(Token = "0x4001DFA")]
			[FieldOffset(Offset = "0x34")]
			[SerializeField]
			private float _testAmount;

			// Token: 0x04001DFB RID: 7675
			[Token(Token = "0x4001DFB")]
			[FieldOffset(Offset = "0x38")]
			private int _currentNotches;

			// Token: 0x04001DFC RID: 7676
			[Token(Token = "0x4001DFC")]
			[FieldOffset(Offset = "0x3C")]
			private float _currentAmount;
		}

		// Token: 0x020004E4 RID: 1252
		[Token(Token = "0x20004E4")]
		[Serializable]
		public class VitalElementDef
		{
			// Token: 0x06002026 RID: 8230 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002026")]
			[Address(RVA = "0x2D37BD0", Offset = "0x2D36BD0", VA = "0x182D37BD0")]
			public void ApplyFactor(float factor)
			{
			}

			// Token: 0x06002027 RID: 8231 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002027")]
			[Address(RVA = "0x2D37BE0", Offset = "0x2D36BE0", VA = "0x182D37BE0")]
			public void ApplyFactor(float factorBase, float factor)
			{
			}

			// Token: 0x06002028 RID: 8232 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002028")]
			[Address(RVA = "0x2476210", Offset = "0x2475210", VA = "0x182476210")]
			public void Disable()
			{
			}

			// Token: 0x06002029 RID: 8233 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002029")]
			[Address(RVA = "0x2D37B90", Offset = "0x2D36B90", VA = "0x182D37B90")]
			public void ApplyColor(Color color)
			{
			}

			// Token: 0x0600202A RID: 8234 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600202A")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public VitalElementDef()
			{
			}

			// Token: 0x04001DFD RID: 7677
			[Token(Token = "0x4001DFD")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Disc _discElement;

			// Token: 0x04001DFE RID: 7678
			[Token(Token = "0x4001DFE")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private float _discStartFullValue;

			// Token: 0x04001DFF RID: 7679
			[Token(Token = "0x4001DFF")]
			[FieldOffset(Offset = "0x1C")]
			[SerializeField]
			private float _discEndFullValue;

			// Token: 0x04001E00 RID: 7680
			[Token(Token = "0x4001E00")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private float _discStartEmptyValue;

			// Token: 0x04001E01 RID: 7681
			[Token(Token = "0x4001E01")]
			[FieldOffset(Offset = "0x24")]
			[SerializeField]
			private float _discEndEmptyValue;

			// Token: 0x04001E02 RID: 7682
			[Token(Token = "0x4001E02")]
			[FieldOffset(Offset = "0x28")]
			private float _currentBaseFactor;

			// Token: 0x04001E03 RID: 7683
			[Token(Token = "0x4001E03")]
			[FieldOffset(Offset = "0x2C")]
			private float _currentFactor;
		}
	}
}
