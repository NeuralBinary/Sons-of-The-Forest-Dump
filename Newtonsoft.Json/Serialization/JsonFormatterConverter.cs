using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200011E RID: 286
	[Token(Token = "0x200011E")]
	[NullableContext(1)]
	[Nullable(0)]
	internal class JsonFormatterConverter : IFormatterConverter
	{
		// Token: 0x0600082E RID: 2094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600082E")]
		[Address(RVA = "0x2584990", Offset = "0x2582F90", VA = "0x182584990")]
		public JsonFormatterConverter(JsonSerializerInternalReader reader, JsonISerializableContract contract, [Nullable(2)] JsonProperty member)
		{
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600082F")]
		private T GetTokenValue<T>(object value)
		{
			return null;
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000830")]
		[Address(RVA = "0x2584B90", Offset = "0x2583190", VA = "0x182584B90", Slot = "4")]
		public object Convert(object value, Type type)
		{
			return null;
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000831")]
		[Address(RVA = "0x2584F10", Offset = "0x2583510", VA = "0x182584F10", Slot = "10")]
		public object Convert(object value, TypeCode typeCode)
		{
			return null;
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x000048A8 File Offset: 0x00002AA8
		[Token(Token = "0x6000832")]
		[Address(RVA = "0x2585070", Offset = "0x2583670", VA = "0x182585070", Slot = "5")]
		public bool ToBoolean(object value)
		{
			return default(bool);
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x000048C0 File Offset: 0x00002AC0
		[Token(Token = "0x6000833")]
		[Address(RVA = "0x25850C0", Offset = "0x25836C0", VA = "0x1825850C0", Slot = "11")]
		public byte ToByte(object value)
		{
			return 0;
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x000048D8 File Offset: 0x00002AD8
		[Token(Token = "0x6000834")]
		[Address(RVA = "0x2585110", Offset = "0x2583710", VA = "0x182585110", Slot = "12")]
		public char ToChar(object value)
		{
			return '\0';
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x000048F0 File Offset: 0x00002AF0
		[Token(Token = "0x6000835")]
		[Address(RVA = "0x2585160", Offset = "0x2583760", VA = "0x182585160", Slot = "13")]
		public DateTime ToDateTime(object value)
		{
			return default(DateTime);
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x00004908 File Offset: 0x00002B08
		[Token(Token = "0x6000836")]
		[Address(RVA = "0x25851B0", Offset = "0x25837B0", VA = "0x1825851B0", Slot = "14")]
		public decimal ToDecimal(object value)
		{
			return 0m;
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x00004920 File Offset: 0x00002B20
		[Token(Token = "0x6000837")]
		[Address(RVA = "0x2585220", Offset = "0x2583820", VA = "0x182585220", Slot = "15")]
		public double ToDouble(object value)
		{
			return 0.0;
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x00004938 File Offset: 0x00002B38
		[Token(Token = "0x6000838")]
		[Address(RVA = "0x2585270", Offset = "0x2583870", VA = "0x182585270", Slot = "16")]
		public short ToInt16(object value)
		{
			return 0;
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x00004950 File Offset: 0x00002B50
		[Token(Token = "0x6000839")]
		[Address(RVA = "0x25852C0", Offset = "0x25838C0", VA = "0x1825852C0", Slot = "6")]
		public int ToInt32(object value)
		{
			return 0;
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x00004968 File Offset: 0x00002B68
		[Token(Token = "0x600083A")]
		[Address(RVA = "0x2585310", Offset = "0x2583910", VA = "0x182585310", Slot = "7")]
		public long ToInt64(object value)
		{
			return 0L;
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x00004980 File Offset: 0x00002B80
		[Token(Token = "0x600083B")]
		[Address(RVA = "0x2585360", Offset = "0x2583960", VA = "0x182585360", Slot = "17")]
		public sbyte ToSByte(object value)
		{
			return 0;
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x00004998 File Offset: 0x00002B98
		[Token(Token = "0x600083C")]
		[Address(RVA = "0x25853B0", Offset = "0x25839B0", VA = "0x1825853B0", Slot = "8")]
		public float ToSingle(object value)
		{
			return 0f;
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600083D")]
		[Address(RVA = "0x2585400", Offset = "0x2583A00", VA = "0x182585400", Slot = "9")]
		public string ToString(object value)
		{
			return null;
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x000049B0 File Offset: 0x00002BB0
		[Token(Token = "0x600083E")]
		[Address(RVA = "0x2585450", Offset = "0x2583A50", VA = "0x182585450", Slot = "18")]
		public ushort ToUInt16(object value)
		{
			return 0;
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x000049C8 File Offset: 0x00002BC8
		[Token(Token = "0x600083F")]
		[Address(RVA = "0x25854A0", Offset = "0x2583AA0", VA = "0x1825854A0", Slot = "19")]
		public uint ToUInt32(object value)
		{
			return 0U;
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x000049E0 File Offset: 0x00002BE0
		[Token(Token = "0x6000840")]
		[Address(RVA = "0x25854F0", Offset = "0x2583AF0", VA = "0x1825854F0", Slot = "20")]
		public ulong ToUInt64(object value)
		{
			return 0UL;
		}

		// Token: 0x04000554 RID: 1364
		[Token(Token = "0x4000554")]
		[FieldOffset(Offset = "0x10")]
		private readonly JsonSerializerInternalReader _reader;

		// Token: 0x04000555 RID: 1365
		[Token(Token = "0x4000555")]
		[FieldOffset(Offset = "0x18")]
		private readonly JsonISerializableContract _contract;

		// Token: 0x04000556 RID: 1366
		[Token(Token = "0x4000556")]
		[FieldOffset(Offset = "0x20")]
		[Nullable(2)]
		private readonly JsonProperty _member;
	}
}
