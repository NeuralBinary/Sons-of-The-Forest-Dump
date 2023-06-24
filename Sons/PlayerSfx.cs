using System;
using System.Collections;
using System.Collections.Generic;
using Bolt;
using FMOD;
using FMOD.Studio;
using FMODUnity;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200022C RID: 556
[Token(Token = "0x200022C")]
public class PlayerSfx : EntityEventListener<IPlayerState>
{
	// Token: 0x06000F85 RID: 3973 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F85")]
	[Address(RVA = "0x372A670", Offset = "0x3728C70", VA = "0x18372A670")]
	private IEnumerable<string> AllEventPaths()
	{
		return null;
	}

	// Token: 0x06000F86 RID: 3974 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F86")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void Awake()
	{
	}

	// Token: 0x06000F87 RID: 3975 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F87")]
	[Address(RVA = "0x372A830", Offset = "0x3728E30", VA = "0x18372A830")]
	private void Start()
	{
	}

	// Token: 0x06000F88 RID: 3976 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F88")]
	[Address(RVA = "0x372AD40", Offset = "0x3729340", VA = "0x18372AD40")]
	private static void Set3DAttributes(EventInstance evt, ATTRIBUTES_3D attributes)
	{
	}

	// Token: 0x06000F89 RID: 3977 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F89")]
	[Address(RVA = "0x372AE20", Offset = "0x3729420", VA = "0x18372AE20")]
	private void Update()
	{
	}

