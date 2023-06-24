using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;

namespace FluidSimulation
{
	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	public class FluidSimulator : MonoBehaviour
	{
		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00002688 File Offset: 0x00000888
		// (set) Token: 0x0600009B RID: 155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003B")]
		public bool Initialized
		{
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x671150", Offset = "0x66F750", VA = "0x180671150")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x671160", Offset = "0x66F760", VA = "0x180671160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009C")]
		[Address(RVA = "0xB01010", Offset = "0xAFF610", VA = "0x180B01010")]
		public void UpdateGravity(Vector3 gravity, Space space = Space.World)
		{
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009D")]
		[Address(RVA = "0xB012E0", Offset = "0xAFF8E0", VA = "0x180B012E0")]
		public void updateFlowMap()
		{
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009E")]
		[Address(RVA = "0xB01850", Offset = "0xAFFE50", VA = "0x180B01850")]
		public void ResetFluid()
		{
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x750FA0", Offset = "0x74F5A0", VA = "0x180750FA0")]
		public RenderTexture GetFluidTexture()
		{
			return null;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000026A0 File Offset: 0x000008A0
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xB01B30", Offset = "0xB00130", VA = "0x180B01B30")]
		public UV GetUVChanel()
		{
			return UV.UV1;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000026B8 File Offset: 0x000008B8
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xB01B50", Offset = "0xB00150", VA = "0x180B01B50")]
		public bool isSkinned()
		{
			return default(bool);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xB01CE0", Offset = "0xB002E0", VA = "0x180B01CE0")]
		public void SetMaterialData(Renderer renderer)
		{
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000026D0 File Offset: 0x000008D0
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xB01EE0", Offset = "0xB004E0", VA = "0x180B01EE0")]
		public bool isSimulatorActive()
		{
			return default(bool);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xB01FD0", Offset = "0xB005D0", VA = "0x180B01FD0")]
		private void Awake()
		{
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xB025B0", Offset = "0xB00BB0", VA = "0x180B025B0")]
		public void Init()
		{
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xB02690", Offset = "0xB00C90", VA = "0x180B02690")]
		private IEnumerator DecompressFluidObject()
		{
			return null;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xB02720", Offset = "0xB00D20", VA = "0x180B02720")]
		private void initialize()
		{
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0xB028F0", Offset = "0xB00EF0", VA = "0x180B028F0")]
		private void setupShaderData(FluidSimulationManager simManager)
		{
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xB03670", Offset = "0xB01C70", VA = "0x180B03670")]
		private void LoadTexelData()
		{
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0xB03A40", Offset = "0xB02040", VA = "0x180B03A40")]
		public void cacheBoneIds(Transform[] cacheBones)
		{
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000026E8 File Offset: 0x000008E8
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xB03C00", Offset = "0xB02200", VA = "0x180B03C00")]
		public int getBoneId(Transform bone)
		{
			return 0;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xB03CE0", Offset = "0xB022E0", VA = "0x180B03CE0")]
		private void simulationCycle()
		{
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xB03D60", Offset = "0xB02360", VA = "0x180B03D60")]
		public void SimulateFlow()
		{
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xB042D0", Offset = "0xB028D0", VA = "0x180B042D0")]
		private void calculateDrop()
		{
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xB04740", Offset = "0xB02D40", VA = "0x180B04740")]
		private IEnumerator dropReadback(AsyncGPUReadbackRequest requestCount)
		{
			return null;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xB047F0", Offset = "0xB02DF0", VA = "0x180B047F0")]
		private void Update()
		{
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xB04950", Offset = "0xB02F50", VA = "0x180B04950")]
		private void evaporateFluid()
		{
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xB04D70", Offset = "0xB03370", VA = "0x180B04D70")]
		private RenderTexture getTemporaryRT(RenderTextureDescriptor desc)
		{
			return null;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xB04EE0", Offset = "0xB034E0", VA = "0x180B04EE0")]
		public void DrawTexture(Vector3 position, Vector3 forward, Vector3 up, Texture2D brushTexture, float brushSize, float brushDepth, float amount, Space space = Space.World)
		{
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xB055C0", Offset = "0xB03BC0", VA = "0x180B055C0")]
		public void SkinnedDrawTexture(Transform bone, Vector3 position, Vector3 forward, Vector3 up, Texture2D brushTexture, float brushSize, float brushDepth, float amount, Space space = Space.World)
		{
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xB05A00", Offset = "0xB04000", VA = "0x180B05A00")]
		public void DrawSphere(Vector3 center, float radius, float amount, Space space = Space.World)
		{
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xB05E10", Offset = "0xB04410", VA = "0x180B05E10")]
		public void SkinnedDrawSphere(Transform bone, Vector3 center, float radius, float amount, Space space = Space.World)
		{
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xB06020", Offset = "0xB04620", VA = "0x180B06020")]
		public void DrawDisc(Vector3 center, Vector3 normal, float radius, float depth, float amount, Space space = Space.World)
		{
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xB06540", Offset = "0xB04B40", VA = "0x180B06540")]
		public void SkinnedDrawDisc(Transform bone, Vector3 center, Vector3 normal, float radius, float depth, float amount, Space space = Space.World)
		{
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xB06850", Offset = "0xB04E50", VA = "0x180B06850")]
		private void AddedNewFluid()
		{
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xB06870", Offset = "0xB04E70", VA = "0x180B06870")]
		private void OnDestroy()
		{
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xB06BB0", Offset = "0xB051B0", VA = "0x180B06BB0")]
		public FluidSimulator()
		{
		}

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x20")]
		public FluidObject fluidObject;

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x28")]
		public Renderer fluidRenderer;

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x30")]
		public int timeout;

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x34")]
		[Range(0f, 2f)]
		public float speed;

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x38")]
		public Texture2D normalMap;

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float normal;

		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		public float slope;

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x48")]
		public float roughness;

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x4C")]
		public float dryTime;

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x50")]
		public bool useFluidEvapoation;

		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x54")]
		public float evaporationPerSecond;

		// Token: 0x04000083 RID: 131
		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x58")]
		public bool checkForDrops;

		// Token: 0x04000084 RID: 132
		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x5C")]
		public float minimumDripAmount;

		// Token: 0x04000085 RID: 133
		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x60")]
		public int dropUpdateSkipAmount;

		// Token: 0x04000086 RID: 134
		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x68")]
		public FluidSimulator.DripEvent OnFluidDrip;

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x71")]
		[NonSerialized]
		public bool DebugDrawFlowTex;

		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		[FieldOffset(Offset = "0x78")]
		private Material DebugMat;

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x80")]
		private ComputeShader flowShader;

		// Token: 0x0400008B RID: 139
		[Token(Token = "0x400008B")]
		[FieldOffset(Offset = "0x88")]
		private RenderTexture texelTex;

		// Token: 0x0400008C RID: 140
		[Token(Token = "0x400008C")]
		[FieldOffset(Offset = "0x90")]
		private RenderTexture fluidTex;

		// Token: 0x0400008D RID: 141
		[Token(Token = "0x400008D")]
		[FieldOffset(Offset = "0x98")]
		private RenderTexture finTex;

		// Token: 0x0400008E RID: 142
		[Token(Token = "0x400008E")]
		[FieldOffset(Offset = "0xA0")]
		private RenderTexture flowTex;

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0xA8")]
		private ComputeBuffer texelBuf;

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0xB0")]
		private ComputeBuffer fluidBuf;

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0xB8")]
		private ComputeBuffer tangentBuffer;

		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0xC0")]
		private ComputeBuffer boundsBuffer;

		// Token: 0x04000093 RID: 147
		[Token(Token = "0x4000093")]
		[FieldOffset(Offset = "0xC8")]
		private ComputeBuffer gravityBuffer;

		// Token: 0x04000094 RID: 148
		[Token(Token = "0x4000094")]
		[FieldOffset(Offset = "0xD0")]
		private ComputeBuffer dropBuffer;

		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		[FieldOffset(Offset = "0xD8")]
		private ComputeBuffer countBuffer;

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0xE0")]
		private RenderTextureDescriptor fluidTexDescriptor;

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0x114")]
		private RenderTextureDescriptor flowTexDescriptor;

		// Token: 0x04000098 RID: 152
		[Token(Token = "0x4000098")]
		[FieldOffset(Offset = "0x148")]
		private Transform rendererTransform;

		// Token: 0x04000099 RID: 153
		[Token(Token = "0x4000099")]
		[FieldOffset(Offset = "0x150")]
		private Transform[] bones;

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x158")]
		private Dictionary<Transform, int> boneIdMap;

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		[FieldOffset(Offset = "0x160")]
		private int texSize;

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		[FieldOffset(Offset = "0x164")]
		private int groupCount;

		// Token: 0x0400009D RID: 157
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x168")]
		private int groupCountDrop;

		// Token: 0x0400009E RID: 158
		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x170")]
		private FluidSimulationManager simManager;

		// Token: 0x0400009F RID: 159
		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x178")]
		private int updateCounter;

		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x17C")]
		private int skippedDropUpdates;

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x180")]
		private float deltaTime;

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x184")]
		private bool isInUpdateQueue;

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x188")]
		private Vector3 localGravity;

		// Token: 0x040000A4 RID: 164
		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x194")]
		private float totalMaxFluid;

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x198")]
		private float evapAmount;

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x19C")]
		private float timeTillDry;

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		private const float HalfInv = 1.5259022E-05f;

		// Token: 0x02000010 RID: 16
		[Token(Token = "0x2000010")]
		[Serializable]
		public class DripEvent : UnityEvent<Vector3, float>
		{
			// Token: 0x060000BC RID: 188 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0xB06C40", Offset = "0xB05240", VA = "0x180B06C40")]
			public DripEvent()
			{
			}
		}

		// Token: 0x02000011 RID: 17
		[Token(Token = "0x2000011")]
		private struct uint2
		{
			// Token: 0x060000BD RID: 189 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x60DE80", Offset = "0x60C480", VA = "0x18060DE80")]
			public uint2(uint x, uint y)
			{
			}

			// Token: 0x040000A8 RID: 168
			[Token(Token = "0x40000A8")]
			[FieldOffset(Offset = "0x0")]
			public uint x;

			// Token: 0x040000A9 RID: 169
			[Token(Token = "0x40000A9")]
			[FieldOffset(Offset = "0x4")]
			public uint y;
		}
	}
}
