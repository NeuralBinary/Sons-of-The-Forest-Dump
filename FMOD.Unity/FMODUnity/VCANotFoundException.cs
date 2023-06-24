using System;
using Il2CppDummyDll;

namespace FMODUnity
{
	// Token: 0x020000F6 RID: 246
	[Token(Token = "0x20000F6")]
	public class VCANotFoundException : Exception
	{
		// Token: 0x06000674 RID: 1652 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000674")]
		[Address(RVA = "0xB50F30", Offset = "0xB4F530", VA = "0x180B50F30")]
		public VCANotFoundException(string path)
		{
		}

		// Token: 0x040004CF RID: 1231
		[Token(Token = "0x40004CF")]
		[FieldOffset(Offset = "0x90")]
		public string Path;
	}
}
