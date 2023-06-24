using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Endnight.Localization;
using Il2CppDummyDll;
using Sons.Gui.Multiplayer.Notifications;
using Sons.Multiplayer;
using Sons.Multiplayer.Dedicated;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Localization;
using UnityEngine.Localization.Components;
using UnityEngine.UI;

namespace Sons.Gui.Multiplayer
{
	// Token: 0x0200001C RID: 28
	[Token(Token = "0x200001C")]
	public class ServerInfoGuiItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x060000C5 RID: 197 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x3036310", Offset = "0x3034910", VA = "0x183036310")]
		public void Reset()
		{
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x3036700", Offset = "0x3034D00", VA = "0x183036700")]
		private void SetTextTargets(string nameValue, string detailValue)
		{
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x30367D0", Offset = "0x3034DD0", VA = "0x1830367D0")]
		public void Setup(IServerInfo serverInfo, int index, HashSet<string> allAvailableSaveGameId, IServerInfo[] allServers)
		{
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x3037390", Offset = "0x3035990", VA = "0x183037390")]
		private void SetButtonsActive(bool active)
		{
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x3037580", Offset = "0x3035B80", VA = "0x183037580")]
		private void Update()
		{
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x3037A90", Offset = "0x3036090", VA = "0x183037A90")]
		private void ApplyButtonsActiveState()
		{
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x3037B70", Offset = "0x3036170", VA = "0x183037B70")]
		public Selectable GetFirstButton()
		{
			return null;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x3037BA0", Offset = "0x30361A0", VA = "0x183037BA0")]
		public void SetNavigation(ServerInfoGuiItem previous, ServerInfoGuiItem next)
		{
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x3037DA0", Offset = "0x30363A0", VA = "0x183037DA0")]
		private void DoJoin()
		{
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x3037E70", Offset = "0x3036470", VA = "0x183037E70")]
		private void DoContinue()
		{
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x3037E80", Offset = "0x3036480", VA = "0x183037E80")]
		private void DoNewGame()
		{
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x3037F50", Offset = "0x3036550", VA = "0x183037F50", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x3037F60", Offset = "0x3036560", VA = "0x183037F60", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ServerInfoGuiItem()
		{
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x3037F70", Offset = "0x3036570", VA = "0x183037F70")]
		[CompilerGenerated]
		internal static void <SetNavigation>g__SetNavigationForSelectable|36_0(Selectable current, Selectable previous, Selectable next)
		{
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x3038090", Offset = "0x3036690", VA = "0x183038090")]
		[CompilerGenerated]
		private void <DoNewGame>g__OnOption2Confirmed|39_0()
		{
		}

		// Token: 0x04000085 RID: 133
		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		[SerializeField]
		private GameServerBrowserStatusBar _statusBar;

		// Token: 0x04000086 RID: 134
		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameServerBrowserGui _browserGui;

		// Token: 0x04000087 RID: 135
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CoopLobbyBrowser _lobbyBrowser;

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private DedicatedServerBrowser _dedicatedBrowser;

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CoopLobbyDialogGui _dialogGui;

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x48")]
		[Header("Gui Links")]
		[SerializeField]
		private TextMeshProUGUI[] _textTargets;

		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TextMeshProUGUI[] _detailTextTargets;

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ServerInfoGuiItemButton _newGameButton;

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private ServerInfoGuiItemButton _continueButton;

		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ServerInfoGuiItemButton _joinButton;

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _inLobbyImage;

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _hasSaveImage;

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _hasFriendsImage;

		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Image _hasPasswordImage;

		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private LocalizeStringEvent _gameModeText;

		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private HorizontalLayoutGroup _rightAnchor;

		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Image _backing;

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Header("Localization")]
		private LocalizationArray _gameModesLocalizationArray;

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private LocalizedString _invalidString;

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0xB8")]
		[Header("Debug")]
		private string _serverGuid;

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0xC0")]
		private string _serverName;

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0xC8")]
		private IServerInfo _source;

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0xD0")]
		private int _index;

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0xD4")]
		private bool _hasSave;

		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0xD8")]
		private HashSet<string> _allAvailableSaveGameId;

		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0xE0")]
		private IServerInfo[] _allServers;

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0xE8")]
		private bool _isButtonActive;

		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0xE9")]
		private bool _isSelected;

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0xEA")]
		private bool _isHover;
	}
}
