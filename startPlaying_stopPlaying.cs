using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001A9 RID: 425
[Token(Token = "0x20001A9")]
public class startPlaying_stopPlaying : MonoBehaviour
{
	// Token: 0x06000C21 RID: 3105 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C21")]
	[Address(RVA = "0x5F6200", Offset = "0x5F5200", VA = "0x1805F6200")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06000C22 RID: 3106 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C22")]
	[Address(RVA = "0x5F61F0", Offset = "0x5F51F0", VA = "0x1805F61F0")]
	private void OnTriggerExit(Collider other)
	{
	}

	// Token: 0x06000C23 RID: 3107 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C23")]
	[Address(RVA = "0x2F751B0", Offset = "0x2F741B0", VA = "0x182F751B0")]
	private void Update()
	{
	}

	// Token: 0x06000C24 RID: 3108 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C24")]
	[Address(RVA = "0x2F75150", Offset = "0x2F74150", VA = "0x182F75150")]
	private void StartPlaying()
	{
	}

	// Token: 0x06000C25 RID: 3109 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C25")]
	[Address(RVA = "0x2F75180", Offset = "0x2F74180", VA = "0x182F75180")]
	private void StopPlaying()
	{
	}

	// Token: 0x06000C26 RID: 3110 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000C26")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public startPlaying_stopPlaying()
	{
	}

	// Token: 0x04000AD6 RID: 2774
	[Token(Token = "0x4000AD6")]
	[FieldOffset(Offset = "0x20")]
	public Animator anim;

	// Token: 0x04000AD7 RID: 2775
	[Token(Token = "0x4000AD7")]
	[FieldOffset(Offset = "0x28")]
	public bool armed;
}
