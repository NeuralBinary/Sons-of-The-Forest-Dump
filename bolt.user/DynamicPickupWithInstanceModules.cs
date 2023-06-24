using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200002B RID: 43
[Token(Token = "0x200002B")]
internal class DynamicPickupWithInstanceModules : NetworkState, IDynamicPickupWithInstanceModules, IDynamicPickup, IState, IDisposable
{
	// Token: 0x060000E1 RID: 225 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x7BDA50", Offset = "0x7BC050", VA = "0x1807BDA50")]
	public DynamicPickupWithInstanceModules()
	{
	}

	// Token: 0x1700005B RID: 91
	// (get) Token: 0x060000E2 RID: 226 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x1700005B")]
	public NetworkTransform Transform
	{
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x7BACE0", Offset = "0x7B92E0", VA = "0x1807BACE0", Slot = "33")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700005C RID: 92
	// (get) Token: 0x060000E3 RID: 227 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060000E4 RID: 228 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700005C")]
	public IProtocolToken ItemInstance
	{
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x7BDAB0", Offset = "0x7BC0B0", VA = "0x1807BDAB0", Slot = "31")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x7BDB60", Offset = "0x7BC160", VA = "0x1807BDB60", Slot = "32")]
		set
		{
		}
	}
}
