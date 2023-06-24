using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace NWH.DWP2.WaterObjects
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(MeshFilter))]
	public class WaterObject : MonoBehaviour
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000054 RID: 84 RVA: 0x000021CE File Offset: 0x000003CE
		// (set) Token: 0x06000055 RID: 85 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000007")]
		public Rigidbody TargetRigidbody
		{
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x6F1D00", Offset = "0x6F0300", VA = "0x1806F1D00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x6F1D10", Offset = "0x6F0310", VA = "0x1806F1D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000056 RID: 86 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x17000008")]
		public Mesh OriginalMesh
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000057 RID: 87 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x17000009")]
		public Mesh SimulationMesh
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x661070", Offset = "0x65F670", VA = "0x180661070")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000058 RID: 88 RVA: 0x000022AC File Offset: 0x000004AC
		// (set) Token: 0x06000059 RID: 89 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000A")]
		public bool Initialized
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x612480", Offset = "0x610A80", VA = "0x180612480")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x612490", Offset = "0x610A90", VA = "0x180612490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600005A RID: 90 RVA: 0x000022C4 File Offset: 0x000004C4
		[Token(Token = "0x1700000B")]
		public bool PreviewEnabled
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x2701DA0", Offset = "0x27003A0", VA = "0x182701DA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600005B RID: 91 RVA: 0x000022DC File Offset: 0x000004DC
		[Token(Token = "0x1700000C")]
		public int TriangleCount
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x2702010", Offset = "0x2700610", VA = "0x182702010")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600005C RID: 92 RVA: 0x000022F4 File Offset: 0x000004F4
		[Token(Token = "0x1700000D")]
		public SerializedMesh SerializedSimulationMesh
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x151E610", Offset = "0x151CC10", VA = "0x18151E610")]
			get
			{
				return default(SerializedMesh);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600005D RID: 93 RVA: 0x0000230C File Offset: 0x0000050C
		[Token(Token = "0x1700000E")]
		public int TriDataStart
		{
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x2702110", Offset = "0x2700710", VA = "0x182702110")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00002324 File Offset: 0x00000524
		[Token(Token = "0x1700000F")]
		public int TriDataLength
		{
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x2702190", Offset = "0x2700790", VA = "0x182702190")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600005F RID: 95 RVA: 0x0000233C File Offset: 0x0000053C
		[Token(Token = "0x17000010")]
		public int TriDataEnd
		{
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x27021E0", Offset = "0x27007E0", VA = "0x1827021E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00002354 File Offset: 0x00000554
		[Token(Token = "0x17000011")]
		public int VertDataStart
		{
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x2702260", Offset = "0x2700860", VA = "0x182702260")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000061 RID: 97 RVA: 0x0000236C File Offset: 0x0000056C
		[Token(Token = "0x17000012")]
		public int VertDataLength
		{
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x27022E0", Offset = "0x27008E0", VA = "0x1827022E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00002384 File Offset: 0x00000584
		[Token(Token = "0x17000013")]
		public int VertDataEnd
		{
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x2702330", Offset = "0x2700930", VA = "0x182702330")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000063 RID: 99 RVA: 0x0000239C File Offset: 0x0000059C
		// (set) Token: 0x06000064 RID: 100 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000014")]
		public int WoArrayIndex
		{
			[Token(Token = "0x6000063")]
			[Address(RVA = "0xAFF280", Offset = "0xAFD880", VA = "0x180AFF280")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000064")]
			[Address(RVA = "0xAFF290", Offset = "0xAFD890", VA = "0x180AFF290")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x27023B0", Offset = "0x27009B0", VA = "0x1827023B0")]
		private void Awake()
		{
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x27023C0", Offset = "0x27009C0", VA = "0x1827023C0")]
		public void Initialize()
		{
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000023B4 File Offset: 0x000005B4
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x2702B70", Offset = "0x2701170", VA = "0x182702B70")]
		public bool IsTouchingWater()
		{
			return default(bool);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x2702C30", Offset = "0x2701230", VA = "0x182702C30")]
		public void StartSimMeshPreview()
		{
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x2702F10", Offset = "0x2701510", VA = "0x182702F10")]
		private void OnDisable()
		{
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x27030D0", Offset = "0x27016D0", VA = "0x1827030D0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x2703280", Offset = "0x2701880", VA = "0x182703280")]
		public void GetStates(ref byte[] states)
		{
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x2703360", Offset = "0x2701960", VA = "0x182703360")]
		public void GetForcePoints(ref Vector3[] points)
		{
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x2703440", Offset = "0x2701A40", VA = "0x182703440")]
		public void GetForces(ref Vector3[] forces)
		{
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x2703520", Offset = "0x2701B20", VA = "0x182703520")]
		public void GetNormals(ref Vector3[] normals)
		{
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x2703600", Offset = "0x2701C00", VA = "0x182703600")]
		public void GetAreas(ref Vector3[] areas)
		{
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x27036E0", Offset = "0x2701CE0", VA = "0x1827036E0")]
		public void GetVelocities(ref Vector3[] velocities)
		{
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x27037C0", Offset = "0x2701DC0", VA = "0x1827037C0")]
		public void GetDistances(ref Vector3[] distances)
		{
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x27038A0", Offset = "0x2701EA0", VA = "0x1827038A0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x2703A60", Offset = "0x2702060", VA = "0x182703A60")]
		public void GenerateSimMesh()
		{
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x2703E20", Offset = "0x2702420", VA = "0x182703E20")]
		public void StopSimMeshPreview()
		{
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x27040D0", Offset = "0x27026D0", VA = "0x1827040D0")]
		private void ShowErrorMessage()
		{
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x2704160", Offset = "0x2702760", VA = "0x182704160")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x27041E0", Offset = "0x27027E0", VA = "0x1827041E0")]
		public WaterObject()
		{
		}

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		public const bool ShowEditorWarnings = true;

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x20")]
		public bool hasBeenSynchronized;

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x24")]
		[Range(0f, 5f)]
		public float dynamicForceCoeff;

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x28")]
		[Range(0.01f, 5f)]
		public float dynamicForcePowerCoeff;

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 5f)]
		public float skinFrictionDragCoeff;

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x30")]
		public bool convexifyMesh;

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x31")]
		public bool simplifyMesh;

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x32")]
		public bool weldColocatedVertices;

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x34")]
		[Range(8f, 256f)]
		[FormerlySerializedAs("targetTris")]
		public int targetTriangleCount;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Mesh _originalMesh;

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SerializedMesh _serializedSimulationMesh;

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Mesh _simulationMesh;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool editorHasErrors;

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x60")]
		private MeshFilter _meshFilter;

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x68")]
		private float _simplificationRatio;
	}
}
