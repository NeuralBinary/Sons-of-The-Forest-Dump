using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000007 RID: 7
[Token(Token = "0x2000007")]
public class OceanSampleDisplacementDemo : MonoBehaviour
{
	// Token: 0x06000014 RID: 20 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x6000014")]
	[Address(RVA = "0x9F0FB0", Offset = "0x9EF5B0", VA = "0x1809F0FB0")]
	private void Update()
	{
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x6000015")]
	[Address(RVA = "0x9F2700", Offset = "0x9F0D00", VA = "0x1809F2700")]
	public OceanSampleDisplacementDemo()
	{
	}

	// Token: 0x0400002F RID: 47
	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x20")]
	public bool _trackCamera;

	// Token: 0x04000030 RID: 48
	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x24")]
	[Range(0f, 32f)]
	public float _minGridSize;

	// Token: 0x04000031 RID: 49
	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x28")]
	private GameObject[] _markerObjects;

	// Token: 0x04000032 RID: 50
	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x30")]
	private Vector3[] _markerPos;

	// Token: 0x04000033 RID: 51
	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x38")]
	private Vector3[] _resultDisps;

	// Token: 0x04000034 RID: 52
	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x40")]
	private Vector3[] _resultNorms;

	// Token: 0x04000035 RID: 53
	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x48")]
	private Vector3[] _resultVels;

	// Token: 0x04000036 RID: 54
	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x50")]
	private float _samplesRadius;
}
