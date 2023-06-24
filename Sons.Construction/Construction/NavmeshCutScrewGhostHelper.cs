using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Crafting.Structures;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000125 RID: 293
	[Token(Token = "0x2000125")]
	[AddComponentMenu("Sons/Construction/NavmeshCutScrewGhostHelper")]
	public class NavmeshCutScrewGhostHelper : MonoBehaviour, IActivateIngredientRendererReceiver
	{
		// Token: 0x06000807 RID: 2055 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000807")]
		[Address(RVA = "0x2E51480", Offset = "0x2E4FA80", VA = "0x182E51480", Slot = "4")]
		public void OnActivateIngredientRenderer()
		{
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000808")]
		[Address(RVA = "0x2E51650", Offset = "0x2E4FC50", VA = "0x182E51650", Slot = "5")]
		public void OnGhostIngredientRenderer()
		{
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000809")]
		[Address(RVA = "0x2E517E0", Offset = "0x2E4FDE0", VA = "0x182E517E0")]
		public void Register(FakePilarScrewGhostHelper helper)
		{
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600080A")]
		[Address(RVA = "0x2E518E0", Offset = "0x2E4FEE0", VA = "0x182E518E0")]
		public NavmeshCutScrewGhostHelper()
		{
		}

		// Token: 0x040005F9 RID: 1529
		[Token(Token = "0x40005F9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<FakePilarScrewGhostHelper> _linkedHelpers;
	}
}
