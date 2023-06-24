using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200000B RID: 11
[Token(Token = "0x200000B")]
[AddComponentMenu("Dynamic Bone/Dynamic Bone Plane Collider")]
public class DynamicBonePlaneCollider : DynamicBoneColliderBase
{
	// Token: 0x0600002D RID: 45 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002D")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void OnValidate()
	{
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00002148 File Offset: 0x00000348
	[Token(Token = "0x600002E")]
	[Address(RVA = "0xA5BC30", Offset = "0xA5A230", VA = "0x180A5BC30", Slot = "4")]
	public override bool Collide(ref Vector3 particlePosition, float particleRadius)
	{
		return default(bool);
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002F")]
	[Address(RVA = "0xA5C020", Offset = "0xA5A620", VA = "0x180A5C020")]
	private void OnDrawGizmosSelected()
	{
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000030")]
	[Address(RVA = "0xA5C340", Offset = "0xA5A940", VA = "0x180A5C340")]
	public DynamicBonePlaneCollider()
	{
	}
}
