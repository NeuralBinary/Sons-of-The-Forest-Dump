using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Tests
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	[Serializable]
	public class MultiplayerClientFullTest : TestAction
	{
		// Token: 0x0600002F RID: 47 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x314A6B0", Offset = "0x3148CB0", VA = "0x18314A6B0")]
		private static string GetHostServerName()
		{
			return null;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x314A6C0", Offset = "0x3148CC0", VA = "0x18314A6C0")]
		public MultiplayerClientFullTest()
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x314A8E0", Offset = "0x3148EE0", VA = "0x18314A8E0", Slot = "23")]
		public override IEnumerator RunWorker(string args)
		{
			return null;
		}

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private string _multiplayerButtonSearch;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private string _joinButtonSearch;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private string _refreshButtonSearch;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private string _multiplayerMenuSceneName;
	}
}
