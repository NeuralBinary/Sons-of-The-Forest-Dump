using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Multiplayer.Gui
{
	// Token: 0x02000562 RID: 1378
	[Token(Token = "0x2000562")]
	[AddComponentMenu("Sons/Multiplayer/Gui/TrustedPlayerList")]
	public class TrustedPlayerList : PlayerListBase
	{
		// Token: 0x060023E4 RID: 9188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E4")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "5")]
		public override void RefreshList()
		{
		}

		// Token: 0x060023E5 RID: 9189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E5")]
		[Address(RVA = "0x2D90CA0", Offset = "0x2D8FCA0", VA = "0x182D90CA0", Slot = "6")]
		protected override void GetButtonVisibility(bool requesterIsAdmin, bool requesterIsHost, bool isHost, bool isTrusted, bool isAdmin, bool isTrustedOrAdmin, bool isBanned, out bool showKickButton, out bool showBanButton, out bool enableRoles)
		{
		}

		// Token: 0x060023E6 RID: 9190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E6")]
		[Address(RVA = "0x2D90CE0", Offset = "0x2D8FCE0", VA = "0x182D90CE0")]
		public TrustedPlayerList()
		{
		}
	}
}
