using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x02000145 RID: 325
	[Token(Token = "0x2000145")]
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	public class JsonSchemaGenerator
	{
		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000A60 RID: 2656 RVA: 0x000055F8 File Offset: 0x000037F8
		// (set) Token: 0x06000A61 RID: 2657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001A4")]
		public UndefinedSchemaIdHandling UndefinedSchemaIdHandling
		{
			[Token(Token = "0x6000A60")]
			[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
			[CompilerGenerated]
			get
			{
				return UndefinedSchemaIdHandling.None;
			}
			[Token(Token = "0x6000A61")]
			[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000A62 RID: 2658 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000A63 RID: 2659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001A5")]
		public IContractResolver ContractResolver
		{
			[Token(Token = "0x6000A62")]
			[Address(RVA = "0x25AC980", Offset = "0x25AAF80", VA = "0x1825AC980")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A63")]
			[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
			set
			{
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000A64 RID: 2660 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170001A6")]
		private JsonSchema CurrentSchema
		{
			[Token(Token = "0x6000A64")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A65")]
		[Address(RVA = "0x25ACA10", Offset = "0x25AB010", VA = "0x1825ACA10")]
		private void Push(JsonSchemaGenerator.TypeSchema typeSchema)
		{
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A66")]
		[Address(RVA = "0x25ACB50", Offset = "0x25AB150", VA = "0x1825ACB50")]
		private JsonSchemaGenerator.TypeSchema Pop()
		{
			return null;
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A67")]
		[Address(RVA = "0x25ACD60", Offset = "0x25AB360", VA = "0x1825ACD60")]
		public JsonSchema Generate(Type type)
		{
			return null;
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A68")]
		[Address(RVA = "0x25ACDE0", Offset = "0x25AB3E0", VA = "0x1825ACDE0")]
		public JsonSchema Generate(Type type, JsonSchemaResolver resolver)
		{
			return null;
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A69")]
		[Address(RVA = "0x25ACE00", Offset = "0x25AB400", VA = "0x1825ACE00")]
		public JsonSchema Generate(Type type, bool rootSchemaNullable)
		{
			return null;
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0x25ACE90", Offset = "0x25AB490", VA = "0x1825ACE90")]
		public JsonSchema Generate(Type type, JsonSchemaResolver resolver, bool rootSchemaNullable)
		{
			return null;
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0x25AD010", Offset = "0x25AB610", VA = "0x1825AD010")]
		private string GetTitle(Type type)
		{
			return null;
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x25AD090", Offset = "0x25AB690", VA = "0x1825AD090")]
		private string GetDescription(Type type)
		{
			return null;
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0x25AD160", Offset = "0x25AB760", VA = "0x1825AD160")]
		private string GetTypeId(Type type, bool explicitOnly)
		{
			return null;
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x25AD260", Offset = "0x25AB860", VA = "0x1825AD260")]
		private JsonSchema GenerateInternal(Type type, Required valueRequired, bool required)
		{
			return null;
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x00005610 File Offset: 0x00003810
		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x25AE3A0", Offset = "0x25AC9A0", VA = "0x1825AE3A0")]
		private JsonSchemaType AddNullType(JsonSchemaType type, Required valueRequired)
		{
			return JsonSchemaType.None;
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x00005628 File Offset: 0x00003828
		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x21D8E50", Offset = "0x21D7450", VA = "0x1821D8E50")]
		private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag)
		{
			return default(bool);
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A71")]
		[Address(RVA = "0x25AE3B0", Offset = "0x25AC9B0", VA = "0x1825AE3B0")]
		private void GenerateObjectSchema(Type type, JsonObjectContract contract)
		{
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x25AE7E0", Offset = "0x25ACDE0", VA = "0x1825AE7E0")]
		private void GenerateISerializableContract(Type type, JsonISerializableContract contract)
		{
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x00005640 File Offset: 0x00003840
		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x25AE800", Offset = "0x25ACE00", VA = "0x1825AE800")]
		internal static bool HasFlag(JsonSchemaType? value, JsonSchemaType flag)
		{
			return default(bool);
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x00005658 File Offset: 0x00003858
		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x25AE8B0", Offset = "0x25ACEB0", VA = "0x1825AE8B0")]
		private JsonSchemaType GetJsonSchemaType(Type type, Required valueRequired)
		{
			return JsonSchemaType.None;
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A75")]
		[Address(RVA = "0x25AEB90", Offset = "0x25AD190", VA = "0x1825AEB90")]
		public JsonSchemaGenerator()
		{
		}

		// Token: 0x04000617 RID: 1559
		[Token(Token = "0x4000617")]
		[FieldOffset(Offset = "0x18")]
		private IContractResolver _contractResolver;

		// Token: 0x04000618 RID: 1560
		[Token(Token = "0x4000618")]
		[FieldOffset(Offset = "0x20")]
		private JsonSchemaResolver _resolver;

		// Token: 0x04000619 RID: 1561
		[Token(Token = "0x4000619")]
		[FieldOffset(Offset = "0x28")]
		private readonly IList<JsonSchemaGenerator.TypeSchema> _stack;

		// Token: 0x0400061A RID: 1562
		[Token(Token = "0x400061A")]
		[FieldOffset(Offset = "0x30")]
		private JsonSchema _currentSchema;

		// Token: 0x02000146 RID: 326
		[Token(Token = "0x2000146")]
		private class TypeSchema
		{
			// Token: 0x170001A7 RID: 423
			// (get) Token: 0x06000A76 RID: 2678 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x170001A7")]
			public Type Type
			{
				[Token(Token = "0x6000A76")]
				[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x170001A8 RID: 424
			// (get) Token: 0x06000A77 RID: 2679 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x170001A8")]
			public JsonSchema Schema
			{
				[Token(Token = "0x6000A77")]
				[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x06000A78 RID: 2680 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000A78")]
			[Address(RVA = "0x25AEC40", Offset = "0x25AD240", VA = "0x1825AEC40")]
			public TypeSchema(Type type, JsonSchema schema)
			{
			}
		}
	}
}
