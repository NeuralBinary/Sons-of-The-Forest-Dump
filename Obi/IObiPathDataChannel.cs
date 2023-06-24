using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x020001EA RID: 490
	[Token(Token = "0x20001EA")]
	public interface IObiPathDataChannel
	{
		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060009F4 RID: 2548
		[Token(Token = "0x17000194")]
		int Count { [Token(Token = "0x60009F4")] get; }

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060009F5 RID: 2549
		[Token(Token = "0x17000195")]
		bool Dirty { [Token(Token = "0x60009F5")] get; }

		// Token: 0x060009F6 RID: 2550
		[Token(Token = "0x60009F6")]
		void Clean();

		// Token: 0x060009F7 RID: 2551
		[Token(Token = "0x60009F7")]
		void RemoveAt(int index);
	}
}
