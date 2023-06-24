using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Multiplayer.Utilities
{
	// Token: 0x0200057D RID: 1405
	[Token(Token = "0x200057D")]
	public class MultiplayerInstantiate : MonoBehaviour
	{
		// Token: 0x0600251A RID: 9498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600251A")]
		[Address(RVA = "0x3397930", Offset = "0x3395F30", VA = "0x183397930")]
		private void Start()
		{
		}

		// Token: 0x0600251B RID: 9499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600251B")]
		[Address(RVA = "0x3397CB0", Offset = "0x33962B0", VA = "0x183397CB0")]
		private GameObject SpawnInstance()
		{
			return null;
		}

		// Token: 0x0600251C RID: 9500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600251C")]
		[Address(RVA = "0x3397D10", Offset = "0x3396310", VA = "0x183397D10")]
		private GameObject SpawnMultiPlayer()
		{
			return null;
		}

		// Token: 0x0600251D RID: 9501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600251D")]
		[Address(RVA = "0x33980E0", Offset = "0x33966E0", VA = "0x1833980E0")]
		private GameObject SpawnSinglePlayer()
		{
			return null;
		}

		// Token: 0x0600251E RID: 9502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600251E")]
		[Address(RVA = "0x33982E0", Offset = "0x33968E0", VA = "0x1833982E0")]
		public MultiplayerInstantiate()
		{
		}

		// Token: 0x04002146 RID: 8518
		[Token(Token = "0x4002146")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("InMP")]
		private bool _inMultiplayer;

		// Token: 0x04002147 RID: 8519
		[Token(Token = "0x4002147")]
		[FieldOffset(Offset = "0x21")]
		[FormerlySerializedAs("InSP")]
		[SerializeField]
		private bool _inSinglePlayer;

		// Token: 0x04002148 RID: 8520
		[Token(Token = "0x4002148")]
		[FieldOffset(Offset = "0x22")]
		[FormerlySerializedAs("NotOnServer")]
		[SerializeField]
		private bool _notOnServer;

		// Token: 0x04002149 RID: 8521
		[Token(Token = "0x4002149")]
		[FieldOffset(Offset = "0x23")]
		[FormerlySerializedAs("NotOnClient")]
		[SerializeField]
		private bool _notOnClient;

		// Token: 0x0400214A RID: 8522
		[Token(Token = "0x400214A")]
		[FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("Prefab")]
		[SerializeField]
		private GameObject _prefabSource;

		// Token: 0x0400214B RID: 8523
		[Token(Token = "0x400214B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _overrideName;

		// Token: 0x0400214C RID: 8524
		[Token(Token = "0x400214C")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<int, int> _counts;
	}
}
