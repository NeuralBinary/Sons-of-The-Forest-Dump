using System;
using System.Collections.Generic;
using Endnight.Utilities;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;

namespace Sons.Characters
{
	// Token: 0x020007F4 RID: 2036
	[Token(Token = "0x20007F4")]
	[AddComponentMenu("Sons/Vail/Ocean Fish Manager")]
	[Serializable]
	public class OceanFishManager : MonoBehaviour, ISimpleSpawner, ISpawner
	{
		// Token: 0x060035D4 RID: 13780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035D4")]
		[Address(RVA = "0x2E95340", Offset = "0x2E94340", VA = "0x182E95340")]
		private void OnValidate()
		{
		}

		// Token: 0x060035D5 RID: 13781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035D5")]
		[Address(RVA = "0x2E94ED0", Offset = "0x2E93ED0", VA = "0x182E94ED0")]
		private void InitializeGridVars()
		{
		}

		// Token: 0x060035D6 RID: 13782 RVA: 0x0000F840 File Offset: 0x0000DA40
		[Token(Token = "0x60035D6")]
		[Address(RVA = "0x2E94900", Offset = "0x2E93900", VA = "0x182E94900")]
		private int GetCellIdx2d(Vector3 pos)
		{
			return default(int);
		}

		// Token: 0x060035D7 RID: 13783 RVA: 0x0000F858 File Offset: 0x0000DA58
		[Token(Token = "0x60035D7")]
		[Address(RVA = "0x2E93DB0", Offset = "0x2E92DB0", VA = "0x182E93DB0")]
		private int CellIdx2D(int x, int z)
		{
			return default(int);
		}

		// Token: 0x060035D8 RID: 13784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035D8")]
		[Address(RVA = "0x2E947A0", Offset = "0x2E937A0", VA = "0x182E947A0")]
		public void GetCellBoundsXZ(Vector3 point, float radius, out int startX, out int startZ, out int endX, out int endZ)
		{
		}

		// Token: 0x060035D9 RID: 13785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035D9")]
		[Address(RVA = "0x2E93EE0", Offset = "0x2E92EE0", VA = "0x182E93EE0")]
		private void GenerateFishZones()
		{
		}

		// Token: 0x060035DA RID: 13786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035DA")]
		[Address(RVA = "0x2E93C00", Offset = "0x2E92C00", VA = "0x182E93C00")]
		private void CalculateCellWaterData(Vector3 cellCenter, out float avgDepth, out float percentWater)
		{
		}

		// Token: 0x060035DB RID: 13787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035DB")]
		[Address(RVA = "0x2E95350", Offset = "0x2E94350", VA = "0x182E95350")]
		private void RemoveChildren()
		{
		}

		// Token: 0x060035DC RID: 13788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035DC")]
		[Address(RVA = "0x2E95000", Offset = "0x2E94000", VA = "0x182E95000")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x060035DD RID: 13789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035DD")]
		[Address(RVA = "0x2E95410", Offset = "0x2E94410", VA = "0x182E95410")]
		private void Start()
		{
		}

		// Token: 0x060035DE RID: 13790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035DE")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "14")]
		public void UpdateRelevant(List<PlayerLocation.ViewerInfo> viewerList)
		{
		}

		// Token: 0x060035DF RID: 13791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035DF")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "10")]
		public void OnLoad(VailWorldSimulation.VailSpawnerData saveDate)
		{
		}

		// Token: 0x060035E0 RID: 13792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035E0")]
		[Address(RVA = "0x2E94AF0", Offset = "0x2E93AF0", VA = "0x182E94AF0", Slot = "11")]
		public VailWorldSimulation.VailSpawnerData GetSaveData()
		{
			return null;
		}

		// Token: 0x060035E1 RID: 13793 RVA: 0x0000F870 File Offset: 0x0000DA70
		[Token(Token = "0x60035E1")]
		[Address(RVA = "0x2E94D90", Offset = "0x2E93D90", VA = "0x182E94D90")]
		private bool InActiveList(int x, int z)
		{
			return default(bool);
		}

		// Token: 0x060035E2 RID: 13794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035E2")]
		[Address(RVA = "0x2E95480", Offset = "0x2E94480", VA = "0x182E95480", Slot = "12")]
		public void Tick(float deltaTime)
		{
		}

		// Token: 0x060035E3 RID: 13795 RVA: 0x0000F888 File Offset: 0x0000DA88
		[Token(Token = "0x60035E3")]
		[Address(RVA = "0x2E949A0", Offset = "0x2E939A0", VA = "0x182E949A0", Slot = "5")]
		public int GetCount()
		{
			return default(int);
		}

		// Token: 0x060035E4 RID: 13796 RVA: 0x0000F8A0 File Offset: 0x0000DAA0
		[Token(Token = "0x60035E4")]
		[Address(RVA = "0x2E94680", Offset = "0x2E93680", VA = "0x182E94680")]
		public int GetActiveCount()
		{
			return default(int);
		}

		// Token: 0x060035E5 RID: 13797 RVA: 0x0000F8B8 File Offset: 0x0000DAB8
		[Token(Token = "0x60035E5")]
		[Address(RVA = "0x2E94C60", Offset = "0x2E93C60", VA = "0x182E94C60")]
		public int GetStartPopulation()
		{
			return default(int);
		}

		// Token: 0x060035E6 RID: 13798 RVA: 0x0000F8D0 File Offset: 0x0000DAD0
		[Token(Token = "0x60035E6")]
		[Address(RVA = "0x2E94D80", Offset = "0x2E93D80", VA = "0x182E94D80", Slot = "7")]
		public int GetUniqueId()
		{
			return default(int);
		}

		// Token: 0x060035E7 RID: 13799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035E7")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "8")]
		public void GenerateUniqueId()
		{
		}

		// Token: 0x060035E8 RID: 13800 RVA: 0x0000F8E8 File Offset: 0x0000DAE8
		[Token(Token = "0x60035E8")]
		[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "13")]
		public bool IsAlwaysRelevant()
		{
			return default(bool);
		}

