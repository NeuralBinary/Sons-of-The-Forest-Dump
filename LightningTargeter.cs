using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Atmosphere;
using UnityEngine;

// Token: 0x02000048 RID: 72
[Token(Token = "0x2000048")]
public class LightningTargeter : MonoBehaviour
{
	// Token: 0x060001E0 RID: 480 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x29AA190", Offset = "0x29A9190", VA = "0x1829AA190")]
	private void Awake()
	{
	}

	// Token: 0x060001E1 RID: 481 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x29AA410", Offset = "0x29A9410", VA = "0x1829AA410")]
	private void Initialize()
	{
	}

	// Token: 0x060001E2 RID: 482 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x29AA5A0", Offset = "0x29A95A0", VA = "0x1829AA5A0")]
	public void RollNewLightningTarget()
	{
	}

	// Token: 0x060001E3 RID: 483 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x29AA4E0", Offset = "0x29A94E0", VA = "0x1829AA4E0")]
	public static void Register(ILightningTarget target)
	{
	}

	// Token: 0x060001E4 RID: 484 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x29AAEB0", Offset = "0x29A9EB0", VA = "0x1829AAEB0")]
	public static void UnRegister(ILightningTarget target)
	{
	}

	// Token: 0x060001E5 RID: 485 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001E5")]
	private static void Register<T>(T receiver, ref List<T> list)
	{
	}

	// Token: 0x060001E6 RID: 486 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001E6")]
	private static void UnRegister<T>(T receiver, ref List<T> list)
	{
	}

	// Token: 0x060001E7 RID: 487 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x29AADB0", Offset = "0x29A9DB0", VA = "0x1829AADB0")]
	private void SetupDebugCommands()
	{
	}

	// Token: 0x060001E8 RID: 488 RVA: 0x000028F8 File Offset: 0x00000AF8
	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x29AA390", Offset = "0x29A9390", VA = "0x1829AA390")]
	private bool DebugCommandSetLightningHitTreeChance(string arguments)
	{
		return default(bool);
	}

	// Token: 0x060001E9 RID: 489 RVA: 0x00002910 File Offset: 0x00000B10
	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x29AA470", Offset = "0x29A9470", VA = "0x1829AA470")]
	private bool LightningHitTreeMustBeInfrontPlayer(string arguments)
	{
		return default(bool);
	}

	// Token: 0x060001EA RID: 490 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x29AAF70", Offset = "0x29A9F70", VA = "0x1829AAF70")]
	public LightningTargeter()
	{
	}

	// Token: 0x040001DB RID: 475
	[Token(Token = "0x40001DB")]
	[FieldOffset(Offset = "0x0")]
	private static LightningTargeter _instance;

	// Token: 0x040001DC RID: 476
	[Token(Token = "0x40001DC")]
	[FieldOffset(Offset = "0x20")]
	private List<ILightningTarget> _lightningTargets;

	// Token: 0x040001DD RID: 477
	[Token(Token = "0x40001DD")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform _lightningStrikeStartTransform;

	// Token: 0x040001DE RID: 478
	[Token(Token = "0x40001DE")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Transform _lightningStrikeEndTransform;

	// Token: 0x040001DF RID: 479
	[Token(Token = "0x40001DF")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Transform _lightningStrikeLightTransform;

	// Token: 0x040001E0 RID: 480
	[Token(Token = "0x40001E0")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Range(0f, 1f)]
	private float _chanceToStrikeOtherTarget;

	// Token: 0x040001E1 RID: 481
	[Token(Token = "0x40001E1")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private bool _treeMustBeInfrontOfPlayer;

	// Token: 0x040001E2 RID: 482
	[Token(Token = "0x40001E2")]
	[FieldOffset(Offset = "0x48")]
	[Range(0.1f, 10f)]
	[SerializeField]
	private float _defaultTrunkWidth;

	// Token: 0x040001E3 RID: 483
	[Token(Token = "0x40001E3")]
	[FieldOffset(Offset = "0x4C")]
	[Range(0.1f, 10f)]
	[SerializeField]
	private float _nearTrunkWidth;

	// Token: 0x040001E4 RID: 484
	[Token(Token = "0x40001E4")]
	[FieldOffset(Offset = "0x50")]
	[Range(0.1f, 10f)]
	[SerializeField]
	private float _defaultEndWidthMultiplier;

	// Token: 0x040001E5 RID: 485
	[Token(Token = "0x40001E5")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	[Range(0.001f, 10f)]
	private float _nearEndWidthMultiplier;

	// Token: 0x040001E6 RID: 486
	[Token(Token = "0x40001E6")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 _defaultStartPosition;

	// Token: 0x040001E7 RID: 487
	[Token(Token = "0x40001E7")]
	[FieldOffset(Offset = "0x64")]
	private Vector3 _defaultEndPosition;
}
