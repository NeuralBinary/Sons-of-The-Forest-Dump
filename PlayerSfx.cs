using System;
using System.Collections;
using System.Collections.Generic;
using Bolt;
using FMOD;
using FMOD.Studio;
using FMODUnity;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200022D RID: 557
[Token(Token = "0x200022D")]
public class PlayerSfx : EntityEventListener<IPlayerState>
{
	// Token: 0x06000F1F RID: 3871 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F1F")]
	[Address(RVA = "0x2FA0290", Offset = "0x2F9F290", VA = "0x182FA0290")]
	private IEnumerable<string> AllEventPaths()
	{
		return null;
	}

	// Token: 0x06000F20 RID: 3872 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F20")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void Awake()
	{
	}

	// Token: 0x06000F21 RID: 3873 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F21")]
	[Address(RVA = "0x2FA2190", Offset = "0x2FA1190", VA = "0x182FA2190")]
	private void Start()
	{
	}

	// Token: 0x06000F22 RID: 3874 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F22")]
	[Address(RVA = "0x2FA1F20", Offset = "0x2FA0F20", VA = "0x182FA1F20")]
	private static void Set3DAttributes(EventInstance evt, ATTRIBUTES_3D attributes)
	{
	}

	// Token: 0x06000F23 RID: 3875 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F23")]
	[Address(RVA = "0x2FA27E0", Offset = "0x2FA17E0", VA = "0x182FA27E0")]
	private void Update()
	{
	}

