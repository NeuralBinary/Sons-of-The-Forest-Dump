using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Ai.Vail
{
	// Token: 0x02000091 RID: 145
	[Token(Token = "0x2000091")]
	[CreateAssetMenu(menuName = "Sons/Ai/Project Settings", fileName = "VailProjectSettings", order = 0)]
	public class ProjectSettings : ScriptableObject
	{
		// Token: 0x060005E8 RID: 1512 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x2B300D0", Offset = "0x2B2E6D0", VA = "0x182B300D0")]
		public static List<ProjectSettings.AttentionFrequencyRanges> AttentionFrequencies()
		{
			return null;
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00004980 File Offset: 0x00002B80
		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x2B30170", Offset = "0x2B2E770", VA = "0x182B30170")]
		private static bool Initialize()
		{
			return default(bool);
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00004998 File Offset: 0x00002B98
		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x2B30320", Offset = "0x2B2E920", VA = "0x182B30320")]
		public static float GetRecentlySeenVisionRangeMultiplier()
		{
			return 0f;
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x000049B0 File Offset: 0x00002BB0
		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x2B30380", Offset = "0x2B2E980", VA = "0x182B30380")]
		public static float GetNightVisionRangeMultiplier()
		{
			return 0f;
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x000049C8 File Offset: 0x00002BC8
		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x2B303E0", Offset = "0x2B2E9E0", VA = "0x182B303E0")]
		public static int GetVisionBlockLayerMask()
		{
			return 0;
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x000049E0 File Offset: 0x00002BE0
		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x2B30440", Offset = "0x2B2EA40", VA = "0x182B30440")]
		public static int StandableLayerMask()
		{
			return 0;
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x000049F8 File Offset: 0x00002BF8
		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x2B304A0", Offset = "0x2B2EAA0", VA = "0x182B304A0")]
		public static int GetAutoJumpCastLayerMask()
		{
			return 0;
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00004A10 File Offset: 0x00002C10
		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x2B30500", Offset = "0x2B2EB00", VA = "0x182B30500")]
		public static float GetFindPathTimeout()
		{
			return 0f;
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00004A28 File Offset: 0x00002C28
		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x2B30560", Offset = "0x2B2EB60", VA = "0x182B30560")]
		public static float GetNoProgressTimeout()
		{
			return 0f;
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00004A40 File Offset: 0x00002C40
		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x2B305C0", Offset = "0x2B2EBC0", VA = "0x182B305C0")]
		public static float GetMovementStuckTimeout()
		{
			return 0f;
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x00004A58 File Offset: 0x00002C58
		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x2B30620", Offset = "0x2B2EC20", VA = "0x182B30620")]
		public static float GetMovementStuckMaxDistance()
		{
			return 0f;
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00004A70 File Offset: 0x00002C70
		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x2B30680", Offset = "0x2B2EC80", VA = "0x182B30680")]
		public static bool ShowBaseStimuliGizmos()
		{
			return default(bool);
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00004A88 File Offset: 0x00002C88
		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x2B306E0", Offset = "0x2B2ECE0", VA = "0x182B306E0")]
		public static bool ShowDebugOverlayOnStart()
		{
			return default(bool);
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x00004AA0 File Offset: 0x00002CA0
		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x2B30740", Offset = "0x2B2ED40", VA = "0x182B30740")]
		public static float GetEnemyHealthMultiplier(VailActorTypeId typeId)
		{
			return 0f;
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00004AB8 File Offset: 0x00002CB8
		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x2B30850", Offset = "0x2B2EE50", VA = "0x182B30850")]
		public static float GetEnemyArmourHealthMultiplier()
		{
			return 0f;
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00004AD0 File Offset: 0x00002CD0
		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x2B30940", Offset = "0x2B2EF40", VA = "0x182B30940")]
		private static bool IsEnemy(VailActorTypeId typeId)
		{
			return default(bool);
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x00004AE8 File Offset: 0x00002CE8
		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x2B30960", Offset = "0x2B2EF60", VA = "0x182B30960")]
		public static float GetEnemyDamageMultiplier(VailActorTypeId typeId)
		{
			return 0f;
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00004B00 File Offset: 0x00002D00
		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x2B30A70", Offset = "0x2B2F070", VA = "0x182B30A70")]
		public static float GetEnemyAggression(VailActorTypeId typeId)
		{
			return 0f;
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00004B18 File Offset: 0x00002D18
		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x2B30C00", Offset = "0x2B2F200", VA = "0x182B30C00")]
		public static float GetEnemyArmourMultiplier()
		{
			return 0f;
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x2B30D80", Offset = "0x2B2F380", VA = "0x182B30D80")]
		public static ProjectSettings.CannibalArmorSettings GetCannibalArmorSettings()
		{
			return null;
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x2B30E20", Offset = "0x2B2F420", VA = "0x182B30E20")]
		public static ProjectSettings.CannibalSentimentSettings GetCannibalSentimentSettings()
		{
			return null;
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00004B30 File Offset: 0x00002D30
		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x2B30EA0", Offset = "0x2B2F4A0", VA = "0x182B30EA0")]
		private float GetAnimalCountMultiplier()
		{
			return 0f;
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00004B48 File Offset: 0x00002D48
		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x2B31010", Offset = "0x2B2F610", VA = "0x182B31010")]
		public static float GetSpawnCountModifier(VailActorTypeId typeId, bool isWinter)
		{
			return 0f;
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x2B31250", Offset = "0x2B2F850", VA = "0x182B31250")]
		public ProjectSettings()
		{
		}

		// Token: 0x040004B1 RID: 1201
		[Token(Token = "0x40004B1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<ProjectSettings.AttentionFrequencyRanges> _attentionFrequencyRanges;

		// Token: 0x040004B2 RID: 1202
		[Token(Token = "0x40004B2")]
		private const string Path = "Data/VailProjectSettings";

		// Token: 0x040004B3 RID: 1203
		[Token(Token = "0x40004B3")]
		[FieldOffset(Offset = "0x0")]
		private static bool _initialized;

		// Token: 0x040004B4 RID: 1204
		[Token(Token = "0x40004B4")]
		[FieldOffset(Offset = "0x8")]
		private static ProjectSettings _instance;

		// Token: 0x040004B5 RID: 1205
		[Token(Token = "0x40004B5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("_stimuliVisionRangeMultiplier")]
		private float _recentlySeenVisionRangeMultiplier;

		// Token: 0x040004B6 RID: 1206
		[Token(Token = "0x40004B6")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _nightVisionRangeMultiplier;

		// Token: 0x040004B7 RID: 1207
		[Token(Token = "0x40004B7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LayerMask _visionBlockLayerMask;

		// Token: 0x040004B8 RID: 1208
		[Token(Token = "0x40004B8")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private LayerMask _standableLayerMask;

		// Token: 0x040004B9 RID: 1209
		[Token(Token = "0x40004B9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private LayerMask _autoJumpCastLayerMask;

		// Token: 0x040004BA RID: 1210
		[Token(Token = "0x40004BA")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _findPathTimeout;

		// Token: 0x040004BB RID: 1211
		[Token(Token = "0x40004BB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _noProgressTimeout;

		// Token: 0x040004BC RID: 1212
		[Token(Token = "0x40004BC")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _movementStuckTimeout;

		// Token: 0x040004BD RID: 1213
		[Token(Token = "0x40004BD")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _movementStuckMaxDistance;

		// Token: 0x040004BE RID: 1214
		[Token(Token = "0x40004BE")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private bool _showBaseStimuliGizmos;

		// Token: 0x040004BF RID: 1215
		[Token(Token = "0x40004BF")]
		[FieldOffset(Offset = "0x45")]
		[SerializeField]
		private bool _showDebugOverlayOnStart;

		// Token: 0x040004C0 RID: 1216
		[Token(Token = "0x40004C0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _enemyHealthLowMult;

		// Token: 0x040004C1 RID: 1217
		[Token(Token = "0x40004C1")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float _enemyHealthHighMult;

		// Token: 0x040004C2 RID: 1218
		[Token(Token = "0x40004C2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _enemyArmorHealthLowMult;

		// Token: 0x040004C3 RID: 1219
		[Token(Token = "0x40004C3")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float _enemyArmorHealthHighMult;

		// Token: 0x040004C4 RID: 1220
		[Token(Token = "0x40004C4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _enemyDamageLowMult;

		// Token: 0x040004C5 RID: 1221
		[Token(Token = "0x40004C5")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _enemyDamageHighMult;

		// Token: 0x040004C6 RID: 1222
		[Token(Token = "0x40004C6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _enemyArmourHighMult;

		// Token: 0x040004C7 RID: 1223
		[Token(Token = "0x40004C7")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float _enemyArmourLowMult;

		// Token: 0x040004C8 RID: 1224
		[Token(Token = "0x40004C8")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _enemyAggressionHighMult;

		// Token: 0x040004C9 RID: 1225
		[Token(Token = "0x40004C9")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float _enemyAggressionLowMult;

		// Token: 0x040004CA RID: 1226
		[Token(Token = "0x40004CA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ProjectSettings.CannibalArmorSettings _cannibalArmor;

		// Token: 0x040004CB RID: 1227
		[Token(Token = "0x40004CB")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ProjectSettings.CannibalSentimentSettings _cannibalSentiment;

		// Token: 0x040004CC RID: 1228
		[Token(Token = "0x40004CC")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private VailSpawnModifiers _winterSpawnModifiers;

		// Token: 0x040004CD RID: 1229
		[Token(Token = "0x40004CD")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float _animalAmountHighMult;

		// Token: 0x040004CE RID: 1230
		[Token(Token = "0x40004CE")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private float _animalAmountLowMult;

		// Token: 0x02000092 RID: 146
		[Token(Token = "0x2000092")]
		[Serializable]
		public class AttentionFrequencyRanges
		{
			// Token: 0x06000600 RID: 1536 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000600")]
			[Address(RVA = "0x2B31580", Offset = "0x2B2FB80", VA = "0x182B31580")]
			public AttentionFrequencyRanges(Attention.Frequency frequency, Vector2 range, bool showRange)
			{
			}

			// Token: 0x040004CF RID: 1231
			[Token(Token = "0x40004CF")]
			[FieldOffset(Offset = "0x10")]
			public Attention.Frequency _frequency;

			// Token: 0x040004D0 RID: 1232
			[Token(Token = "0x40004D0")]
			[FieldOffset(Offset = "0x14")]
			public Vector2 _range;

			// Token: 0x040004D1 RID: 1233
			[Token(Token = "0x40004D1")]
			[FieldOffset(Offset = "0x1C")]
			private bool _showRange;
		}

		// Token: 0x02000093 RID: 147
		[Token(Token = "0x2000093")]
		[Serializable]
		public class CannibalArmorSettings
		{
			// Token: 0x06000601 RID: 1537 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000601")]
			[Address(RVA = "0x2B31590", Offset = "0x2B2FB90", VA = "0x182B31590")]
			public CannibalArmorSettings()
			{
			}

			// Token: 0x040004D2 RID: 1234
			[Token(Token = "0x40004D2")]
			[FieldOffset(Offset = "0x10")]
			public int _cannibalKillsForMax;

			// Token: 0x040004D3 RID: 1235
			[Token(Token = "0x40004D3")]
			[FieldOffset(Offset = "0x14")]
			public int _daysForMax;

			// Token: 0x040004D4 RID: 1236
			[Token(Token = "0x40004D4")]
			[FieldOffset(Offset = "0x18")]
			public float _tierOneFactor;

			// Token: 0x040004D5 RID: 1237
			[Token(Token = "0x40004D5")]
			[FieldOffset(Offset = "0x1C")]
			public float _tierTwoFactor;

			// Token: 0x040004D6 RID: 1238
			[Token(Token = "0x40004D6")]
			[FieldOffset(Offset = "0x20")]
			public float _tierThreeFactor;
		}

		// Token: 0x02000094 RID: 148
		[Token(Token = "0x2000094")]
		[Serializable]
		public class CannibalSentimentSettings
		{
			// Token: 0x06000602 RID: 1538 RVA: 0x00004B60 File Offset: 0x00002D60
			[Token(Token = "0x6000602")]
			[Address(RVA = "0x2B315C0", Offset = "0x2B2FBC0", VA = "0x182B315C0")]
			public float GetAngerMultiplier(VailActorTypeId typeId)
			{
				return 0f;
			}

			// Token: 0x06000603 RID: 1539 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000603")]
			[Address(RVA = "0x2B315E0", Offset = "0x2B2FBE0", VA = "0x182B315E0")]
			public CannibalSentimentSettings()
			{
			}

			// Token: 0x040004D7 RID: 1239
			[Token(Token = "0x40004D7")]
			[FieldOffset(Offset = "0x10")]
			public float _playerAngerMultiplier;

			// Token: 0x040004D8 RID: 1240
			[Token(Token = "0x40004D8")]
			[FieldOffset(Offset = "0x14")]
			public float _playerAngerMuddyMultiplier;
		}
	}
}
