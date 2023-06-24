using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200006F RID: 111
[Token(Token = "0x200006F")]
public interface IFreeFormStructureState : IState, IDisposable
{
	// Token: 0x170001E4 RID: 484
	// (get) Token: 0x060003B1 RID: 945
	// (set) Token: 0x060003B2 RID: 946
	[Token(Token = "0x170001E4")]
	int TypeID { [Token(Token = "0x60003B1")] get; [Token(Token = "0x60003B2")] set; }

	// Token: 0x170001E5 RID: 485
	// (get) Token: 0x060003B3 RID: 947
	// (set) Token: 0x060003B4 RID: 948
	[Token(Token = "0x170001E5")]
	int InstanceID { [Token(Token = "0x60003B3")] get; [Token(Token = "0x60003B4")] set; }
}
