using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200029B RID: 667
[Token(Token = "0x200029B")]
public class FindObjectsWithLayer : MonoBehaviour
{
	// Token: 0x060011D6 RID: 4566 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011D6")]
	[Address(RVA = "0x31CE930", Offset = "0x31CCF30", VA = "0x1831CE930")]
	[ContextMenu("Find Object")]
	private void DoFind()
	{
	}

	// Token: 0x060011D7 RID: 4567 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011D7")]
	[Address(RVA = "0x31CE990", Offset = "0x31CCF90", VA = "0x1831CE990")]
	public static List<GameObject> FindAllInOpenScenes(int layer)
	{
		return null;
	}

	// Token: 0x060011D8 RID: 4568 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011D8")]
	[Address(RVA = "0x31CEB70", Offset = "0x31CD170", VA = "0x1831CEB70")]
	private static List<GameObject> GetObjectsInLayer(GameObject root, int layer)
	{
		return null;
	}

	// Token: 0x060011D9 RID: 4569 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011D9")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public FindObjectsWithLayer()
	{
	}

	// Token: 0x04001193 RID: 4499
	[Token(Token = "0x4001193")]
	[FieldOffset(Offset = "0x20")]
	public int SearchLayer;

	// Token: 0x04001194 RID: 4500
	[Token(Token = "0x4001194")]
	[FieldOffset(Offset = "0x28")]
	public List<GameObject> Objects;
}
