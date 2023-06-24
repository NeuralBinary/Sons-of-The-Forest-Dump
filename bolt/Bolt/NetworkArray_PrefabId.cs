using System;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x02000092 RID: 146
	[Token(Token = "0x2000092")]
	[Documentation]
	public class NetworkArray_PrefabId : NetworkArray_Values<PrefabId>
	{
		// Token: 0x060004F8 RID: 1272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x8EB070", Offset = "0x8E9670", VA = "0x1808EB070")]
		internal NetworkArray_PrefabId(int length, int stride)
		{
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x000038E8 File Offset: 0x00001AE8
		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x8EB150", Offset = "0x8E9750", VA = "0x1808EB150", Slot = "7")]
		protected override PrefabId GetValue(int index)
		{
			return default(PrefabId);
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00003900 File Offset: 0x00001B00
		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x8EB1A0", Offset = "0x8E97A0", VA = "0x1808EB1A0", Slot = "8")]
		protected override bool SetValue(int index, PrefabId value)
		{
			return default(bool);
		}
	}
}
