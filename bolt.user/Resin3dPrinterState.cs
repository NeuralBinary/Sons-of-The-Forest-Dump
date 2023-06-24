using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000073 RID: 115
[Token(Token = "0x2000073")]
internal class Resin3dPrinterState : NetworkState, IResin3dPrinterState, IState, IDisposable
{
	// Token: 0x060003CC RID: 972 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003CC")]
	[Address(RVA = "0x809680", Offset = "0x807C80", VA = "0x180809680")]
	public Resin3dPrinterState()
	{
	}

	// Token: 0x170001F0 RID: 496
	// (get) Token: 0x060003CD RID: 973 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060003CE RID: 974 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001F0")]
	public BoltEntity ConnectedLaptop
	{
		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0", Slot = "31")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x8096E0", Offset = "0x807CE0", VA = "0x1808096E0", Slot = "32")]
		set
		{
		}
	}

	// Token: 0x170001F1 RID: 497
	// (get) Token: 0x060003CF RID: 975 RVA: 0x000034C8 File Offset: 0x000016C8
	// (set) Token: 0x060003D0 RID: 976 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001F1")]
	public float CurrentResinVolumeFactor
	{
		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x7B78E0", Offset = "0x7B5EE0", VA = "0x1807B78E0", Slot = "33")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x809930", Offset = "0x807F30", VA = "0x180809930", Slot = "34")]
		set
		{
		}
	}

	// Token: 0x170001F2 RID: 498
	// (get) Token: 0x060003D1 RID: 977 RVA: 0x000034E0 File Offset: 0x000016E0
	// (set) Token: 0x060003D2 RID: 978 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001F2")]
	public float PrintProgressFactor
	{
		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x7B69F0", Offset = "0x7B4FF0", VA = "0x1807B69F0", Slot = "35")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x809A40", Offset = "0x808040", VA = "0x180809A40", Slot = "36")]
		set
		{
		}
	}

	// Token: 0x170001F3 RID: 499
	// (get) Token: 0x060003D3 RID: 979 RVA: 0x000034F8 File Offset: 0x000016F8
	// (set) Token: 0x060003D4 RID: 980 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001F3")]
	public bool IsPaused
	{
		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x7BB3B0", Offset = "0x7B99B0", VA = "0x1807BB3B0", Slot = "37")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x809B50", Offset = "0x808150", VA = "0x180809B50", Slot = "38")]
		set
		{
		}
	}

	// Token: 0x170001F4 RID: 500
	// (get) Token: 0x060003D5 RID: 981 RVA: 0x00003510 File Offset: 0x00001710
	// (set) Token: 0x060003D6 RID: 982 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170001F4")]
	public bool OutOfResin
	{
		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x7BBF10", Offset = "0x7BA510", VA = "0x1807BBF10", Slot = "39")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x809C40", Offset = "0x808240", VA = "0x180809C40", Slot = "40")]
		set
		{
		}
	}
}
