using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x02000860 RID: 2144
	[Token(Token = "0x2000860")]
	[AddComponentMenu("Sons/Weapon/RepairToolWeaponController")]
	public class RepairToolWeaponController : HeldControllerBase
	{
		// Token: 0x06003970 RID: 14704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003970")]
		[Address(RVA = "0x2ED9370", Offset = "0x2ED8370", VA = "0x182ED9370")]
		private void Update()
		{
		}

		// Token: 0x06003971 RID: 14705 RVA: 0x00010CF8 File Offset: 0x0000EEF8
		[Token(Token = "0x6003971")]
		[Address(RVA = "0x2ED91D0", Offset = "0x2ED81D0", VA = "0x182ED91D0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06003972 RID: 14706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003972")]
		[Address(RVA = "0x2ED92C0", Offset = "0x2ED82C0", VA = "0x182ED92C0", Slot = "9")]
		protected override void UnequipStartedHook()
		{
		}

		// Token: 0x06003973 RID: 14707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003973")]
		[Address(RVA = "0x2EC61C0", Offset = "0x2EC51C0", VA = "0x182EC61C0")]
		public RepairToolWeaponController()
		{
		}
	}
}
