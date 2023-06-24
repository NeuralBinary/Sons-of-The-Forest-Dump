using System;
using System.Collections.Generic;
using Endnight.Types;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000007 RID: 7
[Token(Token = "0x2000007")]
[AddComponentMenu("Sons/Level Props/RadioManager")]
public class RadioManager : SingletonBehaviour<RadioManager>
{
	// Token: 0x0600003F RID: 63 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003F")]
	[Address(RVA = "0x2FFC4A0", Offset = "0x2FFAAA0", VA = "0x182FFC4A0")]
	public static void Register(Transform radio)
	{
	}

	// Token: 0x06000040 RID: 64 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000040")]
	[Address(RVA = "0x2FFC520", Offset = "0x2FFAB20", VA = "0x182FFC520")]
	private void Start()
	{
	}

	// Token: 0x06000041 RID: 65 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000041")]
	[Address(RVA = "0x2FFC5D0", Offset = "0x2FFABD0", VA = "0x182FFC5D0")]
	private void CheckRadioDistances()
	{
	}

	// Token: 0x06000042 RID: 66 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000042")]
	[Address(RVA = "0x2FFC9B0", Offset = "0x2FFAFB0", VA = "0x182FFC9B0")]
	public RadioManager()
	{
	}

	// Token: 0x0400003E RID: 62
	[Token(Token = "0x400003E")]
	private const float RadioTick = 0.5f;

	// Token: 0x0400003F RID: 63
	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x28")]
	private List<Transform> _radios;

	// Token: 0x04000040 RID: 64
	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float _activeDistance;

	// Token: 0x04000041 RID: 65
	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float _distanceMargin;
}
