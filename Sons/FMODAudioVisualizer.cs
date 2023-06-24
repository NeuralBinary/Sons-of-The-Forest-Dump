using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200003F RID: 63
[Token(Token = "0x200003F")]
public class FMODAudioVisualizer : MonoBehaviour
{
	// Token: 0x060001BF RID: 447 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x2F81B50", Offset = "0x2F80150", VA = "0x182F81B50")]
	private void Start()
	{
	}

	// Token: 0x060001C0 RID: 448 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x2F81B60", Offset = "0x2F80160", VA = "0x182F81B60")]
	private void BuildVisuals()
	{
	}

	// Token: 0x060001C1 RID: 449 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x2F821A0", Offset = "0x2F807A0", VA = "0x182F821A0")]
	private void LateUpdate()
	{
	}

	// Token: 0x060001C2 RID: 450 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x2F82770", Offset = "0x2F80D70", VA = "0x182F82770")]
	public FMODAudioVisualizer()
	{
	}

	// Token: 0x040001A6 RID: 422
	[Token(Token = "0x40001A6")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject _barAsset;

	// Token: 0x040001A7 RID: 423
	[Token(Token = "0x40001A7")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _xOffset;

	// Token: 0x040001A8 RID: 424
	[Token(Token = "0x40001A8")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float _heightMultiplier;

	// Token: 0x040001A9 RID: 425
	[Token(Token = "0x40001A9")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private FMODSpectrumData _spectrumData;

	// Token: 0x040001AA RID: 426
	[Token(Token = "0x40001AA")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float _gainSmoothing;

	// Token: 0x040001AB RID: 427
	[Token(Token = "0x40001AB")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float _dropSmoothing;

	// Token: 0x040001AC RID: 428
	[Token(Token = "0x40001AC")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Color _baseColor;

	// Token: 0x040001AD RID: 429
	[Token(Token = "0x40001AD")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Color _peakColor;

	// Token: 0x040001AE RID: 430
	[Token(Token = "0x40001AE")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private float _peakScale;

	// Token: 0x040001AF RID: 431
	[Token(Token = "0x40001AF")]
	[FieldOffset(Offset = "0x68")]
	private List<Transform> _bars;
}
