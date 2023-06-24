using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000108 RID: 264
	[Token(Token = "0x2000108")]
	[NullableContext(1)]
	[Nullable(0)]
	public class DefaultSerializationBinder : SerializationBinder, ISerializationBinder
	{
		// Token: 0x060007A7 RID: 1959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x257D5E0", Offset = "0x257BBE0", VA = "0x18257D5E0")]
		public DefaultSerializationBinder()
		{
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x257D6E0", Offset = "0x257BCE0", VA = "0x18257D6E0")]
		private Type GetTypeFromTypeNameKey([Nullable(new byte[]
		{
			0,
			2,
			1
		})] StructMultiKey<string, string> typeNameKey)
		{
			return null;
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x257DB50", Offset = "0x257C150", VA = "0x18257DB50")]
		private Type GetGenericTypeFromTypeName(string typeName, Assembly assembly)
		{
			return null;
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x257DDC0", Offset = "0x257C3C0", VA = "0x18257DDC0")]
		private Type GetTypeByName([Nullable(new byte[]
		{
			0,
			2,
			1
		})] StructMultiKey<string, string> typeNameKey)
		{
			return null;
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x257DE40", Offset = "0x257C440", VA = "0x18257DE40", Slot = "5")]
		public override Type BindToType([Nullable(2)] string assemblyName, string typeName)
		{
			return null;
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x257DF10", Offset = "0x257C510", VA = "0x18257DF10", Slot = "4")]
		[NullableContext(2)]
		public override void BindToName([Nullable(1)] Type serializedType, out string assemblyName, out string typeName)
		{
		}

		// Token: 0x04000504 RID: 1284
		[Token(Token = "0x4000504")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly DefaultSerializationBinder Instance;

		// Token: 0x04000505 RID: 1285
		[Token(Token = "0x4000505")]
		[FieldOffset(Offset = "0x10")]
		[Nullable(new byte[]
		{
			1,
			0,
			2,
			1,
			1
		})]
		private readonly ThreadSafeStore<StructMultiKey<string, string>, Type> _typeCache;
	}
}
