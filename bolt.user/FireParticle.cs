using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000052 RID: 82
[Token(Token = "0x2000052")]
internal class FireParticle : NetworkState, IFireParticle, IState, IDisposable
{
	// Token: 0x06000300 RID: 768 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000300")]
	[Address(RVA = "0x7D4E60", Offset = "0x7D3460", VA = "0x1807D4E60")]
	public FireParticle()
	{
	}

	// Token: 0x1700018D RID: 397
	// (get) Token: 0x06000301 RID: 769 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700018D")]
	public NetworkTransform Transform
	{
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x7BACE0", Offset = "0x7B92E0", VA = "0x1807BACE0", Slot = "31")]
		get
		{
			return null;
		}
	}
}
