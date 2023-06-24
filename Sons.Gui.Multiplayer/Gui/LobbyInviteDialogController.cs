using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Gui.Multiplayer;
using Sons.Loading;
using Sons.Multiplayer;
using UnityEngine;

namespace Sons.Gui
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	public class LobbyInviteDialogController : DynamicModalDialogController
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000008")]
		private CoopLobby Lobby
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x3029440", Offset = "0x3027A40", VA = "0x183029440")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000020B4 File Offset: 0x000002B4
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x30294D0", Offset = "0x3027AD0", VA = "0x1830294D0", Slot = "4")]
		protected override DynamicModalDialogController.Options GetOptions()
		{
			return (DynamicModalDialogController.Options)0;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x3029570", Offset = "0x3027B70", VA = "0x183029570", Slot = "5")]
		protected override void SetupLocalizedStringArguments()
		{
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x30296C0", Offset = "0x3027CC0", VA = "0x1830296C0", Slot = "7")]
		protected override void OnOption1()
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x3029740", Offset = "0x3027D40", VA = "0x183029740", Slot = "8")]
		protected override void OnOption2()
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x30297C0", Offset = "0x3027DC0", VA = "0x1830297C0", Slot = "9")]
		protected override void OnOption3()
		{
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x3029840", Offset = "0x3027E40", VA = "0x183029840")]
		private void CheckLobbyFull(Action onSuccess)
		{
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x3029950", Offset = "0x3027F50", VA = "0x183029950")]
		private void SetAutoJoinAndLoad()
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x3007190", Offset = "0x3005790", VA = "0x183007190")]
		public LobbyInviteDialogController()
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x3029CA0", Offset = "0x30282A0", VA = "0x183029CA0")]
		[CompilerGenerated]
		private void <OnOption2>g__OnNewSaveConfirmed|7_1()
		{
		}

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Header("Lobby Invite Dialog Properties")]
		private LoadScene _loadScene;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private CoopLobbyBrowser _lobbyBrowser;
	}
}
