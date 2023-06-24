using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x020000BE RID: 190
	[Token(Token = "0x20000BE")]
	[AddComponentMenu("Sons/Ai/Surface Mover Path")]
	public class SurfaceMoverPath : MonoBehaviour
	{
		// Token: 0x06000764 RID: 1892 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000764")]
		[Address(RVA = "0x2B519D0", Offset = "0x2B4FFD0", VA = "0x182B519D0")]
		public SurfaceMoverPoint GetPoint(int i)
		{
			return null;
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x00005778 File Offset: 0x00003978
		[Token(Token = "0x6000765")]
		[Address(RVA = "0x2B51A40", Offset = "0x2B50040", VA = "0x182B51A40")]
		private Quaternion AlignRotationToNormal(Vector3 transformForward, Vector3 normal)
		{
			return default(Quaternion);
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000766")]
		[Address(RVA = "0x2B51C20", Offset = "0x2B50220", VA = "0x182B51C20")]
		private void AddPointPrefab()
		{
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000767")]
		[Address(RVA = "0x2B51DD0", Offset = "0x2B503D0", VA = "0x182B51DD0")]
		public void ClonePoint(SurfaceMoverPoint srcPoint, SurfaceMoverPath.CloneType insertType)
		{
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000768")]
		[Address(RVA = "0x2B52260", Offset = "0x2B50860", VA = "0x182B52260")]
		public void SnapAllPointsLocalDown()
		{
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000769")]
		[Address(RVA = "0x2B524E0", Offset = "0x2B50AE0", VA = "0x182B524E0")]
		public void SnapPoint(Transform tr, Vector3 dir)
		{
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600076A")]
		[Address(RVA = "0x2B52830", Offset = "0x2B50E30", VA = "0x182B52830")]
		public void SetPointHandleVisibility(bool visible)
		{
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600076B")]
		[Address(RVA = "0x2B52B60", Offset = "0x2B51160", VA = "0x182B52B60")]
		public void GatherPointChildren()
		{
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600076C")]
		[Address(RVA = "0x2B52FB0", Offset = "0x2B515B0", VA = "0x182B52FB0")]
		public void SetPreviousPoints()
		{
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600076D")]
		[Address(RVA = "0x2B532D0", Offset = "0x2B518D0", VA = "0x182B532D0")]
		public void ConnectInOrder()
		{
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600076E")]
		[Address(RVA = "0x2B536E0", Offset = "0x2B51CE0", VA = "0x182B536E0")]
		public void ShowPointHandles()
		{
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600076F")]
		[Address(RVA = "0x2B536F0", Offset = "0x2B51CF0", VA = "0x182B536F0")]
		public void HidePointHandles()
		{
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000770")]
		[Address(RVA = "0x2B53700", Offset = "0x2B51D00", VA = "0x182B53700")]
		private void ValidatePathArray()
		{
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00005790 File Offset: 0x00003990
		[Token(Token = "0x6000771")]
		[Address(RVA = "0x2B538E0", Offset = "0x2B51EE0", VA = "0x182B538E0")]
		private float GetPathDistance()
		{
			return 0f;
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000772")]
		[Address(RVA = "0x2B53C20", Offset = "0x2B52220", VA = "0x182B53C20")]
		private void UpdateTestMover()
		{
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000773")]
		[Address(RVA = "0x2B53F50", Offset = "0x2B52550", VA = "0x182B53F50")]
		public void DrawPointGizmos()
		{
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000774")]
		[Address(RVA = "0x2B544C0", Offset = "0x2B52AC0", VA = "0x182B544C0")]
		public void DrawLineGizmos()
		{
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000775")]
		[Address(RVA = "0x2B549D0", Offset = "0x2B52FD0", VA = "0x182B549D0")]
		public void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000776")]
		[Address(RVA = "0x2B54A00", Offset = "0x2B53000", VA = "0x182B54A00")]
		public SurfaceMoverPath()
		{
		}

		// Token: 0x040005E6 RID: 1510
		[Token(Token = "0x40005E6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SurfaceMoverPoint _pointPrefab;

		// Token: 0x040005E7 RID: 1511
		[Token(Token = "0x40005E7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<SurfaceMoverPoint> _points;

		// Token: 0x040005E8 RID: 1512
		[Token(Token = "0x40005E8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _castRadius;

		// Token: 0x040005E9 RID: 1513
		[Token(Token = "0x40005E9")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private LayerMask _castLayerMask;

		// Token: 0x040005EA RID: 1514
		[Token(Token = "0x40005EA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SurfaceMover _testMover;

		// Token: 0x040005EB RID: 1515
		[Token(Token = "0x40005EB")]
		[FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		private float _testDistance;

		// Token: 0x020000BF RID: 191
		[Token(Token = "0x20000BF")]
		public enum CloneType
		{
			// Token: 0x040005ED RID: 1517
			[Token(Token = "0x40005ED")]
			Insert,
			// Token: 0x040005EE RID: 1518
			[Token(Token = "0x40005EE")]
			Branch
		}
	}
}
