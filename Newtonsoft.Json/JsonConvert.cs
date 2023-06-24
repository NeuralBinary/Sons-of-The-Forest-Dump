using System;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Linq;
using Il2CppDummyDll;

namespace Newtonsoft.Json
{
	// Token: 0x0200001A RID: 26
	[Token(Token = "0x200001A")]
	[NullableContext(1)]
	[Nullable(0)]
	public static class JsonConvert
	{
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x0600003B RID: 59 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000012")]
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public static Func<JsonSerializerSettings> DefaultSettings
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x24EBF30", Offset = "0x24EA530", VA = "0x1824EBF30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x24EBF80", Offset = "0x24EA580", VA = "0x1824EBF80")]
			[CompilerGenerated]
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x24EC030", Offset = "0x24EA630", VA = "0x1824EC030")]
		public static string ToString(DateTime value)
		{
			return null;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x24EC080", Offset = "0x24EA680", VA = "0x1824EC080")]
		public static string ToString(DateTime value, DateFormatHandling format, DateTimeZoneHandling timeZoneHandling)
		{
			return null;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x24EC2A0", Offset = "0x24EA8A0", VA = "0x1824EC2A0")]
		public static string ToString(DateTimeOffset value)
		{
			return null;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x24EC300", Offset = "0x24EA900", VA = "0x1824EC300")]
		public static string ToString(DateTimeOffset value, DateFormatHandling format)
		{
			return null;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x24EC520", Offset = "0x24EAB20", VA = "0x1824EC520")]
		public static string ToString(bool value)
		{
			return null;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x24EC5B0", Offset = "0x24EABB0", VA = "0x1824EC5B0")]
		public static string ToString(char value)
		{
			return null;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x24EC640", Offset = "0x24EAC40", VA = "0x1824EC640")]
		public static string ToString(Enum value)
		{
			return null;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x24EC690", Offset = "0x24EAC90", VA = "0x1824EC690")]
		public static string ToString(int value)
		{
			return null;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x24EC7A0", Offset = "0x24EADA0", VA = "0x1824EC7A0")]
		public static string ToString(short value)
		{
			return null;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x24EC8B0", Offset = "0x24EAEB0", VA = "0x1824EC8B0")]
		[CLSCompliant(false)]
		public static string ToString(ushort value)
		{
			return null;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x24EC9C0", Offset = "0x24EAFC0", VA = "0x1824EC9C0")]
		[CLSCompliant(false)]
		public static string ToString(uint value)
		{
			return null;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x24ECAD0", Offset = "0x24EB0D0", VA = "0x1824ECAD0")]
		public static string ToString(long value)
		{
			return null;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x24ECBE0", Offset = "0x24EB1E0", VA = "0x1824ECBE0")]
		private static string ToStringInternal(BigInteger value)
		{
			return null;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x24ECC80", Offset = "0x24EB280", VA = "0x1824ECC80")]
		[CLSCompliant(false)]
		public static string ToString(ulong value)
		{
			return null;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x24ECD90", Offset = "0x24EB390", VA = "0x1824ECD90")]
		public static string ToString(float value)
		{
			return null;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x24ECED0", Offset = "0x24EB4D0", VA = "0x1824ECED0")]
		internal static string ToString(float value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable)
		{
			return null;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x24ED050", Offset = "0x24EB650", VA = "0x1824ED050")]
		private static string EnsureFloatFormat(double value, string text, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable)
		{
			return null;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x24ED1F0", Offset = "0x24EB7F0", VA = "0x1824ED1F0")]
		public static string ToString(double value)
		{
			return null;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x24ED320", Offset = "0x24EB920", VA = "0x1824ED320")]
		internal static string ToString(double value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable)
		{
			return null;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x24ED4A0", Offset = "0x24EBAA0", VA = "0x1824ED4A0")]
		private static string EnsureDecimalPlace(double value, string text)
		{
			return null;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x24ED5B0", Offset = "0x24EBBB0", VA = "0x1824ED5B0")]
		private static string EnsureDecimalPlace(string text)
		{
			return null;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x24ED620", Offset = "0x24EBC20", VA = "0x1824ED620")]
		public static string ToString(byte value)
		{
			return null;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x24ED730", Offset = "0x24EBD30", VA = "0x1824ED730")]
		[CLSCompliant(false)]
		public static string ToString(sbyte value)
		{
			return null;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x24ED840", Offset = "0x24EBE40", VA = "0x1824ED840")]
		public static string ToString(decimal value)
		{
			return null;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x24ED960", Offset = "0x24EBF60", VA = "0x1824ED960")]
		public static string ToString(Guid value)
		{
			return null;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x24EDAE0", Offset = "0x24EC0E0", VA = "0x1824EDAE0")]
		internal static string ToString(Guid value, char quoteChar)
		{
			return null;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x24EDC30", Offset = "0x24EC230", VA = "0x1824EDC30")]
		public static string ToString(TimeSpan value)
		{
			return null;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x24EDD70", Offset = "0x24EC370", VA = "0x1824EDD70")]
		internal static string ToString(TimeSpan value, char quoteChar)
		{
			return null;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x24EDE10", Offset = "0x24EC410", VA = "0x1824EDE10")]
		public static string ToString([Nullable(2)] Uri value)
		{
			return null;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x24EDFB0", Offset = "0x24EC5B0", VA = "0x1824EDFB0")]
		internal static string ToString(Uri value, char quoteChar)
		{
			return null;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x24EE070", Offset = "0x24EC670", VA = "0x1824EE070")]
		public static string ToString([Nullable(2)] string value)
		{
			return null;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x24EE130", Offset = "0x24EC730", VA = "0x1824EE130")]
		public static string ToString([Nullable(2)] string value, char delimiter)
		{
			return null;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x24EE230", Offset = "0x24EC830", VA = "0x1824EE230")]
		public static string ToString([Nullable(2)] string value, char delimiter, StringEscapeHandling stringEscapeHandling)
		{
			return null;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x24EE310", Offset = "0x24EC910", VA = "0x1824EE310")]
		public static string ToString([Nullable(2)] object value)
		{
			return null;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x24EF7F0", Offset = "0x24EDDF0", VA = "0x1824EF7F0")]
		[DebuggerStepThrough]
		public static string SerializeObject([Nullable(2)] object value)
		{
			return null;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x24EF890", Offset = "0x24EDE90", VA = "0x1824EF890")]
		[DebuggerStepThrough]
		public static string SerializeObject([Nullable(2)] object value, Formatting formatting)
		{
			return null;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x24EF990", Offset = "0x24EDF90", VA = "0x1824EF990")]
		[DebuggerStepThrough]
		public static string SerializeObject([Nullable(2)] object value, params JsonConverter[] converters)
		{
			return null;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x24EFAA0", Offset = "0x24EE0A0", VA = "0x1824EFAA0")]
		[DebuggerStepThrough]
		public static string SerializeObject([Nullable(2)] object value, Formatting formatting, params JsonConverter[] converters)
		{
			return null;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x24EFB70", Offset = "0x24EE170", VA = "0x1824EFB70")]
		[NullableContext(2)]
		[DebuggerStepThrough]
		public static string SerializeObject(object value, JsonSerializerSettings settings)
		{
			return null;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x24EFC30", Offset = "0x24EE230", VA = "0x1824EFC30")]
		[DebuggerStepThrough]
		[NullableContext(2)]
		public static string SerializeObject(object value, Type type, JsonSerializerSettings settings)
		{
			return null;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x24EFCC0", Offset = "0x24EE2C0", VA = "0x1824EFCC0")]
		[NullableContext(2)]
		[DebuggerStepThrough]
		public static string SerializeObject(object value, Formatting formatting, JsonSerializerSettings settings)
		{
			return null;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x24EFD40", Offset = "0x24EE340", VA = "0x1824EFD40")]
		[NullableContext(2)]
		[DebuggerStepThrough]
		public static string SerializeObject(object value, Type type, Formatting formatting, JsonSerializerSettings settings)
		{
			return null;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x24EFE00", Offset = "0x24EE400", VA = "0x1824EFE00")]
		private static string SerializeObjectInternal([Nullable(2)] object value, [Nullable(2)] Type type, JsonSerializer jsonSerializer)
		{
			return null;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x24F00C0", Offset = "0x24EE6C0", VA = "0x1824F00C0")]
		[DebuggerStepThrough]
		public static object DeserializeObject(string value)
		{
			return null;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x24F0110", Offset = "0x24EE710", VA = "0x1824F0110")]
		[DebuggerStepThrough]
		public static object DeserializeObject(string value, JsonSerializerSettings settings)
		{
			return null;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x24F0170", Offset = "0x24EE770", VA = "0x1824F0170")]
		[DebuggerStepThrough]
		public static object DeserializeObject(string value, Type type)
		{
			return null;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600006A")]
		[NullableContext(2)]
		[DebuggerStepThrough]
		public static T DeserializeObject<T>([Nullable(1)] string value)
		{
			return null;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600006B")]
		[DebuggerStepThrough]
		public static T DeserializeAnonymousType<T>(string value, T anonymousTypeObject)
		{
			return null;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600006C")]
		[DebuggerStepThrough]
		public static T DeserializeAnonymousType<T>(string value, T anonymousTypeObject, JsonSerializerSettings settings)
		{
			return null;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600006D")]
		[DebuggerStepThrough]
		public static T DeserializeObject<T>(string value, params JsonConverter[] converters)
		{
			return null;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600006E")]
		[NullableContext(2)]
		[DebuggerStepThrough]
		public static T DeserializeObject<T>([Nullable(1)] string value, JsonSerializerSettings settings)
		{
			return null;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x24F01D0", Offset = "0x24EE7D0", VA = "0x1824F01D0")]
		[DebuggerStepThrough]
		public static object DeserializeObject(string value, Type type, params JsonConverter[] converters)
		{
			return null;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x24F0290", Offset = "0x24EE890", VA = "0x1824F0290")]
		[NullableContext(2)]
		public static object DeserializeObject([Nullable(1)] string value, Type type, JsonSerializerSettings settings)
		{
			return null;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x24F0490", Offset = "0x24EEA90", VA = "0x1824F0490")]
		[DebuggerStepThrough]
		public static void PopulateObject(string value, object target)
		{
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x24F04F0", Offset = "0x24EEAF0", VA = "0x1824F04F0")]
		public static void PopulateObject(string value, object target, [Nullable(2)] JsonSerializerSettings settings)
		{
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x24F06F0", Offset = "0x24EECF0", VA = "0x1824F06F0")]
		public static string SerializeXmlNode([Nullable(2)] XmlNode node)
		{
			return null;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x24F0800", Offset = "0x24EEE00", VA = "0x1824F0800")]
		public static string SerializeXmlNode([Nullable(2)] XmlNode node, Formatting formatting)
		{
			return null;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x24F08F0", Offset = "0x24EEEF0", VA = "0x1824F08F0")]
		public static string SerializeXmlNode([Nullable(2)] XmlNode node, Formatting formatting, bool omitRootObject)
		{
			return null;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x24F09F0", Offset = "0x24EEFF0", VA = "0x1824F09F0")]
		public static XmlDocument DeserializeXmlNode(string value)
		{
			return null;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x24F0AB0", Offset = "0x24EF0B0", VA = "0x1824F0AB0")]
		[NullableContext(2)]
		public static XmlDocument DeserializeXmlNode([Nullable(1)] string value, string deserializeRootElementName)
		{
			return null;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x24F0B50", Offset = "0x24EF150", VA = "0x1824F0B50")]
		[NullableContext(2)]
		public static XmlDocument DeserializeXmlNode([Nullable(1)] string value, string deserializeRootElementName, bool writeArrayAttribute)
		{
			return null;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x24F0BD0", Offset = "0x24EF1D0", VA = "0x1824F0BD0")]
		[NullableContext(2)]
		public static XmlDocument DeserializeXmlNode([Nullable(1)] string value, string deserializeRootElementName, bool writeArrayAttribute, bool encodeSpecialCharacters)
		{
			return null;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x24F0E00", Offset = "0x24EF400", VA = "0x1824F0E00")]
		public static string SerializeXNode([Nullable(2)] XObject node)
		{
			return null;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x24F0F50", Offset = "0x24EF550", VA = "0x1824F0F50")]
		public static string SerializeXNode([Nullable(2)] XObject node, Formatting formatting)
		{
			return null;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x24F1070", Offset = "0x24EF670", VA = "0x1824F1070")]
		public static string SerializeXNode([Nullable(2)] XObject node, Formatting formatting, bool omitRootObject)
		{
			return null;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x24F1170", Offset = "0x24EF770", VA = "0x1824F1170")]
		public static XDocument DeserializeXNode(string value)
		{
			return null;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x24F1230", Offset = "0x24EF830", VA = "0x1824F1230")]
		[NullableContext(2)]
		public static XDocument DeserializeXNode([Nullable(1)] string value, string deserializeRootElementName)
		{
			return null;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x24F12D0", Offset = "0x24EF8D0", VA = "0x1824F12D0")]
		[NullableContext(2)]
		public static XDocument DeserializeXNode([Nullable(1)] string value, string deserializeRootElementName, bool writeArrayAttribute)
		{
			return null;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x24F1350", Offset = "0x24EF950", VA = "0x1824F1350")]
		[NullableContext(2)]
		public static XDocument DeserializeXNode([Nullable(1)] string value, string deserializeRootElementName, bool writeArrayAttribute, bool encodeSpecialCharacters)
		{
			return null;
		}

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string True;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string False;

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string Null;

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x20")]
		public static readonly string Undefined;

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x28")]
		public static readonly string PositiveInfinity;

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x30")]
		public static readonly string NegativeInfinity;

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x38")]
		public static readonly string NaN;
	}
}
