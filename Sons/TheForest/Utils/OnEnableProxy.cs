using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.Utils
{
	// Token: 0x020003C3 RID: 963
	[Token(Token = "0x20003C3")]
	public class OnEnableProxy : MonoBehaviour
	{
		// Token: 0x06001A60 RID: 6752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A60")]
		[Address(RVA = "0x329FF00", Offset = "0x329E500", VA = "0x18329FF00")]
		private void OnEnable()
		{
		}

		// Token: 0x06001A61 RID: 6753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A61")]
		[Address(RVA = "0x329FE10", Offset = "0x329E410", VA = "0x18329FE10")]
		private void SendMessageToTarget()
		{
		}

		// Token: 0x06001A62 RID: 6754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A62")]
		[Address(RVA = "0x329FF90", Offset = "0x329E590", VA = "0x18329FF90")]
		public OnEnableProxy()
		{
		}

		// Token: 0x0400198F RID: 6543
		[Token(Token = "0x400198F")]
		[FieldOffset(Offset = "0x20")]
		public MonoBehaviour _todo;

		// Token: 0x04001990 RID: 6544
		[Token(Token = "0x4001990")]
		[FieldOffset(Offset = "0x28")]
		public string _message;

		// Token: 0x04001991 RID: 6545
		[Token(Token = "0x4001991")]
		[FieldOffset(Offset = "0x30")]
		public float _delay;
	}
}
