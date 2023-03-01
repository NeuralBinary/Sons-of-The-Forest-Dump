using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002E6 RID: 742
[Token(Token = "0x20002E6")]
[AddComponentMenu("Camera-Control/Smooth Follow")]
[Serializable]
public class SmoothFollow : MonoBehaviour
{
	// Token: 0x06001304 RID: 4868 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001304")]
	[Address(RVA = "0x2C6AEB0", Offset = "0x2C69EB0", VA = "0x182C6AEB0", Slot = "4")]
	public virtual void LateUpdate()
	{
	}

	// Token: 0x06001305 RID: 4869 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001305")]
	[Address(RVA = "0x2C6B310", Offset = "0x2C6A310", VA = "0x182C6B310")]
	public SmoothFollow()
	{
	}

	// Token: 0x040012EC RID: 4844
	[Token(Token = "0x40012EC")]
	[FieldOffset(Offset = "0x20")]
	public Transform target;

	// Token: 0x040012ED RID: 4845
	[Token(Token = "0x40012ED")]
	[FieldOffset(Offset = "0x28")]
	public float distance;

	// Token: 0x040012EE RID: 4846
	[Token(Token = "0x40012EE")]
	[FieldOffset(Offset = "0x2C")]
	public float height;

	// Token: 0x040012EF RID: 4847
	[Token(Token = "0x40012EF")]
	[FieldOffset(Offset = "0x30")]
	public float heightDamping;

	// Token: 0x040012F0 RID: 4848
	[Token(Token = "0x40012F0")]
	[FieldOffset(Offset = "0x34")]
	public float rotationDamping;
}
