using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000072 RID: 114
[Token(Token = "0x2000072")]
public interface IResin3dPrinterState : IState, IDisposable
{
	// Token: 0x170001EB RID: 491
	// (get) Token: 0x060003C2 RID: 962
	// (set) Token: 0x060003C3 RID: 963
	[Token(Token = "0x170001EB")]
	BoltEntity ConnectedLaptop { [Token(Token = "0x60003C2")] get; [Token(Token = "0x60003C3")] set; }

	// Token: 0x170001EC RID: 492
	// (get) Token: 0x060003C4 RID: 964
	// (set) Token: 0x060003C5 RID: 965
	[Token(Token = "0x170001EC")]
	float CurrentResinVolumeFactor { [Token(Token = "0x60003C4")] get; [Token(Token = "0x60003C5")] set; }

	// Token: 0x170001ED RID: 493
	// (get) Token: 0x060003C6 RID: 966
	// (set) Token: 0x060003C7 RID: 967
	[Token(Token = "0x170001ED")]
	float PrintProgressFactor { [Token(Token = "0x60003C6")] get; [Token(Token = "0x60003C7")] set; }

	// Token: 0x170001EE RID: 494
	// (get) Token: 0x060003C8 RID: 968
	// (set) Token: 0x060003C9 RID: 969
	[Token(Token = "0x170001EE")]
	bool IsPaused { [Token(Token = "0x60003C8")] get; [Token(Token = "0x60003C9")] set; }

	// Token: 0x170001EF RID: 495
	// (get) Token: 0x060003CA RID: 970
	// (set) Token: 0x060003CB RID: 971
	[Token(Token = "0x170001EF")]
	bool OutOfResin { [Token(Token = "0x60003CA")] get; [Token(Token = "0x60003CB")] set; }
}
