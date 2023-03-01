using System;
using System.Collections;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

// Token: 0x0200005B RID: 91
[Token(Token = "0x200005B")]
public class Binoculars : MonoBehaviour
{
	// Token: 0x06000281 RID: 641 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000281")]
	[Address(RVA = "0x2B5F6E0", Offset = "0x2B5E6E0", VA = "0x182B5F6E0")]
	private void Start()
	{
	}

	// Token: 0x06000282 RID: 642 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000282")]
	[Address(RVA = "0x2B5FFF0", Offset = "0x2B5EFF0", VA = "0x182B5FFF0")]
	private void Update()
	{
	}

	// Token: 0x06000283 RID: 643 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000283")]
	[Address(RVA = "0x2B5F780", Offset = "0x2B5E780", VA = "0x182B5F780")]
	public void Toggle()
	{
	}

	// Token: 0x06000284 RID: 644 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000284")]
	[Address(RVA = "0x2B5F660", Offset = "0x2B5E660", VA = "0x182B5F660")]
	private IEnumerator Fade(bool fadeIn)
	{
		return null;
	}

	// Token: 0x06000285 RID: 645 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000285")]
	[Address(RVA = "0x2B5FE20", Offset = "0x2B5EE20", VA = "0x182B5FE20")]
	private void UpdateZoom()
	{
	}

	// Token: 0x06000286 RID: 646 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000286")]
	[Address(RVA = "0x2B5F8F0", Offset = "0x2B5E8F0", VA = "0x182B5F8F0")]
	private void UpdateFov()
	{
	}

	// Token: 0x06000287 RID: 647 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000287")]
	[Address(RVA = "0x2B5FCF0", Offset = "0x2B5ECF0", VA = "0x182B5FCF0")]
	private void UpdatePadding()
	{
	}

	// Token: 0x06000288 RID: 648 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000288")]
	[Address(RVA = "0x2B5FA00", Offset = "0x2B5EA00", VA = "0x182B5FA00")]
	private void UpdateHeldAnimation()
	{
	}

	// Token: 0x06000289 RID: 649 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000289")]
	[Address(RVA = "0x2B5F480", Offset = "0x2B5E480", VA = "0x182B5F480")]
	private void DisableRendererVisibility(bool onOff)
	{
	}

	// Token: 0x0600028A RID: 650 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600028A")]
	[Address(RVA = "0x2B602D0", Offset = "0x2B5F2D0", VA = "0x182B602D0")]
	public Binoculars()
	{
	}

	// Token: 0x04000261 RID: 609
	[Token(Token = "0x4000261")]
	[FieldOffset(Offset = "0x20")]
	[ItemIdPicker]
	[SerializeField]
	private int _binocularsId;

	// Token: 0x04000262 RID: 610
	[Token(Token = "0x4000262")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Header("Field of View:")]
	private float _maxZoomFov;

	// Token: 0x04000263 RID: 611
	[Token(Token = "0x4000263")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _smoothFovSpeed;

	// Token: 0x04000264 RID: 612
	[Token(Token = "0x4000264")]
	[FieldOffset(Offset = "0x2C")]
	[Header("Zoom:")]
	[SerializeField]
	private int _zoomSpeed;

	// Token: 0x04000265 RID: 613
	[Token(Token = "0x4000265")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool _smoothZoom;

	// Token: 0x04000266 RID: 614
	[Token(Token = "0x4000266")]
	[FieldOffset(Offset = "0x38")]
	[Header("Main Image & Padding:")]
	[SerializeField]
	private RectTransform _binocularsOutline;

	// Token: 0x04000267 RID: 615
	[Token(Token = "0x4000267")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private RectTransform _leftPad;

	// Token: 0x04000268 RID: 616
	[Token(Token = "0x4000268")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private RectTransform _rightPad;

	// Token: 0x04000269 RID: 617
	[Token(Token = "0x4000269")]
	[FieldOffset(Offset = "0x50")]
	[Header("Other:")]
	[SerializeField]
	private float _fadeSpeed;

	// Token: 0x0400026A RID: 618
	[Token(Token = "0x400026A")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private SkinnedMeshRenderer[] HideRenderers;

	// Token: 0x0400026B RID: 619
	[Token(Token = "0x400026B")]
	[FieldOffset(Offset = "0x60")]
	private bool _isActive;

	// Token: 0x0400026C RID: 620
	[Token(Token = "0x400026C")]
	[FieldOffset(Offset = "0x61")]
	private bool _isFading;

	// Token: 0x0400026D RID: 621
	[Token(Token = "0x400026D")]
	[FieldOffset(Offset = "0x62")]
	private bool _allowToggle;

	// Token: 0x0400026E RID: 622
	[Token(Token = "0x400026E")]
	[FieldOffset(Offset = "0x63")]
	private bool _toggleAnimation;

	// Token: 0x0400026F RID: 623
	[Token(Token = "0x400026F")]
	[FieldOffset(Offset = "0x64")]
	private bool _wasEquipped;

	// Token: 0x04000270 RID: 624
	[Token(Token = "0x4000270")]
	[FieldOffset(Offset = "0x68")]
	private float _minZoomFov;

	// Token: 0x04000271 RID: 625
	[Token(Token = "0x4000271")]
	[FieldOffset(Offset = "0x6C")]
	private float _currentFov;

	// Token: 0x04000272 RID: 626
	[Token(Token = "0x4000272")]
	[FieldOffset(Offset = "0x70")]
	private CanvasGroup _canvasGroup;

	// Token: 0x04000273 RID: 627
	[Token(Token = "0x4000273")]
	[FieldOffset(Offset = "0x78")]
	private MeshRenderer _heldBinocularRenderer;
}
