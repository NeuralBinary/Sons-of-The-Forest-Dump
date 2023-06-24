using System;
using System.Collections.ObjectModel;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x0200014C RID: 332
	[Token(Token = "0x200014C")]
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	internal class JsonSchemaNodeCollection : KeyedCollection<string, JsonSchemaNode>
	{
		// Token: 0x06000AC6 RID: 2758 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AC6")]
		[Address(RVA = "0x7540A0", Offset = "0x7526A0", VA = "0x1807540A0", Slot = "39")]
		protected override string GetKeyForItem(JsonSchemaNode item)
		{
			return null;
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC7")]
		[Address(RVA = "0x25B1F60", Offset = "0x25B0560", VA = "0x1825B1F60")]
		public JsonSchemaNodeCollection()
		{
		}
	}
}
