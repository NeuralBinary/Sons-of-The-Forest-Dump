using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace TheForest.UI.Multiplayer
{
	// Token: 0x0200041B RID: 1051
	[Token(Token = "0x200041B")]
	public class ChatMessageRow : MonoBehaviour
	{
		// Token: 0x06001B5E RID: 7006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B5E")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public ChatMessageRow()
		{
		}

		// Token: 0x04001A9E RID: 6814
		[Token(Token = "0x4001A9E")]
		[FieldOffset(Offset = "0x20")]
		public TMP_Text _name;

		// Token: 0x04001A9F RID: 6815
		[Token(Token = "0x4001A9F")]
		[FieldOffset(Offset = "0x28")]
		public TMP_Text _message;
	}
}
