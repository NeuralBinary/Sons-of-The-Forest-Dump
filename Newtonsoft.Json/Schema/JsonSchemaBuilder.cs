using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x02000141 RID: 321
	[Token(Token = "0x2000141")]
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	internal class JsonSchemaBuilder
	{
		// Token: 0x06000A43 RID: 2627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A43")]
		[Address(RVA = "0x25A7DC0", Offset = "0x25A63C0", VA = "0x1825A7DC0")]
		public JsonSchemaBuilder(JsonSchemaResolver resolver)
		{
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A44")]
		[Address(RVA = "0x25A7F80", Offset = "0x25A6580", VA = "0x1825A7F80")]
		private void Push(JsonSchema value)
		{
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A45")]
		[Address(RVA = "0x25A8070", Offset = "0x25A6670", VA = "0x1825A8070")]
		private JsonSchema Pop()
		{
			return null;
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000A46 RID: 2630 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170001A0")]
		private JsonSchema CurrentSchema
		{
			[Token(Token = "0x6000A46")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x25A8170", Offset = "0x25A6770", VA = "0x1825A8170")]
		internal JsonSchema Read(JsonReader reader)
		{
			return null;
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x25A82B0", Offset = "0x25A68B0", VA = "0x1825A82B0")]
		private string UnescapeReference(string reference)
		{
			return null;
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x25A8370", Offset = "0x25A6970", VA = "0x1825A8370")]
		private JsonSchema ResolveReferences(JsonSchema schema)
		{
			return null;
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x25A9120", Offset = "0x25A7720", VA = "0x1825A9120")]
		private JsonSchema BuildSchema(JToken token)
		{
			return null;
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0x25A9A30", Offset = "0x25A8030", VA = "0x1825A9A30")]
		private void ProcessSchemaProperties(JObject schemaObject)
		{
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x25AAD60", Offset = "0x25A9360", VA = "0x1825AAD60")]
		private void ProcessExtends(JToken token)
		{
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x25AB0C0", Offset = "0x25A96C0", VA = "0x1825AB0C0")]
		private void ProcessEnum(JToken token)
		{
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0x25AB4C0", Offset = "0x25A9AC0", VA = "0x1825AB4C0")]
		private void ProcessAdditionalProperties(JToken token)
		{
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0x25AB5E0", Offset = "0x25A9BE0", VA = "0x1825AB5E0")]
		private void ProcessAdditionalItems(JToken token)
		{
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A50")]
		[Address(RVA = "0x25AB700", Offset = "0x25A9D00", VA = "0x1825AB700")]
		private IDictionary<string, JsonSchema> ProcessProperties(JToken token)
		{
			return null;
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x25ABAC0", Offset = "0x25AA0C0", VA = "0x1825ABAC0")]
		private void ProcessItems(JToken token)
		{
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x00005580 File Offset: 0x00003780
		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x25ABEF0", Offset = "0x25AA4F0", VA = "0x1825ABEF0")]
		private JsonSchemaType? ProcessType(JToken token)
		{
			return null;
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x00005598 File Offset: 0x00003798
		[Token(Token = "0x6000A53")]
		[Address(RVA = "0x25AC2D0", Offset = "0x25AA8D0", VA = "0x1825AC2D0")]
		internal static JsonSchemaType MapType(string type)
		{
			return JsonSchemaType.None;
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A54")]
		[Address(RVA = "0x25AC460", Offset = "0x25AAA60", VA = "0x1825AC460")]
		internal static string MapType(JsonSchemaType type)
		{
			return null;
		}

		// Token: 0x040005EC RID: 1516
		[Token(Token = "0x40005EC")]
		[FieldOffset(Offset = "0x10")]
		private readonly IList<JsonSchema> _stack;

		// Token: 0x040005ED RID: 1517
		[Token(Token = "0x40005ED")]
		[FieldOffset(Offset = "0x18")]
		private readonly JsonSchemaResolver _resolver;

		// Token: 0x040005EE RID: 1518
		[Token(Token = "0x40005EE")]
		[FieldOffset(Offset = "0x20")]
		private readonly IDictionary<string, JsonSchema> _documentSchemas;

		// Token: 0x040005EF RID: 1519
		[Token(Token = "0x40005EF")]
		[FieldOffset(Offset = "0x28")]
		private JsonSchema _currentSchema;

		// Token: 0x040005F0 RID: 1520
		[Token(Token = "0x40005F0")]
		[FieldOffset(Offset = "0x30")]
		private JObject _rootSchema;
	}
}
