using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000016 RID: 22
[Token(Token = "0x2000016")]
public class NetworkConnectionId : NetworkObj
{
	// Token: 0x0600007A RID: 122 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600007A")]
	[Address(RVA = "0x7B9FF0", Offset = "0x7B85F0", VA = "0x1807B9FF0")]
	public NetworkConnectionId()
	{
	}

	// Token: 0x17000030 RID: 48
	// (get) Token: 0x0600007B RID: 123 RVA: 0x000023B8 File Offset: 0x000005B8
	// (set) Token: 0x0600007C RID: 124 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000030")]
	public NetworkId NetworkId
	{
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x7BA0A0", Offset = "0x7B86A0", VA = "0x1807BA0A0")]
		get
		{
			return default(NetworkId);
		}
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x7BA100", Offset = "0x7B8700", VA = "0x1807BA100")]
		set
		{
		}
	}
}
