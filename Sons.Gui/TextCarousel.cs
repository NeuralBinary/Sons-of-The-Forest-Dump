using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Sons.Gui
{
	// Token: 0x0200004C RID: 76
	[Token(Token = "0x200004C")]
	[AddComponentMenu("Sons/Gui/TextCarousel")]
	public class TextCarousel : Carousel<TMP_Text>
	{
		// Token: 0x060001DB RID: 475 RVA: 0x00002478 File Offset: 0x00000678
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x26093E0", Offset = "0x26079E0", VA = "0x1826093E0")]
		internal bool IsFocused()
		{
			return default(bool);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00002490 File Offset: 0x00000690
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x26093C0", Offset = "0x26079C0", VA = "0x1826093C0")]
		public bool GetPreviewFocused()
		{
			return default(bool);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x301A980", Offset = "0x3018F80", VA = "0x18301A980")]
		public void SetFocus(bool focused)
		{
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x301A9A0", Offset = "0x3018FA0", VA = "0x18301A9A0")]
		public void SetPreviewFocus(bool previewFocused)
		{
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x301A9C0", Offset = "0x3018FC0", VA = "0x18301A9C0")]
		public void AddOption(string optionName, int optionId)
		{
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x301AA40", Offset = "0x3019040", VA = "0x18301AA40", Slot = "5")]
		internal override void UpdateVisuals()
		{
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x301AE80", Offset = "0x3019480", VA = "0x18301AE80")]
		public TextCarousel()
		{
		}

		// Token: 0x040001AB RID: 427
		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0xA8")]
		private bool _focused;

		// Token: 0x040001AC RID: 428
		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0xA9")]
		private bool _previewFocused;

		// Token: 0x040001AD RID: 429
		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0xAA")]
		[SerializeField]
		private bool _useBoldSelectedText;
	}
}
