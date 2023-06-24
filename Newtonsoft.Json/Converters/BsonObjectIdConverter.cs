using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001AC RID: 428
	[Token(Token = "0x20001AC")]
	[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
	public class BsonObjectIdConverter : JsonConverter
	{
		// Token: 0x06000E9A RID: 3738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E9A")]
		[Address(RVA = "0x25EFE80", Offset = "0x25EE480", VA = "0x1825EFE80", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000E9B")]
		[Address(RVA = "0x25F0080", Offset = "0x25EE680", VA = "0x1825F0080", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x00006CA8 File Offset: 0x00004EA8
		[Token(Token = "0x6000E9C")]
		[Address(RVA = "0x25F0330", Offset = "0x25EE930", VA = "0x1825F0330", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E9D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public BsonObjectIdConverter()
		{
		}
	}
}
