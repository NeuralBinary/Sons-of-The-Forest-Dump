using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001AD RID: 429
	[Token(Token = "0x20001AD")]
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class CustomCreationConverter<T> : JsonConverter
	{
		// Token: 0x06000E9E RID: 3742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E9E")]
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer)
		{
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000E9F")]
		public override object ReadJson(JsonReader reader, Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x06000EA0 RID: 3744
		[Token(Token = "0x6000EA0")]
		public abstract T Create(Type objectType);

		// Token: 0x06000EA1 RID: 3745 RVA: 0x00006CC0 File Offset: 0x00004EC0
		[Token(Token = "0x6000EA1")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000EA2 RID: 3746 RVA: 0x00006CD8 File Offset: 0x00004ED8
		[Token(Token = "0x1700024B")]
		public override bool CanWrite
		{
			[Token(Token = "0x6000EA2")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA3")]
		protected CustomCreationConverter()
		{
		}
	}
}
