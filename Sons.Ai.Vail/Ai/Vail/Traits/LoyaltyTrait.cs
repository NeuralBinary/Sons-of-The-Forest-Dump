using System;
using Il2CppDummyDll;

namespace Sons.Ai.Vail.Traits
{
	// Token: 0x02000114 RID: 276
	[Token(Token = "0x2000114")]
	[Serializable]
	public class LoyaltyTrait : Trait
	{
		// Token: 0x06000A66 RID: 2662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A66")]
		[Address(RVA = "0x2B8D740", Offset = "0x2B8BD40", VA = "0x182B8D740")]
		internal LoyaltyTrait()
		{
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A67")]
		[Address(RVA = "0x2B8D950", Offset = "0x2B8BF50", VA = "0x182B8D950", Slot = "8")]
		public override void OnValidate()
		{
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000A68")]
		[Address(RVA = "0x2B8DDA0", Offset = "0x2B8C3A0", VA = "0x182B8DDA0", Slot = "6")]
		public override string GetToolTip()
		{
			return null;
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000A69")]
		[Address(RVA = "0x2B8DDD0", Offset = "0x2B8C3D0", VA = "0x182B8DDD0", Slot = "7")]
		public override string GetId()
		{
			return null;
		}
	}
}
