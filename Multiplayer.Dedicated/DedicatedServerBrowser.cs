using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Bolt;
using Il2CppDummyDll;
using Sons.Gameplay.GameSetup;
using Sons.Gui;
using Sons.Gui.Multiplayer.Notifications;
using Steamworks;
using UdpKit;
using UnityEngine;

namespace Sons.Multiplayer.Dedicated
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	public class DedicatedServerBrowser : MonoBehaviour, IServerBrowser
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00002200 File Offset: 0x00000400
		[Token(Token = "0x17000001")]
		public float RefreshProgress
		{
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x23BFBF0", Offset = "0x23BE1F0", VA = "0x1823BFBF0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00002218 File Offset: 0x00000418
		[Token(Token = "0x17000002")]
		public int ServerCount
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x75C1D0", Offset = "0x75A7D0", VA = "0x18075C1D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00002230 File Offset: 0x00000430
		[Token(Token = "0x17000003")]
		public bool RefreshInProgress
		{
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x2457E50", Offset = "0x2456450", VA = "0x182457E50", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00002248 File Offset: 0x00000448
		[Token(Token = "0x17000004")]
		public bool ReadyToDisplay
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x2457E60", Offset = "0x2456460", VA = "0x182457E60", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000028 RID: 40 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x06000029 RID: 41 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000001")]
		public event Action OnServersRefreshed
		{
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x2457E70", Offset = "0x2456470", VA = "0x182457E70", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x2457F60", Offset = "0x2456560", VA = "0x182457F60", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600002A RID: 42 RVA: 0x0000225E File Offset: 0x0000045E
		[Token(Token = "0x17000005")]
		public IServerInfo[] Entries
		{
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x661070", Offset = "0x65F670", VA = "0x180661070", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2458050", Offset = "0x2456650", VA = "0x182458050")]
		private void OnEnable()
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2458420", Offset = "0x2456A20", VA = "0x182458420")]
		private void OnDisable()
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x24585C0", Offset = "0x2456BC0", VA = "0x1824585C0")]
		public void CheckAutoJoin()
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x24587E0", Offset = "0x2456DE0", VA = "0x1824587E0")]
		private void ResetServerList()
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x2458840", Offset = "0x2456E40", VA = "0x182458840")]
		public void FetchInternet()
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x2458FB0", Offset = "0x24575B0", VA = "0x182458FB0")]
		public void FetchLan()
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x24591D0", Offset = "0x24577D0", VA = "0x1824591D0", Slot = "10")]
		public void CancelRefresh()
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x24591E0", Offset = "0x24577E0", VA = "0x1824591E0", Slot = "11")]
		public void GetServerCount(out int refreshedServerCount, out int totalServerCount)
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x24591F0", Offset = "0x24577F0", VA = "0x1824591F0")]
		public void RefreshServer(int index)
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x24593C0", Offset = "0x24579C0", VA = "0x1824593C0")]
		public void Connect(int index)
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x24596F0", Offset = "0x2457CF0", VA = "0x1824596F0")]
		private void Connect(gameserveritem_t server)
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x2459AF0", Offset = "0x24580F0", VA = "0x182459AF0")]
		private void Connect(CSteamID serverId, string ipAddress, ushort gamePort, string gameGuid, int maxPlayer, bool isPasswordProtected, string connectPassword = "", int serverWeakPasswordHash = -1)
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002264 File Offset: 0x00000464
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x2459F50", Offset = "0x2458550", VA = "0x182459F50")]
		private bool DoWeakPasswordCheck(string connectPassword, int serverSoftPasswordHash)
		{
			return default(bool);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x2459FF0", Offset = "0x24585F0", VA = "0x182459FF0")]
		private void OnKickedOrBanned(CoopKickToken token)
		{
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x245A180", Offset = "0x2458780", VA = "0x18245A180")]
		private void OnWrongPassword(CoopJoinDedicatedServerFailed token)
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x245A300", Offset = "0x2458900", VA = "0x18245A300")]
		private void OnUndefinedDisconnect(IProtocolToken token)
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x245A3B0", Offset = "0x24589B0", VA = "0x18245A3B0")]
		private static void LeaveToTitle()
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x245A450", Offset = "0x2458A50", VA = "0x18245A450")]
		private void CancelServerListQuery()
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x245A540", Offset = "0x2458B40", VA = "0x18245A540")]
		private void ReleaseRequest()
		{
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000225E File Offset: 0x0000045E
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x245A700", Offset = "0x2458D00", VA = "0x18245A700")]
		private static string GameServerItemFormattedString(gameserveritem_t gsi)
		{
			return null;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x245AE00", Offset = "0x2459400", VA = "0x18245AE00")]
		private void OnInternetServerRespondedSuccessOrFail(HServerListRequest hRequest, int iServer)
		{
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x245B310", Offset = "0x2459910", VA = "0x18245B310")]
		private void OnInternetRefreshComplete(HServerListRequest hRequest, EMatchMakingServerResponse response)
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void OnLanServerRespondedSuccessOrFail(HServerListRequest hRequest, int iServer)
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x245B400", Offset = "0x2459A00", VA = "0x18245B400")]
		private void OnLanRefreshComplete(HServerListRequest hRequest, EMatchMakingServerResponse response)
		{
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x245BBD0", Offset = "0x245A1D0", VA = "0x18245BBD0")]
		private void SortServers()
		{
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000227C File Offset: 0x0000047C
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x245BE30", Offset = "0x245A430", VA = "0x18245BE30")]
		private int ServerSortComparison(DedicatedServerInfo x, DedicatedServerInfo y)
		{
			return 0;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000225E File Offset: 0x0000045E
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x245C900", Offset = "0x245AF00", VA = "0x18245C900", Slot = "6")]
		public Task RefreshLobbiesListAsync(ServerBrowserRefreshType refreshType)
		{
			return null;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x245CAA0", Offset = "0x245B0A0", VA = "0x18245CAA0")]
		private void GetDistinctFriendsServers()
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002294 File Offset: 0x00000494
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x245CCE0", Offset = "0x245B2E0", VA = "0x18245CCE0")]
		public bool CheckServerContainsFriends(DedicatedServerInfo dedicatedServerInfo)
		{
			return default(bool);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x245CD40", Offset = "0x245B340", VA = "0x18245CD40")]
		public void SetLobbyNameFilter(string lobbyNameFilter)
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x245CDE0", Offset = "0x245B3E0", VA = "0x18245CDE0")]
		public void SetGameModeFilter(int dropdownIndex)
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x245CE90", Offset = "0x245B490", VA = "0x18245CE90")]
		public void SetFriendsOnly(int filter)
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x245CEB0", Offset = "0x245B4B0", VA = "0x18245CEB0")]
		public DedicatedServerBrowser()
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x245D110", Offset = "0x245B710", VA = "0x18245D110")]
		[CompilerGenerated]
		internal static void <Connect>g__OnModalClosed|38_0(DynamicModalDialogController.Options result)
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x245D120", Offset = "0x245B720", VA = "0x18245D120")]
		[CompilerGenerated]
		internal static void <OnKickedOrBanned>g__OnModalClosed|40_0(DynamicModalDialogController.Options result)
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x245D120", Offset = "0x245B720", VA = "0x18245D120")]
		[CompilerGenerated]
		internal static void <OnWrongPassword>g__OnModalClosed|41_0(DynamicModalDialogController.Options result)
		{
		}

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ClientStarterSteam _clientStarter;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameServerBrowserStatusBar _statusBar;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x30")]
		private HServerListRequest _serverListRequest;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x38")]
		private ISteamMatchmakingServerListResponse _internetServerListResponse;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x40")]
		private ISteamMatchmakingServerListResponse _lanServerListResponse;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x48")]
		[Header("Debug")]
		private DedicatedServerInfo[] _serversArray;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x50")]
		private DedicatedServerInfo[] _sortedServersArray;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x58")]
		private float _refreshProgress;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x5C")]
		private int _serverResponded;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x60")]
		private int _serverCount;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x68")]
		private HashSet<UdpEndPoint> _distinctFriendsServers;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x70")]
		private string _serverNameFilter;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x78")]
		private Mode? _serverGameModeFilter;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x80")]
		private bool _serverFriendsOnlyFilter;
	}
}
