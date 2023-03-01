using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200003F RID: 63
[Token(Token = "0x200003F")]
public class FMODAudioVisualizer : MonoBehaviour
{
	// Token: 0x060001B4 RID: 436 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x29A0600", Offset = "0x299F600", VA = "0x1829A0600")]
	private void Start()
	{
	}

	// Token: 0x060001B5 RID: 437 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x299FE10", Offset = "0x299EE10", VA = "0x18299FE10")]
	private void BuildVisuals()
	{
	}

	// Token: 0x060001B6 RID: 438 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x29A0190", Offset = "0x299F190", VA = "0x1829A0190")]
	private void LateUpdate()
	{
	}

	// Token: 0x060001B7 RID: 439 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x29A0610", Offset = "0x299F610", VA = "0x1829A0610")]
	public FMODAudioVisualizer()
	{
	}

	// Token: 0x040001A0 RID: 416
	[Token(Token = "0x40001A0")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject _barAsset;

	// Token: 0x040001A1 RID: 417
	[Token(Token = "0x40001A1")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _xOffset;

	// Token: 0x040001A2 RID: 418
	[Token(Token = "0x40001A2")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float _heightMultiplier;

	// Token: 0x040001A3 RID: 419
	[Token(Token = "0x40001A3")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private FMODSpectrumData _spectrumData;

	// Token: 0x040001A4 RID: 420
	[Token(Token = "0x40001A4")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float _gainSmoothing;

	// Token: 0x040001A5 RID: 421
	[Token(Token = "0x40001A5")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float _dropSmoothing;

	// Token: 0x040001A6 RID: 422
	[Token(Token = "0x40001A6")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Color _baseColor;

	// Token: 0x040001A7 RID: 423
	[Token(Token = "0x40001A7")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Color _peakColor;

	// Token: 0x040001A8 RID: 424
	[Token(Token = "0x40001A8")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private float _peakScale;

	// Token: 0x040001A9 RID: 425
	[Token(Token = "0x40001A9")]
	[FieldOffset(Offset = "0x68")]
	private List<Transform> _bars;
}
