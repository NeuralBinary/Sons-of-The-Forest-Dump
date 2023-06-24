using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000139 RID: 313
	[Token(Token = "0x2000139")]
	public interface IVolumeConstraintsUser
	{
		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000614 RID: 1556
		// (set) Token: 0x06000615 RID: 1557
		[Token(Token = "0x170000D3")]
		bool volumeConstraintsEnabled { [Token(Token = "0x6000614")] get; [Token(Token = "0x6000615")] set; }

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000616 RID: 1558
		// (set) Token: 0x06000617 RID: 1559
		[Token(Token = "0x170000D4")]
		float compressionCompliance { [Token(Token = "0x6000616")] get; [Token(Token = "0x6000617")] set; }

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000618 RID: 1560
		// (set) Token: 0x06000619 RID: 1561
		[Token(Token = "0x170000D5")]
		float pressure { [Token(Token = "0x6000618")] get; [Token(Token = "0x6000619")] set; }
	}
}
