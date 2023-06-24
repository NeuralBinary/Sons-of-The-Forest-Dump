using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200025C RID: 604
[Token(Token = "0x200025C")]
public class StreamScrolling : MonoBehaviour
{
	// Token: 0x060010CA RID: 4298 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010CA")]
	[Address(RVA = "0x373E200", Offset = "0x373C800", VA = "0x18373E200")]
	private void LateUpdate()
	{
	}

	// Token: 0x060010CB RID: 4299 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010CB")]
	[Address(RVA = "0x373E540", Offset = "0x373CB40", VA = "0x18373E540")]
	public StreamScrolling()
	{
	}

	// Token: 0x04000FA5 RID: 4005
	[Token(Token = "0x4000FA5")]
	[FieldOffset(Offset = "0x20")]
	public int materialIndex;

	// Token: 0x04000FA6 RID: 4006
	[Token(Token = "0x4000FA6")]
	[FieldOffset(Offset = "0x24")]
	public Vector2 uvAnimationRate;

	// Token: 0x04000FA7 RID: 4007
	[Token(Token = "0x4000FA7")]
	[FieldOffset(Offset = "0x30")]
	public string textureName;

	// Token: 0x04000FA8 RID: 4008
	[Token(Token = "0x4000FA8")]
	[FieldOffset(Offset = "0x38")]
	public string textureName2;

	// Token: 0x04000FA9 RID: 4009
	[Token(Token = "0x4000FA9")]
	[FieldOffset(Offset = "0x40")]
	public string textureName3;

	// Token: 0x04000FAA RID: 4010
	[Token(Token = "0x4000FAA")]
	[FieldOffset(Offset = "0x48")]
	private Vector2 uvOffset;
}