	// Token: 0x06000F24 RID: 3876 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F24")]
	[Address(RVA = "0x2FA08D0", Offset = "0x2F9F8D0", VA = "0x182FA08D0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000F25 RID: 3877 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F25")]
	[Address(RVA = "0x2FA0E70", Offset = "0x2F9FE70", VA = "0x182FA0E70")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06000F26 RID: 3878 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F26")]
	[Address(RVA = "0x2FA2650", Offset = "0x2FA1650", VA = "0x182FA2650")]
	public void TriggerSwimStroke()
	{
	}

	// Token: 0x06000F27 RID: 3879 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F27")]
	[Address(RVA = "0x2FA1A70", Offset = "0x2FA0A70", VA = "0x182FA1A70")]
	public void PlayStructureBreak(GameObject emiter, float size)
	{
	}

	// Token: 0x06000F28 RID: 3880 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F28")]
	[Address(RVA = "0x2FA1BF0", Offset = "0x2FA0BF0", VA = "0x182FA1BF0")]
	public void PlayStructureFall(GameObject emiter, float size)
	{
	}

	// Token: 0x06000F29 RID: 3881 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F29")]
	[Address(RVA = "0x2FA1E50", Offset = "0x2FA0E50", VA = "0x182FA1E50")]
	public void PlayWakeMusic()
	{
	}

	// Token: 0x06000F2A RID: 3882 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F2A")]
	[Address(RVA = "0x2FA17C0", Offset = "0x2FA07C0", VA = "0x182FA17C0")]
	public void PlayPlantRustle()
	{
	}

	// Token: 0x06000F2B RID: 3883 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F2B")]
	[Address(RVA = "0x2FA06E0", Offset = "0x2F9F6E0", VA = "0x182FA06E0")]
	private void EnablePlantRustle()
	{
	}

	// Token: 0x06000F2C RID: 3884 RVA: 0x00005AC0 File Offset: 0x00003CC0
	[Token(Token = "0x6000F2C")]
	[Address(RVA = "0x2FA15D0", Offset = "0x2FA05D0", VA = "0x182FA15D0")]
	public EventInstance PlayEvent(string path, GameObject gameObject)
	{
		return default(EventInstance);
	}

	// Token: 0x06000F2D RID: 3885 RVA: 0x00005AD8 File Offset: 0x00003CD8
	[Token(Token = "0x6000F2D")]
	[Address(RVA = "0x2FA1380", Offset = "0x2FA0380", VA = "0x182FA1380")]
	public EventInstance PlayEvent(string path, Vector3 position)
	{
		return default(EventInstance);
	}

	// Token: 0x06000F2E RID: 3886 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F2E")]
	[Address(RVA = "0x2FA1EB0", Offset = "0x2FA0EB0", VA = "0x182FA1EB0")]
	public void PlayWhoosh()
	{
	}

	// Token: 0x06000F2F RID: 3887 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F2F")]
	[Address(RVA = "0x2FA1E80", Offset = "0x2FA0E80", VA = "0x182FA1E80")]
	public void PlayWhoosh(Vector3 position)
	{
	}

	// Token: 0x06000F30 RID: 3888 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F30")]
	[Address(RVA = "0x2FA1D70", Offset = "0x2FA0D70", VA = "0x182FA1D70")]
	public void PlayTwinkle()
	{
	}

	// Token: 0x06000F31 RID: 3889 RVA: 0x00005AF0 File Offset: 0x00003CF0
	[Token(Token = "0x6000F31")]
	[Address(RVA = "0x2FA06F0", Offset = "0x2F9F6F0", VA = "0x182FA06F0")]
	private static Vector3 FindClosestPoint(GameObject gameObject, Vector3 position)
	{
		return default(Vector3);
	}

	// Token: 0x06000F32 RID: 3890 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F32")]
	[Address(RVA = "0x2FA1060", Offset = "0x2FA0060", VA = "0x182FA1060")]
	public void PlayBuildingComplete(GameObject building, bool networkSync = false)
	{
	}

	// Token: 0x06000F33 RID: 3891 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F33")]
	[Address(RVA = "0x2FA11A0", Offset = "0x2FA01A0", VA = "0x182FA11A0")]
	public void PlayBuildingRepair(GameObject building)
	{
	}

	// Token: 0x06000F34 RID: 3892 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F34")]
	[Address(RVA = "0x2FA1A00", Offset = "0x2FA0A00", VA = "0x182FA1A00")]
	public void PlayRemove()
	{
	}

	// Token: 0x06000F35 RID: 3893 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F35")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "178")]
	public override void OnEvent(SfxEat evnt)
	{
	}

	// Token: 0x06000F36 RID: 3894 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F36")]
	[Address(RVA = "0x2FA09B0", Offset = "0x2F9F9B0", VA = "0x182FA09B0", Slot = "179")]
	public override void OnEvent(SfxDrink evnt)
	{
	}

	// Token: 0x06000F37 RID: 3895 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F37")]
	[Address(RVA = "0x2FA09B0", Offset = "0x2F9F9B0", VA = "0x182FA09B0")]
	public void PlayDrink()
	{
	}

	// Token: 0x06000F38 RID: 3896 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F38")]
	[Address(RVA = "0x2FA1310", Offset = "0x2FA0310", VA = "0x182FA1310")]
	public void PlayDrinkFromWaterSource()
	{
	}

	// Token: 0x06000F39 RID: 3897 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F39")]
	[Address(RVA = "0x2FA1640", Offset = "0x2FA0640", VA = "0x182FA1640")]
	public void PlayHurtSound()
	{
	}

	// Token: 0x06000F3A RID: 3898 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F3A")]
	[Address(RVA = "0x2FA0F80", Offset = "0x2F9FF80", VA = "0x182FA0F80")]
	public void PlayBlockedSound()
	{
	}

	// Token: 0x06000F3B RID: 3899 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F3B")]
	[Address(RVA = "0x2FA1700", Offset = "0x2FA0700", VA = "0x182FA1700")]
	public void PlayJumpSound()
	{
	}

	// Token: 0x06000F3C RID: 3900 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F3C")]
	[Address(RVA = "0x2FA06D0", Offset = "0x2F9F6D0", VA = "0x182FA06D0")]
	private void EnableJump()
	{
	}

	// Token: 0x06000F3D RID: 3901 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F3D")]
	[Address(RVA = "0x2FA0940", Offset = "0x2F9F940", VA = "0x182FA0940", Slot = "177")]
	public override void OnEvent(SfxHammer evnt)
	{
	}

	// Token: 0x06000F3E RID: 3902 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F3E")]
	[Address(RVA = "0x2FA0940", Offset = "0x2F9F940", VA = "0x182FA0940")]
	public void PlayHammer()
	{
	}

	// Token: 0x06000F3F RID: 3903 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F3F")]
	[Address(RVA = "0x2FA2C60", Offset = "0x2FA1C60", VA = "0x182FA2C60")]
	public IEnumerator playVisWarning()
	{
		return null;
	}

	// Token: 0x06000F40 RID: 3904 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000F40")]
	[Address(RVA = "0x2FA2CD0", Offset = "0x2FA1CD0", VA = "0x182FA2CD0")]
	public IEnumerator stopVisWarning()
	{
		return null;
	}

	// Token: 0x06000F41 RID: 3905 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F41")]
	[Address(RVA = "0x2FA16B0", Offset = "0x2FA06B0", VA = "0x182FA16B0")]
	public void PlayInjured()
	{
	}

	// Token: 0x06000F42 RID: 3906 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F42")]
	[Address(RVA = "0x5F61F0", Offset = "0x5F51F0", VA = "0x1805F61F0")]
	public void StopPlaying()
	{
	}

	// Token: 0x06000F43 RID: 3907 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F43")]
	[Address(RVA = "0x2FA12A0", Offset = "0x2FA02A0", VA = "0x182FA12A0")]
	public void PlayDigDirtPile(GameObject dirtPile)
	{
	}

	// Token: 0x06000F44 RID: 3908 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F44")]
	[Address(RVA = "0x2FA0FF0", Offset = "0x2F9FFF0", VA = "0x182FA0FF0")]
	public void PlayBreakWood(GameObject wood)
	{
	}

	// Token: 0x06000F45 RID: 3909 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F45")]
	[Address(RVA = "0x2FA1DE0", Offset = "0x2FA0DE0", VA = "0x182FA1DE0")]
	public void PlayUpgradeSuccess(GameObject upgradeView)
	{
	}

	// Token: 0x06000F46 RID: 3910 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F46")]
	[Address(RVA = "0x2FA0EF0", Offset = "0x2F9FEF0", VA = "0x182FA0EF0")]
	public void PlayAfterStorm()
	{
	}

	// Token: 0x06000F47 RID: 3911 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F47")]
	[Address(RVA = "0x2FA1F80", Offset = "0x2FA0F80", VA = "0x182FA1F80")]
	public void SetSleddingLoop(bool onOff)
	{
	}

	// Token: 0x06000F48 RID: 3912 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F48")]
	[Address(RVA = "0x2FA04F0", Offset = "0x2F9F4F0", VA = "0x182FA04F0", Slot = "16")]
	public override void Attached()
	{
	}

	// Token: 0x06000F49 RID: 3913 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F49")]
	[Address(RVA = "0x2FA0A20", Offset = "0x2F9FA20", VA = "0x182FA0A20")]
	private void OnLoopingEventPathUpdate()
	{
	}

	// Token: 0x06000F4A RID: 3914 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F4A")]
	[Address(RVA = "0x2FA2470", Offset = "0x2FA1470", VA = "0x182FA2470")]
	private void SyncLoopingEvent(string path, Vector3 position)
	{
	}

	// Token: 0x06000F4B RID: 3915 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000F4B")]
	[Address(RVA = "0x2FA2C10", Offset = "0x2FA1C10", VA = "0x182FA2C10")]
	public PlayerSfx()
	{
	}

	// Token: 0x04000E28 RID: 3624
	[Token(Token = "0x4000E28")]
	[FieldOffset(Offset = "0x28")]
	private bool Playing;

	// Token: 0x04000E29 RID: 3625
	[Token(Token = "0x4000E29")]
	[FieldOffset(Offset = "0x29")]
	public bool Remote;

	// Token: 0x04000E2A RID: 3626
	[Token(Token = "0x4000E2A")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Rigidbody _rigidbody;

	// Token: 0x04000E2B RID: 3627
	[Token(Token = "0x4000E2B")]
	[FieldOffset(Offset = "0x38")]
	public GameObject SfxPlayer;

	// Token: 0x04000E2C RID: 3628
	[Token(Token = "0x4000E2C")]
	[FieldOffset(Offset = "0x40")]
	public GameObject SfxGUI;

	// Token: 0x04000E2D RID: 3629
	[Token(Token = "0x4000E2D")]
	[FieldOffset(Offset = "0x48")]
	public GameObject SfxRustle;

	// Token: 0x04000E2E RID: 3630
	[Token(Token = "0x4000E2E")]
	[FieldOffset(Offset = "0x50")]
	public GameObject SfxWakeMusic;

	// Token: 0x04000E2F RID: 3631
	[Token(Token = "0x4000E2F")]
	[FieldOffset(Offset = "0x58")]
	private bool sledIsPlaying;

	// Token: 0x04000E30 RID: 3632
	[Token(Token = "0x4000E30")]
	[FieldOffset(Offset = "0x59")]
	private bool sledOnTerrain;

	// Token: 0x04000E31 RID: 3633
	[Token(Token = "0x4000E31")]
	[FieldOffset(Offset = "0x5A")]
	private bool sledOnSnow;

	// Token: 0x04000E32 RID: 3634
	[Token(Token = "0x4000E32")]
	[FieldOffset(Offset = "0x60")]
	public string PlantRustleEvent;

	// Token: 0x04000E33 RID: 3635
	[Token(Token = "0x4000E33")]
	[FieldOffset(Offset = "0x68")]
	public string StructureBreakEvent;

	// Token: 0x04000E34 RID: 3636
	[Token(Token = "0x4000E34")]
	[FieldOffset(Offset = "0x70")]
	public string StructureFallEvent;

	// Token: 0x04000E35 RID: 3637
	[Token(Token = "0x4000E35")]
	[FieldOffset(Offset = "0x78")]
	public string WhooshEvent;

	// Token: 0x04000E36 RID: 3638
	[Token(Token = "0x4000E36")]
	[FieldOffset(Offset = "0x80")]
	public string PutDownEvent;

	// Token: 0x04000E37 RID: 3639
	[Token(Token = "0x4000E37")]
	[FieldOffset(Offset = "0x88")]
	public string PlaceGhostEvent;

	// Token: 0x04000E38 RID: 3640
	[Token(Token = "0x4000E38")]
	[FieldOffset(Offset = "0x90")]
	public string DrinkEvent;

	// Token: 0x04000E39 RID: 3641
	[Token(Token = "0x4000E39")]
	[FieldOffset(Offset = "0x98")]
	public string DrinkFromWaterSourceEvent;

	// Token: 0x04000E3A RID: 3642
	[Token(Token = "0x4000E3A")]
	[FieldOffset(Offset = "0xA0")]
	public string HammerEvent;

	// Token: 0x04000E3B RID: 3643
	[Token(Token = "0x4000E3B")]
	[FieldOffset(Offset = "0xA8")]
	public string HurtEvent;

	// Token: 0x04000E3C RID: 3644
	[Token(Token = "0x4000E3C")]
	[FieldOffset(Offset = "0xB0")]
	public string BlockedHitEvent;

	// Token: 0x04000E3D RID: 3645
	[Token(Token = "0x4000E3D")]
	[FieldOffset(Offset = "0xB8")]
	public string JumpEvent;

	// Token: 0x04000E3E RID: 3646
	[Token(Token = "0x4000E3E")]
	[FieldOffset(Offset = "0xC0")]
	public string visWarningEvent;

	// Token: 0x04000E3F RID: 3647
	[Token(Token = "0x4000E3F")]
	[FieldOffset(Offset = "0xC8")]
	public string MusicInjuredEvent;

	// Token: 0x04000E40 RID: 3648
	[Token(Token = "0x4000E40")]
	[FieldOffset(Offset = "0xD0")]
	public string TwinkleEvent;

	// Token: 0x04000E41 RID: 3649
	[Token(Token = "0x4000E41")]
	[FieldOffset(Offset = "0xD8")]
	public string RemovalEvent;

	// Token: 0x04000E42 RID: 3650
	[Token(Token = "0x4000E42")]
	[FieldOffset(Offset = "0xE0")]
	public string DigEvent;

	// Token: 0x04000E43 RID: 3651
	[Token(Token = "0x4000E43")]
	[FieldOffset(Offset = "0xE8")]
	public string BreakWoodEvent;

	// Token: 0x04000E44 RID: 3652
	[Token(Token = "0x4000E44")]
	[FieldOffset(Offset = "0xF0")]
	public string UpgradeSuccessEvent;

	// Token: 0x04000E45 RID: 3653
	[Token(Token = "0x4000E45")]
	[FieldOffset(Offset = "0xF8")]
	public string TurtleShellSledLoopEvent;

	// Token: 0x04000E46 RID: 3654
	[Token(Token = "0x4000E46")]
	[FieldOffset(Offset = "0x100")]
	[SerializeField]
	[EventRef]
	private string _swimEventPath;

	// Token: 0x04000E47 RID: 3655
	[Token(Token = "0x4000E47")]
	[FieldOffset(Offset = "0x108")]
	private EventInstance ZiplineLoopInstance;

	// Token: 0x04000E48 RID: 3656
	[Token(Token = "0x4000E48")]
	[FieldOffset(Offset = "0x110")]
	private EventInstance _sleddingLoopInstance;

	// Token: 0x04000E49 RID: 3657
	[Token(Token = "0x4000E49")]
	[FieldOffset(Offset = "0x118")]
	private EventInstance visWarningInstance;

	// Token: 0x04000E4A RID: 3658
	[Token(Token = "0x4000E4A")]
	[FieldOffset(Offset = "0x120")]
	private EventInstance afterStormInstance;

	// Token: 0x04000E4B RID: 3659
	[Token(Token = "0x4000E4B")]
	[FieldOffset(Offset = "0x128")]
	private EventInstance onOceanInstance;

	// Token: 0x04000E4C RID: 3660
	[Token(Token = "0x4000E4C")]
	[FieldOffset(Offset = "0x130")]
	private EventInstance _swimEventInstance;

	// Token: 0x04000E4D RID: 3661
	[Token(Token = "0x4000E4D")]
	[FieldOffset(Offset = "0x138")]
	private bool plantRustleEnabled;

	// Token: 0x04000E4E RID: 3662
	[Token(Token = "0x4000E4E")]
	[FieldOffset(Offset = "0x139")]
	private bool jumpEnabled;

	// Token: 0x04000E4F RID: 3663
	[Token(Token = "0x4000E4F")]
	[FieldOffset(Offset = "0x13C")]
	private Vector3 prevPosition;

	// Token: 0x04000E50 RID: 3664
	[Token(Token = "0x4000E50")]
	[FieldOffset(Offset = "0x148")]
	private float flatVelocity;

	// Token: 0x04000E51 RID: 3665
	[Token(Token = "0x4000E51")]
	[FieldOffset(Offset = "0x14C")]
	private bool immersed;

	// Token: 0x04000E52 RID: 3666
	[Token(Token = "0x4000E52")]
	[FieldOffset(Offset = "0x150")]
	private float remoteLoopLastUpdateTime;

	// Token: 0x04000E53 RID: 3667
	[Token(Token = "0x4000E53")]
	[FieldOffset(Offset = "0x158")]
	private string remoteLoopEvent;

	// Token: 0x04000E54 RID: 3668
	[Token(Token = "0x4000E54")]
	[FieldOffset(Offset = "0x160")]
	private EventInstance remoteLoopInstance;

	// Token: 0x04000E55 RID: 3669
	[Token(Token = "0x4000E55")]
	[FieldOffset(Offset = "0x168")]
	private Vector3 remoteLoopVelocity;
}
