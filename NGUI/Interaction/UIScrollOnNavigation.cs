using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NGUI.Interaction
{
	// Token: 0x020000D1 RID: 209
	[Token(Token = "0x20000D1")]
	public class UIScrollOnNavigation : MonoBehaviour
	{
		// Token: 0x06000776 RID: 1910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000776")]
		[Address(RVA = "0x26D68D0", Offset = "0x26D4ED0", VA = "0x1826D68D0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000777")]
		[Address(RVA = "0x26D6BD0", Offset = "0x26D51D0", VA = "0x1826D6BD0")]
		private void OnDisable()
		{
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000778")]
		[Address(RVA = "0x26D6D60", Offset = "0x26D5360", VA = "0x1826D6D60")]
		private void UICamera_OnNavigate(GameObject aObject, KeyCode key)
		{
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000779")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public UIScrollOnNavigation()
		{
		}

		// Token: 0x0400057D RID: 1405
		[Token(Token = "0x400057D")]
		[FieldOffset(Offset = "0x20")]
		public UIScrollView scrollView;

		// Token: 0x0400057E RID: 1406
		[Token(Token = "0x400057E")]
		[FieldOffset(Offset = "0x28")]
		public UIScrollBar scrollBar;

		// Token: 0x0400057F RID: 1407
		[Token(Token = "0x400057F")]
		[FieldOffset(Offset = "0x30")]
		public bool ResetOnEnable;

		// Token: 0x04000580 RID: 1408
		[Token(Token = "0x4000580")]
		[FieldOffset(Offset = "0x34")]
		public float m_BottomScreenThresholdY;

		// Token: 0x04000581 RID: 1409
		[Token(Token = "0x4000581")]
		[FieldOffset(Offset = "0x38")]
		public float m_UpperScreenThreadholdY;
	}
}
