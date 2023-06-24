using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Inventory;

namespace Sons.Gameplay.GrabBag
{
	// Token: 0x02000850 RID: 2128
	[Token(Token = "0x2000850")]
	public interface IGrabBagInteractionReceiver
	{
		// Token: 0x06003C97 RID: 15511
		[Token(Token = "0x6003C97")]
		void OpenInteractionReceiver(GrabBagController grabBagController);

		// Token: 0x06003C98 RID: 15512
		[Token(Token = "0x6003C98")]
		void UpdateInteractionReceiver();

		// Token: 0x06003C99 RID: 15513
		[Token(Token = "0x6003C99")]
		void CloseInteractionReceiver();

		// Token: 0x06003C9A RID: 15514
		[Token(Token = "0x6003C9A")]
		bool TryAddItem(ItemInstance itemInstance);

		// Token: 0x06003C9B RID: 15515
		[Token(Token = "0x6003C9B")]
		bool IsValid();

		// Token: 0x06003C9C RID: 15516
		[Token(Token = "0x6003C9C")]
		List<GrabBagCategory> GetValidGrabBagCategories();
	}
}
