using System;
using System.Collections;
using Il2CppDummyDll;
using Sons.Player;
using UnityEngine;

// Token: 0x0200014C RID: 332
[Token(Token = "0x200014C")]
public class playerHitReactions : MonoBehaviour
{
	// Token: 0x060009D9 RID: 2521 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009D9")]
	[Address(RVA = "0x2F5AC10", Offset = "0x2F59C10", VA = "0x182F5AC10")]
	private void Awake()
	{
	}

	// Token: 0x060009DA RID: 2522 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009DA")]
	[Address(RVA = "0x2F5B1A0", Offset = "0x2F5A1A0", VA = "0x182F5B1A0")]
	public void enableHitState()
	{
	}

	// Token: 0x060009DB RID: 2523 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009DB")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	public void explodeForce(Transform pos)
	{
	}

	// Token: 0x060009DC RID: 2524 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009DC")]
	[Address(RVA = "0x2F5AEB0", Offset = "0x2F59EB0", VA = "0x182F5AEB0")]
	public IEnumerator enableExplodeCamera()
	{
		return null;
	}

	// Token: 0x060009DD RID: 2525 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009DD")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	public void disableExplodeCamera()
	{
	}

	// Token: 0x060009DE RID: 2526 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009DE")]
	[Address(RVA = "0x2F5AF20", Offset = "0x2F59F20", VA = "0x182F5AF20")]
	public void enableExplodeShake(float dist, float explodeRadius = 5f)
	{
	}

	// Token: 0x060009DF RID: 2527 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009DF")]
	[Address(RVA = "0x2F5B420", Offset = "0x2F5A420", VA = "0x182F5B420")]
	private void resetExplodeShake()
	{
	}

	// Token: 0x060009E0 RID: 2528 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009E0")]
	[Address(RVA = "0x2F5B020", Offset = "0x2F5A020", VA = "0x182F5B020")]
	public void enableFootShake(float dist, float mag)
	{
	}

	// Token: 0x060009E1 RID: 2529 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009E1")]
	[Address(RVA = "0x2F5B2B0", Offset = "0x2F5A2B0", VA = "0x182F5B2B0")]
	public void enableWeaponHitState()
	{
	}

	// Token: 0x060009E2 RID: 2530 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009E2")]
	[Address(RVA = "0x2F5AE60", Offset = "0x2F59E60", VA = "0x182F5AE60")]
	public IEnumerator doHardfallRoutine()
	{
		return null;
	}

	// Token: 0x060009E3 RID: 2531 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009E3")]
	[Address(RVA = "0x2F5ADD0", Offset = "0x2F59DD0", VA = "0x182F5ADD0")]
	public void disableImpact(float interval)
	{
	}

	// Token: 0x060009E4 RID: 2532 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009E4")]
	[Address(RVA = "0x2F5B1F0", Offset = "0x2F5A1F0", VA = "0x182F5B1F0")]
	public void enableImpact()
	{
	}

	// Token: 0x060009E5 RID: 2533 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60009E5")]
	[Address(RVA = "0x2F5B240", Offset = "0x2F5A240", VA = "0x182F5B240")]
	public IEnumerator enablePushBack(float strength)
	{
		return null;
	}

	// Token: 0x060009E6 RID: 2534 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009E6")]
	[Address(RVA = "0x2F5B430", Offset = "0x2F5A430", VA = "0x182F5B430")]
	internal void setSeatedCam()
	{
	}

	// Token: 0x060009E7 RID: 2535 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009E7")]
	[Address(RVA = "0x2F5B300", Offset = "0x2F5A300", VA = "0x182F5B300")]
	public void lookAtExplosion(Vector3 pos)
	{
	}

	// Token: 0x060009E8 RID: 2536 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60009E8")]
	[Address(RVA = "0x2F5AD80", Offset = "0x2F59D80", VA = "0x182F5AD80")]
	public playerHitReactions()
	{
	}

	// Token: 0x04000858 RID: 2136
	[Token(Token = "0x4000858")]
	[FieldOffset(Offset = "0x20")]
	private FirstPersonCharacter fps;

	// Token: 0x04000859 RID: 2137
	[Token(Token = "0x4000859")]
	[FieldOffset(Offset = "0x28")]
	private Animator animator;

	// Token: 0x0400085A RID: 2138
	[Token(Token = "0x400085A")]
	[FieldOffset(Offset = "0x30")]
	private playerScriptSetup setup;

	// Token: 0x0400085B RID: 2139
	[Token(Token = "0x400085B")]
	[FieldOffset(Offset = "0x38")]
	public GameObject camAnim;

	// Token: 0x0400085C RID: 2140
	[Token(Token = "0x400085C")]
	[FieldOffset(Offset = "0x40")]
	private Animation camAnimation;

	// Token: 0x0400085D RID: 2141
	[Token(Token = "0x400085D")]
	[FieldOffset(Offset = "0x48")]
	public Vector3 hitDir;

	// Token: 0x0400085E RID: 2142
	[Token(Token = "0x400085E")]
	[FieldOffset(Offset = "0x58")]
	private SimpleMouseRotator camRotator;

	// Token: 0x0400085F RID: 2143
	[Token(Token = "0x400085F")]
	[FieldOffset(Offset = "0x60")]
	private Rigidbody _rb;

	// Token: 0x04000860 RID: 2144
	[Token(Token = "0x4000860")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private CameraShakeController _cameraShakeController;

	// Token: 0x04000861 RID: 2145
	[Token(Token = "0x4000861")]
	[FieldOffset(Offset = "0x70")]
	private int explodeHash;

	// Token: 0x04000862 RID: 2146
	[Token(Token = "0x4000862")]
	[FieldOffset(Offset = "0x74")]
	private bool doingExplodeShake;
}
