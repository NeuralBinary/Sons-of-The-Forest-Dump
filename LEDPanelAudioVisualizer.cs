using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000047 RID: 71
[Token(Token = "0x2000047")]
public class LEDPanelAudioVisualizer : MonoBehaviour
{
	// Token: 0x060001DD RID: 477 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x29AA090", Offset = "0x29A9090", VA = "0x1829AA090")]
	private void Start()
	{
	}

	// Token: 0x060001DE RID: 478 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x29A9DF0", Offset = "0x29A8DF0", VA = "0x1829A9DF0")]
	private void LateUpdate()
	{
	}

	// Token: 0x060001DF RID: 479 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x29AA150", Offset = "0x29A9150", VA = "0x1829AA150")]
	public LEDPanelAudioVisualizer()
	{
	}

	// Token: 0x040001CF RID: 463
	[Token(Token = "0x40001CF")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private FMODSpectrumData _spectrumData;

	// Token: 0x040001D0 RID: 464
	[Token(Token = "0x40001D0")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private int _activeRangeIndex;

	// Token: 0x040001D1 RID: 465
	[Token(Token = "0x40001D1")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float _strengthMultiplier;

	// Token: 0x040001D2 RID: 466
	[Token(Token = "0x40001D2")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float _gainSmoothing;

	// Token: 0x040001D3 RID: 467
	[Token(Token = "0x40001D3")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float _dropSmoothing;

	// Token: 0x040001D4 RID: 468
	[Token(Token = "0x40001D4")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float _baseEmissiveIntensity;

	// Token: 0x040001D5 RID: 469
	[Token(Token = "0x40001D5")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float _peakEmissiveIntensity;

	// Token: 0x040001D6 RID: 470
	[Token(Token = "0x40001D6")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float _baseColorVariationSpeed;

	// Token: 0x040001D7 RID: 471
	[Token(Token = "0x40001D7")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private float _peakColorVariationSpeed;

	// Token: 0x040001D8 RID: 472
	[Token(Token = "0x40001D8")]
	[FieldOffset(Offset = "0x48")]
	private Material _material;

	// Token: 0x040001D9 RID: 473
	[Token(Token = "0x40001D9")]
	[FieldOffset(Offset = "0x50")]
	private float _emissive;

	// Token: 0x040001DA RID: 474
	[Token(Token = "0x40001DA")]
	[FieldOffset(Offset = "0x54")]
	private float _colorVariationSpeed;
}
