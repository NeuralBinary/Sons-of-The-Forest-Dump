using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000118 RID: 280
[Token(Token = "0x2000118")]
public class enableOnLoad : MonoBehaviour
{
	// Token: 0x06000840 RID: 2112 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000840")]
	[Address(RVA = "0x2F479E0", Offset = "0x2F469E0", VA = "0x182F479E0")]
	private void Start()
	{
	}

	// Token: 0x06000841 RID: 2113 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000841")]
	[Address(RVA = "0x2F479A0", Offset = "0x2F469A0", VA = "0x182F479A0")]
	private void OnDeserialized()
	{
	}

	// Token: 0x06000842 RID: 2114 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000842")]
	[Address(RVA = "0x2F47A30", Offset = "0x2F46A30", VA = "0x182F47A30")]
	public IEnumerator doEnable()
	{
		return null;
	}

	// Token: 0x06000843 RID: 2115 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000843")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public enableOnLoad()
	{
	}

	// Token: 0x040006B4 RID: 1716
	[Token(Token = "0x40006B4")]
	[FieldOffset(Offset = "0x20")]
	public bool enableOnStart;

	// Token: 0x040006B5 RID: 1717
	[Token(Token = "0x40006B5")]
	[FieldOffset(Offset = "0x21")]
	private bool doingEnable;

	// Token: 0x040006B6 RID: 1718
	[Token(Token = "0x40006B6")]
	[FieldOffset(Offset = "0x28")]
	public GameObject go;
}
