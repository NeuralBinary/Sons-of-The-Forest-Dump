using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000245 RID: 581
[Token(Token = "0x2000245")]
[Serializable]
public class PlaySoundAfterTime : MonoBehaviour
{
	// Token: 0x0600100A RID: 4106 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600100A")]
	[Address(RVA = "0x2FB57F0", Offset = "0x2FB47F0", VA = "0x182FB57F0", Slot = "4")]
	public virtual void Start()
	{
	}

	// Token: 0x0600100B RID: 4107 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600100B")]
	[Address(RVA = "0x2FB57A0", Offset = "0x2FB47A0", VA = "0x182FB57A0", Slot = "5")]
	public virtual void PlaySound()
	{
	}

	// Token: 0x0600100C RID: 4108 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600100C")]
	[Address(RVA = "0x2FB5840", Offset = "0x2FB4840", VA = "0x182FB5840")]
	public PlaySoundAfterTime()
	{
	}

	// Token: 0x04000F21 RID: 3873
	[Token(Token = "0x4000F21")]
	[FieldOffset(Offset = "0x20")]
	public int waitTime;
}
