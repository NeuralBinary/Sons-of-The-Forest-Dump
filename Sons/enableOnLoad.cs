using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000115 RID: 277
[Token(Token = "0x2000115")]
public class enableOnLoad : MonoBehaviour
{
	// Token: 0x06000887 RID: 2183 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000887")]
	[Address(RVA = "0x36896A0", Offset = "0x3687CA0", VA = "0x1836896A0")]
	private void Start()
	{
	}

	// Token: 0x06000888 RID: 2184 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000888")]
	[Address(RVA = "0x36896F0", Offset = "0x3687CF0", VA = "0x1836896F0")]
	private void OnDeserialized()
	{
	}

	// Token: 0x06000889 RID: 2185 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000889")]
	[Address(RVA = "0x3689730", Offset = "0x3687D30", VA = "0x183689730")]
	public IEnumerator doEnable()
	{
		return null;
	}

	// Token: 0x0600088A RID: 2186 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600088A")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public enableOnLoad()
	{
	}

	// Token: 0x040006D0 RID: 1744
	[Token(Token = "0x40006D0")]
	[FieldOffset(Offset = "0x20")]
	public bool enableOnStart;

	// Token: 0x040006D1 RID: 1745
	[Token(Token = "0x40006D1")]
	[FieldOffset(Offset = "0x21")]
	private bool doingEnable;

	// Token: 0x040006D2 RID: 1746
	[Token(Token = "0x40006D2")]
	[FieldOffset(Offset = "0x28")]
	public GameObject go;
}
