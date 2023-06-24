using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x020000CF RID: 207
	[Token(Token = "0x20000CF")]
	public class VailLevelGrid : MonoBehaviour
	{
		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000805 RID: 2053 RVA: 0x00005A48 File Offset: 0x00003C48
		[Token(Token = "0x1700007F")]
		public bool IsStatic
		{
			[Token(Token = "0x6000805")]
			[Address(RVA = "0x2084CB0", Offset = "0x20832B0", VA = "0x182084CB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000806")]
		[Address(RVA = "0x2B63340", Offset = "0x2B61940", VA = "0x182B63340")]
		private void Awake()
		{
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000807")]
		[Address(RVA = "0x2B63350", Offset = "0x2B61950", VA = "0x182B63350")]
		public static VailLevelGrid NewInstance(string subName, bool isStatic = false)
		{
			return null;
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x00005A60 File Offset: 0x00003C60
		[Token(Token = "0x6000808")]
		[Address(RVA = "0x1E53250", Offset = "0x1E51850", VA = "0x181E53250")]
		public bool IsInitialized()
		{
			return default(bool);
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x00005A78 File Offset: 0x00003C78
		[Token(Token = "0x6000809")]
		[Address(RVA = "0x245D8C0", Offset = "0x245BEC0", VA = "0x18245D8C0")]
		public int GetCount()
		{
			return 0;
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600080A")]
		[Address(RVA = "0x75CCB0", Offset = "0x75B2B0", VA = "0x18075CCB0")]
		public void IncTypeCount()
		{
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00005A90 File Offset: 0x00003C90
		[Token(Token = "0x600080B")]
		[Address(RVA = "0x75C1D0", Offset = "0x75A7D0", VA = "0x18075C1D0")]
		public int GetTypeCount()
		{
			return 0;
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600080C")]
		[Address(RVA = "0x2B63420", Offset = "0x2B61A20", VA = "0x182B63420")]
		public void Add(IVailGridObject obj)
		{
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600080D")]
		[Address(RVA = "0x2B635F0", Offset = "0x2B61BF0", VA = "0x182B635F0")]
		public void Remove(IVailGridObject obj)
		{
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600080E")]
		[Address(RVA = "0x2B63770", Offset = "0x2B61D70", VA = "0x182B63770")]
		public void Clear()
		{
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600080F")]
		[Address(RVA = "0x2B63830", Offset = "0x2B61E30", VA = "0x182B63830")]
		private void InitializeGridVars()
		{
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000810")]
		[Address(RVA = "0x2B63C50", Offset = "0x2B62250", VA = "0x182B63C50")]
		public void UpdateGridCells()
		{
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x00005AA8 File Offset: 0x00003CA8
		[Token(Token = "0x6000811")]
		[Address(RVA = "0x2B63EA0", Offset = "0x2B624A0", VA = "0x182B63EA0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private int GetCellIdx2d(Vector3 pos)
		{
			return 0;
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00005AC0 File Offset: 0x00003CC0
		[Token(Token = "0x6000812")]
		[Address(RVA = "0x2B63F30", Offset = "0x2B62530", VA = "0x182B63F30")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private int CellIdx2D(int x, int z)
		{
			return 0;
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000813")]
		[Address(RVA = "0x2B63F40", Offset = "0x2B62540", VA = "0x182B63F40")]
		public void UpdateGridCellsIfNeeded()
		{
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000814")]
		[Address(RVA = "0x2B63FD0", Offset = "0x2B625D0", VA = "0x182B63FD0")]
		public void GetQueryBounds(Vector3 point, float radius, out int startX, out int startZ, out int endX, out int endZ)
		{
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000815")]
		public void GetObjectsInRadius<T>(Vector3 point, float radius, ref List<T> objectsInRadius) where T : class
		{
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000816")]
		public T GetClosestObject<T>(Vector3 point, float maxRadius) where T : class
		{
			return null;
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000817")]
		[Address(RVA = "0x2B64120", Offset = "0x2B62720", VA = "0x182B64120")]
		public MonoBehaviourStimuli GetClosestStimuli(Vector3 point, float maxRadius, Type checkType)
		{
			return null;
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000818")]
		[Address(RVA = "0x2B645F0", Offset = "0x2B62BF0", VA = "0x182B645F0")]
		public void GetStimuliInRadius(Vector3 point, float radius, ref List<MonoBehaviourStimuli> objectsInRadius, [Optional] List<Type> checkTypes)
		{
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000819")]
		[Address(RVA = "0x2B64BD0", Offset = "0x2B631D0", VA = "0x182B64BD0")]
		public void GetStimuliInRadius(Vector3 point, float radius, ref List<MonoBehaviourStimuli> objectsInRadius, Type checkType)
		{
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600081A")]
		[Address(RVA = "0x2B650A0", Offset = "0x2B636A0", VA = "0x182B650A0")]
		private void DrawGrid()
		{
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600081B")]
		[Address(RVA = "0x2B65440", Offset = "0x2B63A40", VA = "0x182B65440")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600081C")]
		[Address(RVA = "0x2B65740", Offset = "0x2B63D40", VA = "0x182B65740")]
		private void DebugLogStats()
		{
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600081D")]
		[Address(RVA = "0x2B65D90", Offset = "0x2B64390", VA = "0x182B65D90")]
		private void DebugLogObjects()
		{
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600081E")]
		[Address(RVA = "0x2B660A0", Offset = "0x2B646A0", VA = "0x182B660A0")]
		public VailLevelGrid()
		{
		}

		// Token: 0x04000659 RID: 1625
		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector3 _size;

		// Token: 0x0400065A RID: 1626
		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int _gridX;

		// Token: 0x0400065B RID: 1627
		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int _gridZ;

		// Token: 0x0400065C RID: 1628
		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private bool _isStatic;

		// Token: 0x0400065D RID: 1629
		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		[SerializeField]
		private bool _showGrid;

		// Token: 0x0400065E RID: 1630
		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		[SerializeField]
		private bool _showGridObjs;

		// Token: 0x0400065F RID: 1631
		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 _cellSize;

		// Token: 0x04000660 RID: 1632
		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float _invCellSizeX;

		// Token: 0x04000661 RID: 1633
		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float _invCellSizeZ;

		// Token: 0x04000662 RID: 1634
		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 _corner;

		// Token: 0x04000663 RID: 1635
		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<IVailGridObject>[] _gridCells;

		// Token: 0x04000664 RID: 1636
		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int _typeCount;

		// Token: 0x04000665 RID: 1637
		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int _objCount;

		// Token: 0x04000666 RID: 1638
		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float _lastUpdateTime;

		// Token: 0x04000667 RID: 1639
		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float _gridUpdateCooldown;
	}
}
