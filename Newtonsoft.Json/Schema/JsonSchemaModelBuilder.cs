using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x02000149 RID: 329
	[Token(Token = "0x2000149")]
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	internal class JsonSchemaModelBuilder
	{
		// Token: 0x06000AAC RID: 2732 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0x25AF7C0", Offset = "0x25ADDC0", VA = "0x1825AF7C0")]
		public JsonSchemaModel Build(JsonSchema schema)
		{
			return null;
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0x25AF9C0", Offset = "0x25ADFC0", VA = "0x1825AF9C0")]
		public JsonSchemaNode AddSchema(JsonSchemaNode existingNode, JsonSchema schema)
		{
			return null;
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AAE")]
		[Address(RVA = "0x25B00C0", Offset = "0x25AE6C0", VA = "0x1825B00C0")]
		public void AddProperties(IDictionary<string, JsonSchema> source, IDictionary<string, JsonSchemaNode> target)
		{
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AAF")]
		[Address(RVA = "0x25B03F0", Offset = "0x25AE9F0", VA = "0x1825B03F0")]
		public void AddProperty(IDictionary<string, JsonSchemaNode> target, string propertyName, JsonSchema schema)
		{
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AB0")]
		[Address(RVA = "0x25B0560", Offset = "0x25AEB60", VA = "0x1825B0560")]
		public void AddItem(JsonSchemaNode parentNode, int index, JsonSchema schema)
		{
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AB1")]
		[Address(RVA = "0x25B06B0", Offset = "0x25AECB0", VA = "0x1825B06B0")]
		public void AddAdditionalProperties(JsonSchemaNode parentNode, JsonSchema schema)
		{
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AB2")]
		[Address(RVA = "0x25B0730", Offset = "0x25AED30", VA = "0x1825B0730")]
		public void AddAdditionalItems(JsonSchemaNode parentNode, JsonSchema schema)
		{
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000AB3")]
		[Address(RVA = "0x25B07B0", Offset = "0x25AEDB0", VA = "0x1825B07B0")]
		private JsonSchemaModel BuildNodeModel(JsonSchemaNode node)
		{
			return null;
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AB4")]
		[Address(RVA = "0x25B10B0", Offset = "0x25AF6B0", VA = "0x1825B10B0")]
		public JsonSchemaModelBuilder()
		{
		}

		// Token: 0x04000635 RID: 1589
		[Token(Token = "0x4000635")]
		[FieldOffset(Offset = "0x10")]
		private JsonSchemaNodeCollection _nodes;

		// Token: 0x04000636 RID: 1590
		[Token(Token = "0x4000636")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<JsonSchemaNode, JsonSchemaModel> _nodeModels;

		// Token: 0x04000637 RID: 1591
		[Token(Token = "0x4000637")]
		[FieldOffset(Offset = "0x20")]
		private JsonSchemaNode _node;
	}
}
