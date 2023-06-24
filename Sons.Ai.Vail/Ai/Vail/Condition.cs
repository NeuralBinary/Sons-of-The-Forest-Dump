using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sirenix.OdinInspector;
using Sons.Ai.Vail.Memory;
using Sons.Animation.Mae;
using Sons.Atmosphere;
using Sons.StatSystem;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Ai.Vail
{
	// Token: 0x02000063 RID: 99
	[Token(Token = "0x2000063")]
	[Serializable]
	public class Condition
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x00003DB0 File Offset: 0x00001FB0
		[Token(Token = "0x1700004F")]
		private bool IsInventoryCondition
		{
			[Token(Token = "0x6000487")]
			[Address(RVA = "0x2B18310", Offset = "0x2B16910", VA = "0x182B18310")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000488 RID: 1160 RVA: 0x00003DC8 File Offset: 0x00001FC8
		[Token(Token = "0x17000050")]
		private bool IsStatCondition
		{
			[Token(Token = "0x6000488")]
			[Address(RVA = "0x218C660", Offset = "0x218AC60", VA = "0x18218C660")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x00003DE0 File Offset: 0x00001FE0
		[Token(Token = "0x17000051")]
		private bool IsStateCondition
		{
			[Token(Token = "0x6000489")]
			[Address(RVA = "0x2B18330", Offset = "0x2B16930", VA = "0x182B18330")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600048A RID: 1162 RVA: 0x00003DF8 File Offset: 0x00001FF8
		[Token(Token = "0x17000052")]
		private bool IsTimeOfDayCondition
		{
			[Token(Token = "0x600048A")]
			[Address(RVA = "0x2B18340", Offset = "0x2B16940", VA = "0x182B18340")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x00003E10 File Offset: 0x00002010
		[Token(Token = "0x17000053")]
		private bool IsDistanceCondition
		{
			[Token(Token = "0x600048B")]
			[Address(RVA = "0x2B18350", Offset = "0x2B16950", VA = "0x182B18350")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600048C RID: 1164 RVA: 0x00003E28 File Offset: 0x00002028
		[Token(Token = "0x17000054")]
		private bool IsMovementSpeedCondition
		{
			[Token(Token = "0x600048C")]
			[Address(RVA = "0x2B18380", Offset = "0x2B16980", VA = "0x182B18380")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600048D RID: 1165 RVA: 0x00003E40 File Offset: 0x00002040
		[Token(Token = "0x17000055")]
		private bool IsAnimTagActiveCondition
		{
			[Token(Token = "0x600048D")]
			[Address(RVA = "0x2B18390", Offset = "0x2B16990", VA = "0x182B18390")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600048E RID: 1166 RVA: 0x00003E58 File Offset: 0x00002058
		[Token(Token = "0x17000056")]
		private bool IsRandomCondition
		{
			[Token(Token = "0x600048E")]
			[Address(RVA = "0x2B183B0", Offset = "0x2B169B0", VA = "0x182B183B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x00003E70 File Offset: 0x00002070
		[Token(Token = "0x17000057")]
		private bool IsSeasonCondition
		{
			[Token(Token = "0x600048F")]
			[Address(RVA = "0x2B183C0", Offset = "0x2B169C0", VA = "0x182B183C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x00003E88 File Offset: 0x00002088
		[Token(Token = "0x17000058")]
		private bool IsMemoryEventCondition
		{
			[Token(Token = "0x6000490")]
			[Address(RVA = "0x2B183E0", Offset = "0x2B169E0", VA = "0x182B183E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x00003EA0 File Offset: 0x000020A0
		[Token(Token = "0x17000059")]
		private bool IsActorTypeCondition
		{
			[Token(Token = "0x6000491")]
			[Address(RVA = "0x2B183F0", Offset = "0x2B169F0", VA = "0x182B183F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000492 RID: 1170 RVA: 0x00003EB8 File Offset: 0x000020B8
		[Token(Token = "0x1700005A")]
		public bool InterruptsAction
		{
			[Token(Token = "0x6000492")]
			[Address(RVA = "0x612480", Offset = "0x610A80", VA = "0x180612480")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x00003ED0 File Offset: 0x000020D0
		[Token(Token = "0x1700005B")]
		public bool ShowInterrupt
		{
			[Token(Token = "0x6000493")]
			[Address(RVA = "0x2B18400", Offset = "0x2B16A00", VA = "0x182B18400")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000494")]
		[Address(RVA = "0x2B18420", Offset = "0x2B16A20", VA = "0x182B18420")]
		private static ValueDropdownList<string> GetStatChoices()
		{
			return null;
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000495")]
		[Address(RVA = "0x2B18440", Offset = "0x2B16A40", VA = "0x182B18440")]
		private static ValueDropdownList<string> GetInventoryItemTypes()
		{
			return null;
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000496")]
		[Address(RVA = "0x2B18480", Offset = "0x2B16A80", VA = "0x182B18480")]
		private IEnumerable GetAnimationTags()
		{
			return null;
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00003EE8 File Offset: 0x000020E8
		[Token(Token = "0x6000497")]
		[Address(RVA = "0x2B18530", Offset = "0x2B16B30", VA = "0x182B18530")]
		private bool CanChangeTargetType()
		{
			return default(bool);
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00003F00 File Offset: 0x00002100
		[Token(Token = "0x6000498")]
		[Address(RVA = "0x2B18560", Offset = "0x2B16B60", VA = "0x182B18560")]
		private Color GetStateButtonColor()
		{
			return default(Color);
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000499")]
		[Address(RVA = "0x2B185F0", Offset = "0x2B16BF0", VA = "0x182B185F0")]
		private IEnumerable GetStateTreeView()
		{
			return null;
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00003F18 File Offset: 0x00002118
		[Token(Token = "0x600049A")]
		[Address(RVA = "0x2B18630", Offset = "0x2B16C30", VA = "0x182B18630")]
		private bool ShouldShowConditionalOperator()
		{
			return default(bool);
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x600049B")]
		[Address(RVA = "0x2B18800", Offset = "0x2B16E00", VA = "0x182B18800")]
		private string GetValueOverlay()
		{
			return null;
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00003F30 File Offset: 0x00002130
		[Token(Token = "0x600049C")]
		[Address(RVA = "0x2B18840", Offset = "0x2B16E40", VA = "0x182B18840")]
		private bool RefreshRelatedStat()
		{
			return default(bool);
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00003F48 File Offset: 0x00002148
		[Token(Token = "0x600049D")]
		[Address(RVA = "0x2B18990", Offset = "0x2B16F90", VA = "0x182B18990")]
		private bool MatchAssignedValue(IEnumerable<Stat> source, string prefix, ref Stat target)
		{
			return default(bool);
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600049E")]
		[Address(RVA = "0x2B18B70", Offset = "0x2B17170", VA = "0x182B18B70")]
		public void OnValidate(Group group)
		{
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x600049F")]
		[Address(RVA = "0x2B18E40", Offset = "0x2B17440", VA = "0x182B18E40")]
		private VailActor TryGetTargetActorForCondition(VailActor actor, object stimuli)
		{
			return null;
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00003F60 File Offset: 0x00002160
		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x2B18F10", Offset = "0x2B17510", VA = "0x182B18F10")]
		public bool Matches(VailActor actor, IStimuli stimuli)
		{
			return default(bool);
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00003F78 File Offset: 0x00002178
		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x2B1AE00", Offset = "0x2B19400", VA = "0x182B1AE00")]
		private bool InWaterCondition(VailActor actor, IStimuli stimuli)
		{
			return default(bool);
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00003F90 File Offset: 0x00002190
		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x2B1B150", Offset = "0x2B19750", VA = "0x182B1B150")]
		private bool IsStealthCondition(IStimuli stimuli)
		{
			return default(bool);
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00003FA8 File Offset: 0x000021A8
		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x2B1B1C0", Offset = "0x2B197C0", VA = "0x182B1B1C0")]
		private bool TargetIsLow(IStimuli stimuli)
		{
			return default(bool);
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00003FC0 File Offset: 0x000021C0
		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x2B1B330", Offset = "0x2B19930", VA = "0x182B1B330")]
		private bool CanSpawnActor(VailActor srcActor, VailActorTypeId spawnActorType)
		{
			return default(bool);
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00003FD8 File Offset: 0x000021D8
		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x2B1B430", Offset = "0x2B19A30", VA = "0x182B1B430")]
		private bool HasVailAnimTag(IStimuli stimuli, VailAnimStateTag tag)
		{
			return default(bool);
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00003FF0 File Offset: 0x000021F0
		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x2B1B580", Offset = "0x2B19B80", VA = "0x182B1B580")]
		private bool FighterIsWaiting(IStimuli stimuli)
		{
			return default(bool);
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00004008 File Offset: 0x00002208
		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x2B1B6A0", Offset = "0x2B19CA0", VA = "0x182B1B6A0")]
		private bool InVillageCondition(VailActor actor, object stimuli)
		{
			return default(bool);
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00004020 File Offset: 0x00002220
		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x2B1B7D0", Offset = "0x2B19DD0", VA = "0x182B1B7D0")]
		private bool IsOnSand(VailActor actor)
		{
			return default(bool);
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00004038 File Offset: 0x00002238
		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x2B1BB70", Offset = "0x2B1A170", VA = "0x182B1BB70")]
		private bool IsNearBush(VailActor actor, IStimuli stimuli)
		{
			return default(bool);
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00004050 File Offset: 0x00002250
		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x2B1BCA0", Offset = "0x2B1A2A0", VA = "0x182B1BCA0")]
		private bool RandomCondition(VailActor actor)
		{
			return default(bool);
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00004068 File Offset: 0x00002268
		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x2B1BF80", Offset = "0x2B1A580", VA = "0x182B1BF80")]
		private bool TimeOfDayCondition()
		{
			return default(bool);
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00004080 File Offset: 0x00002280
		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x2B1C030", Offset = "0x2B1A630", VA = "0x182B1C030")]
		private bool SeasonCondition()
		{
			return default(bool);
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00004098 File Offset: 0x00002298
		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x2B1C090", Offset = "0x2B1A690", VA = "0x182B1C090")]
		private bool PlayerDistanceCondition(VailActor actor, object stimuli)
		{
			return default(bool);
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x000040B0 File Offset: 0x000022B0
		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x2B1C270", Offset = "0x2B1A870", VA = "0x182B1C270")]
		private bool PlayerDirectionCondition(VailActor actor)
		{
			return default(bool);
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x000040C8 File Offset: 0x000022C8
		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x2B1C7F0", Offset = "0x2B1ADF0", VA = "0x182B1C7F0")]
		private bool InPlayerViewCondition(VailActor actor)
		{
			return default(bool);
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x000040E0 File Offset: 0x000022E0
		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x2B1CA90", Offset = "0x2B1B090", VA = "0x182B1CA90")]
		private bool StimuliHasNoWeapon(object stimuli)
		{
			return default(bool);
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x000040F8 File Offset: 0x000022F8
		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x2B1CB00", Offset = "0x2B1B100", VA = "0x182B1CB00")]
		private bool StimuliIsFamily(VailActor actor, object stimuli)
		{
			return default(bool);
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00004110 File Offset: 0x00002310
		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x2B1CCF0", Offset = "0x2B1B2F0", VA = "0x182B1CCF0")]
		private bool NotTowardsGoalCondition(VailActor actor, object stimuli)
		{
			return default(bool);
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00004128 File Offset: 0x00002328
		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x2B1CE60", Offset = "0x2B1B460", VA = "0x182B1CE60")]
		private bool PassesByPlayer(VailActor actor, object stimuli)
		{
			return default(bool);
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00004140 File Offset: 0x00002340
		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x2B1D010", Offset = "0x2B1B610", VA = "0x182B1D010")]
		private bool PassesByMutant(VailActor actor, object stimuli)
		{
			return default(bool);
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00004158 File Offset: 0x00002358
		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x2B1D1C0", Offset = "0x2B1B7C0", VA = "0x182B1D1C0")]
		private bool NavmeshCastBlocked(VailActor actor, object stimuli)
		{
			return default(bool);
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00004170 File Offset: 0x00002370
		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x2B1D390", Offset = "0x2B1B990", VA = "0x182B1D390")]
		private bool DistanceCondition(VailActor actor, object stimuli, bool ignoreY = false)
		{
			return default(bool);
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00004188 File Offset: 0x00002388
		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x2B1D5B0", Offset = "0x2B1BBB0", VA = "0x182B1D5B0")]
		private bool DistanceAboveGroundCondition(VailActor actor)
		{
			return default(bool);
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x000041A0 File Offset: 0x000023A0
		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x2B1D660", Offset = "0x2B1BC60", VA = "0x182B1D660")]
		private bool DistanceToPathBoundsCondition(VailActor actor, object stimuli)
		{
			return default(bool);
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x000041B8 File Offset: 0x000023B8
		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x2B1D8E0", Offset = "0x2B1BEE0", VA = "0x182B1D8E0")]
		private bool DirectionCondition(VailActor actor, object stimuli)
		{
			return default(bool);
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x000041D0 File Offset: 0x000023D0
		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x2B1DB70", Offset = "0x2B1C170", VA = "0x182B1DB70")]
		private bool VerticalOffsetCondition(VailActor actor, object stimuli)
		{
			return default(bool);
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x000041E8 File Offset: 0x000023E8
		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x2B1DD30", Offset = "0x2B1C330", VA = "0x182B1DD30")]
		private bool MemoryEventCondition(VailActor actor)
		{
			return default(bool);
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00004200 File Offset: 0x00002400
		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x2B1DDD0", Offset = "0x2B1C3D0", VA = "0x182B1DDD0")]
		private bool ShouldFightCondition(VailActor actor, IStimuli stimuli)
		{
			return default(bool);
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00004218 File Offset: 0x00002418
		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x2B1E000", Offset = "0x2B1C600", VA = "0x182B1E000")]
		private bool CannibalAngerCondition()
		{
			return default(bool);
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00004230 File Offset: 0x00002430
		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x2B1E0C0", Offset = "0x2B1C6C0", VA = "0x182B1E0C0")]
		private bool MovementSpeedCondition(VailActor actor, object stimuli)
		{
			return default(bool);
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00004248 File Offset: 0x00002448
		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x2B1E200", Offset = "0x2B1C800", VA = "0x182B1E200")]
		private bool IsAnimTagCondition(VailActor actor)
		{
			return default(bool);
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00004260 File Offset: 0x00002460
		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x2B1E2A0", Offset = "0x2B1C8A0", VA = "0x182B1E2A0")]
		private bool StateCondition(VailActor actor, object stimuli, State state)
		{
			return default(bool);
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00004278 File Offset: 0x00002478
		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x2B1E3D0", Offset = "0x2B1C9D0", VA = "0x182B1E3D0")]
		private bool InventoryCondition(VailActor actor, object stimuli, string itemType, ConditionOperator conditionOperator, float value)
		{
			return default(bool);
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00004290 File Offset: 0x00002490
		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x2B1E530", Offset = "0x2B1CB30", VA = "0x182B1E530")]
		private bool IsCarryingObject(VailActor actor)
		{
			return default(bool);
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x000042A8 File Offset: 0x000024A8
		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x2B1E580", Offset = "0x2B1CB80", VA = "0x182B1E580")]
		private bool EquippedCondition(VailActor actor, string itemType, ConditionOperator conditionOperator, float value)
		{
			return default(bool);
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x000042C0 File Offset: 0x000024C0
		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x2B1E730", Offset = "0x2B1CD30", VA = "0x182B1E730")]
		private bool NeedsItemCondition(VailActor actor, string itemType, ConditionOperator conditionOperator, float value)
		{
			return default(bool);
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x000042D8 File Offset: 0x000024D8
		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x2B1E910", Offset = "0x2B1CF10", VA = "0x182B1E910")]
		private bool ShouldPlaceCarriedItems(VailActor actor)
		{
			return default(bool);
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x000042F0 File Offset: 0x000024F0
		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x2B1EA20", Offset = "0x2B1D020", VA = "0x182B1EA20")]
		private bool StateTimeCondition(VailActor actor, ConditionOperator conditionOperator, float value)
		{
			return default(bool);
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00004308 File Offset: 0x00002508
		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x2B1EAF0", Offset = "0x2B1D0F0", VA = "0x182B1EAF0")]
		private bool CombatTimeCondition(VailActor actor, ConditionOperator conditionOperator, float value)
		{
			return default(bool);
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00004320 File Offset: 0x00002520
		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x2B1EBD0", Offset = "0x2B1D1D0", VA = "0x182B1EBD0")]
		private bool BuildStageCondition(IStimuli stimuli, ConditionOperator conditionOperator, float value)
		{
			return default(bool);
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00004338 File Offset: 0x00002538
		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x2B1ED40", Offset = "0x2B1D340", VA = "0x182B1ED40")]
		private bool HeavyAttackCondition(IStimuli stimuli)
		{
			return default(bool);
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00004350 File Offset: 0x00002550
		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x2B1EE60", Offset = "0x2B1D460", VA = "0x182B1EE60")]
		private bool HasOrders(VailActor actor)
		{
			return default(bool);
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00004368 File Offset: 0x00002568
		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x2B1EEB0", Offset = "0x2B1D4B0", VA = "0x182B1EEB0")]
		private bool OrderTimeCondition(VailActor actor, ConditionOperator conditionOperator, float value)
		{
			return default(bool);
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00004380 File Offset: 0x00002580
		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x2B1EFC0", Offset = "0x2B1D5C0", VA = "0x182B1EFC0")]
		private bool IsVariationId(VailActor actor, ConditionOperator conditionOperator, float value)
		{
			return default(bool);
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00004398 File Offset: 0x00002598
		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x2B1F050", Offset = "0x2B1D650", VA = "0x182B1F050")]
		private bool GroupSizeCondition(VailActor actor, ConditionOperator conditionOperator, float value)
		{
			return default(bool);
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x000043B0 File Offset: 0x000025B0
		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x2B1F150", Offset = "0x2B1D750", VA = "0x182B1F150")]
		private bool PlayerSentimentCondition(VailActor actor, ConditionOperator conditionOperator, float value)
		{
			return default(bool);
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x000043C8 File Offset: 0x000025C8
		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x2B1F1F0", Offset = "0x2B1D7F0", VA = "0x182B1F1F0")]
		private bool StimuliTimeAliveCondition(object stimuli, ConditionOperator conditionOperator, float value)
		{
			return default(bool);
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x000043E0 File Offset: 0x000025E0
		[Token(Token = "0x60004D0")]
		private bool StatCondition<T>(VailActor actor, IStimuli stimuli, T relatedStat, ConditionOperator conditionOperator, float value, out bool passed) where T : Stat
		{
			return default(bool);
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x000043F8 File Offset: 0x000025F8
		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x2B1F2E0", Offset = "0x2B1D8E0", VA = "0x182B1F2E0")]
		private static bool IsTrue(float sample, ConditionOperator conditionOperator, float value)
		{
			return default(bool);
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00004410 File Offset: 0x00002610
		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x2B1F370", Offset = "0x2B1D970", VA = "0x182B1F370")]
		public static bool GoalConditionCheck(VailActor actor, Vector3 stimuliPos)
		{
			return default(bool);
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00004428 File Offset: 0x00002628
		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x2B1F960", Offset = "0x2B1DF60", VA = "0x182B1F960")]
		public static bool PassesByPlayer(VailActor actor, Vector3 stimuliPos)
		{
			return default(bool);
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00004440 File Offset: 0x00002640
		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x2B1F9F0", Offset = "0x2B1DFF0", VA = "0x182B1F9F0")]
		public static bool PassesByMutant(VailActor actor, Vector3 stimuliPos)
		{
			return default(bool);
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x00004458 File Offset: 0x00002658
		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x2B1FA80", Offset = "0x2B1E080", VA = "0x182B1FA80")]
		private static bool PassesByStimuli(VailActor actor, Vector3 stimuliPos, List<Type> typeList)
		{
			return default(bool);
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x2B20040", Offset = "0x2B1E640", VA = "0x182B20040")]
		public Condition()
		{
		}

		// Token: 0x040003C2 RID: 962
		[Token(Token = "0x40003C2")]
		private const string EquationGroupId = "_equation";

		// Token: 0x040003C3 RID: 963
		[Token(Token = "0x40003C3")]
		private const string EquationGroupTestId = "_equation/test";

		// Token: 0x040003C4 RID: 964
		[Token(Token = "0x40003C4")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Condition.TargetType _targetType;

		// Token: 0x040003C5 RID: 965
		[Token(Token = "0x40003C5")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private ConditionType _conditionType;

		// Token: 0x040003C6 RID: 966
		[Token(Token = "0x40003C6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private State _state;

		// Token: 0x040003C7 RID: 967
		[Token(Token = "0x40003C7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _inventoryItemName;

		// Token: 0x040003C8 RID: 968
		[Token(Token = "0x40003C8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private MemoryEvent _memoryEvent;

		// Token: 0x040003C9 RID: 969
		[Token(Token = "0x40003C9")]
		[FieldOffset(Offset = "0x48")]
		[FormerlySerializedAs("_relatedStat")]
		[SerializeField]
		[SerializeReference]
		private string _relatedStatOrTraitId;

		// Token: 0x040003CA RID: 970
		[Token(Token = "0x40003CA")]
		[FieldOffset(Offset = "0x50")]
		private Stat _relatedStatOrTrait;

		// Token: 0x040003CB RID: 971
		[Token(Token = "0x40003CB")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ConditionOperator _operator;

		// Token: 0x040003CC RID: 972
		[Token(Token = "0x40003CC")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _value;

		// Token: 0x040003CD RID: 973
		[Token(Token = "0x40003CD")]
		[FieldOffset(Offset = "0x60")]
		[HideInInspector]
		[SerializeField]
		private bool _checkAgainstEventProxyTarget;

		// Token: 0x040003CE RID: 974
		[Token(Token = "0x40003CE")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private Condition.TimeOfDayType _timeOfDayValue;

		// Token: 0x040003CF RID: 975
		[Token(Token = "0x40003CF")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private SeasonsManager.Season _seasonValue;

		// Token: 0x040003D0 RID: 976
		[Token(Token = "0x40003D0")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float _randomCheckRate;

		// Token: 0x040003D1 RID: 977
		[Token(Token = "0x40003D1")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<AnimationParameter> _animTagHashes;

		// Token: 0x040003D2 RID: 978
		[Token(Token = "0x40003D2")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool _interruptsAction;

		// Token: 0x040003D3 RID: 979
		[Token(Token = "0x40003D3")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private VailActorTypeId _actorType;

		// Token: 0x040003D4 RID: 980
		[Token(Token = "0x40003D4")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<Type> PlayerTypeList;

		// Token: 0x040003D5 RID: 981
		[Token(Token = "0x40003D5")]
		[FieldOffset(Offset = "0x8")]
		private static readonly List<Type> MutantTypeList;

		// Token: 0x02000064 RID: 100
		[Token(Token = "0x2000064")]
		public enum TargetType
		{
			// Token: 0x040003D7 RID: 983
			[Token(Token = "0x40003D7")]
			Self,
			// Token: 0x040003D8 RID: 984
			[Token(Token = "0x40003D8")]
			Stimuli
		}

		// Token: 0x02000065 RID: 101
		[Token(Token = "0x2000065")]
		public enum TimeOfDayType
		{
			// Token: 0x040003DA RID: 986
			[Token(Token = "0x40003DA")]
			Day,
			// Token: 0x040003DB RID: 987
			[Token(Token = "0x40003DB")]
			Night
		}
	}
}
