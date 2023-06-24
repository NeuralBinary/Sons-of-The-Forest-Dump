using System;
using Il2CppDummyDll;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace NWH.Common.Input
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	public class MobileInputButton : Button
	{
		// Token: 0x0600005D RID: 93 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x26F33B0", Offset = "0x26F19B0", VA = "0x1826F33B0")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x26F3420", Offset = "0x26F1A20", VA = "0x1826F3420", Slot = "32")]
		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x26F3440", Offset = "0x26F1A40", VA = "0x1826F3440")]
		public MobileInputButton()
		{
		}

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x108")]
		public bool hasBeenClicked;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x109")]
		public bool isPressed;
	}
}
