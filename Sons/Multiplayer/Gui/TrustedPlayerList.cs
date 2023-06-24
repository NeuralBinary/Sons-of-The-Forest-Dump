using System;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Multiplayer.Gui
{
	// Token: 0x02000571 RID: 1393
	[Token(Token = "0x2000571")]
	[AddComponentMenu("Sons/Multiplayer/Gui/TrustedPlayerList")]
	public class TrustedPlayerList : PlayerListBase
	{
		// Token: 0x060024E0 RID: 9440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60024E0")]
		[Address(RVA = "0x33912A0", Offset = "0x338F8A0", VA = "0x1833912A0", Slot = "5")]
		protected override Task RefreshList()
		{
			return null;
		}

		// Token: 0x060024E1 RID: 9441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024E1")]
		[Address(RVA = "0x33913B0", Offset = "0x338F9B0", VA = "0x1833913B0", Slot = "6")]
		protected override void GetButtonVisibility(bool requesterIsAdmin, bool requesterIsOwner, bool requesterIsHost, bool isBanned, bool isGuest, bool isTrusted, bool isAdmin, bool isOwner, bool isHost, out bool showKickButton, out bool showBanButton, out bool enableRoles)
		{
		}

		// Token: 0x060024E2 RID: 9442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024E2")]
		[Address(RVA = "0x33913F0", Offset = "0x338F9F0", VA = "0x1833913F0")]
		public TrustedPlayerList()
		{
		}
	}
}
