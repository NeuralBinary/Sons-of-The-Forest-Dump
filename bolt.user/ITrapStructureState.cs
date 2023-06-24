using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200009F RID: 159
[Token(Token = "0x200009F")]
public interface ITrapStructureState : IScrewStructureWithStorageState, IScrewStructureState, IState, IDisposable
{
	// Token: 0x170003C7 RID: 967
	// (get) Token: 0x060006CA RID: 1738
	// (set) Token: 0x060006CB RID: 1739
	[Token(Token = "0x170003C7")]
	BoltEntity Target { [Token(Token = "0x60006CA")] get; [Token(Token = "0x60006CB")] set; }

	// Token: 0x170003C8 RID: 968
	// (get) Token: 0x060006CC RID: 1740
	// (set) Token: 0x060006CD RID: 1741
	[Token(Token = "0x170003C8")]
	bool IsDisarmed { [Token(Token = "0x60006CC")] get; [Token(Token = "0x60006CD")] set; }
}
