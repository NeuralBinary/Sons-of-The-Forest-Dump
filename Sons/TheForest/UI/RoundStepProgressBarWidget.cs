using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using NGUI.UI;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x020003F8 RID: 1016
	[Token(Token = "0x20003F8")]
	public class RoundStepProgressBarWidget : MonoBehaviour
	{
		// Token: 0x06001B4B RID: 6987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B4B")]
		[Address(RVA = "0x32B4CC0", Offset = "0x32B32C0", VA = "0x1832B4CC0")]
		public void Show(int currentStep, int maxSteps, bool canAdd)
		{
		}

		// Token: 0x06001B4C RID: 6988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B4C")]
		[Address(RVA = "0x32B54E0", Offset = "0x32B3AE0", VA = "0x1832B54E0")]
		public void Hide()
		{
		}

		// Token: 0x06001B4D RID: 6989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B4D")]
		[Address(RVA = "0x32B5630", Offset = "0x32B3C30", VA = "0x1832B5630")]
		private UISprite GetStepSprite()
		{
			return null;
		}

		// Token: 0x06001B4E RID: 6990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B4E")]
		[Address(RVA = "0x32B59E0", Offset = "0x32B3FE0", VA = "0x1832B59E0")]
		private void ReturnStepSprite(UISprite stepSprite)
		{
		}

		// Token: 0x06001B4F RID: 6991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B4F")]
		[Address(RVA = "0x32B5AE0", Offset = "0x32B40E0", VA = "0x1832B5AE0")]
		private void UpdateIconColor(bool canAdd)
		{
		}

		// Token: 0x06001B50 RID: 6992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B50")]
		[Address(RVA = "0x32B5BF0", Offset = "0x32B41F0", VA = "0x1832B5BF0")]
		public RoundStepProgressBarWidget()
		{
		}

		// Token: 0x04001A7E RID: 6782
		[Token(Token = "0x4001A7E")]
		[FieldOffset(Offset = "0x20")]
		[Header("Icon")]
		public UISprite _icon;

		// Token: 0x04001A7F RID: 6783
		[Token(Token = "0x4001A7F")]
		[FieldOffset(Offset = "0x28")]
		public Color _canAddColor;

		// Token: 0x04001A80 RID: 6784
		[Token(Token = "0x4001A80")]
		[FieldOffset(Offset = "0x38")]
		public Color _cannotAddColor;

		// Token: 0x04001A81 RID: 6785
		[Token(Token = "0x4001A81")]
		[FieldOffset(Offset = "0x48")]
		[Header("Round steps")]
		public UISprite _stepSprite;

		// Token: 0x04001A82 RID: 6786
		[Token(Token = "0x4001A82")]
		[FieldOffset(Offset = "0x50")]
		public Color _clearColor;

		// Token: 0x04001A83 RID: 6787
		[Token(Token = "0x4001A83")]
		[FieldOffset(Offset = "0x60")]
		public Color _filledColor;

		// Token: 0x04001A84 RID: 6788
		[Token(Token = "0x4001A84")]
		[FieldOffset(Offset = "0x70")]
		private bool _lastIconCanAddState;

		// Token: 0x04001A85 RID: 6789
		[Token(Token = "0x4001A85")]
		[FieldOffset(Offset = "0x74")]
		private int _lastCurrentStepDisplayed;

		// Token: 0x04001A86 RID: 6790
		[Token(Token = "0x4001A86")]
		[FieldOffset(Offset = "0x78")]
		private Queue<UISprite> _pooledStepSprites;

		// Token: 0x04001A87 RID: 6791
		[Token(Token = "0x4001A87")]
		[FieldOffset(Offset = "0x80")]
		private Stack<UISprite> _shownStepSprites;
	}
}
