using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x02000152 RID: 338
	[Token(Token = "0x2000152")]
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	public enum UndefinedSchemaIdHandling
	{
		// Token: 0x04000653 RID: 1619
		[Token(Token = "0x4000653")]
		None,
		// Token: 0x04000654 RID: 1620
		[Token(Token = "0x4000654")]
		UseTypeName,
		// Token: 0x04000655 RID: 1621
		[Token(Token = "0x4000655")]
		UseAssemblyQualifiedName
	}
}
