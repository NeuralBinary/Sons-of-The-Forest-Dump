using System;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200011C RID: 284
	[Token(Token = "0x200011C")]
	[NullableContext(2)]
	[Nullable(0)]
	public class JsonDictionaryContract : JsonContainerContract
	{
		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000816 RID: 2070 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000817 RID: 2071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000114")]
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Func<string, string> DictionaryKeyResolver
		{
			[Token(Token = "0x6000816")]
			[Address(RVA = "0x8ECC80", Offset = "0x8EB280", VA = "0x1808ECC80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000817")]
			[Address(RVA = "0x8ECC90", Offset = "0x8EB290", VA = "0x1808ECC90")]
			[CompilerGenerated]
			[param: Nullable(new byte[]
			{
				2,
				1,
				1
			})]
			set
			{
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000818 RID: 2072 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000115")]
		public Type DictionaryKeyType
		{
			[Token(Token = "0x6000818")]
			[Address(RVA = "0x7849C0", Offset = "0x782FC0", VA = "0x1807849C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000819 RID: 2073 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000116")]
		public Type DictionaryValueType
		{
			[Token(Token = "0x6000819")]
			[Address(RVA = "0x784A30", Offset = "0x783030", VA = "0x180784A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x0600081A RID: 2074 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x0600081B RID: 2075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000117")]
		internal JsonContract KeyContract
		{
			[Token(Token = "0x600081A")]
			[Address(RVA = "0x784AA0", Offset = "0x7830A0", VA = "0x180784AA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600081B")]
			[Address(RVA = "0x784AB0", Offset = "0x7830B0", VA = "0x180784AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x0600081C RID: 2076 RVA: 0x00004830 File Offset: 0x00002A30
		[Token(Token = "0x17000118")]
		internal bool ShouldCreateWrapper
		{
			[Token(Token = "0x600081C")]
			[Address(RVA = "0xA03DF0", Offset = "0xA023F0", VA = "0x180A03DF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600081D RID: 2077 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000119")]
		[Nullable(new byte[]
		{
			2,
			1
		})]
		internal ObjectConstructor<object> ParameterizedCreator
		{
			[Token(Token = "0x600081D")]
			[Address(RVA = "0x25827F0", Offset = "0x2580DF0", VA = "0x1825827F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600081E RID: 2078 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x0600081F RID: 2079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700011A")]
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public ObjectConstructor<object> OverrideCreator
		{
			[Token(Token = "0x600081E")]
			[Address(RVA = "0x8DF560", Offset = "0x8DDB60", VA = "0x1808DF560")]
			get
			{
				return null;
			}
			[Token(Token = "0x600081F")]
			[Address(RVA = "0x8DF570", Offset = "0x8DDB70", VA = "0x1808DF570")]
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000820 RID: 2080 RVA: 0x00004848 File Offset: 0x00002A48
		// (set) Token: 0x06000821 RID: 2081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700011B")]
		public bool HasParameterizedCreator
		{
			[Token(Token = "0x6000820")]
			[Address(RVA = "0x61C530", Offset = "0x61AB30", VA = "0x18061C530")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000821")]
			[Address(RVA = "0x61C540", Offset = "0x61AB40", VA = "0x18061C540")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000822 RID: 2082 RVA: 0x00004860 File Offset: 0x00002A60
		[Token(Token = "0x1700011C")]
		internal bool HasParameterizedCreatorInternal
		{
			[Token(Token = "0x6000822")]
			[Address(RVA = "0x2582940", Offset = "0x2580F40", VA = "0x182582940")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000823")]
		[Address(RVA = "0x25829E0", Offset = "0x2580FE0", VA = "0x1825829E0")]
		[NullableContext(1)]
		public JsonDictionaryContract(Type underlyingType)
		{
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000824")]
		[Address(RVA = "0x2583870", Offset = "0x2581E70", VA = "0x182583870")]
		[NullableContext(1)]
		internal IWrappedDictionary CreateWrapper(object dictionary)
		{
			return null;
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000825")]
		[Address(RVA = "0x2583C50", Offset = "0x2582250", VA = "0x182583C50")]
		[NullableContext(1)]
		internal IDictionary CreateTemporaryDictionary()
		{
			return null;
		}

		// Token: 0x04000547 RID: 1351
		[Token(Token = "0x4000547")]
		[FieldOffset(Offset = "0xE0")]
		private readonly Type _genericCollectionDefinitionType;

		// Token: 0x04000548 RID: 1352
		[Token(Token = "0x4000548")]
		[FieldOffset(Offset = "0xE8")]
		private Type _genericWrapperType;

		// Token: 0x04000549 RID: 1353
		[Token(Token = "0x4000549")]
		[FieldOffset(Offset = "0xF0")]
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private ObjectConstructor<object> _genericWrapperCreator;

		// Token: 0x0400054A RID: 1354
		[Token(Token = "0x400054A")]
		[FieldOffset(Offset = "0xF8")]
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Func<object> _genericTemporaryDictionaryCreator;

		// Token: 0x0400054C RID: 1356
		[Token(Token = "0x400054C")]
		[FieldOffset(Offset = "0x108")]
		private readonly ConstructorInfo _parameterizedConstructor;

		// Token: 0x0400054D RID: 1357
		[Token(Token = "0x400054D")]
		[FieldOffset(Offset = "0x110")]
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private ObjectConstructor<object> _overrideCreator;

		// Token: 0x0400054E RID: 1358
		[Token(Token = "0x400054E")]
		[FieldOffset(Offset = "0x118")]
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private ObjectConstructor<object> _parameterizedCreator;
	}
}
