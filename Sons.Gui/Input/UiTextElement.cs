using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Sons.Gui.Input
{
	// Token: 0x0200006B RID: 107
	[Token(Token = "0x200006B")]
	[AddComponentMenu("Sons/Gui/Input/UiTextElement")]
	public class UiTextElement : MonoBehaviour
	{
		// Token: 0x060002EE RID: 750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x305ED50", Offset = "0x305D350", VA = "0x18305ED50")]
		public void SetText(string text)
		{
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public UiTextElement()
		{
		}

		// Token: 0x0400025A RID: 602
		[Token(Token = "0x400025A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextMeshProUGUI _text;
	}
}
