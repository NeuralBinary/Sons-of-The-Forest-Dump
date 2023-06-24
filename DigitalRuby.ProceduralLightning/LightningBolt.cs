using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x0200001C RID: 28
	[Token(Token = "0x200001C")]
	public class LightningBolt
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600006E RID: 110 RVA: 0x0000218C File Offset: 0x0000038C
		// (set) Token: 0x0600006F RID: 111 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000D")]
		public float MinimumDelay
		{
			[Token(Token = "0x600006E")]
			[Address(RVA = "0xA308D0", Offset = "0xA2EED0", VA = "0x180A308D0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600006F")]
			[Address(RVA = "0xA308E0", Offset = "0xA2EEE0", VA = "0x180A308E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000070 RID: 112 RVA: 0x000021A4 File Offset: 0x000003A4
		// (set) Token: 0x06000071 RID: 113 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700000E")]
		public bool HasGlow
		{
			[Token(Token = "0x6000070")]
			[Address(RVA = "0x5FD560", Offset = "0x5FBB60", VA = "0x1805FD560")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x5FD570", Offset = "0x5FBB70", VA = "0x1805FD570")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000072 RID: 114 RVA: 0x000021BC File Offset: 0x000003BC
		[Token(Token = "0x1700000F")]
		public bool IsActive
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0xA308F0", Offset = "0xA2EEF0", VA = "0x180A308F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000073 RID: 115 RVA: 0x000021D4 File Offset: 0x000003D4
		// (set) Token: 0x06000074 RID: 116 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000010")]
		public CameraMode CameraMode
		{
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
			[CompilerGenerated]
			get
			{
				return CameraMode.Auto;
			}
			[Token(Token = "0x6000074")]
			[Address(RVA = "0x6DDE70", Offset = "0x6DC470", VA = "0x1806DDE70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000075")]
		[Address(RVA = "0xA30900", Offset = "0xA2EF00", VA = "0x180A30900")]
		public LightningBolt()
		{
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000076")]
		[Address(RVA = "0xA30AC0", Offset = "0xA2F0C0", VA = "0x180A30AC0")]
		public void SetupLightningBolt(LightningBoltDependencies dependencies)
		{
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000021EC File Offset: 0x000003EC
		[Token(Token = "0x6000077")]
		[Address(RVA = "0xA30CB0", Offset = "0xA2F2B0", VA = "0x180A30CB0")]
		public bool Update()
		{
			return default(bool);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000078")]
		[Address(RVA = "0xA30D70", Offset = "0xA2F370", VA = "0x180A30D70")]
		public void Cleanup()
		{
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000079")]
		[Address(RVA = "0xA316E0", Offset = "0xA2FCE0", VA = "0x180A316E0")]
		public LightningBoltSegmentGroup AddGroup()
		{
			return null;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007A")]
		[Address(RVA = "0xA31C90", Offset = "0xA30290", VA = "0x180A31C90")]
		public static void ClearCache()
		{
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007B")]
		[Address(RVA = "0xA322F0", Offset = "0xA308F0", VA = "0x180A322F0")]
		private void CleanupLight(Light l)
		{
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007C")]
		[Address(RVA = "0xA324E0", Offset = "0xA30AE0", VA = "0x180A324E0")]
		private void EnableLineRenderer(LightningBolt.LineRendererMesh lineRenderer, int tag)
		{
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600007D")]
		[Address(RVA = "0xA32660", Offset = "0xA30C60", VA = "0x180A32660")]
		private IEnumerator EnableLastRendererCoRoutine()
		{
			return null;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600007E")]
		[Address(RVA = "0xA326F0", Offset = "0xA30CF0", VA = "0x180A326F0")]
		private LightningBolt.LineRendererMesh GetOrCreateLineRenderer()
		{
			return null;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600007F")]
		[Address(RVA = "0xA332D0", Offset = "0xA318D0", VA = "0x180A332D0")]
		private void RenderGroup(LightningBoltSegmentGroup group, LightningBoltParameters p)
		{
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000080")]
		[Address(RVA = "0xA33AC0", Offset = "0xA320C0", VA = "0x180A33AC0")]
		private static IEnumerator NotifyBolt(LightningBoltDependencies dependencies, LightningBoltParameters p, Transform transform, Vector3 start, Vector3 end)
		{
			return null;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000081")]
		[Address(RVA = "0xA33C50", Offset = "0xA32250", VA = "0x180A33C50")]
		private void ProcessParameters(LightningBoltParameters p, RangeOfFloats delay, LightningBoltDependencies depends)
		{
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000082")]
		[Address(RVA = "0xA34230", Offset = "0xA32830", VA = "0x180A34230")]
		private void ProcessAllLightningParameters()
		{
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000083")]
		[Address(RVA = "0xA34C90", Offset = "0xA33290", VA = "0x180A34C90")]
		private void EnableCurrentLineRendererFromThread(bool inDestroy)
		{
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000084")]
		[Address(RVA = "0xA34DC0", Offset = "0xA333C0", VA = "0x180A34DC0")]
		private void EnableCurrentLineRenderer()
		{
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000085")]
		[Address(RVA = "0xA34F40", Offset = "0xA33540", VA = "0x180A34F40")]
		private void RenderParticleSystems(Vector3 start, Vector3 end, float trunkWidth, float lifeTime, float delaySeconds)
		{
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000086")]
		[Address(RVA = "0xA351A0", Offset = "0xA337A0", VA = "0x180A351A0")]
		private Transform RenderLightningBolt(LightningBoltQualitySetting quality, int generations, int startGroupIndex, int endGroupIndex, LightningBoltParameters parameters)
		{
			return null;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000087")]
		[Address(RVA = "0xA35D40", Offset = "0xA34340", VA = "0x180A35D40")]
		private void CreateLightsForGroup(LightningBoltSegmentGroup group, LightningLightParameters lp, LightningBoltQualitySetting quality, int maxLights)
		{
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002204 File Offset: 0x00000404
		[Token(Token = "0x6000088")]
		[Address(RVA = "0xA36090", Offset = "0xA34690", VA = "0x180A36090")]
		private bool AddLightToGroup(LightningBoltSegmentGroup group, LightningLightParameters lp, int segmentIndex, int nthLight, int nthShadows, ref int maxLights, ref int nthShadowCounter)
		{
			return default(bool);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000089")]
		[Address(RVA = "0xA36580", Offset = "0xA34B80", VA = "0x180A36580")]
		private Light GetOrCreateLight(LightningLightParameters lp)
		{
			return null;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600008A")]
		[Address(RVA = "0xA36C80", Offset = "0xA35280", VA = "0x180A36C80")]
		private void UpdateLight(LightningLightParameters lp, IEnumerable<Light> lights, float delay, float peakStart, float peakEnd, float lifeTime)
		{
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600008B")]
		[Address(RVA = "0xA37290", Offset = "0xA35890", VA = "0x180A37290")]
		private void UpdateLights()
		{
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600008C")]
		[Address(RVA = "0xA37410", Offset = "0xA35A10", VA = "0x180A37410")]
		private IEnumerator GenerateParticleCoRoutine(ParticleSystem p, Vector3 pos, float delay)
		{
			return null;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600008D")]
		[Address(RVA = "0xA374D0", Offset = "0xA35AD0", VA = "0x180A374D0")]
		private void CheckForGlow(IEnumerable<LightningBoltParameters> parameters)
		{
		}

		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x0")]
		public static int MaximumLightCount;

		// Token: 0x040000D5 RID: 213
		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x4")]
		public static int MaximumLightsPerBatch;

		// Token: 0x040000D9 RID: 217
		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x20")]
		private DateTime startTimeOffset;

		// Token: 0x040000DA RID: 218
		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x28")]
		private LightningBoltDependencies dependencies;

		// Token: 0x040000DB RID: 219
		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x30")]
		private float elapsedTime;

		// Token: 0x040000DC RID: 220
		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x34")]
		private float lifeTime;

		// Token: 0x040000DD RID: 221
		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x38")]
		private float maxLifeTime;

		// Token: 0x040000DE RID: 222
		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x3C")]
		private bool hasLight;

		// Token: 0x040000DF RID: 223
		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x40")]
		private float timeSinceLevelLoad;

		// Token: 0x040000E0 RID: 224
		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x48")]
		private readonly List<LightningBoltSegmentGroup> segmentGroups;

		// Token: 0x040000E1 RID: 225
		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x50")]
		private readonly List<LightningBoltSegmentGroup> segmentGroupsWithLight;

		// Token: 0x040000E2 RID: 226
		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x58")]
		private readonly List<LightningBolt.LineRendererMesh> activeLineRenderers;

		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x8")]
		private static int lightCount;

		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x10")]
		private static readonly List<LightningBolt.LineRendererMesh> lineRendererCache;

		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x18")]
		private static readonly List<LightningBoltSegmentGroup> groupCache;

		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x20")]
		private static readonly List<Light> lightCache;

		// Token: 0x0200001D RID: 29
		[Token(Token = "0x200001D")]
		public class LineRendererMesh
		{
			// Token: 0x17000011 RID: 17
			// (get) Token: 0x0600008F RID: 143 RVA: 0x000020AE File Offset: 0x000002AE
			// (set) Token: 0x06000090 RID: 144 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000011")]
			public GameObject GameObject
			{
				[Token(Token = "0x600008F")]
				[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000090")]
				[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x06000091 RID: 145 RVA: 0x000020AE File Offset: 0x000002AE
			// (set) Token: 0x06000092 RID: 146 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000012")]
			public Material MaterialGlow
			{
				[Token(Token = "0x6000091")]
				[Address(RVA = "0xA378C0", Offset = "0xA35EC0", VA = "0x180A378C0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000092")]
				[Address(RVA = "0xA37920", Offset = "0xA35F20", VA = "0x180A37920")]
				set
				{
				}
			}

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x06000093 RID: 147 RVA: 0x000020AE File Offset: 0x000002AE
			// (set) Token: 0x06000094 RID: 148 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000013")]
			public Material MaterialBolt
			{
				[Token(Token = "0x6000093")]
				[Address(RVA = "0xA37990", Offset = "0xA35F90", VA = "0x180A37990")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000094")]
				[Address(RVA = "0xA379F0", Offset = "0xA35FF0", VA = "0x180A379F0")]
				set
				{
				}
			}

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x06000095 RID: 149 RVA: 0x000020AE File Offset: 0x000002AE
			[Token(Token = "0x17000014")]
			public MeshRenderer MeshRendererGlow
			{
				[Token(Token = "0x6000095")]
				[Address(RVA = "0x750FA0", Offset = "0x74F5A0", VA = "0x180750FA0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x06000096 RID: 150 RVA: 0x000020AE File Offset: 0x000002AE
			[Token(Token = "0x17000015")]
			public MeshRenderer MeshRendererBolt
			{
				[Token(Token = "0x6000096")]
				[Address(RVA = "0x737420", Offset = "0x735A20", VA = "0x180737420")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x06000097 RID: 151 RVA: 0x0000221C File Offset: 0x0000041C
			// (set) Token: 0x06000098 RID: 152 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000016")]
			public int Tag
			{
				[Token(Token = "0x6000097")]
				[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6000098")]
				[Address(RVA = "0x6DDE70", Offset = "0x6DC470", VA = "0x1806DDE70")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x06000099 RID: 153 RVA: 0x000020AE File Offset: 0x000002AE
			// (set) Token: 0x0600009A RID: 154 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000017")]
			public Action<LightningCustomTransformStateInfo> CustomTransform
			{
				[Token(Token = "0x6000099")]
				[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600009A")]
				[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x0600009B RID: 155 RVA: 0x000020AE File Offset: 0x000002AE
			// (set) Token: 0x0600009C RID: 156 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x17000018")]
			public Transform Transform
			{
				[Token(Token = "0x600009B")]
				[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600009C")]
				[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x0600009D RID: 157 RVA: 0x00002234 File Offset: 0x00000434
			[Token(Token = "0x17000019")]
			public bool Empty
			{
				[Token(Token = "0x600009D")]
				[Address(RVA = "0xA37A60", Offset = "0xA36060", VA = "0x180A37A60")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600009E RID: 158 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600009E")]
			[Address(RVA = "0xA37AB0", Offset = "0xA360B0", VA = "0x180A37AB0")]
			public LineRendererMesh()
			{
			}

			// Token: 0x0600009F RID: 159 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600009F")]
			[Address(RVA = "0xA38AA0", Offset = "0xA370A0", VA = "0x180A38AA0")]
			public void PopulateMesh()
			{
			}

			// Token: 0x060000A0 RID: 160 RVA: 0x0000224C File Offset: 0x0000044C
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0xA38B40", Offset = "0xA37140", VA = "0x180A38B40")]
			public bool PrepareForLines(int lineCount)
			{
				return default(bool);
			}

			// Token: 0x060000A1 RID: 161 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0xA38BA0", Offset = "0xA371A0", VA = "0x180A38BA0")]
			public void BeginLine(Vector3 start, Vector3 end, float radius, Color32 color, float colorIntensity, Vector4 fadeLifeTime, float glowWidthModifier, float glowIntensity)
			{
			}

			// Token: 0x060000A2 RID: 162 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0xA38C70", Offset = "0xA37270", VA = "0x180A38C70")]
			public void AppendLine(Vector3 start, Vector3 end, float radius, Color32 color, float colorIntensity, Vector4 fadeLifeTime, float glowWidthModifier, float glowIntensity)
			{
			}

			// Token: 0x060000A3 RID: 163 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0xA38E50", Offset = "0xA37450", VA = "0x180A38E50")]
			public void Reset()
			{
			}

			// Token: 0x060000A4 RID: 164 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0xA39050", Offset = "0xA37650", VA = "0x180A39050")]
			private void PopulateMeshInternal()
			{
			}

			// Token: 0x060000A5 RID: 165 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0xA394C0", Offset = "0xA37AC0", VA = "0x180A394C0")]
			private void UpdateBounds(ref Vector3 point1, ref Vector3 point2)
			{
			}

			// Token: 0x060000A6 RID: 166 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0xA395D0", Offset = "0xA37BD0", VA = "0x180A395D0")]
			private void AddIndices()
			{
			}

			// Token: 0x060000A7 RID: 167 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0xA39860", Offset = "0xA37E60", VA = "0x180A39860")]
			private void AppendLineInternal(ref Vector3 start, ref Vector3 end, ref Vector4 dir, ref Vector4 dirPrev1, ref Vector4 dirPrev2, Color32 color, float colorIntensity, ref Vector4 fadeLifeTime, float glowWidthModifier, float glowIntensity)
			{
			}

			// Token: 0x040000EB RID: 235
			[Token(Token = "0x40000EB")]
			private const int defaultListCapacity = 2048;

			// Token: 0x040000EC RID: 236
			[Token(Token = "0x40000EC")]
			[FieldOffset(Offset = "0x0")]
			private static readonly Vector2 uv1;

			// Token: 0x040000ED RID: 237
			[Token(Token = "0x40000ED")]
			[FieldOffset(Offset = "0x8")]
			private static readonly Vector2 uv2;

			// Token: 0x040000EE RID: 238
			[Token(Token = "0x40000EE")]
			[FieldOffset(Offset = "0x10")]
			private static readonly Vector2 uv3;

			// Token: 0x040000EF RID: 239
			[Token(Token = "0x40000EF")]
			[FieldOffset(Offset = "0x18")]
			private static readonly Vector2 uv4;

			// Token: 0x040000F0 RID: 240
			[Token(Token = "0x40000F0")]
			[FieldOffset(Offset = "0x30")]
			private readonly List<int> indices;

			// Token: 0x040000F1 RID: 241
			[Token(Token = "0x40000F1")]
			[FieldOffset(Offset = "0x38")]
			private readonly List<Vector3> vertices;

			// Token: 0x040000F2 RID: 242
			[Token(Token = "0x40000F2")]
			[FieldOffset(Offset = "0x40")]
			private readonly List<Vector4> lineDirs;

			// Token: 0x040000F3 RID: 243
			[Token(Token = "0x40000F3")]
			[FieldOffset(Offset = "0x48")]
			private readonly List<Color32> colors;

			// Token: 0x040000F4 RID: 244
			[Token(Token = "0x40000F4")]
			[FieldOffset(Offset = "0x50")]
			private readonly List<Vector3> ends;

			// Token: 0x040000F5 RID: 245
			[Token(Token = "0x40000F5")]
			[FieldOffset(Offset = "0x58")]
			private readonly List<Vector4> texCoordsAndGlowModifiers;

			// Token: 0x040000F6 RID: 246
			[Token(Token = "0x40000F6")]
			[FieldOffset(Offset = "0x60")]
			private readonly List<Vector4> fadeLifetimes;

			// Token: 0x040000F7 RID: 247
			[Token(Token = "0x40000F7")]
			private const int boundsPadder = 1000000000;

			// Token: 0x040000F8 RID: 248
			[Token(Token = "0x40000F8")]
			[FieldOffset(Offset = "0x68")]
			private int currentBoundsMinX;

			// Token: 0x040000F9 RID: 249
			[Token(Token = "0x40000F9")]
			[FieldOffset(Offset = "0x6C")]
			private int currentBoundsMinY;

			// Token: 0x040000FA RID: 250
			[Token(Token = "0x40000FA")]
			[FieldOffset(Offset = "0x70")]
			private int currentBoundsMinZ;

			// Token: 0x040000FB RID: 251
			[Token(Token = "0x40000FB")]
			[FieldOffset(Offset = "0x74")]
			private int currentBoundsMaxX;

			// Token: 0x040000FC RID: 252
			[Token(Token = "0x40000FC")]
			[FieldOffset(Offset = "0x78")]
			private int currentBoundsMaxY;

			// Token: 0x040000FD RID: 253
			[Token(Token = "0x40000FD")]
			[FieldOffset(Offset = "0x7C")]
			private int currentBoundsMaxZ;

			// Token: 0x040000FE RID: 254
			[Token(Token = "0x40000FE")]
			[FieldOffset(Offset = "0x80")]
			private Mesh mesh;

			// Token: 0x040000FF RID: 255
			[Token(Token = "0x40000FF")]
			[FieldOffset(Offset = "0x88")]
			private MeshFilter meshFilterGlow;

			// Token: 0x04000100 RID: 256
			[Token(Token = "0x4000100")]
			[FieldOffset(Offset = "0x90")]
			private MeshFilter meshFilterBolt;

			// Token: 0x04000101 RID: 257
			[Token(Token = "0x4000101")]
			[FieldOffset(Offset = "0x98")]
			private MeshRenderer meshRendererGlow;

			// Token: 0x04000102 RID: 258
			[Token(Token = "0x4000102")]
			[FieldOffset(Offset = "0xA0")]
			private MeshRenderer meshRendererBolt;
		}
	}
}
