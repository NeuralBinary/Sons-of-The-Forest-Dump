using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x020008A2 RID: 2210
	[Token(Token = "0x20008A2")]
	[AddComponentMenu("Sons/Weapon/BoneWeaponController")]
	public class BoneWeaponController : GenericMeleeWeaponController
	{
		// Token: 0x06003EF8 RID: 16120 RVA: 0x00013248 File Offset: 0x00011448
		[Token(Token = "0x6003EF8")]
		[Address(RVA = "0x35DC9A0", Offset = "0x35DAFA0", VA = "0x1835DC9A0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06003EF9 RID: 16121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EF9")]
		[Address(RVA = "0x35DCB00", Offset = "0x35DB100", VA = "0x1835DCB00")]
		public BoneWeaponController()
		{
		}
	}
}
