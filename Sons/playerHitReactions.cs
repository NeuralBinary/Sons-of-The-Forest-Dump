using System;
using System.Collections;
using Il2CppDummyDll;
using Sons.Player;
using UnityEngine;

// Token: 0x0200014B RID: 331
[Token(Token = "0x200014B")]
public class playerHitReactions : MonoBehaviour
{
	// Token: 0x06000A28 RID: 2600 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A28")]
	[Address(RVA = "0x36AFAF0", Offset = "0x36AE0F0", VA = "0x1836AFAF0")]
	private void Awake()
	{
	}

	// Token: 0x06000A29 RID: 2601 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A29")]
	[Address(RVA = "0x36AFE00", Offset = "0x36AE400", VA = "0x1836AFE00")]
	public void enableHitState()
	{
	}

	// Token: 0x06000A2A RID: 2602 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A2A")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public void explodeForce(Transform pos)
	{
	}

	// Token: 0x06000A2B RID: 2603 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A2B")]
	[Address(RVA = "0x36AFE70", Offset = "0x36AE470", VA = "0x1836AFE70")]
	public IEnumerator enableExplodeCamera()
	{
		return null;
	}

	// Token: 0x06000A2C RID: 2604 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A2C")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public void disableExplodeCamera()
	{
	}

	// Token: 0x06000A2D RID: 2605 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A2D")]
	[Address(RVA = "0x36AFF00", Offset = "0x36AE500", VA = "0x1836AFF00")]
	public void enableExplodeShake(float dist, float explodeRadius = 5f)
	{
	}

	// Token: 0x06000A2E RID: 2606 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A2E")]
	[Address(RVA = "0x36B0000", Offset = "0x36AE600", VA = "0x1836B0000")]
	public void CameraShakeRadius(float dist, float radius = 5f, float max = 1f)
	{
	}

	// Token: 0x06000A2F RID: 2607 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A2F")]
	[Address(RVA = "0x36B0100", Offset = "0x36AE700", VA = "0x1836B0100")]
	private void resetExplodeShake()
	{
	}

	// Token: 0x06000A30 RID: 2608 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A30")]
	[Address(RVA = "0x36B0110", Offset = "0x36AE710", VA = "0x1836B0110")]
	public void enableFootShake(float dist, float mag)
	{
	}

	// Token: 0x06000A31 RID: 2609 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A31")]
	[Address(RVA = "0x36B02B0", Offset = "0x36AE8B0", VA = "0x1836B02B0")]
	public void enableWeaponHitState()
	{
	}

	// Token: 0x06000A32 RID: 2610 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A32")]
	[Address(RVA = "0x36B0320", Offset = "0x36AE920", VA = "0x1836B0320")]
	public IEnumerator doHardfallRoutine()
	{
		return null;
	}

	// Token: 0x06000A33 RID: 2611 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A33")]
	[Address(RVA = "0x36B0360", Offset = "0x36AE960", VA = "0x1836B0360")]
	public void disableImpact(float interval)
	{
	}

	// Token: 0x06000A34 RID: 2612 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A34")]
	[Address(RVA = "0x36B0440", Offset = "0x36AEA40", VA = "0x1836B0440")]
	public void enableImpact()
	{
	}

	// Token: 0x06000A35 RID: 2613 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000A35")]
	[Address(RVA = "0x36B04D0", Offset = "0x36AEAD0", VA = "0x1836B04D0")]
	public IEnumerator enablePushBack(float strength)
	{
		return null;
	}

	// Token: 0x06000A36 RID: 2614 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A36")]
	[Address(RVA = "0x36B0560", Offset = "0x36AEB60", VA = "0x1836B0560")]
	internal void setSeatedCam()
	{
	}

	// Token: 0x06000A37 RID: 2615 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A37")]
	[Address(RVA = "0x36B06B0", Offset = "0x36AECB0", VA = "0x1836B06B0")]
	public void lookAtExplosion(Vector3 pos)
	{
	}

	// Token: 0x06000A38 RID: 2616 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000A38")]
	[Address(RVA = "0x36B0900", Offset = "0x36AEF00", VA = "0x1836B0900")]
	public playerHitReactions()
	{
	}

	// Token: 0x0400087B RID: 2171
	[Token(Token = "0x400087B")]
	[FieldOffset(Offset = "0x20")]
	private FirstPersonCharacter fps;

	// Token: 0x0400087C RID: 2172
	[Token(Token = "0x400087C")]
	[FieldOffset(Offset = "0x28")]
	private Animator animator;

	// Token: 0x0400087D RID: 2173
	[Token(Token = "0x400087D")]
	[FieldOffset(Offset = "0x30")]
	private playerScriptSetup setup;

	// Token: 0x0400087E RID: 2174
	[Token(Token = "0x400087E")]
	[FieldOffset(Offset = "0x38")]
	public Vector3 hitDir;

	// Token: 0x0400087F RID: 2175
	[Token(Token = "0x400087F")]
	[FieldOffset(Offset = "0x48")]
	private SimpleMouseRotator camRotator;

	// Token: 0x04000880 RID: 2176
	[Token(Token = "0x4000880")]
	[FieldOffset(Offset = "0x50")]
	private Rigidbody _rb;

	// Token: 0x04000881 RID: 2177
	[Token(Token = "0x4000881")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private CameraShakeController _cameraShakeController;

	// Token: 0x04000882 RID: 2178
	[Token(Token = "0x4000882")]
	[FieldOffset(Offset = "0x60")]
	private int explodeHash;

	// Token: 0x04000883 RID: 2179
	[Token(Token = "0x4000883")]
	[FieldOffset(Offset = "0x64")]
	private bool doingExplodeShake;
}
