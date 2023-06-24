using System;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;

// Token: 0x02000005 RID: 5
[Token(Token = "0x2000005")]
[AddComponentMenu("Sons/Utilities/Bounds Shape")]
public class BoundsShape : MonoBehaviour
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000015 RID: 21 RVA: 0x00002054 File Offset: 0x00000254
	[Token(Token = "0x17000001")]
	private bool ShowRadius
	{
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2AE38B0", Offset = "0x2AE1EB0", VA = "0x182AE38B0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000016 RID: 22 RVA: 0x0000206C File Offset: 0x0000026C
	[Token(Token = "0x17000002")]
	private bool ShowHeight
	{
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x2AE38D0", Offset = "0x2AE1ED0", VA = "0x182AE38D0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000017 RID: 23 RVA: 0x00002084 File Offset: 0x00000284
	[Token(Token = "0x17000003")]
	public bool IsRing
	{
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x2AE38E0", Offset = "0x2AE1EE0", VA = "0x182AE38E0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000018 RID: 24 RVA: 0x0000209C File Offset: 0x0000029C
	[Token(Token = "0x6000018")]
	[Address(RVA = "0x9EA6A0", Offset = "0x9E8CA0", VA = "0x1809EA6A0")]
	public bool ShowTerrainOptions()
	{
		return default(bool);
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000019")]
	[Address(RVA = "0x2AE38F0", Offset = "0x2AE1EF0", VA = "0x182AE38F0")]
	private void Awake()
	{
	}

	// Token: 0x0600001A RID: 26 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001A")]
	[Address(RVA = "0x2AE3900", Offset = "0x2AE1F00", VA = "0x182AE3900")]
	public void Init()
	{
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001B")]
	[Address(RVA = "0x2AE39B0", Offset = "0x2AE1FB0", VA = "0x182AE39B0")]
	public void SetColor(Color newColor)
	{
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001C")]
	[Address(RVA = "0x2AE39C0", Offset = "0x2AE1FC0", VA = "0x182AE39C0")]
	public void SetFromAABB(Vector3 min, Vector3 max)
	{
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001D")]
	[Address(RVA = "0x2AE3A30", Offset = "0x2AE2030", VA = "0x182AE3A30")]
	public void SetLocalCenterAndSize(Vector3 center, Vector3 size)
	{
	}

	// Token: 0x0600001E RID: 30 RVA: 0x000020B4 File Offset: 0x000002B4
	[Token(Token = "0x600001E")]
	[Address(RVA = "0x2AE3A60", Offset = "0x2AE2060", VA = "0x182AE3A60")]
	public Vector3 GetRandomPointInBounds(VailWorldSimulation worldSim, bool avoidVillages, bool avoidPlayers)
	{
		return default(Vector3);
	}

	// Token: 0x0600001F RID: 31 RVA: 0x000020CC File Offset: 0x000002CC
	[Token(Token = "0x600001F")]
	[Address(RVA = "0x2AE3C50", Offset = "0x2AE2250", VA = "0x182AE3C50")]
	public Vector3 GetRandomPointInBounds(out bool success)
	{
		return default(Vector3);
	}

	// Token: 0x06000020 RID: 32 RVA: 0x000020E4 File Offset: 0x000002E4
	[Token(Token = "0x6000020")]
	[Address(RVA = "0x2AE3F50", Offset = "0x2AE2550", VA = "0x182AE3F50")]
	public Vector3 GetPointOnRing(int index, int total)
	{
		return default(Vector3);
	}

	// Token: 0x06000021 RID: 33 RVA: 0x000020FC File Offset: 0x000002FC
	[Token(Token = "0x6000021")]
	[Address(RVA = "0x2AE4130", Offset = "0x2AE2730", VA = "0x182AE4130")]
	private float GetTerrainHeight(Vector3 point)
	{
		return 0f;
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00002114 File Offset: 0x00000314
	[Token(Token = "0x6000022")]
	[Address(RVA = "0x2AE4200", Offset = "0x2AE2800", VA = "0x182AE4200")]
	private Vector3 KeepAboveTerrain(Vector3 point)
	{
		return default(Vector3);
	}

	// Token: 0x06000023 RID: 35 RVA: 0x0000212C File Offset: 0x0000032C
	[Token(Token = "0x6000023")]
	[Address(RVA = "0x2AE42A0", Offset = "0x2AE28A0", VA = "0x182AE42A0")]
	private static Vector3 RandomPointInBox(Transform tr, Vector3 center, Vector3 extent)
	{
		return default(Vector3);
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00002144 File Offset: 0x00000344
	[Token(Token = "0x6000024")]
	[Address(RVA = "0x2AE4410", Offset = "0x2AE2A10", VA = "0x182AE4410")]
	private static Vector3 PointOnRing(Transform tr, Vector3 center, float radius, float degrees)
	{
		return default(Vector3);
	}

	// Token: 0x06000025 RID: 37 RVA: 0x0000215C File Offset: 0x0000035C
	[Token(Token = "0x6000025")]
	[Address(RVA = "0x2AE4560", Offset = "0x2AE2B60", VA = "0x182AE4560")]
	private static Vector3 RandomPointInSphere(Transform tr, Vector3 center, float radius)
	{
		return default(Vector3);
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00002174 File Offset: 0x00000374
	[Token(Token = "0x6000026")]
	[Address(RVA = "0x2AE4680", Offset = "0x2AE2C80", VA = "0x182AE4680")]
	private static Vector3 RandomPointInCylinder(Transform tr, Vector3 center, float radius, float height)
	{
		return default(Vector3);
	}

	// Token: 0x06000027 RID: 39 RVA: 0x0000218C File Offset: 0x0000038C
	[Token(Token = "0x6000027")]
	[Address(RVA = "0x2AE4830", Offset = "0x2AE2E30", VA = "0x182AE4830")]
	public Vector3 ClampToBounds(Vector3 point, bool allowTerrainCheck = true)
	{
		return default(Vector3);
	}

	// Token: 0x06000028 RID: 40 RVA: 0x000021A4 File Offset: 0x000003A4
	[Token(Token = "0x6000028")]
	[Address(RVA = "0x2AE4CA0", Offset = "0x2AE32A0", VA = "0x182AE4CA0")]
	public bool IsPointInShapeBounds(Vector3 point, bool allowTerrainCheck = true)
	{
		return default(bool);
	}

	// Token: 0x06000029 RID: 41 RVA: 0x000021BC File Offset: 0x000003BC
	[Token(Token = "0x6000029")]
	[Address(RVA = "0x2AE4F00", Offset = "0x2AE3500", VA = "0x182AE4F00")]
	public Vector3 GetCenter()
	{
		return default(Vector3);
	}

	// Token: 0x0600002A RID: 42 RVA: 0x000021D4 File Offset: 0x000003D4
	[Token(Token = "0x600002A")]
	[Address(RVA = "0x2AE5000", Offset = "0x2AE3600", VA = "0x182AE5000")]
	public float GetHeightY()
	{
		return 0f;
	}

	// Token: 0x0600002B RID: 43 RVA: 0x000021EC File Offset: 0x000003EC
	[Token(Token = "0x600002B")]
	[Address(RVA = "0x2AE5090", Offset = "0x2AE3690", VA = "0x182AE5090")]
	public float GetBottomY()
	{
		return 0f;
	}

	// Token: 0x0600002C RID: 44 RVA: 0x00002204 File Offset: 0x00000404
	[Token(Token = "0x600002C")]
	[Address(RVA = "0x2AE5220", Offset = "0x2AE3820", VA = "0x182AE5220")]
	public float GetTopY()
	{
		return 0f;
	}

	// Token: 0x0600002D RID: 45 RVA: 0x0000221C File Offset: 0x0000041C
	[Token(Token = "0x600002D")]
	[Address(RVA = "0x2AE53B0", Offset = "0x2AE39B0", VA = "0x182AE53B0")]
	public float GetBoundsRadius()
	{
		return 0f;
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002E")]
	[Address(RVA = "0x2AE5460", Offset = "0x2AE3A60", VA = "0x182AE5460")]
	public void MatchBoxCollider(BoxCollider boxCollider, float offsetY)
	{
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002F")]
	[Address(RVA = "0x2AE5630", Offset = "0x2AE3C30", VA = "0x182AE5630")]
	public void SetKeepAboveTerrain(bool value, float minDistAboveTerrain, float maxDistAboveTerrain = 100000f)
	{
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00002234 File Offset: 0x00000434
	[Token(Token = "0x6000030")]
	[Address(RVA = "0x2AE5640", Offset = "0x2AE3C40", VA = "0x182AE5640")]
	public float DistanceToBounds(Vector3 point)
	{
		return 0f;
	}

	// Token: 0x06000031 RID: 49 RVA: 0x0000224C File Offset: 0x0000044C
	[Token(Token = "0x6000031")]
	[Address(RVA = "0x2AE5750", Offset = "0x2AE3D50", VA = "0x182AE5750")]
	private float DistanceToBoundsXZ(Vector3 point)
	{
		return 0f;
	}

	// Token: 0x06000032 RID: 50 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000032")]
	[Address(RVA = "0x2AE57E0", Offset = "0x2AE3DE0", VA = "0x182AE57E0")]
	private static void DrawGizmoCircle(Vector3 pos, float radius)
	{
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000033")]
	[Address(RVA = "0x2AE5A90", Offset = "0x2AE4090", VA = "0x182AE5A90")]
	private static void DrawGizmoCylinder(Vector3 pos, float radius, float height)
	{
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000034")]
	[Address(RVA = "0x2AE67D0", Offset = "0x2AE4DD0", VA = "0x182AE67D0")]
	public void DrawBoundsGizmo()
	{
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000035")]
	[Address(RVA = "0x2AE6C00", Offset = "0x2AE5200", VA = "0x182AE6C00")]
	private void OnDrawGizmosSelected()
	{
	}

	// Token: 0x06000036 RID: 54 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000036")]
	[Address(RVA = "0x2AE6E10", Offset = "0x2AE5410", VA = "0x182AE6E10")]
	public BoundsShape()
	{
	}

	// Token: 0x04000029 RID: 41
	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private BoundsShape.ShapeType _shapeType;

	// Token: 0x0400002A RID: 42
	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private Vector3 _shapeCenter;

	// Token: 0x0400002B RID: 43
	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Vector3 _shapeSize;

	// Token: 0x0400002C RID: 44
	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float _shapeRadius;

	// Token: 0x0400002D RID: 45
	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float _shapeHeight;

	// Token: 0x0400002E RID: 46
	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private bool _keepAboveTerrain;

	// Token: 0x0400002F RID: 47
	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float _minDistAboveTerrain;

	// Token: 0x04000030 RID: 48
	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float _maxDistanceAboveTerrain;

	// Token: 0x04000031 RID: 49
	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private bool _includeWaterAsTerrain;

	// Token: 0x04000032 RID: 50
	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x51")]
	[Tooltip("ignore shape y on clamping/testing position, probably used with terrain height options")]
	[SerializeField]
	private bool _ignoreClampShapeY;

	// Token: 0x04000033 RID: 51
	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	private Color _drawColor;

	// Token: 0x04000034 RID: 52
	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	private bool _drawSolid;

	// Token: 0x04000035 RID: 53
	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x68")]
	private Transform _transform;

	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	private enum ShapeType
	{
		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		Box,
		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		Sphere,
		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		Ring,
		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		Cylinder
	}

	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	public readonly struct SphereBounds
	{
		// Token: 0x06000037 RID: 55 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x2AE6EB0", Offset = "0x2AE54B0", VA = "0x182AE6EB0")]
		public SphereBounds(BoundsShape boundsShape)
		{
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002264 File Offset: 0x00000464
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x2AE7000", Offset = "0x2AE5600", VA = "0x182AE7000")]
		public bool IsWithinDistance(Vector3 testPosition, float distance, bool ignoreY = false)
		{
			return default(bool);
		}

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x0")]
		private readonly Vector3 _position;

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0xC")]
		private readonly float _radius;

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x10")]
		private readonly BoundsShape _boundsShape;
	}
}
