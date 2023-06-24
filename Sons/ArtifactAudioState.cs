using System;
using FMOD.Studio;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001CF RID: 463
[Token(Token = "0x20001CF")]
public class ArtifactAudioState : MonoBehaviour
{
	// Token: 0x06000D71 RID: 3441 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D71")]
	[Address(RVA = "0x37013D0", Offset = "0x36FF9D0", VA = "0x1837013D0")]
	private void PreprocessFMODEvent(EventInstance eventInstance)
	{
	}

	// Token: 0x06000D72 RID: 3442 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D72")]
	[Address(RVA = "0x37013E0", Offset = "0x36FF9E0", VA = "0x1837013E0")]
	private void ApplyToLastEvent()
	{
	}

	// Token: 0x06000D73 RID: 3443 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D73")]
	[Address(RVA = "0x37014A0", Offset = "0x36FFAA0", VA = "0x1837014A0")]
	public void SetBodyPresent(bool present)
	{
	}

	// Token: 0x06000D74 RID: 3444 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D74")]
	[Address(RVA = "0x37014B0", Offset = "0x36FFAB0", VA = "0x1837014B0")]
	public void SetWorking(bool working)
	{
	}

	// Token: 0x06000D75 RID: 3445 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D75")]
	[Address(RVA = "0x7951A0", Offset = "0x7937A0", VA = "0x1807951A0")]
	public ArtifactAudioState()
	{
	}

	// Token: 0x04000C42 RID: 3138
	[Token(Token = "0x4000C42")]
	[FieldOffset(Offset = "0x20")]
	private bool bodyPresent;

	// Token: 0x04000C43 RID: 3139
	[Token(Token = "0x4000C43")]
	[FieldOffset(Offset = "0x21")]
	private bool working;

	// Token: 0x04000C44 RID: 3140
	[Token(Token = "0x4000C44")]
	[FieldOffset(Offset = "0x28")]
	private EventInstance lastEvent;
}
