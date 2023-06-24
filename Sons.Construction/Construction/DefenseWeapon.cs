using System;
using Il2CppDummyDll;
using Sons.Gameplay;
using Sons.Weapon;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200025F RID: 607
	[Token(Token = "0x200025F")]
	[AddComponentMenu("Sons/Construction/DefenseWeapon")]
	public class DefenseWeapon : MeleeWeapon, IImpactSender
	{
		// Token: 0x0600128E RID: 4750 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600128E")]
		[Address(RVA = "0x2F3BEF0", Offset = "0x2F3A4F0", VA = "0x182F3BEF0", Slot = "13")]
		protected override void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600128F")]
		[Address(RVA = "0x2F3C1B0", Offset = "0x2F3A7B0", VA = "0x182F3C1B0", Slot = "5")]
		private void OnDamageSuccess(DamageNode damageNode, IImpactData impactData)
		{
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001290")]
		[Address(RVA = "0x2F3C320", Offset = "0x2F3A920", VA = "0x182F3C320")]
		public DefenseWeapon()
		{
		}
	}
}
