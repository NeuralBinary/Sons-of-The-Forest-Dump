using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace TheForest.Utils
{
	// Token: 0x020003CA RID: 970
	[Token(Token = "0x20003CA")]
	[Serializable]
	public class PlayerStatConditionList
	{
		// Token: 0x06001A12 RID: 6674 RVA: 0x00007DD0 File Offset: 0x00005FD0
		[Token(Token = "0x6001A12")]
		[Address(RVA = "0x2CE9730", Offset = "0x2CE8730", VA = "0x182CE9730")]
		public bool IsValid(PlayerStats playerStats, Vitals vitals)
		{
			return default(bool);
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A13")]
		[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
		public PlayerStatConditionList()
		{
		}

		// Token: 0x0400195E RID: 6494
		[Token(Token = "0x400195E")]
		[FieldOffset(Offset = "0x10")]
		public PlayerStatConditionList.ValidationTypes _validationType;

		// Token: 0x0400195F RID: 6495
		[Token(Token = "0x400195F")]
		[FieldOffset(Offset = "0x18")]
		public List<PlayerStatCondition> _conditions;

		// Token: 0x020003CB RID: 971
		[Token(Token = "0x20003CB")]
		public enum ValidationTypes
		{
			// Token: 0x04001961 RID: 6497
			[Token(Token = "0x4001961")]
			AnyTrue,
			// Token: 0x04001962 RID: 6498
			[Token(Token = "0x4001962")]
			AllTrue
		}
	}
}
