using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Bolt;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.Items.Core;
using Sons.Physics;
using Sons.Weapon;
using TheForest.Items.Inventory;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

// Token: 0x02000185 RID: 389
[Token(Token = "0x2000185")]
public class weaponInfo : EntityEventListener, IImpactSender
{
	// Token: 0x17000172 RID: 370
	// (get) Token: 0x06000BBC RID: 3004 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000172")]
	public Collider[] WeaponColliders
	{
		[Token(Token = "0x6000BBC")]
		[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000173 RID: 371
	// (get) Token: 0x06000BBD RID: 3005 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000173")]
	public Collider[] LowWeaponColliders
	{
		[Token(Token = "0x6000BBD")]
		[Address(RVA = "0x620F10", Offset = "0x61F510", VA = "0x180620F10")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000174 RID: 372
	// (get) Token: 0x06000BBE RID: 3006 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000174")]
	public MeleeWeaponData MeleeWeaponData
	{
		[Token(Token = "0x6000BBE")]
		[Address(RVA = "0x36D8680", Offset = "0x36D6C80", VA = "0x1836D8680")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000BBF RID: 3007 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BBF")]
	[Address(RVA = "0x36D8690", Offset = "0x36D6C90", VA = "0x1836D8690")]
	private void PlayEvent(string path, [Optional] Transform t)
	{
	}

	// Token: 0x06000BC0 RID: 3008 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC0")]
	[Address(RVA = "0x36D88C0", Offset = "0x36D6EC0", VA = "0x1836D88C0")]
	private void OnValidate()
	{
	}

	// Token: 0x06000BC1 RID: 3009 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC1")]
	[Address(RVA = "0x36D8960", Offset = "0x36D6F60", VA = "0x1836D8960")]
	private void Awake()
	{
	}

	// Token: 0x06000BC2 RID: 3010 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BC2")]
	[Address(RVA = "0x36D8C70", Offset = "0x36D7270", VA = "0x1836D8C70")]
	private IEnumerator DelayedAwake()
	{
		return null;
	}

	// Token: 0x06000BC3 RID: 3011 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC3")]
	[Address(RVA = "0x36D8D00", Offset = "0x36D7300", VA = "0x1836D8D00")]
	private void Start()
	{
	}

	// Token: 0x06000BC4 RID: 3012 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC4")]
	[Address(RVA = "0x36D92A0", Offset = "0x36D78A0", VA = "0x1836D92A0")]
	private void Update()
	{
	}

	// Token: 0x06000BC5 RID: 3013 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC5")]
	[Address(RVA = "0x36D92F0", Offset = "0x36D78F0", VA = "0x1836D92F0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000BC6 RID: 3014 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC6")]
	[Address(RVA = "0x36D9570", Offset = "0x36D7B70", VA = "0x1836D9570")]
	private void UpdateVelocity(Vector3 frameVelocity)
	{
	}

	// Token: 0x06000BC7 RID: 3015 RVA: 0x00004EA8 File Offset: 0x000030A8
	[Token(Token = "0x6000BC7")]
	[Address(RVA = "0x36D98E0", Offset = "0x36D7EE0", VA = "0x1836D98E0")]
	private Vector3 GetWeaponImpactPosition()
	{
		return default(Vector3);
	}

	// Token: 0x06000BC8 RID: 3016 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BC8")]
	[Address(RVA = "0x36D9AC0", Offset = "0x36D80C0", VA = "0x1836D9AC0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06000BC9 RID: 3017 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BC9")]
	[Address(RVA = "0x2DBF050", Offset = "0x2DBD650", VA = "0x182DBF050", Slot = "325")]
	public Transform GetRootTransform()
	{
		return null;
	}

	// Token: 0x06000BCA RID: 3018 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BCA")]
	[Address(RVA = "0x36DA320", Offset = "0x36D8920", VA = "0x1836DA320", Slot = "326")]
	private MonoBehaviour GetSourceStimuli()
	{
		return null;
	}

	// Token: 0x06000BCB RID: 3019 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BCB")]
	[Address(RVA = "0x36DA3F0", Offset = "0x36D89F0", VA = "0x1836DA3F0")]
	private void CheckStructureImpact(Collider other)
	{
	}

	// Token: 0x06000BCC RID: 3020 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BCC")]
	[Address(RVA = "0x36DA500", Offset = "0x36D8B00", VA = "0x1836DA500")]
	private void CheckTreeImpact(Collider other)
	{
	}

	// Token: 0x06000BCD RID: 3021 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BCD")]
	[Address(RVA = "0x36DA910", Offset = "0x36D8F10", VA = "0x1836DA910")]
	private void WeaponNoiseEvent(VailAudioManager.Noise noise = VailAudioManager.Noise.Medium)
	{
	}

	// Token: 0x06000BCE RID: 3022 RVA: 0x00004EC0 File Offset: 0x000030C0
	[Token(Token = "0x6000BCE")]
	[Address(RVA = "0x36DAAF0", Offset = "0x36D90F0", VA = "0x1836DAAF0")]
	private bool HandleSpearingFish(Collider other)
	{
		return default(bool);
	}

	// Token: 0x06000BCF RID: 3023 RVA: 0x00004ED8 File Offset: 0x000030D8
	[Token(Token = "0x6000BCF")]
	[Address(RVA = "0x36DB3D0", Offset = "0x36D99D0", VA = "0x1836DB3D0")]
	private static bool GetInvalidAttackAngle(Collider other)
	{
		return default(bool);
	}

	// Token: 0x06000BD0 RID: 3024 RVA: 0x00004EF0 File Offset: 0x000030F0
	[Token(Token = "0x6000BD0")]
	[Address(RVA = "0x36DB690", Offset = "0x36D9C90", VA = "0x1836DB690")]
	private bool PlaySurfaceHitAudio(Collider other)
	{
		return default(bool);
	}

	// Token: 0x17000175 RID: 373
	// (get) Token: 0x06000BD1 RID: 3025 RVA: 0x00004F08 File Offset: 0x00003108
	[Token(Token = "0x17000175")]
	private bool SurfaceHitOnCooldown
	{
		[Token(Token = "0x6000BD1")]
		[Address(RVA = "0x36DBA30", Offset = "0x36DA030", VA = "0x1836DBA30")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000BD2 RID: 3026 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BD2")]
	[Address(RVA = "0x36DBAA0", Offset = "0x36DA0A0", VA = "0x1836DBAA0")]
	private void PlaySurfaceHitAudio(string path)
	{
	}

	// Token: 0x06000BD3 RID: 3027 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BD3")]
	[Address(RVA = "0x36DBBC0", Offset = "0x36DA1C0", VA = "0x1836DBBC0")]
	private void OnEnable()
	{
	}

	// Token: 0x06000BD4 RID: 3028 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BD4")]
	[Address(RVA = "0x36DBE40", Offset = "0x36DA440", VA = "0x1836DBE40")]
	private void SetupHeldWeapon()
	{
	}

	// Token: 0x06000BD5 RID: 3029 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BD5")]
	[Address(RVA = "0x36DBEA0", Offset = "0x36DA4A0", VA = "0x1836DBEA0")]
	private void OnDisable()
	{
	}

	// Token: 0x06000BD6 RID: 3030 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BD6")]
	[Address(RVA = "0x36DC130", Offset = "0x36DA730", VA = "0x1836DC130")]
	public void CleanUpSpearedFish()
	{
	}

	// Token: 0x06000BD7 RID: 3031 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BD7")]
	[Address(RVA = "0x36DC770", Offset = "0x36DAD70", VA = "0x1836DC770")]
	private void DoImpact(Collider other)
	{
	}

	// Token: 0x06000BD8 RID: 3032 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BD8")]
	[Address(RVA = "0x36DC880", Offset = "0x36DAE80", VA = "0x1836DC880")]
	private void InitializeMeleeImpactData()
	{
	}

	// Token: 0x06000BD9 RID: 3033 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BD9")]
	[Address(RVA = "0x36DCAF0", Offset = "0x36DB0F0", VA = "0x1836DCAF0")]
	public void OnNewMeleeAttack()
	{
	}

	// Token: 0x06000BDA RID: 3034 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BDA")]
	[Address(RVA = "0x36DCB10", Offset = "0x36DB110", VA = "0x1836DCB10")]
	public void SetMeleeSwingType(weaponInfo.SwingType type)
	{
	}

	// Token: 0x06000BDB RID: 3035 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BDB")]
	[Address(RVA = "0x36DCB20", Offset = "0x36DB120", VA = "0x1836DCB20")]
	public void SetImpactAudioMaterial(AudioImpactMaterial audioMaterial)
	{
	}

	// Token: 0x06000BDC RID: 3036 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BDC")]
	[Address(RVA = "0x36DCB30", Offset = "0x36DB130", VA = "0x1836DCB30")]
	public void SetApplyStatusEffects(bool value)
	{
	}

	// Token: 0x06000BDD RID: 3037 RVA: 0x00004F20 File Offset: 0x00003120
	[Token(Token = "0x6000BDD")]
	[Address(RVA = "0x36DCB40", Offset = "0x36DB140", VA = "0x1836DCB40")]
	private Vector3 GetImpactEffectVelocity()
	{
		return default(Vector3);
	}

	// Token: 0x06000BDE RID: 3038 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000BDE")]
	[Address(RVA = "0x36DCCC0", Offset = "0x36DB2C0", VA = "0x1836DCCC0")]
	private MeleeImpactData GetMeleeImpactData(Component other)
	{
		return null;
	}

	// Token: 0x06000BDF RID: 3039 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BDF")]
	[Address(RVA = "0x36DCEF0", Offset = "0x36DB4F0", VA = "0x1836DCEF0", Slot = "322")]
	private void OnDamageSuccess(DamageNode damageNode, IImpactData impactData)
	{
	}

	// Token: 0x06000BE0 RID: 3040 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BE0")]
	[Address(RVA = "0x36DD010", Offset = "0x36DB610", VA = "0x1836DD010")]
	private void PlayArmourHitAudio(DamageNode damageNode)
	{
	}

	// Token: 0x06000BE1 RID: 3041 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BE1")]
	[Address(RVA = "0x36DD210", Offset = "0x36DB810", VA = "0x1836DD210")]
	private void PlayHitFleshAudio()
	{
	}

	// Token: 0x06000BE2 RID: 3042 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BE2")]
	[Address(RVA = "0x36DD460", Offset = "0x36DBA60", VA = "0x1836DD460", Slot = "324")]
	private void OnAttackBlocked(DamageNode damageNode, IImpactData impactData)
	{
	}

	// Token: 0x06000BE3 RID: 3043 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BE3")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "323")]
	private void OnAttackParried(DamageNode damageNode, IImpactData impactData)
	{
	}

	// Token: 0x06000BE4 RID: 3044 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BE4")]
	[Address(RVA = "0x36DD4D0", Offset = "0x36DBAD0", VA = "0x1836DD4D0")]
	private void PlayWaterImpact(Collider other)
	{
	}

	// Token: 0x06000BE5 RID: 3045 RVA: 0x00004F38 File Offset: 0x00003138
	[Token(Token = "0x6000BE5")]
	[Address(RVA = "0x36DD9D0", Offset = "0x36DBFD0", VA = "0x1836DD9D0")]
	private bool PlaySurfaceImpactEffect(Collider other)
	{
		return default(bool);
	}

	// Token: 0x06000BE6 RID: 3046 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000BE6")]
	[Address(RVA = "0x36DDF30", Offset = "0x36DC530", VA = "0x1836DDF30")]
	public weaponInfo()
	{
	}

	// Token: 0x04000A54 RID: 2644
	[Token(Token = "0x4000A54")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[ItemIdPicker(true)]
	public int _itemID;

	// Token: 0x04000A55 RID: 2645
	[Token(Token = "0x4000A55")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private ItemData _itemData;

	// Token: 0x04000A56 RID: 2646
	[Token(Token = "0x4000A56")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public PlayerInventory PlayerInv;

	// Token: 0x04000A57 RID: 2647
	[Token(Token = "0x4000A57")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Animator animator;

	// Token: 0x04000A58 RID: 2648
	[Token(Token = "0x4000A58")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public playerScriptSetup setup;

	// Token: 0x04000A59 RID: 2649
	[Token(Token = "0x4000A59")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[HideInInspector]
	public weaponInfo currentWeaponScript;

	// Token: 0x04000A5A RID: 2650
	[Token(Token = "0x4000A5A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Collider[] _weaponColliders;

	// Token: 0x04000A5B RID: 2651
	[Token(Token = "0x4000A5B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Collider[] _lowWeaponColliders;

	// Token: 0x04000A5C RID: 2652
	[Token(Token = "0x4000A5C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private List<TriggerProxy> _triggerProxies;

	// Token: 0x04000A5D RID: 2653
	[Token(Token = "0x4000A5D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public animEventsManager animEvents;

	// Token: 0x04000A5E RID: 2654
	[Token(Token = "0x4000A5E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public bool noTreeCut;

	// Token: 0x04000A5F RID: 2655
	[Token(Token = "0x4000A5F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
	public bool stick;

	// Token: 0x04000A60 RID: 2656
	[Token(Token = "0x4000A60")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7A")]
	[FormerlySerializedAs("spear")]
	[SerializeField]
	private bool _isSpear;

	// Token: 0x04000A61 RID: 2657
	[Token(Token = "0x4000A61")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[EventRef]
	public string treeHitEvent;

	// Token: 0x04000A62 RID: 2658
	[Token(Token = "0x4000A62")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[EventRef]
	public string fleshHitEvent;

	// Token: 0x04000A63 RID: 2659
	[Token(Token = "0x4000A63")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[EventRef]
	public string fleshHitEventGround;

	// Token: 0x04000A64 RID: 2660
	[Token(Token = "0x4000A64")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[EventRef]
	public string fleshHitStatusEffectEvent;

	// Token: 0x04000A65 RID: 2661
	[Token(Token = "0x4000A65")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public bool fleshHitStatusEventExclusive;

	// Token: 0x04000A66 RID: 2662
	[Token(Token = "0x4000A66")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[EventRef]
	public string shellHitEvent;

	// Token: 0x04000A67 RID: 2663
	[Token(Token = "0x4000A67")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[EventRef]
	public string planeHitEvent;

	// Token: 0x04000A68 RID: 2664
	[Token(Token = "0x4000A68")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[EventRef]
	public string ropeHitEvent;

	// Token: 0x04000A69 RID: 2665
	[Token(Token = "0x4000A69")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[EventRef]
	public string dirtHitEvent;

	// Token: 0x04000A6A RID: 2666
	[Token(Token = "0x4000A6A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[EventRef]
	public string rockHitEvent;

	// Token: 0x04000A6B RID: 2667
	[Token(Token = "0x4000A6B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[FormerlySerializedAs("waterHitEvent")]
	[EventRef]
	public string _waterHitAudioEvent;

	// Token: 0x04000A6C RID: 2668
	[Token(Token = "0x4000A6C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[EventRef]
	public string tentHitEvent;

	// Token: 0x04000A6D RID: 2669
	[Token(Token = "0x4000A6D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[EventRef]
	public string _plasticHitEvent;

	// Token: 0x04000A6E RID: 2670
	[Token(Token = "0x4000A6E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	[EventRef]
	public string _swingEvent;

	// Token: 0x04000A6F RID: 2671
	[Token(Token = "0x4000A6F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	[Header("")]
	public bool remotePlayer;

	// Token: 0x04000A70 RID: 2672
	[Token(Token = "0x4000A70")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	[FormerlySerializedAs("weaponDamage")]
	[SerializeField]
	private float _weaponDamage;

	// Token: 0x04000A71 RID: 2673
	[Token(Token = "0x4000A71")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private bool activeBool;

	// Token: 0x04000A72 RID: 2674
	[Token(Token = "0x4000A72")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly List<GameObject> _spearedFish;

	// Token: 0x04000A73 RID: 2675
	[Token(Token = "0x4000A73")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private bool _debugDrawPositions;

	// Token: 0x04000A74 RID: 2676
	[Token(Token = "0x4000A74")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x109")]
	private bool _debugDrawVelocity;

	// Token: 0x04000A75 RID: 2677
	[Token(Token = "0x4000A75")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	private float _debugDrawVelocityScale;

	// Token: 0x04000A76 RID: 2678
	[Token(Token = "0x4000A76")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private Transform _spearTip;

	// Token: 0x04000A77 RID: 2679
	[Token(Token = "0x4000A77")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private float _lastSplashTime;

	// Token: 0x04000A78 RID: 2680
	[Token(Token = "0x4000A78")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	private float _lastImpactTime;

	// Token: 0x04000A79 RID: 2681
	[Token(Token = "0x4000A79")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private float _lastSurfaceHitTime;

	// Token: 0x04000A7A RID: 2682
	[Token(Token = "0x4000A7A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	private float _lastNoiseEventTime;

	// Token: 0x04000A7B RID: 2683
	[Token(Token = "0x4000A7B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private float _lastHitFleshTime;

	// Token: 0x04000A7C RID: 2684
	[Token(Token = "0x4000A7C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	private float _lastHitArmourTime;

	// Token: 0x04000A7D RID: 2685
	[Token(Token = "0x4000A7D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private VailAudioManager.Noise _lastNoise;

	// Token: 0x04000A7E RID: 2686
	[Token(Token = "0x4000A7E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	private Vector3 _lastPosition;

	// Token: 0x04000A7F RID: 2687
	[Token(Token = "0x4000A7F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private Vector3 _lastPosition2;

	// Token: 0x04000A80 RID: 2688
	[Token(Token = "0x4000A80")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
	private Vector3 _velocity;

	// Token: 0x04000A81 RID: 2689
	[Token(Token = "0x4000A81")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private Vector3 _lastWeaponImpactPosition;

	// Token: 0x04000A82 RID: 2690
	[Token(Token = "0x4000A82")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
	[SerializeField]
	private ImpactMeleeType _impactMeleeType;

	// Token: 0x04000A83 RID: 2691
	[Token(Token = "0x4000A83")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	[SerializeField]
	private float _impactEffectVelocityMultiplier;

	// Token: 0x04000A84 RID: 2692
	[Token(Token = "0x4000A84")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	[SerializeField]
	private Transform _weaponImpactTransform;

	// Token: 0x04000A85 RID: 2693
	[Token(Token = "0x4000A85")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private MeleeImpactData _cachedMeleeImpactData;

	// Token: 0x04000A86 RID: 2694
	[Token(Token = "0x4000A86")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private MeleeWeaponData _meleeWeaponData;

	// Token: 0x04000A87 RID: 2695
	[Token(Token = "0x4000A87")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private AudioImpactMaterial _impactAudioMaterial;

	// Token: 0x04000A88 RID: 2696
	[Token(Token = "0x4000A88")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
	private bool _applyStatusEffects;

	// Token: 0x04000A89 RID: 2697
	[Token(Token = "0x4000A89")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	[HideInInspector]
	public UnityEvent<DamageNode, IImpactData> OnDamageSuccessCallback;

	// Token: 0x04000A8A RID: 2698
	[Token(Token = "0x4000A8A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	[HideInInspector]
	public UnityEvent<DamageNode, IImpactData> OnBlockedCallback;

	// Token: 0x04000A8B RID: 2699
	[Token(Token = "0x4000A8B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private weaponInfo.SwingType _swingType;

	// Token: 0x02000186 RID: 390
	[Token(Token = "0x2000186")]
	public enum SwingType
	{
		// Token: 0x04000A8D RID: 2701
		[Token(Token = "0x4000A8D")]
		NormalAttack,
		// Token: 0x04000A8E RID: 2702
		[Token(Token = "0x4000A8E")]
		GroundAttack,
		// Token: 0x04000A8F RID: 2703
		[Token(Token = "0x4000A8F")]
		TreeAttack,
		// Token: 0x04000A90 RID: 2704
		[Token(Token = "0x4000A90")]
		ComboEnder,
		// Token: 0x04000A91 RID: 2705
		[Token(Token = "0x4000A91")]
		ChargeAttack
	}
}
