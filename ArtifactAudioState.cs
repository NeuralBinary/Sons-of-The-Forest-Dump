using System;
using FMOD.Studio;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001D0 RID: 464
[Token(Token = "0x20001D0")]
public class ArtifactAudioState : MonoBehaviour
{
	// Token: 0x06000D16 RID: 3350 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D16")]
	[Address(RVA = "0x2F7D8E0", Offset = "0x2F7C8E0", VA = "0x182F7D8E0")]
	private void PreprocessFMODEvent(EventInstance eventInstance)
	{
	}

	// Token: 0x06000D17 RID: 3351 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D17")]
	[Address(RVA = "0x2F7D820", Offset = "0x2F7C820", VA = "0x182F7D820")]
	private void ApplyToLastEvent()
	{
	}

	// Token: 0x06000D18 RID: 3352 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D18")]
	[Address(RVA = "0x2F7D8F0", Offset = "0x2F7C8F0", VA = "0x182F7D8F0")]
	public void SetBodyPresent(bool present)
	{
	}

	// Token: 0x06000D19 RID: 3353 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D19")]
	[Address(RVA = "0x2F7D900", Offset = "0x2F7C900", VA = "0x182F7D900")]
	public void SetWorking(bool working)
	{
	}

	// Token: 0x06000D1A RID: 3354 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D1A")]
	[Address(RVA = "0x6CBFC0", Offset = "0x6CAFC0", VA = "0x1806CBFC0")]
	public ArtifactAudioState()
	{
	}

	// Token: 0x04000C13 RID: 3091
	[Token(Token = "0x4000C13")]
	[FieldOffset(Offset = "0x20")]
	private bool bodyPresent;

	// Token: 0x04000C14 RID: 3092
	[Token(Token = "0x4000C14")]
	[FieldOffset(Offset = "0x21")]
	private bool working;

	// Token: 0x04000C15 RID: 3093
	[Token(Token = "0x4000C15")]
	[FieldOffset(Offset = "0x28")]
	private EventInstance lastEvent;
}
