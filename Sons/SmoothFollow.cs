using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002DA RID: 730
[Token(Token = "0x20002DA")]
[AddComponentMenu("Camera-Control/Smooth Follow")]
[Serializable]
public class SmoothFollow : MonoBehaviour
{
	// Token: 0x0600133A RID: 4922 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600133A")]
	[Address(RVA = "0x31EFC10", Offset = "0x31EE210", VA = "0x1831EFC10", Slot = "4")]
	public virtual void LateUpdate()
	{
	}

	// Token: 0x0600133B RID: 4923 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600133B")]
	[Address(RVA = "0x31F0570", Offset = "0x31EEB70", VA = "0x1831F0570")]
	public SmoothFollow()
	{
	}

	// Token: 0x04001314 RID: 4884
	[Token(Token = "0x4001314")]
	[FieldOffset(Offset = "0x20")]
	public Transform target;

	// Token: 0x04001315 RID: 4885
	[Token(Token = "0x4001315")]
	[FieldOffset(Offset = "0x28")]
	public float distance;

	// Token: 0x04001316 RID: 4886
	[Token(Token = "0x4001316")]
	[FieldOffset(Offset = "0x2C")]
	public float height;

	// Token: 0x04001317 RID: 4887
	[Token(Token = "0x4001317")]
	[FieldOffset(Offset = "0x30")]
	public float heightDamping;

	// Token: 0x04001318 RID: 4888
	[Token(Token = "0x4001318")]
	[FieldOffset(Offset = "0x34")]
	public float rotationDamping;
}
