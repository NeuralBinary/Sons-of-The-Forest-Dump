using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000024 RID: 36
[Token(Token = "0x2000024")]
[RequireComponent(typeof(Terrain))]
public class ResetBasemapResolution : MonoBehaviour
{
	// Token: 0x06000087 RID: 135 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000087")]
	[Address(RVA = "0x5DAA30", Offset = "0x5D9030", VA = "0x1805DAA30")]
	private void OnEnable()
	{
	}

	// Token: 0x06000088 RID: 136 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000088")]
	[Address(RVA = "0x5DAA60", Offset = "0x5D9060", VA = "0x1805DAA60")]
	private void OnValidate()
	{
	}

	// Token: 0x06000089 RID: 137 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000089")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public ResetBasemapResolution()
	{
	}

	// Token: 0x04000137 RID: 311
	[Token(Token = "0x4000137")]
	[FieldOffset(Offset = "0x20")]
	public TerrainData terData;

	// Token: 0x04000138 RID: 312
	[Token(Token = "0x4000138")]
	[FieldOffset(Offset = "0x28")]
	public bool Reset;
}
