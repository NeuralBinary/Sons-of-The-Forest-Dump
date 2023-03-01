using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000FB RID: 251
[Token(Token = "0x20000FB")]
public class animateMeat : MonoBehaviour
{
	// Token: 0x06000750 RID: 1872 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000750")]
	[Address(RVA = "0x2F44BA0", Offset = "0x2F43BA0", VA = "0x182F44BA0")]
	private void Start()
	{
	}

	// Token: 0x06000751 RID: 1873 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000751")]
	[Address(RVA = "0x2F44C60", Offset = "0x2F43C60", VA = "0x182F44C60")]
	internal void playMeat(float t)
	{
	}

	// Token: 0x06000752 RID: 1874 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000752")]
	[Address(RVA = "0x2F44CD0", Offset = "0x2F43CD0", VA = "0x182F44CD0")]
	private void setMeatMaterial(bool burnt)
	{
	}

	// Token: 0x06000753 RID: 1875 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000753")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public animateMeat()
	{
	}

	// Token: 0x040005F5 RID: 1525
	[Token(Token = "0x40005F5")]
	[FieldOffset(Offset = "0x20")]
	public Animator animator;

	// Token: 0x040005F6 RID: 1526
	[Token(Token = "0x40005F6")]
	[FieldOffset(Offset = "0x28")]
	private SkinnedMeshRenderer skin;

	// Token: 0x040005F7 RID: 1527
	[Token(Token = "0x40005F7")]
	[FieldOffset(Offset = "0x30")]
	public Material meatMat;

	// Token: 0x040005F8 RID: 1528
	[Token(Token = "0x40005F8")]
	[FieldOffset(Offset = "0x38")]
	public Material burntMat;
}
