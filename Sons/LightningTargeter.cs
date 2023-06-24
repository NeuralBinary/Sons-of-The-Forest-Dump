using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Atmosphere;
using UnityEngine;

// Token: 0x0200004A RID: 74
[Token(Token = "0x200004A")]
public class LightningTargeter : MonoBehaviour
{
	// Token: 0x060001F9 RID: 505 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x31A9F70", Offset = "0x31A8570", VA = "0x1831A9F70")]
	private void Awake()
	{
	}

	// Token: 0x060001FA RID: 506 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x31AA290", Offset = "0x31A8890", VA = "0x1831AA290")]
	private void Initialize()
	{
	}

	// Token: 0x060001FB RID: 507 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x31AA390", Offset = "0x31A8990", VA = "0x1831AA390")]
	public void RollNewLightningTarget()
	{
	}

	// Token: 0x060001FC RID: 508 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x31AAF20", Offset = "0x31A9520", VA = "0x1831AAF20")]
	public static void Register(ILightningTarget target)
	{
	}

	// Token: 0x060001FD RID: 509 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x31AB110", Offset = "0x31A9710", VA = "0x1831AB110")]
	public static void UnRegister(ILightningTarget target)
	{
	}

	// Token: 0x060001FE RID: 510 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001FE")]
	private static void Register<T>(T receiver, ref List<T> list)
	{
	}

	// Token: 0x060001FF RID: 511 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001FF")]
	private static void UnRegister<T>(T receiver, ref List<T> list)
	{
	}

	// Token: 0x06000200 RID: 512 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000200")]
	[Address(RVA = "0x31AB2B0", Offset = "0x31A98B0", VA = "0x1831AB2B0")]
	private void SetupDebugCommands()
	{
	}

	// Token: 0x06000201 RID: 513 RVA: 0x00002970 File Offset: 0x00000B70
	[Token(Token = "0x6000201")]
	[Address(RVA = "0x31AB3B0", Offset = "0x31A99B0", VA = "0x1831AB3B0")]
	private bool DebugCommandSetLightningHitTreeChance(string arguments)
	{
		return default(bool);
	}

	// Token: 0x06000202 RID: 514 RVA: 0x00002988 File Offset: 0x00000B88
	[Token(Token = "0x6000202")]
	[Address(RVA = "0x31AB480", Offset = "0x31A9A80", VA = "0x1831AB480")]
	private bool LightningHitTreeMustBeInfrontPlayer(string arguments)
	{
		return default(bool);
	}

	// Token: 0x06000203 RID: 515 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000203")]
	[Address(RVA = "0x31AB570", Offset = "0x31A9B70", VA = "0x1831AB570")]
	public LightningTargeter()
	{
	}

	// Token: 0x0400020A RID: 522
	[Token(Token = "0x400020A")]
	[FieldOffset(Offset = "0x0")]
	private static LightningTargeter _instance;

	// Token: 0x0400020B RID: 523
	[Token(Token = "0x400020B")]
	[FieldOffset(Offset = "0x20")]
	private List<ILightningTarget> _lightningTargets;

	// Token: 0x0400020C RID: 524
	[Token(Token = "0x400020C")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform _lightningStrikeStartTransform;

	// Token: 0x0400020D RID: 525
	[Token(Token = "0x400020D")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Transform _lightningStrikeEndTransform;

	// Token: 0x0400020E RID: 526
	[Token(Token = "0x400020E")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Transform _lightningStrikeLightTransform;

	// Token: 0x0400020F RID: 527
	[Token(Token = "0x400020F")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Range(0f, 1f)]
	private float _chanceToStrikeOtherTarget;

	// Token: 0x04000210 RID: 528
	[Token(Token = "0x4000210")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private bool _treeMustBeInfrontOfPlayer;

	// Token: 0x04000211 RID: 529
	[Token(Token = "0x4000211")]
	[FieldOffset(Offset = "0x48")]
	[Range(0.1f, 10f)]
	[SerializeField]
	private float _defaultTrunkWidth;

	// Token: 0x04000212 RID: 530
	[Token(Token = "0x4000212")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Range(0.1f, 10f)]
	private float _nearTrunkWidth;

	// Token: 0x04000213 RID: 531
	[Token(Token = "0x4000213")]
	[FieldOffset(Offset = "0x50")]
	[Range(0.1f, 10f)]
	[SerializeField]
	private float _defaultEndWidthMultiplier;

	// Token: 0x04000214 RID: 532
	[Token(Token = "0x4000214")]
	[FieldOffset(Offset = "0x54")]
	[Range(0.001f, 10f)]
	[SerializeField]
	private float _nearEndWidthMultiplier;

	// Token: 0x04000215 RID: 533
	[Token(Token = "0x4000215")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 _defaultStartPosition;

	// Token: 0x04000216 RID: 534
	[Token(Token = "0x4000216")]
	[FieldOffset(Offset = "0x64")]
	private Vector3 _defaultEndPosition;
}
