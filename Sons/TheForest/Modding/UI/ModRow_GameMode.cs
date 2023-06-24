using System;
using Il2CppDummyDll;
using TheForest.Modding.Interfaces;
using UnityEngine;

namespace TheForest.Modding.UI
{
	// Token: 0x02000492 RID: 1170
	[Token(Token = "0x2000492")]
	public class ModRow_GameMode : ModRow
	{
		// Token: 0x06001E44 RID: 7748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E44")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ModRow_GameMode()
		{
		}

		// Token: 0x04001C64 RID: 7268
		[Token(Token = "0x4001C64")]
		[FieldOffset(Offset = "0x30")]
		public GameObject _launchSpButton;

		// Token: 0x04001C65 RID: 7269
		[Token(Token = "0x4001C65")]
		[FieldOffset(Offset = "0x38")]
		public GameObject _launchMpButton;

		// Token: 0x04001C66 RID: 7270
		[Token(Token = "0x4001C66")]
		[FieldOffset(Offset = "0x40")]
		private IGameModeLauncher _launcher;
	}
}
