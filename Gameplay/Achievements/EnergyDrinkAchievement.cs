using System;
using Il2CppDummyDll;

namespace Sons.Gameplay.Achievements
{
	// Token: 0x02000733 RID: 1843
	[Token(Token = "0x2000733")]
	public class EnergyDrinkAchievement : Achievement
	{
		// Token: 0x0600301D RID: 12317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600301D")]
		[Address(RVA = "0x2E29F70", Offset = "0x2E28F70", VA = "0x182E29F70", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x0600301E RID: 12318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600301E")]
		[Address(RVA = "0x2E2A050", Offset = "0x2E29050", VA = "0x182E2A050")]
		private void OnItemConsumed(object eventparameter)
		{
		}

		// Token: 0x0600301F RID: 12319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600301F")]
		[Address(RVA = "0x2E2A0F0", Offset = "0x2E290F0", VA = "0x182E2A0F0", Slot = "5")]
		protected override void TickStat(string statName)
		{
		}

		// Token: 0x06003020 RID: 12320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003020")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public EnergyDrinkAchievement()
		{
		}
	}
}
