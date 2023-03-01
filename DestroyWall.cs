using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001EA RID: 490
[Token(Token = "0x20001EA")]
public class DestroyWall : MonoBehaviour
{
	// Token: 0x06000D95 RID: 3477 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D95")]
	[Address(RVA = "0x2F87540", Offset = "0x2F86540", VA = "0x182F87540")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06000D96 RID: 3478 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D96")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public DestroyWall()
	{
	}

	// Token: 0x04000CBF RID: 3263
	[Token(Token = "0x4000CBF")]
	[FieldOffset(Offset = "0x20")]
	public GameObject NormalWall;

	// Token: 0x04000CC0 RID: 3264
	[Token(Token = "0x4000CC0")]
	[FieldOffset(Offset = "0x28")]
	public GameObject DynamicWall;
}
