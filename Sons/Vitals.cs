using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Gameplay.Cooking;
using Sons.Items.Core;
using Sons.Player;
using Sons.StatSystem;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x02000085 RID: 133
[Token(Token = "0x2000085")]
public class Vitals : MonoBehaviour
{
	// Token: 0x170000B2 RID: 178
	// (get) Token: 0x06000463 RID: 1123 RVA: 0x000034C8 File Offset: 0x000016C8
	[Token(Token = "0x170000B2")]
	public bool IsCold
	{
		[Token(Token = "0x6000463")]
		[Address(RVA = "0xA03DF0", Offset = "0xA023F0", VA = "0x180A03DF0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170000B3 RID: 179
	// (get) Token: 0x06000464 RID: 1124 RVA: 0x000034E0 File Offset: 0x000016E0
	[Token(Token = "0x170000B3")]
	public float ColdFactor
	{
		[Token(Token = "0x6000464")]
		[Address(RVA = "0x2A21B20", Offset = "0x2A20120", VA = "0x182A21B20")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06000465 RID: 1125 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000465")]
	[Address(RVA = "0x336BA30", Offset = "0x336A030", VA = "0x18336BA30")]
	public void SetIsCold(bool value)
	{
	}

	// Token: 0x06000466 RID: 1126 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000466")]
	[Address(RVA = "0x336BA40", Offset = "0x336A040", VA = "0x18336BA40")]
	public void SetColdFactor(float value)
	{
	}

	// Token: 0x170000B4 RID: 180
	// (get) Token: 0x06000467 RID: 1127 RVA: 0x000034F8 File Offset: 0x000016F8
	[Token(Token = "0x170000B4")]
	public bool InteriorSpaceWarmth
	{
		[Token(Token = "0x6000467")]
		[Address(RVA = "0x336BA50", Offset = "0x336A050", VA = "0x18336BA50")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000468 RID: 1128 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000468")]
	[Address(RVA = "0x336BA70", Offset = "0x336A070", VA = "0x18336BA70")]
	public void SetInteriorSpaceWarmth(bool value)
	{
	}

	// Token: 0x06000469 RID: 1129 RVA: 0x00003510 File Offset: 0x00001710
	[Token(Token = "0x6000469")]
	[Address(RVA = "0x336BAA0", Offset = "0x336A0A0", VA = "0x18336BAA0")]
	public float GetVitalityLostFromColdFactor()
	{
		return 0f;
	}

	// Token: 0x0600046A RID: 1130 RVA: 0x00003528 File Offset: 0x00001728
	[Token(Token = "0x600046A")]
	[Address(RVA = "0x336BAF0", Offset = "0x336A0F0", VA = "0x18336BAF0")]
	public float GetVitalityLostFromCold()
	{
		return 0f;
	}

	// Token: 0x170000B5 RID: 181
	// (get) Token: 0x0600046B RID: 1131 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000B5")]
	private StrengthStat Strength
	{
		[Token(Token = "0x600046B")]
		[Address(RVA = "0x336BB10", Offset = "0x336A110", VA = "0x18336BB10")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000B6 RID: 182
	// (get) Token: 0x0600046C RID: 1132 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000B6")]
	private VitalityStat Vitality
	{
		[Token(Token = "0x600046C")]
		[Address(RVA = "0x336BBC0", Offset = "0x336A1C0", VA = "0x18336BBC0")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000B7 RID: 183
	// (get) Token: 0x0600046D RID: 1133 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000B7")]
	private HealthStat Health
	{
		[Token(Token = "0x600046D")]
		[Address(RVA = "0x336BC70", Offset = "0x336A270", VA = "0x18336BC70")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000B8 RID: 184
	// (get) Token: 0x0600046E RID: 1134 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000B8")]
	private StaminaStat Stamina
	{
		[Token(Token = "0x600046E")]
		[Address(RVA = "0x336BD20", Offset = "0x336A320", VA = "0x18336BD20")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000B9 RID: 185
	// (get) Token: 0x0600046F RID: 1135 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000B9")]
	private HydrationStat Hydration
	{
		[Token(Token = "0x600046F")]
		[Address(RVA = "0x336BDD0", Offset = "0x336A3D0", VA = "0x18336BDD0")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000BA RID: 186
	// (get) Token: 0x06000470 RID: 1136 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000BA")]
	private FullnessStat Fullness
	{
		[Token(Token = "0x6000470")]
		[Address(RVA = "0x336BE80", Offset = "0x336A480", VA = "0x18336BE80")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000BB RID: 187
	// (get) Token: 0x06000471 RID: 1137 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000BB")]
	private RestedStat Rested
	{
		[Token(Token = "0x6000471")]
		[Address(RVA = "0x336BF30", Offset = "0x336A530", VA = "0x18336BF30")]
		get
		{
			return null;
		}
	}

	// Token: 0x170000BC RID: 188
	// (get) Token: 0x06000472 RID: 1138 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x170000BC")]
	private TemperatureStat Temperature
	{
		[Token(Token = "0x6000472")]
		[Address(RVA = "0x336BFE0", Offset = "0x336A5E0", VA = "0x18336BFE0")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000473 RID: 1139 RVA: 0x00003540 File Offset: 0x00001740
	[Token(Token = "0x6000473")]
	[Address(RVA = "0x336C090", Offset = "0x336A690", VA = "0x18336C090")]
	public float GetStrength()
	{
		return 0f;
	}

	// Token: 0x06000474 RID: 1140 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000474")]
	[Address(RVA = "0x336C0B0", Offset = "0x336A6B0", VA = "0x18336C0B0")]
	public void SetStrength(float value)
	{
	}

	// Token: 0x06000475 RID: 1141 RVA: 0x00003558 File Offset: 0x00001758
	[Token(Token = "0x6000475")]
	[Address(RVA = "0x336C130", Offset = "0x336A730", VA = "0x18336C130")]
	public float GetStrengthFactor()
	{
		return 0f;
	}

	// Token: 0x170000BD RID: 189
	// (get) Token: 0x06000476 RID: 1142 RVA: 0x00003570 File Offset: 0x00001770
	[Token(Token = "0x170000BD")]
	public int CurrentStrengthLevel
	{
		[Token(Token = "0x6000476")]
		[Address(RVA = "0x784B40", Offset = "0x783140", VA = "0x180784B40")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06000477 RID: 1143 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000477")]
	[Address(RVA = "0x336C170", Offset = "0x336A770", VA = "0x18336C170")]
	public void ModifyStrengthBoostModifer(float value)
	{
	}

	// Token: 0x06000478 RID: 1144 RVA: 0x00003588 File Offset: 0x00001788
	[Token(Token = "0x6000478")]
	[Address(RVA = "0x336C190", Offset = "0x336A790", VA = "0x18336C190")]
	public float GetVitality()
	{
		return 0f;
	}

	// Token: 0x06000479 RID: 1145 RVA: 0x000035A0 File Offset: 0x000017A0
	[Token(Token = "0x6000479")]
	[Address(RVA = "0x336C1B0", Offset = "0x336A7B0", VA = "0x18336C1B0")]
	public float GetResolvedMaxVitality()
	{
		return 0f;
	}

	// Token: 0x0600047A RID: 1146 RVA: 0x000035B8 File Offset: 0x000017B8
	[Token(Token = "0x600047A")]
	[Address(RVA = "0x336C1F0", Offset = "0x336A7F0", VA = "0x18336C1F0")]
	public float GetMaxVitalityFactor()
	{
		return 0f;
	}

	// Token: 0x0600047B RID: 1147 RVA: 0x000035D0 File Offset: 0x000017D0
	[Token(Token = "0x600047B")]
	[Address(RVA = "0x336C270", Offset = "0x336A870", VA = "0x18336C270")]
	public float GetVitalityFactor()
	{
		return 0f;
	}

	// Token: 0x0600047C RID: 1148 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600047C")]
	[Address(RVA = "0x336C2B0", Offset = "0x336A8B0", VA = "0x18336C2B0")]
	public void SetFullVitality()
	{
	}

	// Token: 0x0600047D RID: 1149 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600047D")]
	[Address(RVA = "0x336C2E0", Offset = "0x336A8E0", VA = "0x18336C2E0")]
	public void SetVitality(float value)
	{
	}

	// Token: 0x0600047E RID: 1150 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600047E")]
	[Address(RVA = "0x336C3C0", Offset = "0x336A9C0", VA = "0x18336C3C0")]
	public void GainVitality(float value)
	{
	}

	// Token: 0x0600047F RID: 1151 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600047F")]
	[Address(RVA = "0x336C420", Offset = "0x336AA20", VA = "0x18336C420")]
	public void SpendVitality(float value)
	{
	}

	// Token: 0x06000480 RID: 1152 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000480")]
	[Address(RVA = "0x336C490", Offset = "0x336AA90", VA = "0x18336C490")]
	public void CalculateVitality()
	{
	}

	// Token: 0x06000481 RID: 1153 RVA: 0x000035E8 File Offset: 0x000017E8
	[Token(Token = "0x6000481")]
	[Address(RVA = "0x336C650", Offset = "0x336AC50", VA = "0x18336C650")]
	public float GetMaxHealth()
	{
		return 0f;
	}

	// Token: 0x06000482 RID: 1154 RVA: 0x00003600 File Offset: 0x00001800
	[Token(Token = "0x6000482")]
	[Address(RVA = "0x336C670", Offset = "0x336AC70", VA = "0x18336C670")]
	public float GetHealth()
	{
		return 0f;
	}

	// Token: 0x06000483 RID: 1155 RVA: 0x00003618 File Offset: 0x00001818
	[Token(Token = "0x6000483")]
	[Address(RVA = "0x336C690", Offset = "0x336AC90", VA = "0x18336C690")]
	public float GetHealthFactor()
	{
		return 0f;
	}

	// Token: 0x06000484 RID: 1156 RVA: 0x00003630 File Offset: 0x00001830
	[Token(Token = "0x6000484")]
	[Address(RVA = "0x336C6D0", Offset = "0x336ACD0", VA = "0x18336C6D0")]
	public float GetTargetHealthFactor()
	{
		return 0f;
	}

	// Token: 0x06000485 RID: 1157 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000485")]
	[Address(RVA = "0x336C710", Offset = "0x336AD10", VA = "0x18336C710")]
	public void SetFullHealth()
	{
	}

	// Token: 0x06000486 RID: 1158 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000486")]
	[Address(RVA = "0x336C7B0", Offset = "0x336ADB0", VA = "0x18336C7B0")]
	public void SetHealth(float value)
	{
	}

	// Token: 0x06000487 RID: 1159 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000487")]
	[Address(RVA = "0x336C830", Offset = "0x336AE30", VA = "0x18336C830")]
	public void ApplyHealing(float value)
	{
	}

	// Token: 0x06000488 RID: 1160 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000488")]
	[Address(RVA = "0x336C890", Offset = "0x336AE90", VA = "0x18336C890")]
	public void ApplyDamage(float value)
	{
	}

	// Token: 0x06000489 RID: 1161 RVA: 0x00003648 File Offset: 0x00001848
	[Token(Token = "0x6000489")]
	[Address(RVA = "0x336C920", Offset = "0x336AF20", VA = "0x18336C920")]
	public bool IsHealing()
	{
		return default(bool);
	}

	// Token: 0x170000BE RID: 190
	// (get) Token: 0x0600048A RID: 1162 RVA: 0x00003660 File Offset: 0x00001860
	[Token(Token = "0x170000BE")]
	public bool IsLowHealth
	{
		[Token(Token = "0x600048A")]
		[Address(RVA = "0x336C960", Offset = "0x336AF60", VA = "0x18336C960")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600048B RID: 1163 RVA: 0x00003678 File Offset: 0x00001878
	[Token(Token = "0x600048B")]
	[Address(RVA = "0x336C990", Offset = "0x336AF90", VA = "0x18336C990")]
	public bool IsAlive()
	{
		return default(bool);
	}

	// Token: 0x0600048C RID: 1164 RVA: 0x00003690 File Offset: 0x00001890
	[Token(Token = "0x600048C")]
	[Address(RVA = "0x30AEC90", Offset = "0x30AD290", VA = "0x1830AEC90")]
	public bool HasDied()
	{
		return default(bool);
	}

	// Token: 0x0600048D RID: 1165 RVA: 0x000036A8 File Offset: 0x000018A8
	[Token(Token = "0x600048D")]
	[Address(RVA = "0x336C9A0", Offset = "0x336AFA0", VA = "0x18336C9A0")]
	public bool HasHealth()
	{
		return default(bool);
	}

	// Token: 0x170000BF RID: 191
	// (get) Token: 0x0600048E RID: 1166 RVA: 0x000036C0 File Offset: 0x000018C0
	[Token(Token = "0x170000BF")]
	private float HealthRange
	{
		[Token(Token = "0x600048E")]
		[Address(RVA = "0x336C9D0", Offset = "0x336AFD0", VA = "0x18336C9D0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x170000C0 RID: 192
	// (get) Token: 0x0600048F RID: 1167 RVA: 0x000036D8 File Offset: 0x000018D8
	[Token(Token = "0x170000C0")]
	private float HealthPerStrengthLevel
	{
		[Token(Token = "0x600048F")]
		[Address(RVA = "0x336C9E0", Offset = "0x336AFE0", VA = "0x18336C9E0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06000490 RID: 1168 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000490")]
	[Address(RVA = "0x335CAE0", Offset = "0x335B0E0", VA = "0x18335CAE0")]
	public void TriggerDeath()
	{
	}

	// Token: 0x06000491 RID: 1169 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000491")]
	[Address(RVA = "0x336CA10", Offset = "0x336B010", VA = "0x18336CA10")]
	public void TriggerKnockedOut()
	{
	}

	// Token: 0x06000492 RID: 1170 RVA: 0x000036F0 File Offset: 0x000018F0
	[Token(Token = "0x6000492")]
	[Address(RVA = "0x336CA30", Offset = "0x336B030", VA = "0x18336CA30")]
	public float GetStamina()
	{
		return 0f;
	}

	// Token: 0x06000493 RID: 1171 RVA: 0x00003708 File Offset: 0x00001908
	[Token(Token = "0x6000493")]
	[Address(RVA = "0x336CA50", Offset = "0x336B050", VA = "0x18336CA50")]
	public float GetStaminaFactor()
	{
		return 0f;
	}

	// Token: 0x06000494 RID: 1172 RVA: 0x00003720 File Offset: 0x00001920
	[Token(Token = "0x6000494")]
	[Address(RVA = "0x336CAA0", Offset = "0x336B0A0", VA = "0x18336CAA0")]
	public float GetStaminaToMaxVitalityFactor()
	{
		return 0f;
	}

	// Token: 0x06000495 RID: 1173 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000495")]
	[Address(RVA = "0x336CAF0", Offset = "0x336B0F0", VA = "0x18336CAF0")]
	public void SetStamina(float value)
	{
	}

	// Token: 0x06000496 RID: 1174 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000496")]
	[Address(RVA = "0x336CB70", Offset = "0x336B170", VA = "0x18336CB70")]
	public void SetFullStamina()
	{
	}

	// Token: 0x06000497 RID: 1175 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000497")]
	[Address(RVA = "0x336CC10", Offset = "0x336B210", VA = "0x18336CC10")]
	public void AdjustStamina(float value)
	{
	}

	// Token: 0x170000C1 RID: 193
	// (get) Token: 0x06000498 RID: 1176 RVA: 0x00003738 File Offset: 0x00001938
	[Token(Token = "0x170000C1")]
	public bool IsThirsty
	{
		[Token(Token = "0x6000498")]
		[Address(RVA = "0x336CD30", Offset = "0x336B330", VA = "0x18336CD30")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170000C2 RID: 194
	// (get) Token: 0x06000499 RID: 1177 RVA: 0x00003750 File Offset: 0x00001950
	[Token(Token = "0x170000C2")]
	public bool IsDehydrated
	{
		[Token(Token = "0x6000499")]
		[Address(RVA = "0x336CD70", Offset = "0x336B370", VA = "0x18336CD70")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600049A RID: 1178 RVA: 0x00003768 File Offset: 0x00001968
	[Token(Token = "0x600049A")]
	[Address(RVA = "0x336CDA0", Offset = "0x336B3A0", VA = "0x18336CDA0")]
	public float GetHydration()
	{
		return 0f;
	}

	// Token: 0x0600049B RID: 1179 RVA: 0x00003780 File Offset: 0x00001980
	[Token(Token = "0x600049B")]
	[Address(RVA = "0x336CDC0", Offset = "0x336B3C0", VA = "0x18336CDC0")]
	public float GetHydrationFactor()
	{
		return 0f;
	}

	// Token: 0x0600049C RID: 1180 RVA: 0x00003798 File Offset: 0x00001998
	[Token(Token = "0x600049C")]
	[Address(RVA = "0x2403E60", Offset = "0x2402460", VA = "0x182403E60")]
	public float GetHydrationBuffFactor()
	{
		return 0f;
	}

	// Token: 0x0600049D RID: 1181 RVA: 0x000037B0 File Offset: 0x000019B0
	[Token(Token = "0x600049D")]
	[Address(RVA = "0x336CE00", Offset = "0x336B400", VA = "0x18336CE00")]
	public bool IsHydrationBuffed()
	{
		return default(bool);
	}

	// Token: 0x0600049E RID: 1182 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600049E")]
	[Address(RVA = "0x336CE10", Offset = "0x336B410", VA = "0x18336CE10")]
	public void SetHydration(float value)
	{
	}

	// Token: 0x0600049F RID: 1183 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600049F")]
	[Address(RVA = "0x336CEF0", Offset = "0x336B4F0", VA = "0x18336CEF0")]
	public void Dehydrate(float value)
	{
	}

	// Token: 0x060004A0 RID: 1184 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004A0")]
	[Address(RVA = "0x336D010", Offset = "0x336B610", VA = "0x18336D010")]
	public void Hydrate(float value, bool buff)
	{
	}

	// Token: 0x060004A1 RID: 1185 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004A1")]
	[Address(RVA = "0x336D0F0", Offset = "0x336B6F0", VA = "0x18336D0F0")]
	private void UpdateHydrationBuff()
	{
	}

	// Token: 0x170000C3 RID: 195
	// (get) Token: 0x060004A2 RID: 1186 RVA: 0x000037C8 File Offset: 0x000019C8
	[Token(Token = "0x170000C3")]
	public bool IsHungry
	{
		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x336D180", Offset = "0x336B780", VA = "0x18336D180")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x170000C4 RID: 196
	// (get) Token: 0x060004A3 RID: 1187 RVA: 0x000037E0 File Offset: 0x000019E0
	[Token(Token = "0x170000C4")]
	public bool IsStarving
	{
		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x336D1B0", Offset = "0x336B7B0", VA = "0x18336D1B0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060004A4 RID: 1188 RVA: 0x000037F8 File Offset: 0x000019F8
	[Token(Token = "0x60004A4")]
	[Address(RVA = "0x336D1E0", Offset = "0x336B7E0", VA = "0x18336D1E0")]
	public float GetFullness()
	{
		return 0f;
	}

	// Token: 0x060004A5 RID: 1189 RVA: 0x00003810 File Offset: 0x00001A10
	[Token(Token = "0x60004A5")]
	[Address(RVA = "0x336D200", Offset = "0x336B800", VA = "0x18336D200")]
	public float GetFullnessFactor()
	{
		return 0f;
	}

	// Token: 0x060004A6 RID: 1190 RVA: 0x00003828 File Offset: 0x00001A28
	[Token(Token = "0x60004A6")]
	[Address(RVA = "0x23C2640", Offset = "0x23C0C40", VA = "0x1823C2640")]
	public float GetFullnessBuffFactor()
	{
		return 0f;
	}

	// Token: 0x060004A7 RID: 1191 RVA: 0x00003840 File Offset: 0x00001A40
	[Token(Token = "0x60004A7")]
	[Address(RVA = "0x336D240", Offset = "0x336B840", VA = "0x18336D240")]
	public bool IsFullnessBuffed()
	{
		return default(bool);
	}

	// Token: 0x060004A8 RID: 1192 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004A8")]
	[Address(RVA = "0x336D250", Offset = "0x336B850", VA = "0x18336D250")]
	public void SetFullness(float value)
	{
	}

	// Token: 0x060004A9 RID: 1193 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004A9")]
	[Address(RVA = "0x336D330", Offset = "0x336B930", VA = "0x18336D330")]
	public void SpendNutrients(float value)
	{
	}

	// Token: 0x060004AA RID: 1194 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004AA")]
	[Address(RVA = "0x336D450", Offset = "0x336BA50", VA = "0x18336D450")]
	public void GainNutrients(float value, bool buff)
	{
	}

	// Token: 0x060004AB RID: 1195 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004AB")]
	[Address(RVA = "0x336D530", Offset = "0x336BB30", VA = "0x18336D530")]
	private void UpdateFullnessBuff()
	{
	}

	// Token: 0x170000C5 RID: 197
	// (get) Token: 0x060004AC RID: 1196 RVA: 0x00003858 File Offset: 0x00001A58
	[Token(Token = "0x170000C5")]
	public bool IsTired
	{
		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x336D5C0", Offset = "0x336BBC0", VA = "0x18336D5C0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060004AD RID: 1197 RVA: 0x00003870 File Offset: 0x00001A70
	[Token(Token = "0x60004AD")]
	[Address(RVA = "0x716CD0", Offset = "0x7152D0", VA = "0x180716CD0")]
	public int GetLowHealthThreshold()
	{
		return 0;
	}

	// Token: 0x060004AE RID: 1198 RVA: 0x00003888 File Offset: 0x00001A88
	[Token(Token = "0x60004AE")]
	[Address(RVA = "0x336D5F0", Offset = "0x336BBF0", VA = "0x18336D5F0")]
	public float GetRest()
	{
		return 0f;
	}

	// Token: 0x060004AF RID: 1199 RVA: 0x000038A0 File Offset: 0x00001AA0
	[Token(Token = "0x60004AF")]
	[Address(RVA = "0x336D610", Offset = "0x336BC10", VA = "0x18336D610")]
	public float GetRestFactor()
	{
		return 0f;
	}

	// Token: 0x060004B0 RID: 1200 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004B0")]
	[Address(RVA = "0x336D650", Offset = "0x336BC50", VA = "0x18336D650")]
	public void SetFullRest()
	{
	}

	// Token: 0x060004B1 RID: 1201 RVA: 0x000038B8 File Offset: 0x00001AB8
	[Token(Token = "0x60004B1")]
	[Address(RVA = "0x336D680", Offset = "0x336BC80", VA = "0x18336D680")]
	public bool IsRestedBuffed()
	{
		return default(bool);
	}

	// Token: 0x060004B2 RID: 1202 RVA: 0x000038D0 File Offset: 0x00001AD0
	[Token(Token = "0x60004B2")]
	[Address(RVA = "0x6124A0", Offset = "0x610AA0", VA = "0x1806124A0")]
	public float GetRestedBuffFactor()
	{
		return 0f;
	}

	// Token: 0x060004B3 RID: 1203 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004B3")]
	[Address(RVA = "0x336D690", Offset = "0x336BC90", VA = "0x18336D690")]
	public void SetRest(float value)
	{
	}

	// Token: 0x060004B4 RID: 1204 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004B4")]
	[Address(RVA = "0x336D770", Offset = "0x336BD70", VA = "0x18336D770")]
	public void SpendRest(float value)
	{
	}

	// Token: 0x060004B5 RID: 1205 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004B5")]
	[Address(RVA = "0x336D890", Offset = "0x336BE90", VA = "0x18336D890")]
	public void GainRest(float value, bool buff)
	{
	}

	// Token: 0x060004B6 RID: 1206 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004B6")]
	[Address(RVA = "0x336D980", Offset = "0x336BF80", VA = "0x18336D980")]
	private void UpdateRestedBuff()
	{
	}

	// Token: 0x060004B7 RID: 1207 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004B7")]
	[Address(RVA = "0x336DA10", Offset = "0x336C010", VA = "0x18336DA10")]
	private void Start()
	{
	}

	// Token: 0x060004B8 RID: 1208 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004B8")]
	[Address(RVA = "0x336DA20", Offset = "0x336C020", VA = "0x18336DA20")]
	private void OnValidate()
	{
	}

	// Token: 0x060004B9 RID: 1209 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004B9")]
	[Address(RVA = "0x336DB00", Offset = "0x336C100", VA = "0x18336DB00")]
	private void ValidateStats()
	{
	}

	// Token: 0x060004BA RID: 1210 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004BA")]
	[Address(RVA = "0x336DBB0", Offset = "0x336C1B0", VA = "0x18336DBB0")]
	public void InitializeStats()
	{
	}

	// Token: 0x060004BB RID: 1211 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004BB")]
	[Address(RVA = "0x336DFA0", Offset = "0x336C5A0", VA = "0x18336DFA0")]
	private void Update()
	{
	}

	// Token: 0x060004BC RID: 1212 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004BC")]
	[Address(RVA = "0x336E620", Offset = "0x336CC20", VA = "0x18336E620")]
	public void GainStrength(float strengthToGain)
	{
	}

	// Token: 0x060004BD RID: 1213 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004BD")]
	[Address(RVA = "0x336E8A0", Offset = "0x336CEA0", VA = "0x18336E8A0")]
	public static List<Stat> GetDefaultStats()
	{
		return null;
	}

	// Token: 0x060004BE RID: 1214 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004BE")]
	[Address(RVA = "0x336EE80", Offset = "0x336D480", VA = "0x18336EE80")]
	public string GetStatsReadout()
	{
		return null;
	}

	// Token: 0x060004BF RID: 1215 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004BF")]
	[Address(RVA = "0x336F030", Offset = "0x336D630", VA = "0x18336F030")]
	public void GoToSleep()
	{
	}

	// Token: 0x060004C0 RID: 1216 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004C0")]
	[Address(RVA = "0x336F0F0", Offset = "0x336D6F0", VA = "0x18336F0F0")]
	public void WakeUp()
	{
	}

	// Token: 0x060004C1 RID: 1217 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004C1")]
	[Address(RVA = "0x336F1B0", Offset = "0x336D7B0", VA = "0x18336F1B0")]
	public void ResetRestGainFromSleepModifier()
	{
	}

	// Token: 0x060004C2 RID: 1218 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004C2")]
	[Address(RVA = "0x336F200", Offset = "0x336D800", VA = "0x18336F200")]
	public void ModifyRestGainFromSleepModifier(float value)
	{
	}

	// Token: 0x060004C3 RID: 1219 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004C3")]
	[Address(RVA = "0x336F250", Offset = "0x336D850", VA = "0x18336F250")]
	public void ApplyCookingBuffStats(StatRecipe recipe)
	{
	}

	// Token: 0x060004C4 RID: 1220 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004C4")]
	[Address(RVA = "0x336F650", Offset = "0x336DC50", VA = "0x18336F650")]
	private void UpdateCookingBuffs()
	{
	}

	// Token: 0x060004C5 RID: 1221 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004C5")]
	[Address(RVA = "0x336F9F0", Offset = "0x336DFF0", VA = "0x18336F9F0")]
	public void SaveVitalsToPlayerData(PlayerState playerState)
	{
	}

	// Token: 0x060004C6 RID: 1222 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004C6")]
	[Address(RVA = "0x336FDA0", Offset = "0x336E3A0", VA = "0x18336FDA0")]
	public void LoadVitalsFromPlayerData(PlayerState playerState)
	{
	}

	// Token: 0x060004C7 RID: 1223 RVA: 0x000038E8 File Offset: 0x00001AE8
	[Token(Token = "0x60004C7")]
	[Address(RVA = "0x33705B0", Offset = "0x336EBB0", VA = "0x1833705B0")]
	public float GetCookingDurationFactor()
	{
		return 0f;
	}

	// Token: 0x060004C8 RID: 1224 RVA: 0x00003900 File Offset: 0x00001B00
	[Token(Token = "0x60004C8")]
	[Address(RVA = "0x3370620", Offset = "0x336EC20", VA = "0x183370620")]
	public bool HasCookingBuffEffect()
	{
		return default(bool);
	}

	// Token: 0x060004C9 RID: 1225 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004C9")]
	[Address(RVA = "0x8DF560", Offset = "0x8DDB60", VA = "0x1808DF560")]
	public StatRecipe GetActiveCookingBuffRecipe()
	{
		return null;
	}

	// Token: 0x060004CA RID: 1226 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004CA")]
	[Address(RVA = "0x3370700", Offset = "0x336ED00", VA = "0x183370700")]
	private void Awake()
	{
	}

	// Token: 0x060004CB RID: 1227 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004CB")]
	[Address(RVA = "0x3370700", Offset = "0x336ED00", VA = "0x183370700")]
	private void SetupDebugCommands()
	{
	}

	// Token: 0x060004CC RID: 1228 RVA: 0x00003918 File Offset: 0x00001B18
	[Token(Token = "0x60004CC")]
	[Address(RVA = "0x3370850", Offset = "0x336EE50", VA = "0x183370850")]
	private bool SetStrengthLevel(string arg)
	{
		return default(bool);
	}

	// Token: 0x060004CD RID: 1229 RVA: 0x00003930 File Offset: 0x00001B30
	[Token(Token = "0x60004CD")]
	[Address(RVA = "0x3370AE0", Offset = "0x336F0E0", VA = "0x183370AE0")]
	private bool GainStrength(string arg)
	{
		return default(bool);
	}

	// Token: 0x060004CE RID: 1230 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60004CE")]
	[Address(RVA = "0x3370D60", Offset = "0x336F360", VA = "0x183370D60")]
	private IEnumerator AdjustStrengthWorker(float amount, float time)
	{
		return null;
	}

	// Token: 0x060004CF RID: 1231 RVA: 0x00003948 File Offset: 0x00001B48
	[Token(Token = "0x60004CF")]
	[Address(RVA = "0x3370E20", Offset = "0x336F420", VA = "0x183370E20")]
	private bool BuffStats(string arg)
	{
		return default(bool);
	}

	// Token: 0x060004D0 RID: 1232 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60004D0")]
	[Address(RVA = "0x3371000", Offset = "0x336F600", VA = "0x183371000")]
	public Vitals()
	{
	}

	// Token: 0x040003D4 RID: 980
	[Token(Token = "0x40003D4")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _startingHealth;

	// Token: 0x040003D5 RID: 981
	[Token(Token = "0x40003D5")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _maxHealth;

	// Token: 0x040003D6 RID: 982
	[Token(Token = "0x40003D6")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _targetHealth;

	// Token: 0x040003D7 RID: 983
	[Token(Token = "0x40003D7")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float _healthRegenColdModifierSurvivalNormal;

	// Token: 0x040003D8 RID: 984
	[Token(Token = "0x40003D8")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float _healthRegenColdModifierSurvivalHard;

	// Token: 0x040003D9 RID: 985
	[Token(Token = "0x40003D9")]
	[FieldOffset(Offset = "0x34")]
	[FormerlySerializedAs("LowHealthThreshold")]
	[SerializeField]
	public int _lowHealthThreshold;

	// Token: 0x040003DA RID: 986
	[Token(Token = "0x40003DA")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public ThirstSettingsData ThirstSettings;

	// Token: 0x040003DB RID: 987
	[Token(Token = "0x40003DB")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	public StarvationSettingsData StarvationSettings;

	// Token: 0x040003DC RID: 988
	[Token(Token = "0x40003DC")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private int _currentStrengthLevel;

	// Token: 0x040003DD RID: 989
	[Token(Token = "0x40003DD")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private int _maxStrengthLevel;

	// Token: 0x040003DE RID: 990
	[Token(Token = "0x40003DE")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private float _requiredBaseStrengthPerLevel;

	// Token: 0x040003DF RID: 991
	[Token(Token = "0x40003DF")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private AnimationCurve _requiredStrenghtMultiplierCurve;

	// Token: 0x040003E0 RID: 992
	[Token(Token = "0x40003E0")]
	[FieldOffset(Offset = "0x60")]
	private float _requiredCurrentStrengthPerLevel;

	// Token: 0x040003E1 RID: 993
	[Token(Token = "0x40003E1")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	private float _currentStrength;

	// Token: 0x040003E2 RID: 994
	[Token(Token = "0x40003E2")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private float _hydrationDrainBuffModifier;

	// Token: 0x040003E3 RID: 995
	[Token(Token = "0x40003E3")]
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	private float _fullnessDrainBuffModifier;

	// Token: 0x040003E4 RID: 996
	[Token(Token = "0x40003E4")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private float _restedDrainBuffModifier;

	// Token: 0x040003E5 RID: 997
	[Token(Token = "0x40003E5")]
	[FieldOffset(Offset = "0x74")]
	private float _currentHydrationBuffFactor;

	// Token: 0x040003E6 RID: 998
	[Token(Token = "0x40003E6")]
	[FieldOffset(Offset = "0x78")]
	private float _currentFullnessBuffFactor;

	// Token: 0x040003E7 RID: 999
	[Token(Token = "0x40003E7")]
	[FieldOffset(Offset = "0x7C")]
	private float _currentRestedBuffFactor;

	// Token: 0x040003E8 RID: 1000
	[Token(Token = "0x40003E8")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private CookingRecipeDatabase _cookingRecipeDatabase;

	// Token: 0x040003E9 RID: 1001
	[Token(Token = "0x40003E9")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	internal float _maxVitalityLostWhenFreezing;

	// Token: 0x040003EA RID: 1002
	[Token(Token = "0x40003EA")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private StatOverrideSet _playerAwakeStatOverrides;

	// Token: 0x040003EB RID: 1003
	[Token(Token = "0x40003EB")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private StatOverrideSet _playerAsleepStatOverrides;

	// Token: 0x040003EC RID: 1004
	[Token(Token = "0x40003EC")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private StatsManager _statsManager;

	// Token: 0x040003ED RID: 1005
	[Token(Token = "0x40003ED")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	public BreathingData LungBreathing;

	// Token: 0x040003EE RID: 1006
	[Token(Token = "0x40003EE")]
	[FieldOffset(Offset = "0xB0")]
	private float _lastChachedRestedFactor;

	// Token: 0x040003EF RID: 1007
	[Token(Token = "0x40003EF")]
	[FieldOffset(Offset = "0xB4")]
	private float _lastChachedFullnessFactor;

	// Token: 0x040003F0 RID: 1008
	[Token(Token = "0x40003F0")]
	[FieldOffset(Offset = "0xB8")]
	private float _lastChachedHydrationFactor;

	// Token: 0x040003F1 RID: 1009
	[Token(Token = "0x40003F1")]
	[FieldOffset(Offset = "0xC0")]
	private StrengthStat _strength;

	// Token: 0x040003F2 RID: 1010
	[Token(Token = "0x40003F2")]
	[FieldOffset(Offset = "0xC8")]
	private VitalityStat _vitality;

	// Token: 0x040003F3 RID: 1011
	[Token(Token = "0x40003F3")]
	[FieldOffset(Offset = "0xD0")]
	private HealthStat _health;

	// Token: 0x040003F4 RID: 1012
	[Token(Token = "0x40003F4")]
	[FieldOffset(Offset = "0xD8")]
	private StaminaStat _stamina;

	// Token: 0x040003F5 RID: 1013
	[Token(Token = "0x40003F5")]
	[FieldOffset(Offset = "0xE0")]
	private HydrationStat _hydration;

	// Token: 0x040003F6 RID: 1014
	[Token(Token = "0x40003F6")]
	[FieldOffset(Offset = "0xE8")]
	private FullnessStat _fullness;

	// Token: 0x040003F7 RID: 1015
	[Token(Token = "0x40003F7")]
	[FieldOffset(Offset = "0xF0")]
	private RestedStat _rested;

	// Token: 0x040003F8 RID: 1016
	[Token(Token = "0x40003F8")]
	[FieldOffset(Offset = "0xF8")]
	private TemperatureStat _temperature;

	// Token: 0x040003F9 RID: 1017
	[Token(Token = "0x40003F9")]
	[FieldOffset(Offset = "0x100")]
	private bool _isCold;

	// Token: 0x040003FA RID: 1018
	[Token(Token = "0x40003FA")]
	[FieldOffset(Offset = "0x104")]
	private float _coldFactor;

	// Token: 0x040003FB RID: 1019
	[Token(Token = "0x40003FB")]
	[FieldOffset(Offset = "0x108")]
	private bool _hasDied;

	// Token: 0x040003FC RID: 1020
	[Token(Token = "0x40003FC")]
	[FieldOffset(Offset = "0x110")]
	private StatRecipe _activeCookingBuffRecipe;

	// Token: 0x040003FD RID: 1021
	[Token(Token = "0x40003FD")]
	[FieldOffset(Offset = "0x118")]
	private float _remainingCookingBuffTime;

	// Token: 0x040003FE RID: 1022
	[Token(Token = "0x40003FE")]
	[FieldOffset(Offset = "0x11C")]
	private float _strengthBoostModifier;
}
