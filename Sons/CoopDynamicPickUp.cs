using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x020000AF RID: 175
[Token(Token = "0x20000AF")]
[AddComponentMenu("Sons/Coop/CoopDynamicPickUp")]
public class CoopDynamicPickUp : CoopBase<IDynamicPickup>
{
	// Token: 0x060005E1 RID: 1505 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005E1")]
	[Address(RVA = "0x350F980", Offset = "0x350DF80", VA = "0x18350F980")]
	public void CancelDespawn()
	{
	}

	// Token: 0x060005E2 RID: 1506 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005E2")]
	[Address(RVA = "0x350F9E0", Offset = "0x350DFE0", VA = "0x18350F9E0", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x060005E3 RID: 1507 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60005E3")]
	[Address(RVA = "0x350FED0", Offset = "0x350E4D0", VA = "0x18350FED0")]
	private IEnumerator DestroyIn(float seconds)
	{
		return null;
	}

	// Token: 0x060005E4 RID: 1508 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60005E4")]
	[Address(RVA = "0x350FF90", Offset = "0x350E590", VA = "0x18350FF90")]
	public CoopDynamicPickUp()
	{
	}

	// Token: 0x04000527 RID: 1319
	[Token(Token = "0x4000527")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool _hasLifeTime;

	// Token: 0x04000528 RID: 1320
	[Token(Token = "0x4000528")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[FormerlySerializedAs("destroyAfter")]
	private float _lifeTimeSeconds;

	// Token: 0x04000529 RID: 1321
	[Token(Token = "0x4000529")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[FormerlySerializedAs("disablePhysics")]
	private bool _disablePhysics;

	// Token: 0x0400052A RID: 1322
	[Token(Token = "0x400052A")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[FormerlySerializedAs("disableOnProxies")]
	private MonoBehaviour[] _disableOnProxies;
}
