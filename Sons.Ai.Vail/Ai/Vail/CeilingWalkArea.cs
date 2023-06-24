using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x020000BC RID: 188
	[Token(Token = "0x20000BC")]
	[AddComponentMenu("Sons/Ai/CeilingWalkArea")]
	public class CeilingWalkArea : MonoBehaviour
	{
		// Token: 0x06000748 RID: 1864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000748")]
		[Address(RVA = "0x2B4E660", Offset = "0x2B4CC60", VA = "0x182B4E660")]
		public void Start()
		{
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x00005688 File Offset: 0x00003888
		[Token(Token = "0x6000749")]
		[Address(RVA = "0x2B4E670", Offset = "0x2B4CC70", VA = "0x182B4E670")]
		public Vector3 SnapToCeiling(Vector3 pos)
		{
			return default(Vector3);
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x000056A0 File Offset: 0x000038A0
		[Token(Token = "0x600074A")]
		[Address(RVA = "0x2B4E770", Offset = "0x2B4CD70", VA = "0x182B4E770")]
		public bool IsUnderGrid(Vector3 position, float minEdgeDist)
		{
			return default(bool);
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600074B")]
		[Address(RVA = "0x2B4E7D0", Offset = "0x2B4CDD0", VA = "0x182B4E7D0")]
		private void GenerateGrid()
		{
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x000056B8 File Offset: 0x000038B8
		[Token(Token = "0x600074C")]
		[Address(RVA = "0x2B4EA00", Offset = "0x2B4D000", VA = "0x182B4EA00")]
		private Vector3 RaycastUp(Vector3 startPoint)
		{
			return default(Vector3);
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600074D")]
		[Address(RVA = "0x2B4EE20", Offset = "0x2B4D420", VA = "0x182B4EE20")]
		private void ComputeGridStep()
		{
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x000056D0 File Offset: 0x000038D0
		[Token(Token = "0x600074E")]
		[Address(RVA = "0x2B4EF90", Offset = "0x2B4D590", VA = "0x182B4EF90")]
		private int GridIdx(int x, int z)
		{
			return 0;
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x000056E8 File Offset: 0x000038E8
		[Token(Token = "0x600074F")]
		[Address(RVA = "0x2B4EFD0", Offset = "0x2B4D5D0", VA = "0x182B4EFD0")]
		private Vector3 GridWorldXZ(int x, int z)
		{
			return default(Vector3);
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00005700 File Offset: 0x00003900
		[Token(Token = "0x6000750")]
		[Address(RVA = "0x2B4F040", Offset = "0x2B4D640", VA = "0x182B4F040")]
		private Vector3 ClampToGrid(Vector3 position)
		{
			return default(Vector3);
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00005718 File Offset: 0x00003918
		[Token(Token = "0x6000751")]
		[Address(RVA = "0x2B4F100", Offset = "0x2B4D700", VA = "0x182B4F100")]
		private float GetYAtPosition(Vector3 position)
		{
			return 0f;
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000752")]
		[Address(RVA = "0x2B4F370", Offset = "0x2B4D970", VA = "0x182B4F370")]
		private void TestMoveObjectRandom()
		{
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000753")]
		[Address(RVA = "0x2B4F5A0", Offset = "0x2B4DBA0", VA = "0x182B4F5A0")]
		private void TestSnapObject()
		{
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000754")]
		[Address(RVA = "0x2B4F800", Offset = "0x2B4DE00", VA = "0x182B4F800")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000755")]
		[Address(RVA = "0x2B4FB20", Offset = "0x2B4E120", VA = "0x182B4FB20")]
		public CeilingWalkArea()
		{
		}

		// Token: 0x040005CD RID: 1485
		[Token(Token = "0x40005CD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector3 _size;

		// Token: 0x040005CE RID: 1486
		[Token(Token = "0x40005CE")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int _gridWidth;

		// Token: 0x040005CF RID: 1487
		[Token(Token = "0x40005CF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int _gridHeight;

		// Token: 0x040005D0 RID: 1488
		[Token(Token = "0x40005D0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Vector3[] _gridPoints;

		// Token: 0x040005D1 RID: 1489
		[Token(Token = "0x40005D1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _sphereCastSize;

		// Token: 0x040005D2 RID: 1490
		[Token(Token = "0x40005D2")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _offsetY;

		// Token: 0x040005D3 RID: 1491
		[Token(Token = "0x40005D3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _testMoveGo;

		// Token: 0x040005D4 RID: 1492
		[Token(Token = "0x40005D4")]
		[FieldOffset(Offset = "0x50")]
		private Vector3 _gridStep;

		// Token: 0x040005D5 RID: 1493
		[Token(Token = "0x40005D5")]
		[FieldOffset(Offset = "0x5C")]
		private Vector3 _gridOrigin;
	}
}
