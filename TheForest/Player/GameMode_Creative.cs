using System;
using Bolt;
using Il2CppDummyDll;
using Sons.Interfaces;

namespace TheForest.Player
{
	// Token: 0x0200045B RID: 1115
	[Token(Token = "0x200045B")]
	public class GameMode_Creative : EntityBehaviour<IGameModeState>, IGameMode
	{
		// Token: 0x06001C4F RID: 7247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C4F")]
		[Address(RVA = "0x2CF4890", Offset = "0x2CF3890", VA = "0x182CF4890")]
		private void Awake()
		{
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C50")]
		[Address(RVA = "0x2CF4990", Offset = "0x2CF3990", VA = "0x182CF4990")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001C51 RID: 7249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C51")]
		[Address(RVA = "0x2CF4A20", Offset = "0x2CF3A20", VA = "0x182CF4A20", Slot = "24")]
		public void RestoreSettings()
		{
		}

		// Token: 0x06001C52 RID: 7250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C52")]
		[Address(RVA = "0x2CF4AB0", Offset = "0x2CF3AB0", VA = "0x182CF4AB0")]
		public GameMode_Creative()
		{
		}
	}
}
