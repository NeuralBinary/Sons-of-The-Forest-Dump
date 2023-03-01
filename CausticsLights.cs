using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001DB RID: 475
[Token(Token = "0x20001DB")]
[Serializable]
public class CausticsLights : MonoBehaviour
{
	// Token: 0x06000D39 RID: 3385 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D39")]
	[Address(RVA = "0x2F804F0", Offset = "0x2F7F4F0", VA = "0x182F804F0", Slot = "4")]
	public virtual void Update()
	{
	}

	// Token: 0x06000D3A RID: 3386 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D3A")]
	[Address(RVA = "0x2F80590", Offset = "0x2F7F590", VA = "0x182F80590")]
	public CausticsLights()
	{
	}

	// Token: 0x04000C41 RID: 3137
	[Token(Token = "0x4000C41")]
	[FieldOffset(Offset = "0x20")]
	public Texture2D[] frames;

	// Token: 0x04000C42 RID: 3138
	[Token(Token = "0x4000C42")]
	[FieldOffset(Offset = "0x28")]
	public float framesPerSecond;
}
