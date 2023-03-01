using System;
using System.Collections.Generic;
using FMODUnity;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

namespace Sons.Inventory
{
	// Token: 0x020005DB RID: 1499
	[Token(Token = "0x20005DB")]
	public class InventoryLedStripManager : MonoBehaviour
	{
		// Token: 0x0600265F RID: 9823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600265F")]
		[Address(RVA = "0x2DA0B20", Offset = "0x2D9FB20", VA = "0x182DA0B20")]
		private void Awake()
		{
		}

		// Token: 0x06002660 RID: 9824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002660")]
		[Address(RVA = "0x2DA1850", Offset = "0x2DA0850", VA = "0x182DA1850")]
		private void Start()
		{
		}

		// Token: 0x06002661 RID: 9825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002661")]
		[Address(RVA = "0x2DA16D0", Offset = "0x2DA06D0", VA = "0x182DA16D0")]
		private static void SetupButton(GameObject buttonObject, UnityAction onEnter, UnityAction onExit, ref MeshOutliner outMeshOutliner)
		{
		}

		// Token: 0x06002662 RID: 9826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002662")]
		[Address(RVA = "0x2DA2680", Offset = "0x2DA1680", VA = "0x182DA2680")]
		private void Update()
		{
		}

		// Token: 0x06002663 RID: 9827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002663")]
		[Address(RVA = "0x2DA2120", Offset = "0x2DA1120", VA = "0x182DA2120")]
		private void UpdateButtons()
		{
		}

		// Token: 0x06002664 RID: 9828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002664")]
		[Address(RVA = "0x2DA1EB0", Offset = "0x2DA0EB0", VA = "0x182DA1EB0")]
		private void UpdateButton(ref float current, ref float target, GameObject boneTarget, Vector3 startPos, Vector3 downPos, bool returnToZero = false)
		{
		}

		// Token: 0x06002665 RID: 9829 RVA: 0x0000B4D8 File Offset: 0x000096D8
		[Token(Token = "0x6002665")]
		[Address(RVA = "0x2DA2880", Offset = "0x2DA1880", VA = "0x182DA2880")]
		private bool WereLightsActive()
		{
			return default(bool);
		}

		// Token: 0x06002666 RID: 9830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002666")]
		[Address(RVA = "0x2DA2910", Offset = "0x2DA1910", VA = "0x182DA2910")]
		private void WereLightsActive(bool active)
		{
		}

		// Token: 0x06002667 RID: 9831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002667")]
		[Address(RVA = "0x2DA1090", Offset = "0x2DA0090", VA = "0x182DA1090")]
		private void OnEnable()
		{
		}

		// Token: 0x06002668 RID: 9832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002668")]
		[Address(RVA = "0x2DA0E30", Offset = "0x2D9FE30", VA = "0x182DA0E30")]
		private void OnDisable()
		{
		}

