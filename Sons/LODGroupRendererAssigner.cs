using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002EE RID: 750
[Token(Token = "0x20002EE")]
public class LODGroupRendererAssigner : MonoBehaviour
{
	// Token: 0x06001397 RID: 5015 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001397")]
	[Address(RVA = "0x31F77D0", Offset = "0x31F5DD0", VA = "0x1831F77D0")]
	private void ApplyLODs()
	{
	}

	// Token: 0x06001398 RID: 5016 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001398")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public LODGroupRendererAssigner()
	{
	}

	// Token: 0x0400136B RID: 4971
	[Token(Token = "0x400136B")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<RendererList> _Lods;

	// Token: 0x0400136C RID: 4972
	[Token(Token = "0x400136C")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<float> _transitionValue;

	// Token: 0x0400136D RID: 4973
	[Token(Token = "0x400136D")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private LODGroup _LODGroup;
}
