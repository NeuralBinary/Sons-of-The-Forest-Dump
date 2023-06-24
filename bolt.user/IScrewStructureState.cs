using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000096 RID: 150
[Token(Token = "0x2000096")]
public interface IScrewStructureState : IState, IDisposable
{
	// Token: 0x170003A9 RID: 937
	// (get) Token: 0x0600068B RID: 1675
	[Token(Token = "0x170003A9")]
	NetworkTransform Transform { [Token(Token = "0x600068B")] get; }

	// Token: 0x170003AA RID: 938
	// (get) Token: 0x0600068C RID: 1676
	// (set) Token: 0x0600068D RID: 1677
	[Token(Token = "0x170003AA")]
	BoltEntity TranslationController { [Token(Token = "0x600068C")] get; [Token(Token = "0x600068D")] set; }
}
