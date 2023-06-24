using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001EE RID: 494
[Token(Token = "0x20001EE")]
[Serializable]
public class DrawMesh : MonoBehaviour
{
	// Token: 0x06000E00 RID: 3584 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E00")]
	[Address(RVA = "0x37101E0", Offset = "0x370E7E0", VA = "0x1837101E0", Slot = "4")]
	public virtual void Update()
	{
	}

	// Token: 0x06000E01 RID: 3585 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E01")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public DrawMesh()
	{
	}

	// Token: 0x04000CF7 RID: 3319
	[Token(Token = "0x4000CF7")]
	[FieldOffset(Offset = "0x20")]
	public Mesh aMesh;

	// Token: 0x04000CF8 RID: 3320
	[Token(Token = "0x4000CF8")]
	[FieldOffset(Offset = "0x28")]
	public Material aMaterial;
}
