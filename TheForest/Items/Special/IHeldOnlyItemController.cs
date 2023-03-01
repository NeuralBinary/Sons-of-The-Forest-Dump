using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Sons.Inventory;
using UnityEngine;

namespace TheForest.Items.Special
{
	// Token: 0x020004A8 RID: 1192
	[Token(Token = "0x20004A8")]
	public interface IHeldOnlyItemController
	{
		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06001E3B RID: 7739
		[Token(Token = "0x1700042E")]
		ItemInstance HeldItem
		{
			[Token(Token = "0x6001E3B")]
			get;
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06001E3C RID: 7740
		[Token(Token = "0x1700042F")]
		int Amount
		{
			[Token(Token = "0x6001E3C")]
			get;
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06001E3D RID: 7741
		[Token(Token = "0x17000430")]
		bool HasItem
		{
			[Token(Token = "0x6001E3D")]
			get;
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06001E3E RID: 7742
		// (set) Token: 0x06001E3F RID: 7743
		[Token(Token = "0x17000431")]
		bool InfiniteHack
		{
			[Token(Token = "0x6001E3E")]
			get;
			[Token(Token = "0x6001E3F")]
			set;
		}

		// Token: 0x06001E40 RID: 7744
		[Token(Token = "0x6001E40")]
		bool Controlling(int itemId);

		// Token: 0x06001E41 RID: 7745
		[Token(Token = "0x6001E41")]
		bool Has(int itemId);

		// Token: 0x06001E42 RID: 7746
		[Token(Token = "0x6001E42")]
		bool Lift(int itemId, ItemInstance itemInstance);

		// Token: 0x06001E43 RID: 7747
		[Token(Token = "0x6001E43")]
		bool PutDown(bool fake = false, bool drop = false, bool equipPrevious = true, [Optional] GameObject preSpawned, int itemId = -1, float delay = -1f);

		// Token: 0x06001E44 RID: 7748
		[Token(Token = "0x6001E44")]
		void DropAll();
	}
}
