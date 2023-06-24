using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020001D4 RID: 468
	[Token(Token = "0x20001D4")]
	internal enum BsonBinaryType : byte
	{
		// Token: 0x0400082A RID: 2090
		[Token(Token = "0x400082A")]
		Binary,
		// Token: 0x0400082B RID: 2091
		[Token(Token = "0x400082B")]
		Function,
		// Token: 0x0400082C RID: 2092
		[Token(Token = "0x400082C")]
		[Obsolete("This type has been deprecated in the BSON specification. Use Binary instead.")]
		BinaryOld,
		// Token: 0x0400082D RID: 2093
		[Token(Token = "0x400082D")]
		[Obsolete("This type has been deprecated in the BSON specification. Use Uuid instead.")]
		UuidOld,
		// Token: 0x0400082E RID: 2094
		[Token(Token = "0x400082E")]
		Uuid,
		// Token: 0x0400082F RID: 2095
		[Token(Token = "0x400082F")]
		Md5,
		// Token: 0x04000830 RID: 2096
		[Token(Token = "0x4000830")]
		UserDefined = 128
	}
}
