using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000288 RID: 648
[Token(Token = "0x2000288")]
[Serializable]
public class TurnOffLeaves : MonoBehaviour
{
	// Token: 0x060010BF RID: 4287 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010BF")]
	[Address(RVA = "0x2FBC020", Offset = "0x2FBB020", VA = "0x182FBC020", Slot = "4")]
	public virtual void Awake()
	{
	}

	// Token: 0x060010C0 RID: 4288 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010C0")]
	[Address(RVA = "0x2CC1560", Offset = "0x2CC0560", VA = "0x182CC1560", Slot = "5")]
	public virtual void doDelayStart()
	{
	}

	// Token: 0x060010C1 RID: 4289 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010C1")]
	[Address(RVA = "0x2FBC410", Offset = "0x2FBB410", VA = "0x182FBC410", Slot = "6")]
	public virtual void Update()
	{
	}

	// Token: 0x060010C2 RID: 4290 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010C2")]
	[Address(RVA = "0x2FBC0D0", Offset = "0x2FBB0D0", VA = "0x182FBC0D0", Slot = "7")]
	public virtual void TurnOff()
	{
	}

	// Token: 0x060010C3 RID: 4291 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010C3")]
	[Address(RVA = "0x2FBBF80", Offset = "0x2FBAF80", VA = "0x182FBBF80", Slot = "8")]
	public virtual void ActivateLeafParticles()
	{
	}

	// Token: 0x060010C4 RID: 4292 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60010C4")]
	[Address(RVA = "0x2FBC530", Offset = "0x2FBB530", VA = "0x182FBC530")]
	public TurnOffLeaves()
	{
	}

	// Token: 0x04001050 RID: 4176
	[Token(Token = "0x4001050")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Leaves;

	// Token: 0x04001051 RID: 4177
	[Token(Token = "0x4001051")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Rig;

	// Token: 0x04001052 RID: 4178
	[Token(Token = "0x4001052")]
	[FieldOffset(Offset = "0x30")]
	public GameObject Lower;

	// Token: 0x04001053 RID: 4179
	[Token(Token = "0x4001053")]
	[FieldOffset(Offset = "0x38")]
	public GameObject Upper;

	// Token: 0x04001054 RID: 4180
	[Token(Token = "0x4001054")]
	[FieldOffset(Offset = "0x40")]
	public GameObject Particles;

	// Token: 0x04001055 RID: 4181
	[Token(Token = "0x4001055")]
	[FieldOffset(Offset = "0x48")]
	public Transform PosChecker;

	// Token: 0x04001056 RID: 4182
	[Token(Token = "0x4001056")]
	[FieldOffset(Offset = "0x50")]
	public GameObject destroyMe;

	// Token: 0x04001057 RID: 4183
	[Token(Token = "0x4001057")]
	[FieldOffset(Offset = "0x58")]
	public float logSwitchHeightOffset;

	// Token: 0x04001058 RID: 4184
	[Token(Token = "0x4001058")]
	[FieldOffset(Offset = "0x5C")]
	public float logSwitchDelay;

	// Token: 0x04001059 RID: 4185
	[Token(Token = "0x4001059")]
	[FieldOffset(Offset = "0x60")]
	public float posCheckHeight;

	// Token: 0x0400105A RID: 4186
	[Token(Token = "0x400105A")]
	[FieldOffset(Offset = "0x64")]
	public float terrainHeight;

	// Token: 0x0400105B RID: 4187
	[Token(Token = "0x400105B")]
	[FieldOffset(Offset = "0x68")]
	private bool delayStart;

	// Token: 0x0400105C RID: 4188
	[Token(Token = "0x400105C")]
	[FieldOffset(Offset = "0x69")]
	private bool Off;
}
