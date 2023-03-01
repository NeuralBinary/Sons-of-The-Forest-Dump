using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Sons.Inventory
{
	// Token: 0x0200060F RID: 1551
	[Token(Token = "0x200060F")]
	public class ItemInstanceModuleSaveDataJsonConverter : JsonConverter<ItemInstanceModule.SaveData>
	{
		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x060027A2 RID: 10146 RVA: 0x0000B928 File Offset: 0x00009B28
		[Token(Token = "0x17000536")]
		public override bool CanRead
		{
			[Token(Token = "0x60027A2")]
			[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x060027A3 RID: 10147 RVA: 0x0000B940 File Offset: 0x00009B40
		[Token(Token = "0x17000537")]
		public override bool CanWrite
		{
			[Token(Token = "0x60027A3")]
			[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060027A4 RID: 10148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027A4")]
		[Address(RVA = "0x2DBE270", Offset = "0x2DBD270", VA = "0x182DBE270", Slot = "10")]
		public override ItemInstanceModule.SaveData ReadJson(JsonReader reader, Type objectType, ItemInstanceModule.SaveData existingValue, bool hasExistingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x060027A5 RID: 10149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A5")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "9")]
		public override void WriteJson(JsonWriter writer, ItemInstanceModule.SaveData value, JsonSerializer serializer)
		{
		}

		// Token: 0x060027A6 RID: 10150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A6")]
		[Address(RVA = "0x2DBE4A0", Offset = "0x2DBD4A0", VA = "0x182DBE4A0")]
		public ItemInstanceModuleSaveDataJsonConverter()
		{
		}
	}
}
