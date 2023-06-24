using System;
using System.Collections.Generic;
using Endnight.Utilities;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;

namespace Sons.Characters
{
	// Token: 0x02000702 RID: 1794
	[Token(Token = "0x2000702")]
	[AddComponentMenu("Sons/Vail/Ocean Fish Manager")]
	[Serializable]
	public class OceanFishManager : MonoBehaviour, ISimpleSpawner, ISpawner
	{
		// Token: 0x06002F79 RID: 12153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F79")]
		[Address(RVA = "0x34601A0", Offset = "0x345E7A0", VA = "0x1834601A0")]
		private void OnValidate()
		{
		}

		// Token: 0x06002F7A RID: 12154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F7A")]
		[Address(RVA = "0x34601B0", Offset = "0x345E7B0", VA = "0x1834601B0")]
		private void InitializeGridVars()
		{
		}

		// Token: 0x06002F7B RID: 12155 RVA: 0x0000E2C8 File Offset: 0x0000C4C8
		[Token(Token = "0x6002F7B")]
		[Address(RVA = "0x3460360", Offset = "0x345E960", VA = "0x183460360")]
		private int GetCellIdx2d(Vector3 pos)
		{
			return 0;
		}

		// Token: 0x06002F7C RID: 12156 RVA: 0x0000E2E0 File Offset: 0x0000C4E0
		[Token(Token = "0x6002F7C")]
		[Address(RVA = "0x3460400", Offset = "0x345EA00", VA = "0x183460400")]
		private int CellIdx2D(int x, int z)
		{
			return 0;
		}

		// Token: 0x06002F7D RID: 12157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F7D")]
		[Address(RVA = "0x3460410", Offset = "0x345EA10", VA = "0x183460410")]
		public void GetCellBoundsXZ(Vector3 point, float radius, out int startX, out int startZ, out int endX, out int endZ)
		{
		}

		// Token: 0x06002F7E RID: 12158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F7E")]
		[Address(RVA = "0x3460560", Offset = "0x345EB60", VA = "0x183460560")]
		private void GenerateFishZones()
		{
		}

		// Token: 0x06002F7F RID: 12159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F7F")]
		[Address(RVA = "0x3460D20", Offset = "0x345F320", VA = "0x183460D20")]
		private void CalculateCellWaterData(Vector3 cellCenter, out float avgDepth, out float percentWater)
		{
		}

		// Token: 0x06002F80 RID: 12160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F80")]
		[Address(RVA = "0x3460EE0", Offset = "0x345F4E0", VA = "0x183460EE0")]
		private void RemoveChildren()
		{
		}

		// Token: 0x06002F81 RID: 12161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F81")]
		[Address(RVA = "0x3461150", Offset = "0x345F750", VA = "0x183461150")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06002F82 RID: 12162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F82")]
		[Address(RVA = "0x3461610", Offset = "0x345FC10", VA = "0x183461610")]
		private void Start()
		{
		}

		// Token: 0x06002F83 RID: 12163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F83")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "14")]
		public void UpdateRelevant(List<PlayerLocation.ViewerInfo> viewerList)
		{
		}

		// Token: 0x06002F84 RID: 12164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F84")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "10")]
		public void OnLoad(VailWorldSimulation.VailSpawnerData saveDate)
		{
		}

		// Token: 0x06002F85 RID: 12165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F85")]
		[Address(RVA = "0x3461680", Offset = "0x345FC80", VA = "0x183461680", Slot = "11")]
		public VailWorldSimulation.VailSpawnerData GetSaveData()
		{
			return null;
		}

		// Token: 0x06002F86 RID: 12166 RVA: 0x0000E2F8 File Offset: 0x0000C4F8
		[Token(Token = "0x6002F86")]
		[Address(RVA = "0x3461850", Offset = "0x345FE50", VA = "0x183461850")]
		private bool InActiveList(int x, int z)
		{
			return default(bool);
		}

		// Token: 0x06002F87 RID: 12167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F87")]
		[Address(RVA = "0x34619A0", Offset = "0x345FFA0", VA = "0x1834619A0", Slot = "12")]
		public void Tick(float deltaTime)
		{
		}

		// Token: 0x06002F88 RID: 12168 RVA: 0x0000E310 File Offset: 0x0000C510
		[Token(Token = "0x6002F88")]
		[Address(RVA = "0x3462030", Offset = "0x3460630", VA = "0x183462030", Slot = "5")]
		public int GetCount()
		{
			return 0;
		}

		// Token: 0x06002F89 RID: 12169 RVA: 0x0000E328 File Offset: 0x0000C528
		[Token(Token = "0x6002F89")]
		[Address(RVA = "0x34621B0", Offset = "0x34607B0", VA = "0x1834621B0")]
		public int GetActiveCount()
		{
			return 0;
		}

		// Token: 0x06002F8A RID: 12170 RVA: 0x0000E340 File Offset: 0x0000C540
		[Token(Token = "0x6002F8A")]
		[Address(RVA = "0x3462330", Offset = "0x3460930", VA = "0x183462330")]
		public int GetStartPopulation()
		{
			return 0;
		}

		// Token: 0x06002F8B RID: 12171 RVA: 0x0000E358 File Offset: 0x0000C558
		[Token(Token = "0x6002F8B")]
		[Address(RVA = "0x34624B0", Offset = "0x3460AB0", VA = "0x1834624B0", Slot = "7")]
		public int GetUniqueId()
		{
			return 0;
		}

		// Token: 0x06002F8C RID: 12172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F8C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "8")]
		public void GenerateUniqueId()
		{
		}

		// Token: 0x06002F8D RID: 12173 RVA: 0x0000E370 File Offset: 0x0000C570
		[Token(Token = "0x6002F8D")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "13")]
		public bool IsAlwaysRelevant()
		{
			return default(bool);
		}

