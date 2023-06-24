using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200000A RID: 10
[Token(Token = "0x200000A")]
[AddComponentMenu("Crest/Sleeper")]
public class Sleeper : MonoBehaviour
{
	// Token: 0x0600001B RID: 27 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x600001B")]
	[Address(RVA = "0x9F3840", Offset = "0x9F1E40", VA = "0x1809F3840")]
	private void Update()
	{
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x600001C")]
	[Address(RVA = "0x9F3940", Offset = "0x9F1F40", VA = "0x1809F3940")]
	public Sleeper()
	{
	}

	// Token: 0x04000040 RID: 64
	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x20")]
	public int _sleepMs;

	// Token: 0x04000041 RID: 65
	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x24")]
	public bool _jitter;

	// Token: 0x04000042 RID: 66
	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x28")]
	public int _sleepStride;
}
