using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Sons.UiElements
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public class SonsDropdown : TMP_Dropdown
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x315DA40", Offset = "0x315C040", VA = "0x18315DA40", Slot = "43")]
		public override void OnSubmit(BaseEventData eventData)
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x315DA40", Offset = "0x315C040", VA = "0x18315DA40", Slot = "42")]
		public override void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x315DA60", Offset = "0x315C060", VA = "0x18315DA60", Slot = "26")]
		protected override void DoStateTransition(Selectable.SelectionState state, bool instant)
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x315DB70", Offset = "0x315C170", VA = "0x18315DB70")]
		private Color GetTextColor(Selectable.SelectionState state)
		{
			return default(Color);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x315DC80", Offset = "0x315C280", VA = "0x18315DC80")]
		[ContextMenu("Add GameObject Localizer")]
		private void AddGameObjectLocalizer()
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x315E0D0", Offset = "0x315C6D0", VA = "0x18315E0D0")]
		public SonsDropdown()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private bool _blockShowDropdown;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x184")]
		[SerializeField]
		private Color _textColorNormal;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x194")]
		[SerializeField]
		private Color _textColorHighlighted;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x1A4")]
		[SerializeField]
		private Color _textColorPressed;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x1B4")]
		[SerializeField]
		private Color _textColorSelected;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x1C4")]
		[SerializeField]
		private Color _textColorDisabled;
	}
}
