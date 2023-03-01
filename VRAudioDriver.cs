using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002AB RID: 683
[Token(Token = "0x20002AB")]
public class VRAudioDriver : MonoBehaviour
{
	// Token: 0x060011B3 RID: 4531 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011B3")]
	[Address(RVA = "0x2B87430", Offset = "0x2B86430", VA = "0x182B87430")]
	private void Start()
	{
	}

	// Token: 0x060011B4 RID: 4532 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011B4")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public VRAudioDriver()
	{
	}

	// Token: 0x04001185 RID: 4485
	[Token(Token = "0x4001185")]
	[FieldOffset(Offset = "0x20")]
	public bool _logAllAudioDrivers;

	// Token: 0x04001186 RID: 4486
	[Token(Token = "0x4001186")]
	[FieldOffset(Offset = "0x0")]
	private static bool DriverSet;
}
