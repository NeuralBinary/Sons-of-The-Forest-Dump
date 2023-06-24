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
	// Token: 0x020005EC RID: 1516
	[Token(Token = "0x20005EC")]
	public class InventoryLedStripManager : MonoBehaviour
	{
		// Token: 0x06002768 RID: 10088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002768")]
		[Address(RVA = "0x33C5540", Offset = "0x33C3B40", VA = "0x1833C5540")]
		private void Awake()
		{
		}

		// Token: 0x06002769 RID: 10089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002769")]
		[Address(RVA = "0x33C5970", Offset = "0x33C3F70", VA = "0x1833C5970")]
		private void Start()
		{
		}

		// Token: 0x0600276A RID: 10090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600276A")]
		[Address(RVA = "0x33C5AC0", Offset = "0x33C40C0", VA = "0x1833C5AC0")]
		private static void SetupButton(GameObject buttonObject, UnityAction onEnter, UnityAction onExit, ref MeshOutliner outMeshOutliner)
		{
		}

		// Token: 0x0600276B RID: 10091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600276B")]
		[Address(RVA = "0x33C5D70", Offset = "0x33C4370", VA = "0x1833C5D70")]
		private void Update()
		{
		}

		// Token: 0x0600276C RID: 10092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600276C")]
		[Address(RVA = "0x33C5FA0", Offset = "0x33C45A0", VA = "0x1833C5FA0")]
		private void UpdateButtons()
		{
		}

		// Token: 0x0600276D RID: 10093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600276D")]
		[Address(RVA = "0x33C6160", Offset = "0x33C4760", VA = "0x1833C6160")]
		private void UpdateButton(ref float current, ref float target, GameObject boneTarget, Vector3 startPos, Vector3 downPos, bool returnToZero = false)
		{
		}

		// Token: 0x0600276E RID: 10094 RVA: 0x0000BBC8 File Offset: 0x00009DC8
		[Token(Token = "0x600276E")]
		[Address(RVA = "0x33C6460", Offset = "0x33C4A60", VA = "0x1833C6460")]
		private bool WereLightsActive()
		{
			return default(bool);
		}

		// Token: 0x0600276F RID: 10095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600276F")]
		[Address(RVA = "0x33C6510", Offset = "0x33C4B10", VA = "0x1833C6510")]
		private void WereLightsActive(bool active)
		{
		}

		// Token: 0x06002770 RID: 10096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002770")]
		[Address(RVA = "0x33C65B0", Offset = "0x33C4BB0", VA = "0x1833C65B0")]
		private void OnEnable()
		{
		}

		// Token: 0x06002771 RID: 10097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002771")]
		[Address(RVA = "0x33C6A10", Offset = "0x33C5010", VA = "0x1833C6A10")]
		private void OnDisable()
		{
		}

		// Token: 0x06002772 RID: 10098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002772")]
		[Address(RVA = "0x33C6EA0", Offset = "0x33C54A0", VA = "0x1833C6EA0")]
		private void TryInteractWithButtons(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06002773 RID: 10099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002773")]
		[Address(RVA = "0x33C7100", Offset = "0x33C5700", VA = "0x1833C7100")]
		private void TogglePower()
		{
		}

		// Token: 0x06002774 RID: 10100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002774")]
		[Address(RVA = "0x33C7640", Offset = "0x33C5C40", VA = "0x1833C7640")]
		private void PowerOn(bool enable)
		{
		}

		// Token: 0x06002775 RID: 10101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002775")]
		[Address(RVA = "0x33C7650", Offset = "0x33C5C50", VA = "0x1833C7650")]
		private void CycleColor()
		{
		}

		// Token: 0x06002776 RID: 10102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002776")]
		[Address(RVA = "0x33C7750", Offset = "0x33C5D50", VA = "0x1833C7750")]
		private void SetColor(Color color)
		{
		}

		// Token: 0x06002777 RID: 10103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002777")]
		[Address(RVA = "0x33C79C0", Offset = "0x33C5FC0", VA = "0x1833C79C0")]
		private void OnColorSwitchEnter()
		{
		}

		// Token: 0x06002778 RID: 10104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002778")]
		[Address(RVA = "0x33C7A30", Offset = "0x33C6030", VA = "0x1833C7A30")]
		private void OnColorSwitchExit()
		{
		}

		// Token: 0x06002779 RID: 10105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002779")]
		[Address(RVA = "0x33C7AA0", Offset = "0x33C60A0", VA = "0x1833C7AA0")]
		private void OnPowerSwitchOnEnter()
		{
		}

		// Token: 0x0600277A RID: 10106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600277A")]
		[Address(RVA = "0x33C7B90", Offset = "0x33C6190", VA = "0x1833C7B90")]
		private void OnPowerSwitchOnExit()
		{
		}

		// Token: 0x0600277B RID: 10107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600277B")]
		[Address(RVA = "0x33C7C00", Offset = "0x33C6200", VA = "0x1833C7C00")]
		private void OnPowerSwitchOffEnter()
		{
		}

		// Token: 0x0600277C RID: 10108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600277C")]
		[Address(RVA = "0x33C7C70", Offset = "0x33C6270", VA = "0x1833C7C70")]
		private void OnPowerSwitchOffExit()
		{
		}

		// Token: 0x0600277D RID: 10109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600277D")]
		[Address(RVA = "0x33C7CE0", Offset = "0x33C62E0", VA = "0x1833C7CE0")]
		private void UpdateOverheadLightIntensity(float intensity)
		{
		}

		// Token: 0x0600277E RID: 10110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600277E")]
		[Address(RVA = "0x33C7E10", Offset = "0x33C6410", VA = "0x1833C7E10")]
		private void UpdateLightStripIntensity(float intensity)
		{
		}

		// Token: 0x0600277F RID: 10111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600277F")]
		[Address(RVA = "0x33C7F60", Offset = "0x33C6560", VA = "0x1833C7F60")]
		private void UpdateEmissiveMaterialIntensityFromInspector()
		{
		}

		// Token: 0x06002780 RID: 10112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002780")]
		[Address(RVA = "0x33C7F70", Offset = "0x33C6570", VA = "0x1833C7F70")]
		private void UpdateEmissiveIntensity(float intensity)
		{
		}

		// Token: 0x06002781 RID: 10113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002781")]
		[Address(RVA = "0x33C8210", Offset = "0x33C6810", VA = "0x1833C8210")]
		public InventoryLedStripManager()
		{
		}

		// Token: 0x040023A7 RID: 9127
		[Token(Token = "0x40023A7")]
		private const string PowerOffTranslationKey = "POWER_OFF";

		// Token: 0x040023A8 RID: 9128
		[Token(Token = "0x40023A8")]
		private const string PowerOnTranslationKey = "POWER_ON";

		// Token: 0x040023A9 RID: 9129
		[Token(Token = "0x40023A9")]
		private const string LightColorTranslationKey = "LIGHT_COLOR";

		// Token: 0x040023AA RID: 9130
		[Token(Token = "0x40023AA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[ColorUsage(false, true)]
		private List<Color> _colors;

		// Token: 0x040023AB RID: 9131
		[Token(Token = "0x40023AB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<LedStrip> _ledStrips;

		// Token: 0x040023AC RID: 9132
		[Token(Token = "0x40023AC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Light _fakeBounceLight;

		// Token: 0x040023AD RID: 9133
		[Token(Token = "0x40023AD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Range(1f, 500f)]
		private float _overheadLightIntensity;

		// Token: 0x040023AE RID: 9134
		[Token(Token = "0x40023AE")]
		[FieldOffset(Offset = "0x3C")]
		[Range(1f, 500f)]
		[SerializeField]
		[FormerlySerializedAs("_lightIntensity")]
		private float _lightStripIntensity;

		// Token: 0x040023AF RID: 9135
		[Token(Token = "0x40023AF")]
		[FieldOffset(Offset = "0x40")]
		[Range(0f, 30f)]
		[FormerlySerializedAs("_emissiveIntensity")]
		[SerializeField]
		private float _emissiveMaterialIntensity;

		// Token: 0x040023B0 RID: 9136
		[Token(Token = "0x40023B0")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _autoActivationAmbientLevel;

		// Token: 0x040023B1 RID: 9137
		[Token(Token = "0x40023B1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private InventoryLedStripMusicVisualizer _musicVisualizer;

		// Token: 0x040023B2 RID: 9138
		[Token(Token = "0x40023B2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private InventoryMusicPlayerController _musicPlayer;

		// Token: 0x040023B3 RID: 9139
		[Token(Token = "0x40023B3")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[FormerlySerializedAs("_powerSwitchOn")]
		private GameObject _powerSwitchMesh;

		// Token: 0x040023B4 RID: 9140
		[Token(Token = "0x40023B4")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _powerSwitchBone;

		// Token: 0x040023B5 RID: 9141
		[Token(Token = "0x40023B5")]
		[FieldOffset(Offset = "0x68")]
		[FormerlySerializedAs("_colorSwitch")]
		[SerializeField]
		private GameObject _colorSwitchMesh;

		// Token: 0x040023B6 RID: 9142
		[Token(Token = "0x40023B6")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _colorSwitchBone;

		// Token: 0x040023B7 RID: 9143
		[Token(Token = "0x40023B7")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _buttonSpeed;

		// Token: 0x040023B8 RID: 9144
		[Token(Token = "0x40023B8")]
		[FieldOffset(Offset = "0x80")]
		[EventRef]
		[SerializeField]
		private string _powerClickAudioEvent;

		// Token: 0x040023B9 RID: 9145
		[Token(Token = "0x40023B9")]
		[FieldOffset(Offset = "0x88")]
		[EventRef]
		[SerializeField]
		private string _colorClickAudioEvent;

		// Token: 0x040023BA RID: 9146
		[Token(Token = "0x40023BA")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[HideInInspector]
		private bool _isPowerOn;

		// Token: 0x040023BB RID: 9147
		[Token(Token = "0x40023BB")]
		[FieldOffset(Offset = "0x0")]
		private static int _currentColorIndex;

		// Token: 0x040023BC RID: 9148
		[Token(Token = "0x40023BC")]
		[FieldOffset(Offset = "0x91")]
		private bool _isOverColorSwitch;

		// Token: 0x040023BD RID: 9149
		[Token(Token = "0x40023BD")]
		[FieldOffset(Offset = "0x92")]
		private bool _isOverPowerSwitch;

		// Token: 0x040023BE RID: 9150
		[Token(Token = "0x40023BE")]
		[FieldOffset(Offset = "0x98")]
		private MeshOutliner _colorCycleOutliner;

		// Token: 0x040023BF RID: 9151
		[Token(Token = "0x40023BF")]
		[FieldOffset(Offset = "0xA0")]
		private MeshOutliner _powerSwitchOnOutliner;

		// Token: 0x040023C0 RID: 9152
		[Token(Token = "0x40023C0")]
		[FieldOffset(Offset = "0xA8")]
		private MeshOutliner _powerSwitchOffOutliner;

		// Token: 0x040023C1 RID: 9153
		[Token(Token = "0x40023C1")]
		[FieldOffset(Offset = "0xB0")]
		private bool _manuallyTriggeredPowerState;

		// Token: 0x040023C2 RID: 9154
		[Token(Token = "0x40023C2")]
		[FieldOffset(Offset = "0xB4")]
		private float _powerSwitchTarget;

		// Token: 0x040023C3 RID: 9155
		[Token(Token = "0x40023C3")]
		[FieldOffset(Offset = "0xB8")]
		private float _colorSwitchTarget;

		// Token: 0x040023C4 RID: 9156
		[Token(Token = "0x40023C4")]
		[FieldOffset(Offset = "0xBC")]
		private float _powerSwitchCurrent;

		// Token: 0x040023C5 RID: 9157
		[Token(Token = "0x40023C5")]
		[FieldOffset(Offset = "0xC0")]
		private float _colorSwitchCurrent;

		// Token: 0x040023C6 RID: 9158
		[Token(Token = "0x40023C6")]
		[FieldOffset(Offset = "0xC4")]
		private Vector3 _powerSwitchStartPos;

		// Token: 0x040023C7 RID: 9159
		[Token(Token = "0x40023C7")]
		[FieldOffset(Offset = "0xD0")]
		private Vector3 _colorSwitchStartPos;

		// Token: 0x040023C8 RID: 9160
		[Token(Token = "0x40023C8")]
		[FieldOffset(Offset = "0xDC")]
		private Vector3 _powerSwitchDownPos;

		// Token: 0x040023C9 RID: 9161
		[Token(Token = "0x40023C9")]
		[FieldOffset(Offset = "0xE8")]
		private Vector3 _colorSwitchDownPos;
	}
}
