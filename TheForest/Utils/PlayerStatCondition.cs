using System;
using Il2CppDummyDll;

namespace TheForest.Utils
{
	// Token: 0x020003C7 RID: 967
	[Token(Token = "0x20003C7")]
	[Serializable]
	public class PlayerStatCondition
	{
		// Token: 0x06001A10 RID: 6672 RVA: 0x00007DB8 File Offset: 0x00005FB8
		[Token(Token = "0x6001A10")]
		[Address(RVA = "0x2CE9A20", Offset = "0x2CE8A20", VA = "0x182CE9A20")]
		public bool IsValid(PlayerStats playerStats, Vitals vitals)
		{
			return default(bool);
		}

		// Token: 0x06001A11 RID: 6673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A11")]
		[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
		public PlayerStatCondition()
		{
		}

		// Token: 0x0400194D RID: 6477
		[Token(Token = "0x400194D")]
		[FieldOffset(Offset = "0x10")]
		public PlayerStatCondition.Stats _stat;

		// Token: 0x0400194E RID: 6478
		[Token(Token = "0x400194E")]
		[FieldOffset(Offset = "0x14")]
		public PlayerStatCondition.Operators _op;

		// Token: 0x0400194F RID: 6479
		[Token(Token = "0x400194F")]
		[FieldOffset(Offset = "0x18")]
		public float _value;

		// Token: 0x020003C8 RID: 968
		[Token(Token = "0x20003C8")]
		public enum Operators
		{
			// Token: 0x04001951 RID: 6481
			[Token(Token = "0x4001951")]
			Superior,
			// Token: 0x04001952 RID: 6482
			[Token(Token = "0x4001952")]
			SuperiorOrEqual,
			// Token: 0x04001953 RID: 6483
			[Token(Token = "0x4001953")]
			Equal,
			// Token: 0x04001954 RID: 6484
			[Token(Token = "0x4001954")]
			Inferior,
			// Token: 0x04001955 RID: 6485
			[Token(Token = "0x4001955")]
			InferiorOrEqual,
			// Token: 0x04001956 RID: 6486
			[Token(Token = "0x4001956")]
			Different
		}

		// Token: 0x020003C9 RID: 969
		[Token(Token = "0x20003C9")]
		public enum Stats
		{
			// Token: 0x04001958 RID: 6488
			[Token(Token = "0x4001958")]
			Stamina,
			// Token: 0x04001959 RID: 6489
			[Token(Token = "0x4001959")]
			Health,
			// Token: 0x0400195A RID: 6490
			[Token(Token = "0x400195A")]
			Rest,
			// Token: 0x0400195B RID: 6491
			[Token(Token = "0x400195B")]
			Armor,
			// Token: 0x0400195C RID: 6492
			[Token(Token = "0x400195C")]
			Hunger,
			// Token: 0x0400195D RID: 6493
			[Token(Token = "0x400195D")]
			Vitality
		}
	}
}
