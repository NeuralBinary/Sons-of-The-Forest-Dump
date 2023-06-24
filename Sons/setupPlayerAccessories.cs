using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000163 RID: 355
[Token(Token = "0x2000163")]
public class setupPlayerAccessories : MonoBehaviour
{
	// Token: 0x06000ABE RID: 2750 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ABE")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void Start()
	{
	}

	// Token: 0x06000ABF RID: 2751 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000ABF")]
	[Address(RVA = "0x36BC070", Offset = "0x36BA670", VA = "0x1836BC070")]
	public void doSetup()
	{
	}

	// Token: 0x06000AC0 RID: 2752 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AC0")]
	[Address(RVA = "0x36BC290", Offset = "0x36BA890", VA = "0x1836BC290")]
	private void cleanUp()
	{
	}

	// Token: 0x06000AC1 RID: 2753 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AC1")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public setupPlayerAccessories()
	{
	}

	// Token: 0x0400091B RID: 2331
	[Token(Token = "0x400091B")]
	[FieldOffset(Offset = "0x20")]
	public GameObject backpackGo;

	// Token: 0x0400091C RID: 2332
	[Token(Token = "0x400091C")]
	[FieldOffset(Offset = "0x28")]
	public GameObject[] goList;

	// Token: 0x0400091D RID: 2333
	[Token(Token = "0x400091D")]
	[FieldOffset(Offset = "0x30")]
	public Transform rootTr;
}
