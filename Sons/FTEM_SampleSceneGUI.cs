using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200019F RID: 415
[Token(Token = "0x200019F")]
public class FTEM_SampleSceneGUI : MonoBehaviour
{
	// Token: 0x06000C52 RID: 3154 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C52")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void Start()
	{
	}

	// Token: 0x06000C53 RID: 3155 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C53")]
	[Address(RVA = "0x36E4A40", Offset = "0x36E3040", VA = "0x1836E4A40")]
	private void Update()
	{
	}

	// Token: 0x06000C54 RID: 3156 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C54")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public FTEM_SampleSceneGUI()
	{
	}

	// Token: 0x04000ADF RID: 2783
	[Token(Token = "0x4000ADF")]
	[FieldOffset(Offset = "0x20")]
	public Text prefabName;

	// Token: 0x04000AE0 RID: 2784
	[Token(Token = "0x4000AE0")]
	[FieldOffset(Offset = "0x28")]
	public GameObject[] particlePrefab;

	// Token: 0x04000AE1 RID: 2785
	[Token(Token = "0x4000AE1")]
	[FieldOffset(Offset = "0x30")]
	public int particleNum;

	// Token: 0x04000AE2 RID: 2786
	[Token(Token = "0x4000AE2")]
	[FieldOffset(Offset = "0x38")]
	private GameObject effectPrefab;
}
