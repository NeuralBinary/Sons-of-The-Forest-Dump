using System;
using System.Collections.Generic;
using Endnight.Build;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000006 RID: 6
[Token(Token = "0x2000006")]
public class ShaderRuntimeLookup : MonoBehaviour
{
	// Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001D")]
	[Address(RVA = "0xA5F200", Offset = "0xA5D800", VA = "0x180A5F200")]
	private void Awake()
	{
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001E")]
	[Address(RVA = "0xA5F4A0", Offset = "0xA5DAA0", VA = "0x180A5F4A0")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600001F RID: 31 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600001F")]
	[Address(RVA = "0xA5F630", Offset = "0xA5DC30", VA = "0x180A5F630")]
	public static Shader Find(string name)
	{
		return null;
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000020")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public ShaderRuntimeLookup()
	{
	}

	// Token: 0x0400001D RID: 29
	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x0")]
	private static ShaderRuntimeLookup _instance;

	// Token: 0x0400001E RID: 30
	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<IncludeAssetLink> _assetLinks;

	// Token: 0x0400001F RID: 31
	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x28")]
	private Shader _recentLookup;
}
