using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000234 RID: 564
[Token(Token = "0x2000234")]
[AddComponentMenu("TheForest/Player Hang Glider Action")]
public class PlayerHangGliderAction : MonoBehaviour
{
	// Token: 0x06000F7F RID: 3967 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F7F")]
	[Address(RVA = "0x2F9D6B0", Offset = "0x2F9C6B0", VA = "0x182F9D6B0")]
	private void Start()
	{
	}

	// Token: 0x06000F80 RID: 3968 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F80")]
	[Address(RVA = "0x2F9D400", Offset = "0x2F9C400", VA = "0x182F9D400")]
	private void OnEnable()
	{
	}

	// Token: 0x06000F81 RID: 3969 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F81")]
	[Address(RVA = "0x2F9DB30", Offset = "0x2F9CB30", VA = "0x182F9DB30")]
	private void Update()
	{
	}

	// Token: 0x06000F82 RID: 3970 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F82")]
	[Address(RVA = "0x2F9E1E0", Offset = "0x2F9D1E0", VA = "0x182F9E1E0")]
	private void pickupGlider()
	{
	}

	// Token: 0x06000F83 RID: 3971 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F83")]
	[Address(RVA = "0x2F9CA30", Offset = "0x2F9BA30", VA = "0x182F9CA30")]
	internal void DropGlider(bool ignoreCurrentVelocity = false)
	{
	}

	// Token: 0x06000F84 RID: 3972 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F84")]
	[Address(RVA = "0x2F9D0D0", Offset = "0x2F9C0D0", VA = "0x182F9D0D0")]
	private void FlyWithGlider()
	{
	}

	// Token: 0x06000F85 RID: 3973 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F85")]
	[Address(RVA = "0x2F9D6D0", Offset = "0x2F9C6D0", VA = "0x182F9D6D0")]
	private void StopFlyingGlider()
	{
	}

	// Token: 0x06000F86 RID: 3974 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F86")]
	[Address(RVA = "0x2F9D410", Offset = "0x2F9C410", VA = "0x182F9D410")]
	private void SpawnDroppedGlider(Vector3 pos, bool safeSpawn)
	{
	}

	// Token: 0x06000F87 RID: 3975 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F87")]
	[Address(RVA = "0x2F9E0E0", Offset = "0x2F9D0E0", VA = "0x182F9E0E0")]
	private IEnumerator forceHighDragOnSpawn(Rigidbody rb)
	{
		return null;
	}

	// Token: 0x06000F88 RID: 3976 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F88")]
	[Address(RVA = "0x2F9E090", Offset = "0x2F9D090", VA = "0x182F9E090")]
	private void enableFallDamage()
	{
	}

	// Token: 0x06000F89 RID: 3977 RVA: 0x00005BE0 File Offset: 0x00003DE0
	[Token(Token = "0x6000F89")]
	[Address(RVA = "0x2F9E150", Offset = "0x2F9D150", VA = "0x182F9E150")]
	private bool isOutsideWorldBounds()
	{
		return default(bool);
	}

	// Token: 0x06000F8A RID: 3978 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F8A")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public PlayerHangGliderAction()
	{
	}

	// Token: 0x04000E80 RID: 3712
	[Token(Token = "0x4000E80")]
	[FieldOffset(Offset = "0x20")]
	public GameObject gliderHeld;

	// Token: 0x04000E81 RID: 3713
	[Token(Token = "0x4000E81")]
	[FieldOffset(Offset = "0x28")]
	public GameObject gliderSpawnPickup;

	// Token: 0x04000E82 RID: 3714
	[Token(Token = "0x4000E82")]
	[FieldOffset(Offset = "0x30")]
	public Transform VRGliderTr;

	// Token: 0x04000E83 RID: 3715
	[Token(Token = "0x4000E83")]
	[FieldOffset(Offset = "0x38")]
	private bool wasFlying;

	// Token: 0x04000E84 RID: 3716
	[Token(Token = "0x4000E84")]
	[FieldOffset(Offset = "0x3C")]
	private float startFlyingDelay;

	// Token: 0x04000E85 RID: 3717
	[Token(Token = "0x4000E85")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 startGliderOffset;

	// Token: 0x04000E86 RID: 3718
	[Token(Token = "0x4000E86")]
	[FieldOffset(Offset = "0x4C")]
	private Vector3 smoothGliderOffset;
}
