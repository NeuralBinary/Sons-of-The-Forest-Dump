using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class JsonConverter
	{
		// Token: 0x06000082 RID: 130
		[Token(Token = "0x6000082")]
		public abstract void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer);

		// Token: 0x06000083 RID: 131
		[Token(Token = "0x6000083")]
		public abstract object ReadJson(JsonReader reader, Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer);

		// Token: 0x06000084 RID: 132
		[Token(Token = "0x6000084")]
		public abstract bool CanConvert(Type objectType);

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00002118 File Offset: 0x00000318
		[Token(Token = "0x17000013")]
		public virtual bool CanRead
		{
			[Token(Token = "0x6000085")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00002130 File Offset: 0x00000330
		[Token(Token = "0x17000014")]
		public virtual bool CanWrite
		{
			[Token(Token = "0x6000086")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		protected JsonConverter()
		{
		}
	}
}
