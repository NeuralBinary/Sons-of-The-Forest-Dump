using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000005 RID: 5
[Token(Token = "0x2000005")]
public class DynamicBoneDemo1 : MonoBehaviour
{
	// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000005")]
	[Address(RVA = "0x5C69C0", Offset = "0x5C4FC0", VA = "0x1805C69C0")]
	private void Update()
	{
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000006")]
	[Address(RVA = "0x5C6D40", Offset = "0x5C5340", VA = "0x1805C6D40")]
	private void OnGUI()
	{
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000007")]
	[Address(RVA = "0x5C7240", Offset = "0x5C5840", VA = "0x1805C7240")]
	public DynamicBoneDemo1()
	{
	}

	// Token: 0x04000002 RID: 2
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_Player;

	// Token: 0x04000003 RID: 3
	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x28")]
	private float m_weight;

	// Token: 0x04000004 RID: 4
	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x2C")]
	private float m_sleepTime;
}
