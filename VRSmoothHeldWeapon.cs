using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002BF RID: 703
[Token(Token = "0x20002BF")]
public class VRSmoothHeldWeapon : MonoBehaviour
{
	// Token: 0x06001211 RID: 4625 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001211")]
	[Address(RVA = "0x21F6BA0", Offset = "0x21F5BA0", VA = "0x1821F6BA0")]
	private void OnEnable()
	{
	}

	// Token: 0x06001212 RID: 4626 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001212")]
	[Address(RVA = "0x2B8B810", Offset = "0x2B8A810", VA = "0x182B8B810")]
	private void OnDisable()
	{
	}

	// Token: 0x06001213 RID: 4627 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001213")]
	[Address(RVA = "0x2B8B670", Offset = "0x2B8A670", VA = "0x182B8B670")]
	private void LateUpdate()
	{
	}

	// Token: 0x06001214 RID: 4628 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001214")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public VRSmoothHeldWeapon()
	{
	}

	// Token: 0x04001202 RID: 4610
	[Token(Token = "0x4001202")]
	[FieldOffset(Offset = "0x20")]
	public Transform followTransform;

	// Token: 0x04001203 RID: 4611
	[Token(Token = "0x4001203")]
	[FieldOffset(Offset = "0x28")]
	public Transform offsetTransform;

	// Token: 0x04001204 RID: 4612
	[Token(Token = "0x4001204")]
	[FieldOffset(Offset = "0x30")]
	private Transform aimTransform;

	// Token: 0x04001205 RID: 4613
	[Token(Token = "0x4001205")]
	[FieldOffset(Offset = "0x38")]
	private Quaternion smoothRot;

	// Token: 0x04001206 RID: 4614
	[Token(Token = "0x4001206")]
	[FieldOffset(Offset = "0x48")]
	public float smoothTime;

	// Token: 0x04001207 RID: 4615
	[Token(Token = "0x4001207")]
	[FieldOffset(Offset = "0x4C")]
	private int skipFrameCount;
}
