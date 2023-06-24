using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay.Grabber
{
	// Token: 0x02000846 RID: 2118
	[Token(Token = "0x2000846")]
	public interface IGrabberTargetProvider
	{
		// Token: 0x06003C1F RID: 15391
		[Token(Token = "0x6003C1F")]
		bool TryGetTargetScore(out float targetScore);

		// Token: 0x06003C20 RID: 15392
		[Token(Token = "0x6003C20")]
		void SelectTarget();

		// Token: 0x06003C21 RID: 15393
		[Token(Token = "0x6003C21")]
		void DeselectTarget();

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06003C22 RID: 15394
		[Token(Token = "0x170007C2")]
		Collider FocusedCollider { [Token(Token = "0x6003C22")] get; }

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x06003C23 RID: 15395
		[Token(Token = "0x170007C3")]
		GameObject FocusedItemGO { [Token(Token = "0x6003C23")] get; }

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x06003C24 RID: 15396
		[Token(Token = "0x170007C4")]
		bool IsFocused { [Token(Token = "0x6003C24")] get; }
	}
}
