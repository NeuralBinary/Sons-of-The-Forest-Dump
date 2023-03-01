using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002F9 RID: 761
[Token(Token = "0x20002F9")]
public class LightProbeGenerator : MonoBehaviour
{
	// Token: 0x06001365 RID: 4965 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001365")]
	[Address(RVA = "0x2C674B0", Offset = "0x2C664B0", VA = "0x182C674B0")]
	[ContextMenu("Generate")]
	private void Generate()
	{
	}

	// Token: 0x06001366 RID: 4966 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001366")]
	[Address(RVA = "0x2C67450", Offset = "0x2C66450", VA = "0x182C67450")]
	[ContextMenu("Generate Dont Split")]
	private void GenerateDontSplit()
	{
	}

	// Token: 0x06001367 RID: 4967 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001367")]
	[Address(RVA = "0x2C675B0", Offset = "0x2C665B0", VA = "0x182C675B0")]
	[ContextMenu("Split")]
	private void Split()
	{
	}

	// Token: 0x06001368 RID: 4968 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001368")]
	[Address(RVA = "0x2C672C0", Offset = "0x2C662C0", VA = "0x182C672C0")]
	private static List<Vector3> FindPositions(Vector3[] targetGroupProbePositions, float xMin, float xMax, float yMin, float yMax, float zMin, float zMax)
	{
		return null;
	}

	// Token: 0x06001369 RID: 4969 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001369")]
	[Address(RVA = "0x2C67660", Offset = "0x2C66660", VA = "0x182C67660")]
	public LightProbeGenerator()
	{
	}

	// Token: 0x04001346 RID: 4934
	[Token(Token = "0x4001346")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private LightProbeGroup _targetGroup;

	// Token: 0x04001347 RID: 4935
	[Token(Token = "0x4001347")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<LightProbeGroup> _splitGroups;

	// Token: 0x04001348 RID: 4936
	[Token(Token = "0x4001348")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float _density;

	// Token: 0x04001349 RID: 4937
	[Token(Token = "0x4001349")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private LayerMask _snapLayerMask;

	// Token: 0x0400134A RID: 4938
	[Token(Token = "0x400134A")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private int _split;
}
