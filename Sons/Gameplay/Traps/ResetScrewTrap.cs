using System;
using Il2CppDummyDll;
using Sons.Gui.Input;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Gameplay.Traps
{
	// Token: 0x0200083D RID: 2109
	[Token(Token = "0x200083D")]
	public class ResetScrewTrap : MonoBehaviour
	{
		// Token: 0x06003BBF RID: 15295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BBF")]
		[Address(RVA = "0x2612770", Offset = "0x2610D70", VA = "0x182612770")]
		private void Awake()
		{
		}

		// Token: 0x06003BC0 RID: 15296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BC0")]
		[Address(RVA = "0x3594990", Offset = "0x3592F90", VA = "0x183594990")]
		private void GrabEnter()
		{
		}

		// Token: 0x06003BC1 RID: 15297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BC1")]
		[Address(RVA = "0x3594B50", Offset = "0x3593150", VA = "0x183594B50")]
		private void GrabExit()
		{
		}

		// Token: 0x06003BC2 RID: 15298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BC2")]
		[Address(RVA = "0x3594D10", Offset = "0x3593310", VA = "0x183594D10")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003BC3 RID: 15299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BC3")]
		[Address(RVA = "0x3594E80", Offset = "0x3593480", VA = "0x183594E80")]
		private void OnResetTrap(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06003BC4 RID: 15300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BC4")]
		[Address(RVA = "0x3594FE0", Offset = "0x35935E0", VA = "0x183594FE0")]
		public void UpdateResetTrapInteractionVisibility()
		{
		}

		// Token: 0x06003BC5 RID: 15301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BC5")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ResetScrewTrap()
		{
		}

		// Token: 0x040032BD RID: 12989
		[Token(Token = "0x40032BD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LinkUiElement _resetTrapInteraction;

		// Token: 0x040032BE RID: 12990
		[Token(Token = "0x40032BE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BaseTrapController _trap;
	}
}
