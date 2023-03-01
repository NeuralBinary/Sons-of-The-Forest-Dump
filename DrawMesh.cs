using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001EF RID: 495
[Token(Token = "0x20001EF")]
[Serializable]
public class DrawMesh : MonoBehaviour
{
	// Token: 0x06000DA5 RID: 3493 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DA5")]
	[Address(RVA = "0x2F87860", Offset = "0x2F86860", VA = "0x182F87860", Slot = "4")]
	public virtual void Update()
	{
	}

	// Token: 0x06000DA6 RID: 3494 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DA6")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public DrawMesh()
	{
	}

	// Token: 0x04000CC8 RID: 3272
	[Token(Token = "0x4000CC8")]
	[FieldOffset(Offset = "0x20")]
	public Mesh aMesh;

	// Token: 0x04000CC9 RID: 3273
	[Token(Token = "0x4000CC9")]
	[FieldOffset(Offset = "0x28")]
	public Material aMaterial;
}
