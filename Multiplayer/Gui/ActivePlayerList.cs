using System;
using System.Runtime.CompilerServices;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Localization.Components;

namespace Sons.Multiplayer.Gui
{
	// Token: 0x02000550 RID: 1360
	[Token(Token = "0x2000550")]
	[AddComponentMenu("Sons/Multiplayer/Gui/ActivePlayerList")]
	public class ActivePlayerList : PlayerListBase
	{
		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x0600235B RID: 9051 RVA: 0x0000A380 File Offset: 0x00008580
		// (set) Token: 0x0600235C RID: 9052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004C5")]
		public int PlayerCount
		{
			[Token(Token = "0x600235B")]
			[Address(RVA = "0x7C8C00", Offset = "0x7C7C00", VA = "0x1807C8C00")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600235C")]
			[Address(RVA = "0x1F19C90", Offset = "0x1F18C90", VA = "0x181F19C90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x0600235D RID: 9053 RVA: 0x0000A398 File Offset: 0x00008598
		// (set) Token: 0x0600235E RID: 9054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004C6")]
		public int PlayerLimit
		{
			[Token(Token = "0x600235D")]
			[Address(RVA = "0x6B70D0", Offset = "0x6B60D0", VA = "0x1806B70D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600235E")]
			[Address(RVA = "0x23E67A0", Offset = "0x23E57A0", VA = "0x1823E67A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600235F RID: 9055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600235F")]
		[Address(RVA = "0x2D5B590", Offset = "0x2D5A590", VA = "0x182D5B590", Slot = "6")]
		protected override void GetButtonVisibility(bool requesterIsAdmin, bool requesterIsHost, bool isHost, bool isTrusted, bool isAdmin, bool isTrustedOrAdmin, bool isBanned, out bool showKickButton, out bool showBanButton, out bool enableRoles)
		{
		}

		// Token: 0x06002360 RID: 9056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002360")]
		[Address(RVA = "0x2D5C330", Offset = "0x2D5B330", VA = "0x182D5C330", Slot = "5")]
		public override void RefreshList()
		{
		}

		// Token: 0x06002361 RID: 9057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002361")]
		[Address(RVA = "0x2D5BEE0", Offset = "0x2D5AEE0", VA = "0x182D5BEE0")]
		private void RefreshFromP2PServer()
		{
		}

		// Token: 0x06002362 RID: 9058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002362")]
		[Address(RVA = "0x2D5B830", Offset = "0x2D5A830", VA = "0x182D5B830")]
		private void ProcessPlayer(ulong steamId, bool isThisClient, NetworkArray_Integer playerIds, NetworkArray_Integer playerRoles, bool isRequesterAdmin, bool isRequesterHost)
		{
		}

		// Token: 0x06002363 RID: 9059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002363")]
		[Address(RVA = "0x2D5B5E0", Offset = "0x2D5A5E0", VA = "0x182D5B5E0")]
		private static BoltConnection GetConnectionFromSteamId(ulong steamId)
		{
			return null;
		}

		// Token: 0x06002364 RID: 9060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002364")]
		[Address(RVA = "0x2D5B630", Offset = "0x2D5A630", VA = "0x182D5B630")]
		private static BoltEntity GetEntityFromSteamId(ulong steamId)
		{
			return null;
		}

		// Token: 0x06002365 RID: 9061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002365")]
		[Address(RVA = "0x2D5B820", Offset = "0x2D5A820", VA = "0x182D5B820")]
		private static string GetSteamName(ulong steamId)
		{
			return null;
		}

		// Token: 0x06002366 RID: 9062 RVA: 0x0000A3B0 File Offset: 0x000085B0
		[Token(Token = "0x6002366")]
		[Address(RVA = "0x2D5B680", Offset = "0x2D5A680", VA = "0x182D5B680")]
		private static PlayerRoles GetRole(BoltConnection connection, NetworkArray_Integer playerIds, NetworkArray_Integer playerRoles)
		{
			return default(PlayerRoles);
		}

		// Token: 0x06002367 RID: 9063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002367")]
		[Address(RVA = "0x2D5BBF0", Offset = "0x2D5ABF0", VA = "0x182D5BBF0")]
		private void RefreshFromDedicatedServer()
		{
		}

		// Token: 0x06002368 RID: 9064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002368")]
		[Address(RVA = "0x2D5C540", Offset = "0x2D5B540", VA = "0x182D5C540")]
		private void SetPlayerCountAndLimit(int playerCount, int playerLimit)
		{
		}

		// Token: 0x06002369 RID: 9065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002369")]
		[Address(RVA = "0x2D5C560", Offset = "0x2D5B560", VA = "0x182D5C560")]
		private void SetPlayerCount(int playerCount, bool refreshText = true)
		{
		}

		// Token: 0x0600236A RID: 9066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600236A")]
		[Address(RVA = "0x2D5C570", Offset = "0x2D5B570", VA = "0x182D5C570")]
		private void SetPlayerLimit(int count, bool refreshText = true)
		{
		}

		// Token: 0x0600236B RID: 9067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600236B")]
		[Address(RVA = "0x2D5C400", Offset = "0x2D5B400", VA = "0x182D5C400")]
		private void RefreshPlayerCountText()
		{
		}

		// Token: 0x0600236C RID: 9068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600236C")]
		[Address(RVA = "0x2D5C580", Offset = "0x2D5B580", VA = "0x182D5C580")]
		public ActivePlayerList()
		{
		}

		// Token: 0x04001FD7 RID: 8151
		[Token(Token = "0x4001FD7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private LocalizeStringEvent[] _playerCountText;
	}
}
