using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002BE RID: 702
[Token(Token = "0x20002BE")]
[Serializable]
public class WallCheckSide : MonoBehaviour
{
	// Token: 0x06001273 RID: 4723 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001273")]
	[Address(RVA = "0x31DC910", Offset = "0x31DAF10", VA = "0x1831DC910", Slot = "4")]
	public virtual void Start()
	{
	}

	// Token: 0x06001274 RID: 4724 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001274")]
	[Address(RVA = "0x31DC960", Offset = "0x31DAF60", VA = "0x1831DC960", Slot = "5")]
	public virtual void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06001275 RID: 4725 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001275")]
	[Address(RVA = "0x31DCAC0", Offset = "0x31DB0C0", VA = "0x1831DCAC0", Slot = "6")]
	public virtual void TurnOffChecker()
	{
	}

	// Token: 0x06001276 RID: 4726 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001276")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public WallCheckSide()
	{
	}

	// Token: 0x04001265 RID: 4709
	[Token(Token = "0x4001265")]
	[FieldOffset(Offset = "0x20")]
	public GameObject MyWalls;

	// Token: 0x04001266 RID: 4710
	[Token(Token = "0x4001266")]
	[FieldOffset(Offset = "0x28")]
	public bool Middle;

	// Token: 0x04001267 RID: 4711
	[Token(Token = "0x4001267")]
	[FieldOffset(Offset = "0x29")]
	private bool Off;
}
