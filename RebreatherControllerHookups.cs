using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

// Token: 0x02000050 RID: 80
[Token(Token = "0x2000050")]
public class RebreatherControllerHookups : MonoBehaviour
{
	// Token: 0x06000257 RID: 599 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000257")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public RebreatherControllerHookups()
	{
	}

	// Token: 0x04000228 RID: 552
	[Token(Token = "0x4000228")]
	[FieldOffset(Offset = "0x20")]
	public Transform _airGagueDial;

	// Token: 0x04000229 RID: 553
	[Token(Token = "0x4000229")]
	[FieldOffset(Offset = "0x28")]
	public HDAdditionalLightData _rebreatherLightData;
}
