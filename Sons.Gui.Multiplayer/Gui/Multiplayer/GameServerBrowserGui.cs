using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Gui.Multiplayer.Notifications;
using Sons.Multiplayer;
using Sons.Multiplayer.Dedicated;
using TMPro;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Sons.Gui.Multiplayer
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	public class GameServerBrowserGui : MonoBehaviour
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700000D")]
		private IServerBrowser ActiveBrowser
		{
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x30330F0", Offset = "0x30316F0", VA = "0x1830330F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700000E")]
		public HashSet<string> AllAvailableSaveGameId
		{
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x3033100", Offset = "0x3031700", VA = "0x183033100")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x3033170", Offset = "0x3031770", VA = "0x183033170")]
		private void Awake()
		{
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x3033340", Offset = "0x3031940", VA = "0x183033340")]
		private void OnEnable()
		{
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x30337E0", Offset = "0x3031DE0", VA = "0x1830337E0")]
		private void OnDisable()
		{
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x3033C10", Offset = "0x3032210", VA = "0x183033C10")]
		public void Refresh()
		{
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x3033C80", Offset = "0x3032280", VA = "0x183033C80")]
		private void Update()
		{
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x3033DF0", Offset = "0x30323F0", VA = "0x183033DF0")]
		private void UpdateServerCount()
		{
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x3034240", Offset = "0x3032840", VA = "0x183034240")]
		private void UpdateStatusBar()
		{
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x3034390", Offset = "0x3032990", VA = "0x183034390")]
		public void ChangeBrowserMode(int mode)
		{
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x3034400", Offset = "0x3032A00", VA = "0x183034400")]
		private void OnLobbyBrowserRefreshed()
		{
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x3034420", Offset = "0x3032A20", VA = "0x183034420")]
		private void OnDedicatedBrowserRefreshed()
		{
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x3034440", Offset = "0x3032A40", VA = "0x183034440")]
		private void OnBrowserRefreshed()
		{
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x3034510", Offset = "0x3032B10", VA = "0x183034510")]
		private void ResetScrollPanelPosition()
		{
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x3034550", Offset = "0x3032B50", VA = "0x183034550")]
		private void OnScrollPanelValueChanged(Vector2 scroll)
		{
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x30345D0", Offset = "0x3032BD0", VA = "0x1830345D0")]
		private void UpdateVisibleServerInfoGuiItems(float scrollPos)
		{
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x3034E50", Offset = "0x3033450", VA = "0x183034E50")]
		private void SetupServerInfoGuiItemsNavigation(bool selectLast = true)
		{
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x3035150", Offset = "0x3033750", VA = "0x183035150")]
		private void SetSelectedObject(GameObject go)
		{
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002294 File Offset: 0x00000494
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x3035240", Offset = "0x3033840", VA = "0x183035240")]
		public static bool CheckCurrentSelectedIsServerInfoGuiItemButtonOrNull()
		{
			return default(bool);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000022AC File Offset: 0x000004AC
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x3035340", Offset = "0x3033940", VA = "0x183035340")]
		public static bool CheckCurrentSelectedIsServerInfoGuiItemButton()
		{
			return default(bool);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x30354F0", Offset = "0x3033AF0", VA = "0x1830354F0")]
		private void ReturnAllServerInfoGuiItemToPool()
		{
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x3035650", Offset = "0x3033C50", VA = "0x183035650")]
		private ServerInfoGuiItem CreateServerInfoGuiItem()
		{
			return null;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x3013FC0", Offset = "0x30125C0", VA = "0x183013FC0")]
		private void GetServerInfoGuiItem(ServerInfoGuiItem item)
		{
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x30357B0", Offset = "0x3033DB0", VA = "0x1830357B0")]
		private void ReleaseServerInfoGuiItem(ServerInfoGuiItem item)
		{
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x3035860", Offset = "0x3033E60", VA = "0x183035860")]
		private void DestroyServerInfoGuiItem(ServerInfoGuiItem item)
		{
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x3035900", Offset = "0x3033F00", VA = "0x183035900")]
		public GameServerBrowserGui()
		{
		}

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		private const int ServerInfoGuiItemDefaultPoolCapacity = 40;

		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		private const int ServerInfoGuiItemMaxPoolSize = 1000;

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		[SerializeField]
		private CoopLobbyBrowser _lobbyBrowser;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private DedicatedServerBrowser _dedicatedBrowser;

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameServerBrowserStatusBar _statusBar;

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x38")]
		[FormerlySerializedAs("_lobbySelector")]
		[SerializeField]
		private SelectFirstServerInfoOrLastSelected _serverInfoSelector;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ServerBrowserRefreshType _refreshType;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x48")]
		[FormerlySerializedAs("_lobbyGuiItemTemplate")]
		[Header("Gui Links")]
		[SerializeField]
		private ServerInfoGuiItem _serverInfoGuiItemTemplate;

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _lobbyGuiItemsRoot;

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private LayoutElement _topSpacer;

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private LayoutElement _bottomSpacer;

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ScrollRect _scrollPanel;

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TMP_Text _serverCountText;

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x78")]
		private IObjectPool<ServerInfoGuiItem> _serverInfoGuiItemPool;

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x80")]
		private HashSet<string> _allAvailableSaveGameId;

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x88")]
		private bool _firstRefresh;

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x8C")]
		private int _firstVisibleIndex;

		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x90")]
		private int _lastVisibleIndex;
	}
}
