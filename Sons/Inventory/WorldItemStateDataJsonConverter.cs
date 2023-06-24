using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Sons.Inventory
{
	// Token: 0x0200064A RID: 1610
	[Token(Token = "0x200064A")]
	public class WorldItemStateDataJsonConverter : JsonConverter<WorldItemStateData>
	{
		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x060029AC RID: 10668 RVA: 0x0000C498 File Offset: 0x0000A698
		[Token(Token = "0x17000576")]
		public override bool CanRead
		{
			[Token(Token = "0x60029AC")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x060029AD RID: 10669 RVA: 0x0000C4B0 File Offset: 0x0000A6B0
		[Token(Token = "0x17000577")]
		public override bool CanWrite
		{
			[Token(Token = "0x60029AD")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060029AE RID: 10670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029AE")]
		[Address(RVA = "0x33EFBB0", Offset = "0x33EE1B0", VA = "0x1833EFBB0", Slot = "10")]
		public override WorldItemStateData ReadJson(JsonReader reader, Type objectType, WorldItemStateData existingValue, bool hasExistingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x060029AF RID: 10671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029AF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "9")]
		public override void WriteJson(JsonWriter writer, WorldItemStateData value, JsonSerializer serializer)
		{
		}

		// Token: 0x060029B0 RID: 10672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029B0")]
		[Address(RVA = "0x33EFD00", Offset = "0x33EE300", VA = "0x1833EFD00")]
		public WorldItemStateDataJsonConverter()
		{
		}
	}
}
