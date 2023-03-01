using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000056 RID: 86
[Token(Token = "0x2000056")]
public class TreeCutSetPivots : MonoBehaviour
{
	// Token: 0x0600026E RID: 622 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600026E")]
	[Address(RVA = "0x2B81160", Offset = "0x2B80160", VA = "0x182B81160")]
	private void OnEnable()
	{
	}

	// Token: 0x0600026F RID: 623 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600026F")]
	[Address(RVA = "0x2B81020", Offset = "0x2B80020", VA = "0x182B81020")]
	private void OnDisable()
	{
	}

	// Token: 0x06000270 RID: 624 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000270")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public TreeCutSetPivots()
	{
	}

	// Token: 0x0400024A RID: 586
	[Token(Token = "0x400024A")]
	[FieldOffset(Offset = "0x20")]
	public Renderer[] _renderers;

	// Token: 0x0400024B RID: 587
	[Token(Token = "0x400024B")]
	[FieldOffset(Offset = "0x28")]
	private MaterialPropertyBlock _block;

	// Token: 0x0400024C RID: 588
	[Token(Token = "0x400024C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int _UseStaticPivot;

	// Token: 0x0400024D RID: 589
	[Token(Token = "0x400024D")]
	[FieldOffset(Offset = "0x4")]
	private static readonly int _StaticPivot;
}
