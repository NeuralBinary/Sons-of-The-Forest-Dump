using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002CA RID: 714
[Token(Token = "0x20002CA")]
[Serializable]
public class WallCheckSide : MonoBehaviour
{
	// Token: 0x0600123E RID: 4670 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600123E")]
	[Address(RVA = "0x2B901C0", Offset = "0x2B8F1C0", VA = "0x182B901C0", Slot = "4")]
	public virtual void Start()
	{
	}

	// Token: 0x0600123F RID: 4671 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600123F")]
	[Address(RVA = "0x2B900F0", Offset = "0x2B8F0F0", VA = "0x182B900F0", Slot = "5")]
	public virtual void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06001240 RID: 4672 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001240")]
	[Address(RVA = "0x2B90210", Offset = "0x2B8F210", VA = "0x182B90210", Slot = "6")]
	public virtual void TurnOffChecker()
	{
	}

	// Token: 0x06001241 RID: 4673 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001241")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public WallCheckSide()
	{
	}

	// Token: 0x0400123E RID: 4670
	[Token(Token = "0x400123E")]
	[FieldOffset(Offset = "0x20")]
	public GameObject MyWalls;

	// Token: 0x0400123F RID: 4671
	[Token(Token = "0x400123F")]
	[FieldOffset(Offset = "0x28")]
	public bool Middle;

	// Token: 0x04001240 RID: 4672
	[Token(Token = "0x4001240")]
	[FieldOffset(Offset = "0x29")]
	private bool Off;
}
