using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020001A0 RID: 416
[Token(Token = "0x20001A0")]
public class FTEM_SampleSceneGUI : MonoBehaviour
{
	// Token: 0x06000BF8 RID: 3064 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BF8")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void Start()
	{
	}

	// Token: 0x06000BF9 RID: 3065 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BF9")]
	[Address(RVA = "0x2F63040", Offset = "0x2F62040", VA = "0x182F63040")]
	private void Update()
	{
	}

	// Token: 0x06000BFA RID: 3066 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BFA")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public FTEM_SampleSceneGUI()
	{
	}

	// Token: 0x04000AB4 RID: 2740
	[Token(Token = "0x4000AB4")]
	[FieldOffset(Offset = "0x20")]
	public Text prefabName;

	// Token: 0x04000AB5 RID: 2741
	[Token(Token = "0x4000AB5")]
	[FieldOffset(Offset = "0x28")]
	public GameObject[] particlePrefab;

	// Token: 0x04000AB6 RID: 2742
	[Token(Token = "0x4000AB6")]
	[FieldOffset(Offset = "0x30")]
	public int particleNum;

	// Token: 0x04000AB7 RID: 2743
	[Token(Token = "0x4000AB7")]
	[FieldOffset(Offset = "0x38")]
	private GameObject effectPrefab;
}
