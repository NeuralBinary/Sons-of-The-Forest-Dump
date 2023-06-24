using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000099 RID: 153
[Token(Token = "0x2000099")]
public interface IRainCatcherStructureState : IScrewStructureWithStorageState, IScrewStructureState, IState, IDisposable
{
	// Token: 0x170003B0 RID: 944
	// (get) Token: 0x0600069A RID: 1690
	// (set) Token: 0x0600069B RID: 1691
	[Token(Token = "0x170003B0")]
	float CurrentVolume { [Token(Token = "0x600069A")] get; [Token(Token = "0x600069B")] set; }

	// Token: 0x170003B1 RID: 945
	// (get) Token: 0x0600069C RID: 1692
	// (set) Token: 0x0600069D RID: 1693
	[Token(Token = "0x170003B1")]
	bool IsFrozen { [Token(Token = "0x600069C")] get; [Token(Token = "0x600069D")] set; }
}
