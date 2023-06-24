using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x020008CA RID: 2250
	[Token(Token = "0x20008CA")]
	[AddComponentMenu("Sons/Weapon/PrintedKnifeWeaponController")]
	public class PrintedKnifeWeaponController : GenericMeleeWeaponController
	{
		// Token: 0x0600404A RID: 16458 RVA: 0x00013A40 File Offset: 0x00011C40
		[Token(Token = "0x600404A")]
		[Address(RVA = "0x35F8520", Offset = "0x35F6B20", VA = "0x1835F8520", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x0600404B RID: 16459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600404B")]
		[Address(RVA = "0x35DCB00", Offset = "0x35DB100", VA = "0x1835DCB00")]
		public PrintedKnifeWeaponController()
		{
		}
	}
}
