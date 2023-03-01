using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Weapon
{
	// Token: 0x02000833 RID: 2099
	[Token(Token = "0x2000833")]
	[AddComponentMenu("Sons/Weapon/BowWeaponController")]
	public class BowWeaponController : RangedWeaponController
	{
		// Token: 0x060037EA RID: 14314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037EA")]
		[Address(RVA = "0x2EAE670", Offset = "0x2EAD670", VA = "0x182EAE670", Slot = "17")]
		protected override void FireWeapon()
		{
		}

		// Token: 0x060037EB RID: 14315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037EB")]
		[Address(RVA = "0x2EAECB0", Offset = "0x2EADCB0", VA = "0x182EAECB0", Slot = "16")]
		protected override void Update()
		{
		}

		// Token: 0x060037EC RID: 14316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037EC")]
		[Address(RVA = "0x2EAEAF0", Offset = "0x2EADAF0", VA = "0x182EAEAF0", Slot = "13")]
		protected override void OnEnable()
		{
		}

		// Token: 0x060037ED RID: 14317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037ED")]
		[Address(RVA = "0x2EAE940", Offset = "0x2EAD940", VA = "0x182EAE940")]
		private void OnCancelDraw(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x060037EE RID: 14318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037EE")]
		[Address(RVA = "0x2EAE950", Offset = "0x2EAD950", VA = "0x182EAE950", Slot = "12")]
		protected override void OnDisable()
		{
		}

		// Token: 0x060037EF RID: 14319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037EF")]
		[Address(RVA = "0x2EAEC10", Offset = "0x2EADC10", VA = "0x182EAEC10")]
		private void OnProjectileReleased()
		{
		}

		// Token: 0x060037F0 RID: 14320 RVA: 0x00010500 File Offset: 0x0000E700
		[Token(Token = "0x60037F0")]
		[Address(RVA = "0x2EAE760", Offset = "0x2EAD760", VA = "0x182EAE760", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x060037F1 RID: 14321 RVA: 0x00010518 File Offset: 0x0000E718
		[Token(Token = "0x60037F1")]
		[Address(RVA = "0x2EAE850", Offset = "0x2EAD850", VA = "0x182EAE850", Slot = "25")]
		protected override bool IsReloading()
		{
			return default(bool);
		}

		// Token: 0x060037F2 RID: 14322 RVA: 0x00010530 File Offset: 0x0000E730
		[Token(Token = "0x60037F2")]
		[Address(RVA = "0x2EAE710", Offset = "0x2EAD710", VA = "0x182EAE710", Slot = "34")]
		protected override bool IsAimStimuliActive()
		{
			return default(bool);
		}

		// Token: 0x060037F3 RID: 14323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037F3")]
		[Address(RVA = "0x2EAED50", Offset = "0x2EADD50", VA = "0x182EAED50")]
		public BowWeaponController()
		{
		}
	}
}
