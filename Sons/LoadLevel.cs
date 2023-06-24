using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000250 RID: 592
[Token(Token = "0x2000250")]
[Serializable]
public class LoadLevel : MonoBehaviour
{
	// Token: 0x06001087 RID: 4231 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001087")]
	[Address(RVA = "0x373ABD0", Offset = "0x37391D0", VA = "0x18373ABD0", Slot = "4")]
	public virtual void Awake()
	{
	}

	// Token: 0x06001088 RID: 4232 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001088")]
	[Address(RVA = "0x373ADB0", Offset = "0x37393B0", VA = "0x18373ADB0", Slot = "5")]
	public virtual void CheckLoad()
	{
	}

	// Token: 0x06001089 RID: 4233 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001089")]
	[Address(RVA = "0x373B150", Offset = "0x3739750", VA = "0x18373B150", Slot = "6")]
	public virtual void SendKill()
	{
	}

	// Token: 0x0600108A RID: 4234 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600108A")]
	[Address(RVA = "0x73CD40", Offset = "0x73B340", VA = "0x18073CD40", Slot = "7")]
	public virtual void ResetDelay()
	{
	}

	// Token: 0x0600108B RID: 4235 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600108B")]
	[Address(RVA = "0x373B1A0", Offset = "0x37397A0", VA = "0x18373B1A0", Slot = "8")]
	public virtual void LinkLoad()
	{
	}

	// Token: 0x0600108C RID: 4236 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600108C")]
	[Address(RVA = "0x373B2A0", Offset = "0x37398A0", VA = "0x18373B2A0")]
	public LoadLevel()
	{
	}

	// Token: 0x04000F6C RID: 3948
	[Token(Token = "0x4000F6C")]
	[FieldOffset(Offset = "0x20")]
	public GameObject LoadingIcon;

	// Token: 0x04000F6D RID: 3949
	[Token(Token = "0x4000F6D")]
	[FieldOffset(Offset = "0x28")]
	private Transform Player;

	// Token: 0x04000F6E RID: 3950
	[Token(Token = "0x4000F6E")]
	[FieldOffset(Offset = "0x30")]
	public int MyDist;

	// Token: 0x04000F6F RID: 3951
	[Token(Token = "0x4000F6F")]
	[FieldOffset(Offset = "0x38")]
	public GameObject MyTerrain;

	// Token: 0x04000F70 RID: 3952
	[Token(Token = "0x4000F70")]
	[FieldOffset(Offset = "0x40")]
	public int KillDist;

	// Token: 0x04000F71 RID: 3953
	[Token(Token = "0x4000F71")]
	[FieldOffset(Offset = "0x48")]
	public string MyLevel;

	// Token: 0x04000F72 RID: 3954
	[Token(Token = "0x4000F72")]
	[FieldOffset(Offset = "0x50")]
	public string MyLoadedName;

	// Token: 0x04000F73 RID: 3955
	[Token(Token = "0x4000F73")]
	[FieldOffset(Offset = "0x58")]
	private GameObject LoadedLevel;

	// Token: 0x04000F74 RID: 3956
	[Token(Token = "0x4000F74")]
	[FieldOffset(Offset = "0x60")]
	private bool Loaded;

	// Token: 0x04000F75 RID: 3957
	[Token(Token = "0x4000F75")]
	[FieldOffset(Offset = "0x64")]
	private int Distance;

	// Token: 0x04000F76 RID: 3958
	[Token(Token = "0x4000F76")]
	[FieldOffset(Offset = "0x68")]
	private object MyTransform;

	// Token: 0x04000F77 RID: 3959
	[Token(Token = "0x4000F77")]
	[FieldOffset(Offset = "0x70")]
	private bool Delay;
}
