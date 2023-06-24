using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001B6 RID: 438
	[Token(Token = "0x20001B6")]
	[NullableContext(1)]
	[Nullable(0)]
	public class EntityKeyMemberConverter : JsonConverter
	{
		// Token: 0x06000EBD RID: 3773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EBD")]
		[Address(RVA = "0x25F48D0", Offset = "0x25F2ED0", VA = "0x1825F48D0", Slot = "4")]
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer)
		{
		}

		// Token: 0x06000EBE RID: 3774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EBE")]
		[Address(RVA = "0x25F4C50", Offset = "0x25F3250", VA = "0x1825F4C50")]
		private static void ReadAndAssertProperty(JsonReader reader, string propertyName)
		{
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000EBF")]
		[Address(RVA = "0x25F4E40", Offset = "0x25F3440", VA = "0x1825F4E40", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EC0")]
		[Address(RVA = "0x25F51F0", Offset = "0x25F37F0", VA = "0x1825F51F0")]
		private static void EnsureReflectionObject(Type objectType)
		{
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x00006D80 File Offset: 0x00004F80
		[Token(Token = "0x6000EC1")]
		[Address(RVA = "0x25F5330", Offset = "0x25F3930", VA = "0x1825F5330", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EC2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public EntityKeyMemberConverter()
		{
		}

		// Token: 0x040007FF RID: 2047
		[Token(Token = "0x40007FF")]
		private const string EntityKeyMemberFullTypeName = "System.Data.EntityKeyMember";

		// Token: 0x04000800 RID: 2048
		[Token(Token = "0x4000800")]
		private const string KeyPropertyName = "Key";

		// Token: 0x04000801 RID: 2049
		[Token(Token = "0x4000801")]
		private const string TypePropertyName = "Type";

		// Token: 0x04000802 RID: 2050
		[Token(Token = "0x4000802")]
		private const string ValuePropertyName = "Value";

		// Token: 0x04000803 RID: 2051
		[Token(Token = "0x4000803")]
		[FieldOffset(Offset = "0x0")]
		[Nullable(2)]
		private static ReflectionObject _reflectionObject;
	}
}
