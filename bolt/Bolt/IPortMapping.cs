using System;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x020000EF RID: 239
	[Token(Token = "0x20000EF")]
	public interface IPortMapping
	{
		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000709 RID: 1801
		[Token(Token = "0x17000137")]
		ushort External { [Token(Token = "0x6000709")] get; }

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x0600070A RID: 1802
		[Token(Token = "0x17000138")]
		ushort Internal { [Token(Token = "0x600070A")] get; }

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x0600070B RID: 1803
		[Token(Token = "0x17000139")]
		NatPortMappingStatus Status { [Token(Token = "0x600070B")] get; }
	}
}
