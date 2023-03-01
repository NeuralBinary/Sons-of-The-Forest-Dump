using System;
using Il2CppDummyDll;
using TheForest.Modding.Interfaces;
using UnityEngine;

namespace TheForest.Modding.UI
{
	// Token: 0x0200049D RID: 1181
	[Token(Token = "0x200049D")]
	public class ModRow_GameMode : ModRow
	{
		// Token: 0x06001DF4 RID: 7668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DF4")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public ModRow_GameMode()
		{
		}

		// Token: 0x04001C34 RID: 7220
		[Token(Token = "0x4001C34")]
		[FieldOffset(Offset = "0x30")]
		public GameObject _launchSpButton;

		// Token: 0x04001C35 RID: 7221
		[Token(Token = "0x4001C35")]
		[FieldOffset(Offset = "0x38")]
		public GameObject _launchMpButton;

		// Token: 0x04001C36 RID: 7222
		[Token(Token = "0x4001C36")]
		[FieldOffset(Offset = "0x40")]
		private IGameModeLauncher _launcher;
	}
}
