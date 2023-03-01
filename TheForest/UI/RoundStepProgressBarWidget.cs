using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using NGUI.UI;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x02000406 RID: 1030
	[Token(Token = "0x2000406")]
	public class RoundStepProgressBarWidget : MonoBehaviour
	{
		// Token: 0x06001B0D RID: 6925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B0D")]
		[Address(RVA = "0x2CEA730", Offset = "0x2CE9730", VA = "0x182CEA730")]
		public void Show(int currentStep, int maxSteps, bool canAdd)
		{
		}

		// Token: 0x06001B0E RID: 6926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B0E")]
		[Address(RVA = "0x2CEA660", Offset = "0x2CE9660", VA = "0x182CEA660")]
		public void Hide()
		{
		}

		// Token: 0x06001B0F RID: 6927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B0F")]
		[Address(RVA = "0x2CEA480", Offset = "0x2CE9480", VA = "0x182CEA480")]
		private UISprite GetStepSprite()
		{
			return null;
		}

		// Token: 0x06001B10 RID: 6928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B10")]
		[Address(RVA = "0x2CEA6B0", Offset = "0x2CE96B0", VA = "0x182CEA6B0")]
		private void ReturnStepSprite(UISprite stepSprite)
		{
		}

		// Token: 0x06001B11 RID: 6929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B11")]
		[Address(RVA = "0x2CEABC0", Offset = "0x2CE9BC0", VA = "0x182CEABC0")]
		private void UpdateIconColor(bool canAdd)
		{
		}

		// Token: 0x06001B12 RID: 6930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B12")]
		[Address(RVA = "0x2CEAC70", Offset = "0x2CE9C70", VA = "0x182CEAC70")]
		public RoundStepProgressBarWidget()
		{
		}

		// Token: 0x04001A5A RID: 6746
		[Token(Token = "0x4001A5A")]
		[FieldOffset(Offset = "0x20")]
		[Header("Icon")]
		public UISprite _icon;

		// Token: 0x04001A5B RID: 6747
		[Token(Token = "0x4001A5B")]
		[FieldOffset(Offset = "0x28")]
		public Color _canAddColor;

		// Token: 0x04001A5C RID: 6748
		[Token(Token = "0x4001A5C")]
		[FieldOffset(Offset = "0x38")]
		public Color _cannotAddColor;

		// Token: 0x04001A5D RID: 6749
		[Token(Token = "0x4001A5D")]
		[FieldOffset(Offset = "0x48")]
		[Header("Round steps")]
		public UISprite _stepSprite;

		// Token: 0x04001A5E RID: 6750
		[Token(Token = "0x4001A5E")]
		[FieldOffset(Offset = "0x50")]
		public Color _clearColor;

		// Token: 0x04001A5F RID: 6751
		[Token(Token = "0x4001A5F")]
		[FieldOffset(Offset = "0x60")]
		public Color _filledColor;

		// Token: 0x04001A60 RID: 6752
		[Token(Token = "0x4001A60")]
		[FieldOffset(Offset = "0x70")]
		private bool _lastIconCanAddState;

		// Token: 0x04001A61 RID: 6753
		[Token(Token = "0x4001A61")]
		[FieldOffset(Offset = "0x74")]
		private int _lastCurrentStepDisplayed;

		// Token: 0x04001A62 RID: 6754
		[Token(Token = "0x4001A62")]
		[FieldOffset(Offset = "0x78")]
		private Queue<UISprite> _pooledStepSprites;

		// Token: 0x04001A63 RID: 6755
		[Token(Token = "0x4001A63")]
		[FieldOffset(Offset = "0x80")]
		private Stack<UISprite> _shownStepSprites;
	}
}
