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
using Sons.Gameplay.GameSetup;
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

// Token: 0x02000078 RID: 120
[Token(Token = "0x2000078")]
[RequireComponent(typeof(Vitals))]
public class PlayerStats : MonoBehaviour, IBurnable, IEnvironmentWetnessReceiver, ISleepingReceiver, ITemperatureModifierReceiver, IWarmthProbeReceiver
{
	// Token: 0x1700008D RID: 141
	// (get) Token: 0x06000378 RID: 888 RVA: 0x00003090 File Offset: 0x00001290
	[Token(Token = "0x1700008D")]
	public float HardSurvivalConsumablePositiveMultiplier
	{
		[Token(Token = "0x6000378")]
		[Address(RVA = "0x567910", Offset = "0x566910", VA = "0x180567910")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x1700008E RID: 142
	// (get) Token: 0x06000379 RID: 889 RVA: 0x000030A8 File Offset: 0x000012A8
	[Token(Token = "0x1700008E")]
	public float HardSurvivalConsumableNegativeMultiplier
	{
		[Token(Token = "0x6000379")]
		[Address(RVA = "0x5A46D0", Offset = "0x5A36D0", VA = "0x1805A46D0")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x0600037A RID: 890 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600037A")]
	[Address(RVA = "0x2B75A00", Offset = "0x2B74A00", VA = "0x182B75A00")]
	public void ModifyStealthRating(float value)
	{
	}

	// Token: 0x0600037B RID: 891 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600037B")]
	[Address(RVA = "0x2613BD0", Offset = "0x2612BD0", VA = "0x182613BD0")]
	public void ModifyComfortRating(float value)
	{
	}

	// Token: 0x0600037C RID: 892 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600037C")]
	[Address(RVA = "0x2B75A30", Offset = "0x2B74A30", VA = "0x182B75A30")]
	public void ModifyWaterResistRating(float value)
	{
	}

	// Token: 0x1700008F RID: 143
	// (get) Token: 0x0600037D RID: 893 RVA: 0x000030C0 File Offset: 0x000012C0
	[Token(Token = "0x1700008F")]
	public float StealthRatingClamped
	{
		[Token(Token = "0x600037D")]
		[Address(RVA = "0x2B7D270", Offset = "0x2B7C270", VA = "0x182B7D270")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x17000090 RID: 144
	// (get) Token: 0x0600037E RID: 894 RVA: 0x000030D8 File Offset: 0x000012D8
	[Token(Token = "0x17000090")]
	public float ComfortRatingClamped
	{
		[Token(Token = "0x600037E")]
		[Address(RVA = "0x2B7D190", Offset = "0x2B7C190", VA = "0x182B7D190")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x17000091 RID: 145
	// (get) Token: 0x0600037F RID: 895 RVA: 0x000030F0 File Offset: 0x000012F0
	[Token(Token = "0x17000091")]
	public float WaterResistRatingClamped
	{
		[Token(Token = "0x600037F")]
		[Address(RVA = "0x2B7D2D0", Offset = "0x2B7C2D0", VA = "0x182B7D2D0")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x17000092 RID: 146
	// (get) Token: 0x06000380 RID: 896 RVA: 0x00003108 File Offset: 0x00001308
	// (set) Token: 0x06000381 RID: 897 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000092")]
	public bool IsFightingBoss
	{
		[Token(Token = "0x6000380")]
		[Address(RVA = "0x8C5E90", Offset = "0x8C4E90", VA = "0x1808C5E90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000381")]
		[Address(RVA = "0x24BC990", Offset = "0x24BB990", VA = "0x1824BC990")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000093 RID: 147
	// (get) Token: 0x06000382 RID: 898 RVA: 0x00003120 File Offset: 0x00001320
	// (set) Token: 0x06000383 RID: 899 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000093")]
	public bool IsBloody
	{
		[Token(Token = "0x6000382")]
		[Address(RVA = "0x2AA4690", Offset = "0x2AA3690", VA = "0x182AA4690")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000383")]
		[Address(RVA = "0x2AA62C0", Offset = "0x2AA52C0", VA = "0x182AA62C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000094 RID: 148
	// (get) Token: 0x06000384 RID: 900 RVA: 0x00003138 File Offset: 0x00001338
	[Token(Token = "0x17000094")]
	public bool IsMuddy
	{
		[Token(Token = "0x6000384")]
		[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000095 RID: 149
	// (get) Token: 0x06000385 RID: 901 RVA: 0x00003150 File Offset: 0x00001350
	[Token(Token = "0x17000095")]
	public bool IsBurning
	{
		[Token(Token = "0x6000385")]
		[Address(RVA = "0x2B7D1F0", Offset = "0x2B7C1F0", VA = "0x182B7D1F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000096 RID: 150
	// (get) Token: 0x06000386 RID: 902 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000096")]
	public PlayerArmourSystem ArmourSystem
	{
		[Token(Token = "0x6000386")]
		[Address(RVA = "0x23F34C0", Offset = "0x23F24C0", VA = "0x1823F34C0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000097 RID: 151
	// (get) Token: 0x06000387 RID: 903 RVA: 0x00003168 File Offset: 0x00001368
	[Token(Token = "0x17000097")]
	private bool IsRecoveringFromAction
	{
		[Token(Token = "0x6000387")]
		[Address(RVA = "0x2B7D240", Offset = "0x2B7C240", VA = "0x182B7D240")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000388 RID: 904 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000388")]
	[Address(RVA = "0x2B77780", Offset = "0x2B76780", VA = "0x182B77780")]
	private void OnSerializing()
	{
	}

	// Token: 0x06000389 RID: 905 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000389")]
	[Address(RVA = "0x2B76160", Offset = "0x2B75160", VA = "0x182B76160")]
	private IEnumerator OnDeserialized()
	{
		return null;
	}

	// Token: 0x0600038A RID: 906 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600038A")]
	[Address(RVA = "0x2B765F0", Offset = "0x2B755F0", VA = "0x182B765F0")]
	private void OnEnable()
	{
	}

	// Token: 0x0600038B RID: 907 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600038B")]
	[Address(RVA = "0x2B76330", Offset = "0x2B75330", VA = "0x182B76330")]
	private void OnDisable()
	{
	}

	// Token: 0x0600038C RID: 908 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600038C")]
	[Address(RVA = "0x2B71020", Offset = "0x2B70020", VA = "0x182B71020")]
	private void Awake()
	{
	}

	// Token: 0x0600038D RID: 909 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600038D")]
	[Address(RVA = "0x2B74A20", Offset = "0x2B73A20", VA = "0x182B74A20")]
	private void InitializeDamageController()
	{
	}

	// Token: 0x0600038E RID: 910 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600038E")]
	[Address(RVA = "0x2B768A0", Offset = "0x2B758A0", VA = "0x182B768A0")]
	private void OnImpact(IImpactSender sender, IImpactData data)
	{
	}

	// Token: 0x0600038F RID: 911 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600038F")]
	[Address(RVA = "0x2B761D0", Offset = "0x2B751D0", VA = "0x182B761D0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000390 RID: 912 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000390")]
	[Address(RVA = "0x2B79CE0", Offset = "0x2B78CE0", VA = "0x182B79CE0")]
	private void Start()
	{
	}

	// Token: 0x06000391 RID: 913 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000391")]
	[Address(RVA = "0x2B79C30", Offset = "0x2B78C30", VA = "0x182B79C30")]
	private static void StartIfNotPlaying(EventInstance evt)
	{
	}

	// Token: 0x06000392 RID: 914 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000392")]
	[Address(RVA = "0x2B7A170", Offset = "0x2B79170", VA = "0x182B7A170")]
	private static void StopIfPlaying(EventInstance evt)
	{
	}

	// Token: 0x06000393 RID: 915 RVA: 0x00003180 File Offset: 0x00001380
	[Token(Token = "0x6000393")]
	[Address(RVA = "0x2B74C00", Offset = "0x2B73C00", VA = "0x182B74C00")]
	public bool IsInSnow()
	{
		return default(bool);
	}

	// Token: 0x06000394 RID: 916 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000394")]
	[Address(RVA = "0x2B777E0", Offset = "0x2B767E0", VA = "0x182B777E0")]
	public void OnSwingWeapon(float staminaCost, float strengthGain)
	{
	}

	// Token: 0x06000395 RID: 917 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000395")]
	[Address(RVA = "0x2B770A0", Offset = "0x2B760A0", VA = "0x182B770A0")]
	public void OnJump()
	{
	}

	// Token: 0x06000396 RID: 918 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000396")]
	[Address(RVA = "0x2B75E70", Offset = "0x2B74E70", VA = "0x182B75E70")]
	public void OnBlockHit(float staminaCost)
	{
	}

	// Token: 0x06000397 RID: 919 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000397")]
	[Address(RVA = "0x2B7A9B0", Offset = "0x2B799B0", VA = "0x182B7A9B0")]
	private void UpdateExtinguishEvent()
	{
	}

	// Token: 0x06000398 RID: 920 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000398")]
	[Address(RVA = "0x2B7C180", Offset = "0x2B7B180", VA = "0x182B7C180")]
	private void Update()
	{
	}

	// Token: 0x06000399 RID: 921 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000399")]
	[Address(RVA = "0x2B7B3A0", Offset = "0x2B7A3A0", VA = "0x182B7B3A0")]
	private void UpdateStatsDamage()
	{
	}

	// Token: 0x0600039A RID: 922 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600039A")]
	[Address(RVA = "0x2B71A50", Offset = "0x2B70A50", VA = "0x182B71A50")]
	private void CheckWeatherSystemRegister()
	{
	}

	// Token: 0x0600039B RID: 923 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600039B")]
	[Address(RVA = "0x2B73140", Offset = "0x2B72140", VA = "0x182B73140")]
	private void GotMud()
	{
	}

	// Token: 0x0600039C RID: 924 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600039C")]
	[Address(RVA = "0x2B72F30", Offset = "0x2B71F30", VA = "0x182B72F30")]
	private void GotBloody()
	{
	}

	// Token: 0x0600039D RID: 925 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600039D")]
	[Address(RVA = "0x2B71420", Offset = "0x2B70420", VA = "0x182B71420")]
	public void CheckArmor()
	{
	}

	// Token: 0x0600039E RID: 926 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600039E")]
	[Address(RVA = "0x2B7D020", Offset = "0x2B7C020", VA = "0x182B7D020")]
	public void cancelCheckItem()
	{
	}

	// Token: 0x0600039F RID: 927 RVA: 0x00003198 File Offset: 0x00001398
	[Token(Token = "0x600039F")]
	[Address(RVA = "0x2B71980", Offset = "0x2B70980", VA = "0x182B71980")]
	public bool CheckItem(EquipmentSlot equipmentSlot)
	{
		return default(bool);
	}

	// Token: 0x060003A0 RID: 928 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003A0")]
	[Address(RVA = "0x2B7D300", Offset = "0x2B7C300", VA = "0x182B7D300")]
	private IEnumerator resetCheckItem(EquipmentSlot equipmentSlot)
	{
		return null;
	}

	// Token: 0x060003A1 RID: 929 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003A1")]
	[Address(RVA = "0x2B73130", Offset = "0x2B72130", VA = "0x182B73130")]
	public void GotClean()
	{
	}

	// Token: 0x060003A2 RID: 930 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003A2")]
	[Address(RVA = "0x2B72F90", Offset = "0x2B71F90", VA = "0x182B72F90")]
	private void GotCleanReal()
	{
	}

	// Token: 0x060003A3 RID: 931 RVA: 0x000031B0 File Offset: 0x000013B0
	[Token(Token = "0x60003A3")]
	[Address(RVA = "0x2B72F20", Offset = "0x2B71F20", VA = "0x182B72F20")]
	public bool GoToSleep()
	{
		return default(bool);
	}

	// Token: 0x060003A4 RID: 932 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003A4")]
	[Address(RVA = "0x2B7AA90", Offset = "0x2B79A90", VA = "0x182B7AA90")]
	public void UpdateHealthVisuals()
	{
	}

	// Token: 0x060003A5 RID: 933 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003A5")]
	[Address(RVA = "0x2B787A0", Offset = "0x2B777A0", VA = "0x182B787A0")]
	private void RestoreLowHealth()
	{
	}

	// Token: 0x060003A6 RID: 934 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003A6")]
	[Address(RVA = "0x2B72620", Offset = "0x2B71620", VA = "0x182B72620")]
	private void Fell()
	{
	}

	// Token: 0x060003A7 RID: 935 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003A7")]
	[Address(RVA = "0x2B77100", Offset = "0x2B76100", VA = "0x182B77100")]
	public void OnNetworkHit(int damage, ImpactType impactType, float weight, Vector3 attackerPos)
	{
	}

	// Token: 0x060003A8 RID: 936 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003A8")]
	[Address(RVA = "0x2B70FB0", Offset = "0x2B6FFB0", VA = "0x182B70FB0")]
	private IEnumerator AdrenalineRush()
	{
		return null;
	}

	// Token: 0x060003A9 RID: 937 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003A9")]
	[Address(RVA = "0x2B720A0", Offset = "0x2B710A0", VA = "0x182B720A0")]
	private void ExplosionPlayer(float hitDist)
	{
	}

	// Token: 0x060003AA RID: 938 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003AA")]
	[Address(RVA = "0x2B720B0", Offset = "0x2B710B0", VA = "0x182B720B0")]
	private void Explosion(float dist, bool fromPlayer = false)
	{
	}

	// Token: 0x060003AB RID: 939 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003AB")]
	[Address(RVA = "0x2B75B50", Offset = "0x2B74B50", VA = "0x182B75B50")]
	private void NearExplosion(bool fromPlayer)
	{
	}

	// Token: 0x060003AC RID: 940 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003AC")]
	[Address(RVA = "0x2B724F0", Offset = "0x2B714F0", VA = "0x182B724F0")]
	private void FarExplosion()
	{
	}

	// Token: 0x060003AD RID: 941 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003AD")]
	[Address(RVA = "0x2B73870", Offset = "0x2B72870", VA = "0x182B73870")]
	private void HitFromTrap(int damage)
	{
	}

	// Token: 0x060003AE RID: 942 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003AE")]
	[Address(RVA = "0x2B77CB0", Offset = "0x2B76CB0", VA = "0x182B77CB0")]
	private void PlayHitReact(int knockbackType)
	{
	}

	// Token: 0x060003AF RID: 943 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003AF")]
	[Address(RVA = "0x2B73980", Offset = "0x2B72980", VA = "0x182B73980")]
	public void Hit(float damage, bool ignoreArmour = false, ImpactType impactType = 0, float weight = 1f, bool isDemonic = false, [Optional] Vector3 attackerPos, bool blocked = false)
	{
	}

	// Token: 0x060003B0 RID: 944 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003B0")]
	[Address(RVA = "0x2B77D90", Offset = "0x2B76D90", VA = "0x182B77D90")]
	private void PlayHitRumble(float hitFactor)
	{
	}

	// Token: 0x060003B1 RID: 945 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003B1")]
	[Address(RVA = "0x2B71660", Offset = "0x2B70660", VA = "0x182B71660")]
	private void CheckDeath(DeathType deathTypeSource)
	{
	}

	// Token: 0x060003B2 RID: 946 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003B2")]
	[Address(RVA = "0x2B71D00", Offset = "0x2B70D00", VA = "0x182B71D00")]
	private void EnableGhostMode()
	{
	}

	// Token: 0x060003B3 RID: 947 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003B3")]
	[Address(RVA = "0x2B7D040", Offset = "0x2B7C040", VA = "0x182B7D040")]
	private void disablePlayerControl()
	{
	}

	// Token: 0x060003B4 RID: 948 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003B4")]
	[Address(RVA = "0x2B7D390", Offset = "0x2B7C390", VA = "0x182B7D390")]
	private void resetInjuredBool()
	{
	}

	// Token: 0x060003B5 RID: 949 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003B5")]
	[Address(RVA = "0x2B78D50", Offset = "0x2B77D50", VA = "0x182B78D50")]
	public void SetupFirstDayConditions()
	{
	}

	// Token: 0x060003B6 RID: 950 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003B6")]
	[Address(RVA = "0x2B71420", Offset = "0x2B70420", VA = "0x182B71420")]
	public void CheckArmsStart()
	{
	}

	// Token: 0x060003B7 RID: 951 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003B7")]
	[Address(RVA = "0x2B714A0", Offset = "0x2B704A0", VA = "0x182B714A0")]
	private IEnumerator CheckArmsRoutine()
	{
		return null;
	}

	// Token: 0x060003B8 RID: 952 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003B8")]
	[Address(RVA = "0x2B77E90", Offset = "0x2B76E90", VA = "0x182B77E90")]
	public void PlayWakeMusic()
	{
	}

	// Token: 0x060003B9 RID: 953 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003B9")]
	[Address(RVA = "0x2B71510", Offset = "0x2B70510", VA = "0x182B71510")]
	public void CheckCollisionFromAbove(Collision coll)
	{
	}

	// Token: 0x060003BA RID: 954 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003BA")]
	[Address(RVA = "0x2B73580", Offset = "0x2B72580", VA = "0x182B73580")]
	private void HitFire()
	{
	}

	// Token: 0x060003BB RID: 955 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003BB")]
	[Address(RVA = "0x2B73910", Offset = "0x2B72910", VA = "0x182B73910")]
	private void HitPoison()
	{
	}

	// Token: 0x060003BC RID: 956 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003BC")]
	[Address(RVA = "0x2B712A0", Offset = "0x2B702A0", VA = "0x182B712A0", Slot = "5")]
	public void Burn()
	{
	}

	// Token: 0x060003BD RID: 957 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003BD")]
	[Address(RVA = "0x2B7A060", Offset = "0x2B79060", VA = "0x182B7A060")]
	private void StopBurning()
	{
	}

	// Token: 0x060003BE RID: 958 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003BE")]
	[Address(RVA = "0x2B78C70", Offset = "0x2B77C70", VA = "0x182B78C70")]
	private void SetOnFireState(bool onFire)
	{
	}

	// Token: 0x060003BF RID: 959 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003BF")]
	[Address(RVA = "0x2B786B0", Offset = "0x2B776B0", VA = "0x182B786B0")]
	private void ResetHit()
	{
	}

	// Token: 0x060003C0 RID: 960 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003C0")]
	[Address(RVA = "0x2B7D380", Offset = "0x2B7C380", VA = "0x182B7D380")]
	private void resetExplosion()
	{
	}

	// Token: 0x060003C1 RID: 961 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003C1")]
	[Address(RVA = "0x2B747E0", Offset = "0x2B737E0", VA = "0x182B747E0")]
	public void IgnoreCollisionWithTerrain(bool onoff)
	{
	}

	// Token: 0x060003C2 RID: 962 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003C2")]
	[Address(RVA = "0x2B78DD0", Offset = "0x2B77DD0", VA = "0x182B78DD0")]
	public void SitDown()
	{
	}

	// Token: 0x060003C3 RID: 963 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003C3")]
	[Address(RVA = "0x2B78E10", Offset = "0x2B77E10", VA = "0x182B78E10")]
	public void StandUp()
	{
	}

	// Token: 0x060003C4 RID: 964 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003C4")]
	[Address(RVA = "0x2B737B0", Offset = "0x2B727B0", VA = "0x182B737B0")]
	public void HitFood()
	{
	}

	// Token: 0x060003C5 RID: 965 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003C5")]
	[Address(RVA = "0x2B77EC0", Offset = "0x2B76EC0", VA = "0x182B77EC0")]
	public void PoisonMe()
	{
	}

	// Token: 0x060003C6 RID: 966 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003C6")]
	[Address(RVA = "0x2B770F0", Offset = "0x2B760F0", VA = "0x182B770F0")]
	public void OnLoadedFromRespawn(object o)
	{
	}

	// Token: 0x060003C7 RID: 967 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003C7")]
	[Address(RVA = "0x2B7CB30", Offset = "0x2B7BB30", VA = "0x182B7CB30")]
	public void UseRebreather(bool onoff)
	{
	}

	// Token: 0x060003C8 RID: 968 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003C8")]
	[Address(RVA = "0x2B7A850", Offset = "0x2B79850", VA = "0x182B7A850")]
	private void UpdateDaysSurvived()
	{
	}

	// Token: 0x060003C9 RID: 969 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003C9")]
	[Address(RVA = "0x2B7BE30", Offset = "0x2B7AE30", VA = "0x182B7BE30")]
	private void UpdateWashOffOrGetBloody()
	{
	}

	// Token: 0x060003CA RID: 970 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003CA")]
	[Address(RVA = "0x2B7A780", Offset = "0x2B79780", VA = "0x182B7A780")]
	private void UpdateAudioListenerVolumeBasedOnHealth()
	{
	}

	// Token: 0x060003CB RID: 971 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003CB")]
	[Address(RVA = "0x2B7B1A0", Offset = "0x2B7A1A0", VA = "0x182B7B1A0")]
	private void UpdateStamina()
	{
	}

	// Token: 0x060003CC RID: 972 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003CC")]
	[Address(RVA = "0x2B7ADE0", Offset = "0x2B79DE0", VA = "0x182B7ADE0")]
	private void UpdateStaminaBreathAudio()
	{
	}

	// Token: 0x060003CD RID: 973 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003CD")]
	[Address(RVA = "0x2B7AC00", Offset = "0x2B79C00", VA = "0x182B7AC00")]
	private void UpdateRest()
	{
	}

	// Token: 0x060003CE RID: 974 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003CE")]
	[Address(RVA = "0x2B7ABC0", Offset = "0x2B79BC0", VA = "0x182B7ABC0")]
	private void UpdatePlayerLocation()
	{
	}

	// Token: 0x060003CF RID: 975 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003CF")]
	[Address(RVA = "0x2B77850", Offset = "0x2B76850", VA = "0x182B77850", Slot = "7")]
	public void OnWentToSleep()
	{
	}

	// Token: 0x060003D0 RID: 976 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003D0")]
	[Address(RVA = "0x2B77990", Offset = "0x2B76990", VA = "0x182B77990", Slot = "8")]
	public void OnWokeUp()
	{
	}

	// Token: 0x060003D1 RID: 977 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003D1")]
	[Address(RVA = "0x2B7BE00", Offset = "0x2B7AE00", VA = "0x182B7BE00")]
	private void UpdateVitality()
	{
	}

	// Token: 0x060003D2 RID: 978 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003D2")]
	[Address(RVA = "0x2B7BC10", Offset = "0x2B7AC10", VA = "0x182B7BC10")]
	private void UpdateUnderwaterBreathing()
	{
	}

	// Token: 0x060003D3 RID: 979 RVA: 0x000031C8 File Offset: 0x000013C8
	[Token(Token = "0x60003D3")]
	[Address(RVA = "0x2B77FD0", Offset = "0x2B76FD0", VA = "0x182B77FD0")]
	private bool ProcessAirDrain(BreathingData breathing)
	{
		return default(bool);
	}

	// Token: 0x060003D4 RID: 980 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003D4")]
	[Address(RVA = "0x2B77B20", Offset = "0x2B76B20", VA = "0x182B77B20")]
	private void PlayGaspForAir(BreathingData breathing)
	{
	}

	// Token: 0x060003D5 RID: 981 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003D5")]
	[Address(RVA = "0x2B7A5C0", Offset = "0x2B795C0", VA = "0x182B7A5C0")]
	public void UpdateAudioEvents()
	{
	}

	// Token: 0x060003D6 RID: 982 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003D6")]
	[Address(RVA = "0x2B75EB0", Offset = "0x2B74EB0", VA = "0x182B75EB0")]
	private void OnClothingEquipped(int itemId)
	{
	}

	// Token: 0x060003D7 RID: 983 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003D7")]
	[Address(RVA = "0x2B75F40", Offset = "0x2B74F40", VA = "0x182B75F40")]
	private void OnClothingUnequipped(int itemId)
	{
	}

	// Token: 0x060003D8 RID: 984 RVA: 0x000031E0 File Offset: 0x000013E0
	[Token(Token = "0x60003D8")]
	[Address(RVA = "0x2B7A220", Offset = "0x2B79220", VA = "0x182B7A220")]
	private bool TryGetPlayerState(out IPlayerState playerState)
	{
		return default(bool);
	}

	// Token: 0x060003D9 RID: 985 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003D9")]
	[Address(RVA = "0x2B78980", Offset = "0x2B77980", VA = "0x182B78980")]
	public static void SetBlockPlayerFinalDeath(bool value)
	{
	}

	// Token: 0x060003DA RID: 986 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003DA")]
	[Address(RVA = "0x2B78C20", Offset = "0x2B77C20", VA = "0x182B78C20")]
	public void SetInstantRespawnHere(bool value)
	{
	}

	// Token: 0x060003DB RID: 987 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003DB")]
	[Address(RVA = "0x2B74AB0", Offset = "0x2B73AB0", VA = "0x182B74AB0")]
	private void InstantRespawnRoutine()
	{
	}

	// Token: 0x060003DC RID: 988 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003DC")]
	[Address(RVA = "0x2B71870", Offset = "0x2B70870", VA = "0x182B71870")]
	private void CheckFirstDeathRoutineNoPrompt()
	{
	}

	// Token: 0x060003DD RID: 989 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003DD")]
	[Address(RVA = "0x2B718F0", Offset = "0x2B708F0", VA = "0x182B718F0")]
	private void CheckFirstDeathRoutine()
	{
	}

	// Token: 0x060003DE RID: 990 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003DE")]
	[Address(RVA = "0x2B717C0", Offset = "0x2B707C0", VA = "0x182B717C0")]
	private void CheckFirstDeathOption(bool respawnPrompt = true)
	{
	}

	// Token: 0x060003DF RID: 991 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003DF")]
	[Address(RVA = "0x2B729B0", Offset = "0x2B719B0", VA = "0x182B729B0")]
	private void FirstDeathRoutine()
	{
	}

	// Token: 0x060003E0 RID: 992 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E0")]
	[Address(RVA = "0x2B75FC0", Offset = "0x2B74FC0", VA = "0x182B75FC0")]
	private void OnDeathMarkerRequestResponse(DeathMarkerRequest response)
	{
	}

	// Token: 0x060003E1 RID: 993 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E1")]
	[Address(RVA = "0x2B71EA0", Offset = "0x2B70EA0", VA = "0x182B71EA0")]
	private void EndDeathRoutine()
	{
	}

	// Token: 0x060003E2 RID: 994 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E2")]
	[Address(RVA = "0x2B71F30", Offset = "0x2B70F30", VA = "0x182B71F30")]
	private void EndSwimmingDeathRoutine()
	{
	}

	// Token: 0x060003E3 RID: 995 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E3")]
	[Address(RVA = "0x2B79B90", Offset = "0x2B78B90", VA = "0x182B79B90")]
	public void StartDrownWakeup()
	{
	}

	// Token: 0x060003E4 RID: 996 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E4")]
	[Address(RVA = "0x2B78E20", Offset = "0x2B77E20", VA = "0x182B78E20")]
	private void StartDeathRoutine(DeathType deathType)
	{
	}

	// Token: 0x060003E5 RID: 997 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E5")]
	[Address(RVA = "0x2B71B40", Offset = "0x2B70B40", VA = "0x182B71B40")]
	private void DoBasicDeath(bool respawnPrompt = true)
	{
	}

	// Token: 0x060003E6 RID: 998 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003E6")]
	[Address(RVA = "0x2B71C90", Offset = "0x2B70C90", VA = "0x182B71C90")]
	private IEnumerator DyingMpAudio()
	{
		return null;
	}

	// Token: 0x060003E7 RID: 999 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E7")]
	[Address(RVA = "0x2B7A120", Offset = "0x2B79120", VA = "0x182B7A120")]
	private void StopDyingMpAudio()
	{
	}

	// Token: 0x060003E8 RID: 1000 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E8")]
	[Address(RVA = "0x2B77AC0", Offset = "0x2B76AC0", VA = "0x182B77AC0")]
	private void PlayDeathRumble()
	{
	}

	// Token: 0x060003E9 RID: 1001 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003E9")]
	[Address(RVA = "0x2B72420", Offset = "0x2B71420", VA = "0x182B72420")]
	private static void FadeToBlack()
	{
	}

	// Token: 0x060003EA RID: 1002 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003EA")]
	[Address(RVA = "0x2B72350", Offset = "0x2B71350", VA = "0x182B72350")]
	private static void FadeFromBlack()
	{
	}

	// Token: 0x060003EB RID: 1003 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003EB")]
	[Address(RVA = "0x2B78BC0", Offset = "0x2B77BC0", VA = "0x182B78BC0")]
	public static void SetGameOverDelayTime(float value)
	{
	}

	// Token: 0x060003EC RID: 1004 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003EC")]
	[Address(RVA = "0x2B74F50", Offset = "0x2B73F50", VA = "0x182B74F50")]
	public void KillPlayer()
	{
	}

	// Token: 0x060003ED RID: 1005 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003ED")]
	[Address(RVA = "0x2B783F0", Offset = "0x2B773F0", VA = "0x182B783F0")]
	public void QuickKillPlayer()
	{
	}

	// Token: 0x060003EE RID: 1006 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003EE")]
	[Address(RVA = "0x2B74CC0", Offset = "0x2B73CC0", VA = "0x182B74CC0")]
	public void KillPlayerWithRespawnPrompt(bool quickNetwork)
	{
	}

	// Token: 0x060003EF RID: 1007 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003EF")]
	[Address(RVA = "0x2B75AC0", Offset = "0x2B74AC0", VA = "0x182B75AC0")]
	private void MultiplayerRespawn()
	{
	}

	// Token: 0x060003F0 RID: 1008 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003F0")]
	[Address(RVA = "0x2B75A50", Offset = "0x2B74A50", VA = "0x182B75A50")]
	private IEnumerator MultiplayerRespawnWorker()
	{
		return null;
	}

	// Token: 0x060003F1 RID: 1009 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F1")]
	[Address(RVA = "0x2B72690", Offset = "0x2B71690", VA = "0x182B72690")]
	private void FinalizeKillPlayer()
	{
	}

	// Token: 0x060003F2 RID: 1010 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F2")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void GameOver()
	{
	}

	// Token: 0x060003F3 RID: 1011 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F3")]
	[Address(RVA = "0x2B73270", Offset = "0x2B72270", VA = "0x182B73270")]
	public void HealedMp()
	{
	}

	// Token: 0x060003F4 RID: 1012 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60003F4")]
	[Address(RVA = "0x2B78730", Offset = "0x2B77730", VA = "0x182B78730")]
	private IEnumerator ResetPlayerFromHeal()
	{
		return null;
	}

	// Token: 0x060003F5 RID: 1013 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F5")]
	[Address(RVA = "0x2B78D10", Offset = "0x2B77D10", VA = "0x182B78D10")]
	public void SetPlayerDeathCount(int valueInt)
	{
	}

	// Token: 0x060003F6 RID: 1014 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F6")]
	[Address(RVA = "0x2B78B60", Offset = "0x2B77B60", VA = "0x182B78B60")]
	public void SetFinalDeath()
	{
	}

	// Token: 0x060003F7 RID: 1015 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F7")]
	[Address(RVA = "0x2B789E0", Offset = "0x2B779E0", VA = "0x182B789E0")]
	public void SetDyingState(PlayerStats.DyingState newState)
	{
	}

	// Token: 0x060003F8 RID: 1016 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F8")]
	[Address(RVA = "0x2B74F60", Offset = "0x2B73F60", VA = "0x182B74F60")]
	public void LogStats()
	{
	}

	// Token: 0x060003F9 RID: 1017 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003F9")]
	[Address(RVA = "0x2B785D0", Offset = "0x2B775D0", VA = "0x182B785D0")]
	public void Register(IHitReactReceiver receiver)
	{
	}

	// Token: 0x060003FA RID: 1018 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003FA")]
	[Address(RVA = "0x2B7A560", Offset = "0x2B79560", VA = "0x182B7A560")]
	public void Unregister(IHitReactReceiver receiver)
	{
	}

	// Token: 0x060003FB RID: 1019 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003FB")]
	[Address(RVA = "0x2B78810", Offset = "0x2B77810", VA = "0x182B78810")]
	private void SendHitReact()
	{
	}

	// Token: 0x060003FC RID: 1020 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60003FC")]
	[Address(RVA = "0x2B78D20", Offset = "0x2B77D20", VA = "0x182B78D20")]
	public void SetWetnessThermalRatingMultiplier(float value)
	{
	}

	// Token: 0x17000098 RID: 152
	// (get) Token: 0x060003FD RID: 1021 RVA: 0x000031F8 File Offset: 0x000013F8
	// (set) Token: 0x060003FE RID: 1022 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000098")]
	public bool IsCold
	{
		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x2B7D200", Offset = "0x2B7C200", VA = "0x182B7D200")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x2B7D410", Offset = "0x2B7C410", VA = "0x182B7D410")]
		set
		{
		}
	}

	// Token: 0x17000099 RID: 153
	// (get) Token: 0x060003FF RID: 1023 RVA: 0x00003210 File Offset: 0x00001410
	// (set) Token: 0x06000400 RID: 1024 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000099")]
	public bool InteriorSpaceWarmth
	{
		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x2B7D1C0", Offset = "0x2B7C1C0", VA = "0x182B7D1C0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000400")]
		[Address(RVA = "0x2B78DE0", Offset = "0x2B77DE0", VA = "0x182B78DE0")]
		set
		{
		}
	}

	// Token: 0x1700009A RID: 154
	// (get) Token: 0x06000401 RID: 1025 RVA: 0x00003228 File Offset: 0x00001428
	// (set) Token: 0x06000402 RID: 1026 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700009A")]
	public float ColdFactor
	{
		[Token(Token = "0x6000401")]
		[Address(RVA = "0x2B7D160", Offset = "0x2B7C160", VA = "0x182B7D160")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000402")]
		[Address(RVA = "0x2B7D3E0", Offset = "0x2B7C3E0", VA = "0x182B7D3E0")]
		set
		{
		}
	}

	// Token: 0x1700009B RID: 155
	// (get) Token: 0x06000403 RID: 1027 RVA: 0x00003240 File Offset: 0x00001440
	// (set) Token: 0x06000404 RID: 1028 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700009B")]
	public bool IsFreezing
	{
		[Token(Token = "0x6000403")]
		[Address(RVA = "0x2B7D230", Offset = "0x2B7C230", VA = "0x182B7D230")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000404")]
		[Address(RVA = "0x2B7D440", Offset = "0x2B7C440", VA = "0x182B7D440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x1700009C RID: 156
	// (get) Token: 0x06000405 RID: 1029 RVA: 0x00003258 File Offset: 0x00001458
	[Token(Token = "0x1700009C")]
	public float BodyTemperature
	{
		[Token(Token = "0x6000405")]
		[Address(RVA = "0x8C6190", Offset = "0x8C5190", VA = "0x1808C6190")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x1700009D RID: 157
	// (get) Token: 0x06000406 RID: 1030 RVA: 0x00003270 File Offset: 0x00001470
	[Token(Token = "0x1700009D")]
	public float ThermalRatingClamped
	{
		[Token(Token = "0x6000406")]
		[Address(RVA = "0x2B7D2A0", Offset = "0x2B7C2A0", VA = "0x182B7D2A0")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x06000407 RID: 1031 RVA: 0x00003288 File Offset: 0x00001488
	[Token(Token = "0x6000407")]
	[Address(RVA = "0x2B713E0", Offset = "0x2B703E0", VA = "0x182B713E0")]
	public float CalculateColdFactor()
	{
		return default(float);
	}

	// Token: 0x06000408 RID: 1032 RVA: 0x000032A0 File Offset: 0x000014A0
	[Token(Token = "0x6000408")]
	[Address(RVA = "0x2B72EE0", Offset = "0x2B71EE0", VA = "0x182B72EE0")]
	public float GetVitalityLostFromColdFactor()
	{
		return default(float);
	}

	// Token: 0x06000409 RID: 1033 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000409")]
	[Address(RVA = "0x2B7BFF0", Offset = "0x2B7AFF0", VA = "0x182B7BFF0", Slot = "6")]
	public void UpdateWetness(float wetnessCurrent)
	{
	}

	// Token: 0x0600040A RID: 1034 RVA: 0x000032B8 File Offset: 0x000014B8
	[Token(Token = "0x600040A")]
	[Address(RVA = "0x2B72F10", Offset = "0x2B71F10", VA = "0x182B72F10")]
	public float GetWetness()
	{
		return default(float);
	}

	// Token: 0x0600040B RID: 1035 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600040B")]
	[Address(RVA = "0x2B75A10", Offset = "0x2B74A10", VA = "0x182B75A10")]
	public void ModifyThermalRating(float value)
	{
	}

	// Token: 0x0600040C RID: 1036 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600040C")]
	[Address(RVA = "0x2B7B660", Offset = "0x2B7A660", VA = "0x182B7B660")]
	private void UpdateTemperature()
	{
	}

	// Token: 0x0600040D RID: 1037 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600040D")]
	[Address(RVA = "0x2B76880", Offset = "0x2B75880", VA = "0x182B76880", Slot = "9")]
	public void OnEnteredTemperatureVolume(float temperatureCelsius)
	{
	}

	// Token: 0x0600040E RID: 1038 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600040E")]
	[Address(RVA = "0x2B76880", Offset = "0x2B75880", VA = "0x182B76880", Slot = "10")]
	public void OnStayedTemperatureVolume(float temperatureCelsius)
	{
	}

	// Token: 0x0600040F RID: 1039 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600040F")]
	[Address(RVA = "0x2B76890", Offset = "0x2B75890", VA = "0x182B76890", Slot = "11")]
	public void OnExitedTemperatureVolume(float temperatureCelsius)
	{
	}

	// Token: 0x06000410 RID: 1040 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000410")]
	[Address(RVA = "0x2B78DE0", Offset = "0x2B77DE0", VA = "0x182B78DE0", Slot = "12")]
	private void OnWarmthChange(bool isWarm)
	{
	}

	// Token: 0x06000411 RID: 1041 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000411")]
	[Address(RVA = "0x2B78400", Offset = "0x2B77400", VA = "0x182B78400")]
	public static void RegisterBeachMarker(Transform source)
	{
	}

	// Token: 0x06000412 RID: 1042 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000412")]
	[Address(RVA = "0x2B7A470", Offset = "0x2B79470", VA = "0x182B7A470")]
	public static void UnregisterBeachMarker(Transform source)
	{
	}

	// Token: 0x06000413 RID: 1043 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000413")]
	[Address(RVA = "0x2B72C50", Offset = "0x2B71C50", VA = "0x182B72C50")]
	private Transform GetClosestDrownMarker()
	{
		return null;
	}

	// Token: 0x06000414 RID: 1044 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000414")]
	[Address(RVA = "0x2B7CBD0", Offset = "0x2B7BBD0", VA = "0x182B7CBD0")]
	public IEnumerator WakeUpOnBeachCutScene()
	{
		return null;
	}

	// Token: 0x06000415 RID: 1045 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000415")]
	[Address(RVA = "0x2B7CC80", Offset = "0x2B7BC80", VA = "0x182B7CC80")]
	public PlayerStats()
	{
	}

	// Token: 0x04000325 RID: 805
	[Token(Token = "0x4000325")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _comfortRating;

	// Token: 0x04000326 RID: 806
	[Token(Token = "0x4000326")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[Min(0f)]
	private float _hardSurvivalConsumablePositiveMultiplier;

	// Token: 0x04000327 RID: 807
	[Token(Token = "0x4000327")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Min(0f)]
	private float _hardSurvivalConsumableNegativeMultiplier;

	// Token: 0x04000328 RID: 808
	[Token(Token = "0x4000328")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float _hardSettingStatsDamageMultiplier;

	// Token: 0x04000329 RID: 809
	[Token(Token = "0x4000329")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float _starvationDamagePerTick;

	// Token: 0x0400032A RID: 810
	[Token(Token = "0x400032A")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float _dehydrationDamagePerTick;

	// Token: 0x0400032B RID: 811
	[Token(Token = "0x400032B")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[FormerlySerializedAs("_timeBetweenStatDamageTicks")]
	private float _gameSecondsBetweenStatDamageTicks;

	// Token: 0x0400032C RID: 812
	[Token(Token = "0x400032C")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Min(0f)]
	private float _energyLostFromLogs;

	// Token: 0x0400032D RID: 813
	[Token(Token = "0x400032D")]
	[FieldOffset(Offset = "0x40")]
	[Min(0f)]
	[SerializeField]
	private float _energyLostFromCold;

	// Token: 0x0400032E RID: 814
	[Token(Token = "0x400032E")]
	[FieldOffset(Offset = "0x44")]
	[Min(0f)]
	[HideInInspector]
	[SerializeField]
	private float _energyLostFromFreezing;

	// Token: 0x0400032F RID: 815
	[Token(Token = "0x400032F")]
	[FieldOffset(Offset = "0x48")]
	[Min(0f)]
	[SerializeField]
	private float _energyLostFromHunger;

	// Token: 0x04000330 RID: 816
	[Token(Token = "0x4000330")]
	[FieldOffset(Offset = "0x4C")]
	[Min(0f)]
	[HideInInspector]
	[SerializeField]
	private float _energyLostFromStarvation;

	// Token: 0x04000331 RID: 817
	[Token(Token = "0x4000331")]
	[FieldOffset(Offset = "0x50")]
	[Min(0f)]
	[SerializeField]
	private float _energyLostFromThirst;

	// Token: 0x04000332 RID: 818
	[Token(Token = "0x4000332")]
	[FieldOffset(Offset = "0x54")]
	[HideInInspector]
	[Min(0f)]
	[SerializeField]
	private float _energyLostFromDehydration;

	// Token: 0x04000333 RID: 819
	[Token(Token = "0x4000333")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	[Tooltip("Increasing this value means that less energy is consumed. If set to 1, and at max comfort, no energy is lost.")]
	[Range(0f, 1f)]
	private float _comfortEnergyLossModifier;

	// Token: 0x04000334 RID: 820
	[Token(Token = "0x4000334")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private float _stealthRating;

	// Token: 0x04000335 RID: 821
	[Token(Token = "0x4000335")]
	[FieldOffset(Offset = "0x60")]
	private float _timeUntilNextStatDamageTick;

	// Token: 0x04000336 RID: 822
	[Token(Token = "0x4000336")]
	[FieldOffset(Offset = "0x68")]
	private SurvivalSetting _playerStatsDamageSetting;

	// Token: 0x04000337 RID: 823
	[Token(Token = "0x4000337")]
	[FieldOffset(Offset = "0x78")]
	[Range(0f, 1f)]
	public float _requiredDepthToBeConsideredInSnow;

	// Token: 0x04000338 RID: 824
	[Token(Token = "0x4000338")]
	[FieldOffset(Offset = "0x7C")]
	public float SoundRangeDampFactor;

	// Token: 0x04000339 RID: 825
	[Token(Token = "0x4000339")]
	[FieldOffset(Offset = "0x80")]
	public float Flammable;

	// Token: 0x0400033A RID: 826
	[Token(Token = "0x400033A")]
	[FieldOffset(Offset = "0x84")]
	public float DaySurvived;

	// Token: 0x0400033B RID: 827
	[Token(Token = "0x400033B")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	[Header("Effects")]
	private PlayerEffects _playerEffects;

	// Token: 0x0400033C RID: 828
	[Token(Token = "0x400033C")]
	[FieldOffset(Offset = "0x90")]
	[Header("Rumble")]
	public float HitRumbleStrength;

	// Token: 0x0400033D RID: 829
	[Token(Token = "0x400033D")]
	[FieldOffset(Offset = "0x94")]
	public float HitRumbleDuration;

	// Token: 0x0400033E RID: 830
	[Token(Token = "0x400033E")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	[EventRef]
	private string GaspForAirEvent;

	// Token: 0x0400033F RID: 831
	[Token(Token = "0x400033F")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	[EventRef]
	private string DrowningEvent;

	// Token: 0x04000340 RID: 832
	[Token(Token = "0x4000340")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	[EventRef]
	private string DyingEvent;

	// Token: 0x04000341 RID: 833
	[Token(Token = "0x4000341")]
	[FieldOffset(Offset = "0xB0")]
	[SerializeField]
	[EventRef]
	private string ExtinguishEvent;

	// Token: 0x04000342 RID: 834
	[Token(Token = "0x4000342")]
	[FieldOffset(Offset = "0xB8")]
	[EventRef]
	[SerializeField]
	private string ApplyMudEvent;

	// Token: 0x04000343 RID: 835
	[Token(Token = "0x4000343")]
	[FieldOffset(Offset = "0xC0")]
	[EventRef]
	[SerializeField]
	private string _staminaBreathEvent;

	// Token: 0x04000344 RID: 836
	[Token(Token = "0x4000344")]
	[FieldOffset(Offset = "0xC8")]
	[SerializeField]
	private float _staminaRecoverRate;

	// Token: 0x04000345 RID: 837
	[Token(Token = "0x4000345")]
	[FieldOffset(Offset = "0xCC")]
	[SerializeField]
	private float _jumpStaminaCost;

	// Token: 0x04000346 RID: 838
	[Token(Token = "0x4000346")]
	[FieldOffset(Offset = "0xD0")]
	[SerializeField]
	private PlayerArmBlood _leftArmBlood;

	// Token: 0x04000347 RID: 839
	[Token(Token = "0x4000347")]
	[FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private PlayerArmBlood _rightArmBlood;

	// Token: 0x0400034A RID: 842
	[Token(Token = "0x400034A")]
	[FieldOffset(Offset = "0xE4")]
	private float _currentEnergyDrain;

	// Token: 0x0400034B RID: 843
	[Token(Token = "0x400034B")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	private BloodAndColdScreenOverlay _bloodAndColdEffects;

	// Token: 0x0400034C RID: 844
	[Token(Token = "0x400034C")]
	[FieldOffset(Offset = "0xF0")]
	[SerializeField]
	private DamageController _damageController;

	// Token: 0x0400034D RID: 845
	[Token(Token = "0x400034D")]
	[FieldOffset(Offset = "0xF8")]
	private PlayerInventory _inventory;

	// Token: 0x0400034E RID: 846
	[Token(Token = "0x400034E")]
	[FieldOffset(Offset = "0x100")]
	private bool _doGotCleanCheck;

	// Token: 0x0400034F RID: 847
	[Token(Token = "0x400034F")]
	[FieldOffset(Offset = "0x101")]
	private bool _isHealing;

	// Token: 0x04000350 RID: 848
	[Token(Token = "0x4000350")]
	[FieldOffset(Offset = "0x102")]
	private bool _checkingIfBloody;

	// Token: 0x04000351 RID: 849
	[Token(Token = "0x4000351")]
	[FieldOffset(Offset = "0x103")]
	private bool _isSeated;

	// Token: 0x04000352 RID: 850
	[Token(Token = "0x4000352")]
	[FieldOffset(Offset = "0x104")]
	private bool _isExplode;

	// Token: 0x04000353 RID: 851
	[Token(Token = "0x4000353")]
	[FieldOffset(Offset = "0x105")]
	private bool _doneDragScene;

	// Token: 0x04000354 RID: 852
	[Token(Token = "0x4000354")]
	[FieldOffset(Offset = "0x108")]
	private float _trapHitCoolDown;

	// Token: 0x04000355 RID: 853
	[Token(Token = "0x4000355")]
	[FieldOffset(Offset = "0x10C")]
	private float _nextAdrenalineRush;

	// Token: 0x04000356 RID: 854
	[Token(Token = "0x4000356")]
	[FieldOffset(Offset = "0x110")]
	private float _tired;

	// Token: 0x04000357 RID: 855
	[Token(Token = "0x4000357")]
	[FieldOffset(Offset = "0x114")]
	private bool _reloadedFromRespawn;

	// Token: 0x04000358 RID: 856
	[Token(Token = "0x4000358")]
	[FieldOffset(Offset = "0x118")]
	private PlayerSfx _sfx;

	// Token: 0x04000359 RID: 857
	[Token(Token = "0x4000359")]
	[FieldOffset(Offset = "0x120")]
	private float _externalWetnessLevel;

	// Token: 0x0400035A RID: 858
	[Token(Token = "0x400035A")]
	[FieldOffset(Offset = "0x128")]
	private Animator _animator;

	// Token: 0x0400035B RID: 859
	[Token(Token = "0x400035B")]
	[FieldOffset(Offset = "0x130")]
	private playerHitReactions _hitReactions;

	// Token: 0x0400035C RID: 860
	[Token(Token = "0x400035C")]
	[FieldOffset(Offset = "0x138")]
	private camFollowHead _cameraFollow;

	// Token: 0x0400035D RID: 861
	[Token(Token = "0x400035D")]
	[FieldOffset(Offset = "0x140")]
	private Vitals _vitals;

	// Token: 0x0400035E RID: 862
	[Token(Token = "0x400035E")]
	[FieldOffset(Offset = "0x148")]
	private bool _weatherSystemRegistered;

	// Token: 0x0400035F RID: 863
	[Token(Token = "0x400035F")]
	[FieldOffset(Offset = "0x150")]
	private PlayerLocation _playerLocation;

	// Token: 0x04000360 RID: 864
	[Token(Token = "0x4000360")]
	[FieldOffset(Offset = "0x158")]
	[SerializeField]
	private PlayerArmourSystem _armourSystem;

	// Token: 0x04000361 RID: 865
	[Token(Token = "0x4000361")]
	[FieldOffset(Offset = "0x160")]
	private float _staminaActionTime;

	// Token: 0x04000362 RID: 866
	[Token(Token = "0x4000362")]
	[FieldOffset(Offset = "0x168")]
	private EventInstance _dyingSfxEvent;

	// Token: 0x04000363 RID: 867
	[Token(Token = "0x4000363")]
	[FieldOffset(Offset = "0x170")]
	private EventInstance _drowningSfxEvent;

	// Token: 0x04000364 RID: 868
	[Token(Token = "0x4000364")]
	[FieldOffset(Offset = "0x178")]
	private EventInstance _fireExtinguishSfxEvent;

	// Token: 0x04000365 RID: 869
	[Token(Token = "0x4000365")]
	[FieldOffset(Offset = "0x180")]
	private EventInstance _staminaBreathInstance;

	// Token: 0x04000366 RID: 870
	[Token(Token = "0x4000366")]
	[FieldOffset(Offset = "0x188")]
	private readonly int _explodeAnimatorHash;

	// Token: 0x04000367 RID: 871
	[Token(Token = "0x4000367")]
	[FieldOffset(Offset = "0x18C")]
	private readonly int _enterCaveAnimatorHash;

	// Token: 0x04000368 RID: 872
	[Token(Token = "0x4000368")]
	[FieldOffset(Offset = "0x190")]
	private readonly int _eatMeatAnimatorHash;

	// Token: 0x04000369 RID: 873
	[Token(Token = "0x4000369")]
	private const string HitSmallRumbleProfileId = "PlayerHitSmall";

	// Token: 0x0400036A RID: 874
	[Token(Token = "0x400036A")]
	private const string HitMedRumbleProfileId = "PlayerHitMed";

	// Token: 0x0400036B RID: 875
	[Token(Token = "0x400036B")]
	private const string HitLargeRumbleProfileId = "PlayerHitLarge";

	// Token: 0x0400036C RID: 876
	[Token(Token = "0x400036C")]
	private const string HealthParamName = "health";

	// Token: 0x0400036D RID: 877
	[Token(Token = "0x400036D")]
	[FieldOffset(Offset = "0x198")]
	private Coroutine checkItemRoutine;

	// Token: 0x0400036E RID: 878
	[Token(Token = "0x400036E")]
	[FieldOffset(Offset = "0x1A0")]
	private BoltEntity _playerEntityCache;

	// Token: 0x0400036F RID: 879
	[Token(Token = "0x400036F")]
	[FieldOffset(Offset = "0x1A8")]
	private IPlayerState _playerStateCache;

	// Token: 0x04000370 RID: 880
	[Token(Token = "0x4000370")]
	private const string PlayerDeathRumbleProfileId = "PlayerDeath";

	// Token: 0x04000371 RID: 881
	[Token(Token = "0x4000371")]
	private const string MultiplayerRespawnElementId = "multiplayer.respawn";

	// Token: 0x04000372 RID: 882
	[Token(Token = "0x4000372")]
	[FieldOffset(Offset = "0x1B0")]
	[SerializeField]
	private Transform _deathSpawnItemsLocator;

	// Token: 0x04000373 RID: 883
	[Token(Token = "0x4000373")]
	[FieldOffset(Offset = "0x1B8")]
	[SerializeField]
	private UnityEvent _onDeath;

	// Token: 0x04000374 RID: 884
	[Token(Token = "0x4000374")]
	[FieldOffset(Offset = "0x1C0")]
	[EventRef]
	[SerializeField]
	private string _playerDownIntroEvent;

	// Token: 0x04000375 RID: 885
	[Token(Token = "0x4000375")]
	[FieldOffset(Offset = "0x1C8")]
	[SerializeField]
	[EventRef]
	private string _playerDownLoopEvent;

	// Token: 0x04000376 RID: 886
	[Token(Token = "0x4000376")]
	[FieldOffset(Offset = "0x1D0")]
	private int _playerDeathCount;

	// Token: 0x04000377 RID: 887
	[Token(Token = "0x4000377")]
	[FieldOffset(Offset = "0x0")]
	private static bool _blockFinalDeath;

	// Token: 0x04000378 RID: 888
	[Token(Token = "0x4000378")]
	[FieldOffset(Offset = "0x1D8")]
	private readonly ILayerBehaviourActivator[] _getupLayerBehaviourActivators;

	// Token: 0x04000379 RID: 889
	[Token(Token = "0x4000379")]
	[FieldOffset(Offset = "0x1E0")]
	private PlayerStats.DyingState _dyingState;

	// Token: 0x0400037A RID: 890
	[Token(Token = "0x400037A")]
	[FieldOffset(Offset = "0x1E4")]
	private bool _debugInstantRespawn;

	// Token: 0x0400037B RID: 891
	[Token(Token = "0x400037B")]
	[FieldOffset(Offset = "0x1E8")]
	private Vector3 _instantRespawnPosition;

	// Token: 0x0400037C RID: 892
	[Token(Token = "0x400037C")]
	[FieldOffset(Offset = "0x4")]
	private static float _gameOverDelayTime;

	// Token: 0x0400037D RID: 893
	[Token(Token = "0x400037D")]
	[FieldOffset(Offset = "0x1F4")]
	private DeathType _deathType;

	// Token: 0x0400037E RID: 894
	[Token(Token = "0x400037E")]
	[FieldOffset(Offset = "0x1F8")]
	private MultiplayerRespawnTimer _mpRespawnTimerGui;

	// Token: 0x0400037F RID: 895
	[Token(Token = "0x400037F")]
	[FieldOffset(Offset = "0x200")]
	private bool _doFinalDeath;

	// Token: 0x04000380 RID: 896
	[Token(Token = "0x4000380")]
	[FieldOffset(Offset = "0x208")]
	private EventInstance _playerDownLoopEventInstance;

	// Token: 0x04000381 RID: 897
	[Token(Token = "0x4000381")]
	[FieldOffset(Offset = "0x210")]
	private Coroutine _dyingMpAudioCoroutine;

	// Token: 0x04000382 RID: 898
	[Token(Token = "0x4000382")]
	[FieldOffset(Offset = "0x218")]
	private bool _respawning;

	// Token: 0x04000383 RID: 899
	[Token(Token = "0x4000383")]
	[FieldOffset(Offset = "0x21C")]
	private int _maxDeathCount;

	// Token: 0x04000384 RID: 900
	[Token(Token = "0x4000384")]
	[FieldOffset(Offset = "0x220")]
	private readonly List<IHitReactReceiver> _hitReactReceivers;

	// Token: 0x04000385 RID: 901
	[Token(Token = "0x4000385")]
	[FieldOffset(Offset = "0x228")]
	[SerializeField]
	private bool _isOnFire;

	// Token: 0x04000386 RID: 902
	[Token(Token = "0x4000386")]
	[FieldOffset(Offset = "0x22C")]
	[SerializeField]
	private float _thermalRating;

	// Token: 0x04000387 RID: 903
	[Token(Token = "0x4000387")]
	[FieldOffset(Offset = "0x230")]
	[SerializeField]
	[Tooltip("This is the amount a thermal rating of 1 would protect by. Example: A protection of 15 would make -15 degrees feel like 0")]
	private float _maxTempBoostFromThermalRating;

	// Token: 0x04000388 RID: 904
	[Token(Token = "0x4000388")]
	[FieldOffset(Offset = "0x234")]
	[SerializeField]
	private float _bodyTemperature;

	// Token: 0x04000389 RID: 905
	[Token(Token = "0x4000389")]
	[FieldOffset(Offset = "0x238")]
	[SerializeField]
	private float _coldAtTemperature;

	// Token: 0x0400038A RID: 906
	[Token(Token = "0x400038A")]
	[FieldOffset(Offset = "0x23C")]
	[SerializeField]
	private float _freezeAtTemperature;

	// Token: 0x0400038B RID: 907
	[Token(Token = "0x400038B")]
	[FieldOffset(Offset = "0x240")]
	[SerializeField]
	private float _shiverAnimBlendSpeed;

	// Token: 0x0400038C RID: 908
	[Token(Token = "0x400038C")]
	[FieldOffset(Offset = "0x244")]
	[SerializeField]
	private float _blendSpeedOfTemperatureVolumeModifiers;

	// Token: 0x0400038D RID: 909
	[Token(Token = "0x400038D")]
	[FieldOffset(Offset = "0x248")]
	[SerializeField]
	private float _waterResistRating;

	// Token: 0x0400038E RID: 910
	[Token(Token = "0x400038E")]
	[FieldOffset(Offset = "0x24C")]
	[Tooltip("The rate at which the player will get waterlogged.")]
	[Range(0f, 10f)]
	[SerializeField]
	private float _waterSoakInRate;

	// Token: 0x0400038F RID: 911
	[Token(Token = "0x400038F")]
	[FieldOffset(Offset = "0x250")]
	[Tooltip("The rate at which the player will dry off.")]
	[Range(0f, 10f)]
	[SerializeField]
	private float _waterDryOffRate;

	// Token: 0x04000390 RID: 912
	[Token(Token = "0x4000390")]
	[FieldOffset(Offset = "0x254")]
	[SerializeField]
	private float _maxTempDropFromWetness;

	// Token: 0x04000391 RID: 913
	[Token(Token = "0x4000391")]
	[FieldOffset(Offset = "0x258")]
	[Min(0f)]
	[SerializeField]
	private float _maxDryOffTemperature;

	// Token: 0x04000392 RID: 914
	[Token(Token = "0x4000392")]
	[FieldOffset(Offset = "0x25C")]
	private float _wetnessAffectsThermalRatingMultiplier;

	// Token: 0x04000393 RID: 915
	[Token(Token = "0x4000393")]
	[FieldOffset(Offset = "0x260")]
	private float _airTemperature;

	// Token: 0x04000394 RID: 916
	[Token(Token = "0x4000394")]
	[FieldOffset(Offset = "0x264")]
	private float _currentTempBoostFromThermalRating;

	// Token: 0x04000395 RID: 917
	[Token(Token = "0x4000395")]
	[FieldOffset(Offset = "0x268")]
	private float _currentTempDropFromWetness;

	// Token: 0x04000396 RID: 918
	[Token(Token = "0x4000396")]
	[FieldOffset(Offset = "0x26C")]
	private float _temperatureModifierVolumeTemperature;

	// Token: 0x04000397 RID: 919
	[Token(Token = "0x4000397")]
	[FieldOffset(Offset = "0x270")]
	private float _currentModifiedTemperatureBlendDelta;

	// Token: 0x04000398 RID: 920
	[Token(Token = "0x4000398")]
	[FieldOffset(Offset = "0x274")]
	private bool _insideTemperatureModifierVolume;

	// Token: 0x04000399 RID: 921
	[Token(Token = "0x4000399")]
	[FieldOffset(Offset = "0x278")]
	[Range(0f, 1f)]
	private float _currentWetness;

	// Token: 0x0400039A RID: 922
	[Token(Token = "0x400039A")]
	[FieldOffset(Offset = "0x27C")]
	private float _shiverAnimBlendDelta;

	// Token: 0x0400039B RID: 923
	[Token(Token = "0x400039B")]
	[FieldOffset(Offset = "0x280")]
	private float _thermalRatingAfterWetnessPenalty;

	// Token: 0x0400039D RID: 925
	[Token(Token = "0x400039D")]
	[FieldOffset(Offset = "0x8")]
	private static List<Transform> _beachMarkers;

	// Token: 0x02000079 RID: 121
	[Token(Token = "0x2000079")]
	public enum DyingState
	{
		// Token: 0x0400039F RID: 927
		[Token(Token = "0x400039F")]
		Alive,
		// Token: 0x040003A0 RID: 928
		[Token(Token = "0x40003A0")]
		Dying,
		// Token: 0x040003A1 RID: 929
		[Token(Token = "0x40003A1")]
		Dead
	}
}
