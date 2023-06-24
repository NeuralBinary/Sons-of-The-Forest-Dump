using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x020000B5 RID: 181
	[Token(Token = "0x20000B5")]
	[AddComponentMenu("Sons/Ai/Flight Path Mover")]
	public class FlightPathMover : MonoBehaviour
	{
		// Token: 0x0600070E RID: 1806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600070E")]
		[Address(RVA = "0x2B463C0", Offset = "0x2B449C0", VA = "0x182B463C0")]
		public void Initialize(Animator animator)
		{
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600070F")]
		[Address(RVA = "0x2B465A0", Offset = "0x2B44BA0", VA = "0x182B465A0")]
		public void Clear()
		{
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000710")]
		[Address(RVA = "0x2B46780", Offset = "0x2B44D80", VA = "0x182B46780")]
		private void SetAnimState(FlightPathMover.AnimState newAnimState)
		{
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000711")]
		[Address(RVA = "0x2B46930", Offset = "0x2B44F30", VA = "0x182B46930")]
		private void UpdateAnimBools(FlightPathMover.AnimState animState)
		{
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000712")]
		[Address(RVA = "0x2B46AB0", Offset = "0x2B450B0", VA = "0x182B46AB0")]
		public void AddPoint(Vector3 point, FlightPathMover.AnimState segmentAnim = FlightPathMover.AnimState.Flying, bool dynamicTarget = false)
		{
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x000054F0 File Offset: 0x000036F0
		[Token(Token = "0x6000713")]
		[Address(RVA = "0x2B46BD0", Offset = "0x2B451D0", VA = "0x182B46BD0")]
		public int PathPointCount()
		{
			return 0;
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x00005508 File Offset: 0x00003708
		[Token(Token = "0x6000714")]
		[Address(RVA = "0x2B46C10", Offset = "0x2B45210", VA = "0x182B46C10")]
		public Vector3 GetPathEndPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000715")]
		[Address(RVA = "0x2B46CB0", Offset = "0x2B452B0", VA = "0x182B46CB0")]
		public void SetPathEndPosition(Vector3 position)
		{
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x00005520 File Offset: 0x00003720
		[Token(Token = "0x6000716")]
		[Address(RVA = "0x2B46D50", Offset = "0x2B45350", VA = "0x182B46D50")]
		public Vector3 GetForwardsDir(float deltaT = 0.01f)
		{
			return default(Vector3);
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00005538 File Offset: 0x00003738
		[Token(Token = "0x6000717")]
		[Address(RVA = "0x2B46F40", Offset = "0x2B45540", VA = "0x182B46F40")]
		public Vector3 SampleForwardPoint(float deltaT = 0.01f)
		{
			return default(Vector3);
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00005550 File Offset: 0x00003750
		[Token(Token = "0x6000718")]
		[Address(RVA = "0x2B47080", Offset = "0x2B45680", VA = "0x182B47080")]
		public bool IsLastSegment()
		{
			return default(bool);
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x00005568 File Offset: 0x00003768
		[Token(Token = "0x6000719")]
		[Address(RVA = "0x2B470E0", Offset = "0x2B456E0", VA = "0x182B470E0")]
		public bool IsActive()
		{
			return default(bool);
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x00005580 File Offset: 0x00003780
		[Token(Token = "0x600071A")]
		[Address(RVA = "0x2B47140", Offset = "0x2B45740", VA = "0x182B47140")]
		public bool IsComplete()
		{
			return default(bool);
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00005598 File Offset: 0x00003798
		[Token(Token = "0x600071B")]
		[Address(RVA = "0x2B47240", Offset = "0x2B45840", VA = "0x182B47240")]
		private Vector3 GetCurrentPosition()
		{
			return default(Vector3);
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x000055B0 File Offset: 0x000037B0
		[Token(Token = "0x600071C")]
		[Address(RVA = "0x2B47310", Offset = "0x2B45910", VA = "0x182B47310")]
		public Vector3 GetNextPoint()
		{
			return default(Vector3);
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600071D")]
		[Address(RVA = "0x2B473B0", Offset = "0x2B459B0", VA = "0x182B473B0")]
		public void SetActive(bool newActive)
		{
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600071E")]
		[Address(RVA = "0xA53180", Offset = "0xA51780", VA = "0x180A53180")]
		public void SetRandomFlight(bool value)
		{
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600071F")]
		[Address(RVA = "0x2B47450", Offset = "0x2B45A50", VA = "0x182B47450")]
		public void SetFlySpeedTarget(float value)
		{
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000720")]
		[Address(RVA = "0x750FB0", Offset = "0x74F5B0", VA = "0x180750FB0")]
		public void SetBoundsShape(BoundsShape shape)
		{
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000721")]
		[Address(RVA = "0x270DEF0", Offset = "0x270C4F0", VA = "0x18270DEF0")]
		public void SetClampToBounds(bool value)
		{
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000722")]
		[Address(RVA = "0x2B47460", Offset = "0x2B45A60", VA = "0x182B47460")]
		public void SetKeepAboveTerrain(bool value)
		{
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000723")]
		[Address(RVA = "0x2B47470", Offset = "0x2B45A70", VA = "0x182B47470")]
		public void SetInitialVelocity(Vector3 initialVelocity)
		{
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x000055C8 File Offset: 0x000037C8
		[Token(Token = "0x6000724")]
		[Address(RVA = "0x2B47510", Offset = "0x2B45B10", VA = "0x182B47510")]
		private float GetDeltaFromCurve(AnimationCurve curve, float t, float deltaTime)
		{
			return 0f;
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000725")]
		[Address(RVA = "0x2B475F0", Offset = "0x2B45BF0", VA = "0x182B475F0")]
		private AnimationCurve GetMovementCurve(FlightPathMover.AnimState animState)
		{
			return null;
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000726")]
		[Address(RVA = "0x2B47620", Offset = "0x2B45C20", VA = "0x182B47620")]
		public void MoveOnPath(float deltaTime, Transform moverTransform)
		{
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000727")]
		[Address(RVA = "0x2B482A0", Offset = "0x2B468A0", VA = "0x182B482A0")]
		public void RemovePreviousSegments(int numRemoved)
		{
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000728")]
		[Address(RVA = "0x2B483C0", Offset = "0x2B469C0", VA = "0x182B483C0")]
		public void SplitPath(Vector3 startPoint, Vector3 initialVelocity)
		{
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000729")]
		[Address(RVA = "0x2B48530", Offset = "0x2B46B30", VA = "0x182B48530")]
		public void TakeOffPath(Transform moverTransform, bool ignorePathBounds)
		{
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600072A")]
		[Address(RVA = "0x2B48950", Offset = "0x2B46F50", VA = "0x182B48950")]
		public void CirclePoint(Vector3 point, float minOffsetY, float maxOffsetY, float radius, float numCircles, [Optional] Vector3 centerDelta, [Optional] Vector3 initialDir, [Optional] BoundsShape boundsShape)
		{
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600072B")]
		[Address(RVA = "0x2B490E0", Offset = "0x2B476E0", VA = "0x182B490E0")]
		public void FlybyPoint(Vector3 point)
		{
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600072C")]
		[Address(RVA = "0x2B49310", Offset = "0x2B47910", VA = "0x182B49310")]
		public void FlyToTransform(Transform ourTransform, Transform targetTransform, float stopDistance, bool ignoreBounds)
		{
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600072D")]
		[Address(RVA = "0x2B49720", Offset = "0x2B47D20", VA = "0x182B49720")]
		public void SwoopToTransform(Transform ourTransform, Transform targetTransform)
		{
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600072E")]
		[Address(RVA = "0x2B49A70", Offset = "0x2B48070", VA = "0x182B49A70")]
		public void FlyExploreRandom(Transform tr, float maxYawDelta, float minDistance, float maxDistance, float maxPitch = 30f)
		{
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600072F")]
		[Address(RVA = "0x2B49B00", Offset = "0x2B48100", VA = "0x182B49B00")]
		public void AddRandomWaypoint(Transform tr)
		{
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x000055E0 File Offset: 0x000037E0
		[Token(Token = "0x6000730")]
		[Address(RVA = "0x2B49C90", Offset = "0x2B48290", VA = "0x182B49C90")]
		public Vector3 GetRandomWaypoint(Vector3 forward, Vector3 right, float clearanceRadius, BoundsShape boundsShape, float maxYawChange = 100f, float minDistance = 10f, float maxDistance = 25f, float minPitch = -30f, float maxPitch = 30f)
		{
			return default(Vector3);
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x000055F8 File Offset: 0x000037F8
		[Token(Token = "0x6000731")]
		[Address(RVA = "0x2B4A770", Offset = "0x2B48D70", VA = "0x182B4A770")]
		private float GetCurveLength(AnimationCurve curve)
		{
			return 0f;
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000732")]
		[Address(RVA = "0x2B4A850", Offset = "0x2B48E50", VA = "0x182B4A850")]
		public void LandingPath(Vector3 start, Vector3 end, float stopDistance, bool snapEndToGround, bool raycastVerify, Transform current, FlightPathMover.AnimState finalSegmentState = FlightPathMover.AnimState.Landing)
		{
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000733")]
		[Address(RVA = "0x2B4B990", Offset = "0x2B49F90", VA = "0x182B4B990")]
		private void CreateAnglesArray()
		{
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x00005610 File Offset: 0x00003810
		[Token(Token = "0x6000734")]
		[Address(RVA = "0x2B4BAE0", Offset = "0x2B4A0E0", VA = "0x182B4BAE0")]
		private bool RaycastPathSegment(Vector3 start, Vector3 end, float endAdjust = 0f)
		{
			return default(bool);
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x00005628 File Offset: 0x00003828
		[Token(Token = "0x6000735")]
		[Address(RVA = "0x2B4BE50", Offset = "0x2B4A450", VA = "0x182B4BE50")]
		public static Vector3 TrySnapToGround(Vector3 position, out bool onWater, float maxDist = 1f)
		{
			return default(Vector3);
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00005640 File Offset: 0x00003840
		[Token(Token = "0x6000736")]
		[Address(RVA = "0x2B4C230", Offset = "0x2B4A830", VA = "0x182B4C230")]
		private bool VerifyLandingPath(List<Vector3> landingPath)
		{
			return default(bool);
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000737")]
		[Address(RVA = "0x2B4C480", Offset = "0x2B4AA80", VA = "0x182B4C480")]
		private void AddPathSegment(List<Vector3> points, int i, FlightPathMover.AnimState animType, bool dynamicTarget)
		{
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00005658 File Offset: 0x00003858
		[Token(Token = "0x6000738")]
		[Address(RVA = "0x2B4C970", Offset = "0x2B4AF70", VA = "0x182B4C970")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Vector3 CubicCurve(Vector3 p1, Vector3 p2, Vector3 vel1, Vector3 vel2, float t)
		{
			return default(Vector3);
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000739")]
		[Address(RVA = "0x2B4CB00", Offset = "0x2B4B100", VA = "0x182B4CB00")]
		private void DrawAsCurve(int subDivCount = 30)
		{
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600073A")]
		[Address(RVA = "0x2B4CE10", Offset = "0x2B4B410", VA = "0x182B4CE10")]
		private void DrawSegments()
		{
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600073B")]
		[Address(RVA = "0x2B4D040", Offset = "0x2B4B640", VA = "0x182B4D040")]
		private void DrawPoints()
		{
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600073C")]
		[Address(RVA = "0x2B4D1F0", Offset = "0x2B4B7F0", VA = "0x182B4D1F0")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600073D")]
		[Address(RVA = "0x2B4D3C0", Offset = "0x2B4B9C0", VA = "0x182B4D3C0")]
		public FlightPathMover()
		{
		}

		// Token: 0x04000589 RID: 1417
		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _useFlightAnimBools;

		// Token: 0x0400058A RID: 1418
		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _flySpeed;

		// Token: 0x0400058B RID: 1419
		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _flyAccel;

		// Token: 0x0400058C RID: 1420
		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _takeOffSpeed;

		// Token: 0x0400058D RID: 1421
		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _postSwoopSpeed;

		// Token: 0x0400058E RID: 1422
		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AnimationCurve _landingCurve;

		// Token: 0x0400058F RID: 1423
		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AnimationCurve _slowToHoverCurve;

		// Token: 0x04000590 RID: 1424
		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AnimationCurve _takeOffCurve;

		// Token: 0x04000591 RID: 1425
		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AnimationCurve _swoopCurve;

		// Token: 0x04000592 RID: 1426
		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _idealLandingPitch;

		// Token: 0x04000593 RID: 1427
		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _idealTakeoffPitch;

		// Token: 0x04000594 RID: 1428
		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool _useCircleUpDown;

		// Token: 0x04000595 RID: 1429
		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float _circleRadius;

		// Token: 0x04000596 RID: 1430
		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _castRadius;

		// Token: 0x04000597 RID: 1431
		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float _clearanceRadius;

		// Token: 0x04000598 RID: 1432
		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _rotationSpeed;

		// Token: 0x04000599 RID: 1433
		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		private bool _clampToBounds;

		// Token: 0x0400059A RID: 1434
		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public FlightPathMover.AnimState _animType;

		// Token: 0x0400059B RID: 1435
		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float _animStateTime;

		// Token: 0x0400059C RID: 1436
		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Animator _animator;

		// Token: 0x0400059D RID: 1437
		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FlightPathMover.PathMover _pathMover;

		// Token: 0x0400059E RID: 1438
		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private List<FlightPathMover.Segment> _segments;

		// Token: 0x0400059F RID: 1439
		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool _randomFlight;

		// Token: 0x040005A0 RID: 1440
		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		private bool _isActive;

		// Token: 0x040005A1 RID: 1441
		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9A")]
		private bool _keepAboveTerrain;

		// Token: 0x040005A2 RID: 1442
		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BoundsShape _boundsShape;

		// Token: 0x040005A3 RID: 1443
		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private List<Vector3> _pathPoints;

		// Token: 0x040005A4 RID: 1444
		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool _hasHoverBool;

		// Token: 0x040005A5 RID: 1445
		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		private bool _hasSwoopBool;

		// Token: 0x040005A6 RID: 1446
		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float _scale;

		// Token: 0x040005A7 RID: 1447
		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float _flySpeedTarget;

		// Token: 0x040005A8 RID: 1448
		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private List<float> _angleOffsets;

		// Token: 0x040005A9 RID: 1449
		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float _randomMaxYawDelta;

		// Token: 0x040005AA RID: 1450
		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float _randomMinDistance;

		// Token: 0x040005AB RID: 1451
		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float _randomMaxDistance;

		// Token: 0x040005AC RID: 1452
		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private float _randomMaxPitch;

		// Token: 0x040005AD RID: 1453
		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Transform _flyTargetTransform;

		// Token: 0x040005AE RID: 1454
		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float _flyTargetStopDistance;

		// Token: 0x040005AF RID: 1455
		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int HoverBoolId;

		// Token: 0x040005B0 RID: 1456
		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly int FlyBoolId;

		// Token: 0x040005B1 RID: 1457
		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int SwoopBoolId;

		// Token: 0x020000B6 RID: 182
		[Token(Token = "0x20000B6")]
		public enum AnimState
		{
			// Token: 0x040005B3 RID: 1459
			[Token(Token = "0x40005B3")]
			TakeOff,
			// Token: 0x040005B4 RID: 1460
			[Token(Token = "0x40005B4")]
			Landing,
			// Token: 0x040005B5 RID: 1461
			[Token(Token = "0x40005B5")]
			Flying,
			// Token: 0x040005B6 RID: 1462
			[Token(Token = "0x40005B6")]
			SlowToHover,
			// Token: 0x040005B7 RID: 1463
			[Token(Token = "0x40005B7")]
			Swoop,
			// Token: 0x040005B8 RID: 1464
			[Token(Token = "0x40005B8")]
			Hovering,
			// Token: 0x040005B9 RID: 1465
			[Token(Token = "0x40005B9")]
			Stopped
		}

		// Token: 0x020000B7 RID: 183
		[Token(Token = "0x20000B7")]
		[Serializable]
		public class Segment
		{
			// Token: 0x0600073F RID: 1855 RVA: 0x00005670 File Offset: 0x00003870
			[Token(Token = "0x600073F")]
			[Address(RVA = "0x2B4D780", Offset = "0x2B4BD80", VA = "0x182B4D780")]
			public Vector3 Sample(float t)
			{
				return default(Vector3);
			}

			// Token: 0x06000740 RID: 1856 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000740")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public Segment()
			{
			}

			// Token: 0x040005BA RID: 1466
			[Token(Token = "0x40005BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 p1;

			// Token: 0x040005BB RID: 1467
			[Token(Token = "0x40005BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 p2;

			// Token: 0x040005BC RID: 1468
			[Token(Token = "0x40005BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 v1;

			// Token: 0x040005BD RID: 1469
			[Token(Token = "0x40005BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 v2;

			// Token: 0x040005BE RID: 1470
			[Token(Token = "0x40005BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float length;

			// Token: 0x040005BF RID: 1471
			[Token(Token = "0x40005BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public FlightPathMover.AnimState animType;

			// Token: 0x040005C0 RID: 1472
			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public bool dynamicTarget;
		}

		// Token: 0x020000B8 RID: 184
		[Token(Token = "0x20000B8")]
		[Serializable]
		public class PathMover
		{
			// Token: 0x06000741 RID: 1857 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000741")]
			[Address(RVA = "0x2B4D9C0", Offset = "0x2B4BFC0", VA = "0x182B4D9C0")]
			public void Reset()
			{
			}

			// Token: 0x06000742 RID: 1858 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000742")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public PathMover()
			{
			}

			// Token: 0x040005C1 RID: 1473
			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int segIdx;

			// Token: 0x040005C2 RID: 1474
			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float distance;
		}
	}
}
