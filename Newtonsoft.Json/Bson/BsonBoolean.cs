using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Bson
{
	// Token: 0x020001DF RID: 479
	[Token(Token = "0x20001DF")]
	internal class BsonBoolean : BsonValue
	{
		// Token: 0x06001014 RID: 4116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001014")]
		[Address(RVA = "0x260D1A0", Offset = "0x260B7A0", VA = "0x18260D1A0")]
		private BsonBoolean(bool value)
		{
		}

		// Token: 0x0400085B RID: 2139
		[Token(Token = "0x400085B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly BsonBoolean False;

		// Token: 0x0400085C RID: 2140
		[Token(Token = "0x400085C")]
		[FieldOffset(Offset = "0x8")]
		public static readonly BsonBoolean True;
	}
}
