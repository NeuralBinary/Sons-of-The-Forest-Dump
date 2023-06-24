using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200005F RID: 95
[Token(Token = "0x200005F")]
public class ProbeVolumeGenerator : MonoBehaviour
{
	// Token: 0x060002AD RID: 685 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x31B5E60", Offset = "0x31B4460", VA = "0x1831B5E60")]
	public ProbeVolumeGenerator()
	{
	}

	// Token: 0x040002A2 RID: 674
	[Token(Token = "0x40002A2")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ProbeVolume _source;

	// Token: 0x040002A3 RID: 675
	[Token(Token = "0x40002A3")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Vector2 _min;

	// Token: 0x040002A4 RID: 676
	[Token(Token = "0x40002A4")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Vector2 _max;

	// Token: 0x040002A5 RID: 677
	[Token(Token = "0x40002A5")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private List<GameObject> _generatedObjects;
}
