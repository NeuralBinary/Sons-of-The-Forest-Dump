using System;
using System.Collections;
using Il2CppDummyDll;

namespace Sons.Tests
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	[Serializable]
	public class MultiplayerHostFullTest : TestAction
	{
		// Token: 0x06000038 RID: 56 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x314A9D0", Offset = "0x3148FD0", VA = "0x18314A9D0")]
		public static string GetHostServerName()
		{
			return null;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x314AA50", Offset = "0x3149050", VA = "0x18314AA50")]
		public MultiplayerHostFullTest()
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x314AAD0", Offset = "0x31490D0", VA = "0x18314AAD0", Slot = "23")]
		public override IEnumerator RunWorker(string args)
		{
			return null;
		}

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		public const string TestHostServerName = "TESTHOST_AA";
	}
}
