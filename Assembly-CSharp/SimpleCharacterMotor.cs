using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000039 RID: 57
[Token(Token = "0x2000039")]
[RequireComponent(typeof(CharacterController))]
public class SimpleCharacterMotor : MonoBehaviour
{
	// Token: 0x060000D3 RID: 211 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x5E25D0", Offset = "0x5E0BD0", VA = "0x1805E25D0")]
	private void Awake()
	{
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x5E2720", Offset = "0x5E0D20", VA = "0x1805E2720")]
	private void Update()
	{
	}

	// Token: 0x060000D5 RID: 213 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x5E2740", Offset = "0x5E0D40", VA = "0x1805E2740")]
	private void UpdateLookRotation()
	{
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x5E2E90", Offset = "0x5E1490", VA = "0x1805E2E90")]
	private void UpdateTranslation()
	{
	}

	// Token: 0x060000D7 RID: 215 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x5E3340", Offset = "0x5E1940", VA = "0x1805E3340")]
	public SimpleCharacterMotor()
	{
	}

	// Token: 0x040001B0 RID: 432
	[Token(Token = "0x40001B0")]
	[FieldOffset(Offset = "0x20")]
	public CursorLockMode cursorLockMode;

	// Token: 0x040001B1 RID: 433
	[Token(Token = "0x40001B1")]
	[FieldOffset(Offset = "0x24")]
	public bool cursorVisible;

	// Token: 0x040001B2 RID: 434
	[Token(Token = "0x40001B2")]
	[FieldOffset(Offset = "0x28")]
	[Header("Movement")]
	public float walkSpeed;

	// Token: 0x040001B3 RID: 435
	[Token(Token = "0x40001B3")]
	[FieldOffset(Offset = "0x2C")]
	public float runSpeed;

	// Token: 0x040001B4 RID: 436
	[Token(Token = "0x40001B4")]
	[FieldOffset(Offset = "0x30")]
	public float gravity;

	// Token: 0x040001B5 RID: 437
	[Token(Token = "0x40001B5")]
	[FieldOffset(Offset = "0x38")]
	[Space]
	[Header("Look")]
	public Transform cameraPivot;

	// Token: 0x040001B6 RID: 438
	[Token(Token = "0x40001B6")]
	[FieldOffset(Offset = "0x40")]
	public float lookSpeed;

	// Token: 0x040001B7 RID: 439
	[Token(Token = "0x40001B7")]
	[FieldOffset(Offset = "0x44")]
	public bool invertY;

	// Token: 0x040001B8 RID: 440
	[Token(Token = "0x40001B8")]
	[FieldOffset(Offset = "0x48")]
	[Space]
	[Header("Smoothing")]
	public float movementAcceleration;

	// Token: 0x040001B9 RID: 441
	[Token(Token = "0x40001B9")]
	[FieldOffset(Offset = "0x50")]
	private CharacterController controller;

	// Token: 0x040001BA RID: 442
	[Token(Token = "0x40001BA")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 movement;

	// Token: 0x040001BB RID: 443
	[Token(Token = "0x40001BB")]
	[FieldOffset(Offset = "0x64")]
	private Vector3 finalMovement;

	// Token: 0x040001BC RID: 444
	[Token(Token = "0x40001BC")]
	[FieldOffset(Offset = "0x70")]
	private float speed;

	// Token: 0x040001BD RID: 445
	[Token(Token = "0x40001BD")]
	[FieldOffset(Offset = "0x74")]
	private Quaternion targetRotation;

	// Token: 0x040001BE RID: 446
	[Token(Token = "0x40001BE")]
	[FieldOffset(Offset = "0x84")]
	private Quaternion targetPivotRotation;
}
