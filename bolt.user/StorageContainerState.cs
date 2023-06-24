using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200001F RID: 31
[Token(Token = "0x200001F")]
internal class StorageContainerState : NetworkState, IStorageContainerState, IRigidbodyState, IState, IDisposable
{
	// Token: 0x060000A1 RID: 161 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x7BB350", Offset = "0x7B9950", VA = "0x1807BB350")]
	public StorageContainerState()
	{
	}

	// Token: 0x17000040 RID: 64
	// (get) Token: 0x060000A2 RID: 162 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000040")]
	public NetworkTransform Transform
	{
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x7BACE0", Offset = "0x7B92E0", VA = "0x1807BACE0", Slot = "35")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000041 RID: 65
	// (get) Token: 0x060000A3 RID: 163 RVA: 0x00002478 File Offset: 0x00000678
	// (set) Token: 0x060000A4 RID: 164 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000041")]
	public bool IsOpen
	{
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x7BB3B0", Offset = "0x7B99B0", VA = "0x1807BB3B0", Slot = "31")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x7BB410", Offset = "0x7B9A10", VA = "0x1807BB410", Slot = "32")]
		set
		{
		}
	}

	// Token: 0x17000042 RID: 66
	// (get) Token: 0x060000A5 RID: 165 RVA: 0x00002490 File Offset: 0x00000690
	// (set) Token: 0x060000A6 RID: 166 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000042")]
	public int ContentsSeed
	{
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x7BB500", Offset = "0x7B9B00", VA = "0x1807BB500", Slot = "33")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x7BB560", Offset = "0x7B9B60", VA = "0x1807BB560", Slot = "34")]
		set
		{
		}
	}
}
