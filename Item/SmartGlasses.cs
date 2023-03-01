using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Item
{
	// Token: 0x020005A9 RID: 1449
	[Token(Token = "0x20005A9")]
	[AddComponentMenu("Sons/Item/Smart Glasses")]
	public class SmartGlasses : MonoBehaviour
	{
		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06002552 RID: 9554 RVA: 0x0000AF20 File Offset: 0x00009120
		// (set) Token: 0x06002553 RID: 9555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000502")]
		public bool IsEquipped
		{
			[Token(Token = "0x6002552")]
			[Address(RVA = "0x1E52250", Offset = "0x1E51250", VA = "0x181E52250")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002553")]
			[Address(RVA = "0x1E52300", Offset = "0x1E51300", VA = "0x181E52300")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002554 RID: 9556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002554")]
		[Address(RVA = "0x2D90370", Offset = "0x2D8F370", VA = "0x182D90370")]
		private void Update()
		{
		}

		// Token: 0x06002555 RID: 9557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002555")]
		[Address(RVA = "0x2D8FF90", Offset = "0x2D8EF90", VA = "0x182D8FF90")]
		public void Toggle()
		{
		}

		// Token: 0x06002556 RID: 9558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002556")]
		[Address(RVA = "0x2D8FD80", Offset = "0x2D8ED80", VA = "0x182D8FD80")]
		private IEnumerator Fade(bool fadeIn)
		{
			return null;
		}

		// Token: 0x06002557 RID: 9559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002557")]
		[Address(RVA = "0x2D8FE00", Offset = "0x2D8EE00", VA = "0x182D8FE00")]
		private void OnFadeBegan()
		{
		}

		// Token: 0x06002558 RID: 9560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002558")]
		[Address(RVA = "0x2D8FE90", Offset = "0x2D8EE90", VA = "0x182D8FE90")]
		private void OnFadeEnded()
		{
		}

		// Token: 0x06002559 RID: 9561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002559")]
		[Address(RVA = "0x2B704B0", Offset = "0x2B6F4B0", VA = "0x182B704B0")]
		private void UpdatePadding()
		{
		}

		// Token: 0x0600255A RID: 9562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600255A")]
		[Address(RVA = "0x2D900C0", Offset = "0x2D8F0C0", VA = "0x182D900C0")]
		private void UpdateHeldAnimation()
		{
		}

		// Token: 0x0600255B RID: 9563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600255B")]
		[Address(RVA = "0x2D8FF20", Offset = "0x2D8EF20", VA = "0x182D8FF20")]
		private void SetHeadMountedRendererVisibility(bool onOff)
		{
		}

		// Token: 0x0600255C RID: 9564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600255C")]
		[Address(RVA = "0x2D8FB90", Offset = "0x2D8EB90", VA = "0x182D8FB90")]
		private void DisableRendererVisibility(bool onOff)
		{
		}

		// Token: 0x0600255D RID: 9565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600255D")]
		[Address(RVA = "0x2D905D0", Offset = "0x2D8F5D0", VA = "0x182D905D0")]
		public SmartGlasses()
		{
		}

		// Token: 0x040021A3 RID: 8611
		[Token(Token = "0x40021A3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[ItemIdPicker]
		private int _itemId;

		// Token: 0x040021A4 RID: 8612
		[Token(Token = "0x40021A4")]
		[FieldOffset(Offset = "0x28")]
		[Header("Main Image & Padding:")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x040021A5 RID: 8613
		[Token(Token = "0x40021A5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _outline;

		// Token: 0x040021A6 RID: 8614
		[Token(Token = "0x40021A6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _leftPad;

		// Token: 0x040021A7 RID: 8615
		[Token(Token = "0x40021A7")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _rightPad;

		// Token: 0x040021A8 RID: 8616
		[Token(Token = "0x40021A8")]
		[FieldOffset(Offset = "0x48")]
		[Header("Other:")]
		[SerializeField]
		private LayerMask _constructionGhostLayer;

		// Token: 0x040021A9 RID: 8617
		[Token(Token = "0x40021A9")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float _fadeSpeed;

		// Token: 0x040021AA RID: 8618
		[Token(Token = "0x40021AA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SkinnedMeshRenderer[] HideRenderers;

		// Token: 0x040021AB RID: 8619
		[Token(Token = "0x40021AB")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private MeshRenderer[] _headMountedRenderers;

		// Token: 0x040021AC RID: 8620
		[Token(Token = "0x40021AC")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Animation _headMountedAnim;

		// Token: 0x040021AE RID: 8622
		[Token(Token = "0x40021AE")]
		[FieldOffset(Offset = "0x69")]
		private bool _isActive;

		// Token: 0x040021AF RID: 8623
		[Token(Token = "0x40021AF")]
		[FieldOffset(Offset = "0x6A")]
		private bool _isFading;

		// Token: 0x040021B0 RID: 8624
		[Token(Token = "0x40021B0")]
		[FieldOffset(Offset = "0x6B")]
		private bool _allowToggle;

		// Token: 0x040021B1 RID: 8625
		[Token(Token = "0x40021B1")]
		[FieldOffset(Offset = "0x6C")]
		private bool _toggleAnimation;

		// Token: 0x040021B2 RID: 8626
		[Token(Token = "0x40021B2")]
		[FieldOffset(Offset = "0x6D")]
		private bool _wasEquipped;

		// Token: 0x040021B3 RID: 8627
		[Token(Token = "0x40021B3")]
		[FieldOffset(Offset = "0x70")]
		private MeshRenderer[] _heldRenderers;

		// Token: 0x040021B4 RID: 8628
		[Token(Token = "0x40021B4")]
		[FieldOffset(Offset = "0x78")]
		private bool _overrideKeyPressed;
	}
}
