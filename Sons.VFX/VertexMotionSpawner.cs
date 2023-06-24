using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000012 RID: 18
[Token(Token = "0x2000012")]
public class VertexMotionSpawner : MonoBehaviour
{
	// Token: 0x0600005A RID: 90 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600005A")]
	[Address(RVA = "0x316ADF0", Offset = "0x31693F0", VA = "0x18316ADF0")]
	private void Update()
	{
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600005B")]
	[Address(RVA = "0x2436D10", Offset = "0x2435310", VA = "0x182436D10")]
	public VertexMotionSpawner()
	{
	}

	// Token: 0x04000078 RID: 120
	[Token(Token = "0x4000078")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _timeLatch;

	// Token: 0x04000079 RID: 121
	[Token(Token = "0x4000079")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _prefabLifespan;

	// Token: 0x0400007A RID: 122
	[Token(Token = "0x400007A")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject[] _MotionVertexPrefab;

	// Token: 0x0400007B RID: 123
	[Token(Token = "0x400007B")]
	[FieldOffset(Offset = "0x30")]
	private bool _triggered;

	// Token: 0x0400007C RID: 124
	[Token(Token = "0x400007C")]
	[FieldOffset(Offset = "0x34")]
	private float _latch;
}
