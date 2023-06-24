using System;
using Il2CppDummyDll;
using Sons.Gameplay;
using UnityEngine;

// Token: 0x02000040 RID: 64
[Token(Token = "0x2000040")]
public class FootprintParticlesManager : MonoBehaviour
{
	// Token: 0x060001C3 RID: 451 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x2F82890", Offset = "0x2F80E90", VA = "0x182F82890")]
	private void Update()
	{
	}

	// Token: 0x060001C4 RID: 452 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public FootprintParticlesManager()
	{
	}

	// Token: 0x040001B0 RID: 432
	[Token(Token = "0x40001B0")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private FootprintDecalSpawner _decalSpawner;

	// Token: 0x040001B1 RID: 433
	[Token(Token = "0x40001B1")]
	[FieldOffset(Offset = "0x28")]
	private bool _dirty;

	// Token: 0x040001B2 RID: 434
	[Token(Token = "0x40001B2")]
	[FieldOffset(Offset = "0x29")]
	private bool _onCorrectTerrain;

	// Token: 0x040001B3 RID: 435
	[Token(Token = "0x40001B3")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject[] _targets;
}
