using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000063 RID: 99
[Token(Token = "0x2000063")]
public class ProbeVolumeTerrainHelper : MonoBehaviour
{
	// Token: 0x060002B0 RID: 688 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x2427910", Offset = "0x2426910", VA = "0x182427910")]
	public ProbeVolumeTerrainHelper()
	{
	}

	// Token: 0x040002A4 RID: 676
	[Token(Token = "0x40002A4")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ProbeVolume _probeVolume;

	// Token: 0x040002A5 RID: 677
	[Token(Token = "0x40002A5")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _bottomHeightOffset;

	// Token: 0x040002A6 RID: 678
	[Token(Token = "0x40002A6")]
	[FieldOffset(Offset = "0x2C")]
	private float _stepSize;

	// Token: 0x040002A7 RID: 679
	[Token(Token = "0x40002A7")]
	[FieldOffset(Offset = "0x0")]
	private static readonly LayerMask DefaultTerrainAlignLayerMask;
}
