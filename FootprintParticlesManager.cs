using System;
using Il2CppDummyDll;
using Sons.Gameplay;
using UnityEngine;

// Token: 0x02000040 RID: 64
[Token(Token = "0x2000040")]
public class FootprintParticlesManager : MonoBehaviour
{
	// Token: 0x060001B8 RID: 440 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x29A79C0", Offset = "0x29A69C0", VA = "0x1829A79C0")]
	private void Update()
	{
	}

	// Token: 0x060001B9 RID: 441 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public FootprintParticlesManager()
	{
	}

	// Token: 0x040001AA RID: 426
	[Token(Token = "0x40001AA")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private FootprintDecalSpawner _decalSpawner;

	// Token: 0x040001AB RID: 427
	[Token(Token = "0x40001AB")]
	[FieldOffset(Offset = "0x28")]
	private bool _dirty;

	// Token: 0x040001AC RID: 428
	[Token(Token = "0x40001AC")]
	[FieldOffset(Offset = "0x29")]
	private bool _onCorrectTerrain;

	// Token: 0x040001AD RID: 429
	[Token(Token = "0x40001AD")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject[] _targets;
}
