using System;
using Il2CppDummyDll;
using Sons.Gui.Input;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Construction
{
	// Token: 0x0200016D RID: 365
	[Token(Token = "0x200016D")]
	[AddComponentMenu("Sons/Construction/ElectricDeviceSwitch")]
	public class ElectricDeviceSwitch : MonoBehaviour
	{
		// Token: 0x06000AE5 RID: 2789 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AE5")]
		[Address(RVA = "0x2612770", Offset = "0x2610D70", VA = "0x182612770")]
		private void Awake()
		{
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AE6")]
		[Address(RVA = "0x2EA44A0", Offset = "0x2EA2AA0", VA = "0x182EA44A0")]
		private void Update()
		{
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0x2EA4540", Offset = "0x2EA2B40", VA = "0x182EA4540")]
		private void OnEnable()
		{
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AE8")]
		[Address(RVA = "0x2EA46B0", Offset = "0x2EA2CB0", VA = "0x182EA46B0")]
		private void OnDisable()
		{
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AE9")]
		[Address(RVA = "0x2E3A120", Offset = "0x2E38720", VA = "0x182E3A120")]
		private void GrabEnter()
		{
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AEA")]
		[Address(RVA = "0x2612770", Offset = "0x2610D70", VA = "0x182612770")]
		private void GrabExit()
		{
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AEB")]
		[Address(RVA = "0x2EA4880", Offset = "0x2EA2E80", VA = "0x182EA4880")]
		private void OnInteract(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AEC")]
		[Address(RVA = "0x2EA4AC0", Offset = "0x2EA30C0", VA = "0x182EA4AC0")]
		public void SwitchState(Vector3 playerPosition)
		{
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x000070C4 File Offset: 0x000052C4
		[Token(Token = "0x6000AED")]
		[Address(RVA = "0x2EA4C50", Offset = "0x2EA3250", VA = "0x182EA4C50")]
		private bool IsInFront(Vector3 playerPosition)
		{
			return default(bool);
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000AEE")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ElectricDeviceSwitch()
		{
		}

		// Token: 0x040006D7 RID: 1751
		[Token(Token = "0x40006D7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LinkUiElement _icon;
	}
}