		// Token: 0x06002669 RID: 9833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002669")]
		[Address(RVA = "0x2DA1CE0", Offset = "0x2DA0CE0", VA = "0x182DA1CE0")]
		private void TryInteractWithButtons(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x0600266A RID: 9834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600266A")]
		[Address(RVA = "0x2DA19A0", Offset = "0x2DA09A0", VA = "0x182DA19A0")]
		private void TogglePower()
		{
		}

		// Token: 0x0600266B RID: 9835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600266B")]
		[Address(RVA = "0x2DA1510", Offset = "0x2DA0510", VA = "0x182DA1510")]
		private void PowerOn(bool enable)
		{
		}

		// Token: 0x0600266C RID: 9836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600266C")]
		[Address(RVA = "0x2DA0CE0", Offset = "0x2D9FCE0", VA = "0x182DA0CE0")]
		private void CycleColor()
		{
		}

		// Token: 0x0600266D RID: 9837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600266D")]
		[Address(RVA = "0x2DA1520", Offset = "0x2DA0520", VA = "0x182DA1520")]
		private void SetColor(Color color)
		{
		}

		// Token: 0x0600266E RID: 9838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600266E")]
		[Address(RVA = "0x2DA0DD0", Offset = "0x2D9FDD0", VA = "0x182DA0DD0")]
		private void OnColorSwitchEnter()
		{
		}

		// Token: 0x0600266F RID: 9839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600266F")]
		[Address(RVA = "0x2DA0E00", Offset = "0x2D9FE00", VA = "0x182DA0E00")]
		private void OnColorSwitchExit()
		{
		}

		// Token: 0x06002670 RID: 9840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002670")]
		[Address(RVA = "0x2DA1430", Offset = "0x2DA0430", VA = "0x182DA1430")]
		private void OnPowerSwitchOnEnter()
		{
		}

		// Token: 0x06002671 RID: 9841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002671")]
		[Address(RVA = "0x2DA14E0", Offset = "0x2DA04E0", VA = "0x182DA14E0")]
		private void OnPowerSwitchOnExit()
		{
		}

		// Token: 0x06002672 RID: 9842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002672")]
		[Address(RVA = "0x2DA13D0", Offset = "0x2DA03D0", VA = "0x182DA13D0")]
		private void OnPowerSwitchOffEnter()
		{
		}

		// Token: 0x06002673 RID: 9843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002673")]
		[Address(RVA = "0x2DA1400", Offset = "0x2DA0400", VA = "0x182DA1400")]
		private void OnPowerSwitchOffExit()
		{
		}

		// Token: 0x06002674 RID: 9844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002674")]
		[Address(RVA = "0x2DA25D0", Offset = "0x2DA15D0", VA = "0x182DA25D0")]
		private void UpdateOverheadLightIntensity(float intensity)
		{
		}

		// Token: 0x06002675 RID: 9845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002675")]
		[Address(RVA = "0x2DA24B0", Offset = "0x2DA14B0", VA = "0x182DA24B0")]
		private void UpdateLightStripIntensity(float intensity)
		{
		}

		// Token: 0x06002676 RID: 9846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002676")]
		[Address(RVA = "0x2DA24A0", Offset = "0x2DA14A0", VA = "0x182DA24A0")]
		private void UpdateEmissiveMaterialIntensityFromInspector()
		{
		}

		// Token: 0x06002677 RID: 9847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002677")]
		[Address(RVA = "0x2DA22E0", Offset = "0x2DA12E0", VA = "0x182DA22E0")]
		private void UpdateEmissiveIntensity(float intensity)
		{
		}

		// Token: 0x06002678 RID: 9848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002678")]
		[Address(RVA = "0x2DA29B0", Offset = "0x2DA19B0", VA = "0x182DA29B0")]
		public InventoryLedStripManager()
		{
		}

		// Token: 0x040022C9 RID: 8905
		[Token(Token = "0x40022C9")]
		private const string PowerOffTranslationKey = "POWER_OFF";

		// Token: 0x040022CA RID: 8906
		[Token(Token = "0x40022CA")]
		private const string PowerOnTranslationKey = "POWER_ON";

		// Token: 0x040022CB RID: 8907
		[Token(Token = "0x40022CB")]
		private const string LightColorTranslationKey = "LIGHT_COLOR";

		// Token: 0x040022CC RID: 8908
		[Token(Token = "0x40022CC")]
		[FieldOffset(Offset = "0x20")]
		[ColorUsage(false, true)]
		[SerializeField]
		private List<Color> _colors;

		// Token: 0x040022CD RID: 8909
		[Token(Token = "0x40022CD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<LedStrip> _ledStrips;

		// Token: 0x040022CE RID: 8910
		[Token(Token = "0x40022CE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Light _fakeBounceLight;

		// Token: 0x040022CF RID: 8911
		[Token(Token = "0x40022CF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Range(1f, 500f)]
		private float _overheadLightIntensity;

		// Token: 0x040022D0 RID: 8912
		[Token(Token = "0x40022D0")]
		[FieldOffset(Offset = "0x3C")]
		[FormerlySerializedAs("_lightIntensity")]
		[SerializeField]
		[Range(1f, 500f)]
		private float _lightStripIntensity;

		// Token: 0x040022D1 RID: 8913
		[Token(Token = "0x40022D1")]
		[FieldOffset(Offset = "0x40")]
		[Range(0f, 30f)]
		[SerializeField]
		[FormerlySerializedAs("_emissiveIntensity")]
		private float _emissiveMaterialIntensity;

		// Token: 0x040022D2 RID: 8914
		[Token(Token = "0x40022D2")]
		[FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _autoActivationAmbientLevel;

		// Token: 0x040022D3 RID: 8915
		[Token(Token = "0x40022D3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private InventoryLedStripMusicVisualizer _musicVisualizer;

		// Token: 0x040022D4 RID: 8916
		[Token(Token = "0x40022D4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private InventoryMusicPlayerController _musicPlayer;

		// Token: 0x040022D5 RID: 8917
		[Token(Token = "0x40022D5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[FormerlySerializedAs("_powerSwitchOn")]
		private GameObject _powerSwitchMesh;

		// Token: 0x040022D6 RID: 8918
		[Token(Token = "0x40022D6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _powerSwitchBone;

		// Token: 0x040022D7 RID: 8919
		[Token(Token = "0x40022D7")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[FormerlySerializedAs("_colorSwitch")]
		private GameObject _colorSwitchMesh;

		// Token: 0x040022D8 RID: 8920
		[Token(Token = "0x40022D8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _colorSwitchBone;

		// Token: 0x040022D9 RID: 8921
		[Token(Token = "0x40022D9")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _buttonSpeed;

		// Token: 0x040022DA RID: 8922
		[Token(Token = "0x40022DA")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[EventRef]
		private string _powerClickAudioEvent;

		// Token: 0x040022DB RID: 8923
		[Token(Token = "0x40022DB")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[EventRef]
		private string _colorClickAudioEvent;

		// Token: 0x040022DC RID: 8924
		[Token(Token = "0x40022DC")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[HideInInspector]
		private bool _isPowerOn;

		// Token: 0x040022DD RID: 8925
		[Token(Token = "0x40022DD")]
		[FieldOffset(Offset = "0x0")]
		private static int _currentColorIndex;

		// Token: 0x040022DE RID: 8926
		[Token(Token = "0x40022DE")]
		[FieldOffset(Offset = "0x91")]
		private bool _isOverColorSwitch;

		// Token: 0x040022DF RID: 8927
		[Token(Token = "0x40022DF")]
		[FieldOffset(Offset = "0x92")]
		private bool _isOverPowerSwitch;

		// Token: 0x040022E0 RID: 8928
		[Token(Token = "0x40022E0")]
		[FieldOffset(Offset = "0x98")]
		private MeshOutliner _colorCycleOutliner;

		// Token: 0x040022E1 RID: 8929
		[Token(Token = "0x40022E1")]
		[FieldOffset(Offset = "0xA0")]
		private MeshOutliner _powerSwitchOnOutliner;

		// Token: 0x040022E2 RID: 8930
		[Token(Token = "0x40022E2")]
		[FieldOffset(Offset = "0xA8")]
		private MeshOutliner _powerSwitchOffOutliner;

		// Token: 0x040022E3 RID: 8931
		[Token(Token = "0x40022E3")]
		[FieldOffset(Offset = "0xB0")]
		private bool _manuallyTriggeredPowerState;

		// Token: 0x040022E4 RID: 8932
		[Token(Token = "0x40022E4")]
		[FieldOffset(Offset = "0xB4")]
		private float _powerSwitchTarget;

		// Token: 0x040022E5 RID: 8933
		[Token(Token = "0x40022E5")]
		[FieldOffset(Offset = "0xB8")]
		private float _colorSwitchTarget;

		// Token: 0x040022E6 RID: 8934
		[Token(Token = "0x40022E6")]
		[FieldOffset(Offset = "0xBC")]
		private float _powerSwitchCurrent;

		// Token: 0x040022E7 RID: 8935
		[Token(Token = "0x40022E7")]
		[FieldOffset(Offset = "0xC0")]
		private float _colorSwitchCurrent;

		// Token: 0x040022E8 RID: 8936
		[Token(Token = "0x40022E8")]
		[FieldOffset(Offset = "0xC4")]
		private Vector3 _powerSwitchStartPos;

		// Token: 0x040022E9 RID: 8937
		[Token(Token = "0x40022E9")]
		[FieldOffset(Offset = "0xD0")]
		private Vector3 _colorSwitchStartPos;

		// Token: 0x040022EA RID: 8938
		[Token(Token = "0x40022EA")]
		[FieldOffset(Offset = "0xDC")]
		private Vector3 _powerSwitchDownPos;

		// Token: 0x040022EB RID: 8939
		[Token(Token = "0x40022EB")]
		[FieldOffset(Offset = "0xE8")]
		private Vector3 _colorSwitchDownPos;
	}
}
