using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Sons.Inventory
{
	// Token: 0x02000622 RID: 1570
	[Token(Token = "0x2000622")]
	public class ItemInstanceModuleSaveDataJsonConverter : JsonConverter<ItemInstanceModule.SaveData>
	{
		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x060028BB RID: 10427 RVA: 0x0000C060 File Offset: 0x0000A260
		[Token(Token = "0x1700054B")]
		public override bool CanRead
		{
			[Token(Token = "0x60028BB")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x060028BC RID: 10428 RVA: 0x0000C078 File Offset: 0x0000A278
		[Token(Token = "0x1700054C")]
		public override bool CanWrite
		{
			[Token(Token = "0x60028BC")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060028BD RID: 10429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028BD")]
		[Address(RVA = "0x33E3A10", Offset = "0x33E2010", VA = "0x1833E3A10", Slot = "10")]
		public override ItemInstanceModule.SaveData ReadJson(JsonReader reader, Type objectType, ItemInstanceModule.SaveData existingValue, bool hasExistingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x060028BE RID: 10430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028BE")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "9")]
		public override void WriteJson(JsonWriter writer, ItemInstanceModule.SaveData value, JsonSerializer serializer)
		{
		}

		// Token: 0x060028BF RID: 10431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028BF")]
		[Address(RVA = "0x33E3D40", Offset = "0x33E2340", VA = "0x1833E3D40")]
		public ItemInstanceModuleSaveDataJsonConverter()
		{
		}
	}
}
