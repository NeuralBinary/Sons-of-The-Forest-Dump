using System;
using System.Collections;
using Il2CppDummyDll;

namespace Sons.Tests
{
	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	[Serializable]
	public class OpenCloseInventoryTest : TestAction
	{
		// Token: 0x06000041 RID: 65 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x314AE20", Offset = "0x3149420", VA = "0x18314AE20")]
		public OpenCloseInventoryTest()
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x314AEA0", Offset = "0x31494A0", VA = "0x18314AEA0", Slot = "23")]
		public override IEnumerator RunWorker(string args)
		{
			return null;
		}
	}
}
