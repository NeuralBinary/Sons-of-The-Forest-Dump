using System;
using Il2CppDummyDll;

namespace LitJson
{
	// Token: 0x0200001D RID: 29
	[Token(Token = "0x200001D")]
	internal enum ParserToken
	{
		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		None = 65536,
		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		Number,
		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		True,
		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		False,
		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		Null,
		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		CharSeq,
		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		Char,
		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		Text,
		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		Object,
		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		ObjectPrime,
		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		Pair,
		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		PairRest,
		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		Array,
		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		ArrayPrime,
		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		Value,
		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		ValueRest,
		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		String,
		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		End,
		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		Epsilon
	}
}
