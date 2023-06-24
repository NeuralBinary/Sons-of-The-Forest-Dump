using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x02000258 RID: 600
[Token(Token = "0x2000258")]
[Serializable]
public class SpawnOnLoad : MonoBehaviour
{
	// Token: 0x060010BC RID: 4284 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010BC")]
	[Address(RVA = "0x373DCA0", Offset = "0x373C2A0", VA = "0x18373DCA0")]
	public void Awake()
	{
	}

	// Token: 0x060010BD RID: 4285 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010BD")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public SpawnOnLoad()
	{
	}

	// Token: 0x04000F9E RID: 3998
	[Token(Token = "0x4000F9E")]
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("MyItem")]
	public GameObject _objectToSpawn;

	// Token: 0x04000F9F RID: 3999
	[Token(Token = "0x4000F9F")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform _parent;

	// Token: 0x04000FA0 RID: 4000
	[Token(Token = "0x4000FA0")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool _destroyThisAfterInstantiation;
}
