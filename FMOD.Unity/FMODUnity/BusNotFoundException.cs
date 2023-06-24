using System;
using Il2CppDummyDll;

namespace FMODUnity
{
	// Token: 0x020000F5 RID: 245
	[Token(Token = "0x20000F5")]
	public class BusNotFoundException : Exception
	{
		// Token: 0x06000673 RID: 1651 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000673")]
		[Address(RVA = "0xB50E40", Offset = "0xB4F440", VA = "0x180B50E40")]
		public BusNotFoundException(string path)
		{
		}

		// Token: 0x040004CE RID: 1230
		[Token(Token = "0x40004CE")]
		[FieldOffset(Offset = "0x90")]
		public string Path;
	}
}
