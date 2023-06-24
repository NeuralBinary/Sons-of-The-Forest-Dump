using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002DB RID: 731
[Token(Token = "0x20002DB")]
[AddComponentMenu("Camera-Control/Smooth Look At")]
[Serializable]
public class SmoothLookAt : MonoBehaviour
{
	// Token: 0x0600133C RID: 4924 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600133C")]
	[Address(RVA = "0x31F05D0", Offset = "0x31EEBD0", VA = "0x1831F05D0", Slot = "4")]
	public virtual void LateUpdate()
	{
	}

	// Token: 0x0600133D RID: 4925 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600133D")]
	[Address(RVA = "0x31F0AE0", Offset = "0x31EF0E0", VA = "0x1831F0AE0", Slot = "5")]
	public virtual void Start()
	{
	}

	// Token: 0x0600133E RID: 4926 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600133E")]
	[Address(RVA = "0x31F0C20", Offset = "0x31EF220", VA = "0x1831F0C20")]
	public SmoothLookAt()
	{
	}

	// Token: 0x04001319 RID: 4889
	[Token(Token = "0x4001319")]
	[FieldOffset(Offset = "0x20")]
	public Transform target;

	// Token: 0x0400131A RID: 4890
	[Token(Token = "0x400131A")]
	[FieldOffset(Offset = "0x28")]
	public float damping;

	// Token: 0x0400131B RID: 4891
	[Token(Token = "0x400131B")]
	[FieldOffset(Offset = "0x2C")]
	public bool smooth;
}
