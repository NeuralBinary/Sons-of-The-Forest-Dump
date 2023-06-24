using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001AB RID: 427
	[Token(Token = "0x20001AB")]
	[NullableContext(1)]
	[Nullable(0)]
	public class BinaryConverter : JsonConverter
	{
		// Token: 0x06000E93 RID: 3731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E93")]
		[Address(RVA = "0x25EF0A0", Offset = "0x25ED6A0", VA = "0x1825EF0A0", Slot = "4")]
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer)
		{
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000E94")]
		[Address(RVA = "0x25EF110", Offset = "0x25ED710", VA = "0x1825EF110")]
		private byte[] GetByteArray(object value)
		{
			return null;
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E95")]
		[Address(RVA = "0x25EF340", Offset = "0x25ED940", VA = "0x1825EF340")]
		private static void EnsureReflectionObject(Type t)
		{
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000E96")]
		[Address(RVA = "0x25EF530", Offset = "0x25EDB30", VA = "0x1825EF530", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x06000E97 RID: 3735 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000E97")]
		[Address(RVA = "0x25EFB00", Offset = "0x25EE100", VA = "0x1825EFB00")]
		private byte[] ReadByteArray(JsonReader reader)
		{
			return null;
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x00006C90 File Offset: 0x00004E90
		[Token(Token = "0x6000E98")]
		[Address(RVA = "0x25EFD60", Offset = "0x25EE360", VA = "0x1825EFD60", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E99")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public BinaryConverter()
		{
		}

		// Token: 0x040007EE RID: 2030
		[Token(Token = "0x40007EE")]
		private const string BinaryTypeName = "System.Data.Linq.Binary";

		// Token: 0x040007EF RID: 2031
		[Token(Token = "0x40007EF")]
		private const string BinaryToArrayName = "ToArray";

		// Token: 0x040007F0 RID: 2032
		[Token(Token = "0x40007F0")]
		[FieldOffset(Offset = "0x0")]
		[Nullable(2)]
		private static ReflectionObject _reflectionObject;
	}
}
