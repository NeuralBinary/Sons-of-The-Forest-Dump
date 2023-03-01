using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using Pathfinding;
using Sirenix.OdinInspector;
using Sons.Ai.Vail;
using Sons.Areas;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Characters
{
	// Token: 0x02000818 RID: 2072
	[Token(Token = "0x2000818")]
	[AddComponentMenu("Sons/Vail/Creepy Cave")]
	[Serializable]
	public class CreepyCave : VailZoneBase
	{
		// Token: 0x0600372B RID: 14123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600372B")]
		[Address(RVA = "0x2EB6AF0", Offset = "0x2EB5AF0", VA = "0x182EB6AF0")]
		private ValueDropdownList<string> GetNavGraphLabels()
		{
			return null;
		}

		// Token: 0x0600372C RID: 14124 RVA: 0x00010218 File Offset: 0x0000E418
		[Token(Token = "0x600372C")]
		[Address(RVA = "0x9862E0", Offset = "0x9852E0", VA = "0x1809862E0", Slot = "11")]
		public override GraphMask GetNavGraphMask()
		{
			return default(GraphMask);
		}

		// Token: 0x0600372D RID: 14125 RVA: 0x00010230 File Offset: 0x0000E430
		[Token(Token = "0x600372D")]
		[Address(RVA = "0x8E3D80", Offset = "0x8E2D80", VA = "0x1808E3D80", Slot = "5")]
		public override AreaMask GetAreaMask()
		{
			return default(AreaMask);
		}

		// Token: 0x0600372E RID: 14126 RVA: 0x00010248 File Offset: 0x0000E448
		[Token(Token = "0x600372E")]
		[Address(RVA = "0x2EB7890", Offset = "0x2EB6890", VA = "0x182EB7890", Slot = "4")]
		public override VailZoneId ZoneType()
		{
			return default(VailZoneId);
		}

		// Token: 0x0600372F RID: 14127 RVA: 0x00010260 File Offset: 0x0000E460
		[Token(Token = "0x600372F")]
		[Address(RVA = "0xC91EB0", Offset = "0xC90EB0", VA = "0x180C91EB0", Slot = "6")]
		public override VailActorClassId ClassFilter()
		{
			return default(VailActorClassId);
		}

		// Token: 0x06003730 RID: 14128 RVA: 0x00010278 File Offset: 0x0000E478
		[Token(Token = "0x6003730")]
		[Address(RVA = "0x2EB6E70", Offset = "0x2EB5E70", VA = "0x182EB6E70")]
		private int InsidePopulation()
		{
			return default(int);
		}

		// Token: 0x06003731 RID: 14129 RVA: 0x00010290 File Offset: 0x0000E490
		[Token(Token = "0x6003731")]
		[Address(RVA = "0x2EB6E80", Offset = "0x2EB5E80", VA = "0x182EB6E80", Slot = "7")]
		public override bool NeedsSpawner()
		{
			return default(bool);
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06003732 RID: 14130 RVA: 0x000102A8 File Offset: 0x0000E4A8
		[Token(Token = "0x170006FD")]
		public bool CaveIsOpen
		{
			[Token(Token = "0x6003732")]
			[Address(RVA = "0x2EB7970", Offset = "0x2EB6970", VA = "0x182EB7970")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003733 RID: 14131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003733")]
		[Address(RVA = "0x2EB7320", Offset = "0x2EB6320", VA = "0x182EB7320", Slot = "8")]
		protected override void Start()
		{
		}

		// Token: 0x06003734 RID: 14132 RVA: 0x000102C0 File Offset: 0x0000E4C0
		[Token(Token = "0x6003734")]
		[Address(RVA = "0x2EB69B0", Offset = "0x2EB59B0", VA = "0x182EB69B0", Slot = "21")]
		public override Vector3 GetCenterPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06003735 RID: 14133 RVA: 0x000102D8 File Offset: 0x0000E4D8
		[Token(Token = "0x6003735")]
		[Address(RVA = "0x2EB62F0", Offset = "0x2EB52F0", VA = "0x182EB62F0")]
		public int CannibalsInArea()
		{
			return default(int);
		}

		// Token: 0x06003736 RID: 14134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003736")]
		[Address(RVA = "0x2EB7010", Offset = "0x2EB6010", VA = "0x182EB7010")]
		public void OnSerialize(VillageManager.CaveData data)
		{
		}

		// Token: 0x06003737 RID: 14135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003737")]
		[Address(RVA = "0x2EB6EF0", Offset = "0x2EB5EF0", VA = "0x182EB6EF0")]
		public void OnDeserialize(VillageManager.CaveData data)
		{
		}

		// Token: 0x06003738 RID: 14136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003738")]
		[Address(RVA = "0x2EB7330", Offset = "0x2EB6330", VA = "0x182EB7330", Slot = "10")]
		public override void Tick(bool server, VailWorldSimulation worldSim)
		{
		}

		// Token: 0x06003739 RID: 14137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003739")]
		[Address(RVA = "0x2EB75A0", Offset = "0x2EB65A0", VA = "0x182EB75A0")]
		private void UpdateSpawns(VailWorldSimulation worldSim)
		{
		}

		// Token: 0x0600373A RID: 14138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600373A")]
		[Address(RVA = "0x2EB70A0", Offset = "0x2EB60A0", VA = "0x182EB70A0")]
		private void SpawnCaveActor(VailWorldSimulation worldSim)
		{
		}

		// Token: 0x0600373B RID: 14139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600373B")]
		[Address(RVA = "0x2EB6F90", Offset = "0x2EB5F90", VA = "0x182EB6F90", Slot = "12")]
		public override void OnLinkSpawner(IVailSpawner caveSpawner)
		{
		}

		// Token: 0x0600373C RID: 14140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600373C")]
		[Address(RVA = "0x2EB6EB0", Offset = "0x2EB5EB0", VA = "0x182EB6EB0", Slot = "14")]
		public override void OnActorTeleport(AreaMask oldCaveMask, AreaMask newCaveMask)
		{
		}

		// Token: 0x0600373D RID: 14141 RVA: 0x000102F0 File Offset: 0x0000E4F0
		[Token(Token = "0x600373D")]
		[Address(RVA = "0x2EB61B0", Offset = "0x2EB51B0", VA = "0x182EB61B0")]
		private GraphMask CalcNavGraphMask()
		{
			return default(GraphMask);
		}

		// Token: 0x0600373E RID: 14142 RVA: 0x00010308 File Offset: 0x0000E508
		[Token(Token = "0x600373E")]
		[Address(RVA = "0x2EB62D0", Offset = "0x2EB52D0", VA = "0x182EB62D0")]
		public bool CanGoInsideCave()
		{
			return default(bool);
		}

		// Token: 0x0600373F RID: 14143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600373F")]
		[Address(RVA = "0x2EB6B30", Offset = "0x2EB5B30", VA = "0x182EB6B30")]
		public IActorZone GetOutsideArea()
		{
			return null;
		}

		// Token: 0x06003740 RID: 14144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003740")]
		[Address(RVA = "0x2EB6710", Offset = "0x2EB5710", VA = "0x182EB6710", Slot = "29")]
		public override string ExtraWorldStats(List<VailZoneBase> zones)
		{
			return null;
		}

		// Token: 0x06003741 RID: 14145 RVA: 0x00010320 File Offset: 0x0000E520
		[Token(Token = "0x6003741")]
		[Address(RVA = "0x2EB65D0", Offset = "0x2EB55D0", VA = "0x182EB65D0", Slot = "28")]
		public override bool ExtraStats(StringBuilder sb)
		{
			return default(bool);
		}

		// Token: 0x06003742 RID: 14146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003742")]
		[Address(RVA = "0x2EB6450", Offset = "0x2EB5450", VA = "0x182EB6450")]
		private void CollectChildrenAsOutsideZones(Transform parent)
		{
		}

		// Token: 0x06003743 RID: 14147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003743")]
		[Address(RVA = "0x2EB78A0", Offset = "0x2EB68A0", VA = "0x182EB78A0")]
		public CreepyCave()
		{
		}

		// Token: 0x04002F38 RID: 12088
		[Token(Token = "0x4002F38")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CreepyCave.CreepyZoneType _zoneType;

		// Token: 0x04002F39 RID: 12089
		[Token(Token = "0x4002F39")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<string> _navGraphNames;

		// Token: 0x04002F3A RID: 12090
		[Token(Token = "0x4002F3A")]
		[FieldOffset(Offset = "0x68")]
		[FormerlySerializedAs("_caveMask")]
		[SerializeField]
		private AreaMask _areaMask;

		// Token: 0x04002F3B RID: 12091
		[Token(Token = "0x4002F3B")]
		[FieldOffset(Offset = "0x6C")]
		[Tooltip("Disabled, maybe will be removed")]
		[SerializeField]
		private Vector2Int _autoOpenDays;

		// Token: 0x04002F3C RID: 12092
		[Token(Token = "0x4002F3C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private List<Transform> _caveEntrances;

		// Token: 0x04002F3D RID: 12093
		[Token(Token = "0x4002F3D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private List<VailWanderZone> _outsideWanderZones;

		// Token: 0x04002F3E RID: 12094
		[Token(Token = "0x4002F3E")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private int _outsideStartDay;

		// Token: 0x04002F3F RID: 12095
		[Token(Token = "0x4002F3F")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private BoundsShape _cannibalBounds;

		// Token: 0x04002F40 RID: 12096
		[Token(Token = "0x4002F40")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private List<VailSpawner> _cannibalSpawners;

		// Token: 0x04002F41 RID: 12097
		[Token(Token = "0x4002F41")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private int _maxPopulation;

		// Token: 0x04002F42 RID: 12098
		[Token(Token = "0x4002F42")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private int _maxInsidePopulation;

		// Token: 0x04002F43 RID: 12099
		[Token(Token = "0x4002F43")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private int _spawnStartDay;

		// Token: 0x04002F44 RID: 12100
		[Token(Token = "0x4002F44")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private float _spawnRatePerDayMin;

		// Token: 0x04002F45 RID: 12101
		[Token(Token = "0x4002F45")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private float _spawnRatePerDayMax;

		// Token: 0x04002F46 RID: 12102
		[Token(Token = "0x4002F46")]
		[FieldOffset(Offset = "0xB4")]
		[SerializeField]
		private int _minRateCannibalCount;

		// Token: 0x04002F47 RID: 12103
		[Token(Token = "0x4002F47")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private bool _logEnabled;

		// Token: 0x04002F48 RID: 12104
		[Token(Token = "0x4002F48")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private List<CreepyCave.SpawnChanceByType> _creepySpawners;

		// Token: 0x04002F49 RID: 12105
		[Token(Token = "0x4002F49")]
		[FieldOffset(Offset = "0xC8")]
		private int _outsideActorCount;

		// Token: 0x04002F4A RID: 12106
		[Token(Token = "0x4002F4A")]
		[FieldOffset(Offset = "0xCC")]
		private int _currentDay;

		// Token: 0x04002F4B RID: 12107
		[Token(Token = "0x4002F4B")]
		[FieldOffset(Offset = "0xD0")]
		private int _killsToday;

		// Token: 0x04002F4C RID: 12108
		[Token(Token = "0x4002F4C")]
		[FieldOffset(Offset = "0xD8")]
		private CaveBoards _caveBoards;

		// Token: 0x04002F4D RID: 12109
		[Token(Token = "0x4002F4D")]
		[FieldOffset(Offset = "0xE0")]
		private int _autoOpenDay;

		// Token: 0x04002F4E RID: 12110
		[Token(Token = "0x4002F4E")]
		[FieldOffset(Offset = "0xE4")]
		private float _lastKillCheckTimeInHours;

		// Token: 0x04002F4F RID: 12111
		[Token(Token = "0x4002F4F")]
		[FieldOffset(Offset = "0xE8")]
		private GraphMask _navGraphMask;

		// Token: 0x04002F50 RID: 12112
		[Token(Token = "0x4002F50")]
		[FieldOffset(Offset = "0xF0")]
		private List<VailWanderZone> _tempZoneList;

		// Token: 0x02000819 RID: 2073
		[Token(Token = "0x2000819")]
		private enum CreepyZoneType
		{
			// Token: 0x04002F52 RID: 12114
			[Token(Token = "0x4002F52")]
			Cave,
			// Token: 0x04002F53 RID: 12115
			[Token(Token = "0x4002F53")]
			Bunker
		}

		// Token: 0x0200081A RID: 2074
		[Token(Token = "0x200081A")]
		[Serializable]
		private class SpawnChanceByType
		{
			// Token: 0x06003744 RID: 14148 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003744")]
			[Address(RVA = "0x26475D0", Offset = "0x26465D0", VA = "0x1826475D0")]
			public SpawnChanceByType()
			{
			}

			// Token: 0x04002F54 RID: 12116
			[Token(Token = "0x4002F54")]
			[FieldOffset(Offset = "0x10")]
			public VailSpawner Spawner;

			// Token: 0x04002F55 RID: 12117
			[Token(Token = "0x4002F55")]
			[FieldOffset(Offset = "0x18")]
			public float Weight;
		}
	}
}
