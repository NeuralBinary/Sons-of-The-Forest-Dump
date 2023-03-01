using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Multiplayer
{
	// Token: 0x02000536 RID: 1334
	[Token(Token = "0x2000536")]
	public class LobbyTest : MonoBehaviour
	{
		// Token: 0x060022B1 RID: 8881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022B1")]
		[Address(RVA = "0x2D5EEE0", Offset = "0x2D5DEE0", VA = "0x182D5EEE0")]
		private void FindLobby()
		{
		}

		// Token: 0x060022B2 RID: 8882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022B2")]
		[Address(RVA = "0x2D5F010", Offset = "0x2D5E010", VA = "0x182D5F010")]
		private void Join()
		{
		}

		// Token: 0x060022B3 RID: 8883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022B3")]
		[Address(RVA = "0x2D5F120", Offset = "0x2D5E120", VA = "0x182D5F120")]
		private void OnSuccessEnterLobby()
		{
		}

		// Token: 0x060022B4 RID: 8884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022B4")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		private void OnFailedEnterLobby(string obj)
		{
		}

		// Token: 0x060022B5 RID: 8885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022B5")]
		[Address(RVA = "0x2D5F150", Offset = "0x2D5E150", VA = "0x182D5F150")]
		private void Update()
		{
		}

		// Token: 0x060022B6 RID: 8886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022B6")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public LobbyTest()
		{
		}

		// Token: 0x04001F6B RID: 8043
		[Token(Token = "0x4001F6B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _lobbyGuid;

		// Token: 0x04001F6C RID: 8044
		[Token(Token = "0x4001F6C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _lobbyIdInt;

		// Token: 0x04001F6D RID: 8045
		[Token(Token = "0x4001F6D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CoopLobby _targetLobby;

		// Token: 0x04001F6E RID: 8046
		[Token(Token = "0x4001F6E")]
		[FieldOffset(Offset = "0x38")]
		private bool _inLobby;
	}
}
