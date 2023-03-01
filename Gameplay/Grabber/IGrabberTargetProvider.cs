using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay.Grabber
{
	// Token: 0x020006F8 RID: 1784
	[Token(Token = "0x20006F8")]
	public interface IGrabberTargetProvider
	{
		// Token: 0x06002E2A RID: 11818
		[Token(Token = "0x6002E2A")]
		bool TryGetTargetScore(out float targetScore);

		// Token: 0x06002E2B RID: 11819
		[Token(Token = "0x6002E2B")]
		void SelectTarget();

		// Token: 0x06002E2C RID: 11820
		[Token(Token = "0x6002E2C")]
		void DeselectTarget();

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06002E2D RID: 11821
		[Token(Token = "0x170005BF")]
		Collider FocusedCollider
		{
			[Token(Token = "0x6002E2D")]
			get;
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06002E2E RID: 11822
		[Token(Token = "0x170005C0")]
		GameObject FocusedItemGO
		{
			[Token(Token = "0x6002E2E")]
			get;
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06002E2F RID: 11823
		[Token(Token = "0x170005C1")]
		bool IsFocused
		{
			[Token(Token = "0x6002E2F")]
			get;
		}
	}
}
