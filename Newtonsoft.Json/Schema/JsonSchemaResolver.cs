using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x0200014D RID: 333
	[Token(Token = "0x200014D")]
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	public class JsonSchemaResolver
	{
		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000AC8 RID: 2760 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000AC9 RID: 2761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C7")]
		public IList<JsonSchema> LoadedSchemas
		{
			[Token(Token = "0x6000AC8")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AC9")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ACA")]
		[Address(RVA = "0x25B1FB0", Offset = "0x25B05B0", VA = "0x1825B1FB0")]
		public JsonSchemaResolver()
		{
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000ACB")]
		[Address(RVA = "0x25B2060", Offset = "0x25B0660", VA = "0x1825B2060", Slot = "4")]
		public virtual JsonSchema GetSchema(string reference)
		{
			return null;
		}
	}
}
