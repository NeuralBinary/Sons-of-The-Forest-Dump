using System;
using Il2CppDummyDll;
using NGUI.UI;
using UnityEngine;

namespace Sons.Multiplayer.Gui
{
	// Token: 0x0200055E RID: 1374
	[Token(Token = "0x200055E")]
	[AddComponentMenu("Sons/Multiplayer/Gui")]
	public class PlayerOverlay : MonoBehaviour
	{
		// Token: 0x060023DB RID: 9179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023DB")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public PlayerOverlay()
		{
		}

		// Token: 0x0400202D RID: 8237
		[Token(Token = "0x400202D")]
		[FieldOffset(Offset = "0x20")]
		public UILabel _name;

		// Token: 0x0400202E RID: 8238
		[Token(Token = "0x400202E")]
		[FieldOffset(Offset = "0x28")]
		public UISprite _bookIcon;

		// Token: 0x0400202F RID: 8239
		[Token(Token = "0x400202F")]
		[FieldOffset(Offset = "0x30")]
		public UISprite _inventoryIcon;

		// Token: 0x04002030 RID: 8240
		[Token(Token = "0x4002030")]
		[FieldOffset(Offset = "0x38")]
		public UISprite _menuIcon;

		// Token: 0x04002031 RID: 8241
		[Token(Token = "0x4002031")]
		[FieldOffset(Offset = "0x40")]
		public UISprite _deathIcon;

		// Token: 0x04002032 RID: 8242
		[Token(Token = "0x4002032")]
		[FieldOffset(Offset = "0x48")]
		public UISprite _sleepIcon;

		// Token: 0x04002033 RID: 8243
		[Token(Token = "0x4002033")]
		[FieldOffset(Offset = "0x50")]
		public UISprite _inCaveIcon;
	}
}
