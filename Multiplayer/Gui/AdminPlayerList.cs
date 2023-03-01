using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Multiplayer.Gui
{
	// Token: 0x02000553 RID: 1363
	[Token(Token = "0x2000553")]
	[AddComponentMenu("Sons/Multiplayer/Gui/AdminPlayerList")]
	public class AdminPlayerList : PlayerListBase
	{
		// Token: 0x06002374 RID: 9076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002374")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "5")]
		public override void RefreshList()
		{
		}

		// Token: 0x06002375 RID: 9077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002375")]
		[Address(RVA = "0x2D5C5D0", Offset = "0x2D5B5D0", VA = "0x182D5C5D0", Slot = "6")]
		protected override void GetButtonVisibility(bool requesterIsAdmin, bool requesterIsHost, bool isHost, bool isTrusted, bool isAdmin, bool isTrustedOrAdmin, bool isBanned, out bool showKickButton, out bool showBanButton, out bool enableRoles)
		{
		}

		// Token: 0x06002376 RID: 9078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002376")]
		[Address(RVA = "0x2D5C610", Offset = "0x2D5B610", VA = "0x182D5C610")]
		public AdminPlayerList()
		{
		}
	}
}
