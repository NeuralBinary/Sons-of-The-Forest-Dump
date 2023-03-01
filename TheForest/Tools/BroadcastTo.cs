using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.Tools
{
	// Token: 0x0200041C RID: 1052
	[Token(Token = "0x200041C")]
	public class BroadcastTo : MonoBehaviour
	{
		// Token: 0x06001B5F RID: 7007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B5F")]
		[Address(RVA = "0x2CDDE00", Offset = "0x2CDCE00", VA = "0x182CDDE00")]
		public void Start()
		{
		}

		// Token: 0x06001B60 RID: 7008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B60")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public BroadcastTo()
		{
		}

		// Token: 0x04001AA0 RID: 6816
		[Token(Token = "0x4001AA0")]
		[FieldOffset(Offset = "0x20")]
		public GameObject _target;

		// Token: 0x04001AA1 RID: 6817
		[Token(Token = "0x4001AA1")]
		[FieldOffset(Offset = "0x28")]
		public string _message;
	}
}