		// Token: 0x06002F8E RID: 12174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F8E")]
		[Address(RVA = "0x34624C0", Offset = "0x3460AC0", VA = "0x1834624C0", Slot = "15")]
		public void ForceDeactivate()
		{
		}

		// Token: 0x06002F8F RID: 12175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F8F")]
		[Address(RVA = "0x3462610", Offset = "0x3460C10", VA = "0x183462610", Slot = "16")]
		public string GetLabel()
		{
			return null;
		}

		// Token: 0x06002F90 RID: 12176 RVA: 0x0000E388 File Offset: 0x0000C588
		[Token(Token = "0x6002F90")]
		[Address(RVA = "0xE599E0", Offset = "0xE57FE0", VA = "0x180E599E0", Slot = "4")]
		public VailActorTypeId GetActorType()
		{
			return VailActorTypeId.None;
		}

		// Token: 0x06002F91 RID: 12177 RVA: 0x0000E3A0 File Offset: 0x0000C5A0
		[Token(Token = "0x6002F91")]
		[Address(RVA = "0x26E86D0", Offset = "0x26E6CD0", VA = "0x1826E86D0", Slot = "17")]
		public Vector3 GetLabelPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06002F92 RID: 12178 RVA: 0x0000E3B8 File Offset: 0x0000C5B8
		[Token(Token = "0x6002F92")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "6")]
		public bool IsActive()
		{
			return default(bool);
		}

		// Token: 0x06002F93 RID: 12179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F93")]
		[Address(RVA = "0x3462640", Offset = "0x3460C40", VA = "0x183462640")]
		public OceanFishManager()
		{
		}

		// Token: 0x04002906 RID: 10502
		[Token(Token = "0x4002906")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _oceanHeight;

		// Token: 0x04002907 RID: 10503
		[Token(Token = "0x4002907")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _minDepth;

		// Token: 0x04002908 RID: 10504
		[Token(Token = "0x4002908")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _maxDepth;

		// Token: 0x04002909 RID: 10505
		[Token(Token = "0x4002909")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[Range(0f, 100f)]
		private float _minWaterPercent;

		// Token: 0x0400290A RID: 10506
		[Token(Token = "0x400290A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _fishZonePrefab;

		// Token: 0x0400290B RID: 10507
		[Token(Token = "0x400290B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int _fishPerCell;

		// Token: 0x0400290C RID: 10508
		[Token(Token = "0x400290C")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _size;

		// Token: 0x0400290D RID: 10509
		[Token(Token = "0x400290D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private int _gridCells;

		// Token: 0x0400290E RID: 10510
		[Token(Token = "0x400290E")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _activeRadius;

		// Token: 0x0400290F RID: 10511
		[Token(Token = "0x400290F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SimpleAnimalZone[] _cells;

		// Token: 0x04002910 RID: 10512
		[Token(Token = "0x4002910")]
		[FieldOffset(Offset = "0x50")]
		private int _filledCells;

		// Token: 0x04002911 RID: 10513
		[Token(Token = "0x4002911")]
		[FieldOffset(Offset = "0x54")]
		private float _totalCells;

		// Token: 0x04002912 RID: 10514
		[Token(Token = "0x4002912")]
		[FieldOffset(Offset = "0x58")]
		private float _cellSize;

		// Token: 0x04002913 RID: 10515
		[Token(Token = "0x4002913")]
		[FieldOffset(Offset = "0x60")]
		private List<OceanFishManager.ActiveCellInfo> _activeCellList;

		// Token: 0x04002914 RID: 10516
		[Token(Token = "0x4002914")]
		[FieldOffset(Offset = "0x68")]
		private float _invCellSize;

		// Token: 0x04002915 RID: 10517
		[Token(Token = "0x4002915")]
		[FieldOffset(Offset = "0x6C")]
		private Vector3 _cellSize3D;

		// Token: 0x04002916 RID: 10518
		[Token(Token = "0x4002916")]
		[FieldOffset(Offset = "0x78")]
		private Vector3 _corner;

		// Token: 0x02000703 RID: 1795
		[Token(Token = "0x2000703")]
		[Serializable]
		private struct ActiveCellInfo
		{
			// Token: 0x06002F94 RID: 12180 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002F94")]
			[Address(RVA = "0x123B0E0", Offset = "0x12396E0", VA = "0x18123B0E0")]
			public ActiveCellInfo(SimpleAnimalZone zone, int x, int z)
			{
			}

			// Token: 0x04002917 RID: 10519
			[Token(Token = "0x4002917")]
			[FieldOffset(Offset = "0x0")]
			public SimpleAnimalZone _zone;

			// Token: 0x04002918 RID: 10520
			[Token(Token = "0x4002918")]
			[FieldOffset(Offset = "0x8")]
			public int _x;

			// Token: 0x04002919 RID: 10521
			[Token(Token = "0x4002919")]
			[FieldOffset(Offset = "0xC")]
			public int _z;
		}
	}
}
