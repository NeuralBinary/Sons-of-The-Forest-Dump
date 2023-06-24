using System;
using System.Data;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001AF RID: 431
	[Token(Token = "0x20001AF")]
	[NullableContext(1)]
	[Nullable(0)]
	public class DataTableConverter : JsonConverter
	{
		// Token: 0x06000EA8 RID: 3752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA8")]
		[Address(RVA = "0x25F0C40", Offset = "0x25EF240", VA = "0x1825F0C40", Slot = "4")]
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer)
		{
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000EA9")]
		[Address(RVA = "0x25F12E0", Offset = "0x25EF8E0", VA = "0x1825F12E0", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x06000EAA RID: 3754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EAA")]
		[Address(RVA = "0x25F1640", Offset = "0x25EFC40", VA = "0x1825F1640")]
		private static void CreateRow(JsonReader reader, DataTable dt, JsonSerializer serializer)
		{
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000EAB")]
		[Address(RVA = "0x25F1FF0", Offset = "0x25F05F0", VA = "0x1825F1FF0")]
		private static Type GetColumnDataType(JsonReader reader)
		{
			return null;
		}

		// Token: 0x06000EAC RID: 3756 RVA: 0x00006D08 File Offset: 0x00004F08
		[Token(Token = "0x6000EAC")]
		[Address(RVA = "0x25F2200", Offset = "0x25F0800", VA = "0x1825F2200", Slot = "6")]
		public override bool CanConvert(Type valueType)
		{
			return default(bool);
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EAD")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public DataTableConverter()
		{
		}
	}
}
