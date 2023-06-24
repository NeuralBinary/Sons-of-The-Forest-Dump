using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000031 RID: 49
[Token(Token = "0x2000031")]
[Documentation(Ignore = true)]
public interface IBoltListNode
{
	// Token: 0x17000061 RID: 97
	// (get) Token: 0x060001BB RID: 443
	// (set) Token: 0x060001BC RID: 444
	[Token(Token = "0x17000061")]
	object prev { [Token(Token = "0x60001BB")] get; [Token(Token = "0x60001BC")] set; }

	// Token: 0x17000062 RID: 98
	// (get) Token: 0x060001BD RID: 445
	// (set) Token: 0x060001BE RID: 446
	[Token(Token = "0x17000062")]
	object next { [Token(Token = "0x60001BD")] get; [Token(Token = "0x60001BE")] set; }

	// Token: 0x17000063 RID: 99
	// (get) Token: 0x060001BF RID: 447
	// (set) Token: 0x060001C0 RID: 448
	[Token(Token = "0x17000063")]
	object list { [Token(Token = "0x60001BF")] get; [Token(Token = "0x60001C0")] set; }
}
