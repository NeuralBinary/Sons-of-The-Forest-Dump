using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000048 RID: 72
[Token(Token = "0x2000048")]
public interface ICaveBoardsState : IState, IDisposable
{
	// Token: 0x17000176 RID: 374
	// (get) Token: 0x060002CB RID: 715
	// (set) Token: 0x060002CC RID: 716
	[Token(Token = "0x17000176")]
	int BoardMask { [Token(Token = "0x60002CB")] get; [Token(Token = "0x60002CC")] set; }

	// Token: 0x17000177 RID: 375
	// (get) Token: 0x060002CD RID: 717
	// (set) Token: 0x060002CE RID: 718
	[Token(Token = "0x17000177")]
	int AreaMask { [Token(Token = "0x60002CD")] get; [Token(Token = "0x60002CE")] set; }
}
