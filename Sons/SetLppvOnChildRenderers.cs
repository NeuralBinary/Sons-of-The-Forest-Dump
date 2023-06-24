using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000061 RID: 97
[Token(Token = "0x2000061")]
public class SetLppvOnChildRenderers : MonoBehaviour
{
	// Token: 0x060002B0 RID: 688 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x31B6000", Offset = "0x31B4600", VA = "0x1831B6000")]
	private void OnValidate()
	{
	}

	// Token: 0x060002B1 RID: 689 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public SetLppvOnChildRenderers()
	{
	}

	// Token: 0x040002AA RID: 682
	[Token(Token = "0x40002AA")]
	[FieldOffset(Offset = "0x20")]
	public LightProbeProxyVolume LppvToAssign;

	// Token: 0x040002AB RID: 683
	[Token(Token = "0x40002AB")]
	[FieldOffset(Offset = "0x28")]
	public bool AssignLppvToAllClildRenderers;

	// Token: 0x040002AC RID: 684
	[Token(Token = "0x40002AC")]
	[FieldOffset(Offset = "0x29")]
	public bool SetClildRenderersToBlendProbes;
}
