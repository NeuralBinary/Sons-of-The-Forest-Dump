using System;
using System.Collections;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

// Token: 0x0200005C RID: 92
[Token(Token = "0x200005C")]
public class Mask : MonoBehaviour
{
	// Token: 0x0600029E RID: 670 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600029E")]
	[Address(RVA = "0x31B4D80", Offset = "0x31B3380", VA = "0x1831B4D80")]
	private void Start()
	{
	}

	// Token: 0x0600029F RID: 671 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600029F")]
	[Address(RVA = "0x31B4E10", Offset = "0x31B3410", VA = "0x1831B4E10")]
	private void Update()
	{
	}

	// Token: 0x060002A0 RID: 672 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x31B5040", Offset = "0x31B3640", VA = "0x1831B5040")]
	public void Toggle()
	{
	}

	// Token: 0x060002A1 RID: 673 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x31B51D0", Offset = "0x31B37D0", VA = "0x1831B51D0")]
	private IEnumerator Fade(bool fadeIn)
	{
		return null;
	}

	// Token: 0x060002A2 RID: 674 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x31B5290", Offset = "0x31B3890", VA = "0x1831B5290")]
	private void UpdatePadding()
	{
	}

	// Token: 0x060002A3 RID: 675 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x31B5560", Offset = "0x31B3B60", VA = "0x1831B5560")]
	private void UpdateHeldAnimation()
	{
	}

	// Token: 0x060002A4 RID: 676 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x31B5850", Offset = "0x31B3E50", VA = "0x1831B5850")]
	private void DisableRendererVisibility(bool onOff)
	{
	}

	// Token: 0x060002A5 RID: 677 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x3061CF0", Offset = "0x30602F0", VA = "0x183061CF0")]
	public Mask()
	{
	}

	// Token: 0x0400028D RID: 653
	[Token(Token = "0x400028D")]
	[FieldOffset(Offset = "0x20")]
	[ItemIdPicker]
	[SerializeField]
	private int _itemId;

	// Token: 0x0400028E RID: 654
	[Token(Token = "0x400028E")]
	[FieldOffset(Offset = "0x28")]
	[Header("Main Image & Padding:")]
	[SerializeField]
	private RectTransform _outline;

	// Token: 0x0400028F RID: 655
	[Token(Token = "0x400028F")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private RectTransform _leftPad;

	// Token: 0x04000290 RID: 656
	[Token(Token = "0x4000290")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private RectTransform _rightPad;

	// Token: 0x04000291 RID: 657
	[Token(Token = "0x4000291")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Header("Other:")]
	private float _fadeSpeed;

	// Token: 0x04000292 RID: 658
	[Token(Token = "0x4000292")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private SkinnedMeshRenderer[] HideRenderers;

	// Token: 0x04000293 RID: 659
	[Token(Token = "0x4000293")]
	[FieldOffset(Offset = "0x50")]
	private bool _isActive;

	// Token: 0x04000294 RID: 660
	[Token(Token = "0x4000294")]
	[FieldOffset(Offset = "0x51")]
	private bool _isFading;

	// Token: 0x04000295 RID: 661
	[Token(Token = "0x4000295")]
	[FieldOffset(Offset = "0x52")]
	private bool _allowToggle;

	// Token: 0x04000296 RID: 662
	[Token(Token = "0x4000296")]
	[FieldOffset(Offset = "0x53")]
	private bool _toggleAnimation;

	// Token: 0x04000297 RID: 663
	[Token(Token = "0x4000297")]
	[FieldOffset(Offset = "0x54")]
	private bool _wasEquipped;

	// Token: 0x04000298 RID: 664
	[Token(Token = "0x4000298")]
	[FieldOffset(Offset = "0x58")]
	private CanvasGroup _canvasGroup;

	// Token: 0x04000299 RID: 665
	[Token(Token = "0x4000299")]
	[FieldOffset(Offset = "0x60")]
	private MeshRenderer[] _heldRenderers;

	// Token: 0x0400029A RID: 666
	[Token(Token = "0x400029A")]
	[FieldOffset(Offset = "0x68")]
	private bool _overrideKeyPressed;
}
