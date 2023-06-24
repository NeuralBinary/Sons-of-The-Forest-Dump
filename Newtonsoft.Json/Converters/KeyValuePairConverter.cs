using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001BA RID: 442
	[Token(Token = "0x20001BA")]
	[Nullable(0)]
	[NullableContext(1)]
	public class KeyValuePairConverter : JsonConverter
	{
		// Token: 0x06000ED7 RID: 3799 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000ED7")]
		[Address(RVA = "0x25F6C00", Offset = "0x25F5200", VA = "0x1825F6C00")]
		private static ReflectionObject InitializeReflectionObject(Type t)
		{
			return null;
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ED8")]
		[Address(RVA = "0x25F6DE0", Offset = "0x25F53E0", VA = "0x1825F6DE0", Slot = "4")]
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer)
		{
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000ED9")]
		[Address(RVA = "0x25F7110", Offset = "0x25F5710", VA = "0x1825F7110", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x00006DE0 File Offset: 0x00004FE0
		[Token(Token = "0x6000EDA")]
		[Address(RVA = "0x25F7820", Offset = "0x25F5E20", VA = "0x1825F7820", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EDB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public KeyValuePairConverter()
		{
		}

		// Token: 0x04000808 RID: 2056
		[Token(Token = "0x4000808")]
		private const string KeyName = "Key";

		// Token: 0x04000809 RID: 2057
		[Token(Token = "0x4000809")]
		private const string ValueName = "Value";

		// Token: 0x0400080A RID: 2058
		[Token(Token = "0x400080A")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ThreadSafeStore<Type, ReflectionObject> ReflectionObjectPerType;
	}
}
