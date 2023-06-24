using System;
using Il2CppDummyDll;
using Sons.Gui.Input;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Construction
{
	// Token: 0x0200015A RID: 346
	[Token(Token = "0x200015A")]
	[AddComponentMenu("Sons/Construction/DefensiveWallGateInteraction")]
	public class DefensiveWallGateInteraction : MonoBehaviour
	{
		// Token: 0x06000A3D RID: 2621 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x2E3A120", Offset = "0x2E38720", VA = "0x182E3A120")]
		private void GrabEnter()
		{
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x2612770", Offset = "0x2610D70", VA = "0x182612770")]
		private void GrabExit()
		{
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0x2E93940", Offset = "0x2E91F40", VA = "0x182E93940")]
		private void Start()
		{
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x2E93CE0", Offset = "0x2E922E0", VA = "0x182E93CE0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A41")]
		[Address(RVA = "0x2E93E60", Offset = "0x2E92460", VA = "0x182E93E60")]
		private void OnDisable()
		{
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A42")]
		[Address(RVA = "0x2E93FE0", Offset = "0x2E925E0", VA = "0x182E93FE0")]
		private void SetIconEnableStatus(bool onOff)
		{
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A43")]
		[Address(RVA = "0x2E94480", Offset = "0x2E92A80", VA = "0x182E94480")]
		private void OnToggleGateAction(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A44")]
		[Address(RVA = "0x2E94700", Offset = "0x2E92D00", VA = "0x182E94700")]
		public static void MpSync(DefensiveWallGateControl gateControl)
		{
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000A45")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public DefensiveWallGateInteraction()
		{
		}

		// Token: 0x040006AD RID: 1709
		[Token(Token = "0x40006AD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DefensiveWallGateInteraction _linkedInteraction;

		// Token: 0x040006AE RID: 1710
		[Token(Token = "0x40006AE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LinkUiElement _icon;
	}
}
