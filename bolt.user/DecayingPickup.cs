using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000061 RID: 97
[Token(Token = "0x2000061")]
internal class DecayingPickup : NetworkState, IDecayingPickup, IDynamicPickup, IState, IDisposable
{
	// Token: 0x0600035E RID: 862 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600035E")]
	[Address(RVA = "0x8053F0", Offset = "0x8039F0", VA = "0x1808053F0")]
	public DecayingPickup()
	{
	}

	// Token: 0x170001BC RID: 444
	// (get) Token: 0x0600035F RID: 863 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x170001BC")]
	public NetworkTransform Transform
	{
		[Token(Token = "0x600035F")]
		[Address(RVA = "0x7BACE0", Offset = "0x7B92E0", VA = "0x1807BACE0", Slot = "33")]
		get
		{
			return null;
		}
	}

	// Token: 0x170001BD RID: 445
	// (get) Token: 0x06000360 RID: 864 RVA: 0x00003330 File Offset: 0x00001530
	// (set) Token: 0x06000361 RID: 865 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001BD")]
	public int State
	{
		[Token(Token = "0x6000360")]
		[Address(RVA = "0x7B6B40", Offset = "0x7B5140", VA = "0x1807B6B40", Slot = "31")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000361")]
		[Address(RVA = "0x805450", Offset = "0x803A50", VA = "0x180805450", Slot = "32")]
		set
		{
		}
	}
}
