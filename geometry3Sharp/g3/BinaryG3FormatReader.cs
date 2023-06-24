using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001AB RID: 427
	[Token(Token = "0x20001AB")]
	public class BinaryG3FormatReader : MeshFormatReader
	{
		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000B87 RID: 2951 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000208")]
		public List<string> SupportedExtensions
		{
			[Token(Token = "0x6000B87")]
			[Address(RVA = "0x2019000", Offset = "0x2017600", VA = "0x182019000", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x00008684 File Offset: 0x00006884
		[Token(Token = "0x6000B88")]
		[Address(RVA = "0x20190E0", Offset = "0x20176E0", VA = "0x1820190E0", Slot = "5")]
		public IOReadResult ReadFile(string sFilename, IMeshBuilder builder, ReadOptions options, ParsingMessagesHandler messages)
		{
			return default(IOReadResult);
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x0000869C File Offset: 0x0000689C
		[Token(Token = "0x6000B89")]
		[Address(RVA = "0x20192F0", Offset = "0x20178F0", VA = "0x1820192F0", Slot = "6")]
		public IOReadResult ReadFile(Stream stream, IMeshBuilder builder, ReadOptions options, ParsingMessagesHandler messages)
		{
			return default(IOReadResult);
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B8A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public BinaryG3FormatReader()
		{
		}
	}
}
