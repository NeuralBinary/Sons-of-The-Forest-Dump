using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Gameplay;
using UnityEngine;

namespace Sons.Items.Core
{
	// Token: 0x0200002D RID: 45
	[Token(Token = "0x200002D")]
	[Serializable]
	public class MeleeWeaponData
	{
		// Token: 0x060000D1 RID: 209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x30B1D30", Offset = "0x30B0330", VA = "0x1830B1D30")]
		public MeleeWeaponData()
		{
		}

		// Token: 0x040001AA RID: 426
		[Token(Token = "0x40001AA")]
		private const float labelWidth = 160f;

		// Token: 0x040001AB RID: 427
		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0x10")]
		public float Damage;

		// Token: 0x040001AC RID: 428
		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0x14")]
		public float StaminaCost;

		// Token: 0x040001AD RID: 429
		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0x18")]
		public float StrengthGainOnHit;

		// Token: 0x040001AE RID: 430
		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0x1C")]
		public float GroundSmashDamage;

		// Token: 0x040001AF RID: 431
		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x20")]
		public float GroundSmashStamina;

		// Token: 0x040001B0 RID: 432
		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x24")]
		public float ChargeAttackDamage;

		// Token: 0x040001B1 RID: 433
		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x28")]
		public float ChargeAttackStamina;

		// Token: 0x040001B2 RID: 434
		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x2C")]
		public float Weight;

		// Token: 0x040001B3 RID: 435
		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		public float KnockdownCriticalPercent;

		// Token: 0x040001B4 RID: 436
		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x34")]
		public float Dismember;

		// Token: 0x040001B5 RID: 437
		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public float DismemberCriticalPercent;

		// Token: 0x040001B6 RID: 438
		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x3C")]
		public float SwingSpeed;

		// Token: 0x040001B7 RID: 439
		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0x40")]
		public float SwingSpeedTired;

		// Token: 0x040001B8 RID: 440
		[Token(Token = "0x40001B8")]
		[FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		public float UISwingSpeed;

		// Token: 0x040001B9 RID: 441
		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		public float BlockDamagePercent;

		// Token: 0x040001BA RID: 442
		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0x50")]
		public List<StatusEffect> StatusEffects;
	}
}
