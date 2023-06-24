using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000008 RID: 8
[Token(Token = "0x2000008")]
[AddComponentMenu("Sons/Utilities/Path Bounds List")]
public class PathBoundsList : MonoBehaviour
{
	// Token: 0x06000039 RID: 57 RVA: 0x0000227A File Offset: 0x0000047A
	[Token(Token = "0x6000039")]
	[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
	public List<BoundsShape> GetPathShapes()
	{
		return null;
	}

	// Token: 0x0600003A RID: 58 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003A")]
	[Address(RVA = "0x2AE7180", Offset = "0x2AE5780", VA = "0x182AE7180")]
	private void CollectBounds()
	{
	}

	// Token: 0x0600003B RID: 59 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003B")]
	[Address(RVA = "0x2AE7300", Offset = "0x2AE5900", VA = "0x182AE7300")]
	private void OnDrawGizmosSelected()
	{
	}

	// Token: 0x0600003C RID: 60 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003C")]
	[Address(RVA = "0x2AE7310", Offset = "0x2AE5910", VA = "0x182AE7310")]
	public void DrawGizmos()
	{
	}

	// Token: 0x0600003D RID: 61 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003D")]
	[Address(RVA = "0x2AE7630", Offset = "0x2AE5C30", VA = "0x182AE7630")]
	public PathBoundsList()
	{
	}

	// Token: 0x0400003E RID: 62
	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<BoundsShape> _pathShapes;
}
