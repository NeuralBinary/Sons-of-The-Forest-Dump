using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001CC RID: 460
[Token(Token = "0x20001CC")]
[AddComponentMenu("Camera-Control/Mouse Orbit")]
[Serializable]
public class MouseOrbit : MonoBehaviour
{
	// Token: 0x06000CFA RID: 3322 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CFA")]
	[Address(RVA = "0x2F8FFF0", Offset = "0x2F8EFF0", VA = "0x182F8FFF0", Slot = "4")]
	public virtual void Start()
	{
	}

	// Token: 0x06000CFB RID: 3323 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CFB")]
	[Address(RVA = "0x2F8FD50", Offset = "0x2F8ED50", VA = "0x182F8FD50", Slot = "5")]
	public virtual void LateUpdate()
	{
	}

	// Token: 0x06000CFC RID: 3324 RVA: 0x00005358 File Offset: 0x00003558
	[Token(Token = "0x6000CFC")]
	[Address(RVA = "0x8E1E60", Offset = "0x8E0E60", VA = "0x1808E1E60")]
	public static float ClampAngle(float angle, float min, float max)
	{
		return default(float);
	}

	// Token: 0x06000CFD RID: 3325 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000CFD")]
	[Address(RVA = "0x2F900D0", Offset = "0x2F8F0D0", VA = "0x182F900D0")]
	public MouseOrbit()
	{
	}

	// Token: 0x04000BF7 RID: 3063
	[Token(Token = "0x4000BF7")]
	[FieldOffset(Offset = "0x20")]
	public Transform target;

	// Token: 0x04000BF8 RID: 3064
	[Token(Token = "0x4000BF8")]
	[FieldOffset(Offset = "0x28")]
	public float distance;

	// Token: 0x04000BF9 RID: 3065
	[Token(Token = "0x4000BF9")]
	[FieldOffset(Offset = "0x2C")]
	public float xSpeed;

	// Token: 0x04000BFA RID: 3066
	[Token(Token = "0x4000BFA")]
	[FieldOffset(Offset = "0x30")]
	public float ySpeed;

	// Token: 0x04000BFB RID: 3067
	[Token(Token = "0x4000BFB")]
	[FieldOffset(Offset = "0x34")]
	public int yMinLimit;

	// Token: 0x04000BFC RID: 3068
	[Token(Token = "0x4000BFC")]
	[FieldOffset(Offset = "0x38")]
	public int yMaxLimit;

	// Token: 0x04000BFD RID: 3069
	[Token(Token = "0x4000BFD")]
	[FieldOffset(Offset = "0x3C")]
	private float x;

	// Token: 0x04000BFE RID: 3070
	[Token(Token = "0x4000BFE")]
	[FieldOffset(Offset = "0x40")]
	private float y;
}
