using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Sons.UI;
using Steamworks;
using UnityEngine;

namespace Sons.Multiplayer.Gui
{
	// Token: 0x02000562 RID: 1378
	[Token(Token = "0x2000562")]
	public abstract class PlayerListBase : MonoBehaviour
	{
		// Token: 0x06002478 RID: 9336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002478")]
		[Address(RVA = "0x3388040", Offset = "0x3386640", VA = "0x183388040", Slot = "4")]
		public virtual Task Refresh()
		{
			return null;
		}

		// Token: 0x06002479 RID: 9337 RVA: 0x0000AAA0 File Offset: 0x00008CA0
		[Token(Token = "0x6002479")]
		[Address(RVA = "0x33881B0", Offset = "0x33867B0", VA = "0x1833881B0")]
		private bool TryGetCurrentNavigationPosition(out int row, out int column)
		{
			return default(bool);
		}

		// Token: 0x0600247A RID: 9338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600247A")]
		[Address(RVA = "0x33882E0", Offset = "0x33868E0", VA = "0x1833882E0")]
		private Task SetupNavigationDelayed(int restoreRow, int restoreColumn)
		{
			return null;
		}

		// Token: 0x0600247B RID: 9339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600247B")]
		[Address(RVA = "0x3388470", Offset = "0x3386A70", VA = "0x183388470")]
		private void EnableAdminFeatures()
		{
		}

		// Token: 0x0600247C RID: 9340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600247C")]
		[Address(RVA = "0x3388480", Offset = "0x3386A80", VA = "0x183388480")]
		private void DisableAdminFeatures()
		{
		}

		// Token: 0x0600247D RID: 9341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600247D")]
		[Address(RVA = "0x3388490", Offset = "0x3386A90", VA = "0x183388490")]
		private void SetAdminFeatures(bool value)
		{
		}

		// Token: 0x0600247E RID: 9342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600247E")]
		[Address(RVA = "0x3388720", Offset = "0x3386D20", VA = "0x183388720", Slot = "5")]
		protected virtual Task RefreshList()
		{
			return null;
		}

		// Token: 0x0600247F RID: 9343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600247F")]
		[Address(RVA = "0x3388830", Offset = "0x3386E30", VA = "0x183388830")]
		public void ClearPlayerList()
		{
		}

		// Token: 0x06002480 RID: 9344
		[Token(Token = "0x6002480")]
		protected abstract void GetButtonVisibility(bool requesterIsAdmin, bool requesterIsOwner, bool requesterIsHost, bool isBanned, bool isGuest, bool isTrusted, bool isAdmin, bool isOwner, bool isHost, out bool showKickButton, out bool showBanButton, out bool enableRoles);

		// Token: 0x06002481 RID: 9345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002481")]
		[Address(RVA = "0x3388B40", Offset = "0x3387140", VA = "0x183388B40")]
		protected void AddPlayerListElement(string playerName, ulong steamId, bool showProfileButton, bool requesterIsAdmin, bool requesterIsOwner, bool requesterIsHost, [Optional] PlayerRoles? role)
		{
		}

		// Token: 0x06002482 RID: 9346 RVA: 0x0000AAB8 File Offset: 0x00008CB8
		[Token(Token = "0x6002482")]
		[Address(RVA = "0x33892A0", Offset = "0x33878A0", VA = "0x1833892A0")]
		private bool IsBanned(ulong steamId)
		{
			return default(bool);
		}

		// Token: 0x06002483 RID: 9347 RVA: 0x0000AAD0 File Offset: 0x00008CD0
		[Token(Token = "0x6002483")]
		[Address(RVA = "0x33893D0", Offset = "0x33879D0", VA = "0x1833893D0")]
		private bool IsAdmin(ulong steamId)
		{
			return default(bool);
		}

		// Token: 0x06002484 RID: 9348 RVA: 0x0000AAE8 File Offset: 0x00008CE8
		[Token(Token = "0x6002484")]
		[Address(RVA = "0x3389500", Offset = "0x3387B00", VA = "0x183389500")]
		private bool IsOwner(ulong steamId)
		{
			return default(bool);
		}

		// Token: 0x06002485 RID: 9349 RVA: 0x0000AB00 File Offset: 0x00008D00
		[Token(Token = "0x6002485")]
		[Address(RVA = "0x3389630", Offset = "0x3387C30", VA = "0x183389630")]
		private bool IsTrusted(ulong steamId)
		{
			return default(bool);
		}

		// Token: 0x06002486 RID: 9350 RVA: 0x0000AB18 File Offset: 0x00008D18
		[Token(Token = "0x6002486")]
		[Address(RVA = "0x3389770", Offset = "0x3387D70", VA = "0x183389770")]
		private bool IsGuest(ulong steamId)
		{
			return default(bool);
		}

