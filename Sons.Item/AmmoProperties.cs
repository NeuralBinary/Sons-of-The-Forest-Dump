using System;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

// Token: 0x02000002 RID: 2
[Token(Token = "0x2000002")]
[CreateAssetMenu(fileName = "NewAmmoProperties", menuName = "Sons/Data/Item Properties/Ammo", order = 0)]
public class AmmoProperties : ScriptableObject
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x30ACB80", Offset = "0x30AB180", VA = "0x1830ACB80")]
	public AmmoProperties()
	{
	}

	// Token: 0x04000001 RID: 1
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public bool UseHeldItemForPositionAndRotation;

	// Token: 0x04000002 RID: 2
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x20")]
	public ItemPrefabs Prefabs;

	// Token: 0x04000003 RID: 3
	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x28")]
	public bool ScatterShot;

	// Token: 0x04000004 RID: 4
	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x2C")]
	public float ScatterShotCount;

	// Token: 0x04000005 RID: 5
	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x30")]
	public float ScatterShotConeAngleDegrees;

	// Token: 0x04000006 RID: 6
	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x38")]
	public ProjectileInfo ProjectileInfo;

	// Token: 0x04000007 RID: 7
	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x40")]
	[EventRef]
	public string HitTreeEvent;

	// Token: 0x04000008 RID: 8
	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x48")]
	[EventRef]
	public string HitStructureEvent;

	// Token: 0x04000009 RID: 9
	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x50")]
	[EventRef]
	public string HitGroundEvent;

	// Token: 0x0400000A RID: 10
	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x58")]
	[EventRef]
	public string HitAiEvent;

	// Token: 0x0400000B RID: 11
	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x60")]
	[EventRef]
	public string HitBushEvent;

	// Token: 0x0400000C RID: 12
	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x68")]
	[EventRef]
	public string HitWaterEvent;

	// Token: 0x0400000D RID: 13
	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x70")]
	[EventRef]
	public string HitMetalEvent;
}
