using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Sons.Inventory;
using UnityEngine;

namespace TheForest.Items.Special
{
	// Token: 0x0200049E RID: 1182
	[Token(Token = "0x200049E")]
	public interface IHeldOnlyItemController
	{
		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06001E8D RID: 7821
		[Token(Token = "0x17000438")]
		ItemInstance HeldItem { [Token(Token = "0x6001E8D")] get; }

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06001E8E RID: 7822
		[Token(Token = "0x17000439")]
		int Amount { [Token(Token = "0x6001E8E")] get; }

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06001E8F RID: 7823
		[Token(Token = "0x1700043A")]
		bool HasItem { [Token(Token = "0x6001E8F")] get; }

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06001E90 RID: 7824
		// (set) Token: 0x06001E91 RID: 7825
		[Token(Token = "0x1700043B")]
		bool InfiniteHack { [Token(Token = "0x6001E90")] get; [Token(Token = "0x6001E91")] set; }

		// Token: 0x06001E92 RID: 7826
		[Token(Token = "0x6001E92")]
		bool Controlling(int itemId);

		// Token: 0x06001E93 RID: 7827
		[Token(Token = "0x6001E93")]
		bool Has(int itemId);

		// Token: 0x06001E94 RID: 7828
		[Token(Token = "0x6001E94")]
		bool Lift(int itemId, ItemInstance itemInstance);

		// Token: 0x06001E95 RID: 7829
		[Token(Token = "0x6001E95")]
		bool PutDown(bool fake = false, bool drop = false, bool equipPrevious = true, [Optional] GameObject preSpawned, int itemId = -1, float delay = -1f);

		// Token: 0x06001E96 RID: 7830
		[Token(Token = "0x6001E96")]
		void DropAll();
	}
}
