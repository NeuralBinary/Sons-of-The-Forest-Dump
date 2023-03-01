using System;
using System.Collections;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200005F RID: 95
[Token(Token = "0x200005F")]
public class NightVisionGoggles : MonoBehaviour
{
	// Token: 0x0600029F RID: 671 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600029F")]
	[Address(RVA = "0x2B6FDD0", Offset = "0x2B6EDD0", VA = "0x182B6FDD0")]
	private void Awake()
	{
	}

	// Token: 0x060002A0 RID: 672 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x2B705E0", Offset = "0x2B6F5E0", VA = "0x182B705E0")]
	private void UpdateVolume(bool onOff)
	{
	}

	// Token: 0x060002A1 RID: 673 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x2B706A0", Offset = "0x2B6F6A0", VA = "0x182B706A0")]
	private void Update()
	{
	}

	// Token: 0x060002A2 RID: 674 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x2B70090", Offset = "0x2B6F090", VA = "0x182B70090")]
	public void Toggle()
	{
	}

	// Token: 0x060002A3 RID: 675 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x2B6FE30", Offset = "0x2B6EE30", VA = "0x182B6FE30")]
	private IEnumerator Fade(bool fadeIn)
	{
		return null;
	}

	// Token: 0x060002A4 RID: 676 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x2B704B0", Offset = "0x2B6F4B0", VA = "0x182B704B0")]
	private void UpdatePadding()
	{
	}

	// Token: 0x060002A5 RID: 677 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x2B701C0", Offset = "0x2B6F1C0", VA = "0x182B701C0")]
	private void UpdateHeldAnimation()
	{
	}

	// Token: 0x060002A6 RID: 678 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x2B6FEB0", Offset = "0x2B6EEB0", VA = "0x182B6FEB0")]
	private void SetRendererVisibility(bool onOff)
	{
	}

	// Token: 0x060002A7 RID: 679 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x2B70980", Offset = "0x2B6F980", VA = "0x182B70980")]
	public NightVisionGoggles()
	{
	}

	// Token: 0x0400028C RID: 652
	[Token(Token = "0x400028C")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[ItemIdPicker]
	private int _nightVisionGogglesId;

	// Token: 0x0400028D RID: 653
	[Token(Token = "0x400028D")]
	[FieldOffset(Offset = "0x28")]
	[Header("Night Vision Effect:")]
	[SerializeField]
	private Volume _volume;

	// Token: 0x0400028E RID: 654
	[Token(Token = "0x400028E")]
	[FieldOffset(Offset = "0x30")]
	[Header("Main Image & Padding:")]
	[SerializeField]
	private RectTransform _nightVisionGogglesOutline;

	// Token: 0x0400028F RID: 655
	[Token(Token = "0x400028F")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private RectTransform _leftPad;

	// Token: 0x04000290 RID: 656
	[Token(Token = "0x4000290")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private RectTransform _rightPad;

	// Token: 0x04000291 RID: 657
	[Token(Token = "0x4000291")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Header("Other:")]
	private float _fadeSpeed;

	// Token: 0x04000292 RID: 658
	[Token(Token = "0x4000292")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private SkinnedMeshRenderer[] HideRenderers;

	// Token: 0x04000293 RID: 659
	[Token(Token = "0x4000293")]
	[FieldOffset(Offset = "0x58")]
	private bool _isActive;

	// Token: 0x04000294 RID: 660
	[Token(Token = "0x4000294")]
	[FieldOffset(Offset = "0x59")]
	private bool _isFading;

	// Token: 0x04000295 RID: 661
	[Token(Token = "0x4000295")]
	[FieldOffset(Offset = "0x5A")]
	private bool _allowToggle;

	// Token: 0x04000296 RID: 662
	[Token(Token = "0x4000296")]
	[FieldOffset(Offset = "0x5B")]
	private bool _toggleAnimation;

	// Token: 0x04000297 RID: 663
	[Token(Token = "0x4000297")]
	[FieldOffset(Offset = "0x5C")]
	private bool _wasEquipped;

	// Token: 0x04000298 RID: 664
	[Token(Token = "0x4000298")]
	[FieldOffset(Offset = "0x60")]
	private CanvasGroup _canvasGroup;
}
