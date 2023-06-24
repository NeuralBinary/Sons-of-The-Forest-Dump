using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x02000150 RID: 336
	[Token(Token = "0x2000150")]
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	internal class JsonSchemaWriter
	{
		// Token: 0x06000ACF RID: 2767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ACF")]
		[Address(RVA = "0x25B2330", Offset = "0x25B0930", VA = "0x1825B2330")]
		public JsonSchemaWriter(JsonWriter writer, JsonSchemaResolver resolver)
		{
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD0")]
		[Address(RVA = "0x25B2470", Offset = "0x25B0A70", VA = "0x1825B2470")]
		private void ReferenceOrWriteSchema(JsonSchema schema)
		{
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD1")]
		[Address(RVA = "0x25B2580", Offset = "0x25B0B80", VA = "0x1825B2580")]
		public void WriteSchema(JsonSchema schema)
		{
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD2")]
		[Address(RVA = "0x25B3690", Offset = "0x25B1C90", VA = "0x1825B3690")]
		private void WriteSchemaDictionaryIfNotNull(JsonWriter writer, string propertyName, IDictionary<string, JsonSchema> properties)
		{
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD3")]
		[Address(RVA = "0x25B38F0", Offset = "0x25B1EF0", VA = "0x1825B38F0")]
		private void WriteItems(JsonSchema schema)
		{
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD4")]
		[Address(RVA = "0x25B3B80", Offset = "0x25B2180", VA = "0x1825B3B80")]
		private void WriteType(string propertyName, JsonWriter writer, JsonSchemaType type)
		{
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD5")]
		[Address(RVA = "0x25B4100", Offset = "0x25B2700", VA = "0x1825B4100")]
		private void WritePropertyIfNotNull(JsonWriter writer, string propertyName, object value)
		{
		}

		// Token: 0x0400064E RID: 1614
		[Token(Token = "0x400064E")]
		[FieldOffset(Offset = "0x10")]
		private readonly JsonWriter _writer;

		// Token: 0x0400064F RID: 1615
		[Token(Token = "0x400064F")]
		[FieldOffset(Offset = "0x18")]
		private readonly JsonSchemaResolver _resolver;
	}
}
