using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x020000BD RID: 189
	[Token(Token = "0x20000BD")]
	[AddComponentMenu("Sons/Ai/Surface Mover")]
	public class SurfaceMover : MonoBehaviour
	{
		// Token: 0x06000756 RID: 1878 RVA: 0x00005730 File Offset: 0x00003930
		[Token(Token = "0x6000756")]
		[Address(RVA = "0x6599C0", Offset = "0x657FC0", VA = "0x1806599C0")]
		public bool IsActive()
		{
			return default(bool);
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x00005748 File Offset: 0x00003948
		[Token(Token = "0x6000757")]
		[Address(RVA = "0x9ABDB0", Offset = "0x9AA3B0", VA = "0x1809ABDB0")]
		public bool IsComplete()
		{
			return default(bool);
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000758")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void AlignToSurface()
		{
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000759")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void JumpToNavMesh()
		{
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600075A")]
		[Address(RVA = "0x2B4FBB0", Offset = "0x2B4E1B0", VA = "0x182B4FBB0")]
		private void SetActive(bool value)
		{
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600075B")]
		[Address(RVA = "0x2B4FCE0", Offset = "0x2B4E2E0", VA = "0x182B4FCE0")]
		public void StartOnPath(SurfaceMoverPath path, Transform moverTransform, bool blendToStart = true)
		{
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600075C")]
		[Address(RVA = "0x2B50090", Offset = "0x2B4E690", VA = "0x182B50090")]
		public void StopPath()
		{
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600075D")]
		[Address(RVA = "0x2B500A0", Offset = "0x2B4E6A0", VA = "0x182B500A0")]
		private void ResetMover()
		{
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600075E")]
		[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
		public void SetPath(SurfaceMoverPath path)
		{
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600075F")]
		[Address(RVA = "0x2B50130", Offset = "0x2B4E730", VA = "0x182B50130")]
		private void MoveToSegment(SurfaceMoverPoint segmentPoint, SurfaceMoverPoint nextPoint)
		{
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000760")]
		[Address(RVA = "0x2B50920", Offset = "0x2B4EF20", VA = "0x182B50920")]
		public void SetMoverPathDistance(float distance, Transform moverTransform)
		{
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x00005760 File Offset: 0x00003960
		[Token(Token = "0x6000761")]
		[Address(RVA = "0x2B50AE0", Offset = "0x2B4F0E0", VA = "0x182B50AE0")]
		private bool SetPositionFromSegment(Vector3 p1, Vector3 p2, Quaternion r1, Quaternion r2, Transform moverTransform, bool fullLinearRotation)
		{
			return default(bool);
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000762")]
		[Address(RVA = "0x2B50EA0", Offset = "0x2B4F4A0", VA = "0x182B50EA0")]
		public void MoveOnPath(float moveDistance, Transform moverTransform)
		{
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000763")]
		[Address(RVA = "0x2B51980", Offset = "0x2B4FF80", VA = "0x182B51980")]
		public SurfaceMover()
		{
		}

		// Token: 0x040005D6 RID: 1494
		[Token(Token = "0x40005D6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SurfaceMoverPath _path;

		// Token: 0x040005D7 RID: 1495
		[Token(Token = "0x40005D7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _isActive;

		// Token: 0x040005D8 RID: 1496
		[Token(Token = "0x40005D8")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _surfaceAdjustDist;

		// Token: 0x040005D9 RID: 1497
		[Token(Token = "0x40005D9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _turnDistance;

		// Token: 0x040005DA RID: 1498
		[Token(Token = "0x40005DA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x040005DB RID: 1499
		[Token(Token = "0x40005DB")]
		[FieldOffset(Offset = "0x40")]
		private float _distanceOnSegment;

		// Token: 0x040005DC RID: 1500
		[Token(Token = "0x40005DC")]
		[FieldOffset(Offset = "0x48")]
		private SurfaceMoverPoint _currentPoint;

		// Token: 0x040005DD RID: 1501
		[Token(Token = "0x40005DD")]
		[FieldOffset(Offset = "0x50")]
		private SurfaceMoverPoint _nextPoint;

		// Token: 0x040005DE RID: 1502
		[Token(Token = "0x40005DE")]
		[FieldOffset(Offset = "0x58")]
		private SurfaceMoverPoint _nextNextPoint;

		// Token: 0x040005DF RID: 1503
		[Token(Token = "0x40005DF")]
		[FieldOffset(Offset = "0x60")]
		private Quaternion _currentPointRotation;

		// Token: 0x040005E0 RID: 1504
		[Token(Token = "0x40005E0")]
		[FieldOffset(Offset = "0x70")]
		private Quaternion _nextPointRotation;

		// Token: 0x040005E1 RID: 1505
		[Token(Token = "0x40005E1")]
		[FieldOffset(Offset = "0x80")]
		private bool _isComplete;

		// Token: 0x040005E2 RID: 1506
		[Token(Token = "0x40005E2")]
		[FieldOffset(Offset = "0x84")]
		private Vector3 _startPosition;

		// Token: 0x040005E3 RID: 1507
		[Token(Token = "0x40005E3")]
		[FieldOffset(Offset = "0x90")]
		private Quaternion _startRotation;

		// Token: 0x040005E4 RID: 1508
		[Token(Token = "0x40005E4")]
		[FieldOffset(Offset = "0xA0")]
		private bool _startBlend;

		// Token: 0x040005E5 RID: 1509
		[Token(Token = "0x40005E5")]
		[FieldOffset(Offset = "0xA4")]
		private float _lastSetPathDistance;
	}
}
