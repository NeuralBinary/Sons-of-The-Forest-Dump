using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000122 RID: 290
	[Token(Token = "0x2000122")]
	[Nullable(0)]
	[NullableContext(1)]
	public class JsonPrimitiveContract : JsonContract
	{
		// Token: 0x1700012D RID: 301
		// (get) Token: 0x0600085E RID: 2142 RVA: 0x00004A70 File Offset: 0x00002C70
		// (set) Token: 0x0600085F RID: 2143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700012D")]
		internal PrimitiveTypeCode TypeCode
		{
			[Token(Token = "0x600085E")]
			[Address(RVA = "0xAFF2F0", Offset = "0xAFD8F0", VA = "0x180AFF2F0")]
			[CompilerGenerated]
			get
			{
				return PrimitiveTypeCode.Empty;
			}
			[Token(Token = "0x600085F")]
			[Address(RVA = "0xAFF300", Offset = "0xAFD900", VA = "0x180AFF300")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000860")]
		[Address(RVA = "0x2585C00", Offset = "0x2584200", VA = "0x182585C00")]
		public JsonPrimitiveContract(Type underlyingType)
		{
		}

		// Token: 0x04000567 RID: 1383
		[Token(Token = "0x4000567")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<Type, ReadType> ReadTypeMap;
	}
}
