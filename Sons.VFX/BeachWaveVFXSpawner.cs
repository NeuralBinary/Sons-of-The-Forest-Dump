using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000003 RID: 3
[Token(Token = "0x2000003")]
public class BeachWaveVFXSpawner : MonoBehaviour
{
	// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000002")]
	[Address(RVA = "0x3160850", Offset = "0x315EE50", VA = "0x183160850")]
	private void ExtractJsonData()
	{
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x3160850", Offset = "0x315EE50", VA = "0x183160850")]
	private void OnValidate()
	{
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000004")]
	[Address(RVA = "0x31608F0", Offset = "0x315EEF0", VA = "0x1831608F0")]
	private void Update()
	{
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000005")]
	[Address(RVA = "0x3161760", Offset = "0x315FD60", VA = "0x183161760")]
	public BeachWaveVFXSpawner()
	{
	}

	// Token: 0x04000015 RID: 21
	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TextAsset _spawnPointDataFile;

	// Token: 0x04000016 RID: 22
	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private BeachWaveVFXSpawnPointData _spawnPointData;

	// Token: 0x04000017 RID: 23
	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<GameObject> _beachWavePrefabs;

	// Token: 0x04000018 RID: 24
	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject _wavePrefabLOD0;

	// Token: 0x04000019 RID: 25
	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject _wavePrefabLOD1;

	// Token: 0x0400001A RID: 26
	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject _wavePrefabLOD2;

	// Token: 0x0400001B RID: 27
	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private float _Lod0Range;

	// Token: 0x0400001C RID: 28
	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	private float _Lod1Range;

	// Token: 0x0400001D RID: 29
	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private float _Lod2Range;

	// Token: 0x0400001E RID: 30
	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private float _updateInterval;

	// Token: 0x0400001F RID: 31
	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private float _interval;
}
