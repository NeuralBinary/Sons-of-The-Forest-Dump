using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Sons.TerrainDetail
{
	// Token: 0x0200050D RID: 1293
	[Token(Token = "0x200050D")]
	public class WorldLocatorIdJsonConverter : JsonConverter<WorldLocatorId>
	{
		// Token: 0x060021B9 RID: 8633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021B9")]
		[Address(RVA = "0x332E8F0", Offset = "0x332CEF0", VA = "0x18332E8F0", Slot = "9")]
		public override void WriteJson(JsonWriter writer, WorldLocatorId value, JsonSerializer serializer)
		{
		}

		// Token: 0x060021BA RID: 8634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60021BA")]
		[Address(RVA = "0x332E940", Offset = "0x332CF40", VA = "0x18332E940", Slot = "10")]
		public override WorldLocatorId ReadJson(JsonReader reader, Type objectType, WorldLocatorId existingValue, bool hasExistingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x060021BB RID: 8635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60021BB")]
		[Address(RVA = "0x332EB00", Offset = "0x332D100", VA = "0x18332EB00")]
		public WorldLocatorIdJsonConverter()
		{
		}
	}
}
