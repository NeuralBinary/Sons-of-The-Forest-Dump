using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000F8 RID: 248
[Token(Token = "0x20000F8")]
public class activateHangGlider : EntityBehaviour<IDynamicPickup>
{
	// Token: 0x06000744 RID: 1860 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000744")]
	[Address(RVA = "0x2E8CC10", Offset = "0x2E8BC10", VA = "0x182E8CC10")]
	private void GrabEnter(GameObject grabber)
	{
	}

	// Token: 0x06000745 RID: 1861 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000745")]
	[Address(RVA = "0x2E8CE20", Offset = "0x2E8BE20", VA = "0x182E8CE20")]
	private void GrabExit(GameObject grabber)
	{
	}

	// Token: 0x06000746 RID: 1862 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000746")]
	[Address(RVA = "0x2E8D010", Offset = "0x2E8C010", VA = "0x182E8D010")]
	private void Update()
	{
	}

	// Token: 0x06000747 RID: 1863 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000747")]
	[Address(RVA = "0x2E8CE80", Offset = "0x2E8BE80", VA = "0x182E8CE80")]
	private void SendPickupGlider()
	{
	}

	// Token: 0x06000748 RID: 1864 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000748")]
	[Address(RVA = "0x2E8D320", Offset = "0x2E8C320", VA = "0x182E8D320")]
	public activateHangGlider()
	{
	}

	// Token: 0x040005E3 RID: 1507
	[Token(Token = "0x40005E3")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Sheen;

	// Token: 0x040005E4 RID: 1508
	[Token(Token = "0x40005E4")]
	[FieldOffset(Offset = "0x30")]
	public GameObject MyPickUp;

	// Token: 0x040005E5 RID: 1509
	[Token(Token = "0x40005E5")]
	[FieldOffset(Offset = "0x38")]
	public GameObject destroyTarget;
}
