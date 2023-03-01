using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x02000861 RID: 2145
	[Token(Token = "0x2000861")]
	[AddComponentMenu("Sons/Items/RevolverWeaponController")]
	public class RevolverWeaponController : RangedWeaponController
	{
		// Token: 0x06003974 RID: 14708 RVA: 0x00010D10 File Offset: 0x0000EF10
		[Token(Token = "0x6003974")]
		[Address(RVA = "0x2ED95D0", Offset = "0x2ED85D0", VA = "0x182ED95D0", Slot = "25")]
		protected override bool IsReloading()
		{
			return default(bool);
		}

		// Token: 0x06003975 RID: 14709 RVA: 0x00010D28 File Offset: 0x0000EF28
		[Token(Token = "0x6003975")]
		[Address(RVA = "0x2ED94F0", Offset = "0x2ED84F0", VA = "0x182ED94F0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06003976 RID: 14710 RVA: 0x00010D40 File Offset: 0x0000EF40
		[Token(Token = "0x6003976")]
		[Address(RVA = "0x2ED94B0", Offset = "0x2ED84B0", VA = "0x182ED94B0", Slot = "34")]
		protected override bool IsAimStimuliActive()
		{
			return default(bool);
		}

		// Token: 0x06003977 RID: 14711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003977")]
		[Address(RVA = "0x2EAED50", Offset = "0x2EADD50", VA = "0x182EAED50")]
		public RevolverWeaponController()
		{
		}
	}
}
