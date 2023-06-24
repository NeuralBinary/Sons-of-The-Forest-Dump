using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000084 RID: 132
[Token(Token = "0x2000084")]
public interface IWeaponUpgradeProxyState : IState, IDisposable
{
	// Token: 0x17000234 RID: 564
	// (get) Token: 0x0600045F RID: 1119
	// (set) Token: 0x06000460 RID: 1120
	[Token(Token = "0x17000234")]
	BoltEntity TargetPlayer { [Token(Token = "0x600045F")] get; [Token(Token = "0x6000460")] set; }

	// Token: 0x17000235 RID: 565
	// (get) Token: 0x06000461 RID: 1121
	// (set) Token: 0x06000462 RID: 1122
	[Token(Token = "0x17000235")]
	int ItemId { [Token(Token = "0x6000461")] get; [Token(Token = "0x6000462")] set; }

	// Token: 0x17000236 RID: 566
	// (get) Token: 0x06000463 RID: 1123
	// (set) Token: 0x06000464 RID: 1124
	[Token(Token = "0x17000236")]
	IProtocolToken Token { [Token(Token = "0x6000463")] get; [Token(Token = "0x6000464")] set; }

	// Token: 0x17000237 RID: 567
	// (get) Token: 0x06000465 RID: 1125
	// (set) Token: 0x06000466 RID: 1126
	[Token(Token = "0x17000237")]
	bool Cloth { [Token(Token = "0x6000465")] get; [Token(Token = "0x6000466")] set; }

	// Token: 0x17000238 RID: 568
	// (get) Token: 0x06000467 RID: 1127
	// (set) Token: 0x06000468 RID: 1128
	[Token(Token = "0x17000238")]
	int Color { [Token(Token = "0x6000467")] get; [Token(Token = "0x6000468")] set; }

	// Token: 0x17000239 RID: 569
	// (get) Token: 0x06000469 RID: 1129
	// (set) Token: 0x0600046A RID: 1130
	[Token(Token = "0x17000239")]
	int AltRenderer { [Token(Token = "0x6000469")] get; [Token(Token = "0x600046A")] set; }
}
