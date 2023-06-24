using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200004B RID: 75
[Token(Token = "0x200004B")]
public interface IZiplineControllerState : IState, IDisposable
{
	// Token: 0x1700017D RID: 381
	// (get) Token: 0x060002DC RID: 732
	// (set) Token: 0x060002DD RID: 733
	[Token(Token = "0x1700017D")]
	Vector3 AnchorAPosition { [Token(Token = "0x60002DC")] get; [Token(Token = "0x60002DD")] set; }

	// Token: 0x1700017E RID: 382
	// (get) Token: 0x060002DE RID: 734
	// (set) Token: 0x060002DF RID: 735
	[Token(Token = "0x1700017E")]
	Vector3 AnchorBPosition { [Token(Token = "0x60002DE")] get; [Token(Token = "0x60002DF")] set; }

	// Token: 0x1700017F RID: 383
	// (get) Token: 0x060002E0 RID: 736
	// (set) Token: 0x060002E1 RID: 737
	[Token(Token = "0x1700017F")]
	bool CanBeDismantled { [Token(Token = "0x60002E0")] get; [Token(Token = "0x60002E1")] set; }
}
