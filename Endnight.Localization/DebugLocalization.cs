using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Localization;

// Token: 0x02000002 RID: 2
[Token(Token = "0x2000002")]
public class DebugLocalization : MonoBehaviour
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000001")]
	[Address(RVA = "0xA80670", Offset = "0xA7EC70", VA = "0x180A80670")]
	private void Update()
	{
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000002")]
	[Address(RVA = "0xA807E0", Offset = "0xA7EDE0", VA = "0x180A807E0")]
	private Locale GetNextLocale(int offset)
	{
		return null;
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000003")]
	[Address(RVA = "0xA809C0", Offset = "0xA7EFC0", VA = "0x180A809C0")]
	private void FetchLocalesIfNeeded()
	{
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000004")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public DebugLocalization()
	{
	}

	// Token: 0x04000001 RID: 1
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x20")]
	private List<Locale> _allLocales;
}
