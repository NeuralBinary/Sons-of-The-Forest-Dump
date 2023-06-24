using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200000D RID: 13
[Token(Token = "0x200000D")]
public class RigidGroupActivator : MonoBehaviour
{
	// Token: 0x06000040 RID: 64 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000040")]
	[Address(RVA = "0x31675B0", Offset = "0x3165BB0", VA = "0x1831675B0")]
	public void SetActivatedGroups(List<bool> groupStates)
	{
	}

	// Token: 0x06000041 RID: 65 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000041")]
	[Address(RVA = "0x31677B0", Offset = "0x3165DB0", VA = "0x1831677B0")]
	public void RemoveInactiveGroups()
	{
	}

	// Token: 0x06000042 RID: 66 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000042")]
	[Address(RVA = "0x3167990", Offset = "0x3165F90", VA = "0x183167990")]
	public RigidGroupActivator()
	{
	}

	// Token: 0x0400005E RID: 94
	[Token(Token = "0x400005E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<bool> _activatedGroups;

	// Token: 0x0400005F RID: 95
	[Token(Token = "0x400005F")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<GameObject> _groups;
}
