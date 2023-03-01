using System;
using Il2CppDummyDll;
using Sons.Gui.Input;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Gameplay.Traps
{
	// Token: 0x020006F0 RID: 1776
	[Token(Token = "0x20006F0")]
	public class ResetScrewTrap : MonoBehaviour
	{
		// Token: 0x06002DD2 RID: 11730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DD2")]
		[Address(RVA = "0x21F6BA0", Offset = "0x21F5BA0", VA = "0x1821F6BA0")]
		private void Awake()
		{
		}

		// Token: 0x06002DD3 RID: 11731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DD3")]
		[Address(RVA = "0x2E13D80", Offset = "0x2E12D80", VA = "0x182E13D80")]
		private void GrabEnter()
		{
		}

		// Token: 0x06002DD4 RID: 11732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DD4")]
		[Address(RVA = "0x2E13EF0", Offset = "0x2E12EF0", VA = "0x182E13EF0")]
		private void GrabExit()
		{
		}

		// Token: 0x06002DD5 RID: 11733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DD5")]
		[Address(RVA = "0x2E14060", Offset = "0x2E13060", VA = "0x182E14060")]
		private void OnResetTrap(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06002DD6 RID: 11734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DD6")]
		[Address(RVA = "0x2E14180", Offset = "0x2E13180", VA = "0x182E14180")]
		public void UpdateResetTrapInteractionVisibility()
		{
		}

		// Token: 0x06002DD7 RID: 11735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DD7")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public ResetScrewTrap()
		{
		}

		// Token: 0x040028DE RID: 10462
		[Token(Token = "0x40028DE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LinkUiElement _resetTrapInteraction;

		// Token: 0x040028DF RID: 10463
		[Token(Token = "0x40028DF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BaseTrapController _trap;
	}
}
