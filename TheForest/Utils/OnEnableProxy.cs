using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.Utils
{
	// Token: 0x020003D1 RID: 977
	[Token(Token = "0x20003D1")]
	public class OnEnableProxy : MonoBehaviour
	{
		// Token: 0x06001A1F RID: 6687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A1F")]
		[Address(RVA = "0x2CE74C0", Offset = "0x2CE64C0", VA = "0x182CE74C0")]
		private void OnEnable()
		{
		}

		// Token: 0x06001A20 RID: 6688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A20")]
		[Address(RVA = "0x2CE7440", Offset = "0x2CE6440", VA = "0x182CE7440")]
		private void SendMessageToTarget()
		{
		}

		// Token: 0x06001A21 RID: 6689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A21")]
		[Address(RVA = "0x2CE7540", Offset = "0x2CE6540", VA = "0x182CE7540")]
		public OnEnableProxy()
		{
		}

		// Token: 0x0400196B RID: 6507
		[Token(Token = "0x400196B")]
		[FieldOffset(Offset = "0x20")]
		public MonoBehaviour _todo;

		// Token: 0x0400196C RID: 6508
		[Token(Token = "0x400196C")]
		[FieldOffset(Offset = "0x28")]
		public string _message;

		// Token: 0x0400196D RID: 6509
		[Token(Token = "0x400196D")]
		[FieldOffset(Offset = "0x30")]
		public float _delay;
	}
}
