using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000064 RID: 100
[Token(Token = "0x2000064")]
public class SetLppvOnChildRenderers : MonoBehaviour
{
	// Token: 0x060002B2 RID: 690 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x2B7F170", Offset = "0x2B7E170", VA = "0x182B7F170")]
	private void OnValidate()
	{
	}

	// Token: 0x060002B3 RID: 691 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public SetLppvOnChildRenderers()
	{
	}

	// Token: 0x040002A8 RID: 680
	[Token(Token = "0x40002A8")]
	[FieldOffset(Offset = "0x20")]
	public LightProbeProxyVolume LppvToAssign;

	// Token: 0x040002A9 RID: 681
	[Token(Token = "0x40002A9")]
	[FieldOffset(Offset = "0x28")]
	public bool AssignLppvToAllClildRenderers;

	// Token: 0x040002AA RID: 682
	[Token(Token = "0x40002AA")]
	[FieldOffset(Offset = "0x29")]
	public bool SetClildRenderersToBlendProbes;
}
