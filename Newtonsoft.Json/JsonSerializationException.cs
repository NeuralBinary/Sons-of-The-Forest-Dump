using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace Newtonsoft.Json
{
	// Token: 0x02000031 RID: 49
	[Token(Token = "0x2000031")]
	[NullableContext(1)]
	[Nullable(0)]
	[Serializable]
	public class JsonSerializationException : JsonException
	{
		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00002640 File Offset: 0x00000840
		[Token(Token = "0x1700003F")]
		public int LineNumber
		{
			[Token(Token = "0x600013F")]
			[Address(RVA = "0xAFF2F0", Offset = "0xAFD8F0", VA = "0x180AFF2F0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000140 RID: 320 RVA: 0x00002658 File Offset: 0x00000858
		[Token(Token = "0x17000040")]
		public int LinePosition
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0xAFF310", Offset = "0xAFD910", VA = "0x180AFF310")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000141 RID: 321 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000041")]
		[Nullable(2)]
		public string Path
		{
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x750FA0", Offset = "0x74F5A0", VA = "0x180750FA0")]
			[CompilerGenerated]
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x24F1BA0", Offset = "0x24F01A0", VA = "0x1824F1BA0")]
		public JsonSerializationException()
		{
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x24F1BF0", Offset = "0x24F01F0", VA = "0x1824F1BF0")]
		public JsonSerializationException(string message)
		{
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x24F1C50", Offset = "0x24F0250", VA = "0x1824F1C50")]
		public JsonSerializationException(string message, Exception innerException)
		{
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x24F1CC0", Offset = "0x24F02C0", VA = "0x1824F1CC0")]
		public JsonSerializationException(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x24FB580", Offset = "0x24F9B80", VA = "0x1824FB580")]
		public JsonSerializationException(string message, string path, int lineNumber, int linePosition, [Nullable(2)] Exception innerException)
		{
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x24FBA00", Offset = "0x24FA000", VA = "0x1824FBA00")]
		internal static JsonSerializationException Create(JsonReader reader, string message)
		{
			return null;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x24FBA90", Offset = "0x24FA090", VA = "0x1824FBA90")]
		internal static JsonSerializationException Create(JsonReader reader, string message, [Nullable(2)] Exception ex)
		{
			return null;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x24FBB30", Offset = "0x24FA130", VA = "0x1824FBB30")]
		internal static JsonSerializationException Create([Nullable(2)] IJsonLineInfo lineInfo, string path, string message, [Nullable(2)] Exception ex)
		{
			return null;
		}
	}
}
