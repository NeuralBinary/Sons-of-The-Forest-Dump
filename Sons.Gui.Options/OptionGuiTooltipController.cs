using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Components;
using UnityEngine.UI;

namespace Sons.Gui.Options
{
	// Token: 0x02000053 RID: 83
	[Token(Token = "0x2000053")]
	public class OptionGuiTooltipController : MonoBehaviour
	{
		// Token: 0x06000188 RID: 392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x3046760", Offset = "0x3044D60", VA = "0x183046760")]
		private void Awake()
		{
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x30467E0", Offset = "0x3044DE0", VA = "0x1830467E0")]
		public void Update()
		{
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x3046940", Offset = "0x3044F40", VA = "0x183046940")]
		private void ApplyAlpha(float alpha)
		{
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x3046A60", Offset = "0x3045060", VA = "0x183046A60")]
		private void RefreshVisibility()
		{
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x3046A70", Offset = "0x3045070", VA = "0x183046A70")]
		public void SetTooltip(string tooltipKey, LocalizedString label)
		{
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x3046C80", Offset = "0x3045280", VA = "0x183046C80")]
		public OptionGuiTooltipController()
		{
		}

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x20")]
		[Header("Properties")]
		[SerializeField]
		private float _fadeInDuration;

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _fadeOutDuration;

		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _persistenceDuration;

		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x30")]
		[Header("Gui Links")]
		[SerializeField]
		private LocalizeStringEvent _localizedString;

		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _background;

		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TMP_Text _text;

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x48")]
		[Header("Debug")]
		private float _alpha;

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x4C")]
		private float _alphaTarget;

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x50")]
		private float _persistenceTimer;

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x54")]
		private float _initialBackgroundColorAlpha;

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x58")]
		private float _initialTextColorAlpha;

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x60")]
		private string _lastTooltipKey;
	}
}
