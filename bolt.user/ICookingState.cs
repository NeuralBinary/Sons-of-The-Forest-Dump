using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x0200008D RID: 141
[Token(Token = "0x200008D")]
public interface ICookingState : IHierarchyObjectState, IState, IDisposable
{
	// Token: 0x17000280 RID: 640
	// (get) Token: 0x060004FB RID: 1275
	[Token(Token = "0x17000280")]
	NetworkTransform Transform { [Token(Token = "0x60004FB")] get; }

	// Token: 0x17000281 RID: 641
	// (get) Token: 0x060004FC RID: 1276
	// (set) Token: 0x060004FD RID: 1277
	[Token(Token = "0x17000281")]
	int Status { [Token(Token = "0x60004FC")] get; [Token(Token = "0x60004FD")] set; }

	// Token: 0x17000282 RID: 642
	// (get) Token: 0x060004FE RID: 1278
	// (set) Token: 0x060004FF RID: 1279
	[Token(Token = "0x17000282")]
	int DecayState { [Token(Token = "0x60004FE")] get; [Token(Token = "0x60004FF")] set; }
}
