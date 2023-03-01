using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Player;
using Sons.StatSystem;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x02000087 RID: 135
[Token(Token = "0x2000087")]
public class Vitals : MonoBehaviour
{
	// Token: 0x170000AE RID: 174
	// (get) Token: 0x06000451 RID: 1105 RVA: 0x000033A8 File Offset: 0x000015A8
	[Token(Token = "0x170000AE")]
	public bool IsCold
	{
		[Token(Token = "0x6000451")]
		[Address(RVA = "0x8C5EC0", Offset = "0x8C4EC0", VA = "0x1808C5EC0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170000AF RID: 175
	// (get) Token: 0x06000452 RID: 1106 RVA: 0x000033C0 File Offset: 0x000015C0
	[Token(Token = "0x170000AF")]
	public float ColdFactor
	{
		[Token(Token = "0x6000452")]
		[Address(RVA = "0x2397C80", Offset = "0x2396C80", VA = "0x182397C80")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x06000453 RID: 1107 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000453")]
	[Address(RVA = "0x2D57190", Offset = "0x2D56190", VA = "0x182D57190")]
	public void SetIsCold(bool value)
	{
	}

	// Token: 0x06000454 RID: 1108 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000454")]
	[Address(RVA = "0x267BB80", Offset = "0x267AB80", VA = "0x18267BB80")]
	public void SetColdFactor(float value)
	{
	}

	// Token: 0x170000B0 RID: 176
	// (get) Token: 0x06000455 RID: 1109 RVA: 0x000033D8 File Offset: 0x000015D8
	[Token(Token = "0x170000B0")]
	public bool InteriorSpaceWarmth
	{
		[Token(Token = "0x6000455")]
		[Address(RVA = "0x2D58240", Offset = "0x2D57240", VA = "0x182D58240")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000456 RID: 1110 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000456")]
	[Address(RVA = "0x2D57160", Offset = "0x2D56160", VA = "0x182D57160")]
	public void SetInteriorSpaceWarmth(bool value)
	{
	}

	// Token: 0x06000457 RID: 1111 RVA: 0x000033F0 File Offset: 0x000015F0
	[Token(Token = "0x6000457")]
	[Address(RVA = "0x2D560D0", Offset = "0x2D550D0", VA = "0x182D560D0")]
	public float GetVitalityLostFromColdFactor()
	{
		return default(float);
	}

	// Token: 0x06000458 RID: 1112 RVA: 0x00003408 File Offset: 0x00001608
	[Token(Token = "0x6000458")]
	[Address(RVA = "0x2D56120", Offset = "0x2D55120", VA = "0x182D56120")]
	public float GetVitalityLostFromCold()
	{
		return default(float);
	}

	// Token: 0x170000B1 RID: 177
	// (get) Token: 0x06000459 RID: 1113 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000B1")]
	private StrengthStat Strength
	{
		[Token(Token = "0x6000459")]
		[Address(RVA = "0x2D584B0", Offset = "0x2D574B0", VA = "0x182D584B0")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000B2 RID: 178
	// (get) Token: 0x0600045A RID: 1114 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000B2")]
	private VitalityStat Vitality
	{
		[Token(Token = "0x600045A")]
		[Address(RVA = "0x2D585D0", Offset = "0x2D575D0", VA = "0x182D585D0")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000B3 RID: 179
	// (get) Token: 0x0600045B RID: 1115 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000B3")]
	private HealthStat Health
	{
		[Token(Token = "0x600045B")]
		[Address(RVA = "0x2D58120", Offset = "0x2D57120", VA = "0x182D58120")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000B4 RID: 180
	// (get) Token: 0x0600045C RID: 1116 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000B4")]
	private StaminaStat Stamina
	{
		[Token(Token = "0x600045C")]
		[Address(RVA = "0x2D58420", Offset = "0x2D57420", VA = "0x182D58420")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000B5 RID: 181
	// (get) Token: 0x0600045D RID: 1117 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000B5")]
	private HydrationStat Hydration
	{
		[Token(Token = "0x600045D")]
		[Address(RVA = "0x2D581B0", Offset = "0x2D571B0", VA = "0x182D581B0")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000B6 RID: 182
	// (get) Token: 0x0600045E RID: 1118 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000B6")]
	private FullnessStat Fullness
	{
		[Token(Token = "0x600045E")]
		[Address(RVA = "0x2D58010", Offset = "0x2D57010", VA = "0x182D58010")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000B7 RID: 183
	// (get) Token: 0x0600045F RID: 1119 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000B7")]
	private RestedStat Rested
	{
		[Token(Token = "0x600045F")]
		[Address(RVA = "0x2D58390", Offset = "0x2D57390", VA = "0x182D58390")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000B8 RID: 184
	// (get) Token: 0x06000460 RID: 1120 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000B8")]
	private TemperatureStat Temperature
	{
		[Token(Token = "0x6000460")]
		[Address(RVA = "0x2D58540", Offset = "0x2D57540", VA = "0x182D58540")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000461 RID: 1121 RVA: 0x00003420 File Offset: 0x00001620
	[Token(Token = "0x6000461")]
	[Address(RVA = "0x2D56040", Offset = "0x2D55040", VA = "0x182D56040")]
	public float GetStrength()
	{
		return default(float);
	}

	// Token: 0x06000462 RID: 1122 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000462")]
	[Address(RVA = "0x2D57470", Offset = "0x2D56470", VA = "0x182D57470")]
	public void SetStrength(float value)
	{
	}

	// Token: 0x06000463 RID: 1123 RVA: 0x00003438 File Offset: 0x00001638
	[Token(Token = "0x6000463")]
	[Address(RVA = "0x2D56010", Offset = "0x2D55010", VA = "0x182D56010")]
	public float GetStrengthFactor()
	{
		return default(float);
	}

	// Token: 0x170000B9 RID: 185
	// (get) Token: 0x06000464 RID: 1124 RVA: 0x00003450 File Offset: 0x00001650
	[Token(Token = "0x170000B9")]
	public int CurrentStrengthLevel
	{
		[Token(Token = "0x6000464")]
		[Address(RVA = "0x5F1A10", Offset = "0x5F0A10", VA = "0x1805F1A10")]
		get
		{
			return default(int);
		}
	}

	// Token: 0x06000465 RID: 1125 RVA: 0x00003468 File Offset: 0x00001668
	[Token(Token = "0x6000465")]
	[Address(RVA = "0x2D56130", Offset = "0x2D55130", VA = "0x182D56130")]
	public float GetVitality()
	{
		return default(float);
	}

	// Token: 0x06000466 RID: 1126 RVA: 0x00003480 File Offset: 0x00001680
	[Token(Token = "0x6000466")]
	[Address(RVA = "0x2D55D50", Offset = "0x2D54D50", VA = "0x182D55D50")]
	public float GetResolvedMaxVitality()
	{
		return default(float);
	}

	// Token: 0x06000467 RID: 1127 RVA: 0x00003498 File Offset: 0x00001698
	[Token(Token = "0x6000467")]
	[Address(RVA = "0x2D55CD0", Offset = "0x2D54CD0", VA = "0x182D55CD0")]
	public float GetMaxVitalityFactor()
	{
		return default(float);
	}

	// Token: 0x06000468 RID: 1128 RVA: 0x000034B0 File Offset: 0x000016B0
	[Token(Token = "0x6000468")]
	[Address(RVA = "0x2D560A0", Offset = "0x2D550A0", VA = "0x182D560A0")]
	public float GetVitalityFactor()
	{
		return default(float);
	}

	// Token: 0x06000469 RID: 1129 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000469")]
	[Address(RVA = "0x2D56FC0", Offset = "0x2D55FC0", VA = "0x182D56FC0")]
	public void SetFullVitality()
	{
	}

	// Token: 0x0600046A RID: 1130 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600046A")]
	[Address(RVA = "0x2D574B0", Offset = "0x2D564B0", VA = "0x182D574B0")]
	public void SetVitality(float value)
	{
	}

	// Token: 0x0600046B RID: 1131 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600046B")]
	[Address(RVA = "0x2D556A0", Offset = "0x2D546A0", VA = "0x182D556A0")]
	public void GainVitality(float value)
	{
	}

	// Token: 0x0600046C RID: 1132 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600046C")]
	[Address(RVA = "0x2D57720", Offset = "0x2D56720", VA = "0x182D57720")]
	public void SpendVitality(float value)
	{
	}

	// Token: 0x0600046D RID: 1133 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600046D")]
	[Address(RVA = "0x2D54FF0", Offset = "0x2D53FF0", VA = "0x182D54FF0")]
	public void CalculateVitality()
	{
	}

	// Token: 0x0600046E RID: 1134 RVA: 0x000034C8 File Offset: 0x000016C8
	[Token(Token = "0x600046E")]
	[Address(RVA = "0x2D55CB0", Offset = "0x2D54CB0", VA = "0x182D55CB0")]
	public float GetMaxHealth()
	{
		return default(float);
	}

	// Token: 0x0600046F RID: 1135 RVA: 0x000034E0 File Offset: 0x000016E0
	[Token(Token = "0x600046F")]
	[Address(RVA = "0x2D55C40", Offset = "0x2D54C40", VA = "0x182D55C40")]
	public float GetHealth()
	{
		return default(float);
	}

	// Token: 0x06000470 RID: 1136 RVA: 0x000034F8 File Offset: 0x000016F8
	[Token(Token = "0x6000470")]
	[Address(RVA = "0x2D55C10", Offset = "0x2D54C10", VA = "0x182D55C10")]
	public float GetHealthFactor()
	{
		return default(float);
	}

	// Token: 0x06000471 RID: 1137 RVA: 0x00003510 File Offset: 0x00001710
	[Token(Token = "0x6000471")]
	[Address(RVA = "0x2D56060", Offset = "0x2D55060", VA = "0x182D56060")]
	public float GetTargetHealthFactor()
	{
		return default(float);
	}

	// Token: 0x06000472 RID: 1138 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000472")]
	[Address(RVA = "0x2D56EF0", Offset = "0x2D55EF0", VA = "0x182D56EF0")]
	public void SetFullHealth()
	{
	}

	// Token: 0x06000473 RID: 1139 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000473")]
	[Address(RVA = "0x2D57080", Offset = "0x2D56080", VA = "0x182D57080")]
	public void SetHealth(float value)
	{
	}

	// Token: 0x06000474 RID: 1140 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000474")]
	[Address(RVA = "0x2D54C20", Offset = "0x2D53C20", VA = "0x182D54C20")]
	public void ApplyHealing(float value)
	{
	}

	// Token: 0x06000475 RID: 1141 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000475")]
	[Address(RVA = "0x2D54BC0", Offset = "0x2D53BC0", VA = "0x182D54BC0")]
	public void ApplyDamage(float value)
	{
	}

	// Token: 0x06000476 RID: 1142 RVA: 0x00003528 File Offset: 0x00001728
	[Token(Token = "0x6000476")]
	[Address(RVA = "0x2D56660", Offset = "0x2D55660", VA = "0x182D56660")]
	public bool IsHealing()
	{
		return default(bool);
	}

	// Token: 0x170000BA RID: 186
	// (get) Token: 0x06000477 RID: 1143 RVA: 0x00003540 File Offset: 0x00001740
	[Token(Token = "0x170000BA")]
	public bool IsLowHealth
	{
		[Token(Token = "0x6000477")]
		[Address(RVA = "0x2D582C0", Offset = "0x2D572C0", VA = "0x182D582C0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000478 RID: 1144 RVA: 0x00003558 File Offset: 0x00001758
	[Token(Token = "0x6000478")]
	[Address(RVA = "0x2D56640", Offset = "0x2D55640", VA = "0x182D56640")]
	public bool IsAlive()
	{
		return default(bool);
	}

	// Token: 0x06000479 RID: 1145 RVA: 0x00003570 File Offset: 0x00001770
	[Token(Token = "0x6000479")]
	[Address(RVA = "0x2D561D0", Offset = "0x2D551D0", VA = "0x182D561D0")]
	public bool HasDied()
	{
		return default(bool);
	}

	// Token: 0x0600047A RID: 1146 RVA: 0x00003588 File Offset: 0x00001788
	[Token(Token = "0x600047A")]
	[Address(RVA = "0x2D561E0", Offset = "0x2D551E0", VA = "0x182D561E0")]
	public bool HasHealth()
	{
		return default(bool);
	}

	// Token: 0x170000BB RID: 187
	// (get) Token: 0x0600047B RID: 1147 RVA: 0x000035A0 File Offset: 0x000017A0
	[Token(Token = "0x170000BB")]
	private float HealthRange
	{
		[Token(Token = "0x600047B")]
		[Address(RVA = "0x2D58110", Offset = "0x2D57110", VA = "0x182D58110")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x170000BC RID: 188
	// (get) Token: 0x0600047C RID: 1148 RVA: 0x000035B8 File Offset: 0x000017B8
	[Token(Token = "0x170000BC")]
	private float HealthPerStrengthLevel
	{
		[Token(Token = "0x600047C")]
		[Address(RVA = "0x2D580A0", Offset = "0x2D570A0", VA = "0x182D580A0")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x0600047D RID: 1149 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600047D")]
	[Address(RVA = "0x2D57770", Offset = "0x2D56770", VA = "0x182D57770")]
	public void TriggerDeath()
	{
	}

	// Token: 0x0600047E RID: 1150 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600047E")]
	[Address(RVA = "0x2D57780", Offset = "0x2D56780", VA = "0x182D57780")]
	public void TriggerKnockedOut()
	{
	}

	// Token: 0x0600047F RID: 1151 RVA: 0x000035D0 File Offset: 0x000017D0
	[Token(Token = "0x600047F")]
	[Address(RVA = "0x2D55E80", Offset = "0x2D54E80", VA = "0x182D55E80")]
	public float GetStamina()
	{
		return default(float);
	}

	// Token: 0x06000480 RID: 1152 RVA: 0x000035E8 File Offset: 0x000017E8
	[Token(Token = "0x6000480")]
	[Address(RVA = "0x2D55DE0", Offset = "0x2D54DE0", VA = "0x182D55DE0")]
	public float GetStaminaFactor()
	{
		return default(float);
	}

	// Token: 0x06000481 RID: 1153 RVA: 0x00003600 File Offset: 0x00001800
	[Token(Token = "0x6000481")]
	[Address(RVA = "0x2D55E30", Offset = "0x2D54E30", VA = "0x182D55E30")]
	public float GetStaminaToMaxVitalityFactor()
	{
		return default(float);
	}

	// Token: 0x06000482 RID: 1154 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000482")]
	[Address(RVA = "0x2D57230", Offset = "0x2D56230", VA = "0x182D57230")]
	public void SetStamina(float value)
	{
	}

	// Token: 0x06000483 RID: 1155 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000483")]
	[Address(RVA = "0x2D56F70", Offset = "0x2D55F70", VA = "0x182D56F70")]
	public void SetFullStamina()
	{
	}

	// Token: 0x06000484 RID: 1156 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000484")]
	[Address(RVA = "0x2D54A80", Offset = "0x2D53A80", VA = "0x182D54A80")]
	public void AdjustStamina(float value)
	{
	}

	// Token: 0x170000BD RID: 189
	// (get) Token: 0x06000485 RID: 1157 RVA: 0x00003618 File Offset: 0x00001818
	[Token(Token = "0x170000BD")]
	public bool IsThirsty
	{
		[Token(Token = "0x6000485")]
		[Address(RVA = "0x2D58320", Offset = "0x2D57320", VA = "0x182D58320")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170000BE RID: 190
	// (get) Token: 0x06000486 RID: 1158 RVA: 0x00003630 File Offset: 0x00001830
	[Token(Token = "0x170000BE")]
	public bool IsDehydrated
	{
		[Token(Token = "0x6000486")]
		[Address(RVA = "0x2D58260", Offset = "0x2D57260", VA = "0x182D58260")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000487 RID: 1159 RVA: 0x00003648 File Offset: 0x00001848
	[Token(Token = "0x6000487")]
	[Address(RVA = "0x2D55C90", Offset = "0x2D54C90", VA = "0x182D55C90")]
	public float GetHydration()
	{
		return default(float);
	}

	// Token: 0x06000488 RID: 1160 RVA: 0x00003660 File Offset: 0x00001860
	[Token(Token = "0x6000488")]
	[Address(RVA = "0x2D55C60", Offset = "0x2D54C60", VA = "0x182D55C60")]
	public float GetHydrationFactor()
	{
		return default(float);
	}

	// Token: 0x06000489 RID: 1161 RVA: 0x00003678 File Offset: 0x00001878
	[Token(Token = "0x6000489")]
	[Address(RVA = "0x204B160", Offset = "0x204A160", VA = "0x18204B160")]
	public float GetHydrationBuffFactor()
	{
		return default(float);
	}

	// Token: 0x0600048A RID: 1162 RVA: 0x00003690 File Offset: 0x00001890
	[Token(Token = "0x600048A")]
	[Address(RVA = "0x2D56710", Offset = "0x2D55710", VA = "0x182D56710")]
	public bool IsHydrationBuffed()
	{
		return default(bool);
	}

	// Token: 0x0600048B RID: 1163 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600048B")]
	[Address(RVA = "0x2D570D0", Offset = "0x2D560D0", VA = "0x182D570D0")]
	public void SetHydration(float value)
	{
	}

	// Token: 0x0600048C RID: 1164 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600048C")]
	[Address(RVA = "0x2D55120", Offset = "0x2D54120", VA = "0x182D55120")]
	public void Dehydrate(float value)
	{
	}

	// Token: 0x0600048D RID: 1165 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600048D")]
	[Address(RVA = "0x2D56210", Offset = "0x2D55210", VA = "0x182D56210")]
	public void Hydrate(float value, bool buff)
	{
	}

	// Token: 0x0600048E RID: 1166 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600048E")]
	[Address(RVA = "0x2D57840", Offset = "0x2D56840", VA = "0x182D57840")]
	private void UpdateHydrationBuff()
	{
	}

	// Token: 0x170000BF RID: 191
	// (get) Token: 0x0600048F RID: 1167 RVA: 0x000036A8 File Offset: 0x000018A8
	[Token(Token = "0x170000BF")]
	public bool IsHungry
	{
		[Token(Token = "0x600048F")]
		[Address(RVA = "0x2D58290", Offset = "0x2D57290", VA = "0x182D58290")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170000C0 RID: 192
	// (get) Token: 0x06000490 RID: 1168 RVA: 0x000036C0 File Offset: 0x000018C0
	[Token(Token = "0x170000C0")]
	public bool IsStarving
	{
		[Token(Token = "0x6000490")]
		[Address(RVA = "0x2D582F0", Offset = "0x2D572F0", VA = "0x182D582F0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000491 RID: 1169 RVA: 0x000036D8 File Offset: 0x000018D8
	[Token(Token = "0x6000491")]
	[Address(RVA = "0x2D55BF0", Offset = "0x2D54BF0", VA = "0x182D55BF0")]
	public float GetFullness()
	{
		return default(float);
	}

	// Token: 0x06000492 RID: 1170 RVA: 0x000036F0 File Offset: 0x000018F0
	[Token(Token = "0x6000492")]
	[Address(RVA = "0x2D55BC0", Offset = "0x2D54BC0", VA = "0x182D55BC0")]
	public float GetFullnessFactor()
	{
		return default(float);
	}

	// Token: 0x06000493 RID: 1171 RVA: 0x00003708 File Offset: 0x00001908
	[Token(Token = "0x6000493")]
	[Address(RVA = "0x20452E0", Offset = "0x20442E0", VA = "0x1820452E0")]
	public float GetFullnessBuffFactor()
	{
		return default(float);
	}

	// Token: 0x06000494 RID: 1172 RVA: 0x00003720 File Offset: 0x00001920
	[Token(Token = "0x6000494")]
	[Address(RVA = "0x2D56650", Offset = "0x2D55650", VA = "0x182D56650")]
	public bool IsFullnessBuffed()
	{
		return default(bool);
	}

	// Token: 0x06000495 RID: 1173 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000495")]
	[Address(RVA = "0x2D56FF0", Offset = "0x2D55FF0", VA = "0x182D56FF0")]
	public void SetFullness(float value)
	{
	}

	// Token: 0x06000496 RID: 1174 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000496")]
	[Address(RVA = "0x2D57550", Offset = "0x2D56550", VA = "0x182D57550")]
	public void SpendNutrients(float value)
	{
	}

	// Token: 0x06000497 RID: 1175 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000497")]
	[Address(RVA = "0x2D55200", Offset = "0x2D54200", VA = "0x182D55200")]
	public void GainNutrients(float value, bool buff)
	{
	}

	// Token: 0x06000498 RID: 1176 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000498")]
	[Address(RVA = "0x2D577D0", Offset = "0x2D567D0", VA = "0x182D577D0")]
	private void UpdateFullnessBuff()
	{
	}

	// Token: 0x170000C1 RID: 193
	// (get) Token: 0x06000499 RID: 1177 RVA: 0x00003738 File Offset: 0x00001938
	[Token(Token = "0x170000C1")]
	public bool IsTired
	{
		[Token(Token = "0x6000499")]
		[Address(RVA = "0x2D58360", Offset = "0x2D57360", VA = "0x182D58360")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600049A RID: 1178 RVA: 0x00003750 File Offset: 0x00001950
	[Token(Token = "0x600049A")]
	[Address(RVA = "0x5ED0E0", Offset = "0x5EC0E0", VA = "0x1805ED0E0")]
	public int GetLowHealthThreshold()
	{
		return default(int);
	}

	// Token: 0x0600049B RID: 1179 RVA: 0x00003768 File Offset: 0x00001968
	[Token(Token = "0x600049B")]
	[Address(RVA = "0x2D55DC0", Offset = "0x2D54DC0", VA = "0x182D55DC0")]
	public float GetRest()
	{
		return default(float);
	}

	// Token: 0x0600049C RID: 1180 RVA: 0x00003780 File Offset: 0x00001980
	[Token(Token = "0x600049C")]
	[Address(RVA = "0x2D55D90", Offset = "0x2D54D90", VA = "0x182D55D90")]
	public float GetRestFactor()
	{
		return default(float);
	}

	// Token: 0x0600049D RID: 1181 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600049D")]
	[Address(RVA = "0x2D56F40", Offset = "0x2D55F40", VA = "0x182D56F40")]
	public void SetFullRest()
	{
	}

	// Token: 0x0600049E RID: 1182 RVA: 0x00003798 File Offset: 0x00001998
	[Token(Token = "0x600049E")]
	[Address(RVA = "0x2D56720", Offset = "0x2D55720", VA = "0x182D56720")]
	public bool IsRestedBuffed()
	{
		return default(bool);
	}

	// Token: 0x0600049F RID: 1183 RVA: 0x000037B0 File Offset: 0x000019B0
	[Token(Token = "0x600049F")]
	[Address(RVA = "0x2045290", Offset = "0x2044290", VA = "0x182045290")]
	public float GetRestedBuffFactor()
	{
		return default(float);
	}

	// Token: 0x060004A0 RID: 1184 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004A0")]
	[Address(RVA = "0x2D571A0", Offset = "0x2D561A0", VA = "0x182D571A0")]
	public void SetRest(float value)
	{
	}

	// Token: 0x060004A1 RID: 1185 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004A1")]
	[Address(RVA = "0x2D57630", Offset = "0x2D56630", VA = "0x182D57630")]
	public void SpendRest(float value)
	{
	}

	// Token: 0x060004A2 RID: 1186 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004A2")]
	[Address(RVA = "0x2D552A0", Offset = "0x2D542A0", VA = "0x182D552A0")]
	public void GainRest(float value, bool buff)
	{
	}

	// Token: 0x060004A3 RID: 1187 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004A3")]
	[Address(RVA = "0x2D578B0", Offset = "0x2D568B0", VA = "0x182D578B0")]
	private void UpdateRestedBuff()
	{
	}

	// Token: 0x060004A4 RID: 1188 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004A4")]
	[Address(RVA = "0x2D57760", Offset = "0x2D56760", VA = "0x182D57760")]
	private void Start()
	{
	}

	// Token: 0x060004A5 RID: 1189 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004A5")]
	[Address(RVA = "0x2D56BB0", Offset = "0x2D55BB0", VA = "0x182D56BB0")]
	private void OnValidate()
	{
	}

	// Token: 0x060004A6 RID: 1190 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004A6")]
	[Address(RVA = "0x2D57D30", Offset = "0x2D56D30", VA = "0x182D57D30")]
	private void ValidateStats()
	{
	}

	// Token: 0x060004A7 RID: 1191 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004A7")]
	[Address(RVA = "0x2D562B0", Offset = "0x2D552B0", VA = "0x182D562B0")]
	public void InitializeStats()
	{
	}

	// Token: 0x060004A8 RID: 1192 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004A8")]
	[Address(RVA = "0x2D57920", Offset = "0x2D56920", VA = "0x182D57920")]
	private void Update()
	{
	}

	// Token: 0x060004A9 RID: 1193 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004A9")]
	[Address(RVA = "0x2D55350", Offset = "0x2D54350", VA = "0x182D55350")]
	public void GainStrength(float strengthToGain)
	{
	}

	// Token: 0x060004AA RID: 1194 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004AA")]
	[Address(RVA = "0x2D556E0", Offset = "0x2D546E0", VA = "0x182D556E0")]
	public static List<Stat> GetDefaultStats()
	{
		return null;
	}

	// Token: 0x060004AB RID: 1195 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004AB")]
	[Address(RVA = "0x2D55EA0", Offset = "0x2D54EA0", VA = "0x182D55EA0")]
	public string GetStatsReadout()
	{
		return null;
	}

	// Token: 0x060004AC RID: 1196 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004AC")]
	[Address(RVA = "0x2D56150", Offset = "0x2D55150", VA = "0x182D56150")]
	public void GoToSleep()
	{
	}

	// Token: 0x060004AD RID: 1197 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004AD")]
	[Address(RVA = "0x2D57DB0", Offset = "0x2D56DB0", VA = "0x182D57DB0")]
	public void WakeUp()
	{
	}

	// Token: 0x060004AE RID: 1198 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004AE")]
	[Address(RVA = "0x2D56C40", Offset = "0x2D55C40", VA = "0x182D56C40")]
	public void SaveVitalsToPlayerData(PlayerState playerState)
	{
	}

	// Token: 0x060004AF RID: 1199 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004AF")]
	[Address(RVA = "0x2D56730", Offset = "0x2D55730", VA = "0x182D56730")]
	public void LoadVitalsFromPlayerData(PlayerState playerState)
	{
	}

	// Token: 0x060004B0 RID: 1200 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004B0")]
	[Address(RVA = "0x2D54C80", Offset = "0x2D53C80", VA = "0x182D54C80")]
	private void Awake()
	{
	}

	// Token: 0x060004B1 RID: 1201 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004B1")]
	[Address(RVA = "0x2D54C80", Offset = "0x2D53C80", VA = "0x182D54C80")]
	private void SetupDebugCommands()
	{
	}

	// Token: 0x060004B2 RID: 1202 RVA: 0x000037C8 File Offset: 0x000019C8
	[Token(Token = "0x60004B2")]
	[Address(RVA = "0x2D57270", Offset = "0x2D56270", VA = "0x182D57270")]
	private bool SetStrengthLevel(string arg)
	{
		return default(bool);
	}

	// Token: 0x060004B3 RID: 1203 RVA: 0x000037E0 File Offset: 0x000019E0
	[Token(Token = "0x60004B3")]
	[Address(RVA = "0x2D55520", Offset = "0x2D54520", VA = "0x182D55520")]
	private bool GainStrength(string arg)
	{
		return default(bool);
	}

	// Token: 0x060004B4 RID: 1204 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004B4")]
	[Address(RVA = "0x2D54B30", Offset = "0x2D53B30", VA = "0x182D54B30")]
	private IEnumerator AdjustStrengthWorker(float amount, float time)
	{
		return null;
	}

	// Token: 0x060004B5 RID: 1205 RVA: 0x000037F8 File Offset: 0x000019F8
	[Token(Token = "0x60004B5")]
	[Address(RVA = "0x2D54DD0", Offset = "0x2D53DD0", VA = "0x182D54DD0")]
	private bool BuffStats(string arg)
	{
		return default(bool);
	}

	// Token: 0x060004B6 RID: 1206 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004B6")]
	[Address(RVA = "0x2D57E30", Offset = "0x2D56E30", VA = "0x182D57E30")]
	public Vitals()
	{
	}

	// Token: 0x040003C3 RID: 963
	[Token(Token = "0x40003C3")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _startingHealth;

	// Token: 0x040003C4 RID: 964
	[Token(Token = "0x40003C4")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _maxHealth;

	// Token: 0x040003C5 RID: 965
	[Token(Token = "0x40003C5")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _targetHealth;

	// Token: 0x040003C6 RID: 966
	[Token(Token = "0x40003C6")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	[FormerlySerializedAs("LowHealthThreshold")]
	public int _lowHealthThreshold;

	// Token: 0x040003C7 RID: 967
	[Token(Token = "0x40003C7")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public ThirstSettingsData ThirstSettings;

	// Token: 0x040003C8 RID: 968
	[Token(Token = "0x40003C8")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public StarvationSettingsData StarvationSettings;

	// Token: 0x040003C9 RID: 969
	[Token(Token = "0x40003C9")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private int _currentStrengthLevel;

	// Token: 0x040003CA RID: 970
	[Token(Token = "0x40003CA")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private int _maxStrengthLevel;

	// Token: 0x040003CB RID: 971
	[Token(Token = "0x40003CB")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float _requiredBaseStrengthPerLevel;

	// Token: 0x040003CC RID: 972
	[Token(Token = "0x40003CC")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private AnimationCurve _requiredStrenghtMultiplierCurve;

	// Token: 0x040003CD RID: 973
	[Token(Token = "0x40003CD")]
	[FieldOffset(Offset = "0x58")]
	private float _requiredCurrentStrengthPerLevel;

	// Token: 0x040003CE RID: 974
	[Token(Token = "0x40003CE")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private float _currentStrength;

	// Token: 0x040003CF RID: 975
	[Token(Token = "0x40003CF")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private float _hydrationDrainBuffModifier;

	// Token: 0x040003D0 RID: 976
	[Token(Token = "0x40003D0")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	private float _fullnessDrainBuffModifier;

	// Token: 0x040003D1 RID: 977
	[Token(Token = "0x40003D1")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private float _restedDrainBuffModifier;

	// Token: 0x040003D2 RID: 978
	[Token(Token = "0x40003D2")]
	[FieldOffset(Offset = "0x6C")]
	private float _currentHydrationBuffFactor;

	// Token: 0x040003D3 RID: 979
	[Token(Token = "0x40003D3")]
	[FieldOffset(Offset = "0x70")]
	private float _currentFullnessBuffFactor;

	// Token: 0x040003D4 RID: 980
	[Token(Token = "0x40003D4")]
	[FieldOffset(Offset = "0x74")]
	private float _currentRestedBuffFactor;

	// Token: 0x040003D5 RID: 981
	[Token(Token = "0x40003D5")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	internal float _maxVitalityLostWhenFreezing;

	// Token: 0x040003D6 RID: 982
	[Token(Token = "0x40003D6")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private StatOverrideSet _playerAwakeStatOverrides;

	// Token: 0x040003D7 RID: 983
	[Token(Token = "0x40003D7")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private StatOverrideSet _playerAsleepStatOverrides;

	// Token: 0x040003D8 RID: 984
	[Token(Token = "0x40003D8")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private StatsManager _statsManager;

	// Token: 0x040003D9 RID: 985
	[Token(Token = "0x40003D9")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	public BreathingData LungBreathing;

	// Token: 0x040003DA RID: 986
	[Token(Token = "0x40003DA")]
	[FieldOffset(Offset = "0xA0")]
	private float _lastChachedRestedFactor;

	// Token: 0x040003DB RID: 987
	[Token(Token = "0x40003DB")]
	[FieldOffset(Offset = "0xA4")]
	private float _lastChachedFullnessFactor;

	// Token: 0x040003DC RID: 988
	[Token(Token = "0x40003DC")]
	[FieldOffset(Offset = "0xA8")]
	private float _lastChachedHydrationFactor;

	// Token: 0x040003DD RID: 989
	[Token(Token = "0x40003DD")]
	[FieldOffset(Offset = "0xB0")]
	private StrengthStat _strength;

	// Token: 0x040003DE RID: 990
	[Token(Token = "0x40003DE")]
	[FieldOffset(Offset = "0xB8")]
	private VitalityStat _vitality;

	// Token: 0x040003DF RID: 991
	[Token(Token = "0x40003DF")]
	[FieldOffset(Offset = "0xC0")]
	private HealthStat _health;

	// Token: 0x040003E0 RID: 992
	[Token(Token = "0x40003E0")]
	[FieldOffset(Offset = "0xC8")]
	private StaminaStat _stamina;

	// Token: 0x040003E1 RID: 993
	[Token(Token = "0x40003E1")]
	[FieldOffset(Offset = "0xD0")]
	private HydrationStat _hydration;

	// Token: 0x040003E2 RID: 994
	[Token(Token = "0x40003E2")]
	[FieldOffset(Offset = "0xD8")]
	private FullnessStat _fullness;

	// Token: 0x040003E3 RID: 995
	[Token(Token = "0x40003E3")]
	[FieldOffset(Offset = "0xE0")]
	private RestedStat _rested;

	// Token: 0x040003E4 RID: 996
	[Token(Token = "0x40003E4")]
	[FieldOffset(Offset = "0xE8")]
	private TemperatureStat _temperature;

	// Token: 0x040003E5 RID: 997
	[Token(Token = "0x40003E5")]
	[FieldOffset(Offset = "0xF0")]
	private bool _isCold;

	// Token: 0x040003E6 RID: 998
	[Token(Token = "0x40003E6")]
	[FieldOffset(Offset = "0xF4")]
	private float _coldFactor;

	// Token: 0x040003E7 RID: 999
	[Token(Token = "0x40003E7")]
	[FieldOffset(Offset = "0xF8")]
	private bool _hasDied;
}
