using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Tests
{
	// Token: 0x0200001D RID: 29
	[Token(Token = "0x200001D")]
	[Serializable]
	public class StartSinglePlayerTest : TestAction
	{
		// Token: 0x06000091 RID: 145 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x314F6A0", Offset = "0x314DCA0", VA = "0x18314F6A0")]
		public StartSinglePlayerTest()
		{
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x314F860", Offset = "0x314DE60", VA = "0x18314F860", Slot = "23")]
		public override IEnumerator RunWorker(string args)
		{
			return null;
		}

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private string _singlePlayerButtonSearch;

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x68")]
		private string _newGameButtonSearch;

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x70")]
		private string _normalModeSearch;
	}
}
