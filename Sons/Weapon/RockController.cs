using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x020008D3 RID: 2259
	[Token(Token = "0x20008D3")]
	[AddComponentMenu("Sons/Weapon/RockController")]
	public class RockController : GenericMeleeWeaponController
	{
		// Token: 0x0600409E RID: 16542 RVA: 0x00013BF0 File Offset: 0x00011DF0
		[Token(Token = "0x600409E")]
		[Address(RVA = "0x3600B90", Offset = "0x35FF190", VA = "0x183600B90", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x0600409F RID: 16543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600409F")]
		[Address(RVA = "0x35DCB00", Offset = "0x35DB100", VA = "0x1835DCB00")]
		public RockController()
		{
		}
	}
}
