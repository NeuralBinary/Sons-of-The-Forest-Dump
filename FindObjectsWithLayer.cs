using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002A7 RID: 679
[Token(Token = "0x20002A7")]
public class FindObjectsWithLayer : MonoBehaviour
{
	// Token: 0x060011A1 RID: 4513 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011A1")]
	[Address(RVA = "0x2B828F0", Offset = "0x2B818F0", VA = "0x182B828F0")]
	[ContextMenu("Find Object")]
	private void DoFind()
	{
	}

	// Token: 0x060011A2 RID: 4514 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011A2")]
	[Address(RVA = "0x2B82A60", Offset = "0x2B81A60", VA = "0x182B82A60")]
	public static List<GameObject> FindAllInOpenScenes(int layer)
	{
		return null;
	}

	// Token: 0x060011A3 RID: 4515 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60011A3")]
	[Address(RVA = "0x2B82BB0", Offset = "0x2B81BB0", VA = "0x182B82BB0")]
	private static List<GameObject> GetObjectsInLayer(GameObject root, int layer)
	{
		return null;
	}

	// Token: 0x060011A4 RID: 4516 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60011A4")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public FindObjectsWithLayer()
	{
	}

	// Token: 0x0400116C RID: 4460
	[Token(Token = "0x400116C")]
	[FieldOffset(Offset = "0x20")]
	public int SearchLayer;

	// Token: 0x0400116D RID: 4461
	[Token(Token = "0x400116D")]
	[FieldOffset(Offset = "0x28")]
	public List<GameObject> Objects;
}
