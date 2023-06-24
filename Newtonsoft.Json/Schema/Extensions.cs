using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x0200013D RID: 317
	[Token(Token = "0x200013D")]
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	public static class Extensions
	{
		// Token: 0x060009EA RID: 2538 RVA: 0x00005370 File Offset: 0x00003570
		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x25A68D0", Offset = "0x25A4ED0", VA = "0x1825A68D0")]
		[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
		public static bool IsValid(this JToken source, JsonSchema schema)
		{
			return default(bool);
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x00005388 File Offset: 0x00003588
		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x25A6990", Offset = "0x25A4F90", VA = "0x1825A6990")]
		[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
		public static bool IsValid(this JToken source, JsonSchema schema, out IList<string> errorMessages)
		{
			return default(bool);
		}

		// Token: 0x060009EC RID: 2540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x25A6B70", Offset = "0x25A5170", VA = "0x1825A6B70")]
		[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
		public static void Validate(this JToken source, JsonSchema schema)
		{
		}

		// Token: 0x060009ED RID: 2541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x25A6B80", Offset = "0x25A5180", VA = "0x1825A6B80")]
		[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
		public static void Validate(this JToken source, JsonSchema schema, ValidationEventHandler validationEventHandler)
		{
		}
	}
}
