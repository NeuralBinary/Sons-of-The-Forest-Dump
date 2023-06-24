using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001D1 RID: 465
[Token(Token = "0x20001D1")]
public class BlockAlpha : MonoBehaviour
{
	// Token: 0x06000D79 RID: 3449 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D79")]
	[Address(RVA = "0x3701730", Offset = "0x36FFD30", VA = "0x183701730")]
	private void Awake()
	{
	}

	// Token: 0x06000D7A RID: 3450 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D7A")]
	[Address(RVA = "0x37018E0", Offset = "0x36FFEE0", VA = "0x1837018E0")]
	private void Update()
	{
	}

	// Token: 0x06000D7B RID: 3451 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D7B")]
	[Address(RVA = "0x3701AC0", Offset = "0x37000C0", VA = "0x183701AC0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06000D7C RID: 3452 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D7C")]
	[Address(RVA = "0x3701CB0", Offset = "0x37002B0", VA = "0x183701CB0")]
	private void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x06000D7D RID: 3453 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D7D")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public BlockAlpha()
	{
	}

	// Token: 0x04000C47 RID: 3143
	[Token(Token = "0x4000C47")]
	[FieldOffset(Offset = "0x20")]
	public GameObject AlphaMessage;

	// Token: 0x04000C48 RID: 3144
	[Token(Token = "0x4000C48")]
	[FieldOffset(Offset = "0x28")]
	private Collider _collider;

	// Token: 0x04000C49 RID: 3145
	[Token(Token = "0x4000C49")]
	[FieldOffset(Offset = "0x30")]
	private Collider _playerCollider;
}
