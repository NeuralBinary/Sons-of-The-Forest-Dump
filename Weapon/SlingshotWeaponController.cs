using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Weapon
{
	// Token: 0x0200086B RID: 2155
	[Token(Token = "0x200086B")]
	[AddComponentMenu("Sons/Weapon/SlingshotWeaponController")]
	public class SlingshotWeaponController : RangedWeaponController
	{
		// Token: 0x060039B7 RID: 14775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039B7")]
		[Address(RVA = "0x2F05A10", Offset = "0x2F04A10", VA = "0x182F05A10", Slot = "16")]
		protected override void Update()
		{
		}

		// Token: 0x060039B8 RID: 14776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039B8")]
		[Address(RVA = "0x2F05850", Offset = "0x2F04850", VA = "0x182F05850", Slot = "13")]
		protected override void OnEnable()
		{
		}

		// Token: 0x060039B9 RID: 14777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039B9")]
		[Address(RVA = "0x2F056D0", Offset = "0x2F046D0", VA = "0x182F056D0", Slot = "12")]
		protected override void OnDisable()
		{
		}

		// Token: 0x060039BA RID: 14778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039BA")]
		[Address(RVA = "0x2EAE940", Offset = "0x2EAD940", VA = "0x182EAE940")]
		private void OnCancelDraw(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x060039BB RID: 14779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039BB")]
		[Address(RVA = "0x2F05390", Offset = "0x2F04390", VA = "0x182F05390", Slot = "17")]
		protected override void FireWeapon()
		{
		}

		// Token: 0x060039BC RID: 14780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039BC")]
		[Address(RVA = "0x2F05970", Offset = "0x2F04970", VA = "0x182F05970")]
		private void OnProjectileReleased()
		{
		}

		// Token: 0x060039BD RID: 14781 RVA: 0x00010EA8 File Offset: 0x0000F0A8
		[Token(Token = "0x60039BD")]
		[Address(RVA = "0x2F05530", Offset = "0x2F04530", VA = "0x182F05530", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x060039BE RID: 14782 RVA: 0x00010EC0 File Offset: 0x0000F0C0
		[Token(Token = "0x60039BE")]
		[Address(RVA = "0x2F05620", Offset = "0x2F04620", VA = "0x182F05620", Slot = "25")]
		protected override bool IsReloading()
		{
			return default(bool);
		}

		// Token: 0x060039BF RID: 14783 RVA: 0x00010ED8 File Offset: 0x0000F0D8
		[Token(Token = "0x60039BF")]
		[Address(RVA = "0x2F054E0", Offset = "0x2F044E0", VA = "0x182F054E0", Slot = "34")]
		protected override bool IsAimStimuliActive()
		{
			return default(bool);
		}

		// Token: 0x060039C0 RID: 14784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60039C0")]
		[Address(RVA = "0x2EAED50", Offset = "0x2EADD50", VA = "0x182EAED50")]
		public SlingshotWeaponController()
		{
		}
	}
}
