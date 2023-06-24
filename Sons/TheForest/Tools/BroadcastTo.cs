using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.Tools
{
	// Token: 0x0200040E RID: 1038
	[Token(Token = "0x200040E")]
	public class BroadcastTo : MonoBehaviour
	{
		// Token: 0x06001B9D RID: 7069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B9D")]
		[Address(RVA = "0x32BAE90", Offset = "0x32B9490", VA = "0x1832BAE90")]
		public void Start()
		{
		}

		// Token: 0x06001B9E RID: 7070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B9E")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public BroadcastTo()
		{
		}

		// Token: 0x04001AC4 RID: 6852
		[Token(Token = "0x4001AC4")]
		[FieldOffset(Offset = "0x20")]
		public GameObject _target;

		// Token: 0x04001AC5 RID: 6853
		[Token(Token = "0x4001AC5")]
		[FieldOffset(Offset = "0x28")]
		public string _message;
	}
}
