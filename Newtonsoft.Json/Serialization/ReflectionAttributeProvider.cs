using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000137 RID: 311
	[Token(Token = "0x2000137")]
	[Nullable(0)]
	[NullableContext(1)]
	public class ReflectionAttributeProvider : IAttributeProvider
	{
		// Token: 0x0600098E RID: 2446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600098E")]
		[Address(RVA = "0x25A33E0", Offset = "0x25A19E0", VA = "0x1825A33E0")]
		public ReflectionAttributeProvider(object attributeProvider)
		{
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600098F")]
		[Address(RVA = "0x25A34B0", Offset = "0x25A1AB0", VA = "0x1825A34B0", Slot = "4")]
		public IList<Attribute> GetAttributes(bool inherit)
		{
			return null;
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000990")]
		[Address(RVA = "0x25A3510", Offset = "0x25A1B10", VA = "0x1825A3510", Slot = "5")]
		public IList<Attribute> GetAttributes(Type attributeType, bool inherit)
		{
			return null;
		}

		// Token: 0x040005BC RID: 1468
		[Token(Token = "0x40005BC")]
		[FieldOffset(Offset = "0x10")]
		private readonly object _attributeProvider;
	}
}
