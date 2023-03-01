using System;
using Il2CppDummyDll;
using PathologicalGames;
using UnityEngine;

// Token: 0x020002EF RID: 751
[Token(Token = "0x20002EF")]
[RequireComponent(typeof(Detonator))]
public class GrowWithDetonator : MonoBehaviour
{
	// Token: 0x0600132E RID: 4910 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600132E")]
	[Address(RVA = "0x2C66710", Offset = "0x2C65710", VA = "0x182C66710")]
	private void Awake()
	{
	}

	// Token: 0x0600132F RID: 4911 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600132F")]
	[Address(RVA = "0x2C66740", Offset = "0x2C65740", VA = "0x182C66740")]
	private void Update()
	{
	}

	// Token: 0x06001330 RID: 4912 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001330")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public GrowWithDetonator()
	{
	}

	// Token: 0x04001316 RID: 4886
	[Token(Token = "0x4001316")]
	[FieldOffset(Offset = "0x20")]
	public Detonator detonator;

	// Token: 0x04001317 RID: 4887
	[Token(Token = "0x4001317")]
	[FieldOffset(Offset = "0x28")]
	private Transform xform;
}
