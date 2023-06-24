using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000243 RID: 579
[Token(Token = "0x2000243")]
[Serializable]
public class PlaySoundRandomly : MonoBehaviour
{
	// Token: 0x06001063 RID: 4195 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001063")]
	[Address(RVA = "0x37378D0", Offset = "0x3735ED0", VA = "0x1837378D0", Slot = "4")]
	public virtual void Awake()
	{
	}

	// Token: 0x06001064 RID: 4196 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001064")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public PlaySoundRandomly()
	{
	}

	// Token: 0x04000F4D RID: 3917
	[Token(Token = "0x4000F4D")]
	[FieldOffset(Offset = "0x20")]
	private bool Playing;

	// Token: 0x04000F4E RID: 3918
	[Token(Token = "0x4000F4E")]
	[FieldOffset(Offset = "0x24")]
	private int WindDice;

	// Token: 0x04000F4F RID: 3919
	[Token(Token = "0x4000F4F")]
	[FieldOffset(Offset = "0x28")]
	private int WindDiceStop;
}
