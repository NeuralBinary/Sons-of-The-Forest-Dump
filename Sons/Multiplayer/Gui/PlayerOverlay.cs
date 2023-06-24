using System;
using Il2CppDummyDll;
using NGUI.UI;
using UnityEngine;

namespace Sons.Multiplayer.Gui
{
	// Token: 0x0200056D RID: 1389
	[Token(Token = "0x200056D")]
	[AddComponentMenu("Sons/Multiplayer/Gui")]
	public class PlayerOverlay : MonoBehaviour
	{
		// Token: 0x060024D7 RID: 9431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60024D7")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public PlayerOverlay()
		{
		}

		// Token: 0x040020FD RID: 8445
		[Token(Token = "0x40020FD")]
		[FieldOffset(Offset = "0x20")]
		public UILabel _name;

		// Token: 0x040020FE RID: 8446
		[Token(Token = "0x40020FE")]
		[FieldOffset(Offset = "0x28")]
		public UISprite _bookIcon;

		// Token: 0x040020FF RID: 8447
		[Token(Token = "0x40020FF")]
		[FieldOffset(Offset = "0x30")]
		public UISprite _inventoryIcon;

		// Token: 0x04002100 RID: 8448
		[Token(Token = "0x4002100")]
		[FieldOffset(Offset = "0x38")]
		public UISprite _menuIcon;

		// Token: 0x04002101 RID: 8449
		[Token(Token = "0x4002101")]
		[FieldOffset(Offset = "0x40")]
		public UISprite _deathIcon;

		// Token: 0x04002102 RID: 8450
		[Token(Token = "0x4002102")]
		[FieldOffset(Offset = "0x48")]
		public UISprite _sleepIcon;

		// Token: 0x04002103 RID: 8451
		[Token(Token = "0x4002103")]
		[FieldOffset(Offset = "0x50")]
		public UISprite _inCaveIcon;
	}
}
