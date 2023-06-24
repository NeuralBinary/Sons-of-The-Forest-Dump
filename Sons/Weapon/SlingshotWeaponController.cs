using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Sons.Weapon
{
	// Token: 0x020008DB RID: 2267
	[Token(Token = "0x20008DB")]
	[AddComponentMenu("Sons/Weapon/SlingshotWeaponController")]
	public class SlingshotWeaponController : RangedWeaponController
	{
		// Token: 0x060040DB RID: 16603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040DB")]
		[Address(RVA = "0x3607220", Offset = "0x3605820", VA = "0x183607220", Slot = "16")]
		protected override void Update()
		{
		}

		// Token: 0x060040DC RID: 16604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040DC")]
		[Address(RVA = "0x3607290", Offset = "0x3605890", VA = "0x183607290", Slot = "13")]
		protected override void OnEnable()
		{
		}

		// Token: 0x060040DD RID: 16605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040DD")]
		[Address(RVA = "0x3607420", Offset = "0x3605A20", VA = "0x183607420", Slot = "12")]
		protected override void OnDisable()
		{
		}

		// Token: 0x060040DE RID: 16606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040DE")]
		[Address(RVA = "0x35DCDD0", Offset = "0x35DB3D0", VA = "0x1835DCDD0")]
		private void OnCancelDraw(InputAction.CallbackContext obj)
		{
		}

		// Token: 0x060040DF RID: 16607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040DF")]
		[Address(RVA = "0x3607660", Offset = "0x3605C60", VA = "0x183607660", Slot = "17")]
		protected override void FireWeapon()
		{
		}

		// Token: 0x060040E0 RID: 16608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040E0")]
		[Address(RVA = "0x3607730", Offset = "0x3605D30", VA = "0x183607730")]
		private void OnProjectileReleased()
		{
		}

		// Token: 0x060040E1 RID: 16609 RVA: 0x00013D28 File Offset: 0x00011F28
		[Token(Token = "0x60040E1")]
		[Address(RVA = "0x36077D0", Offset = "0x3605DD0", VA = "0x1836077D0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x060040E2 RID: 16610 RVA: 0x00013D40 File Offset: 0x00011F40
		[Token(Token = "0x60040E2")]
		[Address(RVA = "0x36078A0", Offset = "0x3605EA0", VA = "0x1836078A0", Slot = "26")]
		protected override bool IsReloading()
		{
			return default(bool);
		}

		// Token: 0x060040E3 RID: 16611 RVA: 0x00013D58 File Offset: 0x00011F58
		[Token(Token = "0x60040E3")]
		[Address(RVA = "0x35DD410", Offset = "0x35DBA10", VA = "0x1835DD410", Slot = "35")]
		protected override bool IsAimStimuliActive()
		{
			return default(bool);
		}

		// Token: 0x060040E4 RID: 16612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040E4")]
		[Address(RVA = "0x35DD460", Offset = "0x35DBA60", VA = "0x1835DD460")]
		public SlingshotWeaponController()
		{
		}
	}
}
