using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x02000144 RID: 324
	[Token(Token = "0x2000144")]
	[Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	[Serializable]
	public class JsonSchemaException : JsonException
	{
		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000A58 RID: 2648 RVA: 0x000055C8 File Offset: 0x000037C8
		[Token(Token = "0x170001A1")]
		public int LineNumber
		{
			[Token(Token = "0x6000A58")]
			[Address(RVA = "0xAFF2F0", Offset = "0xAFD8F0", VA = "0x180AFF2F0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000A59 RID: 2649 RVA: 0x000055E0 File Offset: 0x000037E0
		[Token(Token = "0x170001A2")]
		public int LinePosition
		{
			[Token(Token = "0x6000A59")]
			[Address(RVA = "0xAFF310", Offset = "0xAFD910", VA = "0x180AFF310")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000A5A RID: 2650 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170001A3")]
		public string Path
		{
			[Token(Token = "0x6000A5A")]
			[Address(RVA = "0x750FA0", Offset = "0x74F5A0", VA = "0x180750FA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0x24F1BA0", Offset = "0x24F01A0", VA = "0x1824F1BA0")]
		public JsonSchemaException()
		{
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0x24F1BF0", Offset = "0x24F01F0", VA = "0x1824F1BF0")]
		public JsonSchemaException(string message)
		{
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0x24F1C50", Offset = "0x24F0250", VA = "0x1824F1C50")]
		public JsonSchemaException(string message, Exception innerException)
		{
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0x24F1CC0", Offset = "0x24F02C0", VA = "0x1824F1CC0")]
		public JsonSchemaException(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0x25AC8A0", Offset = "0x25AAEA0", VA = "0x1825AC8A0")]
		internal JsonSchemaException(string message, Exception innerException, string path, int lineNumber, int linePosition)
		{
		}
	}
}
