using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020002EC RID: 748
[Token(Token = "0x20002EC")]
public class LightProbeGenerator : MonoBehaviour
{
	// Token: 0x06001391 RID: 5009 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001391")]
	[Address(RVA = "0x31F72B0", Offset = "0x31F58B0", VA = "0x1831F72B0")]
	[ContextMenu("Generate")]
	private void Generate()
	{
	}

	// Token: 0x06001392 RID: 5010 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001392")]
	[Address(RVA = "0x31F7420", Offset = "0x31F5A20", VA = "0x1831F7420")]
	[ContextMenu("Generate Dont Split")]
	private void GenerateDontSplit()
	{
	}

	// Token: 0x06001393 RID: 5011 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001393")]
	[Address(RVA = "0x31F7460", Offset = "0x31F5A60", VA = "0x1831F7460")]
	[ContextMenu("Split")]
	private void Split()
	{
	}

	// Token: 0x06001394 RID: 5012 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001394")]
	[Address(RVA = "0x31F75A0", Offset = "0x31F5BA0", VA = "0x1831F75A0")]
	private static List<Vector3> FindPositions(Vector3[] targetGroupProbePositions, float xMin, float xMax, float yMin, float yMax, float zMin, float zMax)
	{
		return null;
	}

	// Token: 0x06001395 RID: 5013 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001395")]
	[Address(RVA = "0x31F7730", Offset = "0x31F5D30", VA = "0x1831F7730")]
	public LightProbeGenerator()
	{
	}

	// Token: 0x04001364 RID: 4964
	[Token(Token = "0x4001364")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private LightProbeGroup _targetGroup;

	// Token: 0x04001365 RID: 4965
	[Token(Token = "0x4001365")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<LightProbeGroup> _splitGroups;

	// Token: 0x04001366 RID: 4966
	[Token(Token = "0x4001366")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float _density;

	// Token: 0x04001367 RID: 4967
	[Token(Token = "0x4001367")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private LayerMask _snapLayerMask;

	// Token: 0x04001368 RID: 4968
	[Token(Token = "0x4001368")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private int _split;
}
