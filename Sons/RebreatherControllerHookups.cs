using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

// Token: 0x02000052 RID: 82
[Token(Token = "0x2000052")]
public class RebreatherControllerHookups : MonoBehaviour
{
	// Token: 0x06000276 RID: 630 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000276")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public RebreatherControllerHookups()
	{
	}

	// Token: 0x0400025B RID: 603
	[Token(Token = "0x400025B")]
	[FieldOffset(Offset = "0x20")]
	public Transform _airGagueDial;

	// Token: 0x0400025C RID: 604
	[Token(Token = "0x400025C")]
	[FieldOffset(Offset = "0x28")]
	public HDAdditionalLightData _rebreatherLightData;
}
