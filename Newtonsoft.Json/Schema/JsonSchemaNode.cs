using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x0200014A RID: 330
	[Token(Token = "0x200014A")]
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	internal class JsonSchemaNode
	{
		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170001C0")]
		public string Id
		{
			[Token(Token = "0x6000AB5")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000AB6 RID: 2742 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170001C1")]
		public ReadOnlyCollection<JsonSchema> Schemas
		{
			[Token(Token = "0x6000AB6")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170001C2")]
		public Dictionary<string, JsonSchemaNode> Properties
		{
			[Token(Token = "0x6000AB7")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000AB8 RID: 2744 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170001C3")]
		public Dictionary<string, JsonSchemaNode> PatternProperties
		{
			[Token(Token = "0x6000AB8")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170001C4")]
		public List<JsonSchemaNode> Items
		{
			[Token(Token = "0x6000AB9")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000ABA RID: 2746 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000ABB RID: 2747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C5")]
		public JsonSchemaNode AdditionalProperties
		{
			[Token(Token = "0x6000ABA")]
			[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000ABB")]
			[Address(RVA = "0x5B2F00", Offset = "0x5B1500", VA = "0x1805B2F00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000ABC RID: 2748 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000ABD RID: 2749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C6")]
		public JsonSchemaNode AdditionalItems
		{
			[Token(Token = "0x6000ABC")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000ABD")]
			[Address(RVA = "0x5B2560", Offset = "0x5B0B60", VA = "0x1805B2560")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ABE")]
		[Address(RVA = "0x25B1220", Offset = "0x25AF820", VA = "0x1825B1220")]
		public JsonSchemaNode(JsonSchema schema)
		{
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ABF")]
		[Address(RVA = "0x25B15E0", Offset = "0x25AFBE0", VA = "0x1825B15E0")]
		private JsonSchemaNode(JsonSchemaNode source, JsonSchema schema)
		{
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AC0")]
		[Address(RVA = "0x25B1B10", Offset = "0x25B0110", VA = "0x1825B1B10")]
		public JsonSchemaNode Combine(JsonSchema schema)
		{
			return null;
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AC1")]
		[Address(RVA = "0x25B1B80", Offset = "0x25B0180", VA = "0x1825B1B80")]
		public static string GetId(IEnumerable<JsonSchema> schemata)
		{
			return null;
		}
	}
}
