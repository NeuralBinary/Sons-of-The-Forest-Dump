using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000139 RID: 313
	[Token(Token = "0x2000139")]
	[Nullable(0)]
	[NullableContext(1)]
	internal class SerializationBinderAdapter : ISerializationBinder
	{
		// Token: 0x06000994 RID: 2452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000994")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public SerializationBinderAdapter(SerializationBinder serializationBinder)
		{
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000995")]
		[Address(RVA = "0x25A39F0", Offset = "0x25A1FF0", VA = "0x1825A39F0", Slot = "4")]
		public Type BindToType([Nullable(2)] string assemblyName, string typeName)
		{
			return null;
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000996")]
		[Address(RVA = "0x25A3A20", Offset = "0x25A2020", VA = "0x1825A3A20", Slot = "5")]
		[NullableContext(2)]
		public void BindToName([Nullable(1)] Type serializedType, out string assemblyName, out string typeName)
		{
		}

		// Token: 0x040005BE RID: 1470
		[Token(Token = "0x40005BE")]
		[FieldOffset(Offset = "0x10")]
		public readonly SerializationBinder SerializationBinder;
	}
}
