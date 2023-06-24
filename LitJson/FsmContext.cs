using System;
using Il2CppDummyDll;

namespace LitJson
{
	// Token: 0x0200001A RID: 26
	[Token(Token = "0x200001A")]
	internal class FsmContext
	{
		// Token: 0x06000112 RID: 274 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public FsmContext()
		{
		}

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x10")]
		public bool Return;

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x14")]
		public int NextState;

		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x18")]
		public Lexer L;

		// Token: 0x04000083 RID: 131
		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x20")]
		public int StateStack;
	}
}
