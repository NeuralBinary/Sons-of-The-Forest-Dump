using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Multiplayer.Gui
{
	// Token: 0x02000554 RID: 1364
	[Token(Token = "0x2000554")]
	[AddComponentMenu("Sons/Multiplayer/Gui/BannedPlayerList")]
	public class BannedPlayerList : PlayerListBase
	{
		// Token: 0x06002377 RID: 9079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002377")]
		[Address(RVA = "0x2D5C6A0", Offset = "0x2D5B6A0", VA = "0x182D5C6A0", Slot = "6")]
		protected override void GetButtonVisibility(bool requesterIsAdmin, bool requesterIsHost, bool isHost, bool isTrusted, bool isAdmin, bool isTrustedOrAdmin, bool isBanned, out bool showKickButton, out bool showBanButton, out bool enableRoles)
		{
		}

		// Token: 0x06002378 RID: 9080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002378")]
		[Address(RVA = "0x2D5C6C0", Offset = "0x2D5B6C0", VA = "0x182D5C6C0", Slot = "5")]
		public override void RefreshList()
		{
		}

		// Token: 0x06002379 RID: 9081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002379")]
		[Address(RVA = "0x2D5C660", Offset = "0x2D5B660", VA = "0x182D5C660", Slot = "8")]
		protected override void BanPlayerButtonPressed(int connectionId, ulong steamId)
		{
		}

		// Token: 0x0600237A RID: 9082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600237A")]
		[Address(RVA = "0x2D5C780", Offset = "0x2D5B780", VA = "0x182D5C780")]
		public BannedPlayerList()
		{
		}
	}
}
