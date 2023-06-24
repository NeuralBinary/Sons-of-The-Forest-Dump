using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Item
{
	// Token: 0x020005B9 RID: 1465
	[Token(Token = "0x20005B9")]
	[AddComponentMenu("Sons/Item/Smart Glasses")]
	public class SmartGlasses : MonoBehaviour
	{
		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06002651 RID: 9809 RVA: 0x0000B5E0 File Offset: 0x000097E0
		// (set) Token: 0x06002652 RID: 9810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000516")]
		public bool IsEquipped
		{
			[Token(Token = "0x6002651")]
			[Address(RVA = "0x15771D0", Offset = "0x15757D0", VA = "0x1815771D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002652")]
			[Address(RVA = "0x15771E0", Offset = "0x15757E0", VA = "0x1815771E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002653 RID: 9811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002653")]
		[Address(RVA = "0x33AA240", Offset = "0x33A8840", VA = "0x1833AA240")]
		private void Update()
		{
		}

		// Token: 0x06002654 RID: 9812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002654")]
		[Address(RVA = "0x33AA440", Offset = "0x33A8A40", VA = "0x1833AA440")]
		public void Toggle()
		{
		}

		// Token: 0x06002655 RID: 9813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002655")]
		[Address(RVA = "0x33AA5D0", Offset = "0x33A8BD0", VA = "0x1833AA5D0")]
		private IEnumerator Fade(bool fadeIn)
		{
			return null;
		}

		// Token: 0x06002656 RID: 9814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002656")]
		[Address(RVA = "0x33AA690", Offset = "0x33A8C90", VA = "0x1833AA690")]
		private void OnFadeBegan()
		{
		}

		// Token: 0x06002657 RID: 9815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002657")]
		[Address(RVA = "0x33AA780", Offset = "0x33A8D80", VA = "0x1833AA780")]
		private void OnFadeEnded()
		{
		}

		// Token: 0x06002658 RID: 9816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002658")]
		[Address(RVA = "0x33AA870", Offset = "0x33A8E70", VA = "0x1833AA870")]
		private void UpdatePadding()
		{
		}

		// Token: 0x06002659 RID: 9817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002659")]
		[Address(RVA = "0x33AAB40", Offset = "0x33A9140", VA = "0x1833AAB40")]
		private void UpdateHeldAnimation()
		{
		}

		// Token: 0x0600265A RID: 9818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600265A")]
		[Address(RVA = "0x33AADF0", Offset = "0x33A93F0", VA = "0x1833AADF0")]
		private void SetHeadMountedRendererVisibility(bool onOff)
		{
		}

		// Token: 0x0600265B RID: 9819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600265B")]
		[Address(RVA = "0x33AAEA0", Offset = "0x33A94A0", VA = "0x1833AAEA0")]
		private void DisableRendererVisibility(bool onOff)
		{
		}

		// Token: 0x0600265C RID: 9820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600265C")]
		[Address(RVA = "0x33AB1A0", Offset = "0x33A97A0", VA = "0x1833AB1A0")]
		public SmartGlasses()
		{
		}

		// Token: 0x04002277 RID: 8823
		[Token(Token = "0x4002277")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[ItemIdPicker]
		private int _itemId;

		// Token: 0x04002278 RID: 8824
		[Token(Token = "0x4002278")]
		[FieldOffset(Offset = "0x28")]
		[Header("Main Image & Padding:")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04002279 RID: 8825
		[Token(Token = "0x4002279")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _outline;

		// Token: 0x0400227A RID: 8826
		[Token(Token = "0x400227A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _leftPad;

		// Token: 0x0400227B RID: 8827
		[Token(Token = "0x400227B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _rightPad;

		// Token: 0x0400227C RID: 8828
		[Token(Token = "0x400227C")]
		[FieldOffset(Offset = "0x48")]
		[Header("Other:")]
		[SerializeField]
		private LayerMask _constructionGhostLayer;

		// Token: 0x0400227D RID: 8829
		[Token(Token = "0x400227D")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float _fadeSpeed;

		// Token: 0x0400227E RID: 8830
		[Token(Token = "0x400227E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SkinnedMeshRenderer[] HideRenderers;

		// Token: 0x0400227F RID: 8831
		[Token(Token = "0x400227F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private MeshRenderer[] _headMountedRenderers;

		// Token: 0x04002280 RID: 8832
		[Token(Token = "0x4002280")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Animation _headMountedAnim;

		// Token: 0x04002282 RID: 8834
		[Token(Token = "0x4002282")]
		[FieldOffset(Offset = "0x69")]
		private bool _isActive;

		// Token: 0x04002283 RID: 8835
		[Token(Token = "0x4002283")]
		[FieldOffset(Offset = "0x6A")]
		private bool _isFading;

		// Token: 0x04002284 RID: 8836
		[Token(Token = "0x4002284")]
		[FieldOffset(Offset = "0x6B")]
		private bool _allowToggle;

		// Token: 0x04002285 RID: 8837
		[Token(Token = "0x4002285")]
		[FieldOffset(Offset = "0x6C")]
		private bool _toggleAnimation;

		// Token: 0x04002286 RID: 8838
		[Token(Token = "0x4002286")]
		[FieldOffset(Offset = "0x6D")]
		private bool _wasEquipped;

		// Token: 0x04002287 RID: 8839
		[Token(Token = "0x4002287")]
		[FieldOffset(Offset = "0x70")]
		private MeshRenderer[] _heldRenderers;

		// Token: 0x04002288 RID: 8840
		[Token(Token = "0x4002288")]
		[FieldOffset(Offset = "0x78")]
		private bool _overrideKeyPressed;
	}
}
