using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Il2CppDummyDll;

namespace LitJson
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	public class JsonMapper
	{
		// Token: 0x060000A4 RID: 164 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x208A8B0", Offset = "0x2088EB0", VA = "0x18208A8B0")]
		private static void AddArrayMetadata(Type type)
		{
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x208AE50", Offset = "0x2089450", VA = "0x18208AE50")]
		private static void AddObjectMetadata(Type type)
		{
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x208B830", Offset = "0x2089E30", VA = "0x18208B830")]
		private static void AddTypeProperties(Type type)
		{
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002156 File Offset: 0x00000356
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x208BE50", Offset = "0x208A450", VA = "0x18208BE50")]
		private static MethodInfo GetConvOp(Type t1, Type t2)
		{
			return null;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002156 File Offset: 0x00000356
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x208C5E0", Offset = "0x208ABE0", VA = "0x18208C5E0")]
		private static object ReadValue(Type inst_type, JsonReader reader)
		{
			return null;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002156 File Offset: 0x00000356
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x208D3E0", Offset = "0x208B9E0", VA = "0x18208D3E0")]
		private static IJsonWrapper ReadValue(WrapperFactory factory, JsonReader reader)
		{
			return null;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x208D7C0", Offset = "0x208BDC0", VA = "0x18208D7C0")]
		private static void RegisterBaseExporters()
		{
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x208E730", Offset = "0x208CD30", VA = "0x18208E730")]
		private static void RegisterBaseImporters()
		{
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x208FFF0", Offset = "0x208E5F0", VA = "0x18208FFF0")]
		private static void RegisterImporter(IDictionary<Type, IDictionary<Type, ImporterFunc>> table, Type json_type, Type value_type, ImporterFunc importer)
		{
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x2090170", Offset = "0x208E770", VA = "0x182090170")]
		private static void WriteValue(object obj, JsonWriter writer, bool writer_is_private, int depth)
		{
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002156 File Offset: 0x00000356
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x2091290", Offset = "0x208F890", VA = "0x182091290")]
		public static string ToJson(object obj, bool pretty)
		{
			return null;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x2091620", Offset = "0x208FC20", VA = "0x182091620")]
		public static void ToJson(object obj, JsonWriter writer)
		{
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002156 File Offset: 0x00000356
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x2091690", Offset = "0x208FC90", VA = "0x182091690")]
		public static JsonData ToObject(JsonReader reader)
		{
			return null;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002156 File Offset: 0x00000356
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x2091890", Offset = "0x208FE90", VA = "0x182091890")]
		public static JsonData ToObject(TextReader reader)
		{
			return null;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002156 File Offset: 0x00000356
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x2091AB0", Offset = "0x20900B0", VA = "0x182091AB0")]
		public static JsonData ToObject(string json)
		{
			return null;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002156 File Offset: 0x00000356
		[Token(Token = "0x60000B3")]
		public static T ToObject<T>(JsonReader reader)
		{
			return null;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00002156 File Offset: 0x00000356
		[Token(Token = "0x60000B4")]
		public static T ToObject<T>(TextReader reader)
		{
			return null;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002156 File Offset: 0x00000356
		[Token(Token = "0x60000B5")]
		public static T ToObject<T>(string json)
		{
			return null;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002156 File Offset: 0x00000356
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x2091CD0", Offset = "0x20902D0", VA = "0x182091CD0")]
		public static IJsonWrapper ToWrapper(WrapperFactory factory, JsonReader reader)
		{
			return null;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002156 File Offset: 0x00000356
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x2091D30", Offset = "0x2090330", VA = "0x182091D30")]
		public static IJsonWrapper ToWrapper(WrapperFactory factory, string json)
		{
			return null;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B8")]
		public static void RegisterExporter<T>(ExporterFunc<T> exporter)
		{
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000B9")]
		public static void RegisterImporter<TJson, TValue>(ImporterFunc<TJson, TValue> importer)
		{
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x2091DC0", Offset = "0x20903C0", VA = "0x182091DC0")]
		public static void UnregisterExporters()
		{
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x2091E40", Offset = "0x2090440", VA = "0x182091E40")]
		public static void UnregisterImporters()
		{
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public JsonMapper()
		{
		}

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x0")]
		private static int max_nesting_depth;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x8")]
		private static IFormatProvider datetime_format;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x10")]
		private static IDictionary<Type, ExporterFunc> base_exporters_table;

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x18")]
		private static IDictionary<Type, ExporterFunc> custom_exporters_table;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x20")]
		private static IDictionary<Type, IDictionary<Type, ImporterFunc>> base_importers_table;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x28")]
		private static IDictionary<Type, IDictionary<Type, ImporterFunc>> custom_importers_table;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x30")]
		private static IDictionary<Type, ArrayMetadata> array_metadata;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x38")]
		private static readonly object array_metadata_lock;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x40")]
		private static IDictionary<Type, IDictionary<Type, MethodInfo>> conv_ops;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x48")]
		private static readonly object conv_ops_lock;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x50")]
		private static IDictionary<Type, ObjectMetadata> object_metadata;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x58")]
		private static readonly object object_metadata_lock;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x60")]
		private static IDictionary<Type, IList<PropertyMetadata>> type_properties;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x68")]
		private static readonly object type_properties_lock;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x70")]
		private static JsonWriter static_writer;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x78")]
		private static readonly object static_writer_lock;
	}
}
