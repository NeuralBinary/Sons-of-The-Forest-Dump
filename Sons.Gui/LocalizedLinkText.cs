using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Localization;

namespace Sons.Gui
{
	// Token: 0x0200001E RID: 30
	[Token(Token = "0x200001E")]
	[AddComponentMenu("Sons/Gui/Options/LocalizedLinkText")]
	public class LocalizedLinkText : MonoBehaviour
	{
		// Token: 0x060000B8 RID: 184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public LocalizedLinkText()
		{
		}

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LinkTextGui _linkTextGui;

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LocalizedString _localizedHint;
	}
}
