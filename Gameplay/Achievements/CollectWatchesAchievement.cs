using System;
using Il2CppDummyDll;

namespace Sons.Gameplay.Achievements
{
	// Token: 0x0200072D RID: 1837
	[Token(Token = "0x200072D")]
	public class CollectWatchesAchievement : Achievement
	{
		// Token: 0x06003000 RID: 12288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003000")]
		[Address(RVA = "0x2E23830", Offset = "0x2E22830", VA = "0x182E23830", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x06003001 RID: 12289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003001")]
		[Address(RVA = "0x2E23910", Offset = "0x2E22910", VA = "0x182E23910")]
		private void OnItemPickedUp(object eventparameter)
		{
		}

		// Token: 0x06003002 RID: 12290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003002")]
		[Address(RVA = "0x2E23A00", Offset = "0x2E22A00", VA = "0x182E23A00", Slot = "5")]
		protected override void TickStat(string statName)
		{
		}

		// Token: 0x06003003 RID: 12291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003003")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public CollectWatchesAchievement()
		{
		}
	}
}
