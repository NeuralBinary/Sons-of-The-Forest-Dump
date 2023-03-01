using System;
using System.Collections;
using Il2CppDummyDll;
using Sons.Gameplay;
using Sons.Inventory;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x020000B2 RID: 178
[Token(Token = "0x20000B2")]
public class CoopDynamicPickupWithInstanceModules : CoopBase<IDynamicPickupWithInstanceModules>
{
	// Token: 0x060005B1 RID: 1457 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005B1")]
	[Address(RVA = "0x2E76230", Offset = "0x2E75230", VA = "0x182E76230")]
	public void CancelDespawn()
	{
	}

	// Token: 0x060005B2 RID: 1458 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005B2")]
	[Address(RVA = "0x2E76340", Offset = "0x2E75340", VA = "0x182E76340", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x060005B3 RID: 1459 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005B3")]
	[Address(RVA = "0x2E767A0", Offset = "0x2E757A0", VA = "0x182E767A0")]
	public void PushItemInstanceToBolt(ItemInstance itemInstance)
	{
	}

	// Token: 0x060005B4 RID: 1460 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005B4")]
	[Address(RVA = "0x2E768D0", Offset = "0x2E758D0", VA = "0x182E768D0")]
	private void UpdateItemInstance()
	{
	}

	// Token: 0x060005B5 RID: 1461 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005B5")]
	[Address(RVA = "0x2E76720", Offset = "0x2E75720", VA = "0x182E76720")]
	private IEnumerator DestroyIn(float seconds)
	{
		return null;
	}

	// Token: 0x060005B6 RID: 1462 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005B6")]
	[Address(RVA = "0x2E76A10", Offset = "0x2E75A10", VA = "0x182E76A10")]
	public CoopDynamicPickupWithInstanceModules()
	{
	}

	// Token: 0x0400050E RID: 1294
	[Token(Token = "0x400050E")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool _hasLifeTime;

	// Token: 0x0400050F RID: 1295
	[Token(Token = "0x400050F")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[FormerlySerializedAs("destroyAfter")]
	private float _lifeTimeSeconds;

	// Token: 0x04000510 RID: 1296
	[Token(Token = "0x4000510")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[FormerlySerializedAs("disablePhysics")]
	private bool _disablePhysics;

	// Token: 0x04000511 RID: 1297
	[Token(Token = "0x4000511")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[FormerlySerializedAs("disableOnProxies")]
	private MonoBehaviour[] _disableOnProxies;

	// Token: 0x04000512 RID: 1298
	[Token(Token = "0x4000512")]
	[FieldOffset(Offset = "0x48")]
	private PickUp _pickup;
}
