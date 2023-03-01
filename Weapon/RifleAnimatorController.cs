using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x02000862 RID: 2146
	[Token(Token = "0x2000862")]
	[AddComponentMenu("Sons/Weapon/Rifle Weapon Controller")]
	public class RifleAnimatorController : RangedWeaponController
	{
		// Token: 0x06003978 RID: 14712 RVA: 0x00010D58 File Offset: 0x0000EF58
		[Token(Token = "0x6003978")]
		[Address(RVA = "0x2ED9870", Offset = "0x2ED8870", VA = "0x182ED9870", Slot = "25")]
		protected override bool IsReloading()
		{
			return default(bool);
		}

		// Token: 0x06003979 RID: 14713 RVA: 0x00010D70 File Offset: 0x0000EF70
		[Token(Token = "0x6003979")]
		[Address(RVA = "0x2ED9780", Offset = "0x2ED8780", VA = "0x182ED9780", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x0600397A RID: 14714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600397A")]
		[Address(RVA = "0x2EAED50", Offset = "0x2EADD50", VA = "0x182EAED50")]
		public RifleAnimatorController()
		{
		}
	}
}
