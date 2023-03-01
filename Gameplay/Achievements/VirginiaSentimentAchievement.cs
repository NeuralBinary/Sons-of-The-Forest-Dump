using System;
using Il2CppDummyDll;
using Sons.Ai.Vail;

namespace Sons.Gameplay.Achievements
{
	// Token: 0x02000740 RID: 1856
	[Token(Token = "0x2000740")]
	public class VirginiaSentimentAchievement : Achievement
	{
		// Token: 0x06003051 RID: 12369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003051")]
		[Address(RVA = "0x2E3B140", Offset = "0x2E3A140", VA = "0x182E3B140", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x06003052 RID: 12370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003052")]
		[Address(RVA = "0x2E3B190", Offset = "0x2E3A190", VA = "0x182E3B190")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003053 RID: 12371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003053")]
		[Address(RVA = "0x2E3AF00", Offset = "0x2E39F00", VA = "0x182E3AF00")]
		private void CheckSentiment()
		{
		}

		// Token: 0x06003054 RID: 12372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003054")]
		[Address(RVA = "0x2E3B1A0", Offset = "0x2E3A1A0", VA = "0x182E3B1A0", Slot = "5")]
		protected override void TickStat(string statName)
		{
		}

		// Token: 0x06003055 RID: 12373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003055")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public VirginiaSentimentAchievement()
		{
		}

		// Token: 0x04002A4D RID: 10829
		[Token(Token = "0x4002A4D")]
		[FieldOffset(Offset = "0x38")]
		private VailActor _virginia;
	}
}