		// Token: 0x06002487 RID: 9351 RVA: 0x0000AB30 File Offset: 0x00008D30
		[Token(Token = "0x6002487")]
		[Address(RVA = "0x33898A0", Offset = "0x3387EA0", VA = "0x1833898A0")]
		internal bool IsRequesterHost()
		{
			return default(bool);
		}

		// Token: 0x06002488 RID: 9352 RVA: 0x0000AB48 File Offset: 0x00008D48
		[Token(Token = "0x6002488")]
		[Address(RVA = "0x3389970", Offset = "0x3387F70", VA = "0x183389970")]
		internal bool IsRequesterAdmin()
		{
			return default(bool);
		}

		// Token: 0x06002489 RID: 9353 RVA: 0x0000AB60 File Offset: 0x00008D60
		[Token(Token = "0x6002489")]
		[Address(RVA = "0x3389A50", Offset = "0x3388050", VA = "0x183389A50")]
		internal bool IsRequesterOwner()
		{
			return default(bool);
		}

		// Token: 0x0600248A RID: 9354 RVA: 0x0000AB78 File Offset: 0x00008D78
		[Token(Token = "0x600248A")]
		[Address(RVA = "0x3389B30", Offset = "0x3388130", VA = "0x183389B30")]
		internal bool IsHost(ulong steamId)
		{
			return default(bool);
		}

		// Token: 0x0600248B RID: 9355 RVA: 0x0000AB90 File Offset: 0x00008D90
		[Token(Token = "0x600248B")]
		[Address(RVA = "0x3389C40", Offset = "0x3388240", VA = "0x183389C40")]
		internal bool VerifyActiveOwnerSteamId()
		{
			return default(bool);
		}

		// Token: 0x0600248C RID: 9356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600248C")]
		[Address(RVA = "0x3389CF0", Offset = "0x33882F0", VA = "0x183389CF0")]
		public PlayerListElementView CreatePlayerListElement(string dummy, string playerName, ulong steamId, bool adminControl, bool showProfileButton, bool showKickButton, bool showBanButton, bool showRoles, bool enableRoles, string playerRole)
		{
			return null;
		}

		// Token: 0x0600248D RID: 9357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600248D")]
		[Address(RVA = "0x338A530", Offset = "0x3388B30", VA = "0x18338A530")]
		private static PlayerListElementView CreateNewPlayerListElementView(GameObject playerListElementPrefab)
		{
			return null;
		}

		// Token: 0x0600248E RID: 9358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600248E")]
		[Address(RVA = "0x338A7A0", Offset = "0x3388DA0", VA = "0x18338A7A0", Slot = "7")]
		protected virtual void ProfileButtonPressed(ulong steamid)
		{
		}

		// Token: 0x0600248F RID: 9359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600248F")]
		[Address(RVA = "0x338A870", Offset = "0x3388E70", VA = "0x18338A870")]
		private void KickPlayerButtonPressed(ulong steamId)
		{
		}

		// Token: 0x06002490 RID: 9360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002490")]
		[Address(RVA = "0x338A8C0", Offset = "0x3388EC0", VA = "0x18338A8C0", Slot = "8")]
		protected virtual void BanPlayerButtonPressed(ulong steamId)
		{
		}

		// Token: 0x06002491 RID: 9361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002491")]
		[Address(RVA = "0x338ABC0", Offset = "0x33891C0", VA = "0x18338ABC0")]
		private void PlayerAdminRoleSelected(ulong steamId)
		{
		}

		// Token: 0x06002492 RID: 9362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002492")]
		[Address(RVA = "0x338AC10", Offset = "0x3389210", VA = "0x18338AC10")]
		private void PlayerTrustRoleSelected(ulong steamId)
		{
		}

		// Token: 0x06002493 RID: 9363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002493")]
		[Address(RVA = "0x338AC60", Offset = "0x3389260", VA = "0x18338AC60")]
		private void PlayerGuestRoleSelected(ulong steamId)
		{
		}

		// Token: 0x06002494 RID: 9364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002494")]
		[Address(RVA = "0x338ACB0", Offset = "0x33892B0", VA = "0x18338ACB0")]
		public static void UpdateKnownPlayers()
		{
		}

		// Token: 0x06002495 RID: 9365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002495")]
		[Address(RVA = "0x338B100", Offset = "0x3389700", VA = "0x18338B100")]
		protected static string GetSteamName(ulong steamId)
		{
			return null;
		}

		// Token: 0x06002496 RID: 9366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002496")]
		[Address(RVA = "0x338B240", Offset = "0x3389840", VA = "0x18338B240")]
		protected List<PlayerData> GetFakeBannedPlayers()
		{
			return null;
		}

		// Token: 0x06002497 RID: 9367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002497")]
		[Address(RVA = "0x338B4C0", Offset = "0x3389AC0", VA = "0x18338B4C0")]
		internal void AddPlayerToList(PlayerData playerData)
		{
		}

