using System;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Multiplayer.Gui
{
	// Token: 0x0200055E RID: 1374
	[Token(Token = "0x200055E")]
	[AddComponentMenu("Sons/Multiplayer/Gui/AdminPlayerList")]
	public class AdminPlayerList : PlayerListBase
	{
		// Token: 0x0600246B RID: 9323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600246B")]
		[Address(RVA = "0x3387110", Offset = "0x3385710", VA = "0x183387110", Slot = "5")]
		protected override Task RefreshList()
		{
			return null;
		}

		// Token: 0x0600246C RID: 9324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600246C")]
		[Address(RVA = "0x3387220", Offset = "0x3385820", VA = "0x183387220", Slot = "6")]
		protected override void GetButtonVisibility(bool requesterIsAdmin, bool requesterIsOwner, bool requesterIsHost, bool isBanned, bool isGuest, bool isTrusted, bool isAdmin, bool isOwner, bool isHost, out bool showKickButton, out bool showBanButton, out bool enableRoles)
		{
		}

		// Token: 0x0600246D RID: 9325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600246D")]
		[Address(RVA = "0x3387260", Offset = "0x3385860", VA = "0x183387260")]
		public AdminPlayerList()
		{
		}
	}
}
