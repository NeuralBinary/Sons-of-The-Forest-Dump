using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Sons.Gui.Multiplayer
{
	// Token: 0x0200001D RID: 29
	[Token(Token = "0x200001D")]
	public class ServerInfoGuiItemButton : MonoBehaviour
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x1700000F")]
		public Button Button
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x3038160", Offset = "0x3036760", VA = "0x183038160")]
		public void SetActive(bool active)
		{
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x3038240", Offset = "0x3036840", VA = "0x183038240")]
		private void On()
		{
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x30382C0", Offset = "0x30368C0", VA = "0x1830382C0")]
		private void Off()
		{
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ServerInfoGuiItemButton()
		{
		}

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x20")]
		[Header("This Components")]
		[SerializeField]
		private Button _button;

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _content;
	}
}
