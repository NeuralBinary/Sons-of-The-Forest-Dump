using System;
using Il2CppDummyDll;
using Sons.Multiplayer;

namespace Sons.Gui
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	public class LobbyFullDialogController : DynamicModalDialogController
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000007")]
		private CoopLobby Lobby
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x3029220", Offset = "0x3027820", VA = "0x183029220")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x30292B0", Offset = "0x30278B0", VA = "0x1830292B0", Slot = "5")]
		protected override void SetupLocalizedStringArguments()
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x3007190", Offset = "0x3005790", VA = "0x183007190")]
		public LobbyFullDialogController()
		{
		}
	}
}
