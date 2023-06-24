using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Sons.Gameplay.GameSetup;
using Sons.Gui.Multiplayer.Notifications;
using Sons.Multiplayer;
using Steamworks;
using UnityEngine;

namespace Sons.Gui.Multiplayer
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	public class CoopLobbyBrowser : MonoBehaviour, IServerBrowser
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600004A RID: 74 RVA: 0x000020CC File Offset: 0x000002CC
		[Token(Token = "0x17000009")]
		public bool RefreshInProgress
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x998F00", Offset = "0x997500", VA = "0x180998F00", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600004B RID: 75 RVA: 0x000020E4 File Offset: 0x000002E4
		[Token(Token = "0x1700000A")]
		public bool ReadyToDisplay
		{
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x3029EB0", Offset = "0x30284B0", VA = "0x183029EB0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700000B")]
		public List<CoopLobby> Lobbies
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x3029EC0", Offset = "0x30284C0", VA = "0x183029EC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700000C")]
		public IServerInfo[] Entries
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x3029ED0", Offset = "0x30284D0", VA = "0x183029ED0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600004E RID: 78 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x0600004F RID: 79 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000001")]
		public event Action OnServersRefreshed
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x3029FB0", Offset = "0x30285B0", VA = "0x183029FB0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x302A0A0", Offset = "0x30286A0", VA = "0x18302A0A0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x302A190", Offset = "0x3028790", VA = "0x18302A190")]
		private void Start()
		{
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x302A220", Offset = "0x3028820", VA = "0x18302A220")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x302A2B0", Offset = "0x30288B0", VA = "0x18302A2B0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x302A380", Offset = "0x3028980", VA = "0x18302A380")]
		private void OnDisable()
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x302A440", Offset = "0x3028A40", VA = "0x18302A440")]
		public void CheckAutoJoin()
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x302A6D0", Offset = "0x3028CD0", VA = "0x18302A6D0")]
		public void JoinLobby(CoopLobby lobby)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x302A6F0", Offset = "0x3028CF0", VA = "0x18302A6F0")]
		public void JoinLobby(ulong lobby)
		{
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x302A890", Offset = "0x3028E90", VA = "0x18302A890")]
		public void LeaveLobby(bool updateDialogVisibility = true)
		{
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x302AAC0", Offset = "0x30290C0", VA = "0x18302AAC0")]
		private void OnActiveGameStarted()
		{
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x302ABE0", Offset = "0x30291E0", VA = "0x18302ABE0")]
		public void SetLobbyNameFilter(string lobbyNameFilter)
		{
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x302AC00", Offset = "0x3029200", VA = "0x18302AC00")]
		public void SetGameModeFilter(int dropdownIndex)
		{
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x302ACC0", Offset = "0x30292C0", VA = "0x18302ACC0")]
		private Task SetLobbyNameFilterAsync(string lobbyNameFilter)
		{
			return null;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x302AEA0", Offset = "0x30294A0", VA = "0x18302AEA0")]
		public void SetFriendsOnly(int filter)
		{
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x302AEE0", Offset = "0x30294E0", VA = "0x18302AEE0", Slot = "6")]
		public Task RefreshLobbiesListAsync(ServerBrowserRefreshType refreshType)
		{
			return null;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "10")]
		public void CancelRefresh()
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x302B080", Offset = "0x3029680", VA = "0x18302B080", Slot = "11")]
		public void GetServerCount(out int refreshedServerCount, out int totalServerCount)
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x302B100", Offset = "0x3029700", VA = "0x18302B100")]
		private Task<List<CoopLobby>> RequestFriendsLobbiesAsync()
		{
			return null;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x302B270", Offset = "0x3029870", VA = "0x18302B270")]
		private void GetDistinctFriendsLobbies()
		{
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x302B480", Offset = "0x3029A80", VA = "0x18302B480")]
		private void AddLobbies(CoopLobby[] results, string source)
		{
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x302B6D0", Offset = "0x3029CD0", VA = "0x18302B6D0")]
		private void AddLobbiesWithLateFiltering(CoopLobby[] results, string source)
		{
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x302BEE0", Offset = "0x302A4E0", VA = "0x18302BEE0")]
		private void LobbiesQueryListCallback(CoopLobby[] results)
		{
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000020FC File Offset: 0x000002FC
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x302BF30", Offset = "0x302A530", VA = "0x18302BF30")]
		public bool CheckLobbyContainsFriends(CSteamID lobbyId)
		{
			return default(bool);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x302BF90", Offset = "0x302A590", VA = "0x18302BF90")]
		private void ApplyLobbySearch()
		{
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x302C620", Offset = "0x302AC20", VA = "0x18302C620")]
		public CoopLobbyBrowser()
		{
		}

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Header("References")]
		private SonsServerMono _sonsServer;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ClientStarterSteam _starter;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameServerBrowserStatusBar _statusBar;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameServerBrowserGui _browserGui;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CoopLobbyDialogGui _dialogGui;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x48")]
		[Header("Debug")]
		private string _lobbyNameFilter;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x50")]
		private bool _lobbyFriendsOnlyFilter;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x54")]
		private Mode? _lobbyGameModeFilter;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x5C")]
		private bool _refreshInProgress;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x5D")]
		private bool _queryListRefreshInProgress;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x60")]
		private List<CoopLobby> _lobbies;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x68")]
		private List<CoopLobby> _filteredLobbies;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x70")]
		private HashSet<CSteamID> _distinctFriendsLobbies;

		// Token: 0x0200000C RID: 12
		[Token(Token = "0x200000C")]
		private class LobbyGuidComparer : IEqualityComparer<CoopLobby>
		{
			// Token: 0x06000068 RID: 104 RVA: 0x00002114 File Offset: 0x00000314
			[Token(Token = "0x6000068")]
			[Address(RVA = "0x302C8C0", Offset = "0x302AEC0", VA = "0x18302C8C0", Slot = "4")]
			public bool Equals(CoopLobby x, CoopLobby y)
			{
				return default(bool);
			}

			// Token: 0x06000069 RID: 105 RVA: 0x0000212C File Offset: 0x0000032C
			[Token(Token = "0x6000069")]
			[Address(RVA = "0x302C920", Offset = "0x302AF20", VA = "0x18302C920", Slot = "5")]
			public int GetHashCode(CoopLobby obj)
			{
				return 0;
			}

			// Token: 0x0600006A RID: 106 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600006A")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public LobbyGuidComparer()
			{
			}
		}
	}
}
