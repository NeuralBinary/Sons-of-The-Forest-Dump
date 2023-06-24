using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.StatSystem;

namespace Sons.Ai.Vail.Influences
{
	// Token: 0x02000229 RID: 553
	[Token(Token = "0x2000229")]
	[Serializable]
	public abstract class Influence : Stat
	{
		// Token: 0x06000FB1 RID: 4017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FB1")]
		[Address(RVA = "0x2BC1090", Offset = "0x2BBF690", VA = "0x182BC1090")]
		protected Influence(Influence values)
		{
		}

		// Token: 0x06000FB2 RID: 4018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FB2")]
		[Address(RVA = "0x2B8D740", Offset = "0x2B8BD40", VA = "0x182B8D740")]
		protected Influence()
		{
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000FB3")]
		[Address(RVA = "0x2BC1530", Offset = "0x2BBFB30", VA = "0x182BC1530")]
		public static List<Influence> GetDefaults()
		{
			return null;
		}
	}
}
