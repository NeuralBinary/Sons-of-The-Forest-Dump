using System;
using Il2CppDummyDll;
using Sons.Environment;
using Sons.Wearable.Race;
using UnityEngine;

// Token: 0x0200004B RID: 75
[Token(Token = "0x200004B")]
public class PlayerArmBlood : MonoBehaviour, IBloodReceiver, IEnvironmentWetnessReceiver
{
	// Token: 0x0600021C RID: 540 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600021C")]
	[Address(RVA = "0x2B70D40", Offset = "0x2B6FD40", VA = "0x182B70D40")]
	private void Start()
	{
	}

	// Token: 0x0600021D RID: 541 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600021D")]
	[Address(RVA = "0x2B70B30", Offset = "0x2B6FB30", VA = "0x182B70B30")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600021E RID: 542 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600021E")]
	[Address(RVA = "0x2B70C00", Offset = "0x2B6FC00", VA = "0x182B70C00")]
	private void OnRaceChanged(PlayerRace.Race race)
	{
	}

	// Token: 0x0600021F RID: 543 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600021F")]
	[Address(RVA = "0x2B70990", Offset = "0x2B6F990", VA = "0x182B70990", Slot = "4")]
	public void GotBloody(Vector3 bloodSourcePosition)
	{
	}

	// Token: 0x06000220 RID: 544 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000220")]
	[Address(RVA = "0x2B70DD0", Offset = "0x2B6FDD0", VA = "0x182B70DD0")]
	public void Update()
	{
	}

	// Token: 0x06000221 RID: 545 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000221")]
	[Address(RVA = "0x2B70CC0", Offset = "0x2B6FCC0", VA = "0x182B70CC0")]
	private void RefreshBlood()
	{
	}

	// Token: 0x06000222 RID: 546 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000222")]
	[Address(RVA = "0x2B70DB0", Offset = "0x2B6FDB0", VA = "0x182B70DB0", Slot = "5")]
	public void UpdateWetness(float wetness)
	{
	}

	// Token: 0x06000223 RID: 547 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000223")]
	[Address(RVA = "0x2B70F90", Offset = "0x2B6FF90", VA = "0x182B70F90")]
	public PlayerArmBlood()
	{
	}

	// Token: 0x04000202 RID: 514
	[Token(Token = "0x4000202")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int _bloodPropertyID;

	// Token: 0x04000203 RID: 515
	[Token(Token = "0x4000203")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private PlayerArmBlood.Arm _arm;

	// Token: 0x04000204 RID: 516
	[Token(Token = "0x4000204")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Min(0f)]
	private float _washOffRate;

	// Token: 0x04000205 RID: 517
	[Token(Token = "0x4000205")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Range(0f, 1f)]
	private float _evaporationRate;

	// Token: 0x04000206 RID: 518
	[Token(Token = "0x4000206")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float _currentBloodAmount;

	// Token: 0x04000207 RID: 519
	[Token(Token = "0x4000207")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float _currentWetness;

	// Token: 0x04000208 RID: 520
	[Token(Token = "0x4000208")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private PlayerRaceSystem _raceSystem;

	// Token: 0x04000209 RID: 521
	[Token(Token = "0x4000209")]
	[FieldOffset(Offset = "0x40")]
	private Renderer _renderer;

	// Token: 0x0400020A RID: 522
	[Token(Token = "0x400020A")]
	[FieldOffset(Offset = "0x48")]
	private Material _material;

	// Token: 0x0200004C RID: 76
	[Token(Token = "0x200004C")]
	private enum Arm
	{
		// Token: 0x0400020C RID: 524
		[Token(Token = "0x400020C")]
		Left,
		// Token: 0x0400020D RID: 525
		[Token(Token = "0x400020D")]
		Right
	}
}
