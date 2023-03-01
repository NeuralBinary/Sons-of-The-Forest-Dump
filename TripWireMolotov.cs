using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000286 RID: 646
[Token(Token = "0x2000286")]
public class TripWireMolotov : MonoBehaviour
{
	// Token: 0x060010BA RID: 4282 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010BA")]
	[Address(RVA = "0x2FBBE90", Offset = "0x2FBAE90", VA = "0x182FBBE90")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x060010BB RID: 4283 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010BB")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public TripWireMolotov()
	{
	}

	// Token: 0x0400104C RID: 4172
	[Token(Token = "0x400104C")]
	[FieldOffset(Offset = "0x20")]
	public GameObject MolotovReal;

	// Token: 0x0400104D RID: 4173
	[Token(Token = "0x400104D")]
	[FieldOffset(Offset = "0x28")]
	public GameObject MolotovFake;
}
