using System;
using Il2CppDummyDll;

namespace Construction
{
	// Token: 0x02000063 RID: 99
	[Token(Token = "0x2000063")]
	public interface IPlaceElementProfile
	{
		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000276 RID: 630
		[Token(Token = "0x170000D6")]
		StructureElement ElementPrefab { [Token(Token = "0x6000276")] get; }

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000277 RID: 631
		[Token(Token = "0x170000D7")]
		ElementPlaceAnimation ElementPlaceAnimation { [Token(Token = "0x6000277")] get; }

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000278 RID: 632
		[Token(Token = "0x170000D8")]
		AudioClipProfile PlacedElementAudioClip { [Token(Token = "0x6000278")] get; }

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000279 RID: 633
		[Token(Token = "0x170000D9")]
		bool AllowAutoEquip { [Token(Token = "0x6000279")] get; }
	}
}
