using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x020008C1 RID: 2241
	[Token(Token = "0x20008C1")]
	[AddComponentMenu("Sons/Weapon/KatanaHeldController")]
	public class KatanaHeldController : GenericMeleeWeaponController
	{
		// Token: 0x06003FFB RID: 16379 RVA: 0x000138A8 File Offset: 0x00011AA8
		[Token(Token = "0x6003FFB")]
		[Address(RVA = "0x35F1920", Offset = "0x35EFF20", VA = "0x1835F1920", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06003FFC RID: 16380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FFC")]
		[Address(RVA = "0x35DCB00", Offset = "0x35DB100", VA = "0x1835DCB00")]
		public KatanaHeldController()
		{
		}
	}
}
