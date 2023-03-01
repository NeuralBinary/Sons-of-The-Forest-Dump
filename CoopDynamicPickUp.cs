using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x020000B0 RID: 176
[Token(Token = "0x20000B0")]
[AddComponentMenu("Sons/Coop/CoopDynamicPickUp")]
public class CoopDynamicPickUp : CoopBase<IDynamicPickup>
{
	// Token: 0x060005A7 RID: 1447 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005A7")]
	[Address(RVA = "0x2E76230", Offset = "0x2E75230", VA = "0x182E76230")]
	public void CancelDespawn()
	{
	}

	// Token: 0x060005A8 RID: 1448 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005A8")]
	[Address(RVA = "0x2E75F30", Offset = "0x2E74F30", VA = "0x182E75F30", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x060005A9 RID: 1449 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005A9")]
	[Address(RVA = "0x2E76250", Offset = "0x2E75250", VA = "0x182E76250")]
	private IEnumerator DestroyIn(float seconds)
	{
		return null;
	}

	// Token: 0x060005AA RID: 1450 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005AA")]
	[Address(RVA = "0x2E762D0", Offset = "0x2E752D0", VA = "0x182E762D0")]
	public CoopDynamicPickUp()
	{
	}

	// Token: 0x04000506 RID: 1286
	[Token(Token = "0x4000506")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool _hasLifeTime;

	// Token: 0x04000507 RID: 1287
	[Token(Token = "0x4000507")]
	[FieldOffset(Offset = "0x34")]
	[FormerlySerializedAs("destroyAfter")]
	[SerializeField]
	private float _lifeTimeSeconds;

	// Token: 0x04000508 RID: 1288
	[Token(Token = "0x4000508")]
	[FieldOffset(Offset = "0x38")]
	[FormerlySerializedAs("disablePhysics")]
	[SerializeField]
	private bool _disablePhysics;

	// Token: 0x04000509 RID: 1289
	[Token(Token = "0x4000509")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[FormerlySerializedAs("disableOnProxies")]
	private MonoBehaviour[] _disableOnProxies;
}
