using System;
using Il2CppDummyDll;

namespace Sons.Gameplay.Achievements
{
	// Token: 0x0200072C RID: 1836
	[Token(Token = "0x200072C")]
	public class CollectMoneyAchievement : Achievement
	{
		// Token: 0x06002FFC RID: 12284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FFC")]
		[Address(RVA = "0x2E23570", Offset = "0x2E22570", VA = "0x182E23570", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x06002FFD RID: 12285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FFD")]
		[Address(RVA = "0x2E23650", Offset = "0x2E22650", VA = "0x182E23650")]
		private void OnItemPickedUp(object eventParameter)
		{
		}

		// Token: 0x06002FFE RID: 12286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FFE")]
		[Address(RVA = "0x2E23710", Offset = "0x2E22710", VA = "0x182E23710", Slot = "5")]
		protected override void TickStat(string statName)
		{
		}

		// Token: 0x06002FFF RID: 12287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FFF")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public CollectMoneyAchievement()
		{
		}

		// Token: 0x04002A43 RID: 10819
		[Token(Token = "0x4002A43")]
		[FieldOffset(Offset = "0x38")]
		private int _amountToAdd;
	}
}
