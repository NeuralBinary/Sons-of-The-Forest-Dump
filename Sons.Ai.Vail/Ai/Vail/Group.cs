using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sirenix.OdinInspector;
using Sons.Ai.Vail.Memory;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Ai.Vail
{
	// Token: 0x0200006C RID: 108
	[Token(Token = "0x200006C")]
	[CreateAssetMenu(menuName = "Sons/Ai/Vail Controller Group", fileName = "VailGroup", order = 0)]
	public class Group : ScriptableObject
	{
		// Token: 0x060004EC RID: 1260 RVA: 0x00004518 File Offset: 0x00002718
		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x2B20CA0", Offset = "0x2B1F2A0", VA = "0x182B20CA0")]
		public bool HasConditionSet(ConditionSet conditionSet)
		{
			return default(bool);
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x1700005C")]
		public ConditionSet ConditionSet
		{
			[Token(Token = "0x60004ED")]
			[Address(RVA = "0x661070", Offset = "0x65F670", VA = "0x180661070")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060004EE RID: 1262 RVA: 0x00004530 File Offset: 0x00002730
		[Token(Token = "0x1700005D")]
		private bool GameIsRunning
		{
			[Token(Token = "0x60004EE")]
			[Address(RVA = "0x2B20DD0", Offset = "0x2B1F3D0", VA = "0x182B20DD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x2B20E50", Offset = "0x2B1F450", VA = "0x182B20E50")]
		private void MuteConditions()
		{
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x2B20F90", Offset = "0x2B1F590", VA = "0x182B20F90")]
		private string GetMuteButtonString()
		{
			return null;
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x620F10", Offset = "0x61F510", VA = "0x180620F10")]
		internal List<Thought> GetThoughts()
		{
			return null;
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060004F2 RID: 1266 RVA: 0x00004548 File Offset: 0x00002748
		[Token(Token = "0x1700005E")]
		public bool IsSequenceOnly
		{
			[Token(Token = "0x60004F2")]
			[Address(RVA = "0x8F37B0", Offset = "0x8F1DB0", VA = "0x1808F37B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x00004560 File Offset: 0x00002760
		[Token(Token = "0x1700005F")]
		public float DriverBase
		{
			[Token(Token = "0x60004F3")]
			[Address(RVA = "0x71D320", Offset = "0x71B920", VA = "0x18071D320")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
		internal string Name()
		{
			return null;
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x2B20FE0", Offset = "0x2B1F5E0", VA = "0x182B20FE0")]
		private string GetCooldownHeader()
		{
			return null;
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x2B210C0", Offset = "0x2B1F6C0", VA = "0x182B210C0")]
		public ValueDropdownList<Priority> GetPriorityList()
		{
			return null;
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
		internal Priority GetPriority()
		{
			return null;
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00004578 File Offset: 0x00002778
		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x2B21100", Offset = "0x2B1F700", VA = "0x182B21100")]
		public Color GetGroupPriorityBackgroundColor()
		{
			return default(Color);
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00004590 File Offset: 0x00002790
		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x2B211C0", Offset = "0x2B1F7C0", VA = "0x182B211C0")]
		public Color GetGroupPriorityColor()
		{
			return default(Color);
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x2B211F0", Offset = "0x2B1F7F0", VA = "0x182B211F0")]
		private void OnCooldownMinChanged()
		{
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x2B21220", Offset = "0x2B1F820", VA = "0x182B21220")]
		private void OnCooldownMaxChanged()
		{
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x2B21250", Offset = "0x2B1F850", VA = "0x182B21250")]
		public void OnValidate()
		{
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x1D05D60", Offset = "0x1D04360", VA = "0x181D05D60")]
		public void EditorInit(string name, Priority priority)
		{
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x000045A8 File Offset: 0x000027A8
		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x2B21460", Offset = "0x2B1FA60", VA = "0x182B21460")]
		private bool TryRunThought(Thought thought, VailActor actor, bool isFollowingSequence, bool muteConditions = false)
		{
			return default(bool);
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x000045C0 File Offset: 0x000027C0
		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x2B21580", Offset = "0x2B1FB80", VA = "0x182B21580")]
		public bool Run(VailActor actor, bool isFollowingSequence)
		{
			return default(bool);
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x000045D8 File Offset: 0x000027D8
		[Token(Token = "0x6000500")]
		[Address(RVA = "0x2B21810", Offset = "0x2B1FE10", VA = "0x182B21810")]
		public bool CheckIsolation(out Group sender, out Thought result)
		{
			return default(bool);
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000501")]
		[Address(RVA = "0x2B21A60", Offset = "0x2B20060", VA = "0x182B21A60")]
		public void ClearIsolation()
		{
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000502")]
		[Address(RVA = "0x2B21BC0", Offset = "0x2B201C0", VA = "0x182B21BC0")]
		public void SetMute(bool value)
		{
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x000045F0 File Offset: 0x000027F0
		[Token(Token = "0x6000503")]
		[Address(RVA = "0x2B21C80", Offset = "0x2B20280", VA = "0x182B21C80")]
		public static int Compare(Group x, Group y)
		{
			return 0;
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00004608 File Offset: 0x00002808
		[Token(Token = "0x6000504")]
		[Address(RVA = "0x2B21F10", Offset = "0x2B20510", VA = "0x182B21F10")]
		public float GetRandomCooldown()
		{
			return 0f;
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000505 RID: 1285 RVA: 0x00004620 File Offset: 0x00002820
		[Token(Token = "0x17000060")]
		public bool StartCooldownOnComplete
		{
			[Token(Token = "0x6000505")]
			[Address(RVA = "0x993BD0", Offset = "0x9921D0", VA = "0x180993BD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x00004638 File Offset: 0x00002838
		[Token(Token = "0x17000061")]
		private float CooldownMin
		{
			[Token(Token = "0x6000506")]
			[Address(RVA = "0x781570", Offset = "0x77FB70", VA = "0x180781570")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x00004650 File Offset: 0x00002850
		[Token(Token = "0x17000062")]
		private float CooldownMax
		{
			[Token(Token = "0x6000507")]
			[Address(RVA = "0x23B72F0", Offset = "0x23B58F0", VA = "0x1823B72F0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000508")]
		[Address(RVA = "0x2B21F30", Offset = "0x2B20530", VA = "0x182B21F30")]
		public void CacheDrivers()
		{
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000509")]
		[Address(RVA = "0x2B221C0", Offset = "0x2B207C0", VA = "0x182B221C0")]
		public List<StatDriver> GetDrivers(bool forceRefresh = false)
		{
			return null;
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00004668 File Offset: 0x00002868
		[Token(Token = "0x600050A")]
		[Address(RVA = "0x2B22200", Offset = "0x2B20800", VA = "0x182B22200")]
		public float GetMemoryDriverScore(VailActor actor)
		{
			return 0f;
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600050B")]
		[Address(RVA = "0x2B22400", Offset = "0x2B20A00", VA = "0x182B22400")]
		public Group()
		{
		}

		// Token: 0x04000430 RID: 1072
		[Token(Token = "0x4000430")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _name;

		// Token: 0x04000431 RID: 1073
		[Token(Token = "0x4000431")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Priority _priorityValue;

		// Token: 0x04000432 RID: 1074
		[Token(Token = "0x4000432")]
		[FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("_statPriorityLinks")]
		[SerializeField]
		private List<StatDriver> _drivers;

		// Token: 0x04000433 RID: 1075
		[Token(Token = "0x4000433")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<MemoryEvent> _memoryDrivers;

		// Token: 0x04000434 RID: 1076
		[Token(Token = "0x4000434")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Range(-1f, 1f)]
		private float _driverBase;

		// Token: 0x04000435 RID: 1077
		[Token(Token = "0x4000435")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private bool _sequenceOnly;

		// Token: 0x04000436 RID: 1078
		[Token(Token = "0x4000436")]
		[FieldOffset(Offset = "0x40")]
		[Header("Cooldown random range:")]
		[SerializeField]
		private float _cooldownMin;

		// Token: 0x04000437 RID: 1079
		[Token(Token = "0x4000437")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _cooldownMax;

		// Token: 0x04000438 RID: 1080
		[Token(Token = "0x4000438")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool _startCooldownOnComplete;

		// Token: 0x04000439 RID: 1081
		[Token(Token = "0x4000439")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ConditionSet _conditionSet;

		// Token: 0x0400043A RID: 1082
		[Token(Token = "0x400043A")]
		[FieldOffset(Offset = "0x58")]
		private bool _muteConditions;

		// Token: 0x0400043B RID: 1083
		[Token(Token = "0x400043B")]
		[FieldOffset(Offset = "0x60")]
		[Header("$GetCooldownHeader")]
		[SerializeField]
		private List<Thought> _thoughts;

		// Token: 0x0400043C RID: 1084
		[Token(Token = "0x400043C")]
		[FieldOffset(Offset = "0x68")]
		private List<StatDriver> _cachedDrivers;
	}
}