		// Token: 0x060035E9 RID: 13801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035E9")]
		[Address(RVA = "0x2E93DC0", Offset = "0x2E92DC0", VA = "0x182E93DC0", Slot = "15")]
		public void ForceDeactivate()
		{
		}

		// Token: 0x060035EA RID: 13802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035EA")]
		[Address(RVA = "0x2E94AC0", Offset = "0x2E93AC0", VA = "0x182E94AC0", Slot = "16")]
		public string GetLabel()
		{
			return null;
		}

		// Token: 0x060035EB RID: 13803 RVA: 0x0000F900 File Offset: 0x0000DB00
		[Token(Token = "0x60035EB")]
		[Address(RVA = "0xC91E50", Offset = "0xC90E50", VA = "0x180C91E50", Slot = "4")]
		public VailActorTypeId GetActorType()
		{
			return default(VailActorTypeId);
		}

		// Token: 0x060035EC RID: 13804 RVA: 0x0000F918 File Offset: 0x0000DB18
		[Token(Token = "0x60035EC")]
		[Address(RVA = "0x2294B70", Offset = "0x2293B70", VA = "0x182294B70", Slot = "17")]
		public Vector3 GetLabelPosition()
		{
			return default(Vector3);
		}

		// Token: 0x060035ED RID: 13805 RVA: 0x0000F930 File Offset: 0x0000DB30
		[Token(Token = "0x60035ED")]
		[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "6")]
		public bool IsActive()
		{
			return default(bool);
		}

		// Token: 0x060035EE RID: 13806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035EE")]
		[Address(RVA = "0x2E959A0", Offset = "0x2E949A0", VA = "0x182E959A0")]
		public OceanFishManager()
		{
		}

		// Token: 0x04002E15 RID: 11797
		[Token(Token = "0x4002E15")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _oceanHeight;

		// Token: 0x04002E16 RID: 11798
		[Token(Token = "0x4002E16")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _minDepth;

		// Token: 0x04002E17 RID: 11799
		[Token(Token = "0x4002E17")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _maxDepth;

		// Token: 0x04002E18 RID: 11800
		[Token(Token = "0x4002E18")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[Range(0f, 100f)]
		private float _minWaterPercent;

		// Token: 0x04002E19 RID: 11801
		[Token(Token = "0x4002E19")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _fishZonePrefab;

		// Token: 0x04002E1A RID: 11802
		[Token(Token = "0x4002E1A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int _fishPerCell;

		// Token: 0x04002E1B RID: 11803
		[Token(Token = "0x4002E1B")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _size;

		// Token: 0x04002E1C RID: 11804
		[Token(Token = "0x4002E1C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private int _gridCells;

		// Token: 0x04002E1D RID: 11805
		[Token(Token = "0x4002E1D")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _activeRadius;

		// Token: 0x04002E1E RID: 11806
		[Token(Token = "0x4002E1E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SimpleAnimalZone[] _cells;

		// Token: 0x04002E1F RID: 11807
		[Token(Token = "0x4002E1F")]
		[FieldOffset(Offset = "0x50")]
		private int _filledCells;

		// Token: 0x04002E20 RID: 11808
		[Token(Token = "0x4002E20")]
		[FieldOffset(Offset = "0x54")]
		private float _totalCells;

		// Token: 0x04002E21 RID: 11809
		[Token(Token = "0x4002E21")]
		[FieldOffset(Offset = "0x58")]
		private float _cellSize;

		// Token: 0x04002E22 RID: 11810
		[Token(Token = "0x4002E22")]
		[FieldOffset(Offset = "0x60")]
		private List<OceanFishManager.ActiveCellInfo> _activeCellList;

		// Token: 0x04002E23 RID: 11811
		[Token(Token = "0x4002E23")]
		[FieldOffset(Offset = "0x68")]
		private float _invCellSize;

		// Token: 0x04002E24 RID: 11812
		[Token(Token = "0x4002E24")]
		[FieldOffset(Offset = "0x6C")]
		private Vector3 _cellSize3D;

		// Token: 0x04002E25 RID: 11813
		[Token(Token = "0x4002E25")]
		[FieldOffset(Offset = "0x78")]
		private Vector3 _corner;

		// Token: 0x020007F5 RID: 2037
		[Token(Token = "0x20007F5")]
		[Serializable]
		private struct ActiveCellInfo
		{
			// Token: 0x060035EF RID: 13807 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60035EF")]
			[Address(RVA = "0x1041290", Offset = "0x1040290", VA = "0x181041290")]
			public ActiveCellInfo(SimpleAnimalZone zone, int x, int z)
			{
			}

			// Token: 0x04002E26 RID: 11814
			[Token(Token = "0x4002E26")]
			[FieldOffset(Offset = "0x0")]
			public SimpleAnimalZone _zone;

			// Token: 0x04002E27 RID: 11815
			[Token(Token = "0x4002E27")]
			[FieldOffset(Offset = "0x8")]
			public int _x;

			// Token: 0x04002E28 RID: 11816
			[Token(Token = "0x4002E28")]
			[FieldOffset(Offset = "0xC")]
			public int _z;
		}
	}
}
