using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002FB RID: 763
[Token(Token = "0x20002FB")]
public class LODGroupRendererAssigner : MonoBehaviour
{
	// Token: 0x0600136B RID: 4971 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600136B")]
	[Address(RVA = "0x2C67000", Offset = "0x2C66000", VA = "0x182C67000")]
	private void ApplyLODs()
	{
	}

	// Token: 0x0600136C RID: 4972 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600136C")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public LODGroupRendererAssigner()
	{
	}

	// Token: 0x0400134D RID: 4941
	[Token(Token = "0x400134D")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<RendererList> _Lods;

	// Token: 0x0400134E RID: 4942
	[Token(Token = "0x400134E")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<float> _transitionValue;

	// Token: 0x0400134F RID: 4943
	[Token(Token = "0x400134F")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private LODGroup _LODGroup;
}
