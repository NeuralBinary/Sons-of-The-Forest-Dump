using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001BE RID: 446
	[Token(Token = "0x20001BE")]
	[NullableContext(1)]
	[Nullable(0)]
	public class VersionConverter : JsonConverter
	{
		// Token: 0x06000EFD RID: 3837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EFD")]
		[Address(RVA = "0x25FA070", Offset = "0x25F8670", VA = "0x1825FA070", Slot = "4")]
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer)
		{
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000EFE")]
		[Address(RVA = "0x25FA170", Offset = "0x25F8770", VA = "0x1825FA170", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x00006EA0 File Offset: 0x000050A0
		[Token(Token = "0x6000EFF")]
		[Address(RVA = "0x25FA3D0", Offset = "0x25F89D0", VA = "0x1825FA3D0", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F00")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public VersionConverter()
		{
		}
	}
}
