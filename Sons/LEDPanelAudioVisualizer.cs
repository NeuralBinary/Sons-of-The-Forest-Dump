using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000049 RID: 73
[Token(Token = "0x2000049")]
public class LEDPanelAudioVisualizer : MonoBehaviour
{
	// Token: 0x060001F6 RID: 502 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x31A9B10", Offset = "0x31A8110", VA = "0x1831A9B10")]
	private void Start()
	{
	}

	// Token: 0x060001F7 RID: 503 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x31A9C50", Offset = "0x31A8250", VA = "0x1831A9C50")]
	private void LateUpdate()
	{
	}

	// Token: 0x060001F8 RID: 504 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x31A9F00", Offset = "0x31A8500", VA = "0x1831A9F00")]
	public LEDPanelAudioVisualizer()
	{
	}

	// Token: 0x040001FE RID: 510
	[Token(Token = "0x40001FE")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private FMODSpectrumData _spectrumData;

	// Token: 0x040001FF RID: 511
	[Token(Token = "0x40001FF")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private int _activeRangeIndex;

	// Token: 0x04000200 RID: 512
	[Token(Token = "0x4000200")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float _strengthMultiplier;

	// Token: 0x04000201 RID: 513
	[Token(Token = "0x4000201")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float _gainSmoothing;

	// Token: 0x04000202 RID: 514
	[Token(Token = "0x4000202")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float _dropSmoothing;

	// Token: 0x04000203 RID: 515
	[Token(Token = "0x4000203")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float _baseEmissiveIntensity;

	// Token: 0x04000204 RID: 516
	[Token(Token = "0x4000204")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float _peakEmissiveIntensity;

	// Token: 0x04000205 RID: 517
	[Token(Token = "0x4000205")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float _baseColorVariationSpeed;

	// Token: 0x04000206 RID: 518
	[Token(Token = "0x4000206")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private float _peakColorVariationSpeed;

	// Token: 0x04000207 RID: 519
	[Token(Token = "0x4000207")]
	[FieldOffset(Offset = "0x48")]
	private Material _material;

	// Token: 0x04000208 RID: 520
	[Token(Token = "0x4000208")]
	[FieldOffset(Offset = "0x50")]
	private float _emissive;

	// Token: 0x04000209 RID: 521
	[Token(Token = "0x4000209")]
	[FieldOffset(Offset = "0x54")]
	private float _colorVariationSpeed;
}
