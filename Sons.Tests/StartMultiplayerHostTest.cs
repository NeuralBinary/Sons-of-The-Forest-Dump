using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Tests
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	[Serializable]
	public class StartMultiplayerHostTest : TestAction
	{
		// Token: 0x06000089 RID: 137 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x314F1D0", Offset = "0x314D7D0", VA = "0x18314F1D0")]
		public StartMultiplayerHostTest()
		{
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x314F420", Offset = "0x314DA20", VA = "0x18314F420", Slot = "23")]
		public override IEnumerator RunWorker(string args)
		{
			return null;
		}

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private string _multiplayerButtonSearch;

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private string _newGameButtonSearch;

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private string _startHostButtonSearch;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private string _hostButtonSearch;

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float _timeout;
	}
}
