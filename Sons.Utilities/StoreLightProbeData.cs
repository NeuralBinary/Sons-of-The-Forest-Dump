using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000002 RID: 2
[Token(Token = "0x2000002")]
public class StoreLightProbeData : MonoBehaviour
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x315E6A0", Offset = "0x315CCA0", VA = "0x18315E6A0")]
	public StoreLightProbeData()
	{
	}

	// Token: 0x04000001 RID: 1
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool _sourceWriterOnly;

	// Token: 0x04000002 RID: 2
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private LightingSettings _quickRebakeLightingSettings;

	// Token: 0x04000003 RID: 3
	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x30")]
	[HideInInspector]
	[SerializeField]
	private List<string> _mergeScenes;

	// Token: 0x04000004 RID: 4
	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private LightProbeGroup _lightProbeGroup;

	// Token: 0x04000005 RID: 5
	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private string _outputFile;

	// Token: 0x04000006 RID: 6
	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private List<string> _inputFiles;

	// Token: 0x04000007 RID: 7
	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private bool _allowAllZero;

	// Token: 0x04000008 RID: 8
	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x58")]
	private SphericalHarmonicsL2[] _lightProbes;

	// Token: 0x04000009 RID: 9
	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x60")]
	private Vector3[] _probePositions;

	// Token: 0x0400000A RID: 10
	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	[HideInInspector]
	private List<string> _loadedScenes;

	// Token: 0x0400000B RID: 11
	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x70")]
	private LightingSettings _storedLightingSettings;
}
