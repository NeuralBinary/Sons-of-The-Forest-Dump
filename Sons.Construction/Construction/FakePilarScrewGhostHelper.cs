using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Crafting.Structures;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200011C RID: 284
	[Token(Token = "0x200011C")]
	[AddComponentMenu("Sons/Construction/FakePilarScrewGhostHelper")]
	public class FakePilarScrewGhostHelper : MonoBehaviour, IActivateIngredientRendererReceiver
	{
		// Token: 0x060007E2 RID: 2018 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x2E4DD40", Offset = "0x2E4C340", VA = "0x182E4DD40")]
		public void Register(NavmeshCutScrewGhostHelper master)
		{
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x2E4DE40", Offset = "0x2E4C440", VA = "0x182E4DE40", Slot = "4")]
		public void OnActivateIngredientRenderer()
		{
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x2E4DE50", Offset = "0x2E4C450", VA = "0x182E4DE50", Slot = "5")]
		public void OnGhostIngredientRenderer()
		{
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x2E4DFF0", Offset = "0x2E4C5F0", VA = "0x182E4DFF0")]
		public void Toggle(bool onOff)
		{
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x2E4E340", Offset = "0x2E4C940", VA = "0x182E4E340")]
		public FakePilarScrewGhostHelper()
		{
		}

		// Token: 0x040005EF RID: 1519
		[Token(Token = "0x40005EF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<NavmeshCutScrewGhostHelper> _masters;
	}
}
