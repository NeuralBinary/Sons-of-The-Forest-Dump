using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000195 RID: 405
[Token(Token = "0x2000195")]
[Serializable]
public class MasterFire : MonoBehaviour
{
	// Token: 0x06000BD0 RID: 3024 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BD0")]
	[Address(RVA = "0x10287E0", Offset = "0x10277E0", VA = "0x1810287E0", Slot = "4")]
	public virtual void Update()
	{
	}

	// Token: 0x06000BD1 RID: 3025 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BD1")]
	[Address(RVA = "0x2F708B0", Offset = "0x2F6F8B0", VA = "0x182F708B0", Slot = "5")]
	public virtual void startFire()
	{
	}

	// Token: 0x06000BD2 RID: 3026 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BD2")]
	[Address(RVA = "0x2F706A0", Offset = "0x2F6F6A0", VA = "0x182F706A0", Slot = "6")]
	public virtual void endFire()
	{
	}

	// Token: 0x06000BD3 RID: 3027 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BD3")]
	[Address(RVA = "0x2F706F0", Offset = "0x2F6F6F0", VA = "0x182F706F0", Slot = "7")]
	public virtual void spreadFire()
	{
	}

	// Token: 0x06000BD4 RID: 3028 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BD4")]
	[Address(RVA = "0x2F70650", Offset = "0x2F6F650", VA = "0x182F70650", Slot = "8")]
	public virtual void Start()
	{
	}

	// Token: 0x06000BD5 RID: 3029 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BD5")]
	[Address(RVA = "0x2F70670", Offset = "0x2F6F670", VA = "0x182F70670")]
	public MasterFire()
	{
	}

	// Token: 0x04000A8F RID: 2703
	[Token(Token = "0x4000A8F")]
	[FieldOffset(Offset = "0x20")]
	public float fireSpread;

	// Token: 0x04000A90 RID: 2704
	[Token(Token = "0x4000A90")]
	[FieldOffset(Offset = "0x28")]
	public Transform fireParticle;

	// Token: 0x04000A91 RID: 2705
	[Token(Token = "0x4000A91")]
	[FieldOffset(Offset = "0x30")]
	public float spreadTime;

	// Token: 0x04000A92 RID: 2706
	[Token(Token = "0x4000A92")]
	[FieldOffset(Offset = "0x34")]
	public float burnTime;

	// Token: 0x04000A93 RID: 2707
	[Token(Token = "0x4000A93")]
	[FieldOffset(Offset = "0x38")]
	public bool burnOnStart;

	// Token: 0x04000A94 RID: 2708
	[Token(Token = "0x4000A94")]
	[FieldOffset(Offset = "0x39")]
	private bool fireStarted;

	// Token: 0x04000A95 RID: 2709
	[Token(Token = "0x4000A95")]
	[FieldOffset(Offset = "0x3C")]
	private float fTime;

	// Token: 0x04000A96 RID: 2710
	[Token(Token = "0x4000A96")]
	[FieldOffset(Offset = "0x40")]
	private Transform burnP;

	// Token: 0x04000A97 RID: 2711
	[Token(Token = "0x4000A97")]
	[FieldOffset(Offset = "0x48")]
	private bool fireSp;
}
