using System;
using Il2CppDummyDll;

namespace Sons.Gameplay.Achievements
{
	// Token: 0x02000888 RID: 2184
	[Token(Token = "0x2000888")]
	public class CollectMoneyAchievement : Achievement
	{
		// Token: 0x06003E68 RID: 15976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E68")]
		[Address(RVA = "0x35D1B70", Offset = "0x35D0170", VA = "0x1835D1B70", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x06003E69 RID: 15977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E69")]
		[Address(RVA = "0x35D1C50", Offset = "0x35D0250", VA = "0x1835D1C50")]
		private void OnItemPickedUp(object eventParameter)
		{
		}

		// Token: 0x06003E6A RID: 15978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E6A")]
		[Address(RVA = "0x35D1D10", Offset = "0x35D0310", VA = "0x1835D1D10", Slot = "5")]
		protected override void TickStat(string statName)
		{
		}

		// Token: 0x06003E6B RID: 15979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E6B")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public CollectMoneyAchievement()
		{
		}

		// Token: 0x04003470 RID: 13424
		[Token(Token = "0x4003470")]
		[FieldOffset(Offset = "0x38")]
		private int _amountToAdd;
	}
}
