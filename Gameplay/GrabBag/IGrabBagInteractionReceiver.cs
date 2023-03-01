using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Inventory;

namespace Sons.Gameplay.GrabBag
{
	// Token: 0x02000702 RID: 1794
	[Token(Token = "0x2000702")]
	public interface IGrabBagInteractionReceiver
	{
		// Token: 0x06002E9F RID: 11935
		[Token(Token = "0x6002E9F")]
		void OpenInteractionReceiver(GrabBagController grabBagController);

		// Token: 0x06002EA0 RID: 11936
		[Token(Token = "0x6002EA0")]
		void UpdateInteractionReceiver();

		// Token: 0x06002EA1 RID: 11937
		[Token(Token = "0x6002EA1")]
		void CloseInteractionReceiver();

		// Token: 0x06002EA2 RID: 11938
		[Token(Token = "0x6002EA2")]
		bool TryAddItem(ItemInstance itemInstance);

		// Token: 0x06002EA3 RID: 11939
		[Token(Token = "0x6002EA3")]
		bool IsValid();

		// Token: 0x06002EA4 RID: 11940
		[Token(Token = "0x6002EA4")]
		List<GrabBagCategory> GetValidGrabBagCategories();
	}
}
