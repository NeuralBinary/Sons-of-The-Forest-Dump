using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000AF RID: 175
[Token(Token = "0x20000AF")]
internal class Resin3dPrinterLaptopState : NetworkState, IResin3dPrinterLaptopState, IState, IDisposable
{
	// Token: 0x060007E1 RID: 2017 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60007E1")]
	[Address(RVA = "0x832A70", Offset = "0x831070", VA = "0x180832A70")]
	public Resin3dPrinterLaptopState()
	{
	}

	// Token: 0x17000456 RID: 1110
	// (get) Token: 0x060007E2 RID: 2018 RVA: 0x00002052 File Offset: 0x00000252
	// (set) Token: 0x060007E3 RID: 2019 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000456")]
	public BoltEntity ConnectedPrinter
	{
		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x7BC8F0", Offset = "0x7BAEF0", VA = "0x1807BC8F0", Slot = "31")]
		get
		{
			return null;
		}
		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x832AD0", Offset = "0x8310D0", VA = "0x180832AD0", Slot = "32")]
		set
		{
		}
	}

	// Token: 0x17000457 RID: 1111
	// (get) Token: 0x060007E4 RID: 2020 RVA: 0x00004F20 File Offset: 0x00003120
	// (set) Token: 0x060007E5 RID: 2021 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000457")]
	public bool IsBusy
	{
		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x7B5490", Offset = "0x7B3A90", VA = "0x1807B5490", Slot = "33")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x7B54F0", Offset = "0x7B3AF0", VA = "0x1807B54F0", Slot = "34")]
		set
		{
		}
	}

	// Token: 0x17000458 RID: 1112
	// (get) Token: 0x060007E6 RID: 2022 RVA: 0x00004F38 File Offset: 0x00003138
	// (set) Token: 0x060007E7 RID: 2023 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000458")]
	public bool InMidPrint
	{
		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x7B8B00", Offset = "0x7B7100", VA = "0x1807B8B00", Slot = "35")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x7B8B60", Offset = "0x7B7160", VA = "0x1807B8B60", Slot = "36")]
		set
		{
		}
	}

	// Token: 0x17000459 RID: 1113
	// (get) Token: 0x060007E8 RID: 2024 RVA: 0x00004F50 File Offset: 0x00003150
	// (set) Token: 0x060007E9 RID: 2025 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000459")]
	public bool IsPrintOnPrintBed
	{
		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x7BB3B0", Offset = "0x7B99B0", VA = "0x1807BB3B0", Slot = "37")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x809B50", Offset = "0x808150", VA = "0x180809B50", Slot = "38")]
		set
		{
		}
	}

	// Token: 0x1700045A RID: 1114
	// (get) Token: 0x060007EA RID: 2026 RVA: 0x00004F68 File Offset: 0x00003168
	// (set) Token: 0x060007EB RID: 2027 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700045A")]
	public int BlueprintId
	{
		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x7BB500", Offset = "0x7B9B00", VA = "0x1807BB500", Slot = "39")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x832D20", Offset = "0x831320", VA = "0x180832D20", Slot = "40")]
		set
		{
		}
	}

	// Token: 0x1700045B RID: 1115
	// (get) Token: 0x060007EC RID: 2028 RVA: 0x00004F80 File Offset: 0x00003180
	// (set) Token: 0x060007ED RID: 2029 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700045B")]
	public float PrintProgressFactor
	{
		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x832E20", Offset = "0x831420", VA = "0x180832E20", Slot = "41")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x832E80", Offset = "0x831480", VA = "0x180832E80", Slot = "42")]
		set
		{
		}
	}
}
