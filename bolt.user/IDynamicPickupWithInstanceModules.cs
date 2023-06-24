using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200002A RID: 42
[Token(Token = "0x200002A")]
public interface IDynamicPickupWithInstanceModules : IDynamicPickup, IState, IDisposable
{
	// Token: 0x1700005A RID: 90
	// (get) Token: 0x060000DF RID: 223
	// (set) Token: 0x060000E0 RID: 224
	[Token(Token = "0x1700005A")]
	IProtocolToken ItemInstance { [Token(Token = "0x60000DF")] get; [Token(Token = "0x60000E0")] set; }
}
