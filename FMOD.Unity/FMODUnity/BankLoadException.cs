using System;
using FMOD;
using Il2CppDummyDll;

namespace FMODUnity
{
	// Token: 0x020000F7 RID: 247
	[Token(Token = "0x20000F7")]
	public class BankLoadException : Exception
	{
		// Token: 0x06000675 RID: 1653 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000675")]
		[Address(RVA = "0xB51020", Offset = "0xB4F620", VA = "0x180B51020")]
		public BankLoadException(string path, RESULT result)
		{
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000676")]
		[Address(RVA = "0xB51150", Offset = "0xB4F750", VA = "0x180B51150")]
		public BankLoadException(string path, string error)
		{
		}

		// Token: 0x040004D0 RID: 1232
		[Token(Token = "0x40004D0")]
		[FieldOffset(Offset = "0x90")]
		public string Path;

		// Token: 0x040004D1 RID: 1233
		[Token(Token = "0x40004D1")]
		[FieldOffset(Offset = "0x98")]
		public RESULT Result;
	}
}
