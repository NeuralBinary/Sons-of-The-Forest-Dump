using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001AA RID: 426
	[Token(Token = "0x20001AA")]
	public class OFFFormatReader : MeshFormatReader
	{
		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000B83 RID: 2947 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000207")]
		public List<string> SupportedExtensions
		{
			[Token(Token = "0x6000B83")]
			[Address(RVA = "0x2018B10", Offset = "0x2017110", VA = "0x182018B10", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x00008654 File Offset: 0x00006854
		[Token(Token = "0x6000B84")]
		[Address(RVA = "0x2018BF0", Offset = "0x20171F0", VA = "0x182018BF0", Slot = "5")]
		public IOReadResult ReadFile(string sFilename, IMeshBuilder builder, ReadOptions options, ParsingMessagesHandler messages)
		{
			return default(IOReadResult);
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x0000866C File Offset: 0x0000686C
		[Token(Token = "0x6000B85")]
		[Address(RVA = "0x2018DB0", Offset = "0x20173B0", VA = "0x182018DB0", Slot = "6")]
		public IOReadResult ReadFile(Stream stream, IMeshBuilder builder, ReadOptions options, ParsingMessagesHandler messages)
		{
			return default(IOReadResult);
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B86")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public OFFFormatReader()
		{
		}
	}
}
