using System;
using Il2CppDummyDll;
using Sons.Items.Core;

namespace Construction
{
	// Token: 0x020001B1 RID: 433
	[Token(Token = "0x20001B1")]
	public interface IElementItemProvider
	{
		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000CE9 RID: 3305
		[Token(Token = "0x1700031B")]
		ItemData ElementItemData { [Token(Token = "0x6000CE9")] get; }

		// Token: 0x06000CEA RID: 3306
		[Token(Token = "0x6000CEA")]
		bool IsCompatible(ItemData item);
	}
}
