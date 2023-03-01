using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.Tools
{
	// Token: 0x0200042B RID: 1067
	[Token(Token = "0x200042B")]
	public class SendMessageTo : MonoBehaviour
	{
		// Token: 0x06001B81 RID: 7041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B81")]
		[Address(RVA = "0x2CEC270", Offset = "0x2CEB270", VA = "0x182CEC270")]
		private void Start()
		{
		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B82")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public SendMessageTo()
		{
		}

		// Token: 0x04001AB7 RID: 6839
		[Token(Token = "0x4001AB7")]
		[FieldOffset(Offset = "0x20")]
		public GameObject _target;

		// Token: 0x04001AB8 RID: 6840
		[Token(Token = "0x4001AB8")]
		[FieldOffset(Offset = "0x28")]
		public string _message;
	}
}
