using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Items.Core
{
	// Token: 0x02000032 RID: 50
	[Token(Token = "0x2000032")]
	[Serializable]
	public class StatEffect
	{
		// Token: 0x060000D7 RID: 215 RVA: 0x00002898 File Offset: 0x00000A98
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x30B1FC0", Offset = "0x30B05C0", VA = "0x1830B1FC0")]
		public static bool IsNetNegativeEffect(IEnumerable<StatEffect> statEffects)
		{
			return default(bool);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x30B2140", Offset = "0x30B0740", VA = "0x1830B2140")]
		public StatEffect()
		{
		}

		// Token: 0x040001CC RID: 460
		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x10")]
		public StatEffect.Types _type;

		// Token: 0x040001CD RID: 461
		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x14")]
		public float _amount;

		// Token: 0x040001CE RID: 462
		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x18")]
		public bool _buff;

		// Token: 0x040001CF RID: 463
		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x19")]
		public bool _linkedToCookingBuff;

		// Token: 0x040001D0 RID: 464
		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x1C")]
		public int _cookingBuffTier;

		// Token: 0x02000033 RID: 51
		[Token(Token = "0x2000033")]
		public enum Types
		{
			// Token: 0x040001D2 RID: 466
			[Token(Token = "0x40001D2")]
			Stamina,
			// Token: 0x040001D3 RID: 467
			[Token(Token = "0x40001D3")]
			Health,
			// Token: 0x040001D4 RID: 468
			[Token(Token = "0x40001D4")]
			Rest,
			// Token: 0x040001D5 RID: 469
			[Token(Token = "0x40001D5")]
			WalkSpeed,
			// Token: 0x040001D6 RID: 470
			[Token(Token = "0x40001D6")]
			RunSpeed,
			// Token: 0x040001D7 RID: 471
			[Token(Token = "0x40001D7")]
			SwimSpeed,
			// Token: 0x040001D8 RID: 472
			[Token(Token = "0x40001D8")]
			UNUSED6,
			// Token: 0x040001D9 RID: 473
			[Token(Token = "0x40001D9")]
			Ate,
			// Token: 0x040001DA RID: 474
			[Token(Token = "0x40001DA")]
			ColdAmt,
			// Token: 0x040001DB RID: 475
			[Token(Token = "0x40001DB")]
			Fullness,
			// Token: 0x040001DC RID: 476
			[Token(Token = "0x40001DC")]
			Tired,
			// Token: 0x040001DD RID: 477
			[Token(Token = "0x40001DD")]
			EnergyEx,
			// Token: 0x040001DE RID: 478
			[Token(Token = "0x40001DE")]
			UNUSED12,
			// Token: 0x040001DF RID: 479
			[Token(Token = "0x40001DF")]
			UNUSED13,
			// Token: 0x040001E0 RID: 480
			[Token(Token = "0x40001E0")]
			EnergyTemp,
			// Token: 0x040001E1 RID: 481
			[Token(Token = "0x40001E1")]
			UNUSED15,
			// Token: 0x040001E2 RID: 482
			[Token(Token = "0x40001E2")]
			Method_HitFood,
			// Token: 0x040001E3 RID: 483
			[Token(Token = "0x40001E3")]
			UNUSED17,
			// Token: 0x040001E4 RID: 484
			[Token(Token = "0x40001E4")]
			UNUSED18,
			// Token: 0x040001E5 RID: 485
			[Token(Token = "0x40001E5")]
			UNUSED19,
			// Token: 0x040001E6 RID: 486
			[Token(Token = "0x40001E6")]
			Stealth,
			// Token: 0x040001E7 RID: 487
			[Token(Token = "0x40001E7")]
			Hydration,
			// Token: 0x040001E8 RID: 488
			[Token(Token = "0x40001E8")]
			UNIUSED22,
			// Token: 0x040001E9 RID: 489
			[Token(Token = "0x40001E9")]
			UNUSED23,
			// Token: 0x040001EA RID: 490
			[Token(Token = "0x40001EA")]
			Flammable,
			// Token: 0x040001EB RID: 491
			[Token(Token = "0x40001EB")]
			TreeChopBoostModifier,
			// Token: 0x040001EC RID: 492
			[Token(Token = "0x40001EC")]
			StrengthBoostModifier,
			// Token: 0x040001ED RID: 493
			[Token(Token = "0x40001ED")]
			ComfortRating,
			// Token: 0x040001EE RID: 494
			[Token(Token = "0x40001EE")]
			WaterResistRating,
			// Token: 0x040001EF RID: 495
			[Token(Token = "0x40001EF")]
			ThermalRating,
			// Token: 0x040001F0 RID: 496
			[Token(Token = "0x40001F0")]
			SoundRangeDampFactor
		}
	}
}
