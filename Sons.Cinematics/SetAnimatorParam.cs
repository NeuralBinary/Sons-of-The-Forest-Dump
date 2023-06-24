using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000008 RID: 8
[Token(Token = "0x2000008")]
public class SetAnimatorParam : MonoBehaviour
{
	// Token: 0x06000018 RID: 24 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000018")]
	[Address(RVA = "0x2D564E0", Offset = "0x2D54AE0", VA = "0x182D564E0")]
	private void OnEnable()
	{
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000019")]
	[Address(RVA = "0x2D56810", Offset = "0x2D54E10", VA = "0x182D56810")]
	private void OnDisable()
	{
	}

	// Token: 0x0600001A RID: 26 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001A")]
	[Address(RVA = "0x2D56A70", Offset = "0x2D55070", VA = "0x182D56A70")]
	private void ApplyPreset(AnimatorParamPreset eachPreset, Animator target, bool revert = false)
	{
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001B")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public SetAnimatorParam()
	{
	}

	// Token: 0x04000017 RID: 23
	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Animator _target;

	// Token: 0x04000018 RID: 24
	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<AnimatorParamPreset> _presets;
}
