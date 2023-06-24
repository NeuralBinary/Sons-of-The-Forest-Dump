using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001A3 RID: 419
	[Token(Token = "0x20001A3")]
	internal class OFFReader : IMeshReader
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000B5D RID: 2909 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x06000B5E RID: 2910 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x14000002")]
		public event ParsingMessagesHandler warningEvent
		{
			[Token(Token = "0x6000B5D")]
			[Address(RVA = "0x2014AF0", Offset = "0x20130F0", VA = "0x182014AF0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000B5E")]
			[Address(RVA = "0x2014BE0", Offset = "0x20131E0", VA = "0x182014BE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x0000851C File Offset: 0x0000671C
		[Token(Token = "0x6000B5F")]
		[Address(RVA = "0x2014CD0", Offset = "0x20132D0", VA = "0x182014CD0", Slot = "5")]
		public IOReadResult Read(BinaryReader reader, ReadOptions options, IMeshBuilder builder)
		{
			return default(IOReadResult);
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x00008534 File Offset: 0x00006734
		[Token(Token = "0x6000B60")]
		[Address(RVA = "0x2014D20", Offset = "0x2013320", VA = "0x182014D20", Slot = "4")]
		public IOReadResult Read(TextReader reader, ReadOptions options, IMeshBuilder builder)
		{
			return default(IOReadResult);
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B61")]
		[Address(RVA = "0x2015480", Offset = "0x2013A80", VA = "0x182015480")]
		private void emit_warning(string sMessage)
		{
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B62")]
		[Address(RVA = "0x20155E0", Offset = "0x2013BE0", VA = "0x1820155E0")]
		public OFFReader()
		{
		}

		// Token: 0x040006A2 RID: 1698
		[Token(Token = "0x40006A2")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, int> warningCount;
	}
}
