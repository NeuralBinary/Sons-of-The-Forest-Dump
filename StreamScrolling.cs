using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000261 RID: 609
[Token(Token = "0x2000261")]
public class StreamScrolling : MonoBehaviour
{
	// Token: 0x0600107C RID: 4220 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600107C")]
	[Address(RVA = "0x2FBA540", Offset = "0x2FB9540", VA = "0x182FBA540")]
	private void LateUpdate()
	{
	}

	// Token: 0x0600107D RID: 4221 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600107D")]
	[Address(RVA = "0x2FBA740", Offset = "0x2FB9740", VA = "0x182FBA740")]
	public StreamScrolling()
	{
	}

	// Token: 0x04000F7F RID: 3967
	[Token(Token = "0x4000F7F")]
	[FieldOffset(Offset = "0x20")]
	public int materialIndex;

	// Token: 0x04000F80 RID: 3968
	[Token(Token = "0x4000F80")]
	[FieldOffset(Offset = "0x24")]
	public Vector2 uvAnimationRate;

	// Token: 0x04000F81 RID: 3969
	[Token(Token = "0x4000F81")]
	[FieldOffset(Offset = "0x30")]
	public string textureName;

	// Token: 0x04000F82 RID: 3970
	[Token(Token = "0x4000F82")]
	[FieldOffset(Offset = "0x38")]
	public string textureName2;

	// Token: 0x04000F83 RID: 3971
	[Token(Token = "0x4000F83")]
	[FieldOffset(Offset = "0x40")]
	public string textureName3;

	// Token: 0x04000F84 RID: 3972
	[Token(Token = "0x4000F84")]
	[FieldOffset(Offset = "0x48")]
	private Vector2 uvOffset;
}
