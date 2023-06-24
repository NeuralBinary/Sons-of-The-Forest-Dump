using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json
{
	// Token: 0x02000027 RID: 39
	[Token(Token = "0x2000027")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
	[Nullable(0)]
	[NullableContext(2)]
	public sealed class JsonPropertyAttribute : Attribute
	{
		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001D")]
		public Type ItemConverterType
		{
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x620F10", Offset = "0x61F510", VA = "0x180620F10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x620F20", Offset = "0x61F520", VA = "0x180620F20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001E")]
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public object[] ItemConverterParameters
		{
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x675FA0", Offset = "0x6745A0", VA = "0x180675FA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x675FB0", Offset = "0x6745B0", VA = "0x180675FB0")]
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

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001F")]
		public Type NamingStrategyType
		{
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x6F1D00", Offset = "0x6F0300", VA = "0x1806F1D00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x6F1D10", Offset = "0x6F0310", VA = "0x1806F1D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060000BB RID: 187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000020")]
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public object[] NamingStrategyParameters
		{
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x6306D0", Offset = "0x62ECD0", VA = "0x1806306D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x73EE10", Offset = "0x73D410", VA = "0x18073EE10")]
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

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00002220 File Offset: 0x00000420
		// (set) Token: 0x060000BD RID: 189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000021")]
		public NullValueHandling NullValueHandling
		{
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x24F2CE0", Offset = "0x24F12E0", VA = "0x1824F2CE0")]
			get
			{
				return NullValueHandling.Include;
			}
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x24F2D20", Offset = "0x24F1320", VA = "0x1824F2D20")]
			set
			{
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000BE RID: 190 RVA: 0x00002238 File Offset: 0x00000438
		// (set) Token: 0x060000BF RID: 191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000022")]
		public DefaultValueHandling DefaultValueHandling
		{
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x24F2D80", Offset = "0x24F1380", VA = "0x1824F2D80")]
			get
			{
				return DefaultValueHandling.Include;
			}
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x24F2DC0", Offset = "0x24F13C0", VA = "0x1824F2DC0")]
			set
			{
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00002250 File Offset: 0x00000450
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000023")]
		public ReferenceLoopHandling ReferenceLoopHandling
		{
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x24F2E20", Offset = "0x24F1420", VA = "0x1824F2E20")]
			get
			{
				return ReferenceLoopHandling.Error;
			}
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x24F2E60", Offset = "0x24F1460", VA = "0x1824F2E60")]
			set
			{
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00002268 File Offset: 0x00000468
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000024")]
		public ObjectCreationHandling ObjectCreationHandling
		{
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x24F2EC0", Offset = "0x24F14C0", VA = "0x1824F2EC0")]
			get
			{
				return ObjectCreationHandling.Auto;
			}
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x24F2F00", Offset = "0x24F1500", VA = "0x1824F2F00")]
			set
			{
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00002280 File Offset: 0x00000480
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000025")]
		public TypeNameHandling TypeNameHandling
		{
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x24F2F60", Offset = "0x24F1560", VA = "0x1824F2F60")]
			get
			{
				return TypeNameHandling.None;
			}
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x24F2FA0", Offset = "0x24F15A0", VA = "0x1824F2FA0")]
			set
			{
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00002298 File Offset: 0x00000498
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000026")]
		public bool IsReference
		{
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x24F3000", Offset = "0x24F1600", VA = "0x1824F3000")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x24F3040", Offset = "0x24F1640", VA = "0x1824F3040")]
			set
			{
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x000022B0 File Offset: 0x000004B0
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000027")]
		public int Order
		{
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x24F3090", Offset = "0x24F1690", VA = "0x1824F3090")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x24F30D0", Offset = "0x24F16D0", VA = "0x1824F30D0")]
			set
			{
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000CA RID: 202 RVA: 0x000022C8 File Offset: 0x000004C8
		// (set) Token: 0x060000CB RID: 203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000028")]
		public Required Required
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x24F3130", Offset = "0x24F1730", VA = "0x1824F3130")]
			get
			{
				return Required.Default;
			}
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x24F3170", Offset = "0x24F1770", VA = "0x1824F3170")]
			set
			{
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060000CD RID: 205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000029")]
		public string PropertyName
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x737410", Offset = "0x735A10", VA = "0x180737410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x8DD040", Offset = "0x8DB640", VA = "0x1808DD040")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000CE RID: 206 RVA: 0x000022E0 File Offset: 0x000004E0
		// (set) Token: 0x060000CF RID: 207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002A")]
		public ReferenceLoopHandling ItemReferenceLoopHandling
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x24F31D0", Offset = "0x24F17D0", VA = "0x1824F31D0")]
			get
			{
				return ReferenceLoopHandling.Error;
			}
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x24F3210", Offset = "0x24F1810", VA = "0x1824F3210")]
			set
			{
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x000022F8 File Offset: 0x000004F8
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002B")]
		public TypeNameHandling ItemTypeNameHandling
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x24F3270", Offset = "0x24F1870", VA = "0x1824F3270")]
			get
			{
				return TypeNameHandling.None;
			}
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x24F32B0", Offset = "0x24F18B0", VA = "0x1824F32B0")]
			set
			{
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00002310 File Offset: 0x00000510
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002C")]
		public bool ItemIsReference
		{
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x24F3310", Offset = "0x24F1910", VA = "0x1824F3310")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x24F3350", Offset = "0x24F1950", VA = "0x1824F3350")]
			set
			{
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public JsonPropertyAttribute()
		{
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x8DD040", Offset = "0x8DB640", VA = "0x1808DD040")]
		[NullableContext(1)]
		public JsonPropertyAttribute(string propertyName)
		{
		}

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x10")]
		internal NullValueHandling? _nullValueHandling;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x18")]
		internal DefaultValueHandling? _defaultValueHandling;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x20")]
		internal ReferenceLoopHandling? _referenceLoopHandling;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x28")]
		internal ObjectCreationHandling? _objectCreationHandling;

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x30")]
		internal TypeNameHandling? _typeNameHandling;

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x38")]
		internal bool? _isReference;

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x3C")]
		internal int? _order;

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x44")]
		internal Required? _required;

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x4C")]
		internal bool? _itemIsReference;

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x50")]
		internal ReferenceLoopHandling? _itemReferenceLoopHandling;

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x58")]
		internal TypeNameHandling? _itemTypeNameHandling;
	}
}
