using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000002 RID: 2
[Token(Token = "0x2000002")]
[CreateAssetMenu(fileName = "SonsTerrainArrayDefinitions", menuName = "SonsTerrainArrays", order = 1)]
public class SonsTerrainArrays : ScriptableObject
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x31A57B0", Offset = "0x31A3DB0", VA = "0x1831A57B0")]
	public SonsTerrainArrays()
	{
	}

	// Token: 0x04000001 RID: 1
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x18")]
	public Material TerrainMat;

	// Token: 0x04000002 RID: 2
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x20")]
	public Texture2D[] AlbedoMaps;

	// Token: 0x04000003 RID: 3
	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x28")]
	public Texture2D[] NormalMaps;

	// Token: 0x04000004 RID: 4
	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x30")]
	public Texture2D[] AOMaps;

	// Token: 0x04000005 RID: 5
	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x38")]
	public Texture2D[] SmoothnessMaps;

	// Token: 0x04000006 RID: 6
	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x40")]
	public Texture2D[] HeightMaps;

	// Token: 0x04000007 RID: 7
	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x48")]
	[Range(1f, 8f)]
	public int AlbedoAniso;

	// Token: 0x04000008 RID: 8
	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x4C")]
	[Range(1f, 8f)]
	public int NSOAniso;

	// Token: 0x04000009 RID: 9
	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x50")]
	[Range(1f, 8f)]
	public int HeightAniso;

	// Token: 0x0400000A RID: 10
	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x58")]
	public string SavePath;
}
