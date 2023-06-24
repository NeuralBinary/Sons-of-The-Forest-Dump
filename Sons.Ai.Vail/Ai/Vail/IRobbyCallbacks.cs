using System;
using Il2CppDummyDll;
using Sons.Ai.Vail.StimuliTypes;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x0200007D RID: 125
	[Token(Token = "0x200007D")]
	public interface IRobbyCallbacks
	{
		// Token: 0x06000563 RID: 1379
		[Token(Token = "0x6000563")]
		void OnBushCleared(Vector3 location, bool force);

		// Token: 0x06000564 RID: 1380
		[Token(Token = "0x6000564")]
		void OnFellTree(Vector3 location);

		// Token: 0x06000565 RID: 1381
		[Token(Token = "0x6000565")]
		void OnTreeHit(Vector3 location);

		// Token: 0x06000566 RID: 1382
		[Token(Token = "0x6000566")]
		void OnAddedItemsToHolder(bool holderMissing = false);

		// Token: 0x06000567 RID: 1383
		[Token(Token = "0x6000567")]
		void OnDroppedItems();

		// Token: 0x06000568 RID: 1384
		[Token(Token = "0x6000568")]
		void OnCompletedReaction();

		// Token: 0x06000569 RID: 1385
		[Token(Token = "0x6000569")]
		void OnCompletedOrder();

		// Token: 0x0600056A RID: 1386
		[Token(Token = "0x600056A")]
		int GetItemNeededCount(string itemType);

		// Token: 0x0600056B RID: 1387
		[Token(Token = "0x600056B")]
		bool ShouldPlaceCarriedItems();

		// Token: 0x0600056C RID: 1388
		[Token(Token = "0x600056C")]
		bool IsCurrentBuildStimuli(BuildActionStimuli stimuli);

		// Token: 0x0600056D RID: 1389
		[Token(Token = "0x600056D")]
		void AdjustItemCount(int itemId, int delta);
	}
}
