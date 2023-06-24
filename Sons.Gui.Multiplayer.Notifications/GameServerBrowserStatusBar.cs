using System;
using Endnight.Localization;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Localization.Components;

namespace Sons.Gui.Multiplayer.Notifications
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public class GameServerBrowserStatusBar : MonoBehaviour
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x30385C0", Offset = "0x3036BC0", VA = "0x1830385C0")]
		public void Show(GameServerBrowserStatusBar.State state)
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x30385D0", Offset = "0x3036BD0", VA = "0x1830385D0")]
		public void Show(GameServerBrowserStatusBar.State state, object[] arguments)
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x3038650", Offset = "0x3036C50", VA = "0x183038650")]
		public void ShowTemporary(GameServerBrowserStatusBar.State state, float duration = 3f)
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x3038670", Offset = "0x3036C70", VA = "0x183038670")]
		public void ShowTemporary(GameServerBrowserStatusBar.State state, object[] arguments, float duration = 3f)
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x30386F0", Offset = "0x3036CF0", VA = "0x1830386F0")]
		private void Update()
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x3038790", Offset = "0x3036D90", VA = "0x183038790")]
		private void SetText(GameServerBrowserStatusBar.State state, object[] arguments)
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public GameServerBrowserStatusBar()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x20")]
		[Header("Properties")]
		[SerializeField]
		private LocalizationArray _localization;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x28")]
		[Header("Gui Links")]
		[SerializeField]
		private LocalizeStringEvent _text;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x30")]
		[Header("Debug")]
		private GameServerBrowserStatusBar.State _currentState;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x38")]
		private object[] _currentStateArguments;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x40")]
		private GameServerBrowserStatusBar.State _temporaryState;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x48")]
		private object[] _temporaryStateArguments;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x50")]
		private float _temporaryStateTime;

		// Token: 0x02000005 RID: 5
		[Token(Token = "0x2000005")]
		public enum State
		{
			// Token: 0x0400000E RID: 14
			[Token(Token = "0x400000E")]
			Unknown,
			// Token: 0x0400000F RID: 15
			[Token(Token = "0x400000F")]
			Empty,
			// Token: 0x04000010 RID: 16
			[Token(Token = "0x4000010")]
			Connected,
			// Token: 0x04000011 RID: 17
			[Token(Token = "0x4000011")]
			NotConnected,
			// Token: 0x04000012 RID: 18
			[Token(Token = "0x4000012")]
			Refreshing,
			// Token: 0x04000013 RID: 19
			[Token(Token = "0x4000013")]
			CreatingLobby,
			// Token: 0x04000014 RID: 20
			[Token(Token = "0x4000014")]
			JoiningLobby,
			// Token: 0x04000015 RID: 21
			[Token(Token = "0x4000015")]
			JoinLobbyFail,
			// Token: 0x04000016 RID: 22
			[Token(Token = "0x4000016")]
			InLobby,
			// Token: 0x04000017 RID: 23
			[Token(Token = "0x4000017")]
			ServerCreationSuccess,
			// Token: 0x04000018 RID: 24
			[Token(Token = "0x4000018")]
			ServerCreationFailed,
			// Token: 0x04000019 RID: 25
			[Token(Token = "0x4000019")]
			HostStartFailed,
			// Token: 0x0400001A RID: 26
			[Token(Token = "0x400001A")]
			GameStarting,
			// Token: 0x0400001B RID: 27
			[Token(Token = "0x400001B")]
			LobbyHostLeft,
			// Token: 0x0400001C RID: 28
			[Token(Token = "0x400001C")]
			PlayerJoinedLobby,
			// Token: 0x0400001D RID: 29
			[Token(Token = "0x400001D")]
			LobbyFull,
			// Token: 0x0400001E RID: 30
			[Token(Token = "0x400001E")]
			KickedFromGame,
			// Token: 0x0400001F RID: 31
			[Token(Token = "0x400001F")]
			BannedFromGame
		}
	}
}
