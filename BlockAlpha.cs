using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001D2 RID: 466
[Token(Token = "0x20001D2")]
public class BlockAlpha : MonoBehaviour
{
	// Token: 0x06000D1E RID: 3358 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D1E")]
	[Address(RVA = "0x2F7DAA0", Offset = "0x2F7CAA0", VA = "0x182F7DAA0")]
	private void Awake()
	{
	}

	// Token: 0x06000D1F RID: 3359 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D1F")]
	[Address(RVA = "0x2F7DCC0", Offset = "0x2F7CCC0", VA = "0x182F7DCC0")]
	private void Update()
	{
	}

	// Token: 0x06000D20 RID: 3360 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D20")]
	[Address(RVA = "0x2F7DB50", Offset = "0x2F7CB50", VA = "0x182F7DB50")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06000D21 RID: 3361 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D21")]
	[Address(RVA = "0x2F7DBF0", Offset = "0x2F7CBF0", VA = "0x182F7DBF0")]
	private void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x06000D22 RID: 3362 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D22")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public BlockAlpha()
	{
	}

	// Token: 0x04000C18 RID: 3096
	[Token(Token = "0x4000C18")]
	[FieldOffset(Offset = "0x20")]
	public GameObject AlphaMessage;

	// Token: 0x04000C19 RID: 3097
	[Token(Token = "0x4000C19")]
	[FieldOffset(Offset = "0x28")]
	private Collider _collider;

	// Token: 0x04000C1A RID: 3098
	[Token(Token = "0x4000C1A")]
	[FieldOffset(Offset = "0x30")]
	private Collider _playerCollider;
}