	// Token: 0x06000F8A RID: 3978 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F8A")]
	[Address(RVA = "0x372B310", Offset = "0x3729910", VA = "0x18372B310")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000F8B RID: 3979 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F8B")]
	[Address(RVA = "0x372B380", Offset = "0x3729980", VA = "0x18372B380")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06000F8C RID: 3980 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F8C")]
	[Address(RVA = "0x372B480", Offset = "0x3729A80", VA = "0x18372B480")]
	public void TriggerSwimStroke()
	{
	}

	// Token: 0x06000F8D RID: 3981 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F8D")]
	[Address(RVA = "0x372B5F0", Offset = "0x3729BF0", VA = "0x18372B5F0")]
	public void PlayStructureBreak(GameObject emiter, float size)
	{
	}

	// Token: 0x06000F8E RID: 3982 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F8E")]
	[Address(RVA = "0x372B850", Offset = "0x3729E50", VA = "0x18372B850")]
	public void PlayStructureFall(GameObject emiter, float size)
	{
	}

	// Token: 0x06000F8F RID: 3983 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F8F")]
	[Address(RVA = "0x372BAB0", Offset = "0x372A0B0", VA = "0x18372BAB0")]
	public void PlayWakeMusic()
	{
	}

	// Token: 0x06000F90 RID: 3984 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F90")]
	[Address(RVA = "0x372BB10", Offset = "0x372A110", VA = "0x18372BB10")]
	public void PlayPlantRustle()
	{
	}

	// Token: 0x06000F91 RID: 3985 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F91")]
	[Address(RVA = "0x372BDD0", Offset = "0x372A3D0", VA = "0x18372BDD0")]
	private void EnablePlantRustle()
	{
	}

	// Token: 0x06000F92 RID: 3986 RVA: 0x00005D78 File Offset: 0x00003F78
	[Token(Token = "0x6000F92")]
	[Address(RVA = "0x372BDE0", Offset = "0x372A3E0", VA = "0x18372BDE0")]
	public EventInstance PlayEvent(string path, GameObject gameObject)
	{
		return default(EventInstance);
	}

	// Token: 0x06000F93 RID: 3987 RVA: 0x00005D90 File Offset: 0x00003F90
	[Token(Token = "0x6000F93")]
	[Address(RVA = "0x372BEE0", Offset = "0x372A4E0", VA = "0x18372BEE0")]
	public EventInstance PlayEvent(string path, Vector3 position)
	{
		return default(EventInstance);
	}

	// Token: 0x06000F94 RID: 3988 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F94")]
	[Address(RVA = "0x372C130", Offset = "0x372A730", VA = "0x18372C130")]
	public void PlayWhoosh()
	{
	}

	// Token: 0x06000F95 RID: 3989 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F95")]
	[Address(RVA = "0x372C140", Offset = "0x372A740", VA = "0x18372C140")]
	public void PlayWhoosh(Vector3 position)
	{
	}

	// Token: 0x06000F96 RID: 3990 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F96")]
	[Address(RVA = "0x372C170", Offset = "0x372A770", VA = "0x18372C170")]
	public void PlayTwinkle()
	{
	}

	// Token: 0x06000F97 RID: 3991 RVA: 0x00005DA8 File Offset: 0x00003FA8
	[Token(Token = "0x6000F97")]
	[Address(RVA = "0x372C190", Offset = "0x372A790", VA = "0x18372C190")]
	private static Vector3 FindClosestPoint(GameObject gameObject, Vector3 position)
	{
		return default(Vector3);
	}

	// Token: 0x06000F98 RID: 3992 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F98")]
	[Address(RVA = "0x372C480", Offset = "0x372AA80", VA = "0x18372C480")]
	public void PlayBuildingComplete(GameObject building, bool networkSync = false)
	{
	}

	// Token: 0x06000F99 RID: 3993 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F99")]
	[Address(RVA = "0x372C680", Offset = "0x372AC80", VA = "0x18372C680")]
	public void PlayBuildingRepair(GameObject building)
	{
	}

	// Token: 0x06000F9A RID: 3994 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F9A")]
	[Address(RVA = "0x372C840", Offset = "0x372AE40", VA = "0x18372C840")]
	public void PlayRemove()
	{
	}

	// Token: 0x06000F9B RID: 3995 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F9B")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "191")]
	public override void OnEvent(SfxEat evnt)
	{
	}

	// Token: 0x06000F9C RID: 3996 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F9C")]
	[Address(RVA = "0x372C860", Offset = "0x372AE60", VA = "0x18372C860", Slot = "192")]
	public override void OnEvent(SfxDrink evnt)
	{
	}

	// Token: 0x06000F9D RID: 3997 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F9D")]
	[Address(RVA = "0x372C860", Offset = "0x372AE60", VA = "0x18372C860")]
	public void PlayDrink()
	{
	}

	// Token: 0x06000F9E RID: 3998 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F9E")]
	[Address(RVA = "0x372C880", Offset = "0x372AE80", VA = "0x18372C880")]
	public void PlayDrinkFromWaterSource()
	{
	}

	// Token: 0x06000F9F RID: 3999 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F9F")]
	[Address(RVA = "0x372C8A0", Offset = "0x372AEA0", VA = "0x18372C8A0")]
	public void PlayHurtSound()
	{
	}

	// Token: 0x06000FA0 RID: 4000 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FA0")]
	[Address(RVA = "0x372C8C0", Offset = "0x372AEC0", VA = "0x18372C8C0")]
	public void PlayBlockedSound()
	{
	}

	// Token: 0x06000FA1 RID: 4001 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FA1")]
	[Address(RVA = "0x372C8E0", Offset = "0x372AEE0", VA = "0x18372C8E0")]
	public void PlayJumpSound()
	{
	}

	// Token: 0x06000FA2 RID: 4002 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FA2")]
	[Address(RVA = "0x372C960", Offset = "0x372AF60", VA = "0x18372C960")]
	private void EnableJump()
	{
	}

	// Token: 0x06000FA3 RID: 4003 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FA3")]
	[Address(RVA = "0x372C970", Offset = "0x372AF70", VA = "0x18372C970", Slot = "190")]
	public override void OnEvent(SfxHammer evnt)
	{
	}

	// Token: 0x06000FA4 RID: 4004 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FA4")]
	[Address(RVA = "0x372C970", Offset = "0x372AF70", VA = "0x18372C970")]
	public void PlayHammer()
	{
	}

	// Token: 0x06000FA5 RID: 4005 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FA5")]
	[Address(RVA = "0x372C990", Offset = "0x372AF90", VA = "0x18372C990")]
	public IEnumerator playVisWarning()
	{
		return null;
	}

	// Token: 0x06000FA6 RID: 4006 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000FA6")]
	[Address(RVA = "0x372CA20", Offset = "0x372B020", VA = "0x18372CA20")]
	public IEnumerator stopVisWarning()
	{
		return null;
	}

	// Token: 0x06000FA7 RID: 4007 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FA7")]
	[Address(RVA = "0x372CAB0", Offset = "0x372B0B0", VA = "0x18372CAB0")]
	public void PlayInjured()
	{
	}

	// Token: 0x06000FA8 RID: 4008 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FA8")]
	[Address(RVA = "0x66EAE0", Offset = "0x66D0E0", VA = "0x18066EAE0")]
	public void StopPlaying()
	{
	}

	// Token: 0x06000FA9 RID: 4009 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FA9")]
	[Address(RVA = "0x372CB10", Offset = "0x372B110", VA = "0x18372CB10")]
	public void PlayDigDirtPile(GameObject dirtPile)
	{
	}

	// Token: 0x06000FAA RID: 4010 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FAA")]
	[Address(RVA = "0x372CB30", Offset = "0x372B130", VA = "0x18372CB30")]
	public void PlayBreakWood(GameObject wood)
	{
	}

	// Token: 0x06000FAB RID: 4011 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FAB")]
	[Address(RVA = "0x372CB50", Offset = "0x372B150", VA = "0x18372CB50")]
	public void PlayUpgradeSuccess(GameObject upgradeView)
	{
	}

	// Token: 0x06000FAC RID: 4012 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FAC")]
	[Address(RVA = "0x372CB70", Offset = "0x372B170", VA = "0x18372CB70")]
	public void PlayAfterStorm()
	{
	}

	// Token: 0x06000FAD RID: 4013 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FAD")]
	[Address(RVA = "0x372CC40", Offset = "0x372B240", VA = "0x18372CC40")]
	public void SetSleddingLoop(bool onOff)
	{
	}

	// Token: 0x06000FAE RID: 4014 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FAE")]
	[Address(RVA = "0x372CF60", Offset = "0x372B560", VA = "0x18372CF60", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x06000FAF RID: 4015 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FAF")]
	[Address(RVA = "0x372D1A0", Offset = "0x372B7A0", VA = "0x18372D1A0")]
	private void OnLoopingEventPathUpdate()
	{
	}

	// Token: 0x06000FB0 RID: 4016 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FB0")]
	[Address(RVA = "0x372D8F0", Offset = "0x372BEF0", VA = "0x18372D8F0")]
	private void SyncLoopingEvent(string path, Vector3 position)
	{
	}

	// Token: 0x06000FB1 RID: 4017 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000FB1")]
	[Address(RVA = "0x372DB70", Offset = "0x372C170", VA = "0x18372DB70")]
	public PlayerSfx()
	{
	}

	// Token: 0x04000E5D RID: 3677
	[Token(Token = "0x4000E5D")]
	[FieldOffset(Offset = "0x28")]
	private bool Playing;

	// Token: 0x04000E5E RID: 3678
	[Token(Token = "0x4000E5E")]
	[FieldOffset(Offset = "0x29")]
	public bool Remote;

	// Token: 0x04000E5F RID: 3679
	[Token(Token = "0x4000E5F")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Rigidbody _rigidbody;

	// Token: 0x04000E60 RID: 3680
	[Token(Token = "0x4000E60")]
	[FieldOffset(Offset = "0x38")]
	public GameObject SfxPlayer;

	// Token: 0x04000E61 RID: 3681
	[Token(Token = "0x4000E61")]
	[FieldOffset(Offset = "0x40")]
	public GameObject SfxGUI;

	// Token: 0x04000E62 RID: 3682
	[Token(Token = "0x4000E62")]
	[FieldOffset(Offset = "0x48")]
	public GameObject SfxRustle;

	// Token: 0x04000E63 RID: 3683
	[Token(Token = "0x4000E63")]
	[FieldOffset(Offset = "0x50")]
	public GameObject SfxWakeMusic;

	// Token: 0x04000E64 RID: 3684
	[Token(Token = "0x4000E64")]
	[FieldOffset(Offset = "0x58")]
	private bool sledIsPlaying;

	// Token: 0x04000E65 RID: 3685
	[Token(Token = "0x4000E65")]
	[FieldOffset(Offset = "0x59")]
	private bool sledOnTerrain;

	// Token: 0x04000E66 RID: 3686
	[Token(Token = "0x4000E66")]
	[FieldOffset(Offset = "0x5A")]
	private bool sledOnSnow;

	// Token: 0x04000E67 RID: 3687
	[Token(Token = "0x4000E67")]
	[FieldOffset(Offset = "0x60")]
	public string PlantRustleEvent;

	// Token: 0x04000E68 RID: 3688
	[Token(Token = "0x4000E68")]
	[FieldOffset(Offset = "0x68")]
	public string StructureBreakEvent;

	// Token: 0x04000E69 RID: 3689
	[Token(Token = "0x4000E69")]
	[FieldOffset(Offset = "0x70")]
	public string StructureFallEvent;

	// Token: 0x04000E6A RID: 3690
	[Token(Token = "0x4000E6A")]
	[FieldOffset(Offset = "0x78")]
	public string WhooshEvent;

	// Token: 0x04000E6B RID: 3691
	[Token(Token = "0x4000E6B")]
	[FieldOffset(Offset = "0x80")]
	public string PutDownEvent;

	// Token: 0x04000E6C RID: 3692
	[Token(Token = "0x4000E6C")]
	[FieldOffset(Offset = "0x88")]
	public string PlaceGhostEvent;

	// Token: 0x04000E6D RID: 3693
	[Token(Token = "0x4000E6D")]
	[FieldOffset(Offset = "0x90")]
	public string DrinkEvent;

	// Token: 0x04000E6E RID: 3694
	[Token(Token = "0x4000E6E")]
	[FieldOffset(Offset = "0x98")]
	public string DrinkFromWaterSourceEvent;

	// Token: 0x04000E6F RID: 3695
	[Token(Token = "0x4000E6F")]
	[FieldOffset(Offset = "0xA0")]
	public string HammerEvent;

	// Token: 0x04000E70 RID: 3696
	[Token(Token = "0x4000E70")]
	[FieldOffset(Offset = "0xA8")]
	public string HurtEvent;

	// Token: 0x04000E71 RID: 3697
	[Token(Token = "0x4000E71")]
	[FieldOffset(Offset = "0xB0")]
	public string BlockedHitEvent;

	// Token: 0x04000E72 RID: 3698
	[Token(Token = "0x4000E72")]
	[FieldOffset(Offset = "0xB8")]
	public string JumpEvent;

	// Token: 0x04000E73 RID: 3699
	[Token(Token = "0x4000E73")]
	[FieldOffset(Offset = "0xC0")]
	public string visWarningEvent;

	// Token: 0x04000E74 RID: 3700
	[Token(Token = "0x4000E74")]
	[FieldOffset(Offset = "0xC8")]
	public string MusicInjuredEvent;

	// Token: 0x04000E75 RID: 3701
	[Token(Token = "0x4000E75")]
	[FieldOffset(Offset = "0xD0")]
	public string TwinkleEvent;

	// Token: 0x04000E76 RID: 3702
	[Token(Token = "0x4000E76")]
	[FieldOffset(Offset = "0xD8")]
	public string RemovalEvent;

	// Token: 0x04000E77 RID: 3703
	[Token(Token = "0x4000E77")]
	[FieldOffset(Offset = "0xE0")]
	public string DigEvent;

	// Token: 0x04000E78 RID: 3704
	[Token(Token = "0x4000E78")]
	[FieldOffset(Offset = "0xE8")]
	public string BreakWoodEvent;

	// Token: 0x04000E79 RID: 3705
	[Token(Token = "0x4000E79")]
	[FieldOffset(Offset = "0xF0")]
	public string UpgradeSuccessEvent;

	// Token: 0x04000E7A RID: 3706
	[Token(Token = "0x4000E7A")]
	[FieldOffset(Offset = "0xF8")]
	public string TurtleShellSledLoopEvent;

	// Token: 0x04000E7B RID: 3707
	[Token(Token = "0x4000E7B")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	[EventRef]
	private string _swimEventPath;

	// Token: 0x04000E7C RID: 3708
	[Token(Token = "0x4000E7C")]
	[FieldOffset(Offset = "0x108")]
	private EventInstance ZiplineLoopInstance;

	// Token: 0x04000E7D RID: 3709
	[Token(Token = "0x4000E7D")]
	[FieldOffset(Offset = "0x110")]
	private EventInstance _sleddingLoopInstance;

	// Token: 0x04000E7E RID: 3710
	[Token(Token = "0x4000E7E")]
	[FieldOffset(Offset = "0x118")]
	private EventInstance visWarningInstance;

	// Token: 0x04000E7F RID: 3711
	[Token(Token = "0x4000E7F")]
	[FieldOffset(Offset = "0x120")]
	private EventInstance afterStormInstance;

	// Token: 0x04000E80 RID: 3712
	[Token(Token = "0x4000E80")]
	[FieldOffset(Offset = "0x128")]
	private EventInstance onOceanInstance;

	// Token: 0x04000E81 RID: 3713
	[Token(Token = "0x4000E81")]
	[FieldOffset(Offset = "0x130")]
	private EventInstance _swimEventInstance;

	// Token: 0x04000E82 RID: 3714
	[Token(Token = "0x4000E82")]
	[FieldOffset(Offset = "0x138")]
	private bool plantRustleEnabled;

	// Token: 0x04000E83 RID: 3715
	[Token(Token = "0x4000E83")]
	[FieldOffset(Offset = "0x139")]
	private bool jumpEnabled;

	// Token: 0x04000E84 RID: 3716
	[Token(Token = "0x4000E84")]
	[FieldOffset(Offset = "0x13C")]
	private Vector3 prevPosition;

	// Token: 0x04000E85 RID: 3717
	[Token(Token = "0x4000E85")]
	[FieldOffset(Offset = "0x148")]
	private float flatVelocity;

	// Token: 0x04000E86 RID: 3718
	[Token(Token = "0x4000E86")]
	[FieldOffset(Offset = "0x14C")]
	private bool immersed;

	// Token: 0x04000E87 RID: 3719
	[Token(Token = "0x4000E87")]
	[FieldOffset(Offset = "0x150")]
	private float remoteLoopLastUpdateTime;

	// Token: 0x04000E88 RID: 3720
	[Token(Token = "0x4000E88")]
	[FieldOffset(Offset = "0x158")]
	private string remoteLoopEvent;

	// Token: 0x04000E89 RID: 3721
	[Token(Token = "0x4000E89")]
	[FieldOffset(Offset = "0x160")]
	private EventInstance remoteLoopInstance;

	// Token: 0x04000E8A RID: 3722
	[Token(Token = "0x4000E8A")]
	[FieldOffset(Offset = "0x168")]
	private Vector3 remoteLoopVelocity;
}
