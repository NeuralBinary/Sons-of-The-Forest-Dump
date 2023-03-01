using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay.Achievements
{
	// Token: 0x02000739 RID: 1849
	[Token(Token = "0x2000739")]
	public class LogsPlacedAchievement : Achievement
	{
		// Token: 0x06003035 RID: 12341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003035")]
		[Address(RVA = "0x2E355A0", Offset = "0x2E345A0", VA = "0x182E355A0", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x06003036 RID: 12342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003036")]
		[Address(RVA = "0x2E35680", Offset = "0x2E34680", VA = "0x182E35680", Slot = "5")]
		protected override void TickStat(string statName)
		{
		}

		// Token: 0x06003037 RID: 12343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003037")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public LogsPlacedAchievement()
		{
		}

		// Token: 0x04002A4A RID: 10826
		[Token(Token = "0x4002A4A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int _logCount;
	}
}
