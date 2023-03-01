using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x0200025D RID: 605
[Token(Token = "0x200025D")]
[Serializable]
public class SpawnOnLoad : MonoBehaviour
{
	// Token: 0x0600106E RID: 4206 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600106E")]
	[Address(RVA = "0x2FBA330", Offset = "0x2FB9330", VA = "0x182FBA330")]
	public void Awake()
	{
	}

	// Token: 0x0600106F RID: 4207 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600106F")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public SpawnOnLoad()
	{
	}

	// Token: 0x04000F78 RID: 3960
	[Token(Token = "0x4000F78")]
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("MyItem")]
	public GameObject _objectToSpawn;

	// Token: 0x04000F79 RID: 3961
	[Token(Token = "0x4000F79")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform _parent;

	// Token: 0x04000F7A RID: 3962
	[Token(Token = "0x4000F7A")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool _destroyThisAfterInstantiation;
}
