using System;
using System.Collections;
using Il2CppDummyDll;
using Sons.Gameplay;
using Sons.Inventory;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x020000B1 RID: 177
[Token(Token = "0x20000B1")]
public class CoopDynamicPickupWithInstanceModules : CoopBase<IDynamicPickupWithInstanceModules>
{
	// Token: 0x060005EB RID: 1515 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005EB")]
	[Address(RVA = "0x350F980", Offset = "0x350DF80", VA = "0x18350F980")]
	public void CancelDespawn()
	{
	}

	// Token: 0x060005EC RID: 1516 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005EC")]
	[Address(RVA = "0x3510200", Offset = "0x350E800", VA = "0x183510200", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x060005ED RID: 1517 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005ED")]
	[Address(RVA = "0x3510920", Offset = "0x350EF20", VA = "0x183510920")]
	public void PushItemInstanceToBolt(ItemInstance itemInstance)
	{
	}

	// Token: 0x060005EE RID: 1518 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005EE")]
	[Address(RVA = "0x3510A10", Offset = "0x350F010", VA = "0x183510A10")]
	private void UpdateItemInstance()
	{
	}

	// Token: 0x060005EF RID: 1519 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005EF")]
	[Address(RVA = "0x3510BE0", Offset = "0x350F1E0", VA = "0x183510BE0")]
	private IEnumerator DestroyIn(float seconds)
	{
		return null;
	}

	// Token: 0x060005F0 RID: 1520 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005F0")]
	[Address(RVA = "0x3510CA0", Offset = "0x350F2A0", VA = "0x183510CA0")]
	public CoopDynamicPickupWithInstanceModules()
	{
	}

	// Token: 0x0400052F RID: 1327
	[Token(Token = "0x400052F")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool _hasLifeTime;

	// Token: 0x04000530 RID: 1328
	[Token(Token = "0x4000530")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[FormerlySerializedAs("destroyAfter")]
	private float _lifeTimeSeconds;

	// Token: 0x04000531 RID: 1329
	[Token(Token = "0x4000531")]
	[FieldOffset(Offset = "0x38")]
	[FormerlySerializedAs("disablePhysics")]
	[SerializeField]
	private bool _disablePhysics;

	// Token: 0x04000532 RID: 1330
	[Token(Token = "0x4000532")]
	[FieldOffset(Offset = "0x40")]
	[FormerlySerializedAs("disableOnProxies")]
	[SerializeField]
	private MonoBehaviour[] _disableOnProxies;

	// Token: 0x04000533 RID: 1331
	[Token(Token = "0x4000533")]
	[FieldOffset(Offset = "0x48")]
	private PickUp _pickup;
}
