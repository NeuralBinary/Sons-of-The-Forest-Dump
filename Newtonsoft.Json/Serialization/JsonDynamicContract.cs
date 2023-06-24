using System;
using System.Dynamic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200011D RID: 285
	[Token(Token = "0x200011D")]
	[Nullable(0)]
	[NullableContext(1)]
	public class JsonDynamicContract : JsonContainerContract
	{
		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000826 RID: 2086 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700011D")]
		public JsonPropertyCollection Properties
		{
			[Token(Token = "0x6000826")]
			[Address(RVA = "0x8ECC80", Offset = "0x8EB280", VA = "0x1808ECC80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000827 RID: 2087 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000828 RID: 2088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700011E")]
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Func<string, string> PropertyNameResolver
		{
			[Token(Token = "0x6000827")]
			[Address(RVA = "0x7849C0", Offset = "0x782FC0", VA = "0x1807849C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000828")]
			[Address(RVA = "0x7849D0", Offset = "0x782FD0", VA = "0x1807849D0")]
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

		// Token: 0x06000829 RID: 2089 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000829")]
		[Address(RVA = "0x2583F20", Offset = "0x2582520", VA = "0x182583F20")]
		private static CallSite<Func<CallSite, object, object>> CreateCallSiteGetter(string name)
		{
			return null;
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600082A")]
		[Address(RVA = "0x25840E0", Offset = "0x25826E0", VA = "0x1825840E0")]
		private static CallSite<Func<CallSite, object, object, object>> CreateCallSiteSetter(string name)
		{
			return null;
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600082B")]
		[Address(RVA = "0x2584390", Offset = "0x2582990", VA = "0x182584390")]
		public JsonDynamicContract(Type underlyingType)
		{
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x00004878 File Offset: 0x00002A78
		[Token(Token = "0x600082C")]
		[Address(RVA = "0x2584610", Offset = "0x2582C10", VA = "0x182584610")]
		internal bool TryGetMember(IDynamicMetaObjectProvider dynamicProvider, string name, [Nullable(2)] out object value)
		{
			return default(bool);
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x00004890 File Offset: 0x00002A90
		[Token(Token = "0x600082D")]
		[Address(RVA = "0x2584820", Offset = "0x2582E20", VA = "0x182584820")]
		internal bool TrySetMember(IDynamicMetaObjectProvider dynamicProvider, string name, [Nullable(2)] object value)
		{
			return default(bool);
		}

		// Token: 0x04000552 RID: 1362
		[Token(Token = "0x4000552")]
		[FieldOffset(Offset = "0xD0")]
		private readonly ThreadSafeStore<string, CallSite<Func<CallSite, object, object>>> _callSiteGetters;

		// Token: 0x04000553 RID: 1363
		[Token(Token = "0x4000553")]
		[FieldOffset(Offset = "0xD8")]
		[Nullable(new byte[]
		{
			1,
			1,
			1,
			1,
			1,
			1,
			2,
			1
		})]
		private readonly ThreadSafeStore<string, CallSite<Func<CallSite, object, object, object>>> _callSiteSetters;
	}
}
