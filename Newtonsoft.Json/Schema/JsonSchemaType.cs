using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x0200014F RID: 335
	[Token(Token = "0x200014F")]
	[Flags]
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	public enum JsonSchemaType
	{
		// Token: 0x04000645 RID: 1605
		[Token(Token = "0x4000645")]
		None = 0,
		// Token: 0x04000646 RID: 1606
		[Token(Token = "0x4000646")]
		String = 1,
		// Token: 0x04000647 RID: 1607
		[Token(Token = "0x4000647")]
		Float = 2,
		// Token: 0x04000648 RID: 1608
		[Token(Token = "0x4000648")]
		Integer = 4,
		// Token: 0x04000649 RID: 1609
		[Token(Token = "0x4000649")]
		Boolean = 8,
		// Token: 0x0400064A RID: 1610
		[Token(Token = "0x400064A")]
		Object = 16,
		// Token: 0x0400064B RID: 1611
		[Token(Token = "0x400064B")]
		Array = 32,
		// Token: 0x0400064C RID: 1612
		[Token(Token = "0x400064C")]
		Null = 64,
		// Token: 0x0400064D RID: 1613
		[Token(Token = "0x400064D")]
		Any = 127
	}
}
