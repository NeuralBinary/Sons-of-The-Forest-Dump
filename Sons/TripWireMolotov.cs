using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000281 RID: 641
[Token(Token = "0x2000281")]
public class TripWireMolotov : MonoBehaviour
{
	// Token: 0x06001108 RID: 4360 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001108")]
	[Address(RVA = "0x3742CA0", Offset = "0x37412A0", VA = "0x183742CA0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06001109 RID: 4361 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001109")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public TripWireMolotov()
	{
	}

	// Token: 0x04001072 RID: 4210
	[Token(Token = "0x4001072")]
	[FieldOffset(Offset = "0x20")]
	public GameObject MolotovReal;

	// Token: 0x04001073 RID: 4211
	[Token(Token = "0x4001073")]
	[FieldOffset(Offset = "0x28")]
	public GameObject MolotovFake;
}
