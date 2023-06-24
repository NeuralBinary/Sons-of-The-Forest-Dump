using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002B4 RID: 692
[Token(Token = "0x20002B4")]
public class VRSpearController : MonoBehaviour
{
	// Token: 0x0600124A RID: 4682 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600124A")]
	[Address(RVA = "0x31D7EC0", Offset = "0x31D64C0", VA = "0x1831D7EC0")]
	private void Awake()
	{
	}

	// Token: 0x0600124B RID: 4683 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600124B")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void OnDisable()
	{
	}

	// Token: 0x0600124C RID: 4684 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600124C")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void Update()
	{
	}

	// Token: 0x0600124D RID: 4685 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600124D")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public VRSpearController()
	{
	}

	// Token: 0x0400122F RID: 4655
	[Token(Token = "0x400122F")]
	[FieldOffset(Offset = "0x20")]
	public float initRotY;

	// Token: 0x04001230 RID: 4656
	[Token(Token = "0x4001230")]
	[FieldOffset(Offset = "0x24")]
	private float ResetAngleTimer;

	// Token: 0x04001231 RID: 4657
	[Token(Token = "0x4001231")]
	[FieldOffset(Offset = "0x28")]
	private float smoothWeaponAngle;
}
