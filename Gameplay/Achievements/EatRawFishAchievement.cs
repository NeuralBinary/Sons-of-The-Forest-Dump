using System;
using Il2CppDummyDll;

namespace Sons.Gameplay.Achievements
{
	// Token: 0x02000732 RID: 1842
	[Token(Token = "0x2000732")]
	public class EatRawFishAchievement : Achievement
	{
		// Token: 0x06003019 RID: 12313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003019")]
		[Address(RVA = "0x2E29B30", Offset = "0x2E28B30", VA = "0x182E29B30", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x0600301A RID: 12314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600301A")]
		[Address(RVA = "0x2E29C10", Offset = "0x2E28C10", VA = "0x182E29C10")]
		private void OnItemConsumed(object eventParameter)
		{
		}

		// Token: 0x0600301B RID: 12315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600301B")]
		[Address(RVA = "0x2E29DE0", Offset = "0x2E28DE0", VA = "0x182E29DE0", Slot = "5")]
		protected override void TickStat(string statName)
		{
		}

		// Token: 0x0600301C RID: 12316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600301C")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public EatRawFishAchievement()
		{
		}
	}
}
