using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200001A RID: 26
[Token(Token = "0x200001A")]
public class FMODListenerTarget : MonoBehaviour
{
	// Token: 0x0600007C RID: 124 RVA: 0x000021A8 File Offset: 0x000003A8
	[Token(Token = "0x600007C")]
	[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
	public int GetPriority()
	{
		return 0;
	}

	// Token: 0x0600007D RID: 125 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600007D")]
	[Address(RVA = "0x2F6BF40", Offset = "0x2F6A540", VA = "0x182F6BF40")]
	private void OnEnable()
	{
	}

	// Token: 0x0600007E RID: 126 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600007E")]
	[Address(RVA = "0x2F6BF90", Offset = "0x2F6A590", VA = "0x182F6BF90")]
	private void OnDisable()
	{
	}

	// Token: 0x0600007F RID: 127 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600007F")]
	[Address(RVA = "0x5FD590", Offset = "0x5FBB90", VA = "0x1805FD590")]
	public void SetPriority(int priority)
	{
	}

	// Token: 0x06000080 RID: 128 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000080")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public FMODListenerTarget()
	{
	}

	// Token: 0x04000099 RID: 153
	[Token(Token = "0x4000099")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int _priority;
}
