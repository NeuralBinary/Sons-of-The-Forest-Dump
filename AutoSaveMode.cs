using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000EB RID: 235
[Token(Token = "0x20000EB")]
public class AutoSaveMode : MonoBehaviour
{
	// Token: 0x060006D3 RID: 1747 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006D3")]
	[Address(RVA = "0x2E70DC0", Offset = "0x2E6FDC0", VA = "0x182E70DC0")]
	private void Awake()
	{
	}

	// Token: 0x060006D4 RID: 1748 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006D4")]
	[Address(RVA = "0x2E70E90", Offset = "0x2E6FE90", VA = "0x182E70E90")]
	private void Start()
	{
	}

	// Token: 0x060006D5 RID: 1749 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006D5")]
	[Address(RVA = "0x2E70F00", Offset = "0x2E6FF00", VA = "0x182E70F00")]
	private void Update()
	{
	}

	// Token: 0x060006D6 RID: 1750 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006D6")]
	[Address(RVA = "0x2E70E20", Offset = "0x2E6FE20", VA = "0x182E70E20")]
	private IEnumerator StartWhenready()
	{
		return null;
	}

	// Token: 0x060006D7 RID: 1751 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006D7")]
	[Address(RVA = "0x2E70D70", Offset = "0x2E6FD70", VA = "0x182E70D70")]
	private IEnumerator AutoSave()
	{
		return null;
	}

	// Token: 0x060006D8 RID: 1752 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006D8")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public AutoSaveMode()
	{
	}

	// Token: 0x040005B6 RID: 1462
	[Token(Token = "0x40005B6")]
	[FieldOffset(Offset = "0x20")]
	private float timer;

	// Token: 0x040005B7 RID: 1463
	[Token(Token = "0x40005B7")]
	[FieldOffset(Offset = "0x24")]
	private bool autosaveWhenEmpty;
}
