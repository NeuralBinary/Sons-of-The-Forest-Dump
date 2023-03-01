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

// Token: 0x02000186 RID: 390
[Token(Token = "0x2000186")]
public class weaponInfo : EntityEventListener, IImpactSender
{
	// Token: 0x17000169 RID: 361
	// (get) Token: 0x06000B63 RID: 2915 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000169")]
	public Collider[] WeaponColliders
	{
		[Token(Token = "0x6000B63")]
		[Address(RVA = "0x5E9600", Offset = "0x5E8600", VA = "0x1805E9600")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700016A RID: 362
	// (get) Token: 0x06000B64 RID: 2916 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700016A")]
	public Collider[] LowWeaponColliders
	{
		[Token(Token = "0x6000B64")]
		[Address(RVA = "0x5A2410", Offset = "0x5A1410", VA = "0x1805A2410")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700016B RID: 363
	// (get) Token: 0x06000B65 RID: 2917 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700016B")]
	public MeleeWeaponData MeleeWeaponData
	{
		[Token(Token = "0x6000B65")]
		[Address(RVA = "0x2F7CA00", Offset = "0x2F7BA00", VA = "0x182F7CA00")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000B66 RID: 2918 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B66")]
	[Address(RVA = "0x2F7B5C0", Offset = "0x2F7A5C0", VA = "0x182F7B5C0")]
	private void PlayEvent(string path, [Optional] Transform t)
	{
	}

	// Token: 0x06000B67 RID: 2919 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B67")]
	[Address(RVA = "0x2F7B550", Offset = "0x2F7A550", VA = "0x182F7B550")]
	private void OnValidate()
	{
	}

	// Token: 0x06000B68 RID: 2920 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B68")]
	[Address(RVA = "0x2F79380", Offset = "0x2F78380", VA = "0x182F79380")]
	private void Awake()
	{
	}

	// Token: 0x06000B69 RID: 2921 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B69")]
	[Address(RVA = "0x2F79B60", Offset = "0x2F78B60", VA = "0x182F79B60")]
	private IEnumerator DelayedAwake()
	{
		return null;
	}

	// Token: 0x06000B6A RID: 2922 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B6A")]
	[Address(RVA = "0x2F7C2B0", Offset = "0x2F7B2B0", VA = "0x182F7C2B0")]
	private void Start()
	{
	}

	// Token: 0x06000B6B RID: 2923 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B6B")]
	[Address(RVA = "0x2F7C780", Offset = "0x2F7B780", VA = "0x182F7C780")]
	private void Update()
	{
	}

	// Token: 0x06000B6C RID: 2924 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B6C")]
	[Address(RVA = "0x2F7AAD0", Offset = "0x2F79AD0", VA = "0x182F7AAD0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000B6D RID: 2925 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B6D")]
	[Address(RVA = "0x2F7C4E0", Offset = "0x2F7B4E0", VA = "0x182F7C4E0")]
	private void UpdateVelocity(Vector3 frameVelocity)
	{
	}

	// Token: 0x06000B6E RID: 2926 RVA: 0x00004C80 File Offset: 0x00002E80
	[Token(Token = "0x6000B6E")]
	[Address(RVA = "0x2F7A1D0", Offset = "0x2F791D0", VA = "0x182F7A1D0")]
	private Vector3 GetWeaponImpactPosition()
	{
		return default(Vector3);
	}

	// Token: 0x06000B6F RID: 2927 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B6F")]
	[Address(RVA = "0x2F7B050", Offset = "0x2F7A050", VA = "0x182F7B050")]
	private void OnTriggerEnter(Collider other)
	{
	}

	// Token: 0x06000B70 RID: 2928 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B70")]
	[Address(RVA = "0x286CA80", Offset = "0x286BA80", VA = "0x18286CA80", Slot = "299")]
	public Transform GetRootTransform()
	{
		return null;
	}

	// Token: 0x06000B71 RID: 2929 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B71")]
	[Address(RVA = "0x2F7A640", Offset = "0x2F79640", VA = "0x182F7A640", Slot = "300")]
	private MonoBehaviour GetSourceStimuli()
	{
		return null;
	}

	// Token: 0x06000B72 RID: 2930 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B72")]
	[Address(RVA = "0x2F79510", Offset = "0x2F78510", VA = "0x182F79510")]
	private void CheckStructureImpact(Collider other)
	{
	}

	// Token: 0x06000B73 RID: 2931 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B73")]
	[Address(RVA = "0x2F795C0", Offset = "0x2F785C0", VA = "0x182F795C0")]
	private void CheckTreeImpact(Collider other)
	{
	}

	// Token: 0x06000B74 RID: 2932 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B74")]
	[Address(RVA = "0x2F7C7D0", Offset = "0x2F7B7D0", VA = "0x182F7C7D0")]
	private void WeaponNoiseEvent(VailAudioManager.Noise noise = 1)
	{
	}

	// Token: 0x06000B75 RID: 2933 RVA: 0x00004C98 File Offset: 0x00002E98
	[Token(Token = "0x6000B75")]
	[Address(RVA = "0x2F7A290", Offset = "0x2F79290", VA = "0x182F7A290")]
	private bool HandleSpearingFish(Collider other)
	{
		return default(bool);
	}

	// Token: 0x06000B76 RID: 2934 RVA: 0x00004CB0 File Offset: 0x00002EB0
	[Token(Token = "0x6000B76")]
	[Address(RVA = "0x2F79DB0", Offset = "0x2F78DB0", VA = "0x182F79DB0")]
	private static bool GetInvalidAttackAngle(Collider other)
	{
		return default(bool);
	}

	// Token: 0x06000B77 RID: 2935 RVA: 0x00004CC8 File Offset: 0x00002EC8
	[Token(Token = "0x6000B77")]
	[Address(RVA = "0x2F7B860", Offset = "0x2F7A860", VA = "0x182F7B860")]
	private bool PlaySurfaceHitAudio(Collider other)
	{
		return default(bool);
	}

	// Token: 0x1700016C RID: 364
	// (get) Token: 0x06000B78 RID: 2936 RVA: 0x00004CE0 File Offset: 0x00002EE0
	[Token(Token = "0x1700016C")]
	private bool SurfaceHitOnCooldown
	{
		[Token(Token = "0x6000B78")]
		[Address(RVA = "0x2F7CA10", Offset = "0x2F7BA10", VA = "0x182F7CA10")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000B79 RID: 2937 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B79")]
	[Address(RVA = "0x2F7BB20", Offset = "0x2F7AB20", VA = "0x182F7BB20")]
	private void PlaySurfaceHitAudio(string path)
	{
	}

	// Token: 0x06000B7A RID: 2938 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B7A")]
	[Address(RVA = "0x2F7AE40", Offset = "0x2F79E40", VA = "0x182F7AE40")]
	private void OnEnable()
	{
	}

	// Token: 0x06000B7B RID: 2939 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B7B")]
	[Address(RVA = "0x2F7C250", Offset = "0x2F7B250", VA = "0x182F7C250")]
	private void SetupHeldWeapon()
	{
	}

	// Token: 0x06000B7C RID: 2940 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B7C")]
	[Address(RVA = "0x2F7AC80", Offset = "0x2F79C80", VA = "0x182F7AC80")]
	private void OnDisable()
	{
	}

	// Token: 0x06000B7D RID: 2941 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B7D")]
	[Address(RVA = "0x2F79850", Offset = "0x2F78850", VA = "0x182F79850")]
	private void CleanUpSpearedFish()
	{
	}

	// Token: 0x06000B7E RID: 2942 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B7E")]
	[Address(RVA = "0x2F79BD0", Offset = "0x2F78BD0", VA = "0x182F79BD0")]
	private void DoImpact(Collider other)
	{
	}

	// Token: 0x06000B7F RID: 2943 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B7F")]
	[Address(RVA = "0x2F7A8A0", Offset = "0x2F798A0", VA = "0x182F7A8A0")]
	private void InitializeMeleeImpactData()
	{
	}

	// Token: 0x06000B80 RID: 2944 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B80")]
	[Address(RVA = "0x2F7B030", Offset = "0x2F7A030", VA = "0x182F7B030")]
	public void OnNewMeleeAttack()
	{
	}

	// Token: 0x06000B81 RID: 2945 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B81")]
	[Address(RVA = "0x23E16A0", Offset = "0x23E06A0", VA = "0x1823E16A0")]
	public void SetMeleeSwingType(weaponInfo.SwingType type)
	{
	}

	// Token: 0x06000B82 RID: 2946 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B82")]
	[Address(RVA = "0x2F7C240", Offset = "0x2F7B240", VA = "0x182F7C240")]
	public void SetImpactAudioMaterial(AudioImpactMaterial audioMaterial)
	{
	}

	// Token: 0x06000B83 RID: 2947 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B83")]
	[Address(RVA = "0x2F7C230", Offset = "0x2F7B230", VA = "0x182F7C230")]
	public void SetApplyStatusEffects(bool value)
	{
	}

	// Token: 0x06000B84 RID: 2948 RVA: 0x00004CF8 File Offset: 0x00002EF8
	[Token(Token = "0x6000B84")]
	[Address(RVA = "0x2F79C80", Offset = "0x2F78C80", VA = "0x182F79C80")]
	private Vector3 GetImpactEffectVelocity()
	{
		return default(Vector3);
	}

	// Token: 0x06000B85 RID: 2949 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000B85")]
	[Address(RVA = "0x2F79FF0", Offset = "0x2F78FF0", VA = "0x182F79FF0")]
	private MeleeImpactData GetMeleeImpactData(Component other)
	{
		return null;
	}

	// Token: 0x06000B86 RID: 2950 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B86")]
	[Address(RVA = "0x2F7A710", Offset = "0x2F79710", VA = "0x182F7A710", Slot = "296")]
	private void OnDamageSuccess(DamageNode damageNode, IImpactData impactData)
	{
	}

	// Token: 0x06000B87 RID: 2951 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B87")]
	[Address(RVA = "0x2F7B730", Offset = "0x2F7A730", VA = "0x182F7B730")]
	private void PlayHitFleshAudio()
	{
	}

	// Token: 0x06000B88 RID: 2952 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B88")]
	[Address(RVA = "0x2F7A6A0", Offset = "0x2F796A0", VA = "0x182F7A6A0", Slot = "298")]
	private void OnAttackBlocked(DamageNode damageNode, IImpactData impactData)
	{
	}

	// Token: 0x06000B89 RID: 2953 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B89")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "297")]
	private void OnAttackParried(DamageNode damageNode, IImpactData impactData)
	{
	}

	// Token: 0x06000B8A RID: 2954 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B8A")]
	[Address(RVA = "0x2F7BF60", Offset = "0x2F7AF60", VA = "0x182F7BF60")]
	private void PlayWaterImpact(Collider other)
	{
	}

	// Token: 0x06000B8B RID: 2955 RVA: 0x00004D10 File Offset: 0x00002F10
	[Token(Token = "0x6000B8B")]
	[Address(RVA = "0x2F7BBF0", Offset = "0x2F7ABF0", VA = "0x182F7BBF0")]
	private bool PlaySurfaceImpactEffect(Collider other)
	{
		return default(bool);
	}

	// Token: 0x06000B8C RID: 2956 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B8C")]
	[Address(RVA = "0x2F7C8B0", Offset = "0x2F7B8B0", VA = "0x182F7C8B0")]
	public weaponInfo()
	{
	}

	// Token: 0x04000A2B RID: 2603
	[Token(Token = "0x4000A2B")]
	[FieldOffset(Offset = "0x28")]
	[ItemIdPicker(true)]
	public int _itemID;

	// Token: 0x04000A2C RID: 2604
	[Token(Token = "0x4000A2C")]
	[FieldOffset(Offset = "0x30")]
	private ItemData _itemData;

	// Token: 0x04000A2D RID: 2605
	[Token(Token = "0x4000A2D")]
	[FieldOffset(Offset = "0x38")]
	public PlayerInventory PlayerInv;

	// Token: 0x04000A2E RID: 2606
	[Token(Token = "0x4000A2E")]
	[FieldOffset(Offset = "0x40")]
	public Animator animator;

	// Token: 0x04000A2F RID: 2607
	[Token(Token = "0x4000A2F")]
	[FieldOffset(Offset = "0x48")]
	public playerScriptSetup setup;

	// Token: 0x04000A30 RID: 2608
	[Token(Token = "0x4000A30")]
	[FieldOffset(Offset = "0x50")]
	[HideInInspector]
	public weaponInfo currentWeaponScript;

	// Token: 0x04000A31 RID: 2609
	[Token(Token = "0x4000A31")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Collider[] _weaponColliders;

	// Token: 0x04000A32 RID: 2610
	[Token(Token = "0x4000A32")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Collider[] _lowWeaponColliders;

	// Token: 0x04000A33 RID: 2611
	[Token(Token = "0x4000A33")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private List<TriggerProxy> _triggerProxies;

	// Token: 0x04000A34 RID: 2612
	[Token(Token = "0x4000A34")]
	[FieldOffset(Offset = "0x70")]
	public animEventsManager animEvents;

	// Token: 0x04000A35 RID: 2613
	[Token(Token = "0x4000A35")]
	[FieldOffset(Offset = "0x78")]
	public bool noTreeCut;

	// Token: 0x04000A36 RID: 2614
	[Token(Token = "0x4000A36")]
	[FieldOffset(Offset = "0x79")]
	public bool stick;

	// Token: 0x04000A37 RID: 2615
	[Token(Token = "0x4000A37")]
	[FieldOffset(Offset = "0x7A")]
	[SerializeField]
	[FormerlySerializedAs("spear")]
	private bool _isSpear;

	// Token: 0x04000A38 RID: 2616
	[Token(Token = "0x4000A38")]
	[FieldOffset(Offset = "0x80")]
	[EventRef]
	public string treeHitEvent;

	// Token: 0x04000A39 RID: 2617
	[Token(Token = "0x4000A39")]
	[FieldOffset(Offset = "0x88")]
	[EventRef]
	public string fleshHitEvent;

	// Token: 0x04000A3A RID: 2618
	[Token(Token = "0x4000A3A")]
	[FieldOffset(Offset = "0x90")]
	[EventRef]
	public string fleshHitEventGround;

	// Token: 0x04000A3B RID: 2619
	[Token(Token = "0x4000A3B")]
	[FieldOffset(Offset = "0x98")]
	[EventRef]
	public string fleshHitStatusEffectEvent;

	// Token: 0x04000A3C RID: 2620
	[Token(Token = "0x4000A3C")]
	[FieldOffset(Offset = "0xA0")]
	public bool fleshHitStatusEventExclusive;

	// Token: 0x04000A3D RID: 2621
	[Token(Token = "0x4000A3D")]
	[FieldOffset(Offset = "0xA8")]
	[EventRef]
	public string shellHitEvent;

	// Token: 0x04000A3E RID: 2622
	[Token(Token = "0x4000A3E")]
	[FieldOffset(Offset = "0xB0")]
	[EventRef]
	public string planeHitEvent;

	// Token: 0x04000A3F RID: 2623
	[Token(Token = "0x4000A3F")]
	[FieldOffset(Offset = "0xB8")]
	[EventRef]
	public string ropeHitEvent;

	// Token: 0x04000A40 RID: 2624
	[Token(Token = "0x4000A40")]
	[FieldOffset(Offset = "0xC0")]
	[EventRef]
	public string dirtHitEvent;

	// Token: 0x04000A41 RID: 2625
	[Token(Token = "0x4000A41")]
	[FieldOffset(Offset = "0xC8")]
	[EventRef]
	public string rockHitEvent;

	// Token: 0x04000A42 RID: 2626
	[Token(Token = "0x4000A42")]
	[FieldOffset(Offset = "0xD0")]
	[FormerlySerializedAs("waterHitEvent")]
	[EventRef]
	public string _waterHitAudioEvent;

	// Token: 0x04000A43 RID: 2627
	[Token(Token = "0x4000A43")]
	[FieldOffset(Offset = "0xD8")]
	[EventRef]
	public string tentHitEvent;

	// Token: 0x04000A44 RID: 2628
	[Token(Token = "0x4000A44")]
	[FieldOffset(Offset = "0xE0")]
	[EventRef]
	public string _swingEvent;

	// Token: 0x04000A45 RID: 2629
	[Token(Token = "0x4000A45")]
	[FieldOffset(Offset = "0xE8")]
	[Header("")]
	public bool remotePlayer;

	// Token: 0x04000A46 RID: 2630
	[Token(Token = "0x4000A46")]
	[FieldOffset(Offset = "0xEC")]
	[SerializeField]
	[FormerlySerializedAs("weaponDamage")]
	private float _weaponDamage;

	// Token: 0x04000A47 RID: 2631
	[Token(Token = "0x4000A47")]
	[FieldOffset(Offset = "0xF0")]
	private bool activeBool;

	// Token: 0x04000A48 RID: 2632
	[Token(Token = "0x4000A48")]
	[FieldOffset(Offset = "0xF8")]
	private readonly List<GameObject> _spearedFish;

	// Token: 0x04000A49 RID: 2633
	[Token(Token = "0x4000A49")]
	[FieldOffset(Offset = "0x100")]
	private bool _debugDrawPositions;

	// Token: 0x04000A4A RID: 2634
	[Token(Token = "0x4000A4A")]
	[FieldOffset(Offset = "0x101")]
	private bool _debugDrawVelocity;

	// Token: 0x04000A4B RID: 2635
	[Token(Token = "0x4000A4B")]
	[FieldOffset(Offset = "0x104")]
	private float _debugDrawVelocityScale;

	// Token: 0x04000A4C RID: 2636
	[Token(Token = "0x4000A4C")]
	[FieldOffset(Offset = "0x108")]
	private Transform _spearTip;

	// Token: 0x04000A4D RID: 2637
	[Token(Token = "0x4000A4D")]
	[FieldOffset(Offset = "0x110")]
	private float _lastSplashTime;

	// Token: 0x04000A4E RID: 2638
	[Token(Token = "0x4000A4E")]
	[FieldOffset(Offset = "0x114")]
	private float _lastImpactTime;

	// Token: 0x04000A4F RID: 2639
	[Token(Token = "0x4000A4F")]
	[FieldOffset(Offset = "0x118")]
	private float _lastSurfaceHitTime;

	// Token: 0x04000A50 RID: 2640
	[Token(Token = "0x4000A50")]
	[FieldOffset(Offset = "0x11C")]
	private float _lastNoiseEventTime;

	// Token: 0x04000A51 RID: 2641
	[Token(Token = "0x4000A51")]
	[FieldOffset(Offset = "0x120")]
	private VailAudioManager.Noise _lastNoise;

	// Token: 0x04000A52 RID: 2642
	[Token(Token = "0x4000A52")]
	[FieldOffset(Offset = "0x124")]
	private float _lastPlayerHit;

	// Token: 0x04000A53 RID: 2643
	[Token(Token = "0x4000A53")]
	[FieldOffset(Offset = "0x128")]
	private Vector3 _lastPosition;

	// Token: 0x04000A54 RID: 2644
	[Token(Token = "0x4000A54")]
	[FieldOffset(Offset = "0x134")]
	private Vector3 _lastPosition2;

	// Token: 0x04000A55 RID: 2645
	[Token(Token = "0x4000A55")]
	[FieldOffset(Offset = "0x140")]
	private Vector3 _velocity;

	// Token: 0x04000A56 RID: 2646
	[Token(Token = "0x4000A56")]
	[FieldOffset(Offset = "0x14C")]
	private Vector3 _lastWeaponImpactPosition;

	// Token: 0x04000A57 RID: 2647
	[Token(Token = "0x4000A57")]
	[FieldOffset(Offset = "0x158")]
	[SerializeField]
	private ImpactMeleeType _impactMeleeType;

	// Token: 0x04000A58 RID: 2648
	[Token(Token = "0x4000A58")]
	[FieldOffset(Offset = "0x15C")]
	[SerializeField]
	private float _impactEffectVelocityMultiplier;

	// Token: 0x04000A59 RID: 2649
	[Token(Token = "0x4000A59")]
	[FieldOffset(Offset = "0x160")]
	[SerializeField]
	private Transform _weaponImpactTransform;

	// Token: 0x04000A5A RID: 2650
	[Token(Token = "0x4000A5A")]
	[FieldOffset(Offset = "0x168")]
	private MeleeImpactData _cachedMeleeImpactData;

	// Token: 0x04000A5B RID: 2651
	[Token(Token = "0x4000A5B")]
	[FieldOffset(Offset = "0x170")]
	private MeleeWeaponData _meleeWeaponData;

	// Token: 0x04000A5C RID: 2652
	[Token(Token = "0x4000A5C")]
	[FieldOffset(Offset = "0x178")]
	private AudioImpactMaterial _impactAudioMaterial;

	// Token: 0x04000A5D RID: 2653
	[Token(Token = "0x4000A5D")]
	[FieldOffset(Offset = "0x17C")]
	private bool _applyStatusEffects;

	// Token: 0x04000A5E RID: 2654
	[Token(Token = "0x4000A5E")]
	[FieldOffset(Offset = "0x180")]
	[HideInInspector]
	public UnityEvent<DamageNode, IImpactData> OnDamageSuccessCallback;

	// Token: 0x04000A5F RID: 2655
	[Token(Token = "0x4000A5F")]
	[FieldOffset(Offset = "0x188")]
	[HideInInspector]
	public UnityEvent<DamageNode, IImpactData> OnBlockedCallback;

	// Token: 0x04000A60 RID: 2656
	[Token(Token = "0x4000A60")]
	[FieldOffset(Offset = "0x190")]
	private weaponInfo.SwingType _swingType;

	// Token: 0x02000187 RID: 391
	[Token(Token = "0x2000187")]
	public enum SwingType
	{
		// Token: 0x04000A62 RID: 2658
		[Token(Token = "0x4000A62")]
		NormalAttack,
		// Token: 0x04000A63 RID: 2659
		[Token(Token = "0x4000A63")]
		GroundAttack,
		// Token: 0x04000A64 RID: 2660
		[Token(Token = "0x4000A64")]
		TreeAttack,
		// Token: 0x04000A65 RID: 2661
		[Token(Token = "0x4000A65")]
		ComboEnder,
		// Token: 0x04000A66 RID: 2662
		[Token(Token = "0x4000A66")]
		ChargeAttack
	}
}
