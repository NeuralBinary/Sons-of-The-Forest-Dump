using System;
using System.IO;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200018F RID: 399
	[Token(Token = "0x200018F")]
	public class BinaryG3Reader : IMeshReader
	{
		// Token: 0x06000ACC RID: 2764 RVA: 0x00008264 File Offset: 0x00006464
		[Token(Token = "0x6000ACC")]
		[Address(RVA = "0x2003FD0", Offset = "0x20025D0", VA = "0x182003FD0", Slot = "5")]
		public IOReadResult Read(BinaryReader reader, ReadOptions options, IMeshBuilder builder)
		{
			return default(IOReadResult);
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x0000827C File Offset: 0x0000647C
		[Token(Token = "0x6000ACD")]
		[Address(RVA = "0x20041A0", Offset = "0x20027A0", VA = "0x1820041A0", Slot = "4")]
		public IOReadResult Read(TextReader reader, ReadOptions options, IMeshBuilder builder)
		{
			return default(IOReadResult);
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000ACE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public BinaryG3Reader()
		{
		}
	}
}
