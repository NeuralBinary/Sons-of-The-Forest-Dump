using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000062 RID: 98
[Token(Token = "0x2000062")]
public class ProbeVolumeGenerator : MonoBehaviour
{
	// Token: 0x060002AF RID: 687 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002AF")]
	[Address(RVA = "0x2B7D450", Offset = "0x2B7C450", VA = "0x182B7D450")]
	public ProbeVolumeGenerator()
	{
	}

	// Token: 0x040002A0 RID: 672
	[Token(Token = "0x40002A0")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ProbeVolume _source;

	// Token: 0x040002A1 RID: 673
	[Token(Token = "0x40002A1")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Vector2 _min;

	// Token: 0x040002A2 RID: 674
	[Token(Token = "0x40002A2")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Vector2 _max;

	// Token: 0x040002A3 RID: 675
	[Token(Token = "0x40002A3")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private List<GameObject> _generatedObjects;
}
