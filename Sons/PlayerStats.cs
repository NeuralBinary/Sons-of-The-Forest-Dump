using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Endnight.Utilities;
using FMOD.Studio;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Atmosphere;
using Sons.Environment;
using Sons.Gameplay;
using Sons.Interfaces;
using Sons.Items.Core;
using Sons.Multiplayer;
using Sons.Player;
using Sons.Player.Stats;
using Sons.Weapon;
using Sons.Wearable.Armour;
using TheForest.Items.Inventory;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

// Token: 0x02000077 RID: 119
[Token(Token = "0x2000077")]
[RequireComponent(typeof(Vitals))]
public class PlayerStats : MonoBehaviour, IBurnable, IEnvironmentWetnessReceiver, ISleepingReceiver, ITemperatureModifierReceiver, IWarmthProbeReceiver
{
	// Token: 0x1700008F RID: 143
	// (get) Token: 0x06000383 RID: 899 RVA: 0x00003168 File Offset: 0x00001368
	[Token(Token = "0x1700008F")]
	public float HardSurvivalConsumablePositiveMultiplier
	{
		[Token(Token = "0x6000383")]
		[Address(RVA = "0x620AA0", Offset = "0x61F0A0", VA = "0x180620AA0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000090 RID: 144
	// (get) Token: 0x06000384 RID: 900 RVA: 0x00003180 File Offset: 0x00001380
	[Token(Token = "0x17000090")]
	public float HardSurvivalConsumableNegativeMultiplier
	{
		[Token(Token = "0x6000384")]
		[Address(RVA = "0x71D320", Offset = "0x71B920", VA = "0x18071D320")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06000385 RID: 901 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000385")]
	[Address(RVA = "0x3359030", Offset = "0x3357630", VA = "0x183359030")]
	public void ModifyStealthRating(float value)
	{
	}

	// Token: 0x06000386 RID: 902 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000386")]
	[Address(RVA = "0x2AFB220", Offset = "0x2AF9820", VA = "0x182AFB220")]
	public void ModifyComfortRating(float value)
	{
	}

	// Token: 0x06000387 RID: 903 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000387")]
	[Address(RVA = "0x3359040", Offset = "0x3357640", VA = "0x183359040")]
	public void ModifyWaterResistRating(float value)
	{
	}

	// Token: 0x06000388 RID: 904 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000388")]
	[Address(RVA = "0x3359060", Offset = "0x3357660", VA = "0x183359060")]
	public void ModifyStrengthBoostModifer(float value)
	{
	}

	// Token: 0x06000389 RID: 905 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000389")]
	[Address(RVA = "0x3359090", Offset = "0x3357690", VA = "0x183359090")]
	public void ModifyTreeCutDamageMultiplier(float value)
	{
	}

	// Token: 0x17000091 RID: 145
	// (get) Token: 0x0600038A RID: 906 RVA: 0x00003198 File Offset: 0x00001398
	[Token(Token = "0x17000091")]
	public float StealthRatingClamped
	{
		[Token(Token = "0x600038A")]
		[Address(RVA = "0x33590A0", Offset = "0x33576A0", VA = "0x1833590A0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000092 RID: 146
	// (get) Token: 0x0600038B RID: 907 RVA: 0x000031B0 File Offset: 0x000013B0
	[Token(Token = "0x17000092")]
	public float ComfortRatingClamped
	{
		[Token(Token = "0x600038B")]
		[Address(RVA = "0x33590D0", Offset = "0x33576D0", VA = "0x1833590D0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000093 RID: 147
	// (get) Token: 0x0600038C RID: 908 RVA: 0x000031C8 File Offset: 0x000013C8
	[Token(Token = "0x17000093")]
	public float WaterResistRatingClamped
	{
		[Token(Token = "0x600038C")]
		[Address(RVA = "0x3359100", Offset = "0x3357700", VA = "0x183359100")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000094 RID: 148
	// (get) Token: 0x0600038D RID: 909 RVA: 0x000031E0 File Offset: 0x000013E0
	[Token(Token = "0x17000094")]
	public float TreeCutDamageMultiplier
	{
		[Token(Token = "0x600038D")]
		[Address(RVA = "0x2403E60", Offset = "0x2402460", VA = "0x182403E60")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x17000095 RID: 149
	// (get) Token: 0x0600038E RID: 910 RVA: 0x000031F8 File Offset: 0x000013F8
	// (set) Token: 0x0600038F RID: 911 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000095")]
	public bool IsFightingBoss
	{
		[Token(Token = "0x600038E")]
		[Address(RVA = "0x27394A0", Offset = "0x2737AA0", VA = "0x1827394A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600038F")]
		[Address(RVA = "0x3359130", Offset = "0x3357730", VA = "0x183359130")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000096 RID: 150
	// (get) Token: 0x06000390 RID: 912 RVA: 0x00003210 File Offset: 0x00001410
	// (set) Token: 0x06000391 RID: 913 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000096")]
	public bool IsBloody
	{
		[Token(Token = "0x6000390")]
		[Address(RVA = "0x2A32B50", Offset = "0x2A31150", VA = "0x182A32B50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000391")]
		[Address(RVA = "0x30AED00", Offset = "0x30AD300", VA = "0x1830AED00")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000097 RID: 151
	// (get) Token: 0x06000392 RID: 914 RVA: 0x00003228 File Offset: 0x00001428
	[Token(Token = "0x17000097")]
	public bool IsMuddy
	{
		[Token(Token = "0x6000392")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000098 RID: 152
	// (get) Token: 0x06000393 RID: 915 RVA: 0x00003240 File Offset: 0x00001440
	[Token(Token = "0x17000098")]
	public bool IsBurning
	{
		[Token(Token = "0x6000393")]
		[Address(RVA = "0x3359140", Offset = "0x3357740", VA = "0x183359140", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000099 RID: 153
	// (get) Token: 0x06000394 RID: 916 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000099")]
	public PlayerArmourSystem ArmourSystem
	{
		[Token(Token = "0x6000394")]
		[Address(RVA = "0x2A3DA20", Offset = "0x2A3C020", VA = "0x182A3DA20")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700009A RID: 154
	// (get) Token: 0x06000395 RID: 917 RVA: 0x00003258 File Offset: 0x00001458
	[Token(Token = "0x1700009A")]
	private bool IsRecoveringFromAction
	{
		[Token(Token = "0x6000395")]
		[Address(RVA = "0x3359150", Offset = "0x3357750", VA = "0x183359150")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000396 RID: 918 RVA: 0x00003270 File Offset: 0x00001470
	[Token(Token = "0x6000396")]
	[Address(RVA = "0x2403E60", Offset = "0x2402460", VA = "0x182403E60")]
	public float GetTreeCutDamageMultiplier()
	{
		return 0f;
	}

	// Token: 0x06000397 RID: 919 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000397")]
	[Address(RVA = "0x33591C0", Offset = "0x33577C0", VA = "0x1833591C0")]
	private void OnSerializing()
	{
	}

	// Token: 0x06000398 RID: 920 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000398")]
	[Address(RVA = "0x3359220", Offset = "0x3357820", VA = "0x183359220")]
	private IEnumerator OnDeserialized()
	{
		return null;
	}

	// Token: 0x06000399 RID: 921 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000399")]
	[Address(RVA = "0x33592B0", Offset = "0x33578B0", VA = "0x1833592B0")]
	private void OnEnable()
	{
	}

	// Token: 0x0600039A RID: 922 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600039A")]
	[Address(RVA = "0x3359570", Offset = "0x3357B70", VA = "0x183359570")]
	private void OnBeforeSaveCallback()
	{
	}

	// Token: 0x0600039B RID: 923 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600039B")]
	[Address(RVA = "0x33597C0", Offset = "0x3357DC0", VA = "0x1833597C0")]
	public void OnAfterLoadCallback()
	{
	}

	// Token: 0x0600039C RID: 924 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600039C")]
	[Address(RVA = "0x3359A10", Offset = "0x3358010", VA = "0x183359A10")]
	private void OnDisable()
	{
	}

	// Token: 0x0600039D RID: 925 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600039D")]
	[Address(RVA = "0x3359D40", Offset = "0x3358340", VA = "0x183359D40")]
	private void Awake()
	{
	}

	// Token: 0x0600039E RID: 926 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600039E")]
	[Address(RVA = "0x335A1D0", Offset = "0x33587D0", VA = "0x18335A1D0")]
	private void InitializeDamageController()
	{
	}

	// Token: 0x0600039F RID: 927 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600039F")]
	[Address(RVA = "0x335A260", Offset = "0x3358860", VA = "0x18335A260")]
	private void OnImpact(IImpactSender sender, IImpactData data)
	{
	}

	// Token: 0x060003A0 RID: 928 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003A0")]
	[Address(RVA = "0x335AD90", Offset = "0x3359390", VA = "0x18335AD90")]
	private void OnDestroy()
	{
	}

	// Token: 0x060003A1 RID: 929 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003A1")]
	[Address(RVA = "0x335AEF0", Offset = "0x33594F0", VA = "0x18335AEF0")]
	private void Start()
	{
	}

	// Token: 0x060003A2 RID: 930 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003A2")]
	[Address(RVA = "0x335B220", Offset = "0x3359820", VA = "0x18335B220")]
	private static void StartIfNotPlaying(EventInstance evt)
	{
	}

	// Token: 0x060003A3 RID: 931 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003A3")]
	[Address(RVA = "0x335B340", Offset = "0x3359940", VA = "0x18335B340")]
	private static void StopIfPlaying(EventInstance evt)
	{
	}

	// Token: 0x060003A4 RID: 932 RVA: 0x00003288 File Offset: 0x00001488
	[Token(Token = "0x60003A4")]
	[Address(RVA = "0x335B460", Offset = "0x3359A60", VA = "0x18335B460")]
	public bool IsInSnow()
	{
		return default(bool);
	}

	// Token: 0x060003A5 RID: 933 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003A5")]
	[Address(RVA = "0x335B5A0", Offset = "0x3359BA0", VA = "0x18335B5A0")]
	public void OnSwingWeapon(float staminaCost, float strengthGain)
	{
	}

	// Token: 0x060003A6 RID: 934 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003A6")]
	[Address(RVA = "0x335B640", Offset = "0x3359C40", VA = "0x18335B640")]
	public void OnJump()
	{
	}

	// Token: 0x060003A7 RID: 935 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003A7")]
	[Address(RVA = "0x335B6C0", Offset = "0x3359CC0", VA = "0x18335B6C0")]
	public void OnBlockHit(float staminaCost)
	{
	}

	// Token: 0x060003A8 RID: 936 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003A8")]
	[Address(RVA = "0x335B740", Offset = "0x3359D40", VA = "0x18335B740")]
	private void UpdateExtinguishEvent()
	{
	}

	// Token: 0x060003A9 RID: 937 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003A9")]
	[Address(RVA = "0x335B8C0", Offset = "0x3359EC0", VA = "0x18335B8C0")]
	private void Update()
	{
	}

	// Token: 0x060003AA RID: 938 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003AA")]
	[Address(RVA = "0x335BFB0", Offset = "0x335A5B0", VA = "0x18335BFB0")]
	private void UpdateStatsDamage()
	{
	}

	// Token: 0x060003AB RID: 939 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003AB")]
	[Address(RVA = "0x335C3C0", Offset = "0x335A9C0", VA = "0x18335C3C0")]
	private void CheckWeatherSystemRegister()
	{
	}

	// Token: 0x060003AC RID: 940 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003AC")]
	[Address(RVA = "0x335C500", Offset = "0x335AB00", VA = "0x18335C500")]
	private void GotMud()
	{
	}

	// Token: 0x060003AD RID: 941 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003AD")]
	[Address(RVA = "0x335C6A0", Offset = "0x335ACA0", VA = "0x18335C6A0")]
	private void GotBloody()
	{
	}

	// Token: 0x060003AE RID: 942 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003AE")]
	[Address(RVA = "0x335C880", Offset = "0x335AE80", VA = "0x18335C880")]
	public void CheckArmor()
	{
	}

	// Token: 0x060003AF RID: 943 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003AF")]
	[Address(RVA = "0x335C8B0", Offset = "0x335AEB0", VA = "0x18335C8B0")]
	public void cancelCheckItem()
	{
	}

	// Token: 0x060003B0 RID: 944 RVA: 0x000032A0 File Offset: 0x000014A0
	[Token(Token = "0x60003B0")]
	[Address(RVA = "0x335C8D0", Offset = "0x335AED0", VA = "0x18335C8D0")]
	public bool CheckItem(EquipmentSlot equipmentSlot)
	{
		return default(bool);
	}

	// Token: 0x060003B1 RID: 945 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003B1")]
	[Address(RVA = "0x335CA20", Offset = "0x335B020", VA = "0x18335CA20")]
	private IEnumerator resetCheckItem(EquipmentSlot equipmentSlot)
	{
		return null;
	}

	// Token: 0x060003B2 RID: 946 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003B2")]
	[Address(RVA = "0x335CAE0", Offset = "0x335B0E0", VA = "0x18335CAE0")]
	public void GotClean()
	{
	}

	// Token: 0x060003B3 RID: 947 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003B3")]
	[Address(RVA = "0x335CAF0", Offset = "0x335B0F0", VA = "0x18335CAF0")]
	private void GotCleanReal()
	{
	}

	// Token: 0x060003B4 RID: 948 RVA: 0x000032B8 File Offset: 0x000014B8
	[Token(Token = "0x60003B4")]
	[Address(RVA = "0x335CE60", Offset = "0x335B460", VA = "0x18335CE60")]
	public bool GoToSleep()
	{
		return default(bool);
	}

	// Token: 0x060003B5 RID: 949 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003B5")]
	[Address(RVA = "0x335CE70", Offset = "0x335B470", VA = "0x18335CE70")]
	public void UpdateHealthVisuals()
	{
	}

	// Token: 0x060003B6 RID: 950 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003B6")]
	[Address(RVA = "0x335D020", Offset = "0x335B620", VA = "0x18335D020")]
	private void RestoreLowHealth()
	{
	}

	// Token: 0x060003B7 RID: 951 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003B7")]
	[Address(RVA = "0x335D0A0", Offset = "0x335B6A0", VA = "0x18335D0A0")]
	private void Fell()
	{
	}

	// Token: 0x060003B8 RID: 952 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003B8")]
	[Address(RVA = "0x335D150", Offset = "0x335B750", VA = "0x18335D150")]
	public void OnNetworkHit(int damage, ImpactType impactType, float weight, Vector3 attackerPos)
	{
	}

	// Token: 0x060003B9 RID: 953 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003B9")]
	[Address(RVA = "0x335D8F0", Offset = "0x335BEF0", VA = "0x18335D8F0")]
	private IEnumerator AdrenalineRush()
	{
		return null;
	}

	// Token: 0x060003BA RID: 954 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003BA")]
	[Address(RVA = "0x335D980", Offset = "0x335BF80", VA = "0x18335D980")]
	private void ExplosionPlayer(float hitDist)
	{
	}

	// Token: 0x060003BB RID: 955 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003BB")]
	[Address(RVA = "0x335D990", Offset = "0x335BF90", VA = "0x18335D990")]
	private void Explosion(float dist, bool fromPlayer = false)
	{
	}

	// Token: 0x060003BC RID: 956 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003BC")]
	[Address(RVA = "0x335DC40", Offset = "0x335C240", VA = "0x18335DC40")]
	private void NearExplosion(bool fromPlayer)
	{
	}

	// Token: 0x060003BD RID: 957 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003BD")]
	[Address(RVA = "0x335DF80", Offset = "0x335C580", VA = "0x18335DF80")]
	private void FarExplosion()
	{
	}

	// Token: 0x060003BE RID: 958 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003BE")]
	[Address(RVA = "0x335E0C0", Offset = "0x335C6C0", VA = "0x18335E0C0")]
	private void HitFromTrap(int damage)
	{
	}

	// Token: 0x060003BF RID: 959 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003BF")]
	[Address(RVA = "0x335E1D0", Offset = "0x335C7D0", VA = "0x18335E1D0")]
	private void PlayHitReact(int knockbackType)
	{
	}

	// Token: 0x060003C0 RID: 960 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003C0")]
	[Address(RVA = "0x335E390", Offset = "0x335C990", VA = "0x18335E390")]
	public void Hit(float damage, bool ignoreArmour = false, ImpactType impactType = ImpactType.Unknown, float weight = 1f, bool isDemonic = false, [Optional] Vector3 attackerPos, bool blocked = false)
	{
	}

	// Token: 0x060003C1 RID: 961 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003C1")]
	[Address(RVA = "0x335F1C0", Offset = "0x335D7C0", VA = "0x18335F1C0")]
	private void PlayHitRumble(float hitFactor)
	{
	}

	// Token: 0x060003C2 RID: 962 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003C2")]
	[Address(RVA = "0x335F2C0", Offset = "0x335D8C0", VA = "0x18335F2C0")]
	private void CheckDeath(DeathType deathTypeSource)
	{
	}

	// Token: 0x060003C3 RID: 963 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003C3")]
	[Address(RVA = "0x335F440", Offset = "0x335DA40", VA = "0x18335F440")]
	private void EnableGhostMode()
	{
	}

	// Token: 0x060003C4 RID: 964 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003C4")]
	[Address(RVA = "0x335F610", Offset = "0x335DC10", VA = "0x18335F610")]
	private void disablePlayerControl()
	{
	}

	// Token: 0x060003C5 RID: 965 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003C5")]
	[Address(RVA = "0x335F7E0", Offset = "0x335DDE0", VA = "0x18335F7E0")]
	private void resetInjuredBool()
	{
	}

	// Token: 0x060003C6 RID: 966 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003C6")]
	[Address(RVA = "0x335F830", Offset = "0x335DE30", VA = "0x18335F830")]
	public void SetupFirstDayConditions()
	{
	}

	// Token: 0x060003C7 RID: 967 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003C7")]
	[Address(RVA = "0x335C880", Offset = "0x335AE80", VA = "0x18335C880")]
	public void CheckArmsStart()
	{
	}

	// Token: 0x060003C8 RID: 968 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003C8")]
	[Address(RVA = "0x335F8D0", Offset = "0x335DED0", VA = "0x18335F8D0")]
	private IEnumerator CheckArmsRoutine()
	{
		return null;
	}

	// Token: 0x060003C9 RID: 969 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003C9")]
	[Address(RVA = "0x335F960", Offset = "0x335DF60", VA = "0x18335F960")]
	public void PlayWakeMusic()
	{
	}

	// Token: 0x060003CA RID: 970 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003CA")]
	[Address(RVA = "0x335F9D0", Offset = "0x335DFD0", VA = "0x18335F9D0")]
	public void CheckCollisionFromAbove(Collision coll)
	{
	}

	// Token: 0x060003CB RID: 971 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003CB")]
	[Address(RVA = "0x335FB60", Offset = "0x335E160", VA = "0x18335FB60")]
	private void HitFire()
	{
	}

	// Token: 0x060003CC RID: 972 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003CC")]
	[Address(RVA = "0x335FCB0", Offset = "0x335E2B0", VA = "0x18335FCB0")]
	private void HitPoison()
	{
	}

	// Token: 0x060003CD RID: 973 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003CD")]
	[Address(RVA = "0x335FD60", Offset = "0x335E360", VA = "0x18335FD60", Slot = "5")]
	public void Burn()
	{
	}

	// Token: 0x060003CE RID: 974 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003CE")]
	[Address(RVA = "0x335FEE0", Offset = "0x335E4E0", VA = "0x18335FEE0")]
	private void StopBurning()
	{
	}

	// Token: 0x060003CF RID: 975 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003CF")]
	[Address(RVA = "0x3360080", Offset = "0x335E680", VA = "0x183360080")]
	public void SetPlayerEffects(bool value)
	{
	}

	// Token: 0x060003D0 RID: 976 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003D0")]
	[Address(RVA = "0x3360170", Offset = "0x335E770", VA = "0x183360170")]
	private void SetOnFireState(bool onFire)
	{
	}

	// Token: 0x060003D1 RID: 977 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003D1")]
	[Address(RVA = "0x3360210", Offset = "0x335E810", VA = "0x183360210")]
	private void ResetHit()
	{
	}

	// Token: 0x060003D2 RID: 978 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003D2")]
	[Address(RVA = "0x33602D0", Offset = "0x335E8D0", VA = "0x1833602D0")]
	private void resetExplosion()
	{
	}

	// Token: 0x060003D3 RID: 979 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003D3")]
	[Address(RVA = "0x33602E0", Offset = "0x335E8E0", VA = "0x1833602E0")]
	public void IgnoreCollisionWithTerrain(bool onoff)
	{
	}

	// Token: 0x060003D4 RID: 980 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003D4")]
	[Address(RVA = "0x33607E0", Offset = "0x335EDE0", VA = "0x1833607E0")]
	public void SitDown()
	{
	}

	// Token: 0x060003D5 RID: 981 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003D5")]
	[Address(RVA = "0x33607F0", Offset = "0x335EDF0", VA = "0x1833607F0")]
	public void StandUp()
	{
	}

	// Token: 0x060003D6 RID: 982 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003D6")]
	[Address(RVA = "0x3360800", Offset = "0x335EE00", VA = "0x183360800")]
	public void HitFood()
	{
	}

	// Token: 0x060003D7 RID: 983 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003D7")]
	[Address(RVA = "0x33608C0", Offset = "0x335EEC0", VA = "0x1833608C0")]
	public void OnLoadedFromRespawn(object o)
	{
	}

	// Token: 0x060003D8 RID: 984 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003D8")]
	[Address(RVA = "0x33608D0", Offset = "0x335EED0", VA = "0x1833608D0")]
	public void UseRebreather(bool onoff)
	{
	}

	// Token: 0x060003D9 RID: 985 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003D9")]
	[Address(RVA = "0x3360970", Offset = "0x335EF70", VA = "0x183360970")]
	private void UpdateDaysSurvived()
	{
	}

	// Token: 0x060003DA RID: 986 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003DA")]
	[Address(RVA = "0x3360A90", Offset = "0x335F090", VA = "0x183360A90")]
	private void UpdateWashOffOrGetBloody()
	{
	}

	// Token: 0x060003DB RID: 987 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003DB")]
	[Address(RVA = "0x3360AD0", Offset = "0x335F0D0", VA = "0x183360AD0")]
	private void UpdateAudioListenerVolumeBasedOnHealth()
	{
	}

	// Token: 0x060003DC RID: 988 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003DC")]
	[Address(RVA = "0x3360D60", Offset = "0x335F360", VA = "0x183360D60")]
	private void UpdateStamina()
	{
	}

	// Token: 0x060003DD RID: 989 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003DD")]
	[Address(RVA = "0x3361080", Offset = "0x335F680", VA = "0x183361080")]
	private void UpdateStaminaBreathAudio()
	{
	}

	// Token: 0x060003DE RID: 990 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003DE")]
	[Address(RVA = "0x33614F0", Offset = "0x335FAF0", VA = "0x1833614F0")]
	private void UpdateRest()
	{
	}

	// Token: 0x060003DF RID: 991 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003DF")]
	[Address(RVA = "0x3361700", Offset = "0x335FD00", VA = "0x183361700")]
	private void UpdatePlayerLocation()
	{
	}

	// Token: 0x060003E0 RID: 992 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E0")]
	[Address(RVA = "0x3361840", Offset = "0x335FE40", VA = "0x183361840", Slot = "7")]
	public void OnWentToSleep()
	{
	}

	// Token: 0x060003E1 RID: 993 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E1")]
	[Address(RVA = "0x3361B50", Offset = "0x3360150", VA = "0x183361B50", Slot = "8")]
	public void OnWokeUp()
	{
	}

	// Token: 0x060003E2 RID: 994 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E2")]
	[Address(RVA = "0x3361DC0", Offset = "0x33603C0", VA = "0x183361DC0")]
	private void UpdateVitality()
	{
	}

	// Token: 0x060003E3 RID: 995 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E3")]
	[Address(RVA = "0x3361F90", Offset = "0x3360590", VA = "0x183361F90")]
	private void UpdateUnderwaterBreathing()
	{
	}

	// Token: 0x060003E4 RID: 996 RVA: 0x000032D0 File Offset: 0x000014D0
	[Token(Token = "0x60003E4")]
	[Address(RVA = "0x3362250", Offset = "0x3360850", VA = "0x183362250")]
	private bool ProcessAirDrain(BreathingData breathing)
	{
		return default(bool);
	}

	// Token: 0x060003E5 RID: 997 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E5")]
	[Address(RVA = "0x33624C0", Offset = "0x3360AC0", VA = "0x1833624C0")]
	private void PlayGaspForAir(BreathingData breathing)
	{
	}

	// Token: 0x060003E6 RID: 998 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E6")]
	[Address(RVA = "0x3362700", Offset = "0x3360D00", VA = "0x183362700")]
	public void UpdateAudioEvents()
	{
	}

	// Token: 0x060003E7 RID: 999 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E7")]
	[Address(RVA = "0x3362970", Offset = "0x3360F70", VA = "0x183362970")]
	private void OnClothingEquipped(int itemId)
	{
	}

	// Token: 0x060003E8 RID: 1000 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E8")]
	[Address(RVA = "0x3362A00", Offset = "0x3361000", VA = "0x183362A00")]
	private void OnClothingUnequipped(int itemId)
	{
	}

	// Token: 0x060003E9 RID: 1001 RVA: 0x000032E8 File Offset: 0x000014E8
	[Token(Token = "0x60003E9")]
	[Address(RVA = "0x3362A80", Offset = "0x3361080", VA = "0x183362A80")]
	private bool TryGetPlayerState(out IPlayerState playerState)
	{
		return default(bool);
	}

	// Token: 0x060003EA RID: 1002 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003EA")]
	[Address(RVA = "0x3362DD0", Offset = "0x33613D0", VA = "0x183362DD0")]
	public static void SetBlockPlayerFinalDeath(bool value)
	{
	}

	// Token: 0x1700009B RID: 155
	// (get) Token: 0x060003EB RID: 1003 RVA: 0x00003300 File Offset: 0x00001500
	[Token(Token = "0x1700009B")]
	private bool IsNetworkGame
	{
		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x3362E30", Offset = "0x3361430", VA = "0x183362E30")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060003EC RID: 1004 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003EC")]
	[Address(RVA = "0x3362E70", Offset = "0x3361470", VA = "0x183362E70")]
	public void SetInstantRespawnHere(bool value)
	{
	}

	// Token: 0x060003ED RID: 1005 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003ED")]
	[Address(RVA = "0x3362F50", Offset = "0x3361550", VA = "0x183362F50")]
	private void InstantRespawnRoutine()
	{
	}

	// Token: 0x060003EE RID: 1006 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003EE")]
	[Address(RVA = "0x3363140", Offset = "0x3361740", VA = "0x183363140")]
	private void CheckFirstDeathRoutineNoPrompt()
	{
	}

	// Token: 0x060003EF RID: 1007 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003EF")]
	[Address(RVA = "0x3363150", Offset = "0x3361750", VA = "0x183363150")]
	private void CheckFirstDeathRoutine()
	{
	}

	// Token: 0x060003F0 RID: 1008 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F0")]
	[Address(RVA = "0x3363160", Offset = "0x3361760", VA = "0x183363160")]
	private void CheckFirstDeathOption(bool respawnPrompt = true)
	{
	}

	// Token: 0x060003F1 RID: 1009 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F1")]
	[Address(RVA = "0x3363230", Offset = "0x3361830", VA = "0x183363230")]
	private void FirstDeathRoutine()
	{
	}

	// Token: 0x060003F2 RID: 1010 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F2")]
	[Address(RVA = "0x3363740", Offset = "0x3361D40", VA = "0x183363740")]
	private void OnDeathMarkerRequestResponse(DeathMarkerRequest response)
	{
	}

	// Token: 0x060003F3 RID: 1011 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F3")]
	[Address(RVA = "0x33639A0", Offset = "0x3361FA0", VA = "0x1833639A0")]
	private void EndDeathRoutine()
	{
	}

	// Token: 0x060003F4 RID: 1012 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F4")]
	[Address(RVA = "0x3363A40", Offset = "0x3362040", VA = "0x183363A40")]
	private void EndSwimmingDeathRoutine()
	{
	}

	// Token: 0x060003F5 RID: 1013 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F5")]
	[Address(RVA = "0x3363B70", Offset = "0x3362170", VA = "0x183363B70")]
	public void StartDrownWakeup()
	{
	}

	// Token: 0x060003F6 RID: 1014 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F6")]
	[Address(RVA = "0x3363C40", Offset = "0x3362240", VA = "0x183363C40")]
	private void StartDeathRoutine(DeathType deathType)
	{
	}

	// Token: 0x060003F7 RID: 1015 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F7")]
	[Address(RVA = "0x3364D50", Offset = "0x3363350", VA = "0x183364D50")]
	private void DoBasicDeath(bool respawnPrompt = true)
	{
	}

	// Token: 0x060003F8 RID: 1016 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003F8")]
	[Address(RVA = "0x3364E70", Offset = "0x3363470", VA = "0x183364E70")]
	private IEnumerator DyingMpAudio()
	{
		return null;
	}

	// Token: 0x060003F9 RID: 1017 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F9")]
	[Address(RVA = "0x3364F00", Offset = "0x3363500", VA = "0x183364F00")]
	private void StopDyingMpAudio()
	{
	}

	// Token: 0x060003FA RID: 1018 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003FA")]
	[Address(RVA = "0x3364F50", Offset = "0x3363550", VA = "0x183364F50")]
	private void PlayDeathRumble()
	{
	}

	// Token: 0x060003FB RID: 1019 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003FB")]
	[Address(RVA = "0x3364FB0", Offset = "0x33635B0", VA = "0x183364FB0")]
	private static void FadeToBlack()
	{
	}

	// Token: 0x060003FC RID: 1020 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003FC")]
	[Address(RVA = "0x33650D0", Offset = "0x33636D0", VA = "0x1833650D0")]
	private static void FadeFromBlack()
	{
	}

	// Token: 0x060003FD RID: 1021 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003FD")]
	[Address(RVA = "0x33651F0", Offset = "0x33637F0", VA = "0x1833651F0")]
	public static void SetGameOverDelayTime(float value)
	{
	}

	// Token: 0x060003FE RID: 1022 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003FE")]
	[Address(RVA = "0x3365250", Offset = "0x3363850", VA = "0x183365250")]
	public void KillPlayer()
	{
	}

	// Token: 0x060003FF RID: 1023 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003FF")]
	[Address(RVA = "0x3365260", Offset = "0x3363860", VA = "0x183365260")]
	public void QuickKillPlayer()
	{
	}

	// Token: 0x06000400 RID: 1024 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000400")]
	[Address(RVA = "0x3365270", Offset = "0x3363870", VA = "0x183365270")]
	public void KillPlayerWithRespawnPrompt(bool quickNetwork)
	{
	}

	// Token: 0x06000401 RID: 1025 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000401")]
	[Address(RVA = "0x3365770", Offset = "0x3363D70", VA = "0x183365770")]
	private void MultiplayerRespawn()
	{
	}

	// Token: 0x06000402 RID: 1026 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000402")]
	[Address(RVA = "0x3365820", Offset = "0x3363E20", VA = "0x183365820")]
	private IEnumerator MultiplayerRespawnWorker()
	{
		return null;
	}

	// Token: 0x06000403 RID: 1027 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000403")]
	[Address(RVA = "0x33658B0", Offset = "0x3363EB0", VA = "0x1833658B0")]
	private void FinalizeKillPlayer()
	{
	}

	// Token: 0x06000404 RID: 1028 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000404")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void GameOver()
	{
	}

	// Token: 0x06000405 RID: 1029 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000405")]
	[Address(RVA = "0x3365C50", Offset = "0x3364250", VA = "0x183365C50")]
	public void HealedMp(bool instant = false)
	{
	}

	// Token: 0x06000406 RID: 1030 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000406")]
	[Address(RVA = "0x3366000", Offset = "0x3364600", VA = "0x183366000")]
	private IEnumerator ResetPlayerFromHeal()
	{
		return null;
	}

	// Token: 0x06000407 RID: 1031 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000407")]
	[Address(RVA = "0x3366090", Offset = "0x3364690", VA = "0x183366090")]
	private void StartResetFromHeal()
	{
	}

	// Token: 0x06000408 RID: 1032 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000408")]
	[Address(RVA = "0x33662D0", Offset = "0x33648D0", VA = "0x1833662D0")]
	private void FinalizeResetFromHeal()
	{
	}

	// Token: 0x06000409 RID: 1033 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000409")]
	[Address(RVA = "0x33667C0", Offset = "0x3364DC0", VA = "0x1833667C0")]
	public void SetPlayerDeathCount(int valueInt)
	{
	}

	// Token: 0x0600040A RID: 1034 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600040A")]
	[Address(RVA = "0x33667D0", Offset = "0x3364DD0", VA = "0x1833667D0")]
	public void SetFinalDeath()
	{
	}

	// Token: 0x0600040B RID: 1035 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600040B")]
	[Address(RVA = "0x3366830", Offset = "0x3364E30", VA = "0x183366830")]
	public void SetDyingState(PlayerStats.DyingState newState)
	{
	}

	// Token: 0x0600040C RID: 1036 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600040C")]
	[Address(RVA = "0x3366960", Offset = "0x3364F60", VA = "0x183366960")]
	private void UpdatePlayerDyingOnGround()
	{
	}

	// Token: 0x0600040D RID: 1037 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600040D")]
	[Address(RVA = "0x3366A30", Offset = "0x3365030", VA = "0x183366A30")]
	public void UnregisterOnDeathCallback(Action deathAction)
	{
	}

	// Token: 0x0600040E RID: 1038 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600040E")]
	[Address(RVA = "0x3366B20", Offset = "0x3365120", VA = "0x183366B20")]
	public void RegisterOnDeathCallback(Action deathAction)
	{
	}

	// Token: 0x0600040F RID: 1039 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600040F")]
	[Address(RVA = "0x3366C10", Offset = "0x3365210", VA = "0x183366C10")]
	public void LogStats()
	{
	}

	// Token: 0x06000410 RID: 1040 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000410")]
	[Address(RVA = "0x3367820", Offset = "0x3365E20", VA = "0x183367820")]
	public void Register(IHitReactReceiver receiver)
	{
	}

	// Token: 0x06000411 RID: 1041 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000411")]
	[Address(RVA = "0x3367930", Offset = "0x3365F30", VA = "0x183367930")]
	public void Unregister(IHitReactReceiver receiver)
	{
	}

	// Token: 0x06000412 RID: 1042 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000412")]
	[Address(RVA = "0x3367990", Offset = "0x3365F90", VA = "0x183367990")]
	private void SendHitReact()
	{
	}

	// Token: 0x06000413 RID: 1043 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000413")]
	[Address(RVA = "0x3367B20", Offset = "0x3366120", VA = "0x183367B20")]
	public void SetWetnessThermalRatingMultiplier(float value)
	{
	}

	// Token: 0x1700009C RID: 156
	// (get) Token: 0x06000414 RID: 1044 RVA: 0x00003318 File Offset: 0x00001518
	// (set) Token: 0x06000415 RID: 1045 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700009C")]
	public bool IsCold
	{
		[Token(Token = "0x6000414")]
		[Address(RVA = "0x3367B50", Offset = "0x3366150", VA = "0x183367B50")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000415")]
		[Address(RVA = "0x3367B80", Offset = "0x3366180", VA = "0x183367B80")]
		set
		{
		}
	}

	// Token: 0x1700009D RID: 157
	// (get) Token: 0x06000416 RID: 1046 RVA: 0x00003330 File Offset: 0x00001530
	// (set) Token: 0x06000417 RID: 1047 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700009D")]
	public bool InteriorSpaceWarmth
	{
		[Token(Token = "0x6000416")]
		[Address(RVA = "0x3367BB0", Offset = "0x33661B0", VA = "0x183367BB0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000417")]
		[Address(RVA = "0x3367BE0", Offset = "0x33661E0", VA = "0x183367BE0")]
		set
		{
		}
	}

	// Token: 0x1700009E RID: 158
	// (get) Token: 0x06000418 RID: 1048 RVA: 0x00003348 File Offset: 0x00001548
	// (set) Token: 0x06000419 RID: 1049 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700009E")]
	public float ColdFactor
	{
		[Token(Token = "0x6000418")]
		[Address(RVA = "0x3367C10", Offset = "0x3366210", VA = "0x183367C10")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000419")]
		[Address(RVA = "0x3367C40", Offset = "0x3366240", VA = "0x183367C40")]
		set
		{
		}
	}

	// Token: 0x1700009F RID: 159
	// (get) Token: 0x0600041A RID: 1050 RVA: 0x00003360 File Offset: 0x00001560
	// (set) Token: 0x0600041B RID: 1051 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700009F")]
	public bool IsFreezing
	{
		[Token(Token = "0x600041A")]
		[Address(RVA = "0x3367C70", Offset = "0x3366270", VA = "0x183367C70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600041B")]
		[Address(RVA = "0x3367C80", Offset = "0x3366280", VA = "0x183367C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x170000A0 RID: 160
	// (get) Token: 0x0600041C RID: 1052 RVA: 0x00003378 File Offset: 0x00001578
	[Token(Token = "0x170000A0")]
	public float BodyTemperature
	{
		[Token(Token = "0x600041C")]
		[Address(RVA = "0x3367C90", Offset = "0x3366290", VA = "0x183367C90")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170000A1 RID: 161
	// (get) Token: 0x0600041D RID: 1053 RVA: 0x00003390 File Offset: 0x00001590
	[Token(Token = "0x170000A1")]
	public float ThermalRatingClamped
	{
		[Token(Token = "0x600041D")]
		[Address(RVA = "0x3367CA0", Offset = "0x33662A0", VA = "0x183367CA0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x0600041E RID: 1054 RVA: 0x000033A8 File Offset: 0x000015A8
	[Token(Token = "0x600041E")]
	[Address(RVA = "0x3367CD0", Offset = "0x33662D0", VA = "0x183367CD0")]
	public float CalculateColdFactor()
	{
		return 0f;
	}

	// Token: 0x0600041F RID: 1055 RVA: 0x000033C0 File Offset: 0x000015C0
	[Token(Token = "0x600041F")]
	[Address(RVA = "0x3367D10", Offset = "0x3366310", VA = "0x183367D10")]
	public float GetVitalityLostFromColdFactor()
	{
		return 0f;
	}

	// Token: 0x06000420 RID: 1056 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000420")]
	[Address(RVA = "0x3367D70", Offset = "0x3366370", VA = "0x183367D70", Slot = "6")]
	public void UpdateWetness(float wetnessCurrent)
	{
	}

	// Token: 0x06000421 RID: 1057 RVA: 0x000033D8 File Offset: 0x000015D8
	[Token(Token = "0x6000421")]
	[Address(RVA = "0x3367FB0", Offset = "0x33665B0", VA = "0x183367FB0")]
	public float GetWetness()
	{
		return 0f;
	}

	// Token: 0x06000422 RID: 1058 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000422")]
	[Address(RVA = "0x3367FC0", Offset = "0x33665C0", VA = "0x183367FC0")]
	public void ModifyThermalRating(float value)
	{
	}

	// Token: 0x06000423 RID: 1059 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000423")]
	[Address(RVA = "0x3367FE0", Offset = "0x33665E0", VA = "0x183367FE0")]
	private void UpdateTemperature()
	{
	}

	// Token: 0x06000424 RID: 1060 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000424")]
	[Address(RVA = "0x3368740", Offset = "0x3366D40", VA = "0x183368740", Slot = "9")]
	public void OnEnteredTemperatureVolume(float temperatureCelsius)
	{
	}

	// Token: 0x06000425 RID: 1061 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000425")]
	[Address(RVA = "0x3368740", Offset = "0x3366D40", VA = "0x183368740", Slot = "10")]
	public void OnStayedTemperatureVolume(float temperatureCelsius)
	{
	}

	// Token: 0x06000426 RID: 1062 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000426")]
	[Address(RVA = "0x3368750", Offset = "0x3366D50", VA = "0x183368750", Slot = "11")]
	public void OnExitedTemperatureVolume(float temperatureCelsius)
	{
	}

	// Token: 0x06000427 RID: 1063 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000427")]
	[Address(RVA = "0x3367BE0", Offset = "0x33661E0", VA = "0x183367BE0", Slot = "12")]
	private void OnWarmthChange(bool isWarm)
	{
	}

	// Token: 0x06000428 RID: 1064 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000428")]
	[Address(RVA = "0x3368760", Offset = "0x3366D60", VA = "0x183368760")]
	public static void RegisterBeachMarker(Transform source)
	{
	}

	// Token: 0x06000429 RID: 1065 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000429")]
	[Address(RVA = "0x3368910", Offset = "0x3366F10", VA = "0x183368910")]
	public static void UnregisterBeachMarker(Transform source)
	{
	}

	// Token: 0x0600042A RID: 1066 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600042A")]
	[Address(RVA = "0x3368A00", Offset = "0x3367000", VA = "0x183368A00")]
	private Transform GetClosestDrownMarker()
	{
		return null;
	}

	// Token: 0x0600042B RID: 1067 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600042B")]
	[Address(RVA = "0x3368D70", Offset = "0x3367370", VA = "0x183368D70")]
	public IEnumerator WakeUpOnBeachCutScene()
	{
		return null;
	}

	// Token: 0x0600042C RID: 1068 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600042C")]
	[Address(RVA = "0x3368E00", Offset = "0x3367400", VA = "0x183368E00")]
	public PlayerStats()
	{
	}

	// Token: 0x04000333 RID: 819
	[Token(Token = "0x4000333")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _comfortRating;

	// Token: 0x04000334 RID: 820
	[Token(Token = "0x4000334")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private Vector2 _indoorRestGainComfortRangeModifier;

	// Token: 0x04000335 RID: 821
	[Token(Token = "0x4000335")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private Vector2 _outdoorRestGainComfortRangeModifier;

	// Token: 0x04000336 RID: 822
	[Token(Token = "0x4000336")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	[Min(0f)]
	private float _hardSurvivalConsumablePositiveMultiplier;

	// Token: 0x04000337 RID: 823
	[Token(Token = "0x4000337")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Min(0f)]
	private float _hardSurvivalConsumableNegativeMultiplier;

	// Token: 0x04000338 RID: 824
	[Token(Token = "0x4000338")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float _hardSettingStatsDamageMultiplier;

	// Token: 0x04000339 RID: 825
	[Token(Token = "0x4000339")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float _starvationDamagePerTick;

	// Token: 0x0400033A RID: 826
	[Token(Token = "0x400033A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[SerializeField]
	private float _dehydrationDamagePerTick;

	// Token: 0x0400033B RID: 827
	[Token(Token = "0x400033B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	[FormerlySerializedAs("_timeBetweenStatDamageTicks")]
	private float _gameSecondsBetweenStatDamageTicks;

	// Token: 0x0400033C RID: 828
	[Token(Token = "0x400033C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float _staminaRegenColdModifierSurvivalNormal;

	// Token: 0x0400033D RID: 829
	[Token(Token = "0x400033D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private float _staminaRegenColdModifierSurvivalHard;

	// Token: 0x0400033E RID: 830
	[Token(Token = "0x400033E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[SerializeField]
	[Min(0f)]
	private float _energyLostFromLogs;

	// Token: 0x0400033F RID: 831
	[Token(Token = "0x400033F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Min(0f)]
	private float _energyLostFromCold;

	// Token: 0x04000340 RID: 832
	[Token(Token = "0x4000340")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	[SerializeField]
	[HideInInspector]
	[Min(0f)]
	private float _energyLostFromFreezing;

	// Token: 0x04000341 RID: 833
	[Token(Token = "0x4000341")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	[Min(0f)]
	private float _energyLostFromHunger;

	// Token: 0x04000342 RID: 834
	[Token(Token = "0x4000342")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[HideInInspector]
	[SerializeField]
	[Min(0f)]
	private float _energyLostFromStarvation;

	// Token: 0x04000343 RID: 835
	[Token(Token = "0x4000343")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[Min(0f)]
	[SerializeField]
	private float _energyLostFromThirst;

	// Token: 0x04000344 RID: 836
	[Token(Token = "0x4000344")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[Min(0f)]
	[SerializeField]
	[HideInInspector]
	private float _energyLostFromDehydration;

	// Token: 0x04000345 RID: 837
	[Token(Token = "0x4000345")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private float _stealthRating;

	// Token: 0x04000346 RID: 838
	[Token(Token = "0x4000346")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[SerializeField]
	private float _treeCutDamageMultiplier;

	// Token: 0x04000347 RID: 839
	[Token(Token = "0x4000347")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float _timeUntilNextStatDamageTick;

	// Token: 0x04000348 RID: 840
	[Token(Token = "0x4000348")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[Range(0f, 1f)]
	public float _requiredDepthToBeConsideredInSnow;

	// Token: 0x04000349 RID: 841
	[Token(Token = "0x4000349")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float SoundRangeDampFactor;

	// Token: 0x0400034A RID: 842
	[Token(Token = "0x400034A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float Flammable;

	// Token: 0x0400034B RID: 843
	[Token(Token = "0x400034B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float DaySurvived;

	// Token: 0x0400034C RID: 844
	[Token(Token = "0x400034C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[Header("Effects")]
	[SerializeField]
	private PlayerEffects _playerEffects;

	// Token: 0x0400034D RID: 845
	[Token(Token = "0x400034D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[Header("Rumble")]
	public float HitRumbleStrength;

	// Token: 0x0400034E RID: 846
	[Token(Token = "0x400034E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public float HitRumbleDuration;

	// Token: 0x0400034F RID: 847
	[Token(Token = "0x400034F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[SerializeField]
	[EventRef]
	private string GaspForAirEvent;

	// Token: 0x04000350 RID: 848
	[Token(Token = "0x4000350")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[EventRef]
	[SerializeField]
	private string DrowningEvent;

	// Token: 0x04000351 RID: 849
	[Token(Token = "0x4000351")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[SerializeField]
	[EventRef]
	private string DyingEvent;

	// Token: 0x04000352 RID: 850
	[Token(Token = "0x4000352")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[SerializeField]
	[EventRef]
	private string ExtinguishEvent;

	// Token: 0x04000353 RID: 851
	[Token(Token = "0x4000353")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[SerializeField]
	[EventRef]
	private string ApplyMudEvent;

	// Token: 0x04000354 RID: 852
	[Token(Token = "0x4000354")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[EventRef]
	[SerializeField]
	private string _staminaBreathEvent;

	// Token: 0x04000355 RID: 853
	[Token(Token = "0x4000355")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private float _staminaRecoverRate;

	// Token: 0x04000356 RID: 854
	[Token(Token = "0x4000356")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	[SerializeField]
	private float _jumpStaminaCost;

	// Token: 0x04000357 RID: 855
	[Token(Token = "0x4000357")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private PlayerArmBlood _leftArmBlood;

	// Token: 0x04000358 RID: 856
	[Token(Token = "0x4000358")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[SerializeField]
	private PlayerArmBlood _rightArmBlood;

	// Token: 0x0400035B RID: 859
	[Token(Token = "0x400035B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private float _currentEnergyDrain;

	// Token: 0x0400035C RID: 860
	[Token(Token = "0x400035C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	[SerializeField]
	private BloodAndColdScreenOverlay _bloodAndColdEffects;

	// Token: 0x0400035D RID: 861
	[Token(Token = "0x400035D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	[SerializeField]
	private DamageController _damageController;

	// Token: 0x0400035E RID: 862
	[Token(Token = "0x400035E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private PlayerInventory _inventory;

	// Token: 0x0400035F RID: 863
	[Token(Token = "0x400035F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private bool _doGotCleanCheck;

	// Token: 0x04000360 RID: 864
	[Token(Token = "0x4000360")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x109")]
	private bool _isHealing;

	// Token: 0x04000361 RID: 865
	[Token(Token = "0x4000361")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10A")]
	private bool _checkingIfBloody;

	// Token: 0x04000362 RID: 866
	[Token(Token = "0x4000362")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10B")]
	private bool _isSeated;

	// Token: 0x04000363 RID: 867
	[Token(Token = "0x4000363")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	private bool _isExplode;

	// Token: 0x04000364 RID: 868
	[Token(Token = "0x4000364")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10D")]
	private bool _doneDragScene;

	// Token: 0x04000365 RID: 869
	[Token(Token = "0x4000365")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private float _trapHitCoolDown;

	// Token: 0x04000366 RID: 870
	[Token(Token = "0x4000366")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	private float _nextAdrenalineRush;

	// Token: 0x04000367 RID: 871
	[Token(Token = "0x4000367")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private float _tired;

	// Token: 0x04000368 RID: 872
	[Token(Token = "0x4000368")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	private bool _reloadedFromRespawn;

	// Token: 0x04000369 RID: 873
	[Token(Token = "0x4000369")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private PlayerSfx _sfx;

	// Token: 0x0400036A RID: 874
	[Token(Token = "0x400036A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private float _externalWetnessLevel;

	// Token: 0x0400036B RID: 875
	[Token(Token = "0x400036B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private Animator _animator;

	// Token: 0x0400036C RID: 876
	[Token(Token = "0x400036C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private playerHitReactions _hitReactions;

	// Token: 0x0400036D RID: 877
	[Token(Token = "0x400036D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private camFollowHead _cameraFollow;

	// Token: 0x0400036E RID: 878
	[Token(Token = "0x400036E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private Vitals _vitals;

	// Token: 0x0400036F RID: 879
	[Token(Token = "0x400036F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private bool _weatherSystemRegistered;

	// Token: 0x04000370 RID: 880
	[Token(Token = "0x4000370")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private PlayerLocation _playerLocation;

	// Token: 0x04000371 RID: 881
	[Token(Token = "0x4000371")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	[SerializeField]
	private PlayerArmourSystem _armourSystem;

	// Token: 0x04000372 RID: 882
	[Token(Token = "0x4000372")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private float _staminaActionTime;

	// Token: 0x04000373 RID: 883
	[Token(Token = "0x4000373")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private EventInstance _dyingSfxEvent;

	// Token: 0x04000374 RID: 884
	[Token(Token = "0x4000374")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private EventInstance _drowningSfxEvent;

	// Token: 0x04000375 RID: 885
	[Token(Token = "0x4000375")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private EventInstance _fireExtinguishSfxEvent;

	// Token: 0x04000376 RID: 886
	[Token(Token = "0x4000376")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private EventInstance _staminaBreathInstance;

	// Token: 0x04000377 RID: 887
	[Token(Token = "0x4000377")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private readonly int _explodeAnimatorHash;

	// Token: 0x04000378 RID: 888
	[Token(Token = "0x4000378")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
	private readonly int _enterCaveAnimatorHash;

	// Token: 0x04000379 RID: 889
	[Token(Token = "0x4000379")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private readonly int _eatMeatAnimatorHash;

	// Token: 0x0400037A RID: 890
	[Token(Token = "0x400037A")]
	private const string HitSmallRumbleProfileId = "PlayerHitSmall";

	// Token: 0x0400037B RID: 891
	[Token(Token = "0x400037B")]
	private const string HitMedRumbleProfileId = "PlayerHitMed";

	// Token: 0x0400037C RID: 892
	[Token(Token = "0x400037C")]
	private const string HitLargeRumbleProfileId = "PlayerHitLarge";

	// Token: 0x0400037D RID: 893
	[Token(Token = "0x400037D")]
	private const string HealthParamName = "health";

	// Token: 0x0400037E RID: 894
	[Token(Token = "0x400037E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private Coroutine checkItemRoutine;

	// Token: 0x0400037F RID: 895
	[Token(Token = "0x400037F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private BoltEntity _playerEntityCache;

	// Token: 0x04000380 RID: 896
	[Token(Token = "0x4000380")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private IPlayerState _playerStateCache;

	// Token: 0x04000381 RID: 897
	[Token(Token = "0x4000381")]
	private const string PlayerDeathRumbleProfileId = "PlayerDeath";

	// Token: 0x04000382 RID: 898
	[Token(Token = "0x4000382")]
	private const string MultiplayerRespawnElementId = "multiplayer.respawn";

	// Token: 0x04000383 RID: 899
	[Token(Token = "0x4000383")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	[SerializeField]
	private Transform _deathSpawnItemsLocator;

	// Token: 0x04000384 RID: 900
	[Token(Token = "0x4000384")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	[SerializeField]
	[FormerlySerializedAs("_onDeath")]
	private UnityEvent _onDeathUnityEvent;

	// Token: 0x04000385 RID: 901
	[Token(Token = "0x4000385")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	[SerializeField]
	[EventRef]
	private string _playerDownIntroEvent;

	// Token: 0x04000386 RID: 902
	[Token(Token = "0x4000386")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	[SerializeField]
	[EventRef]
	private string _playerDownLoopEvent;

	// Token: 0x04000387 RID: 903
	[Token(Token = "0x4000387")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private int _playerDeathCount;

	// Token: 0x04000388 RID: 904
	[Token(Token = "0x4000388")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool _blockFinalDeath;

	// Token: 0x04000389 RID: 905
	[Token(Token = "0x4000389")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	private Action _onDeathCallback;

	// Token: 0x0400038A RID: 906
	[Token(Token = "0x400038A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	private readonly ILayerBehaviourActivator[] _getupLayerBehaviourActivators;

	// Token: 0x0400038B RID: 907
	[Token(Token = "0x400038B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	private PlayerStats.DyingState _dyingState;

	// Token: 0x0400038C RID: 908
	[Token(Token = "0x400038C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
	private bool _debugInstantRespawn;

	// Token: 0x0400038D RID: 909
	[Token(Token = "0x400038D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	private Vector3 _instantRespawnPosition;

	// Token: 0x0400038E RID: 910
	[Token(Token = "0x400038E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static float _gameOverDelayTime;

	// Token: 0x0400038F RID: 911
	[Token(Token = "0x400038F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
	private DeathType _deathType;

	// Token: 0x04000390 RID: 912
	[Token(Token = "0x4000390")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	private MultiplayerRespawnTimer _mpRespawnTimerGui;

	// Token: 0x04000391 RID: 913
	[Token(Token = "0x4000391")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	private bool _doFinalDeath;

	// Token: 0x04000392 RID: 914
	[Token(Token = "0x4000392")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	private EventInstance _playerDownLoopEventInstance;

	// Token: 0x04000393 RID: 915
	[Token(Token = "0x4000393")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	private Coroutine _dyingMpAudioCoroutine;

	// Token: 0x04000394 RID: 916
	[Token(Token = "0x4000394")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	private bool _respawning;

	// Token: 0x04000395 RID: 917
	[Token(Token = "0x4000395")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22C")]
	private int _maxDeathCount;

	// Token: 0x04000396 RID: 918
	[Token(Token = "0x4000396")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	private bool _checkPlayerDyingOnGround;

	// Token: 0x04000397 RID: 919
	[Token(Token = "0x4000397")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	private readonly List<IHitReactReceiver> _hitReactReceivers;

	// Token: 0x04000398 RID: 920
	[Token(Token = "0x4000398")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	[SerializeField]
	private bool _isOnFire;

	// Token: 0x04000399 RID: 921
	[Token(Token = "0x4000399")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x244")]
	[SerializeField]
	private float _thermalRating;

	// Token: 0x0400039A RID: 922
	[Token(Token = "0x400039A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	[SerializeField]
	[Tooltip("This is the amount a thermal rating of 1 would protect by. Example: A protection of 15 would make -15 degrees feel like 0")]
	private float _maxTempBoostFromThermalRating;

	// Token: 0x0400039B RID: 923
	[Token(Token = "0x400039B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24C")]
	[SerializeField]
	private float _bodyTemperature;

	// Token: 0x0400039C RID: 924
	[Token(Token = "0x400039C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
	[SerializeField]
	private float _coldAtTemperature;

	// Token: 0x0400039D RID: 925
	[Token(Token = "0x400039D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x254")]
	[SerializeField]
	private float _freezeAtTemperature;

	// Token: 0x0400039E RID: 926
	[Token(Token = "0x400039E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
	[SerializeField]
	private float _shiverAnimBlendSpeed;

	// Token: 0x0400039F RID: 927
	[Token(Token = "0x400039F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25C")]
	[SerializeField]
	private float _blendSpeedOfTemperatureVolumeModifiers;

	// Token: 0x040003A0 RID: 928
	[Token(Token = "0x40003A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
	[SerializeField]
	private float _waterResistRating;

	// Token: 0x040003A1 RID: 929
	[Token(Token = "0x40003A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x264")]
	[Range(0f, 10f)]
	[SerializeField]
	[Tooltip("The rate at which the player will get waterlogged.")]
	private float _waterSoakInRate;

	// Token: 0x040003A2 RID: 930
	[Token(Token = "0x40003A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
	[Range(0f, 10f)]
	[Tooltip("The rate at which the player will dry off.")]
	[SerializeField]
	private float _waterDryOffRate;

	// Token: 0x040003A3 RID: 931
	[Token(Token = "0x40003A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x26C")]
	[SerializeField]
	private float _maxTempDropFromWetness;

	// Token: 0x040003A4 RID: 932
	[Token(Token = "0x40003A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
	[Min(0f)]
	[SerializeField]
	private float _maxDryOffTemperature;

	// Token: 0x040003A5 RID: 933
	[Token(Token = "0x40003A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x274")]
	private float _wetnessAffectsThermalRatingMultiplier;

	// Token: 0x040003A6 RID: 934
	[Token(Token = "0x40003A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
	private float _airTemperature;

	// Token: 0x040003A7 RID: 935
	[Token(Token = "0x40003A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x27C")]
	private float _currentTempBoostFromThermalRating;

	// Token: 0x040003A8 RID: 936
	[Token(Token = "0x40003A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
	private float _currentTempDropFromWetness;

	// Token: 0x040003A9 RID: 937
	[Token(Token = "0x40003A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x284")]
	private float _temperatureModifierVolumeTemperature;

	// Token: 0x040003AA RID: 938
	[Token(Token = "0x40003AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
	private float _currentModifiedTemperatureBlendDelta;

	// Token: 0x040003AB RID: 939
	[Token(Token = "0x40003AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28C")]
	private bool _insideTemperatureModifierVolume;

	// Token: 0x040003AC RID: 940
	[Token(Token = "0x40003AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
	[Range(0f, 1f)]
	private float _currentWetness;

	// Token: 0x040003AD RID: 941
	[Token(Token = "0x40003AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x294")]
	private float _shiverAnimBlendDelta;

	// Token: 0x040003AE RID: 942
	[Token(Token = "0x40003AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
	private float _thermalRatingAfterWetnessPenalty;

	// Token: 0x040003B0 RID: 944
	[Token(Token = "0x40003B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static List<Transform> _beachMarkers;

	// Token: 0x02000078 RID: 120
	[Token(Token = "0x2000078")]
	public enum DyingState
	{
		// Token: 0x040003B2 RID: 946
		[Token(Token = "0x40003B2")]
		Alive,
		// Token: 0x040003B3 RID: 947
		[Token(Token = "0x40003B3")]
		Dying,
		// Token: 0x040003B4 RID: 948
		[Token(Token = "0x40003B4")]
		Dead
	}
}
