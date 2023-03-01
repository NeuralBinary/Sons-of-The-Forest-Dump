using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000138 RID: 312
[Token(Token = "0x2000138")]
public class lookAtDir : MonoBehaviour
{
	// Token: 0x060008CB RID: 2251 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008CB")]
	[Address(RVA = "0x2F4A2C0", Offset = "0x2F492C0", VA = "0x182F4A2C0")]
	private void Start()
	{
	}

	// Token: 0x060008CC RID: 2252 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008CC")]
	[Address(RVA = "0x2F4A220", Offset = "0x2F49220", VA = "0x182F4A220")]
	private void FixedUpdate()
	{
	}

	// Token: 0x060008CD RID: 2253 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008CD")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public lookAtDir()
	{
	}

	// Token: 0x04000720 RID: 1824
	[Token(Token = "0x4000720")]
	[FieldOffset(Offset = "0x20")]
	private Transform thisTr;

	// Token: 0x04000721 RID: 1825
	[Token(Token = "0x4000721")]
	[FieldOffset(Offset = "0x28")]
	public Transform rootTr;

	// Token: 0x04000722 RID: 1826
	[Token(Token = "0x4000722")]
	[FieldOffset(Offset = "0x30")]
	public Transform endTr;

	// Token: 0x04000723 RID: 1827
	[Token(Token = "0x4000723")]
	[FieldOffset(Offset = "0x38")]
	private Transform lookTr;

	// Token: 0x04000724 RID: 1828
	[Token(Token = "0x4000724")]
	[FieldOffset(Offset = "0x40")]
	public float xOffset;

	// Token: 0x04000725 RID: 1829
	[Token(Token = "0x4000725")]
	[FieldOffset(Offset = "0x44")]
	public float yOffset;

	// Token: 0x04000726 RID: 1830
	[Token(Token = "0x4000726")]
	[FieldOffset(Offset = "0x48")]
	public float zOffset;
}
