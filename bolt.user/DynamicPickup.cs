using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000043 RID: 67
[Token(Token = "0x2000043")]
internal class DynamicPickup : NetworkState, IDynamicPickup, IState, IDisposable
{
	// Token: 0x060002AA RID: 682 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x7D20E0", Offset = "0x7D06E0", VA = "0x1807D20E0")]
	public DynamicPickup()
	{
	}

	// Token: 0x17000167 RID: 359
	// (get) Token: 0x060002AB RID: 683 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000167")]
	public NetworkTransform Transform
	{
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x7BACE0", Offset = "0x7B92E0", VA = "0x1807BACE0", Slot = "31")]
		get
		{
			return null;
		}
	}
}
