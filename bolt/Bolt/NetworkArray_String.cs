using System;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x02000095 RID: 149
	[Token(Token = "0x2000095")]
	[Documentation]
	public class NetworkArray_String : NetworkArray_Values<string>
	{
		// Token: 0x06000501 RID: 1281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000501")]
		[Address(RVA = "0x8EB730", Offset = "0x8E9D30", VA = "0x1808EB730")]
		internal NetworkArray_String(int length, int stride)
		{
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000502")]
		[Address(RVA = "0x8EB790", Offset = "0x8E9D90", VA = "0x1808EB790", Slot = "7")]
		protected override string GetValue(int index)
		{
			return null;
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00003960 File Offset: 0x00001B60
		[Token(Token = "0x6000503")]
		[Address(RVA = "0x8EB820", Offset = "0x8E9E20", VA = "0x1808EB820", Slot = "8")]
		protected override bool SetValue(int index, string value)
		{
			return default(bool);
		}
	}
}
