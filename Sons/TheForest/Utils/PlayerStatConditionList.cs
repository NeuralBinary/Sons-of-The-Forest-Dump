using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace TheForest.Utils
{
	// Token: 0x020003BC RID: 956
	[Token(Token = "0x20003BC")]
	[Serializable]
	public class PlayerStatConditionList
	{
		// Token: 0x06001A53 RID: 6739 RVA: 0x00008058 File Offset: 0x00006258
		[Token(Token = "0x6001A53")]
		[Address(RVA = "0x329F670", Offset = "0x329DC70", VA = "0x18329F670")]
		public bool IsValid(PlayerStats playerStats, Vitals vitals)
		{
			return default(bool);
		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A54")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public PlayerStatConditionList()
		{
		}

		// Token: 0x04001982 RID: 6530
		[Token(Token = "0x4001982")]
		[FieldOffset(Offset = "0x10")]
		public PlayerStatConditionList.ValidationTypes _validationType;

		// Token: 0x04001983 RID: 6531
		[Token(Token = "0x4001983")]
		[FieldOffset(Offset = "0x18")]
		public List<PlayerStatCondition> _conditions;

		// Token: 0x020003BD RID: 957
		[Token(Token = "0x20003BD")]
		public enum ValidationTypes
		{
			// Token: 0x04001985 RID: 6533
			[Token(Token = "0x4001985")]
			AnyTrue,
			// Token: 0x04001986 RID: 6534
			[Token(Token = "0x4001986")]
			AllTrue
		}
	}
}
