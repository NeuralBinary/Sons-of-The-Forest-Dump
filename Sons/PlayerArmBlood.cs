using System;
using Il2CppDummyDll;
using Sons.Environment;
using Sons.Wearable.Race;
using UnityEngine;

// Token: 0x0200004D RID: 77
[Token(Token = "0x200004D")]
public class PlayerArmBlood : MonoBehaviour, IBloodReceiver, IEnvironmentWetnessReceiver
{
	// Token: 0x06000238 RID: 568 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000238")]
	[Address(RVA = "0x31AC810", Offset = "0x31AAE10", VA = "0x1831AC810")]
	private void Start()
	{
	}

	// Token: 0x06000239 RID: 569 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000239")]
	[Address(RVA = "0x31AC880", Offset = "0x31AAE80", VA = "0x1831AC880")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600023A RID: 570 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600023A")]
	[Address(RVA = "0x31AC950", Offset = "0x31AAF50", VA = "0x1831AC950")]
	private void OnRaceChanged(PlayerRace.Race race)
	{
	}

	// Token: 0x0600023B RID: 571 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600023B")]
	[Address(RVA = "0x31ACCF0", Offset = "0x31AB2F0", VA = "0x1831ACCF0", Slot = "4")]
	public void GotBloody(Vector3 bloodSourcePosition)
	{
	}

	// Token: 0x0600023C RID: 572 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600023C")]
	[Address(RVA = "0x31ACE40", Offset = "0x31AB440", VA = "0x1831ACE40")]
	public void Update()
	{
	}

	// Token: 0x0600023D RID: 573 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600023D")]
	[Address(RVA = "0x31AD040", Offset = "0x31AB640", VA = "0x1831AD040")]
	private void RefreshBlood()
	{
	}

	// Token: 0x0600023E RID: 574 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600023E")]
	[Address(RVA = "0x31AD110", Offset = "0x31AB710", VA = "0x1831AD110", Slot = "5")]
	public void UpdateWetness(float wetness)
	{
	}

	// Token: 0x0600023F RID: 575 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600023F")]
	[Address(RVA = "0x31AD130", Offset = "0x31AB730", VA = "0x1831AD130")]
	public PlayerArmBlood()
	{
	}

	// Token: 0x04000233 RID: 563
	[Token(Token = "0x4000233")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int _bloodPropertyID;

	// Token: 0x04000234 RID: 564
	[Token(Token = "0x4000234")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private PlayerArmBlood.Arm _arm;

	// Token: 0x04000235 RID: 565
	[Token(Token = "0x4000235")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Min(0f)]
	private float _washOffRate;

	// Token: 0x04000236 RID: 566
	[Token(Token = "0x4000236")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Range(0f, 1f)]
	private float _evaporationRate;

	// Token: 0x04000237 RID: 567
	[Token(Token = "0x4000237")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float _currentBloodAmount;

	// Token: 0x04000238 RID: 568
	[Token(Token = "0x4000238")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float _currentWetness;

	// Token: 0x04000239 RID: 569
	[Token(Token = "0x4000239")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private PlayerRaceSystem _raceSystem;

	// Token: 0x0400023A RID: 570
	[Token(Token = "0x400023A")]
	[FieldOffset(Offset = "0x40")]
	private Renderer _renderer;

	// Token: 0x0400023B RID: 571
	[Token(Token = "0x400023B")]
	[FieldOffset(Offset = "0x48")]
	private Material _material;

	// Token: 0x0200004E RID: 78
	[Token(Token = "0x200004E")]
	private enum Arm
	{
		// Token: 0x0400023D RID: 573
		[Token(Token = "0x400023D")]
		Left,
		// Token: 0x0400023E RID: 574
		[Token(Token = "0x400023E")]
		Right
	}
}
