using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000038 RID: 56
[Token(Token = "0x2000038")]
internal static class EntityProxyEnvelopePool
{
	// Token: 0x06000243 RID: 579 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000243")]
	[Address(RVA = "0x79E4D0", Offset = "0x79CAD0", VA = "0x18079E4D0")]
	internal static EntityProxyEnvelope Acquire()
	{
		return null;
	}

	// Token: 0x06000244 RID: 580 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000244")]
	[Address(RVA = "0x79E660", Offset = "0x79CC60", VA = "0x18079E660")]
	internal static void Release(EntityProxyEnvelope obj)
	{
	}

	// Token: 0x04000126 RID: 294
	[Token(Token = "0x4000126")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Stack<EntityProxyEnvelope> pool;
}
