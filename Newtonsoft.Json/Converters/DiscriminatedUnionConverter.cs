using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020001B1 RID: 433
	[Token(Token = "0x20001B1")]
	[NullableContext(1)]
	[Nullable(0)]
	public class DiscriminatedUnionConverter : JsonConverter
	{
		// Token: 0x06000EB0 RID: 3760 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000EB0")]
		[Address(RVA = "0x25F2440", Offset = "0x25F0A40", VA = "0x1825F2440")]
		private static Type CreateUnionTypeLookup(Type t)
		{
			return null;
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000EB1")]
		[Address(RVA = "0x25F2680", Offset = "0x25F0C80", VA = "0x1825F2680")]
		private static DiscriminatedUnionConverter.Union CreateUnion(Type t)
		{
			return null;
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EB2")]
		[Address(RVA = "0x25F32C0", Offset = "0x25F18C0", VA = "0x1825F32C0", Slot = "4")]
		public override void WriteJson(JsonWriter writer, [Nullable(2)] object value, JsonSerializer serializer)
		{
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000EB3")]
		[Address(RVA = "0x25F3860", Offset = "0x25F1E60", VA = "0x1825F3860", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, [Nullable(2)] object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x00006D38 File Offset: 0x00004F38
		[Token(Token = "0x6000EB4")]
		[Address(RVA = "0x25F4290", Offset = "0x25F2890", VA = "0x1825F4290", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EB5")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public DiscriminatedUnionConverter()
		{
		}

		// Token: 0x040007F1 RID: 2033
		[Token(Token = "0x40007F1")]
		private const string CasePropertyName = "Case";

		// Token: 0x040007F2 RID: 2034
		[Token(Token = "0x40007F2")]
		private const string FieldsPropertyName = "Fields";

		// Token: 0x040007F3 RID: 2035
		[Token(Token = "0x40007F3")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ThreadSafeStore<Type, DiscriminatedUnionConverter.Union> UnionCache;

		// Token: 0x040007F4 RID: 2036
		[Token(Token = "0x40007F4")]
		[FieldOffset(Offset = "0x8")]
		private static readonly ThreadSafeStore<Type, Type> UnionTypeLookupCache;

		// Token: 0x020001B2 RID: 434
		[Token(Token = "0x20001B2")]
		[Nullable(0)]
		internal class Union
		{
			// Token: 0x06000EB7 RID: 3767 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000EB7")]
			[Address(RVA = "0x992FC0", Offset = "0x9915C0", VA = "0x180992FC0")]
			public Union(FSharpFunction tagReader, List<DiscriminatedUnionConverter.UnionCase> cases)
			{
			}

			// Token: 0x040007F5 RID: 2037
			[Token(Token = "0x40007F5")]
			[FieldOffset(Offset = "0x10")]
			public readonly FSharpFunction TagReader;

			// Token: 0x040007F6 RID: 2038
			[Token(Token = "0x40007F6")]
			[FieldOffset(Offset = "0x18")]
			public readonly List<DiscriminatedUnionConverter.UnionCase> Cases;
		}

		// Token: 0x020001B3 RID: 435
		[Token(Token = "0x20001B3")]
		[Nullable(0)]
		internal class UnionCase
		{
			// Token: 0x06000EB8 RID: 3768 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000EB8")]
			[Address(RVA = "0x25F4770", Offset = "0x25F2D70", VA = "0x1825F4770")]
			public UnionCase(int tag, string name, PropertyInfo[] fields, FSharpFunction fieldReader, FSharpFunction constructor)
			{
			}

			// Token: 0x040007F7 RID: 2039
			[Token(Token = "0x40007F7")]
			[FieldOffset(Offset = "0x10")]
			public readonly int Tag;

			// Token: 0x040007F8 RID: 2040
			[Token(Token = "0x40007F8")]
			[FieldOffset(Offset = "0x18")]
			public readonly string Name;

			// Token: 0x040007F9 RID: 2041
			[Token(Token = "0x40007F9")]
			[FieldOffset(Offset = "0x20")]
			public readonly PropertyInfo[] Fields;

			// Token: 0x040007FA RID: 2042
			[Token(Token = "0x40007FA")]
			[FieldOffset(Offset = "0x28")]
			public readonly FSharpFunction FieldReader;

			// Token: 0x040007FB RID: 2043
			[Token(Token = "0x40007FB")]
			[FieldOffset(Offset = "0x30")]
			public readonly FSharpFunction Constructor;
		}
	}
}
