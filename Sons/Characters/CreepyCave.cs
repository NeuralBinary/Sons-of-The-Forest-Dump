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
	// Token: 0x0200072B RID: 1835
	[Token(Token = "0x200072B")]
	[AddComponentMenu("Sons/Vail/Creepy Cave")]
	[Serializable]
	public class CreepyCave : VailZoneBase
	{
		// Token: 0x06003106 RID: 12550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003106")]
		[Address(RVA = "0x3483050", Offset = "0x3481650", VA = "0x183483050")]
		private ValueDropdownList<string> GetNavGraphLabels()
		{
			return null;
		}

		// Token: 0x06003107 RID: 12551 RVA: 0x0000EE08 File Offset: 0x0000D008
		[Token(Token = "0x6003107")]
		[Address(RVA = "0xAFF480", Offset = "0xAFDA80", VA = "0x180AFF480", Slot = "12")]
		public override GraphMask GetNavGraphMask()
		{
			return default(GraphMask);
		}

		// Token: 0x06003108 RID: 12552 RVA: 0x0000EE20 File Offset: 0x0000D020
		[Token(Token = "0x6003108")]
		[Address(RVA = "0x75C1D0", Offset = "0x75A7D0", VA = "0x18075C1D0", Slot = "5")]
		public override AreaMask GetAreaMask()
		{
			return AreaMask.None;
		}

		// Token: 0x06003109 RID: 12553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003109")]
		[Address(RVA = "0x675FA0", Offset = "0x6745A0", VA = "0x180675FA0")]
		public List<Transform> GetCaveEntrances()
		{
			return null;
		}

		// Token: 0x0600310A RID: 12554 RVA: 0x0000EE38 File Offset: 0x0000D038
		[Token(Token = "0x600310A")]
		[Address(RVA = "0x3483090", Offset = "0x3481690", VA = "0x183483090", Slot = "4")]
		public override VailZoneId ZoneType()
		{
			return VailZoneId.CannibalVillage;
		}

		// Token: 0x0600310B RID: 12555 RVA: 0x0000EE50 File Offset: 0x0000D050
		[Token(Token = "0x600310B")]
		[Address(RVA = "0xE51970", Offset = "0xE4FF70", VA = "0x180E51970", Slot = "6")]
		public override VailActorClassId ClassFilter()
		{
			return VailActorClassId.None;
		}

		// Token: 0x0600310C RID: 12556 RVA: 0x0000EE68 File Offset: 0x0000D068
		[Token(Token = "0x600310C")]
		[Address(RVA = "0x34830A0", Offset = "0x34816A0", VA = "0x1834830A0")]
		private int MaxPopulation()
		{
			return 0;
		}

		// Token: 0x0600310D RID: 12557 RVA: 0x0000EE80 File Offset: 0x0000D080
		[Token(Token = "0x600310D")]
		[Address(RVA = "0x34830B0", Offset = "0x34816B0", VA = "0x1834830B0", Slot = "18")]
		public override int GetPopulation()
		{
			return 0;
		}

		// Token: 0x0600310E RID: 12558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600310E")]
		[Address(RVA = "0x34830C0", Offset = "0x34816C0", VA = "0x1834830C0", Slot = "20")]
		protected override string GetStatus()
		{
			return null;
		}

		// Token: 0x0600310F RID: 12559 RVA: 0x0000EE98 File Offset: 0x0000D098
		[Token(Token = "0x600310F")]
		[Address(RVA = "0x3483120", Offset = "0x3481720", VA = "0x183483120", Slot = "7")]
		public override bool NeedsSpawner()
		{
			return default(bool);
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06003110 RID: 12560 RVA: 0x0000EEB0 File Offset: 0x0000D0B0
		[Token(Token = "0x17000675")]
		public bool CaveIsOpen
		{
			[Token(Token = "0x6003110")]
			[Address(RVA = "0x3483160", Offset = "0x3481760", VA = "0x183483160")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06003111 RID: 12561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003111")]
		[Address(RVA = "0x34831E0", Offset = "0x34817E0", VA = "0x1834831E0", Slot = "9")]
		public override void Clear()
		{
		}

		// Token: 0x06003112 RID: 12562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003112")]
		[Address(RVA = "0x3483250", Offset = "0x3481850", VA = "0x183483250", Slot = "10")]
		public override void OnPostLoad(VailWorldSimulation worldSim)
		{
		}

		// Token: 0x06003113 RID: 12563 RVA: 0x0000EEC8 File Offset: 0x0000D0C8
		[Token(Token = "0x6003113")]
		[Address(RVA = "0x3483420", Offset = "0x3481A20", VA = "0x183483420", Slot = "24")]
		public override Vector3 GetCenterPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06003114 RID: 12564 RVA: 0x0000EEE0 File Offset: 0x0000D0E0
		[Token(Token = "0x6003114")]
		[Address(RVA = "0x3483630", Offset = "0x3481C30", VA = "0x183483630")]
		public int CannibalsInArea()
		{
			return 0;
		}

		// Token: 0x06003115 RID: 12565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003115")]
		[Address(RVA = "0x3483820", Offset = "0x3481E20", VA = "0x183483820")]
		public void OnSerialize(VillageManager.CaveData data)
		{
		}

		// Token: 0x06003116 RID: 12566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003116")]
		[Address(RVA = "0x3483860", Offset = "0x3481E60", VA = "0x183483860")]
		public void OnDeserialize(VillageManager.CaveData data)
		{
		}

		// Token: 0x06003117 RID: 12567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003117")]
		[Address(RVA = "0x3483910", Offset = "0x3481F10", VA = "0x183483910", Slot = "11")]
		public override void Tick(bool server, VailWorldSimulation worldSim)
		{
		}

		// Token: 0x06003118 RID: 12568 RVA: 0x0000EEF8 File Offset: 0x0000D0F8
		[Token(Token = "0x6003118")]
		[Address(RVA = "0x3483AD0", Offset = "0x34820D0", VA = "0x183483AD0")]
		private bool CanSpawn()
		{
			return default(bool);
		}

		// Token: 0x06003119 RID: 12569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003119")]
		[Address(RVA = "0x3483B00", Offset = "0x3482100", VA = "0x183483B00")]
		private void UpdateSpawning(VailWorldSimulation worldSim)
		{
		}

		// Token: 0x0600311A RID: 12570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600311A")]
		[Address(RVA = "0x3483E10", Offset = "0x3482410", VA = "0x183483E10")]
		private void SpawnCaveActor(VailWorldSimulation worldSim, bool spawnOutside = false)
		{
		}

		// Token: 0x0600311B RID: 12571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600311B")]
		[Address(RVA = "0x3484210", Offset = "0x3482810", VA = "0x183484210", Slot = "13")]
		public override void OnLinkSpawner(IVailSpawner caveSpawner)
		{
		}

		// Token: 0x0600311C RID: 12572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600311C")]
		[Address(RVA = "0x34842D0", Offset = "0x34828D0", VA = "0x1834842D0", Slot = "15")]
		public override void OnActorTeleport(AreaMask oldCaveMask, AreaMask newCaveMask)
		{
		}

		// Token: 0x0600311D RID: 12573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600311D")]
		[Address(RVA = "0x3484320", Offset = "0x3482920", VA = "0x183484320")]
		private void UpdateActorCount(WorldSimActor actor, int delta)
		{
		}

		// Token: 0x0600311E RID: 12574 RVA: 0x0000EF10 File Offset: 0x0000D110
		[Token(Token = "0x600311E")]
		[Address(RVA = "0x3484370", Offset = "0x3482970", VA = "0x183484370", Slot = "16")]
		public override bool OnAddActor(WorldSimActor actor)
		{
			return default(bool);
		}

		// Token: 0x0600311F RID: 12575 RVA: 0x0000EF28 File Offset: 0x0000D128
		[Token(Token = "0x600311F")]
		[Address(RVA = "0x34843F0", Offset = "0x34829F0", VA = "0x1834843F0", Slot = "17")]
		public override bool OnRemoveActor(WorldSimActor actor)
		{
			return default(bool);
		}

		// Token: 0x06003120 RID: 12576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003120")]
		[Address(RVA = "0x3484520", Offset = "0x3482B20", VA = "0x183484520")]
		private void CacheGraphMask()
		{
		}

		// Token: 0x06003121 RID: 12577 RVA: 0x0000EF40 File Offset: 0x0000D140
		[Token(Token = "0x6003121")]
		[Address(RVA = "0x34845C0", Offset = "0x3482BC0", VA = "0x1834845C0")]
		private GraphMask CalcNavGraphMask()
		{
			return default(GraphMask);
		}

		// Token: 0x06003122 RID: 12578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003122")]
		[Address(RVA = "0x3484720", Offset = "0x3482D20", VA = "0x183484720")]
		public IActorZone GetOutsideArea()
		{
			return null;
		}

		// Token: 0x06003123 RID: 12579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003123")]
		[Address(RVA = "0x3484A50", Offset = "0x3483050", VA = "0x183484A50", Slot = "32")]
		public override string ExtraWorldStats(List<VailZoneBase> zones)
		{
			return null;
		}

		// Token: 0x06003124 RID: 12580 RVA: 0x0000EF58 File Offset: 0x0000D158
		[Token(Token = "0x6003124")]
		[Address(RVA = "0x3484D10", Offset = "0x3483310", VA = "0x183484D10", Slot = "31")]
		public override bool ExtraStats(StringBuilder sb)
		{
			return default(bool);
		}

		// Token: 0x06003125 RID: 12581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003125")]
		[Address(RVA = "0x3484EB0", Offset = "0x34834B0", VA = "0x183484EB0")]
		private void CollectChildrenAsOutsideZones(Transform parent)
		{
		}

		// Token: 0x06003126 RID: 12582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003126")]
		[Address(RVA = "0x3485120", Offset = "0x3483720", VA = "0x183485120")]
		public CreepyCave()
		{
		}

		// Token: 0x04002A56 RID: 10838
		[Token(Token = "0x4002A56")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CreepyCave.CreepyZoneType _zoneType;

		// Token: 0x04002A57 RID: 10839
		[Token(Token = "0x4002A57")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private List<string> _navGraphNames;

		// Token: 0x04002A58 RID: 10840
		[Token(Token = "0x4002A58")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[FormerlySerializedAs("_caveMask")]
		private AreaMask _areaMask;

		// Token: 0x04002A59 RID: 10841
		[Token(Token = "0x4002A59")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private List<Transform> _caveEntrances;

		// Token: 0x04002A5A RID: 10842
		[Token(Token = "0x4002A5A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<VailWanderZone> _outsideWanderZones;

		// Token: 0x04002A5B RID: 10843
		[Token(Token = "0x4002A5B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private int _outsideStartDay;

		// Token: 0x04002A5C RID: 10844
		[Token(Token = "0x4002A5C")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private BoundsShape _cannibalBounds;

		// Token: 0x04002A5D RID: 10845
		[Token(Token = "0x4002A5D")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private List<VailSpawner> _cannibalSpawners;

		// Token: 0x04002A5E RID: 10846
		[Token(Token = "0x4002A5E")]
		[FieldOffset(Offset = "0x90")]
		[FormerlySerializedAs("_maxPopulation")]
		[SerializeField]
		private int _maxOutsidePopulation;

		// Token: 0x04002A5F RID: 10847
		[Token(Token = "0x4002A5F")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private int _maxInsidePopulation;

		// Token: 0x04002A60 RID: 10848
		[Token(Token = "0x4002A60")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private int _spawnStartDay;

		// Token: 0x04002A61 RID: 10849
		[Token(Token = "0x4002A61")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private float _spawnRatePerDayMin;

		// Token: 0x04002A62 RID: 10850
		[Token(Token = "0x4002A62")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private float _spawnRatePerDayMax;

		// Token: 0x04002A63 RID: 10851
		[Token(Token = "0x4002A63")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private int _minRateCannibalCount;

		// Token: 0x04002A64 RID: 10852
		[Token(Token = "0x4002A64")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private bool _logEnabled;

		// Token: 0x04002A65 RID: 10853
		[Token(Token = "0x4002A65")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private List<CreepyCave.SpawnChanceByType> _creepySpawners;

		// Token: 0x04002A66 RID: 10854
		[Token(Token = "0x4002A66")]
		[FieldOffset(Offset = "0xB8")]
		private int _insideActorCount;

		// Token: 0x04002A67 RID: 10855
		[Token(Token = "0x4002A67")]
		[FieldOffset(Offset = "0xBC")]
		private int _outsideActorCount;

		// Token: 0x04002A68 RID: 10856
		[Token(Token = "0x4002A68")]
		[FieldOffset(Offset = "0xC0")]
		private int _currentDay;

		// Token: 0x04002A69 RID: 10857
		[Token(Token = "0x4002A69")]
		[FieldOffset(Offset = "0xC4")]
		private int _killsToday;

		// Token: 0x04002A6A RID: 10858
		[Token(Token = "0x4002A6A")]
		[FieldOffset(Offset = "0xC8")]
		private CaveBoards _caveBoards;

		// Token: 0x04002A6B RID: 10859
		[Token(Token = "0x4002A6B")]
		[FieldOffset(Offset = "0xD0")]
		private float _lastKillCheckTimeInHours;

		// Token: 0x04002A6C RID: 10860
		[Token(Token = "0x4002A6C")]
		[FieldOffset(Offset = "0xD4")]
		private GraphMask _navGraphMask;

		// Token: 0x0200072C RID: 1836
		[Token(Token = "0x200072C")]
		private enum CreepyZoneType
		{
			// Token: 0x04002A6E RID: 10862
			[Token(Token = "0x4002A6E")]
			Cave,
			// Token: 0x04002A6F RID: 10863
			[Token(Token = "0x4002A6F")]
			Bunker
		}

		// Token: 0x0200072D RID: 1837
		[Token(Token = "0x200072D")]
		[Serializable]
		private class SpawnChanceByType
		{
			// Token: 0x06003127 RID: 12583 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003127")]
			[Address(RVA = "0x2B0D3D0", Offset = "0x2B0B9D0", VA = "0x182B0D3D0")]
			public SpawnChanceByType()
			{
			}

			// Token: 0x04002A70 RID: 10864
			[Token(Token = "0x4002A70")]
			[FieldOffset(Offset = "0x10")]
			public VailSpawner Spawner;

			// Token: 0x04002A71 RID: 10865
			[Token(Token = "0x4002A71")]
			[FieldOffset(Offset = "0x18")]
			public float Weight;
		}
	}
}
