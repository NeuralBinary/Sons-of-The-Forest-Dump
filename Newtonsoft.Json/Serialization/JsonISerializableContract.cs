using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200011F RID: 287
	[Token(Token = "0x200011F")]
	public class JsonISerializableContract : JsonContainerContract
	{
		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000841 RID: 2113 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000842 RID: 2114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700011F")]
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public ObjectConstructor<object> ISerializableCreator
		{
			[Token(Token = "0x6000841")]
			[Address(RVA = "0x8ECC80", Offset = "0x8EB280", VA = "0x1808ECC80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000842")]
			[Address(RVA = "0x8ECC90", Offset = "0x8EB290", VA = "0x1808ECC90")]
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

		// Token: 0x06000843 RID: 2115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000843")]
		[Address(RVA = "0x2585540", Offset = "0x2583B40", VA = "0x182585540")]
		[NullableContext(1)]
		public JsonISerializableContract(Type underlyingType)
		{
		}
	}
}
