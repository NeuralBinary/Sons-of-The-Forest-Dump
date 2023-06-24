using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x020008BC RID: 2236
	[Token(Token = "0x20008BC")]
	[AddComponentMenu("Sons/Weapon/GuitarController")]
	public class GuitarController : GenericMeleeWeaponController
	{
		// Token: 0x06003FD7 RID: 16343 RVA: 0x000137A0 File Offset: 0x000119A0
		[Token(Token = "0x6003FD7")]
		[Address(RVA = "0x35EFD70", Offset = "0x35EE370", VA = "0x1835EFD70", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06003FD8 RID: 16344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FD8")]
		[Address(RVA = "0x35DCB00", Offset = "0x35DB100", VA = "0x1835DCB00")]
		public GuitarController()
		{
		}
	}
}
