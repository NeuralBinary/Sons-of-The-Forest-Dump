using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000060 RID: 96
[Token(Token = "0x2000060")]
public class ProbeVolumeTerrainHelper : MonoBehaviour
{
	// Token: 0x060002AE RID: 686 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002AE")]
	[Address(RVA = "0x28C7AC0", Offset = "0x28C60C0", VA = "0x1828C7AC0")]
	public ProbeVolumeTerrainHelper()
	{
	}

	// Token: 0x040002A6 RID: 678
	[Token(Token = "0x40002A6")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ProbeVolume _probeVolume;

	// Token: 0x040002A7 RID: 679
	[Token(Token = "0x40002A7")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _bottomHeightOffset;

	// Token: 0x040002A8 RID: 680
	[Token(Token = "0x40002A8")]
	[FieldOffset(Offset = "0x2C")]
	private float _stepSize;

	// Token: 0x040002A9 RID: 681
	[Token(Token = "0x40002A9")]
	[FieldOffset(Offset = "0x0")]
	private static readonly LayerMask DefaultTerrainAlignLayerMask;
}
