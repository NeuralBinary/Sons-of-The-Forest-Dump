using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000002 RID: 2
[Token(Token = "0x2000002")]
[AddComponentMenu("Sons/Environment/Custom Billboard Tester")]
public class BillboardTester : MonoBehaviour
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x30B84A0", Offset = "0x30B6AA0", VA = "0x1830B84A0")]
	private void Awake()
	{
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000002")]
	[Address(RVA = "0x30B88D0", Offset = "0x30B6ED0", VA = "0x1830B88D0")]
	public BillboardTester()
	{
	}

	// Token: 0x04000001 RID: 1
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int _count;

	// Token: 0x04000002 RID: 2
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private Vector3 _area;
}
