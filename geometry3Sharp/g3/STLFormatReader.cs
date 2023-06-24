using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001A9 RID: 425
	[Token(Token = "0x20001A9")]
	public class STLFormatReader : MeshFormatReader
	{
		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000B7F RID: 2943 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000206")]
		public List<string> SupportedExtensions
		{
			[Token(Token = "0x6000B7F")]
			[Address(RVA = "0x2018510", Offset = "0x2016B10", VA = "0x182018510", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x00008624 File Offset: 0x00006824
		[Token(Token = "0x6000B80")]
		[Address(RVA = "0x20185F0", Offset = "0x2016BF0", VA = "0x1820185F0", Slot = "5")]
		public IOReadResult ReadFile(string sFilename, IMeshBuilder builder, ReadOptions options, ParsingMessagesHandler messages)
		{
			return default(IOReadResult);
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x0000863C File Offset: 0x0000683C
		[Token(Token = "0x6000B81")]
		[Address(RVA = "0x20187B0", Offset = "0x2016DB0", VA = "0x1820187B0", Slot = "6")]
		public IOReadResult ReadFile(Stream stream, IMeshBuilder builder, ReadOptions options, ParsingMessagesHandler messages)
		{
			return default(IOReadResult);
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B82")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public STLFormatReader()
		{
		}
	}
}
