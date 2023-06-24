using System;
using Il2CppDummyDll;
using PathologicalGames;
using UnityEngine;

// Token: 0x020002E3 RID: 739
[Token(Token = "0x20002E3")]
[RequireComponent(typeof(Detonator))]
public class GrowWithDetonator : MonoBehaviour
{
	// Token: 0x06001364 RID: 4964 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001364")]
	[Address(RVA = "0x31F4DA0", Offset = "0x31F33A0", VA = "0x1831F4DA0")]
	private void Awake()
	{
	}

	// Token: 0x06001365 RID: 4965 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001365")]
	[Address(RVA = "0x31F4E50", Offset = "0x31F3450", VA = "0x1831F4E50")]
	private void Update()
	{
	}

	// Token: 0x06001366 RID: 4966 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001366")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public GrowWithDetonator()
	{
	}

	// Token: 0x0400133E RID: 4926
	[Token(Token = "0x400133E")]
	[FieldOffset(Offset = "0x20")]
	public Detonator detonator;

	// Token: 0x0400133F RID: 4927
	[Token(Token = "0x400133F")]
	[FieldOffset(Offset = "0x28")]
	private Transform xform;
}
