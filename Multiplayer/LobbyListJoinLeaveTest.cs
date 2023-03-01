using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Multiplayer
{
	// Token: 0x0200054D RID: 1357
	[Token(Token = "0x200054D")]
	public class LobbyListJoinLeaveTest : MonoBehaviour
	{
		// Token: 0x06002346 RID: 9030 RVA: 0x0000A350 File Offset: 0x00008550
		[Token(Token = "0x6002346")]
		[Address(RVA = "0x2D5E770", Offset = "0x2D5D770", VA = "0x182D5E770")]
		private bool IsInLobby()
		{
			return default(bool);
		}

		// Token: 0x06002347 RID: 9031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002347")]
		[Address(RVA = "0x2D5EA80", Offset = "0x2D5DA80", VA = "0x182D5EA80")]
		private void OnEnable()
		{
		}

		// Token: 0x06002348 RID: 9032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002348")]
		[Address(RVA = "0x2D5E9F0", Offset = "0x2D5D9F0", VA = "0x182D5E9F0")]
		private void OnDisable()
		{
		}

		// Token: 0x06002349 RID: 9033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002349")]
		[Address(RVA = "0x2D5ED90", Offset = "0x2D5DD90", VA = "0x182D5ED90")]
		private void UpdateLobbies()
		{
		}

		// Token: 0x0600234A RID: 9034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600234A")]
		[Address(RVA = "0x2D5EB10", Offset = "0x2D5DB10", VA = "0x182D5EB10")]
		private void QueryCallback(CoopLobby[] results)
		{
		}

		// Token: 0x0600234B RID: 9035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600234B")]
		[Address(RVA = "0x2D5EE40", Offset = "0x2D5DE40", VA = "0x182D5EE40")]
		private void Update()
		{
		}

		// Token: 0x0600234C RID: 9036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600234C")]
		[Address(RVA = "0x2D5E7B0", Offset = "0x2D5D7B0", VA = "0x182D5E7B0")]
		private void JoinLobby()
		{
		}

		// Token: 0x0600234D RID: 9037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600234D")]
		[Address(RVA = "0x2D5E920", Offset = "0x2D5D920", VA = "0x182D5E920")]
		private void LeaveLobby()
		{
		}

		// Token: 0x0600234E RID: 9038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600234E")]
		[Address(RVA = "0x2D5E6C0", Offset = "0x2D5D6C0", VA = "0x182D5E6C0")]
		private void FakeServerStart()
		{
		}

		// Token: 0x0600234F RID: 9039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600234F")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public LobbyListJoinLeaveTest()
		{
		}

		// Token: 0x04001FD0 RID: 8144
		[Token(Token = "0x4001FD0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<CoopLobby> _lobbies;

		// Token: 0x04001FD1 RID: 8145
		[Token(Token = "0x4001FD1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CoopLobby _activeLobby;

		// Token: 0x04001FD2 RID: 8146
		[Token(Token = "0x4001FD2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int _lobbyIndexToJoin;
	}
}
