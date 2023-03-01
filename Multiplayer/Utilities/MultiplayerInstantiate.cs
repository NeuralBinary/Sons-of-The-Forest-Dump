using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Multiplayer.Utilities
{
	// Token: 0x0200056D RID: 1389
	[Token(Token = "0x200056D")]
	public class MultiplayerInstantiate : MonoBehaviour
	{
		// Token: 0x0600241B RID: 9243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600241B")]
		[Address(RVA = "0x2D85C60", Offset = "0x2D84C60", VA = "0x182D85C60")]
		private void Start()
		{
		}

		// Token: 0x0600241C RID: 9244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600241C")]
		[Address(RVA = "0x2D85740", Offset = "0x2D84740", VA = "0x182D85740")]
		private GameObject SpawnInstance()
		{
			return null;
		}

		// Token: 0x0600241D RID: 9245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600241D")]
		[Address(RVA = "0x2D859D0", Offset = "0x2D849D0", VA = "0x182D859D0")]
		private GameObject SpawnMultiPlayer()
		{
			return null;
		}

		// Token: 0x0600241E RID: 9246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600241E")]
		[Address(RVA = "0x2D85B50", Offset = "0x2D84B50", VA = "0x182D85B50")]
		private GameObject SpawnSinglePlayer()
		{
			return null;
		}

		// Token: 0x0600241F RID: 9247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600241F")]
		[Address(RVA = "0x2D85EE0", Offset = "0x2D84EE0", VA = "0x182D85EE0")]
		public MultiplayerInstantiate()
		{
		}

		// Token: 0x04002072 RID: 8306
		[Token(Token = "0x4002072")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("InMP")]
		private bool _inMultiplayer;

		// Token: 0x04002073 RID: 8307
		[Token(Token = "0x4002073")]
		[FieldOffset(Offset = "0x21")]
		[SerializeField]
		[FormerlySerializedAs("InSP")]
		private bool _inSinglePlayer;

		// Token: 0x04002074 RID: 8308
		[Token(Token = "0x4002074")]
		[FieldOffset(Offset = "0x22")]
		[FormerlySerializedAs("NotOnServer")]
		[SerializeField]
		private bool _notOnServer;

		// Token: 0x04002075 RID: 8309
		[Token(Token = "0x4002075")]
		[FieldOffset(Offset = "0x23")]
		[FormerlySerializedAs("NotOnClient")]
		[SerializeField]
		private bool _notOnClient;

		// Token: 0x04002076 RID: 8310
		[Token(Token = "0x4002076")]
		[FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("Prefab")]
		[SerializeField]
		private GameObject _prefabSource;

		// Token: 0x04002077 RID: 8311
		[Token(Token = "0x4002077")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _overrideName;

		// Token: 0x04002078 RID: 8312
		[Token(Token = "0x4002078")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<int, int> _counts;
	}
}
