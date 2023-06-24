using System;
using Il2CppDummyDll;

namespace LitJson
{
	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	internal class WriterContext
	{
		// Token: 0x060000EF RID: 239 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public WriterContext()
		{
		}

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x10")]
		public int Count;

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x14")]
		public bool InArray;

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x15")]
		public bool InObject;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x16")]
		public bool ExpectingValue;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x18")]
		public int Padding;
	}
}
