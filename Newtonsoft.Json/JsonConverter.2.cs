using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json
{
	// Token: 0x0200001C RID: 28
	[Token(Token = "0x200001C")]
	[Nullable(0)]
	[NullableContext(1)]
	public abstract class JsonConverter<T> : JsonConverter
	{
		// Token: 0x06000088 RID: 136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000088")]
		public sealed override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer)
		{
		}

		// Token: 0x06000089 RID: 137
		[Token(Token = "0x6000089")]
		public abstract void WriteJson(JsonWriter writer, [Nullable(2)] T value, JsonSerializer serializer);

		// Token: 0x0600008A RID: 138 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600008A")]
		public sealed override object ReadJson(JsonReader reader, Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x0600008B RID: 139
		[Token(Token = "0x600008B")]
		public abstract T ReadJson(JsonReader reader, Type objectType, [Nullable(2)] T existingValue, bool hasExistingValue, JsonSerializer serializer);

		// Token: 0x0600008C RID: 140 RVA: 0x00002148 File Offset: 0x00000348
		[Token(Token = "0x600008C")]
		public sealed override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008D")]
		protected JsonConverter()
		{
		}
	}
}
