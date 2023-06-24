using System;
using Il2CppDummyDll;
using Steamworks;
using UnityEngine;
using UnityEngine.Events;

namespace Sons.Multiplayer
{
	// Token: 0x02000021 RID: 33
	[Token(Token = "0x2000021")]
	public class CoopSteamCallbacks : MonoBehaviour
	{
		// Token: 0x06000108 RID: 264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x30E0FD0", Offset = "0x30DF5D0", VA = "0x1830E0FD0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x30E11E0", Offset = "0x30DF7E0", VA = "0x1830E11E0")]
		private void OnDisable()
		{
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x30E1270", Offset = "0x30DF870", VA = "0x1830E1270")]
		private void GameOverlayActivated(GameOverlayActivated_t param)
		{
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public CoopSteamCallbacks()
		{
		}

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UnityEvent<bool> _gameOverlayActivated;

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x28")]
		private Callback<GameOverlayActivated_t> _gameOverlayActivatedCallback;
	}
}
