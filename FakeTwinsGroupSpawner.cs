using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000002 RID: 2
[Token(Token = "0x2000002")]
public class FakeTwinsGroupSpawner : MonoBehaviour
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x29A5540", Offset = "0x29A4540", VA = "0x1829A5540")]
	private IEnumerator Start()
	{
		return null;
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000002")]
	[Address(RVA = "0x29A55B0", Offset = "0x29A45B0", VA = "0x1829A55B0")]
	public FakeTwinsGroupSpawner()
	{
	}

	// Token: 0x04000001 RID: 1
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Animator _prefab;

	// Token: 0x04000002 RID: 2
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string[] _animatorBeginTriggerNames;

	// Token: 0x04000003 RID: 3
	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float _moveUpDuration;
}