		// Token: 0x06002498 RID: 9368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002498")]
		[Address(RVA = "0x338B560", Offset = "0x3389B60", VA = "0x18338B560")]
		private void PersonaStateChanged(PersonaStateChange_t param)
		{
		}

		// Token: 0x06002499 RID: 9369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002499")]
		[Address(RVA = "0x338B620", Offset = "0x3389C20", VA = "0x18338B620")]
		public void OnEnable()
		{
		}

		// Token: 0x0600249A RID: 9370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600249A")]
		[Address(RVA = "0x338B960", Offset = "0x3389F60", VA = "0x18338B960")]
		public void OnDisable()
		{
		}

		// Token: 0x0600249B RID: 9371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600249B")]
		[Address(RVA = "0x338BC80", Offset = "0x338A280", VA = "0x18338BC80")]
		private void OnConnectedPlayer(BoltConnection obj)
		{
		}

		// Token: 0x0600249C RID: 9372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600249C")]
		[Address(RVA = "0x338BC90", Offset = "0x338A290", VA = "0x18338BC90")]
		protected void DelayedRefresh()
		{
		}

		// Token: 0x0600249D RID: 9373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600249D")]
		[Address(RVA = "0x338BE10", Offset = "0x338A410", VA = "0x18338BE10")]
		private Task DelayedRefreshAsync()
		{
			return null;
		}

		// Token: 0x0600249E RID: 9374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600249E")]
		[Address(RVA = "0x338BF80", Offset = "0x338A580", VA = "0x18338BF80")]
		protected PlayerListBase()
		{
		}

		// Token: 0x040020AD RID: 8365
		[Token(Token = "0x40020AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _playerListElementPrefab;

		// Token: 0x040020AE RID: 8366
		[Token(Token = "0x40020AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<GameObject> _adminGroups;

		// Token: 0x040020AF RID: 8367
		[Token(Token = "0x40020AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected MultiplayerPlayerRoles _playerRolesSource;

		// Token: 0x040020B0 RID: 8368
		[Token(Token = "0x40020B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<BoltConnection, PlayerListBase.KnownPlayerData> _knownPlayers;

		// Token: 0x040020B1 RID: 8369
		[Token(Token = "0x40020B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ISteamMatchmakingPlayersResponse _dsPlayersResponse;

		// Token: 0x040020B2 RID: 8370
		[Token(Token = "0x40020B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<PlayerListElementView> _playerListElements;

		// Token: 0x040020B3 RID: 8371
		[Token(Token = "0x40020B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _refreshInProgress;

		// Token: 0x040020B4 RID: 8372
		[Token(Token = "0x40020B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private CSteamID _activeOwnerSteamIdCache;

		// Token: 0x040020B5 RID: 8373
		[Token(Token = "0x40020B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly List<string> _randomNames;

		// Token: 0x02000563 RID: 1379
		[Token(Token = "0x2000563")]
		protected class KnownPlayerData
		{
			// Token: 0x170004DB RID: 1243
			// (get) Token: 0x060024A0 RID: 9376 RVA: 0x0000ABA8 File Offset: 0x00008DA8
			// (set) Token: 0x060024A1 RID: 9377 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170004DB")]
			internal ulong SteamId
			{
				[Token(Token = "0x60024A0")]
				[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
				[CompilerGenerated]
				get
				{
					return 0UL;
				}
				[Token(Token = "0x60024A1")]
				[Address(RVA = "0x754960", Offset = "0x752F60", VA = "0x180754960")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170004DC RID: 1244
			// (get) Token: 0x060024A2 RID: 9378 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060024A3 RID: 9379 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170004DC")]
			internal BoltConnection Connection
			{
				[Token(Token = "0x60024A2")]
				[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60024A3")]
				[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170004DD RID: 1245
			// (get) Token: 0x060024A4 RID: 9380 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060024A5 RID: 9381 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170004DD")]
			internal string Name
			{
				[Token(Token = "0x60024A4")]
				[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60024A5")]
				[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170004DE RID: 1246
			// (get) Token: 0x060024A6 RID: 9382 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060024A7 RID: 9383 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170004DE")]
			internal BoltEntity BoltEntity
			{
				[Token(Token = "0x60024A6")]
				[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60024A7")]
				[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170004DF RID: 1247
			// (get) Token: 0x060024A8 RID: 9384 RVA: 0x0000ABC0 File Offset: 0x00008DC0
			// (set) Token: 0x060024A9 RID: 9385 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170004DF")]
			internal CSteamID CSteamId
			{
				[Token(Token = "0x60024A8")]
				[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
				[CompilerGenerated]
				get
				{
					return default(CSteamID);
				}
				[Token(Token = "0x60024A9")]
				[Address(RVA = "0x25A71E0", Offset = "0x25A57E0", VA = "0x1825A71E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x060024AA RID: 9386 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60024AA")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public KnownPlayerData()
			{
			}
		}
	}
}
