using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x020000AE RID: 174
[Token(Token = "0x20000AE")]
public interface IResin3dPrinterLaptopState : IState, IDisposable
{
	// Token: 0x17000450 RID: 1104
	// (get) Token: 0x060007D5 RID: 2005
	// (set) Token: 0x060007D6 RID: 2006
	[Token(Token = "0x17000450")]
	BoltEntity ConnectedPrinter { [Token(Token = "0x60007D5")] get; [Token(Token = "0x60007D6")] set; }

	// Token: 0x17000451 RID: 1105
	// (get) Token: 0x060007D7 RID: 2007
	// (set) Token: 0x060007D8 RID: 2008
	[Token(Token = "0x17000451")]
	bool IsBusy { [Token(Token = "0x60007D7")] get; [Token(Token = "0x60007D8")] set; }

	// Token: 0x17000452 RID: 1106
	// (get) Token: 0x060007D9 RID: 2009
	// (set) Token: 0x060007DA RID: 2010
	[Token(Token = "0x17000452")]
	bool InMidPrint { [Token(Token = "0x60007D9")] get; [Token(Token = "0x60007DA")] set; }

	// Token: 0x17000453 RID: 1107
	// (get) Token: 0x060007DB RID: 2011
	// (set) Token: 0x060007DC RID: 2012
	[Token(Token = "0x17000453")]
	bool IsPrintOnPrintBed { [Token(Token = "0x60007DB")] get; [Token(Token = "0x60007DC")] set; }

	// Token: 0x17000454 RID: 1108
	// (get) Token: 0x060007DD RID: 2013
	// (set) Token: 0x060007DE RID: 2014
	[Token(Token = "0x17000454")]
	int BlueprintId { [Token(Token = "0x60007DD")] get; [Token(Token = "0x60007DE")] set; }

	// Token: 0x17000455 RID: 1109
	// (get) Token: 0x060007DF RID: 2015
	// (set) Token: 0x060007E0 RID: 2016
	[Token(Token = "0x17000455")]
	float PrintProgressFactor { [Token(Token = "0x60007DF")] get; [Token(Token = "0x60007E0")] set; }
}
