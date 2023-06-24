using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000015 RID: 21
[Token(Token = "0x2000015")]
public class ScaleMeshBoundsGlobally : MonoBehaviour
{
	// Token: 0x06000054 RID: 84 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000054")]
	[Address(RVA = "0x5D2A00", Offset = "0x5D1000", VA = "0x1805D2A00")]
	private void Start()
	{
	}

	// Token: 0x06000055 RID: 85 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000055")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public ScaleMeshBoundsGlobally()
	{
	}

	// Token: 0x040000C1 RID: 193
	[Token(Token = "0x40000C1")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Mesh[] _Meshes;

	// Token: 0x040000C2 RID: 194
	[Token(Token = "0x40000C2")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Vector3[] _Scales;
}
