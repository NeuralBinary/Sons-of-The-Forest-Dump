using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Multiplayer.Gui
{
	// Token: 0x02000560 RID: 1376
	[Token(Token = "0x2000560")]
	[AddComponentMenu("Sons/Multiplayer/Gui/BannedPlayerList")]
	public class BannedPlayerList : PlayerListBase
	{
		// Token: 0x06002470 RID: 9328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002470")]
		[Address(RVA = "0x3387500", Offset = "0x3385B00", VA = "0x183387500", Slot = "6")]
		protected override void GetButtonVisibility(bool requesterIsAdmin, bool requesterIsOwner, bool requesterIsHost, bool isBanned, bool isGuest, bool isTrusted, bool isAdmin, bool isOwner, bool isHost, out bool showKickButton, out bool showBanButton, out bool enableRoles)
		{
		}

		// Token: 0x06002471 RID: 9329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002471")]
		[Address(RVA = "0x3387530", Offset = "0x3385B30", VA = "0x183387530", Slot = "5")]
		protected override Task RefreshList()
		{
			return null;
		}

		// Token: 0x06002472 RID: 9330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002472")]
		[Address(RVA = "0x33876A0", Offset = "0x3385CA0", VA = "0x1833876A0")]
		private void RefreshFromPlayerRolesSource()
		{
		}

		// Token: 0x06002473 RID: 9331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002473")]
		[Address(RVA = "0x33877B0", Offset = "0x3385DB0", VA = "0x1833877B0", Slot = "8")]
		protected override void BanPlayerButtonPressed(ulong steamId)
		{
		}

		// Token: 0x06002474 RID: 9332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002474")]
		[Address(RVA = "0x3387820", Offset = "0x3385E20", VA = "0x183387820")]
		public BannedPlayerList()
		{
		}

		// Token: 0x06002475 RID: 9333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002475")]
		[Address(RVA = "0x3387870", Offset = "0x3385E70", VA = "0x183387870")]
		[CompilerGenerated]
		private void <RefreshList>g__SetResult|2_0()
		{
		}

		// Token: 0x040020A7 RID: 8359
		[Token(Token = "0x40020A7")]
		[FieldOffset(Offset = "0x58")]
		private TaskCompletionSource<bool> _blobSyncCompletion;
	}
}
