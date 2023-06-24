using System;
using Bolt;
using Il2CppDummyDll;
using Sons.Interfaces;

namespace TheForest.Player
{
	// Token: 0x0200044D RID: 1101
	[Token(Token = "0x200044D")]
	public class GameMode_Creative : EntityBehaviour<IGameModeState>, IGameMode
	{
		// Token: 0x06001C8D RID: 7309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C8D")]
		[Address(RVA = "0x32C4640", Offset = "0x32C2C40", VA = "0x1832C4640")]
		private void Awake()
		{
		}

		// Token: 0x06001C8E RID: 7310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C8E")]
		[Address(RVA = "0x32C4770", Offset = "0x32C2D70", VA = "0x1832C4770")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001C8F RID: 7311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C8F")]
		[Address(RVA = "0x32C4890", Offset = "0x32C2E90", VA = "0x1832C4890", Slot = "24")]
		public void RestoreSettings()
		{
		}

		// Token: 0x06001C90 RID: 7312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C90")]
		[Address(RVA = "0x32C4920", Offset = "0x32C2F20", VA = "0x1832C4920")]
		public GameMode_Creative()
		{
		}
	}
}
