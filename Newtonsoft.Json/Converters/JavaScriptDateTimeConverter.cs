using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001B9 RID: 441
	[Token(Token = "0x20001B9")]
	[NullableContext(1)]
	[Nullable(0)]
	public class JavaScriptDateTimeConverter : DateTimeConverterBase
	{
		// Token: 0x06000ED4 RID: 3796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ED4")]
		[Address(RVA = "0x25F6460", Offset = "0x25F4A60", VA = "0x1825F6460", Slot = "4")]
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer)
		{
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000ED5")]
		[Address(RVA = "0x25F6760", Offset = "0x25F4D60", VA = "0x1825F6760", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ED6")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public JavaScriptDateTimeConverter()
		{
		}
	}
}
