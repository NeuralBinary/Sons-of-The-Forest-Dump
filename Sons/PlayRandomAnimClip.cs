using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200000E RID: 14
[Token(Token = "0x200000E")]
public class PlayRandomAnimClip : MonoBehaviour
{
	// Token: 0x06000034 RID: 52 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000034")]
	[Address(RVA = "0x2F65940", Offset = "0x2F63F40", VA = "0x182F65940")]
	private void Start()
	{
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000035")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public PlayRandomAnimClip()
	{
	}

	// Token: 0x04000043 RID: 67
	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x20")]
	private Animation _anim;

	// Token: 0x04000044 RID: 68
	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x28")]
	public AnimationClip[] RandomClips;
}
