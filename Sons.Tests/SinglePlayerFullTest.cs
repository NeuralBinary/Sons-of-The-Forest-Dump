using System;
using System.Collections;
using Il2CppDummyDll;

namespace Sons.Tests
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	[Serializable]
	public class SinglePlayerFullTest : TestAction
	{
		// Token: 0x06000081 RID: 129 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x314EE80", Offset = "0x314D480", VA = "0x18314EE80")]
		public SinglePlayerFullTest()
		{
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x314EF00", Offset = "0x314D500", VA = "0x18314EF00", Slot = "23")]
		public override IEnumerator RunWorker(string args)
		{
			return null;
		}
	}
}
