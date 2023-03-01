using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002E7 RID: 743
[Token(Token = "0x20002E7")]
[AddComponentMenu("Camera-Control/Smooth Look At")]
[Serializable]
public class SmoothLookAt : MonoBehaviour
{
	// Token: 0x06001306 RID: 4870 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001306")]
	[Address(RVA = "0x2C6B350", Offset = "0x2C6A350", VA = "0x182C6B350", Slot = "4")]
	public virtual void LateUpdate()
	{
	}

	// Token: 0x06001307 RID: 4871 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001307")]
	[Address(RVA = "0x2C6B530", Offset = "0x2C6A530", VA = "0x182C6B530", Slot = "5")]
	public virtual void Start()
	{
	}

	// Token: 0x06001308 RID: 4872 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001308")]
	[Address(RVA = "0x2C6B5D0", Offset = "0x2C6A5D0", VA = "0x182C6B5D0")]
	public SmoothLookAt()
	{
	}

	// Token: 0x040012F1 RID: 4849
	[Token(Token = "0x40012F1")]
	[FieldOffset(Offset = "0x20")]
	public Transform target;

	// Token: 0x040012F2 RID: 4850
	[Token(Token = "0x40012F2")]
	[FieldOffset(Offset = "0x28")]
	public float damping;

	// Token: 0x040012F3 RID: 4851
	[Token(Token = "0x40012F3")]
	[FieldOffset(Offset = "0x2C")]
	public bool smooth;
}
