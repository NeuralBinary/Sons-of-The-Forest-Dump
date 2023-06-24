using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x0200080F RID: 2063
	[Token(Token = "0x200080F")]
	[AddComponentMenu("Sons/Gameplay/Binoculars")]
	public class Binoculars : MonoBehaviour
	{
		// Token: 0x0600383D RID: 14397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600383D")]
		[Address(RVA = "0x35525B0", Offset = "0x3550BB0", VA = "0x1835525B0")]
		public void Activate(bool activate)
		{
		}

		// Token: 0x0600383E RID: 14398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600383E")]
		[Address(RVA = "0x3552670", Offset = "0x3550C70", VA = "0x183552670")]
		private void Start()
		{
		}

		// Token: 0x0600383F RID: 14399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600383F")]
		[Address(RVA = "0x3552700", Offset = "0x3550D00", VA = "0x183552700")]
		private void Update()
		{
		}

		// Token: 0x06003840 RID: 14400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003840")]
		[Address(RVA = "0x3552750", Offset = "0x3550D50", VA = "0x183552750")]
		private void Toggle()
		{
		}

		// Token: 0x06003841 RID: 14401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003841")]
		[Address(RVA = "0x3552860", Offset = "0x3550E60", VA = "0x183552860")]
		private IEnumerator Fade(bool fadeIn)
		{
			return null;
		}

		// Token: 0x06003842 RID: 14402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003842")]
		[Address(RVA = "0x3552920", Offset = "0x3550F20", VA = "0x183552920")]
		private void UpdatePadding()
		{
		}

		// Token: 0x06003843 RID: 14403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003843")]
		[Address(RVA = "0x3552BF0", Offset = "0x35511F0", VA = "0x183552BF0")]
		public Binoculars()
		{
		}

		// Token: 0x040030A1 RID: 12449
		[Token(Token = "0x40030A1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _binocularsOutline;

		// Token: 0x040030A2 RID: 12450
		[Token(Token = "0x40030A2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _leftPad;

		// Token: 0x040030A3 RID: 12451
		[Token(Token = "0x40030A3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _rightPad;

		// Token: 0x040030A4 RID: 12452
		[Token(Token = "0x40030A4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _fadeSpeed;

		// Token: 0x040030A5 RID: 12453
		[Token(Token = "0x40030A5")]
		[FieldOffset(Offset = "0x3C")]
		private bool _isActive;

		// Token: 0x040030A6 RID: 12454
		[Token(Token = "0x40030A6")]
		[FieldOffset(Offset = "0x3D")]
		private bool _isFading;

		// Token: 0x040030A7 RID: 12455
		[Token(Token = "0x40030A7")]
		[FieldOffset(Offset = "0x3E")]
		private bool _allowToggle;

		// Token: 0x040030A8 RID: 12456
		[Token(Token = "0x40030A8")]
		[FieldOffset(Offset = "0x3F")]
		private bool _toggleAnimation;

		// Token: 0x040030A9 RID: 12457
		[Token(Token = "0x40030A9")]
		[FieldOffset(Offset = "0x40")]
		private bool _wasEquipped;

		// Token: 0x040030AA RID: 12458
		[Token(Token = "0x40030AA")]
		[FieldOffset(Offset = "0x48")]
		private CanvasGroup _canvasGroup;
	}
}
