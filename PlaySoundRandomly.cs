using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000246 RID: 582
[Token(Token = "0x2000246")]
[Serializable]
public class PlaySoundRandomly : MonoBehaviour
{
	// Token: 0x0600100D RID: 4109 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600100D")]
	[Address(RVA = "0x2FB5860", Offset = "0x2FB4860", VA = "0x182FB5860", Slot = "4")]
	public virtual void Awake()
	{
	}

	// Token: 0x0600100E RID: 4110 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600100E")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public PlaySoundRandomly()
	{
	}

	// Token: 0x04000F22 RID: 3874
	[Token(Token = "0x4000F22")]
	[FieldOffset(Offset = "0x20")]
	private bool Playing;

	// Token: 0x04000F23 RID: 3875
	[Token(Token = "0x4000F23")]
	[FieldOffset(Offset = "0x24")]
	private int WindDice;

	// Token: 0x04000F24 RID: 3876
	[Token(Token = "0x4000F24")]
	[FieldOffset(Offset = "0x28")]
	private int WindDiceStop;
}
