using System;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000112 RID: 274
	[Token(Token = "0x2000112")]
	[Nullable(0)]
	[NullableContext(2)]
	public class JsonArrayContract : JsonContainerContract
	{
		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060007CC RID: 1996 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000F9")]
		public Type CollectionItemType
		{
			[Token(Token = "0x60007CC")]
			[Address(RVA = "0x8ECC80", Offset = "0x8EB280", VA = "0x1808ECC80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060007CD RID: 1997 RVA: 0x00004728 File Offset: 0x00002928
		[Token(Token = "0x170000FA")]
		public bool IsMultidimensionalArray
		{
			[Token(Token = "0x60007CD")]
			[Address(RVA = "0x22711D0", Offset = "0x226F7D0", VA = "0x1822711D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060007CE RID: 1998 RVA: 0x00004740 File Offset: 0x00002940
		[Token(Token = "0x170000FB")]
		internal bool IsArray
		{
			[Token(Token = "0x60007CE")]
			[Address(RVA = "0xA03DE0", Offset = "0xA023E0", VA = "0x180A03DE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060007CF RID: 1999 RVA: 0x00004758 File Offset: 0x00002958
		[Token(Token = "0x170000FC")]
		internal bool ShouldCreateWrapper
		{
			[Token(Token = "0x60007CF")]
			[Address(RVA = "0x257EA70", Offset = "0x257D070", VA = "0x18257EA70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060007D0 RID: 2000 RVA: 0x00004770 File Offset: 0x00002970
		// (set) Token: 0x060007D1 RID: 2001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000FD")]
		internal bool CanDeserialize
		{
			[Token(Token = "0x60007D0")]
			[Address(RVA = "0x257EA80", Offset = "0x257D080", VA = "0x18257EA80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007D1")]
			[Address(RVA = "0x257EA90", Offset = "0x257D090", VA = "0x18257EA90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060007D2 RID: 2002 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000FE")]
		[Nullable(new byte[]
		{
			2,
			1
		})]
		internal ObjectConstructor<object> ParameterizedCreator
		{
			[Token(Token = "0x60007D2")]
			[Address(RVA = "0x257EAA0", Offset = "0x257D0A0", VA = "0x18257EAA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060007D3 RID: 2003 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060007D4 RID: 2004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000FF")]
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public ObjectConstructor<object> OverrideCreator
		{
			[Token(Token = "0x60007D3")]
			[Address(RVA = "0x8DF4F0", Offset = "0x8DDAF0", VA = "0x1808DF4F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007D4")]
			[Address(RVA = "0x257EBF0", Offset = "0x257D1F0", VA = "0x18257EBF0")]
			[param: Nullable(new byte[]
			{
				2,
				1
			})]
			set
			{
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060007D5 RID: 2005 RVA: 0x00004788 File Offset: 0x00002988
		// (set) Token: 0x060007D6 RID: 2006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000100")]
		public bool HasParameterizedCreator
		{
			[Token(Token = "0x60007D5")]
			[Address(RVA = "0x257EC60", Offset = "0x257D260", VA = "0x18257EC60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007D6")]
			[Address(RVA = "0x257EC70", Offset = "0x257D270", VA = "0x18257EC70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060007D7 RID: 2007 RVA: 0x000047A0 File Offset: 0x000029A0
		[Token(Token = "0x17000101")]
		internal bool HasParameterizedCreatorInternal
		{
			[Token(Token = "0x60007D7")]
			[Address(RVA = "0x257EC80", Offset = "0x257D280", VA = "0x18257EC80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x257ED20", Offset = "0x257D320", VA = "0x18257ED20")]
		[NullableContext(1)]
		public JsonArrayContract(Type underlyingType)
		{
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x257FFA0", Offset = "0x257E5A0", VA = "0x18257FFA0")]
		[NullableContext(1)]
		internal IWrappedCollection CreateWrapper(object list)
		{
			return null;
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x25804A0", Offset = "0x257EAA0", VA = "0x1825804A0")]
		[NullableContext(1)]
		internal IList CreateTemporaryCollection()
		{
			return null;
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x2580710", Offset = "0x257ED10", VA = "0x182580710")]
		[NullableContext(1)]
		private void StoreFSharpListCreatorIfNecessary(Type underlyingType)
		{
		}

		// Token: 0x04000511 RID: 1297
		[Token(Token = "0x4000511")]
		[FieldOffset(Offset = "0xD0")]
		private readonly Type _genericCollectionDefinitionType;

		// Token: 0x04000512 RID: 1298
		[Token(Token = "0x4000512")]
		[FieldOffset(Offset = "0xD8")]
		private Type _genericWrapperType;

		// Token: 0x04000513 RID: 1299
		[Token(Token = "0x4000513")]
		[FieldOffset(Offset = "0xE0")]
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private ObjectConstructor<object> _genericWrapperCreator;

		// Token: 0x04000514 RID: 1300
		[Token(Token = "0x4000514")]
		[FieldOffset(Offset = "0xE8")]
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Func<object> _genericTemporaryCollectionCreator;

		// Token: 0x04000518 RID: 1304
		[Token(Token = "0x4000518")]
		[FieldOffset(Offset = "0xF8")]
		private readonly ConstructorInfo _parameterizedConstructor;

		// Token: 0x04000519 RID: 1305
		[Token(Token = "0x4000519")]
		[FieldOffset(Offset = "0x100")]
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private ObjectConstructor<object> _parameterizedCreator;

		// Token: 0x0400051A RID: 1306
		[Token(Token = "0x400051A")]
		[FieldOffset(Offset = "0x108")]
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private ObjectConstructor<object> _overrideCreator;
	}
}
