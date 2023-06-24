using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace Newtonsoft.Json
{
	// Token: 0x02000020 RID: 32
	[Token(Token = "0x2000020")]
	[Nullable(0)]
	[NullableContext(1)]
	[Serializable]
	public class JsonException : Exception
	{
		// Token: 0x06000095 RID: 149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x24F1BA0", Offset = "0x24F01A0", VA = "0x1824F1BA0")]
		public JsonException()
		{
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x24F1BF0", Offset = "0x24F01F0", VA = "0x1824F1BF0")]
		public JsonException(string message)
		{
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x24F1C50", Offset = "0x24F0250", VA = "0x1824F1C50")]
		public JsonException(string message, [Nullable(2)] Exception innerException)
		{
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x24F1CC0", Offset = "0x24F02C0", VA = "0x1824F1CC0")]
		public JsonException(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x24F1D40", Offset = "0x24F0340", VA = "0x1824F1D40")]
		internal static JsonException Create(IJsonLineInfo lineInfo, string path, string message)
		{
			return null;
		}
	}
}
