using System;
using System.Collections;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

// Token: 0x0200005D RID: 93
[Token(Token = "0x200005D")]
public class Mask : MonoBehaviour
{
	// Token: 0x06000291 RID: 657 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000291")]
	[Address(RVA = "0x2B6E9F0", Offset = "0x2B6D9F0", VA = "0x182B6E9F0")]
	private void Start()
	{
	}

	// Token: 0x06000292 RID: 658 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000292")]
	[Address(RVA = "0x2B6EF90", Offset = "0x2B6DF90", VA = "0x182B6EF90")]
	private void Update()
	{
	}

	// Token: 0x06000293 RID: 659 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000293")]
	[Address(RVA = "0x2B6EA40", Offset = "0x2B6DA40", VA = "0x182B6EA40")]
	public void Toggle()
	{
	}

	// Token: 0x06000294 RID: 660 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000294")]
	[Address(RVA = "0x2B6E970", Offset = "0x2B6D970", VA = "0x182B6E970")]
	private IEnumerator Fade(bool fadeIn)
	{
		return null;
	}

	// Token: 0x06000295 RID: 661 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000295")]
	[Address(RVA = "0x2B6EE60", Offset = "0x2B6DE60", VA = "0x182B6EE60")]
	private void UpdatePadding()
	{
	}

	// Token: 0x06000296 RID: 662 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000296")]
	[Address(RVA = "0x2B6EB70", Offset = "0x2B6DB70", VA = "0x182B6EB70")]
	private void UpdateHeldAnimation()
	{
	}

	// Token: 0x06000297 RID: 663 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000297")]
	[Address(RVA = "0x2B6E780", Offset = "0x2B6D780", VA = "0x182B6E780")]
	private void DisableRendererVisibility(bool onOff)
	{
	}

	// Token: 0x06000298 RID: 664 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000298")]
	[Address(RVA = "0x2B6F2D0", Offset = "0x2B6E2D0", VA = "0x182B6F2D0")]
	public Mask()
	{
	}

	// Token: 0x04000279 RID: 633
	[Token(Token = "0x4000279")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[ItemIdPicker]
	private int _itemId;

	// Token: 0x0400027A RID: 634
	[Token(Token = "0x400027A")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Header("Main Image & Padding:")]
	private RectTransform _outline;

	// Token: 0x0400027B RID: 635
	[Token(Token = "0x400027B")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private RectTransform _leftPad;

	// Token: 0x0400027C RID: 636
	[Token(Token = "0x400027C")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private RectTransform _rightPad;

	// Token: 0x0400027D RID: 637
	[Token(Token = "0x400027D")]
	[FieldOffset(Offset = "0x40")]
	[Header("Other:")]
	[SerializeField]
	private float _fadeSpeed;

	// Token: 0x0400027E RID: 638
	[Token(Token = "0x400027E")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private SkinnedMeshRenderer[] HideRenderers;

	// Token: 0x0400027F RID: 639
	[Token(Token = "0x400027F")]
	[FieldOffset(Offset = "0x50")]
	private bool _isActive;

	// Token: 0x04000280 RID: 640
	[Token(Token = "0x4000280")]
	[FieldOffset(Offset = "0x51")]
	private bool _isFading;

	// Token: 0x04000281 RID: 641
	[Token(Token = "0x4000281")]
	[FieldOffset(Offset = "0x52")]
	private bool _allowToggle;

	// Token: 0x04000282 RID: 642
	[Token(Token = "0x4000282")]
	[FieldOffset(Offset = "0x53")]
	private bool _toggleAnimation;

	// Token: 0x04000283 RID: 643
	[Token(Token = "0x4000283")]
	[FieldOffset(Offset = "0x54")]
	private bool _wasEquipped;

	// Token: 0x04000284 RID: 644
	[Token(Token = "0x4000284")]
	[FieldOffset(Offset = "0x58")]
	private CanvasGroup _canvasGroup;

	// Token: 0x04000285 RID: 645
	[Token(Token = "0x4000285")]
	[FieldOffset(Offset = "0x60")]
	private MeshRenderer[] _heldRenderers;

	// Token: 0x04000286 RID: 646
	[Token(Token = "0x4000286")]
	[FieldOffset(Offset = "0x68")]
	private bool _overrideKeyPressed;
}
