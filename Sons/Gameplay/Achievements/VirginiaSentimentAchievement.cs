using System;
using Il2CppDummyDll;
using Sons.Ai.Vail;

namespace Sons.Gameplay.Achievements
{
	// Token: 0x0200089C RID: 2204
	[Token(Token = "0x200089C")]
	public class VirginiaSentimentAchievement : Achievement
	{
		// Token: 0x06003EC4 RID: 16068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EC4")]
		[Address(RVA = "0x35D5900", Offset = "0x35D3F00", VA = "0x1835D5900", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x06003EC5 RID: 16069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EC5")]
		[Address(RVA = "0x35D5950", Offset = "0x35D3F50", VA = "0x1835D5950")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003EC6 RID: 16070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EC6")]
		[Address(RVA = "0x35D59A0", Offset = "0x35D3FA0", VA = "0x1835D59A0")]
		private void CheckSentiment()
		{
		}

		// Token: 0x06003EC7 RID: 16071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EC7")]
		[Address(RVA = "0x35D5CB0", Offset = "0x35D42B0", VA = "0x1835D5CB0", Slot = "5")]
		protected override void TickStat(string statName)
		{
		}

		// Token: 0x06003EC8 RID: 16072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EC8")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public VirginiaSentimentAchievement()
		{
		}

		// Token: 0x0400347B RID: 13435
		[Token(Token = "0x400347B")]
		[FieldOffset(Offset = "0x38")]
		private VailActor _virginia;
	}
}
