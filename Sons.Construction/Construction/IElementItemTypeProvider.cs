using System;
using Il2CppDummyDll;
using Sons.Items.Core;

namespace Construction
{
	// Token: 0x020001B2 RID: 434
	[Token(Token = "0x20001B2")]
	public interface IElementItemTypeProvider
	{
		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000CEB RID: 3307
		[Token(Token = "0x1700031C")]
		Types ItemType { [Token(Token = "0x6000CEB")] get; }

		// Token: 0x06000CEC RID: 3308
		[Token(Token = "0x6000CEC")]
		bool IsCompatible(ItemData item);
	}
}
