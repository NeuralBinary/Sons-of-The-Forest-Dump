using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x020000F9 RID: 249
	[Token(Token = "0x20000F9")]
	[Nullable(0)]
	[NullableContext(1)]
	public class CamelCasePropertyNamesContractResolver : DefaultContractResolver
	{
		// Token: 0x06000739 RID: 1849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000739")]
		[Address(RVA = "0x2572040", Offset = "0x2570640", VA = "0x182572040")]
		public CamelCasePropertyNamesContractResolver()
		{
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600073A")]
		[Address(RVA = "0x2572100", Offset = "0x2570700", VA = "0x182572100", Slot = "5")]
		public override JsonContract ResolveContract(Type type)
		{
			return null;
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600073B")]
		[Address(RVA = "0x25726B0", Offset = "0x2570CB0", VA = "0x1825726B0", Slot = "20")]
		internal override DefaultJsonNameTable GetNameTable()
		{
			return null;
		}

		// Token: 0x040004DB RID: 1243
		[Token(Token = "0x40004DB")]
		[FieldOffset(Offset = "0x0")]
		private static readonly object TypeContractCacheLock;

		// Token: 0x040004DC RID: 1244
		[Token(Token = "0x40004DC")]
		[FieldOffset(Offset = "0x8")]
		private static readonly DefaultJsonNameTable NameTable;

		// Token: 0x040004DD RID: 1245
		[Token(Token = "0x40004DD")]
		[FieldOffset(Offset = "0x10")]
		[Nullable(new byte[]
		{
			2,
			0,
			1,
			1,
			1
		})]
		private static Dictionary<StructMultiKey<Type, Type>, JsonContract> _contractCache;
	}
}
