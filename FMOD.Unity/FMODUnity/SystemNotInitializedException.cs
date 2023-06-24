using System;
using FMOD;
using Il2CppDummyDll;

namespace FMODUnity
{
	// Token: 0x020000F8 RID: 248
	[Token(Token = "0x20000F8")]
	public class SystemNotInitializedException : Exception
	{
		// Token: 0x06000677 RID: 1655 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000677")]
		[Address(RVA = "0xB51240", Offset = "0xB4F840", VA = "0x180B51240")]
		public SystemNotInitializedException(RESULT result, string location)
		{
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000678")]
		[Address(RVA = "0xB51370", Offset = "0xB4F970", VA = "0x180B51370")]
		public SystemNotInitializedException(Exception inner)
		{
		}

		// Token: 0x040004D2 RID: 1234
		[Token(Token = "0x40004D2")]
		[FieldOffset(Offset = "0x90")]
		public RESULT Result;

		// Token: 0x040004D3 RID: 1235
		[Token(Token = "0x40004D3")]
		[FieldOffset(Offset = "0x98")]
		public string Location;
	}
}
