using System;
using Il2CppDummyDll;

namespace Sons.Gameplay.Achievements
{
	// Token: 0x0200073E RID: 1854
	[Token(Token = "0x200073E")]
	public class TechArmorAchievement : Achievement
	{
		// Token: 0x06003049 RID: 12361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003049")]
		[Address(RVA = "0x2E384A0", Offset = "0x2E374A0", VA = "0x182E384A0", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x0600304A RID: 12362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600304A")]
		[Address(RVA = "0x2E38580", Offset = "0x2E37580", VA = "0x182E38580")]
		private void OnArmorEquipped(object _)
		{
		}

		// Token: 0x0600304B RID: 12363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600304B")]
		[Address(RVA = "0x2E38600", Offset = "0x2E37600", VA = "0x182E38600", Slot = "5")]
		protected override void TickStat(string statName)
		{
		}

		// Token: 0x0600304C RID: 12364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600304C")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public TechArmorAchievement()
		{
		}
	}
}
