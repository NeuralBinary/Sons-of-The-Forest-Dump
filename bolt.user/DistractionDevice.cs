using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200004F RID: 79
[Token(Token = "0x200004F")]
internal class DistractionDevice : NetworkState, IDistractionDevice, IDynamicPickup, IState, IDisposable
{
	// Token: 0x060002F3 RID: 755 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x7D45F0", Offset = "0x7D2BF0", VA = "0x1807D45F0")]
	public DistractionDevice()
	{
	}

	// Token: 0x17000187 RID: 391
	// (get) Token: 0x060002F4 RID: 756 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000187")]
	public NetworkTransform Transform
	{
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x7BACE0", Offset = "0x7B92E0", VA = "0x1807BACE0", Slot = "33")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000188 RID: 392
	// (get) Token: 0x060002F5 RID: 757 RVA: 0x00003138 File Offset: 0x00001338
	// (set) Token: 0x060002F6 RID: 758 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000188")]
	public int MusicTrack
	{
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x7B6B40", Offset = "0x7B5140", VA = "0x1807B6B40", Slot = "31")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x7D4650", Offset = "0x7D2C50", VA = "0x1807D4650", Slot = "32")]
		set
		{
		}
	}
}
