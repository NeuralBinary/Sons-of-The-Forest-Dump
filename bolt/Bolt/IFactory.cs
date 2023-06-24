using System;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x02000087 RID: 135
	[Token(Token = "0x2000087")]
	internal interface IFactory
	{
		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060004CD RID: 1229
		[Token(Token = "0x170000F0")]
		Type TypeObject { [Token(Token = "0x60004CD")] get; }

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060004CE RID: 1230
		[Token(Token = "0x170000F1")]
		TypeId TypeId { [Token(Token = "0x60004CE")] get; }

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060004CF RID: 1231
		[Token(Token = "0x170000F2")]
		UniqueId TypeKey { [Token(Token = "0x60004CF")] get; }

		// Token: 0x060004D0 RID: 1232
		[Token(Token = "0x60004D0")]
		object Create();
	}
}
