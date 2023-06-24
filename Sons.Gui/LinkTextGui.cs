using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Sons.Gui
{
	// Token: 0x0200001D RID: 29
	[Token(Token = "0x200001D")]
	[AddComponentMenu("Sons/Gui/Options/LinkTextGui")]
	public class LinkTextGui : MonoBehaviour
	{
		// Token: 0x060000B1 RID: 177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x3007C60", Offset = "0x3006260", VA = "0x183007C60")]
		private void CollectTargetsFromChildren()
		{
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x3007DA0", Offset = "0x30063A0", VA = "0x183007DA0")]
		private void ClearNulls()
		{
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x3007DB0", Offset = "0x30063B0", VA = "0x183007DB0")]
		private void OnValidate()
		{
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x3007DC0", Offset = "0x30063C0", VA = "0x183007DC0")]
		private void OnValidateInternal(bool removeNulls)
		{
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
		public string GetText()
		{
			return null;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x3008030", Offset = "0x3006630", VA = "0x183008030")]
		public void SetText(string sourceString)
		{
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public LinkTextGui()
		{
		}

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _textValue;

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<TMP_Text> _textTargets;

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _toUpper;
	}
}
