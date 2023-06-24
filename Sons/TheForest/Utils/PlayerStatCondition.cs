using System;
using Il2CppDummyDll;

namespace TheForest.Utils
{
	// Token: 0x020003B9 RID: 953
	[Token(Token = "0x20003B9")]
	[Serializable]
	public class PlayerStatCondition
	{
		// Token: 0x06001A51 RID: 6737 RVA: 0x00008040 File Offset: 0x00006240
		[Token(Token = "0x6001A51")]
		[Address(RVA = "0x329F4E0", Offset = "0x329DAE0", VA = "0x18329F4E0")]
		public bool IsValid(PlayerStats playerStats, Vitals vitals)
		{
			return default(bool);
		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A52")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public PlayerStatCondition()
		{
		}

		// Token: 0x04001971 RID: 6513
		[Token(Token = "0x4001971")]
		[FieldOffset(Offset = "0x10")]
		public PlayerStatCondition.Stats _stat;

		// Token: 0x04001972 RID: 6514
		[Token(Token = "0x4001972")]
		[FieldOffset(Offset = "0x14")]
		public PlayerStatCondition.Operators _op;

		// Token: 0x04001973 RID: 6515
		[Token(Token = "0x4001973")]
		[FieldOffset(Offset = "0x18")]
		public float _value;

		// Token: 0x020003BA RID: 954
		[Token(Token = "0x20003BA")]
		public enum Operators
		{
			// Token: 0x04001975 RID: 6517
			[Token(Token = "0x4001975")]
			Superior,
			// Token: 0x04001976 RID: 6518
			[Token(Token = "0x4001976")]
			SuperiorOrEqual,
			// Token: 0x04001977 RID: 6519
			[Token(Token = "0x4001977")]
			Equal,
			// Token: 0x04001978 RID: 6520
			[Token(Token = "0x4001978")]
			Inferior,
			// Token: 0x04001979 RID: 6521
			[Token(Token = "0x4001979")]
			InferiorOrEqual,
			// Token: 0x0400197A RID: 6522
			[Token(Token = "0x400197A")]
			Different
		}

		// Token: 0x020003BB RID: 955
		[Token(Token = "0x20003BB")]
		public enum Stats
		{
			// Token: 0x0400197C RID: 6524
			[Token(Token = "0x400197C")]
			Stamina,
			// Token: 0x0400197D RID: 6525
			[Token(Token = "0x400197D")]
			Health,
			// Token: 0x0400197E RID: 6526
			[Token(Token = "0x400197E")]
			Rest,
			// Token: 0x0400197F RID: 6527
			[Token(Token = "0x400197F")]
			Armor,
			// Token: 0x04001980 RID: 6528
			[Token(Token = "0x4001980")]
			Hunger,
			// Token: 0x04001981 RID: 6529
			[Token(Token = "0x4001981")]
			Vitality
		}
	}
}
