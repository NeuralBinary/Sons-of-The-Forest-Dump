using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000253 RID: 595
[Token(Token = "0x2000253")]
[Serializable]
public class LoadLevel : MonoBehaviour
{
	// Token: 0x06001031 RID: 4145 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001031")]
	[Address(RVA = "0x2FB4B00", Offset = "0x2FB3B00", VA = "0x182FB4B00", Slot = "4")]
	public virtual void Awake()
	{
	}

	// Token: 0x06001032 RID: 4146 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001032")]
	[Address(RVA = "0x2FB4BC0", Offset = "0x2FB3BC0", VA = "0x182FB4BC0", Slot = "5")]
	public virtual void CheckLoad()
	{
	}

	// Token: 0x06001033 RID: 4147 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001033")]
	[Address(RVA = "0x2FB4E90", Offset = "0x2FB3E90", VA = "0x182FB4E90", Slot = "6")]
	public virtual void SendKill()
	{
	}

	// Token: 0x06001034 RID: 4148 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001034")]
	[Address(RVA = "0x691690", Offset = "0x690690", VA = "0x180691690", Slot = "7")]
	public virtual void ResetDelay()
	{
	}

	// Token: 0x06001035 RID: 4149 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001035")]
	[Address(RVA = "0x2FB4E40", Offset = "0x2FB3E40", VA = "0x182FB4E40", Slot = "8")]
	public virtual void LinkLoad()
	{
	}

	// Token: 0x06001036 RID: 4150 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001036")]
	[Address(RVA = "0x2FB4EE0", Offset = "0x2FB3EE0", VA = "0x182FB4EE0")]
	public LoadLevel()
	{
	}

	// Token: 0x04000F41 RID: 3905
	[Token(Token = "0x4000F41")]
	[FieldOffset(Offset = "0x20")]
	public GameObject LoadingIcon;

	// Token: 0x04000F42 RID: 3906
	[Token(Token = "0x4000F42")]
	[FieldOffset(Offset = "0x28")]
	private Transform Player;

	// Token: 0x04000F43 RID: 3907
	[Token(Token = "0x4000F43")]
	[FieldOffset(Offset = "0x30")]
	public int MyDist;

	// Token: 0x04000F44 RID: 3908
	[Token(Token = "0x4000F44")]
	[FieldOffset(Offset = "0x38")]
	public GameObject MyTerrain;

	// Token: 0x04000F45 RID: 3909
	[Token(Token = "0x4000F45")]
	[FieldOffset(Offset = "0x40")]
	public int KillDist;

	// Token: 0x04000F46 RID: 3910
	[Token(Token = "0x4000F46")]
	[FieldOffset(Offset = "0x48")]
	public string MyLevel;

	// Token: 0x04000F47 RID: 3911
	[Token(Token = "0x4000F47")]
	[FieldOffset(Offset = "0x50")]
	public string MyLoadedName;

	// Token: 0x04000F48 RID: 3912
	[Token(Token = "0x4000F48")]
	[FieldOffset(Offset = "0x58")]
	private GameObject LoadedLevel;

	// Token: 0x04000F49 RID: 3913
	[Token(Token = "0x4000F49")]
	[FieldOffset(Offset = "0x60")]
	private bool Loaded;

	// Token: 0x04000F4A RID: 3914
	[Token(Token = "0x4000F4A")]
	[FieldOffset(Offset = "0x64")]
	private int Distance;

	// Token: 0x04000F4B RID: 3915
	[Token(Token = "0x4000F4B")]
	[FieldOffset(Offset = "0x68")]
	private object MyTransform;

	// Token: 0x04000F4C RID: 3916
	[Token(Token = "0x4000F4C")]
	[FieldOffset(Offset = "0x70")]
	private bool Delay;
}
