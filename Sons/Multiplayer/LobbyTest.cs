using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Multiplayer
{
	// Token: 0x0200053F RID: 1343
	[Token(Token = "0x200053F")]
	public class LobbyTest : MonoBehaviour
	{
		// Token: 0x060023A5 RID: 9125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A5")]
		[Address(RVA = "0x3352BD0", Offset = "0x33511D0", VA = "0x183352BD0")]
		private void FindLobby()
		{
		}

		// Token: 0x060023A6 RID: 9126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A6")]
		[Address(RVA = "0x3352E10", Offset = "0x3351410", VA = "0x183352E10")]
		private void Join()
		{
		}

		// Token: 0x060023A7 RID: 9127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A7")]
		[Address(RVA = "0x3352F60", Offset = "0x3351560", VA = "0x183352F60")]
		private void OnSuccessEnterLobby()
		{
		}

		// Token: 0x060023A8 RID: 9128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void OnFailedEnterLobby(string obj)
		{
		}

		// Token: 0x060023A9 RID: 9129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A9")]
		[Address(RVA = "0x3352F90", Offset = "0x3351590", VA = "0x183352F90")]
		private void Update()
		{
		}

		// Token: 0x060023AA RID: 9130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023AA")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public LobbyTest()
		{
		}

		// Token: 0x04002020 RID: 8224
		[Token(Token = "0x4002020")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _lobbyGuid;

		// Token: 0x04002021 RID: 8225
		[Token(Token = "0x4002021")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _lobbyIdInt;

		// Token: 0x04002022 RID: 8226
		[Token(Token = "0x4002022")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CoopLobby _targetLobby;

		// Token: 0x04002023 RID: 8227
		[Token(Token = "0x4002023")]
		[FieldOffset(Offset = "0x38")]
		private bool _inLobby;
	}
}
