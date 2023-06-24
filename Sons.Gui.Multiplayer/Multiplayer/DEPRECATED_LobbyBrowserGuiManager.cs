using System;
using System.Collections;
using System.Collections.Generic;
using Endnight.Utilities.Timer;
using Il2CppDummyDll;
using Sons.Gui.Multiplayer;
using Sons.Input;
using TMPro;
using UnityEngine;

namespace Sons.Multiplayer
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public class DEPRECATED_LobbyBrowserGuiManager : MonoBehaviour
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x5B2F00", Offset = "0x5B1500", VA = "0x1805B2F00")]
		public void SetLobbyFilter(string lobbyFilterString)
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x674890", Offset = "0x672E90", VA = "0x180674890")]
		public void SetFriendsOnly(bool filter)
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x3025910", Offset = "0x3023F10", VA = "0x183025910")]
		private void Update()
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x3025A30", Offset = "0x3024030", VA = "0x183025A30")]
		public void DoRefresh()
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x3025A40", Offset = "0x3024040", VA = "0x183025A40")]
		private IEnumerator DoRefresh(float delay)
		{
			return null;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x3025B00", Offset = "0x3024100", VA = "0x183025B00")]
		public void DoFakeRefresh()
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x3025F80", Offset = "0x3024580", VA = "0x183025F80")]
		public void OnSteamInitializeFailed()
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x3025FD0", Offset = "0x30245D0", VA = "0x183025FD0")]
		public void OnSteamInitialized()
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x3026020", Offset = "0x3024620", VA = "0x183026020")]
		private void OnEnable()
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x30261D0", Offset = "0x30247D0", VA = "0x1830261D0")]
		private void OnDisable()
		{
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x3026310", Offset = "0x3024910", VA = "0x183026310")]
		private void RefreshGui()
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x3026450", Offset = "0x3024A50", VA = "0x183026450")]
		private void ClearLobbyGui()
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x3026860", Offset = "0x3024E60", VA = "0x183026860")]
		private void AddLobbies(CoopLobby[] results)
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x3026E30", Offset = "0x3025430", VA = "0x183026E30")]
		private IEnumerator ShowLobbyDelayed(CoopLobby eachLobby, float delay)
		{
			return null;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void RefreshSelected(ServerInfoGuiItem serverInfoItem)
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x3026EF0", Offset = "0x30254F0", VA = "0x183026EF0")]
		public void LobbySelected(CoopLobby lobby)
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x30271B0", Offset = "0x30257B0", VA = "0x1830271B0")]
		private void OnActiveGameStarted()
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x30272B0", Offset = "0x30258B0", VA = "0x1830272B0")]
		private void ShowConnectingMessage(bool value)
		{
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x3027320", Offset = "0x3025920", VA = "0x183027320")]
		private void SetMenuEnabled(bool value)
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x3027440", Offset = "0x3025A40", VA = "0x183027440")]
		private void ClearMessage()
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x30274A0", Offset = "0x3025AA0", VA = "0x1830274A0")]
		private void ShowMessage(string message, float holdTimer = 3f)
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x3027650", Offset = "0x3025C50", VA = "0x183027650")]
		private void OnFailedEnterLobby(string reason)
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x3027700", Offset = "0x3025D00", VA = "0x183027700")]
		private void OnSuccessEnterLobby()
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x30277C0", Offset = "0x3025DC0", VA = "0x1830277C0")]
		private ServerInfoGuiItem Depool()
		{
			return null;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x30279F0", Offset = "0x3025FF0", VA = "0x1830279F0")]
		private void Repool(ServerInfoGuiItem item)
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x3027C60", Offset = "0x3026260", VA = "0x183027C60")]
		private ServerInfoGuiItem CreateNewLobbyGuiItem()
		{
			return null;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x3027F20", Offset = "0x3026520", VA = "0x183027F20")]
		public DEPRECATED_LobbyBrowserGuiManager()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		private const float DefaultHoldMessageTimer = 3f;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _menuGameObject;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ClientStarterSteam _starter;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _lobbyGuiSource;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _lobbyFilterString;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _lobbyFriendsOnlyFilter;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TMP_Text _infoMessageText;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _lobbyGuiParent;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _lobbyGuiPoolParent;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _lobbyShowDelayMin;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float _lobbyShowDelayMax;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private InputGamepadMenuHelper _helper;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<string> _lobbyIds;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x78")]
		private Queue<ServerInfoGuiItem> _activeLobbyGuiItems;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x80")]
		private Queue<ServerInfoGuiItem> _pooledLobbyGuiItems;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private MultiplayerMenu _multiplayerMenu;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _connectingGroup;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x98")]
		private int _totalItems;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x9C")]
		private Vector3 _defaultLobbyPoolScale;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0xA8")]
		private RealtimeAutoTimer _infoMessageTimer;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0xB0")]
		private List<string> _shownLobbies;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0xB8")]
		private int _refreshFrame;
	}
}
