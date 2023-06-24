using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020001E4 RID: 484
	[Token(Token = "0x20001E4")]
	internal enum BsonType : sbyte
	{
		// Token: 0x04000865 RID: 2149
		[Token(Token = "0x4000865")]
		Number = 1,
		// Token: 0x04000866 RID: 2150
		[Token(Token = "0x4000866")]
		String,
		// Token: 0x04000867 RID: 2151
		[Token(Token = "0x4000867")]
		Object,
		// Token: 0x04000868 RID: 2152
		[Token(Token = "0x4000868")]
		Array,
		// Token: 0x04000869 RID: 2153
		[Token(Token = "0x4000869")]
		Binary,
		// Token: 0x0400086A RID: 2154
		[Token(Token = "0x400086A")]
		Undefined,
		// Token: 0x0400086B RID: 2155
		[Token(Token = "0x400086B")]
		Oid,
		// Token: 0x0400086C RID: 2156
		[Token(Token = "0x400086C")]
		Boolean,
		// Token: 0x0400086D RID: 2157
		[Token(Token = "0x400086D")]
		Date,
		// Token: 0x0400086E RID: 2158
		[Token(Token = "0x400086E")]
		Null,
		// Token: 0x0400086F RID: 2159
		[Token(Token = "0x400086F")]
		Regex,
		// Token: 0x04000870 RID: 2160
		[Token(Token = "0x4000870")]
		Reference,
		// Token: 0x04000871 RID: 2161
		[Token(Token = "0x4000871")]
		Code,
		// Token: 0x04000872 RID: 2162
		[Token(Token = "0x4000872")]
		Symbol,
		// Token: 0x04000873 RID: 2163
		[Token(Token = "0x4000873")]
		CodeWScope,
		// Token: 0x04000874 RID: 2164
		[Token(Token = "0x4000874")]
		Integer,
		// Token: 0x04000875 RID: 2165
		[Token(Token = "0x4000875")]
		TimeStamp,
		// Token: 0x04000876 RID: 2166
		[Token(Token = "0x4000876")]
		Long,
		// Token: 0x04000877 RID: 2167
		[Token(Token = "0x4000877")]
		MinKey = -1,
		// Token: 0x04000878 RID: 2168
		[Token(Token = "0x4000878")]
		MaxKey = 127
	}
}
