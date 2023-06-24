using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.Tools
{
	// Token: 0x0200041D RID: 1053
	[Token(Token = "0x200041D")]
	public class SendMessageTo : MonoBehaviour
	{
		// Token: 0x06001BBF RID: 7103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BBF")]
		[Address(RVA = "0x32BC0E0", Offset = "0x32BA6E0", VA = "0x1832BC0E0")]
		private void Start()
		{
		}

		// Token: 0x06001BC0 RID: 7104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BC0")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public SendMessageTo()
		{
		}

		// Token: 0x04001ADB RID: 6875
		[Token(Token = "0x4001ADB")]
		[FieldOffset(Offset = "0x20")]
		public GameObject _target;

		// Token: 0x04001ADC RID: 6876
		[Token(Token = "0x4001ADC")]
		[FieldOffset(Offset = "0x28")]
		public string _message;
	}
}
