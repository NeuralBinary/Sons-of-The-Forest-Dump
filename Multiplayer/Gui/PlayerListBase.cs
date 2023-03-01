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
	// Token: 0x02000555 RID: 1365
	[Token(Token = "0x2000555")]
	public abstract class PlayerListBase : MonoBehaviour
	{
		// Token: 0x0600237B RID: 9083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600237B")]
		[Address(RVA = "0x2D61A90", Offset = "0x2D60A90", VA = "0x182D61A90", Slot = "4")]
		public virtual void Refresh()
		{
		}

		// Token: 0x0600237C RID: 9084 RVA: 0x0000A410 File Offset: 0x00008610
		[Token(Token = "0x600237C")]
		[Address(RVA = "0x2D62090", Offset = "0x2D61090", VA = "0x182D62090")]
		private bool TryGetCurrentNavigationPosition(out int row, out int column)
		{
			return default(bool);
		}

		// Token: 0x0600237D RID: 9085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600237D")]
		[Address(RVA = "0x2D61FA0", Offset = "0x2D60FA0", VA = "0x182D61FA0")]
		private Task SetupNavigationDelayed(int restoreRow, int restoreColumn)
		{
			return null;
		}

		// Token: 0x0600237E RID: 9086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600237E")]
		[Address(RVA = "0x2D60B60", Offset = "0x2D5FB60", VA = "0x182D60B60")]
		private void EnableAdminFeatures()
		{
		}

		// Token: 0x0600237F RID: 9087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600237F")]
		[Address(RVA = "0x2D60B50", Offset = "0x2D5FB50", VA = "0x182D60B50")]
		private void DisableAdminFeatures()
		{
		}

		// Token: 0x06002380 RID: 9088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002380")]
		[Address(RVA = "0x2D61DF0", Offset = "0x2D60DF0", VA = "0x182D61DF0")]
		private void SetAdminFeatures(bool value)
		{
		}

		// Token: 0x06002381 RID: 9089
		[Token(Token = "0x6002381")]
		public abstract void RefreshList();

		// Token: 0x06002382 RID: 9090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002382")]
		[Address(RVA = "0x2D60060", Offset = "0x2D5F060", VA = "0x182D60060")]
		public void ClearPlayerList()
		{
		}

		// Token: 0x06002383 RID: 9091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002383")]
		[Address(RVA = "0x2D613B0", Offset = "0x2D603B0", VA = "0x182D613B0")]
		public void KickBySteamId(ulong steamId)
		{
		}

		// Token: 0x06002384 RID: 9092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002384")]
		[Address(RVA = "0x2D61180", Offset = "0x2D60180", VA = "0x182D61180")]
		public void KickByConnectionId(int connectionId)
		{
		}

		// Token: 0x06002385 RID: 9093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002385")]
		[Address(RVA = "0x2D61230", Offset = "0x2D60230", VA = "0x182D61230")]
		public void KickByName(string name)
		{
		}

		// Token: 0x06002386 RID: 9094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002386")]
		[Address(RVA = "0x2D5FAE0", Offset = "0x2D5EAE0", VA = "0x182D5FAE0")]
		public void BanByConnectionId(int connectionId)
		{
		}

		// Token: 0x06002387 RID: 9095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002387")]
		[Address(RVA = "0x2D5FF10", Offset = "0x2D5EF10", VA = "0x182D5FF10")]
		public void Ban(ulong steamid)
		{
		}

		// Token: 0x06002388 RID: 9096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002388")]
		[Address(RVA = "0x2D5FB90", Offset = "0x2D5EB90", VA = "0x182D5FB90")]
		public void BanByName(string name)
		{
		}

		// Token: 0x06002389 RID: 9097
		[Token(Token = "0x6002389")]
		protected abstract void GetButtonVisibility(bool requesterIsAdmin, bool requesterIsHost, bool isHost, bool isTrusted, bool isAdmin, bool isTrustedOrAdmin, bool isBanned, out bool showKickButton, out bool showBanButton, out bool enableRoles);

		// Token: 0x0600238A RID: 9098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600238A")]
		[Address(RVA = "0x2D5F600", Offset = "0x2D5E600", VA = "0x182D5F600")]
		protected void AddPlayerListElement(string playerName, int connectionId, ulong steamId, bool showProfileButton, bool requesterIsAdmin, bool requesterIsHost, [Optional] PlayerRoles? role)
		{
		}

		// Token: 0x0600238B RID: 9099 RVA: 0x0000A428 File Offset: 0x00008628
		[Token(Token = "0x600238B")]
		[Address(RVA = "0x2D60E10", Offset = "0x2D5FE10", VA = "0x182D60E10")]
		private bool IsBanned(ulong steamId)
		{
			return default(bool);
		}

		// Token: 0x0600238C RID: 9100 RVA: 0x0000A440 File Offset: 0x00008640
		[Token(Token = "0x600238C")]
		[Address(RVA = "0x2D60D70", Offset = "0x2D5FD70", VA = "0x182D60D70")]
		private bool IsAdmin(ulong steamId)
		{
			return default(bool);
		}

		// Token: 0x0600238D RID: 9101 RVA: 0x0000A458 File Offset: 0x00008658
		[Token(Token = "0x600238D")]
		[Address(RVA = "0x2D610E0", Offset = "0x2D600E0", VA = "0x182D610E0")]
		private bool IsTrusted(ulong steamId)
		{
			return default(bool);
		}

		// Token: 0x0600238E RID: 9102 RVA: 0x0000A470 File Offset: 0x00008670
		[Token(Token = "0x600238E")]
		[Address(RVA = "0x2D60EB0", Offset = "0x2D5FEB0", VA = "0x182D60EB0")]
		private bool IsGuest(ulong steamId)
		{
			return default(bool);
		}

		// Token: 0x0600238F RID: 9103 RVA: 0x0000A488 File Offset: 0x00008688
		[Token(Token = "0x600238F")]
		[Address(RVA = "0x2D610A0", Offset = "0x2D600A0", VA = "0x182D610A0")]
		internal bool IsRequesterHost()
		{
			return default(bool);
		}

		// Token: 0x06002390 RID: 9104 RVA: 0x0000A4A0 File Offset: 0x000086A0
		[Token(Token = "0x6002390")]
		[Address(RVA = "0x2D61020", Offset = "0x2D60020", VA = "0x182D61020")]
		internal bool IsRequesterAdmin()
		{
			return default(bool);
		}

		// Token: 0x06002391 RID: 9105 RVA: 0x0000A4B8 File Offset: 0x000086B8
		[Token(Token = "0x6002391")]
		[Address(RVA = "0x2D60F50", Offset = "0x2D5FF50", VA = "0x182D60F50")]
		internal bool IsHost(ulong steamId)
		{
			return default(bool);
		}

		// Token: 0x06002392 RID: 9106 RVA: 0x0000A4D0 File Offset: 0x000086D0
		[Token(Token = "0x6002392")]
		[Address(RVA = "0x2D624F0", Offset = "0x2D614F0", VA = "0x182D624F0")]
		internal bool VerifyActiveOwnerSteamId()
		{
			return default(bool);
		}

		// Token: 0x06002393 RID: 9107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002393")]
		[Address(RVA = "0x2D602F0", Offset = "0x2D5F2F0", VA = "0x182D602F0")]
		public PlayerListElementView CreatePlayerListElement(string dummy, string playerName, int connectionId, ulong steamId, bool adminControl, bool showProfileButton, bool showKickButton, bool showBanButton, bool showRoles, bool enableRoles, string playerRole)
		{
			return null;
		}

		// Token: 0x06002394 RID: 9108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002394")]
		[Address(RVA = "0x2D60190", Offset = "0x2D5F190", VA = "0x182D60190")]
		private static PlayerListElementView CreateNewPlayerListElementView(GameObject playerListElementPrefab)
		{
			return null;
		}

		// Token: 0x06002395 RID: 9109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002395")]
		[Address(RVA = "0x2D61A50", Offset = "0x2D60A50", VA = "0x182D61A50", Slot = "7")]
		protected virtual void ProfileButtonPressed(int connectionId, ulong steamid)
		{
		}

		// Token: 0x06002396 RID: 9110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002396")]
		[Address(RVA = "0x2D614D0", Offset = "0x2D604D0", VA = "0x182D614D0")]
		private void KickPlayerButtonPressed(int connectionId, ulong steamId)
		{
		}

		// Token: 0x06002397 RID: 9111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002397")]
		[Address(RVA = "0x2D61870", Offset = "0x2D60870", VA = "0x182D61870")]
		private void PlayerAdminRoleSelected(int connectionId, ulong steamId)
		{
		}

		// Token: 0x06002398 RID: 9112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002398")]
		[Address(RVA = "0x2D619B0", Offset = "0x2D609B0", VA = "0x182D619B0")]
		private void PlayerTrustRoleSelected(int connectionId, ulong steamId)
		{
		}

		// Token: 0x06002399 RID: 9113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002399")]
		[Address(RVA = "0x2D61910", Offset = "0x2D60910", VA = "0x182D61910")]
		private void PlayerGuestRoleSelected(int connectionId, ulong steamId)
		{
		}

		// Token: 0x0600239A RID: 9114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600239A")]
		[Address(RVA = "0x2D5FCF0", Offset = "0x2D5ECF0", VA = "0x182D5FCF0", Slot = "8")]
		protected virtual void BanPlayerButtonPressed(int connectionId, ulong steamId)
		{
		}

		// Token: 0x0600239B RID: 9115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600239B")]
		[Address(RVA = "0x2D621A0", Offset = "0x2D611A0", VA = "0x182D621A0")]
		public static void UpdateKnownPlayers()
		{
		}

		// Token: 0x0600239C RID: 9116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600239C")]
		[Address(RVA = "0x2D5F520", Offset = "0x2D5E520", VA = "0x182D5F520")]
		private void AddDSPlayerToList(string pchName)
		{
		}

		// Token: 0x0600239D RID: 9117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600239D")]
		[Address(RVA = "0x2D5F520", Offset = "0x2D5E520", VA = "0x182D5F520")]
		private void DsAddPlayerToList(string pchName, int nScore, float flTimePlayed)
		{
		}

		// Token: 0x0600239E RID: 9118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600239E")]
		[Address(RVA = "0x2A31380", Offset = "0x2A30380", VA = "0x182A31380")]
		private void DsPlayerListRequestFailed()
		{
		}

		// Token: 0x0600239F RID: 9119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600239F")]
		[Address(RVA = "0x2A31380", Offset = "0x2A30380", VA = "0x182A31380")]
		private void DsPlayerListRequestFinished()
		{
		}

		// Token: 0x060023A0 RID: 9120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023A0")]
		[Address(RVA = "0x2D60B70", Offset = "0x2D5FB70", VA = "0x182D60B70")]
		protected List<PlayerData> GetFakeBannedPlayers()
		{
			return null;
		}

		// Token: 0x060023A1 RID: 9121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A1")]
		[Address(RVA = "0x2D5FA30", Offset = "0x2D5EA30", VA = "0x182D5FA30")]
		internal void AddPlayerToList(PlayerData playerData)
		{
		}

		// Token: 0x060023A2 RID: 9122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A2")]
		[Address(RVA = "0x2D617F0", Offset = "0x2D607F0", VA = "0x182D617F0")]
		private void OnEnable()
		{
		}

		// Token: 0x060023A3 RID: 9123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A3")]
		[Address(RVA = "0x2D61780", Offset = "0x2D60780", VA = "0x182D61780")]
		private void OnDisable()
		{
		}

		// Token: 0x060023A4 RID: 9124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A4")]
		[Address(RVA = "0x2D616B0", Offset = "0x2D606B0", VA = "0x182D616B0")]
		private void OnConnectedPlayer(BoltConnection obj)
		{
		}

		// Token: 0x060023A5 RID: 9125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023A5")]
		[Address(RVA = "0x2D60A80", Offset = "0x2D5FA80", VA = "0x182D60A80")]
		private Task DelayedRefresh()
		{
			return null;
		}

		// Token: 0x060023A6 RID: 9126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A6")]
		[Address(RVA = "0x2D62BD0", Offset = "0x2D61BD0", VA = "0x182D62BD0")]
		protected PlayerListBase()
		{
		}

		// Token: 0x04001FE4 RID: 8164
		[Token(Token = "0x4001FE4")]
		private const string KickAdminCommandString = "kick";

		// Token: 0x04001FE5 RID: 8165
		[Token(Token = "0x4001FE5")]
		private const string KickByConnectionIdCommandString = "kickbycid";

		// Token: 0x04001FE6 RID: 8166
		[Token(Token = "0x4001FE6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _playerListElementPrefab;

		// Token: 0x04001FE7 RID: 8167
		[Token(Token = "0x4001FE7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<GameObject> _adminGroups;

		// Token: 0x04001FE8 RID: 8168
		[Token(Token = "0x4001FE8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected MultiplayerPlayerRoles _playerRolesSource;

		// Token: 0x04001FE9 RID: 8169
		[Token(Token = "0x4001FE9")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<BoltConnection, PlayerListBase.KnownPlayerData> _knownPlayers;

		// Token: 0x04001FEA RID: 8170
		[Token(Token = "0x4001FEA")]
		[FieldOffset(Offset = "0x38")]
		private ISteamMatchmakingPlayersResponse _dsPlayersResponse;

		// Token: 0x04001FEB RID: 8171
		[Token(Token = "0x4001FEB")]
		[FieldOffset(Offset = "0x40")]
		private List<PlayerListElementView> _playerListElements;

		// Token: 0x04001FEC RID: 8172
		[Token(Token = "0x4001FEC")]
		[FieldOffset(Offset = "0x48")]
		private CSteamID _activeOwnerSteamIdCache;

		// Token: 0x04001FED RID: 8173
		[Token(Token = "0x4001FED")]
		[FieldOffset(Offset = "0x8")]
		private static readonly List<string> _randomNames;

		// Token: 0x02000556 RID: 1366
		[Token(Token = "0x2000556")]
		protected class KnownPlayerData
		{
			// Token: 0x170004C7 RID: 1223
			// (get) Token: 0x060023A8 RID: 9128 RVA: 0x0000A4E8 File Offset: 0x000086E8
			// (set) Token: 0x060023A9 RID: 9129 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170004C7")]
			internal ulong SteamId
			{
				[Token(Token = "0x60023A8")]
				[Address(RVA = "0x5430A0", Offset = "0x5420A0", VA = "0x1805430A0")]
				[CompilerGenerated]
				get
				{
					return default(ulong);
				}
				[Token(Token = "0x60023A9")]
				[Address(RVA = "0x6AE190", Offset = "0x6AD190", VA = "0x1806AE190")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170004C8 RID: 1224
			// (get) Token: 0x060023AA RID: 9130 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060023AB RID: 9131 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170004C8")]
			internal BoltConnection Connection
			{
				[Token(Token = "0x60023AA")]
				[Address(RVA = "0x57B1D0", Offset = "0x57A1D0", VA = "0x18057B1D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60023AB")]
				[Address(RVA = "0x5A85C0", Offset = "0x5A75C0", VA = "0x1805A85C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170004C9 RID: 1225
			// (get) Token: 0x060023AC RID: 9132 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060023AD RID: 9133 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170004C9")]
			internal string Name
			{
				[Token(Token = "0x60023AC")]
				[Address(RVA = "0x541200", Offset = "0x540200", VA = "0x180541200")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60023AD")]
				[Address(RVA = "0x541240", Offset = "0x540240", VA = "0x180541240")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170004CA RID: 1226
			// (get) Token: 0x060023AE RID: 9134 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060023AF RID: 9135 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170004CA")]
			internal BoltEntity BoltEntity
			{
				[Token(Token = "0x60023AE")]
				[Address(RVA = "0x541230", Offset = "0x540230", VA = "0x180541230")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60023AF")]
				[Address(RVA = "0x541270", Offset = "0x540270", VA = "0x180541270")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170004CB RID: 1227
			// (get) Token: 0x060023B0 RID: 9136 RVA: 0x0000A500 File Offset: 0x00008700
			// (set) Token: 0x060023B1 RID: 9137 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170004CB")]
			internal CSteamID CSteamId
			{
				[Token(Token = "0x60023B0")]
				[Address(RVA = "0x541210", Offset = "0x540210", VA = "0x180541210")]
				[CompilerGenerated]
				get
				{
					return default(CSteamID);
				}
				[Token(Token = "0x60023B1")]
				[Address(RVA = "0x219E160", Offset = "0x219D160", VA = "0x18219E160")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x060023B2 RID: 9138 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60023B2")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public KnownPlayerData()
			{
			}
		}
	}
}
