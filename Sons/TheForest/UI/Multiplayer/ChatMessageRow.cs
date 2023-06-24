using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace TheForest.UI.Multiplayer
{
	// Token: 0x0200040D RID: 1037
	[Token(Token = "0x200040D")]
	public class ChatMessageRow : MonoBehaviour
	{
		// Token: 0x06001B9C RID: 7068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B9C")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ChatMessageRow()
		{
		}

		// Token: 0x04001AC2 RID: 6850
		[Token(Token = "0x4001AC2")]
		[FieldOffset(Offset = "0x20")]
		public TMP_Text _name;

		// Token: 0x04001AC3 RID: 6851
		[Token(Token = "0x4001AC3")]
		[FieldOffset(Offset = "0x28")]
		public TMP_Text _message;
	}
}
