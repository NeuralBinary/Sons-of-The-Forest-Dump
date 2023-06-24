using System;
using Bolt;
using Il2CppDummyDll;

// Token: 0x02000063 RID: 99
[Token(Token = "0x2000063")]
public interface ITreeFallState : IState, IDisposable
{
	// Token: 0x170001C1 RID: 449
	// (get) Token: 0x0600036A RID: 874
	[Token(Token = "0x170001C1")]
	NetworkTransform SectionATransform { [Token(Token = "0x600036A")] get; }

	// Token: 0x170001C2 RID: 450
	// (get) Token: 0x0600036B RID: 875
	[Token(Token = "0x170001C2")]
	NetworkTransform SectionBTransform { [Token(Token = "0x600036B")] get; }

	// Token: 0x170001C3 RID: 451
	// (get) Token: 0x0600036C RID: 876
	[Token(Token = "0x170001C3")]
	NetworkTransform SectionCTransform { [Token(Token = "0x600036C")] get; }

	// Token: 0x170001C4 RID: 452
	// (get) Token: 0x0600036D RID: 877
	[Token(Token = "0x170001C4")]
	NetworkTransform SectionDTransform { [Token(Token = "0x600036D")] get; }

	// Token: 0x170001C5 RID: 453
	// (get) Token: 0x0600036E RID: 878
	// (set) Token: 0x0600036F RID: 879
	[Token(Token = "0x170001C5")]
	BoltEntity CutTree { [Token(Token = "0x600036E")] get; [Token(Token = "0x600036F")] set; }

	// Token: 0x170001C6 RID: 454
	// (get) Token: 0x06000370 RID: 880
	// (set) Token: 0x06000371 RID: 881
	[Token(Token = "0x170001C6")]
	float UniformScale { [Token(Token = "0x6000370")] get; [Token(Token = "0x6000371")] set; }
}
