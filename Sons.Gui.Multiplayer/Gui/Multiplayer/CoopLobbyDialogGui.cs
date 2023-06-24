using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Bolt;
using Il2CppDummyDll;
using Sons.Gui.Multiplayer.Notifications;
using Sons.Multiplayer;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.UI;

namespace Sons.Gui.Multiplayer
{
	// Token: 0x02000014 RID: 20
	[Token(Token = "0x2000014")]
	public class CoopLobbyDialogGui : MonoBehaviour
	{
		// Token: 0x06000081 RID: 129 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x302EA50", Offset = "0x302D050", VA = "0x18302EA50")]
		private void Start()
		{
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x302EBE0", Offset = "0x302D1E0", VA = "0x18302EBE0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x302F120", Offset = "0x302D720", VA = "0x18302F120")]
		private void OnDisable()
		{
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x302F7F0", Offset = "0x302DDF0", VA = "0x18302F7F0")]
		public Task CreateServerAsync()
		{
			return null;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x302F960", Offset = "0x302DF60", VA = "0x18302F960")]
		private void Update()
		{
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x302FB40", Offset = "0x302E140", VA = "0x18302FB40")]
		private void OnActiveGameStarted()
		{
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x302FC00", Offset = "0x302E200", VA = "0x18302FC00")]
		private void OnCreateServerSuccess()
		{
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x302FCA0", Offset = "0x302E2A0", VA = "0x18302FCA0")]
		private void OnCreateServerFailed(string reason)
		{
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x302FDA0", Offset = "0x302E3A0", VA = "0x18302FDA0")]
		public void OnStartClicked()
		{
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x3030000", Offset = "0x302E600", VA = "0x183030000")]
		public void OnInviteClicked()
		{
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002204 File Offset: 0x00000404
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x3030170", Offset = "0x302E770", VA = "0x183030170")]
		private bool IsGameStarted()
		{
			return default(bool);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x3030220", Offset = "0x302E820", VA = "0x183030220")]
		public void OnLeaveClicked()
		{
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x3030250", Offset = "0x302E850", VA = "0x183030250")]
		private void LeaveLobbyAndCloseDialog(bool gameStarted)
		{
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x3030530", Offset = "0x302EB30", VA = "0x183030530")]
		private void OnKickedOrBanned(CoopKickToken token)
		{
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x30305D0", Offset = "0x302EBD0", VA = "0x1830305D0")]
		private void OnHostLeftLobby()
		{
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x3030600", Offset = "0x302EC00", VA = "0x183030600")]
		private void OnUndefinedDisconnect(IProtocolToken token)
		{
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x3030670", Offset = "0x302EC70", VA = "0x183030670")]
		private void OnPlayerLeaveRequested()
		{
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x30306A0", Offset = "0x302ECA0", VA = "0x1830306A0")]
		private void ShowModalAndLeave(ModalDialogManager.Dialog dialog, GameServerBrowserStatusBar.State status, int duration)
		{
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x3030850", Offset = "0x302EE50", VA = "0x183030850")]
		private void OnActiveLobbyMembersUpdated()
		{
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x3030860", Offset = "0x302EE60", VA = "0x183030860")]
		private void RefreshMemberList()
		{
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x3032520", Offset = "0x3030B20", VA = "0x183032520")]
		private void ClearMemberList()
		{
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x30327A0", Offset = "0x3030DA0", VA = "0x1830327A0")]
		public CoopLobbyDialogGui()
		{
		}

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x20")]
		[Header("Properties")]
		[SerializeField]
		private bool _hostMode;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LocalizedString _hostMemberSuffix;

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		[SerializeField]
		private SonsServerMono _sonsServer;

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameServerBrowserStatusBar _statusBar;

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SonsFMODEventEmitter _playerJoinedSound;

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CoopLobbyBrowser _lobbyBrowser;

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x50")]
		[Header("Gui Links")]
		[SerializeField]
		private GameObject _memberGuiItemTemplate;

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject[] _memberGuiListRoots;

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private LinkTextGui _memberCount;

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Button[] _inviteButton;

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Button _startButton;

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x78")]
		[Header("Debug")]
		private CoopLobby _lobby;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x80")]
		[TupleElementNames(new string[]
		{
			"gui",
			"order"
		})]
		private Dictionary<CoopLobbyMember, ValueTuple<GameObject, int>> _membersGui;
	}
}
