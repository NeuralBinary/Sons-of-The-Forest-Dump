using System;
using Il2CppDummyDll;
using NGUI.UI;
using UnityEngine;

namespace NGUI.Interaction
{
	// Token: 0x020000BA RID: 186
	[Token(Token = "0x20000BA")]
	[AddComponentMenu("NGUI/UI/Image Button")]
	public class UIImageButton : MonoBehaviour
	{
		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060006AC RID: 1708 RVA: 0x00004608 File Offset: 0x00002808
		// (set) Token: 0x060006AD RID: 1709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000150")]
		public bool isEnabled
		{
			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x26BFD10", Offset = "0x26BE310", VA = "0x1826BFD10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x26BFE80", Offset = "0x26BE480", VA = "0x1826BFE80")]
			set
			{
			}
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x26C0020", Offset = "0x26BE620", VA = "0x1826C0020")]
		private void OnEnable()
		{
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x26C0150", Offset = "0x26BE750", VA = "0x1826C0150")]
		private void OnValidate()
		{
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x26C03E0", Offset = "0x26BE9E0", VA = "0x1826C03E0")]
		private void UpdateImage()
		{
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x26C0540", Offset = "0x26BEB40", VA = "0x1826C0540")]
		private void OnHover(bool isOver)
		{
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x26C0640", Offset = "0x26BEC40", VA = "0x1826C0640")]
		private void OnPress(bool pressed)
		{
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x26C0660", Offset = "0x26BEC60", VA = "0x1826C0660")]
		private void SetSprite(string sprite)
		{
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x26C07A0", Offset = "0x26BEDA0", VA = "0x1826C07A0")]
		public UIImageButton()
		{
		}

		// Token: 0x040004CB RID: 1227
		[Token(Token = "0x40004CB")]
		[FieldOffset(Offset = "0x20")]
		public UISprite target;

		// Token: 0x040004CC RID: 1228
		[Token(Token = "0x40004CC")]
		[FieldOffset(Offset = "0x28")]
		public string normalSprite;

		// Token: 0x040004CD RID: 1229
		[Token(Token = "0x40004CD")]
		[FieldOffset(Offset = "0x30")]
		public string hoverSprite;

		// Token: 0x040004CE RID: 1230
		[Token(Token = "0x40004CE")]
		[FieldOffset(Offset = "0x38")]
		public string pressedSprite;

		// Token: 0x040004CF RID: 1231
		[Token(Token = "0x40004CF")]
		[FieldOffset(Offset = "0x40")]
		public string disabledSprite;

		// Token: 0x040004D0 RID: 1232
		[Token(Token = "0x40004D0")]
		[FieldOffset(Offset = "0x48")]
		public bool pixelSnap;
	}
}
