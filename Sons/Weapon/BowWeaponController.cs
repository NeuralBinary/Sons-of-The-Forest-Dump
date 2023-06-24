using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Weapon
{
	// Token: 0x020008A3 RID: 2211
	[Token(Token = "0x20008A3")]
	[AddComponentMenu("Sons/Weapon/BowWeaponController")]
	public class BowWeaponController : RangedWeaponController
	{
		// Token: 0x06003EFA RID: 16122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EFA")]
		[Address(RVA = "0x35DCB10", Offset = "0x35DB110", VA = "0x1835DCB10", Slot = "17")]
		protected override void FireWeapon()
		{
		}

		// Token: 0x06003EFB RID: 16123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EFB")]
		[Address(RVA = "0x35DCBB0", Offset = "0x35DB1B0", VA = "0x1835DCBB0", Slot = "16")]
		protected override void Update()
		{
		}

		// Token: 0x06003EFC RID: 16124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EFC")]
		[Address(RVA = "0x35DCC40", Offset = "0x35DB240", VA = "0x1835DCC40", Slot = "13")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06003EFD RID: 16125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EFD")]
		[Address(RVA = "0x35DCDD0", Offset = "0x35DB3D0", VA = "0x1835DCDD0")]
		private void OnCancelDraw(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x06003EFE RID: 16126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EFE")]
		[Address(RVA = "0x35DCDE0", Offset = "0x35DB3E0", VA = "0x1835DCDE0", Slot = "12")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06003EFF RID: 16127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EFF")]
		[Address(RVA = "0x35DD1D0", Offset = "0x35DB7D0", VA = "0x1835DD1D0")]
		private void OnProjectileReleased()
		{
		}

		// Token: 0x06003F00 RID: 16128 RVA: 0x00013260 File Offset: 0x00011460
		[Token(Token = "0x6003F00")]
		[Address(RVA = "0x35DD270", Offset = "0x35DB870", VA = "0x1835DD270", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06003F01 RID: 16129 RVA: 0x00013278 File Offset: 0x00011478
		[Token(Token = "0x6003F01")]
		[Address(RVA = "0x35DD340", Offset = "0x35DB940", VA = "0x1835DD340", Slot = "26")]
		protected override bool IsReloading()
		{
			return default(bool);
		}

		// Token: 0x06003F02 RID: 16130 RVA: 0x00013290 File Offset: 0x00011490
		[Token(Token = "0x6003F02")]
		[Address(RVA = "0x35DD410", Offset = "0x35DBA10", VA = "0x1835DD410", Slot = "35")]
		protected override bool IsAimStimuliActive()
		{
			return default(bool);
		}

		// Token: 0x06003F03 RID: 16131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F03")]
		[Address(RVA = "0x35DD460", Offset = "0x35DBA60", VA = "0x1835DD460")]
		public BowWeaponController()
		{
		}
	}
}
