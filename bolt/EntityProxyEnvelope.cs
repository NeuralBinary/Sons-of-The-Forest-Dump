using System;
using System.Collections.Generic;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000037 RID: 55
[Token(Token = "0x2000037")]
internal class EntityProxyEnvelope : BoltObject, IDisposable
{
	// Token: 0x06000241 RID: 577 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000241")]
	[Address(RVA = "0x79E2C0", Offset = "0x79C8C0", VA = "0x18079E2C0", Slot = "10")]
	public void Dispose()
	{
	}

	// Token: 0x06000242 RID: 578 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000242")]
	[Address(RVA = "0x79E420", Offset = "0x79CA20", VA = "0x18079E420")]
	public EntityProxyEnvelope()
	{
	}

	// Token: 0x04000120 RID: 288
	[Token(Token = "0x4000120")]
	[FieldOffset(Offset = "0x28")]
	public int PacketNumber;

	// Token: 0x04000121 RID: 289
	[Token(Token = "0x4000121")]
	[FieldOffset(Offset = "0x2C")]
	public ProxyFlags Flags;

	// Token: 0x04000122 RID: 290
	[Token(Token = "0x4000122")]
	[FieldOffset(Offset = "0x30")]
	public EntityProxy Proxy;

	// Token: 0x04000123 RID: 291
	[Token(Token = "0x4000123")]
	[FieldOffset(Offset = "0x38")]
	public List<Priority> Written;

	// Token: 0x04000124 RID: 292
	[Token(Token = "0x4000124")]
	[FieldOffset(Offset = "0x40")]
	public IProtocolToken ControlTokenLost;

	// Token: 0x04000125 RID: 293
	[Token(Token = "0x4000125")]
	[FieldOffset(Offset = "0x48")]
	public IProtocolToken ControlTokenGained;
}
