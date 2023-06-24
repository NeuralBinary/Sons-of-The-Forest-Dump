using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000136 RID: 310
[Token(Token = "0x2000136")]
public class lookAtDir : MonoBehaviour
{
	// Token: 0x06000913 RID: 2323 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000913")]
	[Address(RVA = "0x3690820", Offset = "0x368EE20", VA = "0x183690820")]
	private void Start()
	{
	}

	// Token: 0x06000914 RID: 2324 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000914")]
	[Address(RVA = "0x3690AB0", Offset = "0x368F0B0", VA = "0x183690AB0")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06000915 RID: 2325 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000915")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public lookAtDir()
	{
	}

	// Token: 0x0400073C RID: 1852
	[Token(Token = "0x400073C")]
	[FieldOffset(Offset = "0x20")]
	private Transform thisTr;

	// Token: 0x0400073D RID: 1853
	[Token(Token = "0x400073D")]
	[FieldOffset(Offset = "0x28")]
	public Transform rootTr;

	// Token: 0x0400073E RID: 1854
	[Token(Token = "0x400073E")]
	[FieldOffset(Offset = "0x30")]
	public Transform endTr;

	// Token: 0x0400073F RID: 1855
	[Token(Token = "0x400073F")]
	[FieldOffset(Offset = "0x38")]
	private Transform lookTr;

	// Token: 0x04000740 RID: 1856
	[Token(Token = "0x4000740")]
	[FieldOffset(Offset = "0x40")]
	public float xOffset;

	// Token: 0x04000741 RID: 1857
	[Token(Token = "0x4000741")]
	[FieldOffset(Offset = "0x44")]
	public float yOffset;

	// Token: 0x04000742 RID: 1858
	[Token(Token = "0x4000742")]
	[FieldOffset(Offset = "0x48")]
	public float zOffset;
}
