using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Multiplayer
{
	// Token: 0x02000557 RID: 1367
	[Token(Token = "0x2000557")]
	public class LobbyListJoinLeaveTest : MonoBehaviour
	{
		// Token: 0x0600243C RID: 9276 RVA: 0x0000A9B0 File Offset: 0x00008BB0
		[Token(Token = "0x600243C")]
		[Address(RVA = "0x3384D70", Offset = "0x3383370", VA = "0x183384D70")]
		private bool IsInLobby()
		{
			return default(bool);
		}

		// Token: 0x0600243D RID: 9277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600243D")]
		[Address(RVA = "0x3384DB0", Offset = "0x33833B0", VA = "0x183384DB0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600243E RID: 9278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600243E")]
		[Address(RVA = "0x3384E70", Offset = "0x3383470", VA = "0x183384E70")]
		private void OnDisable()
		{
		}

		// Token: 0x0600243F RID: 9279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600243F")]
		[Address(RVA = "0x3384F30", Offset = "0x3383530", VA = "0x183384F30")]
		private void UpdateLobbies()
		{
		}

		// Token: 0x06002440 RID: 9280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002440")]
		[Address(RVA = "0x3385050", Offset = "0x3383650", VA = "0x183385050")]
		private void QueryCallback(CoopLobby[] results)
		{
		}

		// Token: 0x06002441 RID: 9281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002441")]
		[Address(RVA = "0x33850C0", Offset = "0x33836C0", VA = "0x1833850C0")]
		private void Update()
		{
		}

		// Token: 0x06002442 RID: 9282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002442")]
		[Address(RVA = "0x33851A0", Offset = "0x33837A0", VA = "0x1833851A0")]
		private void JoinLobby()
		{
		}

		// Token: 0x06002443 RID: 9283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002443")]
		[Address(RVA = "0x3385370", Offset = "0x3383970", VA = "0x183385370")]
		private void LeaveLobby()
		{
		}

		// Token: 0x06002444 RID: 9284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002444")]
		[Address(RVA = "0x3385430", Offset = "0x3383A30", VA = "0x183385430")]
		private void FakeServerStart()
		{
		}

		// Token: 0x06002445 RID: 9285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002445")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public LobbyListJoinLeaveTest()
		{
		}

		// Token: 0x0400208A RID: 8330
		[Token(Token = "0x400208A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<CoopLobby> _lobbies;

		// Token: 0x0400208B RID: 8331
		[Token(Token = "0x400208B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CoopLobby _activeLobby;

		// Token: 0x0400208C RID: 8332
		[Token(Token = "0x400208C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int _lobbyIndexToJoin;
	}
}
