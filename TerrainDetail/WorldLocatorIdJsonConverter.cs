using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Sons.TerrainDetail
{
	// Token: 0x02000508 RID: 1288
	[Token(Token = "0x2000508")]
	public class WorldLocatorIdJsonConverter : JsonConverter<WorldLocatorId>
	{
		// Token: 0x060020ED RID: 8429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020ED")]
		[Address(RVA = "0x2D3A830", Offset = "0x2D39830", VA = "0x182D3A830", Slot = "9")]
		public override void WriteJson(JsonWriter writer, WorldLocatorId value, JsonSerializer serializer)
		{
		}

		// Token: 0x060020EE RID: 8430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020EE")]
		[Address(RVA = "0x2D3A610", Offset = "0x2D39610", VA = "0x182D3A610", Slot = "10")]
		public override WorldLocatorId ReadJson(JsonReader reader, Type objectType, WorldLocatorId existingValue, bool hasExistingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x060020EF RID: 8431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020EF")]
		[Address(RVA = "0x2D3A880", Offset = "0x2D39880", VA = "0x182D3A880")]
		public WorldLocatorIdJsonConverter()
		{
		}
	}
}
