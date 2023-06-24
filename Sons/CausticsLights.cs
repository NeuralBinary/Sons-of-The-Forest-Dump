using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001DA RID: 474
[Token(Token = "0x20001DA")]
[Serializable]
public class CausticsLights : MonoBehaviour
{
	// Token: 0x06000D94 RID: 3476 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D94")]
	[Address(RVA = "0x3705420", Offset = "0x3703A20", VA = "0x183705420", Slot = "4")]
	public virtual void Update()
	{
	}

	// Token: 0x06000D95 RID: 3477 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D95")]
	[Address(RVA = "0x3705540", Offset = "0x3703B40", VA = "0x183705540")]
	public CausticsLights()
	{
	}

	// Token: 0x04000C70 RID: 3184
	[Token(Token = "0x4000C70")]
	[FieldOffset(Offset = "0x20")]
	public Texture2D[] frames;

	// Token: 0x04000C71 RID: 3185
	[Token(Token = "0x4000C71")]
	[FieldOffset(Offset = "0x28")]
	public float framesPerSecond;
}
