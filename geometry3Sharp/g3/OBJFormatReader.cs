using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001A8 RID: 424
	[Token(Token = "0x20001A8")]
	public class OBJFormatReader : MeshFormatReader
	{
		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000B7B RID: 2939 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000205")]
		public List<string> SupportedExtensions
		{
			[Token(Token = "0x6000B7B")]
			[Address(RVA = "0x2018000", Offset = "0x2016600", VA = "0x182018000", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x000085F4 File Offset: 0x000067F4
		[Token(Token = "0x6000B7C")]
		[Address(RVA = "0x20180E0", Offset = "0x20166E0", VA = "0x1820180E0", Slot = "5")]
		public IOReadResult ReadFile(string sFilename, IMeshBuilder builder, ReadOptions options, ParsingMessagesHandler messages)
		{
			return default(IOReadResult);
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x0000860C File Offset: 0x0000680C
		[Token(Token = "0x6000B7D")]
		[Address(RVA = "0x2018400", Offset = "0x2016A00", VA = "0x182018400", Slot = "6")]
		public IOReadResult ReadFile(Stream stream, IMeshBuilder builder, ReadOptions options, ParsingMessagesHandler messages)
		{
			return default(IOReadResult);
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B7E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public OBJFormatReader()
		{
		}
	}
}
