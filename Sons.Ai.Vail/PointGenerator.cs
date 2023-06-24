using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;

// Token: 0x02000009 RID: 9
[Token(Token = "0x2000009")]
[AddComponentMenu("Sons/Utilities/Point Generator")]
public class PointGenerator : MonoBehaviour
{
	// Token: 0x17000004 RID: 4
	// (get) Token: 0x0600003E RID: 62 RVA: 0x00002280 File Offset: 0x00000480
	[Token(Token = "0x17000004")]
	private bool StimuliIsSet
	{
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x2AE7710", Offset = "0x2AE5D10", VA = "0x182AE7710")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x0600003F RID: 63 RVA: 0x00002298 File Offset: 0x00000498
	[Token(Token = "0x17000005")]
	private bool ShowClusters
	{
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x2AE77D0", Offset = "0x2AE5DD0", VA = "0x182AE77D0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000040 RID: 64 RVA: 0x0000227A File Offset: 0x0000047A
	[Token(Token = "0x17000006")]
	private string GetCountLabel
	{
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x2AE77E0", Offset = "0x2AE5DE0", VA = "0x182AE77E0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x06000041 RID: 65 RVA: 0x000022B0 File Offset: 0x000004B0
	[Token(Token = "0x17000007")]
	private bool ShowRing
	{
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x2AE7830", Offset = "0x2AE5E30", VA = "0x182AE7830")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x06000042 RID: 66 RVA: 0x000022C8 File Offset: 0x000004C8
	[Token(Token = "0x17000008")]
	private bool ShowSlope
	{
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x2AE7910", Offset = "0x2AE5F10", VA = "0x182AE7910")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x06000043 RID: 67 RVA: 0x000022E0 File Offset: 0x000004E0
	[Token(Token = "0x17000009")]
	private bool TypeIsMesh
	{
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x2AE7930", Offset = "0x2AE5F30", VA = "0x182AE7930")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000044 RID: 68 RVA: 0x000022F8 File Offset: 0x000004F8
	[Token(Token = "0x6000044")]
	[Address(RVA = "0x2AE7940", Offset = "0x2AE5F40", VA = "0x182AE7940")]
	private int GetPointCount()
	{
		return 0;
	}

	// Token: 0x06000045 RID: 69 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000045")]
	[Address(RVA = "0x2AE7980", Offset = "0x2AE5F80", VA = "0x182AE7980")]
	public void GeneratePoints()
	{
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000046")]
	[Address(RVA = "0x2AE7990", Offset = "0x2AE5F90", VA = "0x182AE7990")]
	public void SnapExisting()
	{
	}

	// Token: 0x06000047 RID: 71 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000047")]
	[Address(RVA = "0x2AE7AE0", Offset = "0x2AE60E0", VA = "0x182AE7AE0")]
	private void CreateBoundsShape()
	{
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000048")]
	[Address(RVA = "0x2AE7D50", Offset = "0x2AE6350", VA = "0x182AE7D50")]
	private void RegisterGameObjectsButton()
	{
	}

	// Token: 0x06000049 RID: 73 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000049")]
	[Address(RVA = "0x2AE7D60", Offset = "0x2AE6360", VA = "0x182AE7D60")]
	private void RegisterGameObjects()
	{
	}

	// Token: 0x0600004A RID: 74 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004A")]
	[Address(RVA = "0x2AE7E00", Offset = "0x2AE6400", VA = "0x182AE7E00")]
	private void OnValidate()
	{
	}

	// Token: 0x0600004B RID: 75 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004B")]
	[Address(RVA = "0x2AE8040", Offset = "0x2AE6640", VA = "0x182AE8040")]
	private void Start()
	{
	}

	// Token: 0x0600004C RID: 76 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004C")]
	[Address(RVA = "0x2AE8150", Offset = "0x2AE6750", VA = "0x182AE8150")]
	private void AddReservableLocation(Vector3 point, int i)
	{
	}

	// Token: 0x0600004D RID: 77 RVA: 0x00002310 File Offset: 0x00000510
	[Token(Token = "0x600004D")]
	[Address(RVA = "0x2AE85C0", Offset = "0x2AE6BC0", VA = "0x182AE85C0")]
	private Vector3 GenerateRandomPoint(int i = 0, [Optional] MeshCollider meshCollider)
	{
		return default(Vector3);
	}

	// Token: 0x0600004E RID: 78 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004E")]
	[Address(RVA = "0x2AE87C0", Offset = "0x2AE6DC0", VA = "0x182AE87C0")]
	private void GeneratePointsInternal()
	{
	}

	// Token: 0x0600004F RID: 79 RVA: 0x00002328 File Offset: 0x00000528
	[Token(Token = "0x600004F")]
	[Address(RVA = "0x2AE91F0", Offset = "0x2AE77F0", VA = "0x182AE91F0")]
	private Vector3 GetPoint(int i)
	{
		return default(Vector3);
	}

	// Token: 0x06000050 RID: 80 RVA: 0x00002340 File Offset: 0x00000540
	[Token(Token = "0x6000050")]
	[Address(RVA = "0x2AE9420", Offset = "0x2AE7A20", VA = "0x182AE9420")]
	private bool IsValidSpawnNormal(Vector3 normal, Vector3 rayDir)
	{
		return default(bool);
	}

	// Token: 0x06000051 RID: 81 RVA: 0x00002358 File Offset: 0x00000558
	[Token(Token = "0x6000051")]
	[Address(RVA = "0x2AE94B0", Offset = "0x2AE7AB0", VA = "0x182AE94B0")]
	private Vector3 SnapPoint(Vector3 pointLocal, out bool valid, MeshCollider meshCollider)
	{
		return default(Vector3);
	}

	// Token: 0x06000052 RID: 82 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000052")]
	[Address(RVA = "0x2AE9FB0", Offset = "0x2AE85B0", VA = "0x182AE9FB0")]
	private void DrawGizmoCircle(Vector3 pos, float radius)
	{
	}

	// Token: 0x06000053 RID: 83 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000053")]
	[Address(RVA = "0x2AEA260", Offset = "0x2AE8860", VA = "0x182AEA260")]
	public void DrawPointGizmos()
	{
	}

	// Token: 0x06000054 RID: 84 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000054")]
	[Address(RVA = "0x2AEA510", Offset = "0x2AE8B10", VA = "0x182AEA510")]
	private void OnDrawGizmosSelected()
	{
	}

	// Token: 0x06000055 RID: 85 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000055")]
	[Address(RVA = "0x2AEA780", Offset = "0x2AE8D80", VA = "0x182AEA780")]
	private void CheckPointCollision()
	{
	}

	// Token: 0x06000056 RID: 86 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000056")]
	[Address(RVA = "0x2AEAB60", Offset = "0x2AE9160", VA = "0x182AEAB60")]
	public PointGenerator()
	{
	}

	// Token: 0x0400003F RID: 63
	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Tooltip("If these points are locations for a stimuli, set it here.")]
	[SerializeField]
	private MonoBehaviourStimuli _stimuli;

	// Token: 0x04000040 RID: 64
	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Tooltip("The points will be generated inside this bounds shape.")]
	private BoundsShape _bounds;

	// Token: 0x04000041 RID: 65
	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Tooltip("Register the point locations with stimuli on start play.")]
	private bool _registerOnStart;

	// Token: 0x04000042 RID: 66
	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	private PointGenerator.GenType _pointGenType;

	// Token: 0x04000043 RID: 67
	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private PointGenerator.RingGenType _ringGenType;

	// Token: 0x04000044 RID: 68
	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private int _clusterCount;

	// Token: 0x04000045 RID: 69
	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private int _pointsPerCluster;

	// Token: 0x04000046 RID: 70
	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[SerializeField]
	private float _clusterRadius;

	// Token: 0x04000047 RID: 71
	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private PointGenerator.SnapToType _snapToType;

	// Token: 0x04000048 RID: 72
	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private LayerMask _layerMask;

	// Token: 0x04000049 RID: 73
	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private float _maxSlopeDegrees;

	// Token: 0x0400004A RID: 74
	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private MeshFilter _meshFilter;

	// Token: 0x0400004B RID: 75
	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private List<Vector3> _points;

	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	private enum GenType
	{
		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		Points,
		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		Point_Clusters
	}

	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	private enum RingGenType
	{
		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		Random,
		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		Even
	}

	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	private enum SnapToType
	{
		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		None,
		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		Terrain,
		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		Mesh,
		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		RaycastDown,
		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		RaycastUp,
		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		AboveTerrain
	}
}
