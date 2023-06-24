using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001B3 RID: 435
	[Token(Token = "0x20001B3")]
	[Serializable]
	public struct SteamDatagramHostedAddress
	{
		// Token: 0x060009F7 RID: 2551 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009F7")]
		[Address(RVA = "0x98A770", Offset = "0x988D70", VA = "0x18098A770")]
		public void Clear()
		{
		}

		// Token: 0x04000A6F RID: 2671
		[Token(Token = "0x4000A6F")]
		[FieldOffset(Offset = "0x0")]
		public int m_cbSize;

		// Token: 0x04000A70 RID: 2672
		[Token(Token = "0x4000A70")]
		[FieldOffset(Offset = "0x8")]
		public byte[] m_data;
	}
}
