using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace Newtonsoft.Json
{
	// Token: 0x02000082 RID: 130
	[Token(Token = "0x2000082")]
	[NullableContext(1)]
	[Nullable(0)]
	[Serializable]
	public class JsonWriterException : JsonException
	{
		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000AB")]
		[Nullable(2)]
		public string Path
		{
			[Token(Token = "0x60004C5")]
			[Address(RVA = "0x5EE390", Offset = "0x5EC990", VA = "0x1805EE390")]
			[CompilerGenerated]
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x24F1BA0", Offset = "0x24F01A0", VA = "0x1824F1BA0")]
		public JsonWriterException()
		{
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x24F1BF0", Offset = "0x24F01F0", VA = "0x1824F1BF0")]
		public JsonWriterException(string message)
		{
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x24F1C50", Offset = "0x24F0250", VA = "0x1824F1C50")]
		public JsonWriterException(string message, Exception innerException)
		{
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x24F1CC0", Offset = "0x24F02C0", VA = "0x1824F1CC0")]
		public JsonWriterException(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x254D2C0", Offset = "0x254B8C0", VA = "0x18254D2C0")]
		public JsonWriterException(string message, string path, [Nullable(2)] Exception innerException)
		{
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x254D390", Offset = "0x254B990", VA = "0x18254D390")]
		internal static JsonWriterException Create(JsonWriter writer, string message, [Nullable(2)] Exception ex)
		{
			return null;
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x254D4D0", Offset = "0x254BAD0", VA = "0x18254D4D0")]
		internal static JsonWriterException Create(string path, string message, [Nullable(2)] Exception ex)
		{
			return null;
		}
	}
}
