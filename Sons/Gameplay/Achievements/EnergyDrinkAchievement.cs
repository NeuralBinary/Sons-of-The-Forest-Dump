using System;
using Il2CppDummyDll;

namespace Sons.Gameplay.Achievements
{
	// Token: 0x0200088F RID: 2191
	[Token(Token = "0x200088F")]
	public class EnergyDrinkAchievement : Achievement
	{
		// Token: 0x06003E8D RID: 16013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E8D")]
		[Address(RVA = "0x35D3720", Offset = "0x35D1D20", VA = "0x1835D3720", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x06003E8E RID: 16014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E8E")]
		[Address(RVA = "0x35D3800", Offset = "0x35D1E00", VA = "0x1835D3800")]
		private void OnItemConsumed(object eventparameter)
		{
		}

		// Token: 0x06003E8F RID: 16015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E8F")]
		[Address(RVA = "0x35D38A0", Offset = "0x35D1EA0", VA = "0x1835D38A0", Slot = "5")]
		protected override void TickStat(string statName)
		{
		}

		// Token: 0x06003E90 RID: 16016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E90")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public EnergyDrinkAchievement()
		{
		}
	}
}
