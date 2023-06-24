using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200001C RID: 28
[Token(Token = "0x200001C")]
internal class RigidbodyState : NetworkState, IRigidbodyState, IState, IDisposable
{
	// Token: 0x06000093 RID: 147 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000093")]
	[Address(RVA = "0x7BAC80", Offset = "0x7B9280", VA = "0x1807BAC80")]
	public RigidbodyState()
	{
	}

	// Token: 0x1700003A RID: 58
	// (get) Token: 0x06000094 RID: 148 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700003A")]
	public NetworkTransform Transform
	{
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x7BACE0", Offset = "0x7B92E0", VA = "0x1807BACE0", Slot = "31")]
		get
		{
			return null;
		}
	}
}
