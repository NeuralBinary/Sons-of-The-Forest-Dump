using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200008A RID: 138
[Token(Token = "0x200008A")]
public interface IHierarchyObjectState : IState, IDisposable
{
	// Token: 0x1700027B RID: 635
	// (get) Token: 0x060004EE RID: 1262
	// (set) Token: 0x060004EF RID: 1263
	[Token(Token = "0x1700027B")]
	BoltEntity ParentHack { [Token(Token = "0x60004EE")] get; [Token(Token = "0x60004EF")] set; }
}
