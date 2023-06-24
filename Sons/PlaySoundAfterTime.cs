using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000242 RID: 578
[Token(Token = "0x2000242")]
[Serializable]
public class PlaySoundAfterTime : MonoBehaviour
{
	// Token: 0x06001060 RID: 4192 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001060")]
	[Address(RVA = "0x37377A0", Offset = "0x3735DA0", VA = "0x1837377A0", Slot = "4")]
	public virtual void Start()
	{
	}

	// Token: 0x06001061 RID: 4193 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001061")]
	[Address(RVA = "0x37377F0", Offset = "0x3735DF0", VA = "0x1837377F0", Slot = "5")]
	public virtual void PlaySound()
	{
	}

	// Token: 0x06001062 RID: 4194 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001062")]
	[Address(RVA = "0x3737880", Offset = "0x3735E80", VA = "0x183737880")]
	public PlaySoundAfterTime()
	{
	}

	// Token: 0x04000F4C RID: 3916
	[Token(Token = "0x4000F4C")]
	[FieldOffset(Offset = "0x20")]
	public int waitTime;
}
