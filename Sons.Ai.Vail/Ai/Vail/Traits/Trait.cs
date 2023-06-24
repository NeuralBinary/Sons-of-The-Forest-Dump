using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.StatSystem;

namespace Sons.Ai.Vail.Traits
{
	// Token: 0x0200011B RID: 283
	[Token(Token = "0x200011B")]
	[Serializable]
	public abstract class Trait : Stat
	{
		// Token: 0x06000A82 RID: 2690 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000A82")]
		[Address(RVA = "0x2B8E0E0", Offset = "0x2B8C6E0", VA = "0x182B8E0E0", Slot = "10")]
		public override string InspectorReadout()
		{
			return null;
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A83")]
		[Address(RVA = "0x2B8E150", Offset = "0x2B8C750", VA = "0x182B8E150", Slot = "8")]
		public override void OnValidate()
		{
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000A84")]
		[Address(RVA = "0x2B8E160", Offset = "0x2B8C760", VA = "0x182B8E160")]
		public static List<Trait> GetDefaults()
		{
			return null;
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A85")]
		[Address(RVA = "0x2B8D740", Offset = "0x2B8BD40", VA = "0x182B8D740")]
		protected Trait()
		{
		}
	}
}
