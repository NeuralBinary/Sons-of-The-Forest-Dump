using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Events;

namespace NWH.DWP2.WaterObjects
{
	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	[Serializable]
	public class WaterObjectManager : MonoBehaviour
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000078 RID: 120 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x17000015")]
		public List<WaterObject> WaterObjects
		{
			[Token(Token = "0x6000078")]
			[Address(RVA = "0x61C550", Offset = "0x61AB50", VA = "0x18061C550")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000079 RID: 121 RVA: 0x000021CE File Offset: 0x000003CE
		// (set) Token: 0x0600007A RID: 122 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000016")]
		public byte[] States
		{
			[Token(Token = "0x6000079")]
			[Address(RVA = "0xA3F1B0", Offset = "0xA3D7B0", VA = "0x180A3F1B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600007A")]
			[Address(RVA = "0xA3F1C0", Offset = "0xA3D7C0", VA = "0x180A3F1C0")]
			private set
			{
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600007B RID: 123 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x17000017")]
		public int[] WaterObjectTriDataStarts
		{
			[Token(Token = "0x600007B")]
			[Address(RVA = "0x675FA0", Offset = "0x6745A0", VA = "0x180675FA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600007C RID: 124 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x17000018")]
		public int[] WaterObjectTriDataEnds
		{
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x6F1D00", Offset = "0x6F0300", VA = "0x1806F1D00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600007D RID: 125 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x17000019")]
		public int[] WaterObjectVertDataStarts
		{
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x6306D0", Offset = "0x62ECD0", VA = "0x1806306D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600007E RID: 126 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x1700001A")]
		public int[] WaterObjectVertDataEnds
		{
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x737410", Offset = "0x735A10", VA = "0x180737410")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600007F RID: 127 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x1700001B")]
		public Vector3[] WorldVertices
		{
			[Token(Token = "0x600007F")]
			[Address(RVA = "0x2704250", Offset = "0x2702850", VA = "0x182704250")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000080 RID: 128 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x1700001C")]
		public int[] Triangles
		{
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x7849C0", Offset = "0x782FC0", VA = "0x1807849C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000081 RID: 129 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x1700001D")]
		public Vector3[] Vertices
		{
			[Token(Token = "0x6000081")]
			[Address(RVA = "0x784A30", Offset = "0x783030", VA = "0x180784A30")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000082 RID: 130 RVA: 0x000021CE File Offset: 0x000003CE
		// (set) Token: 0x06000083 RID: 131 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700001E")]
		public Vector3[] Forces
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x784BA0", Offset = "0x7831A0", VA = "0x180784BA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x784BB0", Offset = "0x7831B0", VA = "0x180784BB0")]
			private set
			{
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000084 RID: 132 RVA: 0x000021CE File Offset: 0x000003CE
		// (set) Token: 0x06000085 RID: 133 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700001F")]
		public Vector3[] ForcePoints
		{
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x671190", Offset = "0x66F790", VA = "0x180671190")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000085")]
			[Address(RVA = "0x728460", Offset = "0x726A60", VA = "0x180728460")]
			private set
			{
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000086 RID: 134 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x17000020")]
		public float[] WaterHeights
		{
			[Token(Token = "0x6000086")]
			[Address(RVA = "0x8DF4F0", Offset = "0x8DDAF0", VA = "0x1808DF4F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000087 RID: 135 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x17000021")]
		public Vector3[] WaterNormals
		{
			[Token(Token = "0x6000087")]
			[Address(RVA = "0x1359C20", Offset = "0x1358220", VA = "0x181359C20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000088 RID: 136 RVA: 0x000021CE File Offset: 0x000003CE
		[Token(Token = "0x17000022")]
		public Vector3[] WaterFlows
		{
			[Token(Token = "0x6000088")]
			[Address(RVA = "0x8DF480", Offset = "0x8DDA80", VA = "0x1808DF480")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000089 RID: 137 RVA: 0x000021CE File Offset: 0x000003CE
		// (set) Token: 0x0600008A RID: 138 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000023")]
		public Vector3[] Normals
		{
			[Token(Token = "0x6000089")]
			[Address(RVA = "0x784AA0", Offset = "0x7830A0", VA = "0x180784AA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x784AB0", Offset = "0x7830B0", VA = "0x180784AB0")]
			private set
			{
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600008B RID: 139 RVA: 0x000021CE File Offset: 0x000003CE
		// (set) Token: 0x0600008C RID: 140 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000024")]
		public float[] Areas
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x737420", Offset = "0x735A20", VA = "0x180737420")]
			get
			{
				return null;
			}
			[Token(Token = "0x600008C")]
			[Address(RVA = "0x750FB0", Offset = "0x74F5B0", VA = "0x180750FB0")]
			private set
			{
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600008D RID: 141 RVA: 0x000021CE File Offset: 0x000003CE
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000025")]
		public Vector3[] Velocities
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0xA3F220", Offset = "0xA3D820", VA = "0x180A3F220")]
			get
			{
				return null;
			}
			[Token(Token = "0x600008E")]
			[Address(RVA = "0xA3F230", Offset = "0xA3D830", VA = "0x180A3F230")]
			private set
			{
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600008F RID: 143 RVA: 0x000021CE File Offset: 0x000003CE
		// (set) Token: 0x06000090 RID: 144 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000026")]
		public float[] DistancesToSurface
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0x751010", Offset = "0x74F610", VA = "0x180751010")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x13428C0", Offset = "0x1340EC0", VA = "0x1813428C0")]
			private set
			{
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000091 RID: 145 RVA: 0x000021CE File Offset: 0x000003CE
		// (set) Token: 0x06000092 RID: 146 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000027")]
		public Vector3[] P0S
		{
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x2704260", Offset = "0x2702860", VA = "0x182704260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x2704270", Offset = "0x2702870", VA = "0x182704270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000093 RID: 147 RVA: 0x000023CC File Offset: 0x000005CC
		// (set) Token: 0x06000094 RID: 148 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000028")]
		public int TriangleCount
		{
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x27042D0", Offset = "0x27028D0", VA = "0x1827042D0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x27042E0", Offset = "0x27028E0", VA = "0x1827042E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000095 RID: 149 RVA: 0x000023E4 File Offset: 0x000005E4
		// (set) Token: 0x06000096 RID: 150 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000029")]
		public int VertexCount
		{
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x27042F0", Offset = "0x27028F0", VA = "0x1827042F0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x2704300", Offset = "0x2702900", VA = "0x182704300")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000097 RID: 151 RVA: 0x000023FC File Offset: 0x000005FC
		[Token(Token = "0x1700002A")]
		public int ActiveTriCount
		{
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x2704310", Offset = "0x2702910", VA = "0x182704310")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00002414 File Offset: 0x00000614
		[Token(Token = "0x1700002B")]
		public int ActiveUnderwaterTriCount
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x2704480", Offset = "0x2702A80", VA = "0x182704480")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000099 RID: 153 RVA: 0x0000242C File Offset: 0x0000062C
		[Token(Token = "0x1700002C")]
		public int ActiveAboveWaterTriCount
		{
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x27045F0", Offset = "0x2702BF0", VA = "0x1827045F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00002444 File Offset: 0x00000644
		[Token(Token = "0x1700002D")]
		public int DisabledTriCount
		{
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x2704760", Offset = "0x2702D60", VA = "0x182704760")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600009B RID: 155 RVA: 0x0000245C File Offset: 0x0000065C
		[Token(Token = "0x1700002E")]
		public int DestroyedTriCount
		{
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x27048D0", Offset = "0x2702ED0", VA = "0x1827048D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00002474 File Offset: 0x00000674
		[Token(Token = "0x1700002F")]
		public int InactiveTriCount
		{
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x2704A40", Offset = "0x2703040", VA = "0x182704A40")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x2704BB0", Offset = "0x27031B0", VA = "0x182704BB0")]
		private void Initialize()
		{
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x2706F90", Offset = "0x2705590", VA = "0x182706F90")]
		private void Awake()
		{
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x27070D0", Offset = "0x27056D0", VA = "0x1827070D0")]
		private void Start()
		{
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x27070E0", Offset = "0x27056E0", VA = "0x1827070E0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x2707180", Offset = "0x2705780", VA = "0x182707180")]
		private void OnDisable()
		{
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x2707190", Offset = "0x2705790", VA = "0x182707190")]
		public void Synchronize()
		{
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x27071C0", Offset = "0x27057C0", VA = "0x1827071C0")]
		public void MarkTrisAsDeleted(int triStartIndex, int triEndIndex)
		{
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x2707210", Offset = "0x2705810", VA = "0x182707210")]
		public void MarkTrisAsDisabled(int triStartIndex, int triEndIndex)
		{
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x2707260", Offset = "0x2705860", VA = "0x182707260")]
		public void MarkTrisAsEnabled(int triStartIndex, int triEndIndex)
		{
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x27072B0", Offset = "0x27058B0", VA = "0x1827072B0")]
		private void OnValidate()
		{
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x2707180", Offset = "0x2705780", VA = "0x182707180")]
		private void OnDestroy()
		{
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x2707340", Offset = "0x2705940", VA = "0x182707340")]
		private void FindSceneWaterObjects(ref List<WaterObject> waterObjects, bool includeInactive)
		{
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x2707710", Offset = "0x2705D10", VA = "0x182707710")]
		private void Schedule()
		{
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x2708400", Offset = "0x2706A00", VA = "0x182708400")]
		private void Process()
		{
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x2708870", Offset = "0x2706E70", VA = "0x182708870")]
		private void Finish()
		{
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AC")]
		private static void FastCopy<T>(T[] source, T[] destination) where T : struct
		{
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x27088B0", Offset = "0x2706EB0", VA = "0x1827088B0")]
		private void DeallocateNativeContainers()
		{
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x2708AF0", Offset = "0x27070F0", VA = "0x182708AF0")]
		public WaterObjectManager()
		{
		}

		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x0")]
		public static WaterObjectManager Instance;

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x20")]
		public bool includeMultipleScenes;

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x21")]
		public bool calculateBuoyancyForces;

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x22")]
		public bool calculateDynamicForces;

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x23")]
		public bool calculateSkinDrag;

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x24")]
		[Range(0.5f, 2f)]
		public float dynamicForceCoefficient;

		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x28")]
		[Range(0.5f, 2f)]
		public float dynamicForcePower;

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x2C")]
		public float fluidDensity;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x30")]
		[HideInInspector]
		public UnityEvent onSynchronize;

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x38")]
		public bool simulateWaterFlow;

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x39")]
		public bool simulateWaterNormals;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x3C")]
		[Range(0f, 0.2f)]
		public float skinFrictionDrag;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x40")]
		[Range(0.5f, 2f)]
		public float velocityDotPower;

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x44")]
		public bool includeInactive;

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x45")]
		public bool finishJobsInOneFrame;

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x48")]
		private Vector3[] _objRigidbodyAngVels;

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x50")]
		private Vector3[] _objRigidbodyCoMs;

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x58")]
		private Vector3[] _objRigidbodyLinVels;

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x60")]
		private int[] _woIndices;

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x68")]
		private int[] _woTriDataStart;

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x70")]
		private int[] _woTriDataEnd;

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x78")]
		private int[] _woVertDataStart;

		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x80")]
		private int[] _woVertDataEnd;

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x88")]
		private float[] _objDynamicForceCoeffs;

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x90")]
		private float[] _objDynamicForcePowerCoeffs;

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x98")]
		private float[] _objSkinFrictionDragCoeffs;

		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0xA0")]
		private float[] _triAreas;

		// Token: 0x04000083 RID: 131
		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0xA8")]
		private float[] _triDistToSurface;

		// Token: 0x04000084 RID: 132
		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0xB0")]
		private bool _finished;

		// Token: 0x04000085 RID: 133
		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0xB8")]
		private Vector3[] _triForcePoints;

		// Token: 0x04000086 RID: 134
		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0xC0")]
		private bool _initialized;

		// Token: 0x04000087 RID: 135
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0xC8")]
		private int[] _triangles;

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0xD0")]
		private Vector3[] _vertices;

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0xD8")]
		private Vector3[] _triNormals;

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0xE0")]
		private Vector3[] _triForces;

		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0xE8")]
		private bool _scheduled;

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0xF0")]
		private byte[] _triStates;

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0xF8")]
		private Vector3[] _triVelocities;

		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0x100")]
		private Vector3[] _waterFlows;

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x108")]
		private float[] _waterHeights;

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x110")]
		private JobHandle _waterJobHandle;

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x120")]
		private Vector3[] _waterNormals;

		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x128")]
		private List<WaterObject> _waterObjects;

		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0x130")]
		private WaterTriangleJob _waterTriJob;

		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0x2C0")]
		private Vector3[] _worldVerts;
	}
}
