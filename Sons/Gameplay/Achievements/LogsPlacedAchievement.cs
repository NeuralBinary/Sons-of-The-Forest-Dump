using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay.Achievements
{
	// Token: 0x02000895 RID: 2197
	[Token(Token = "0x2000895")]
	public class LogsPlacedAchievement : Achievement
	{
		// Token: 0x06003EA5 RID: 16037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EA5")]
		[Address(RVA = "0x35D4240", Offset = "0x35D2840", VA = "0x1835D4240", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x06003EA6 RID: 16038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EA6")]
		[Address(RVA = "0x35D4320", Offset = "0x35D2920", VA = "0x1835D4320", Slot = "5")]
		protected override void TickStat(string statName)
		{
		}

		// Token: 0x06003EA7 RID: 16039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EA7")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public LogsPlacedAchievement()
		{
		}

		// Token: 0x04003478 RID: 13432
		[Token(Token = "0x4003478")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int _logCount;
	}
}
