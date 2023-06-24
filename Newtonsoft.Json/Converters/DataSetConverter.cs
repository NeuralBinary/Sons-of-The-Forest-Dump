using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001AE RID: 430
	[Token(Token = "0x20001AE")]
	[NullableContext(1)]
	[Nullable(0)]
	public class DataSetConverter : JsonConverter
	{
		// Token: 0x06000EA4 RID: 3748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA4")]
		[Address(RVA = "0x25F03F0", Offset = "0x25EE9F0", VA = "0x1825F03F0", Slot = "4")]
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer)
		{
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000EA5")]
		[Address(RVA = "0x25F07F0", Offset = "0x25EEDF0", VA = "0x1825F07F0", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x00006CF0 File Offset: 0x00004EF0
		[Token(Token = "0x6000EA6")]
		[Address(RVA = "0x25F0B70", Offset = "0x25EF170", VA = "0x1825F0B70", Slot = "6")]
		public override bool CanConvert(Type valueType)
		{
			return default(bool);
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public DataSetConverter()
		{
		}
	}
}
