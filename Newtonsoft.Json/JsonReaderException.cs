using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace Newtonsoft.Json
{
	// Token: 0x0200002F RID: 47
	[Token(Token = "0x200002F")]
	[Nullable(0)]
	[NullableContext(1)]
	[Serializable]
	public class JsonReaderException : JsonException
	{
		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000133 RID: 307 RVA: 0x00002610 File Offset: 0x00000810
		[Token(Token = "0x1700003C")]
		public int LineNumber
		{
			[Token(Token = "0x6000133")]
			[Address(RVA = "0xAFF2F0", Offset = "0xAFD8F0", VA = "0x180AFF2F0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00002628 File Offset: 0x00000828
		[Token(Token = "0x1700003D")]
		public int LinePosition
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0xAFF310", Offset = "0xAFD910", VA = "0x180AFF310")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000135 RID: 309 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700003E")]
		[Nullable(2)]
		public string Path
		{
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x750FA0", Offset = "0x74F5A0", VA = "0x180750FA0")]
			[NullableContext(2)]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x24F1BA0", Offset = "0x24F01A0", VA = "0x1824F1BA0")]
		public JsonReaderException()
		{
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x24F1BF0", Offset = "0x24F01F0", VA = "0x1824F1BF0")]
		public JsonReaderException(string message)
		{
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x24F1C50", Offset = "0x24F0250", VA = "0x1824F1C50")]
		public JsonReaderException(string message, Exception innerException)
		{
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x24F1CC0", Offset = "0x24F02C0", VA = "0x1824F1CC0")]
		public JsonReaderException(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x24FB580", Offset = "0x24F9B80", VA = "0x1824FB580")]
		public JsonReaderException(string message, string path, int lineNumber, int linePosition, [Nullable(2)] Exception innerException)
		{
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x24FB660", Offset = "0x24F9C60", VA = "0x1824FB660")]
		internal static JsonReaderException Create(JsonReader reader, string message)
		{
			return null;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x24FB670", Offset = "0x24F9C70", VA = "0x1824FB670")]
		internal static JsonReaderException Create(JsonReader reader, string message, [Nullable(2)] Exception ex)
		{
			return null;
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x24FB860", Offset = "0x24F9E60", VA = "0x1824FB860")]
		internal static JsonReaderException Create([Nullable(2)] IJsonLineInfo lineInfo, string path, string message, [Nullable(2)] Exception ex)
		{
			return null;
		}
	}
}
