using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000004 RID: 4
[Token(Token = "0x2000004")]
public class CinematicMuzzleFlashController : MonoBehaviour
{
	// Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000D")]
	[Address(RVA = "0x2D554A0", Offset = "0x2D53AA0", VA = "0x182D554A0")]
	public void ShowFlash()
	{
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000E")]
	[Address(RVA = "0x2D55560", Offset = "0x2D53B60", VA = "0x182D55560")]
	public void HideFlash()
	{
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000F")]
	[Address(RVA = "0x2D555E0", Offset = "0x2D53BE0", VA = "0x182D555E0")]
	private void Update()
	{
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000010")]
	[Address(RVA = "0x2D55660", Offset = "0x2D53C60", VA = "0x182D55660")]
	public CinematicMuzzleFlashController()
	{
	}

	// Token: 0x0400000A RID: 10
	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject _muzzleFlash;

	// Token: 0x0400000B RID: 11
	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _flashDuration;

	// Token: 0x0400000C RID: 12
	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x2C")]
	private float _lastFlashTime;

	// Token: 0x0400000D RID: 13
	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x30")]
	private bool _flashActive;
}
