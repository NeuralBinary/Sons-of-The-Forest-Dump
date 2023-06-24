using System;
using Il2CppDummyDll;

namespace Construction.Anim
{
	// Token: 0x020002BA RID: 698
	[Token(Token = "0x20002BA")]
	public interface IAnimationSfx
	{
		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06001516 RID: 5398
		[Token(Token = "0x17000463")]
		AudioClipProfile Sfx1 { [Token(Token = "0x6001516")] get; }

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06001517 RID: 5399
		[Token(Token = "0x17000464")]
		AudioClipProfile Sfx2 { [Token(Token = "0x6001517")] get; }

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06001518 RID: 5400
		[Token(Token = "0x17000465")]
		TargetInfo CurrentTarget { [Token(Token = "0x6001518")] get; }
	}
}
