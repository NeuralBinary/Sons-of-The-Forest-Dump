using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000E9 RID: 233
[Token(Token = "0x20000E9")]
public class AutoSaveMode : MonoBehaviour
{
	// Token: 0x06000720 RID: 1824 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000720")]
	[Address(RVA = "0x366E1F0", Offset = "0x366C7F0", VA = "0x18366E1F0")]
	private void Awake()
	{
	}

	// Token: 0x06000721 RID: 1825 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000721")]
	[Address(RVA = "0x366E2C0", Offset = "0x366C8C0", VA = "0x18366E2C0")]
	private void Start()
	{
	}

	// Token: 0x06000722 RID: 1826 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000722")]
	[Address(RVA = "0x366E360", Offset = "0x366C960", VA = "0x18366E360")]
	private void Update()
	{
	}

	// Token: 0x06000723 RID: 1827 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000723")]
	[Address(RVA = "0x366E5E0", Offset = "0x366CBE0", VA = "0x18366E5E0")]
	private IEnumerator StartWhenready()
	{
		return null;
	}

	// Token: 0x06000724 RID: 1828 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000724")]
	[Address(RVA = "0x366E670", Offset = "0x366CC70", VA = "0x18366E670")]
	private IEnumerator AutoSave()
	{
		return null;
	}

	// Token: 0x06000725 RID: 1829 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000725")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public AutoSaveMode()
	{
	}

	// Token: 0x040005D5 RID: 1493
	[Token(Token = "0x40005D5")]
	[FieldOffset(Offset = "0x20")]
	private float timer;

	// Token: 0x040005D6 RID: 1494
	[Token(Token = "0x40005D6")]
	[FieldOffset(Offset = "0x24")]
	private bool autosaveWhenEmpty;
}
